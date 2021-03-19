using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmAddNewEmployee
    {
        public FrmAddNewEmployee()
        {
            InitializeComponent();
            _phoneNumberTextBox.Name = "phoneNumberTextBox";
            _firstNameTextBox.Name = "firstNameTextBox";
            _skillsCertificationButton.Name = "skillsCertificationButton";
            _firstAidCheckBox.Name = "firstAidCheckBox";
            _otherCheckBox.Name = "otherCheckBox";
            _emergencyPhoneNumberTextBox.Name = "emergencyPhoneNumberTextBox";
            _FinishButton.Name = "FinishButton";
            _personalInfoButton.Name = "personalInfoButton";
            _uploadPhotoButton.Name = "uploadPhotoButton";
            _newEmployeeTabControl.Name = "newEmployeeTabControl";
        }

        private object _cardID { get; set; } = "";

        private DatabaseHelper db = new DatabaseHelper();
        private string _employeeFirstName;
        private string _employeeLasttName;
        private int _employeeID;
        private string _alias;
        public string remoteFtpPath;
        private string pictureExtendsion;
        private string PictureLocalPath;
        public string OldPictureRemotelPath;

        private void Key_press_KeyDown(object sender, KeyEventArgs e)
        {
            if (newEmployeeTabControl.SelectedIndex == 2)
            {
                if (e.KeyCode != Keys.ShiftKey)
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        _cardID = _cardID.ToString().Substring(1, 12);
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(db.cardAlreadyAssigned(Conversions.ToString(_cardID)), false, false)))
                        {
                            MdlControllerModifier.warning("card available", titleScanLabel);
                            ScanCardPictureBox.BackgroundImage = My.Resources.Resources.icon_available;
                            FinishButton.Text = "Finish";
                        }
                        else
                        {
                            MdlControllerModifier.warning("card not available", titleScanLabel);
                            _cardID = "";
                            ScanCardPictureBox.BackgroundImage = My.Resources.Resources.icon_not_available;
                        }
                    }
                    else
                    {
                        _cardID += e.KeyCode.ToString().Substring(1, 1);
                    }
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var ftpModule = new MdlFtp();
            string imageName;
            if (string.IsNullOrEmpty(firstNameTextBox.Text) | string.IsNullOrEmpty(lastNameLabel.Text) | typeComboBox.SelectedIndex == -1 | yardComboBox.SelectedIndex == -1 | genderComboBox.SelectedIndex == -1 | string.IsNullOrEmpty(jobDescriptionComboBox.Text) | payMehodComboBox.SelectedIndex == -1)
            {
                MdlControllerModifier.warning("incomplete information", titlePersonalInfoLabel);
            }
            else if (personalInfoButton.Text.Equals("Save and Continue"))
            {
                if (!Information.IsNothing(remoteFtpPath) && remoteFtpPath.Equals(""))
                {
                    imageName = Strings.Trim(aliasTextBox.Text).Replace("/", "").Replace(@"\", "").Replace(" ", "") + DateAndTime.Now.ToString("dd-MMMd-yyyy_HHmmss") + pictureExtendsion;
                    remoteFtpPath = "/Operations/EmployeeManagement/EmployeePictures/";
                    ftpModule.uploadFtpFile(PictureLocalPath, remoteFtpPath, imageName);
                }
                else
                {
                    remoteFtpPath = "";
                }

                if (Conversions.ToBoolean(db.saveEmployee()))
                {
                    if (!newEmployeeTabControl.TabPages.Contains(certificationsTabPage))
                    {
                        newEmployeeTabControl.TabPages.Add(certificationsTabPage);
                        newEmployeeTabControl.SelectTab(1);
                    }

                    _employeeFirstName = firstNameTextBox.Text;
                    _employeeLasttName = lastNameTextBox.Text;
                    _alias = aliasTextBox.Text;
                    SkillsCertificationPictureBox.BackgroundImage = employeePictureBox.BackgroundImage;
                    titlePersonalInfoLabel.ForeColor = Color.FromArgb(64, 64, 64);
                    titlePersonalInfoLabel.Text = "Fill up all that apply";
                }
                else
                {
                    MdlControllerModifier.warning("user already exists", titlePersonalInfoLabel);
                }
            }
            else
            {
                if (!PictureLocalPath.Equals(""))
                {
                    imageName = Strings.Trim(aliasTextBox.Text).Replace("/", "").Replace(@"\", "").Replace(" ", "") + DateAndTime.Now.ToString("dd-MMMd-yyyy_HHmmss") + pictureExtendsion;
                    remoteFtpPath = "/Operations/EmployeeManagement/EmployeePictures/" + imageName;
                    if ((OldPictureRemotelPath ?? "") != (remoteFtpPath ?? "") && !OldPictureRemotelPath.Equals(""))
                    {
                        ftpModule.deleteFTPImage(OldPictureRemotelPath);
                    }

                    ftpModule.uploadFtpFile(PictureLocalPath, "/Operations/EmployeeManagement/EmployeePictures/", imageName);
                    SkillsCertificationPictureBox.BackgroundImage = employeePictureBox.BackgroundImage;
                    ScanCardPictureBox.BackgroundImage = employeePictureBox.BackgroundImage;
                }
                else
                {
                    remoteFtpPath = "";
                }

                db.updateEmployeeInfo(MdlModifyData.userID);
                if (!newEmployeeTabControl.TabPages.Contains(certificationsTabPage))
                {
                    newEmployeeTabControl.TabPages.Add(certificationsTabPage);
                    newEmployeeTabControl.SelectTab(1);
                }

                MdlModifyData.fillSkillsCheckBoxes();
                newEmployeeTabControl.SelectTab(1);
            }
        }

        private void skillsCertificationButton_Click(object sender, EventArgs e)
        {
            if (Conversions.ToBoolean(db.userExists(firstNameTextBox.Text, lastNameTextBox.Text, aliasTextBox.Text)))
            {
                db.updateSkillsOrCertifications();
                if (skillsCertificationButton.Text.Equals("Save and Continue"))
                {
                    if (!firstAidCheckBox.Checked)
                    {
                        newEmployeeTabControl.TabPages.Add(cardIDTabPage);
                        newEmployeeTabControl.SelectTab(2);
                        FinishButton.Show();
                    }
                    else if (firstAidCheckBox.Checked & firstAidComboBox.SelectedIndex != -1)
                    {
                        newEmployeeTabControl.TabPages.Add(cardIDTabPage);
                        newEmployeeTabControl.SelectTab(2);
                        FinishButton.Show();
                    }
                    else
                    {
                        titleSkillsAndCertificationLabel.BackColor = Color.Firebrick;
                        titleSkillsAndCertificationLabel.Text = "Please, select the level of the first aid certificate";
                    }
                }
                else if (!firstAidCheckBox.Checked)
                {
                    Close();
                }
                else if (firstAidCheckBox.Checked & firstAidComboBox.SelectedIndex != -1)
                {
                }
                // EmployeeOptionsTabControl.SelectTab(1)
                else
                {
                    titleSkillsAndCertificationLabel.BackColor = Color.Firebrick;
                    titleSkillsAndCertificationLabel.Text = "Please, select the level of the first aid certificate";
                }
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (FinishButton.Text.Equals("Cancel"))
            {
                MdlControllerModifier.clearFields();
                MdlControllerModifier.formatTabsbackToNormal();
            }
            else
            {
                db.updateCardID(_employeeFirstName, _alias, _employeeLasttName, Conversions.ToString(_cardID)); // Then
                _cardID = "";
                MdlControllerModifier.formatTabsbackToNormal();
                MdlControllerModifier.clearFields();
                newEmployeeTabControl.SelectTab(0);
                MdlEmpManagement.populateEmployeeList(My.MyProject.Forms.FrmEmployeeManagement.BunifuDataGridView1, My.MyProject.Forms.FrmEmployeeManagement.employeeStatus);
            }

            Close();
            My.MyProject.Forms.FrmEmployeeManagement.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // pictureViwer.Show()
            var ofd = new OpenFileDialog();
            ofd.Filter = "All|*|Bitmap|*.bmp|JPEG|*.jpg|PNG|*.png"; // If you like file type filters you can add them here
                                                                    // any other modifications to the dialog

            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;
            try
            {
                var bmp = new Bitmap(ofd.FileName);
                if (!Information.IsNothing(employeePictureBox.BackgroundImage))
                    employeePictureBox.BackgroundImage.Dispose(); // Optional if you want to destroy the previously loaded image
                employeePictureBox.BackgroundImage = bmp;
                pictureExtendsion = Path.GetExtension(ofd.FileName);
                PictureLocalPath = ofd.FileName;
            }
            catch
            {
                pictureExtendsion = "";
                PictureLocalPath = "";
                Interaction.MsgBox("Not a valid image file.");
            }
        }

        private void firstAidCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (firstAidCheckBox.Checked)
            {
                firstAidComboBox.Show();
            }
            else
            {
                firstAidComboBox.Hide();
            }
        }

        private void otherCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (otherCheckBox.Checked)
            {
                otherTextBox.Show();
            }
            else
            {
                otherTextBox.Hide();
            }
        }

        private void EmployeeManagementForm_Load(object sender, EventArgs e)
        {
            pictureExtendsion = "";
            PictureLocalPath = "";
            MdlOptionsManagement.getEmployeeManagementAllowedFunctionalities();
            // adjustScreen(Me, FrmParentScreen.menuIsExpanded)
            MdlControllerModifier.clearFields();
            var jobDescriptionsTable = db.getTableInfo("Employees", "distinct(Job_Description)", "order by Job_Description").Rows;
            jobDescriptionComboBox.Items.Clear();
            foreach (DataRow job in jobDescriptionsTable)
                jobDescriptionComboBox.Items.Add(job["Job_Description"]);
        }

        private void phoneNumberTextBox_LostFocus(object sender, EventArgs e)
        {
            if (MdlControllerModifier.formatPhoneNumber(phoneNumberTextBox.Text).Equals("Wrong format"))
            {
                titlePersonalInfoLabel.Text = "Phone number has wrong format";
                titlePersonalInfoLabel.BackColor = Color.Firebrick;
            }
            else
            {
                phoneNumberTextBox.Text = MdlControllerModifier.formatPhoneNumber(phoneNumberTextBox.Text);
                titlePersonalInfoLabel.BackColor = Color.DarkSlateGray;
                titlePersonalInfoLabel.Text = "Fill up all that apply";
            }
        }

        private void emergencyPhoneNumberTextBox_LostFocus(object sender, EventArgs e)
        {
            if (MdlControllerModifier.formatPhoneNumber(emergencyPhoneNumberTextBox.Text).Equals("Wrong format"))
            {
                titlePersonalInfoLabel.Text = "Phone number has wrong format";
                titlePersonalInfoLabel.BackColor = Color.Firebrick;
            }
            else
            {
                emergencyPhoneNumberTextBox.Text = MdlControllerModifier.formatPhoneNumber(emergencyPhoneNumberTextBox.Text);
                titlePersonalInfoLabel.BackColor = Color.DarkSlateGray;
                titlePersonalInfoLabel.Text = "Fill up all that apply";
            }
        }

        private void firstNameTextBox_TextChanged_1(object sender, EventArgs e)
        {
            aliasTextBox.Text = firstNameTextBox.Text;
        }

        private object GetTempLocalPathStr(Bitmap img, string imageName)
        {
            if (!Directory.Exists(@"C:\temp"))
            {
                Directory.CreateDirectory(@"C:\temp");
            }

            string destinationPath = Path.Combine(@"C:\temp", imageName);
            using (var employeePic = img)
            {
                employeePic.Save(destinationPath);
            }

            return destinationPath;
        }
    }
}