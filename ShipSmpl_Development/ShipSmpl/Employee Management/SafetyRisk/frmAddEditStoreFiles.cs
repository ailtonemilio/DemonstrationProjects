using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Security;
using System.Windows.Forms;
using WaitLoading;

namespace ShipSmpl
{
    public partial class frmAddEditStoreFiles
    {
        public frmAddEditStoreFiles()
        {
            InitializeComponent();
            _closeLabel.Name = "closeLabel";
            _btnSave.Name = "btnSave";
            _btnSearchFile.Name = "btnSearchFile";
            _txtExpireDate.Name = "txtExpireDate";
            _btnAddDocumentType.Name = "btnAddDocumentType";
            _ddlArea.Name = "ddlArea";
            _btnCancelIssueDate.Name = "btnCancelIssueDate";
            _txtIssueDate.Name = "txtIssueDate";
            _btnCancelExpireDate.Name = "btnCancelExpireDate";
            _btnAddDepartment.Name = "btnAddDepartment";
        }

        private string IssueDate = "";
        private string ExpireDate = "";
        private string DateDoc = "";
        private string filename = "";
        private string fileOrigin = "";
        private string fileDestiny = "";
        private FTPServerManagement ftpser = new FTPServerManagement();
        private WaitLoadingRun waitForm = new WaitLoadingRun();

        private void frmAddEditStoreFiles_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private void btnSave_Click(object sender, EventArgs e)
        {
            UploadFile();
        }

        private void btnSearchFile_Click(object sender, EventArgs e)
        {
            ofdDoc.Multiselect = false;
            ofdDoc.Title = "Select the Document";
            ofdDoc.InitialDirectory = @"C:\";
            // Filter only PDF Files
            // ofdDoc.Filter = "Arquivos (*.PDF;*.AVI;*.MP3;*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.PDF;*.AVI;*.MP3;*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" & "Todos (*.*)|*.*"
            ofdDoc.Filter = "Arquivos (*.PDF;)|*.PDF;";
            ofdDoc.CheckFileExists = true;
            ofdDoc.CheckPathExists = true;
            ofdDoc.FilterIndex = 2;
            ofdDoc.RestoreDirectory = true;
            var dr = ofdDoc.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(ofdDoc.FileName))
                {
                    return;
                }

                try
                {
                    txtFile.Text = ofdDoc.FileName;
                    txtFile.Text = ofdDoc.FileName;
                    // Defines the document data
                    btnSave.Enabled = true;
                }
                catch (SecurityException ex)
                {
                    // The user does not have permission to read files
                    MessageBox.Show("Security error Contact your network security administrator." + Constants.vbLf + Constants.vbLf + "Message : " + ex.Message + Constants.vbLf + Constants.vbLf + "Details (send to support):" + Constants.vbLf + Constants.vbLf + ex.StackTrace);
                }
                catch (Exception ex)
                {
                    // Cannot upload the image (permission issues)
                    MessageBox.Show("Cannot access the file: " + ofdDoc.FileName + ". You may not have permission to read the file, or " + " it may be corrupted." + Constants.vbLf + Constants.vbLf + "Error reported: " + ex.Message);
                }
            }
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SelectDocumentType(string DescDocumentType)
        {
            ddlType.Text = DescDocumentType;
        }

        private void btnAddDocumentType_Click(object sender, EventArgs e)
        {
            if (VerifyDepartmentUser(Conversions.ToInteger(ddlArea.SelectedValue)) == false)
            {
                MessageBox.Show("You cannot create document types for this department!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            My.MyProject.Forms.frmAddDocumentType.LoadForm(Conversions.ToInteger(ddlArea.SelectedValue));
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.frmAddDocumentType, this);
        }

        private void ddlArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            DocumentsStoredTypeBindingSource.DataSource = DocumentsStoredTypeService.GetByDeparmentId(Conversions.ToInteger(ddlArea.SelectedValue));
        }

        private void btnCancelIssueDate_Click(object sender, EventArgs e)
        {
            txtIssueDate.CustomFormat = " ";
        }

        private void btnCancelExpireDate_Click(object sender, EventArgs e)
        {
            txtExpireDate.CustomFormat = " ";
        }

        private void txtIssueDate_ValueChanged(object sender, EventArgs e)
        {
            txtIssueDate.CustomFormat = "MMM dd, yyyy";
        }

        private void txtExpireDate_ValueChanged(object sender, EventArgs e)
        {
            txtExpireDate.CustomFormat = "MMM dd, yyyy";
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.frmAddDepartment, this);
        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private void UploadFile()
        {
            // Verify max
            if (txtFileTitle.TextLength > 50)
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("The maximum characters for the File Title field is 50.", "File Title", this);
                return;
            }

            if (txtDescription.TextLength > 250)
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("The maximum characters for the description field is 250..", "File Title", this);
                return;
            }

            // 0 - Handles possible errors
            if (string.IsNullOrEmpty(ddlArea.Text))
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Choose a department.", "Department", this);
                return;
            }

            if (string.IsNullOrEmpty(ddlType.Text))
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Choose a Document Type.", "Document Type", this);
                return;
            }

            if (string.IsNullOrEmpty(txtFile.Text))
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Invalid file", "Enter the name and path of the destination file", this);
                return;
            }

            // 1 - Check Form Date Format
            if (txtIssueDate.CustomFormat == "MMM dd, yyyy")
            {
                IssueDate = Conversions.ToString(txtIssueDate.Value);
            }

            if (txtExpireDate.CustomFormat == "MMM dd, yyyy")
            {
                ExpireDate = Conversions.ToString(txtExpireDate.Value);
            }

            // 2 - Name the file
            DateDoc = DateTime.Now.ToString("dd/MMM/yyyy") + "_" + DateTime.Now.ToString("HH") + "h_" + DateTime.Now.ToString("mm") + "m";
            if (string.IsNullOrEmpty(ddlEmployee.Text))
            {
                filename = ddlType.Text.Trim().Replace(" ", "_") + "_" + DateDoc.Replace("/", "_") + ".PDF";
            }
            else
            {
                filename = ddlType.Text.Trim() + "_" + ddlEmployee.Text.Trim().Replace("(", "").Replace(")", "_").Replace(" ", "").Replace(",", "_") + "_" + DateDoc.Replace("/", "_") + ".PDF";
            }

            // 3 - Select the file for a specific directory
            fileOrigin = txtFile.Text;

            // 4 - file destiny
            fileDestiny = "documentstorage/" + ddlArea.Text + "/" + ddlType.Text + "/";
            waitForm.Show();
            // 4.1 - Insert file on server and save to database
            if (ftpser.uploadSFTPFile(fileOrigin, fileDestiny, filename))
            {
                if (DocumentsStoredService.Insert(txtFileTitle.Text, txtDescription.Text, fileDestiny + filename, IssueDate, ExpireDate, filename, Conversions.ToInteger(ddlEmployee.SelectedValue), Conversions.ToInteger(ddlType.SelectedValue), Conversions.ToInteger(ddlArea.SelectedValue)))
                {
                    waitForm.Close();
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("File copied successfully.", "Success", this);
                    DocumentsStoredTypeBindingSource.DataSource = DocumentsStoredTypeService.GetByDeparmentId(Conversions.ToInteger(ddlArea.SelectedValue));
                    Close();
                    My.MyProject.Forms.frmStoreFiles.SearchDocs();
                }
                else
                {
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("If the Error persists contact the IT department. Error Code# DB120", "Error sending file", this);
                    ftpser.DeleteSFTPFile(fileDestiny + filename);
                }
            }
            else
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("If the Error persists contact the IT department. Error Code #FTB120", "Error sending file", this);
            }

            waitForm.Close();
        }

        public void ConfigLayoutForUserPerfil()
        {
            int IdUser = My.MyProject.Forms.FrmLoginWindow._userID;
            switch (IdUser)
            {
                // 54 - JORDAN
                // 63 - LYNDON
                // 70 - MAY
                // 124 - Vania
                // 135 - Roger
                // 163 - Emilio
                case 135:
                    {
                        btnAddDepartment.Visible = false;
                        ddlArea.SelectedValue = 18;
                        DocumentsStoredTypeBindingSource.DataSource = DocumentsStoredTypeService.GetByDeparmentIdForDropBox(Conversions.ToInteger(ddlArea.SelectedValue), true);
                        ddlArea.Enabled = false;
                        break;
                    }

                case 70:
                    {
                        btnAddDepartment.Visible = false;
                        ddlArea.SelectedValue = 17;
                        DocumentsStoredTypeBindingSource.DataSource = DocumentsStoredTypeService.GetByDeparmentIdForDropBox(Conversions.ToInteger(ddlArea.SelectedValue), true);
                        ddlArea.Enabled = false;
                        break;
                    }

                case 54:
                    {
                        btnAddDepartment.Visible = true;
                        break;
                    }

                case 63:
                    {
                        btnAddDepartment.Visible = true;
                        break;
                    }

                case 124:
                    {
                        btnAddDepartment.Visible = true;
                        break;
                    }

                case 163:
                    {
                        btnAddDepartment.Visible = true;
                        break;
                    }
            }
        }

        public void LoadForm()
        {
            EmployeeNameBindingSource.DataSource = EmployeeService.GetFirstNameLastNameForDropBox();
            DocumentsStoredDepartmentBindingSource.DataSource = DocumentsStoredDepartmentService.GetAll();
            DocumentsStoredTypeBindingSource.DataSource = DocumentsStoredTypeService.GetByDeparmentId(Conversions.ToInteger(ddlArea.SelectedValue));
            txtExpireDate.CustomFormat = " ";
            txtIssueDate.CustomFormat = " ";
            ConfigLayoutForUserPerfil();
        }

        public void LoadDepartment(int DepartmentId)
        {
            DocumentsStoredDepartmentBindingSource.DataSource = DocumentsStoredDepartmentService.GetAll();
            ddlArea.SelectedValue = DepartmentId;
        }

        public void LoadDocType()
        {
            DocumentsStoredTypeBindingSource.DataSource = DocumentsStoredTypeService.GetByDeparmentId(Convert.ToInt32(ddlArea.SelectedValue));
        }

        public bool VerifyDepartmentUser(int DepId)
        {
            bool isDepOK = false;
            // Department code:
            // HR - 17
            // SAFETY_AND_RISK - 18

            // Verifica se usuario pode excluir documentos do departamento.
            int IdUser = My.MyProject.Forms.FrmLoginWindow._userID;
            switch (IdUser)
            {
                // 54 - JORDAN
                // 63 - LYNDON
                // 70 - MAY
                // 124 - Vania
                // 135 - Roger
                // 163 - Emilio
                case 135:
                    {
                        if (DepId == 18)
                        {
                            isDepOK = true;
                        }

                        break;
                    }

                case 70:
                    {
                        if (DepId == 17)
                        {
                            isDepOK = true;
                        }

                        break;
                    }

                default:
                    {
                        isDepOK = true;
                        break;
                    }
            }

            return isDepOK;
        }

        public void ClearFields()
        {
            txtFileTitle.Text = "";
            txtFileTitle.Text = "";
            txtExpireDate.CustomFormat = " ";
            txtIssueDate.CustomFormat = " ";
            txtFile.Text = "";
            txtDescription.Text = "";
            LoadForm();
            ddlEmployee.Text = "";
        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}