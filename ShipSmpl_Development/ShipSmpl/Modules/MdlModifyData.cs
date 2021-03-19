using Bunifu.UI.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ShipSmpl
{
    static class MdlModifyData
    {
        public static int userID { get; set; }

        private static DatabaseHelper db = new DatabaseHelper();

        public static void fillTextBoxes()
        {
            int selectedRow = employeDataGridView.CurrentRow.Index;
            employeeID = Conversions.ToInteger(employeDataGridView.Rows[selectedRow].Cells[6].Value);
            foreach (DataRow employee in (IEnumerable)db.getEmployee(employeeID).Rows)
            {
                userID = Conversions.ToInteger(employee["ID"]);
                My.MyProject.Forms.FrmAddNewEmployee.firstNameTextBox.Text = Conversions.ToString(employee["First_Name"]);
                My.MyProject.Forms.FrmAddNewEmployee.lastNameTextBox.Text = Conversions.ToString(employee["Last_Name"]);
                My.MyProject.Forms.FrmAddNewEmployee.aliasTextBox.Text = Conversions.ToString(employee["Alias"]);
                My.MyProject.Forms.FrmAddNewEmployee.typeComboBox.Text = Conversions.ToString(employee["Type"]);
                My.MyProject.Forms.FrmAddNewEmployee.yardComboBox.Text = Conversions.ToString(employee["Yard"]);
                My.MyProject.Forms.FrmAddNewEmployee.adressTextBox.Text = Conversions.ToString(employee["Address"]);
                My.MyProject.Forms.FrmAddNewEmployee.phoneNumberTextBox.Text = Conversions.ToString(employee["Phone_Number"]);
                My.MyProject.Forms.FrmAddNewEmployee.startDateDateTimePicker.Value = Conversions.ToDate(employee["Start_Date"]);
                My.MyProject.Forms.FrmAddNewEmployee.emergencyFirstNameTextBox.Text = Conversions.ToString(employee["FirstName_Emerg_Contact"]);
                My.MyProject.Forms.FrmAddNewEmployee.emergencyLastNameTextBox.Text = Conversions.ToString(employee["LastName_Emerg_Contact"]);
                My.MyProject.Forms.FrmAddNewEmployee.emergencyPhoneNumberTextBox.Text = Conversions.ToString(employee["PhoneNumber_Emerg_Contact"]);
                My.MyProject.Forms.FrmAddNewEmployee.relationshipTextBox.Text = Conversions.ToString(employee["Relationship_Emerg_Contact"]);
                My.MyProject.Forms.FrmAddNewEmployee.birthdateDateTimePicker.Value = Conversions.ToDate(employee["Birth_Date"]);
                My.MyProject.Forms.FrmAddNewEmployee.SINumbTextBox.Text = Conversions.ToString(employee["SIN_Number"]);
                My.MyProject.Forms.FrmAddNewEmployee.genderComboBox.SelectedItem = employee["Gender"];
                My.MyProject.Forms.FrmAddNewEmployee.jobDescriptionComboBox.SelectedItem = employee["Job_Description"];
                My.MyProject.Forms.FrmAddNewEmployee.payMehodComboBox.SelectedItem = employee["Pay_Method"];
                My.MyProject.Forms.FrmAddNewEmployee.supervisorTextBox.Text = Conversions.ToString(employee["Supervisor"]);
                My.MyProject.Forms.FrmAddNewEmployee.emailTextBox.Text = Conversions.ToString(employee["Email"]);
                if (!employee["Card_ID"].Equals("Not assigned"))
                {
                    My.MyProject.Forms.FrmAddNewEmployee.cardAddignedLabel.BackColor = Color.Green;
                    My.MyProject.Forms.FrmAddNewEmployee.cardAddignedLabel.Text = "Assigned";
                }

                var ftpModule = new MdlFtp();
                Bitmap ImageFromDB;
                if (!Information.IsDBNull(employee["EmployeePicturePath"]) && !employee["EmployeePicturePath"].Equals(""))
                {
                    ImageFromDB = ftpModule.GetFTPImage(Conversions.ToString(employee["EmployeePicturePath"]));
                    My.MyProject.Forms.FrmAddNewEmployee.employeePictureBox.BackgroundImage = ImageFromDB;
                    My.MyProject.Forms.FrmAddNewEmployee.SkillsCertificationPictureBox.BackgroundImage = ImageFromDB;
                    My.MyProject.Forms.FrmAddNewEmployee.remoteFtpPath = Conversions.ToString(employee["EmployeePicturePath"]);
                    My.MyProject.Forms.FrmAddNewEmployee.OldPictureRemotelPath = Conversions.ToString(employee["EmployeePicturePath"]);
                }
                else
                {
                    My.MyProject.Forms.FrmAddNewEmployee.remoteFtpPath = "";
                    My.MyProject.Forms.FrmAddNewEmployee.OldPictureRemotelPath = "";
                }

                fillSkillsCheckBoxes();
            }

            // FrmEmployeeManagement.newEmployeeTabControl.TabPages.Remove(FrmAddNewEmployee.cardIDTabPage)
        }

        public static void fillSkillsCheckBoxes()
        {
            My.MyProject.Forms.FrmEmployeeDetails.skillsLabel.Text = "";
            My.MyProject.Forms.FrmEmployeeDetails.certificatesLabel.Text = "";
            if (db.getAllSkillsAndCertificates(userID).Rows.Count > 0)
            {
                foreach (DataRow item in (IEnumerable)db.getAllSkillsAndCertificates(userID).Rows)
                {
                    if (item["Bag"].Equals("yes"))
                    {
                        My.MyProject.Forms.FrmAddNewEmployee.bagCheckBox.Checked = true;
                        My.MyProject.Forms.FrmEmployeeDetails.skillsLabel.Text += "‣ Bag" + Environment.NewLine;
                    }

                    if (item["Bagger"].Equals("yes"))
                    {
                        My.MyProject.Forms.FrmAddNewEmployee.baggerCheckBox.Checked = true;
                        My.MyProject.Forms.FrmEmployeeDetails.skillsLabel.Text += "‣ Bagger" + Environment.NewLine;
                    }

                    if (item["Bag_Tipper"].Equals("yes"))
                    {
                        My.MyProject.Forms.FrmAddNewEmployee.bagTipperCheckBox.Checked = true;
                        My.MyProject.Forms.FrmEmployeeDetails.skillsLabel.Text += "‣ Bag Tipper" + Environment.NewLine;
                    }

                    if (item["Bulk_"].Equals("yes"))
                    {
                        My.MyProject.Forms.FrmAddNewEmployee.BulkCheckBox.Checked = true;
                        My.MyProject.Forms.FrmEmployeeDetails.skillsLabel.Text += "‣ Bulk" + Environment.NewLine;
                    }

                    if (item["Bulk_Heads"].Equals("yes"))
                    {
                        My.MyProject.Forms.FrmAddNewEmployee.bulk_HeadsCheckBox.Checked = true;
                        My.MyProject.Forms.FrmEmployeeDetails.skillsLabel.Text += "‣ Bulk Heads" + Environment.NewLine;
                    }

                    if (item["Warehouse"].Equals("yes"))
                    {
                        My.MyProject.Forms.FrmAddNewEmployee.warehouseCheckBox.Checked = true;
                        My.MyProject.Forms.FrmEmployeeDetails.skillsLabel.Text += "‣ Warehouse" + Environment.NewLine;
                    }

                    if (item["Yard_Manager"].Equals("yes"))
                    {
                        My.MyProject.Forms.FrmAddNewEmployee.yardManagerCheckBox.Checked = true;
                        My.MyProject.Forms.FrmEmployeeDetails.skillsLabel.Text += "‣ Yard Manager" + Environment.NewLine;
                    }

                    if (item["_700_Hyster"].Equals("yes"))
                    {
                        My.MyProject.Forms.FrmAddNewEmployee._700HysterCheckBox6.Checked = true;
                        My.MyProject.Forms.FrmEmployeeDetails.certificatesLabel.Text += "‣ 700 Hyster" + Environment.NewLine;
                    }

                    if (item["Driver_License"].Equals("yes"))
                    {
                        My.MyProject.Forms.FrmAddNewEmployee.driverLicenseCheckBox.Checked = true;
                        My.MyProject.Forms.FrmEmployeeDetails.certificatesLabel.Text += "‣ Driver License" + Environment.NewLine;
                    }

                    if (item["First_Aid"].Equals("yes"))
                    {
                        My.MyProject.Forms.FrmAddNewEmployee.firstAidComboBox.Show();
                        My.MyProject.Forms.FrmAddNewEmployee.firstAidCheckBox.Checked = true;
                        My.MyProject.Forms.FrmAddNewEmployee.firstAidComboBox.SelectedItem = item["First_Aid_Level"];
                        My.MyProject.Forms.FrmEmployeeDetails.certificatesLabel.Text = Conversions.ToString(My.MyProject.Forms.FrmEmployeeDetails.certificatesLabel.Text + Operators.AddObject(Operators.AddObject("‣ First Aid - ", item["First_Aid_Level"]), Environment.NewLine));
                    }

                    if (item["Railcar_Mover"].Equals("yes"))
                    {
                        My.MyProject.Forms.FrmAddNewEmployee.railcarMoverCheckBox8.Checked = true;
                        My.MyProject.Forms.FrmEmployeeDetails.certificatesLabel.Text += "‣ Railcar Mover" + Environment.NewLine;
                    }

                    if (item["Empty_Machine"].Equals("yes"))
                    {
                        My.MyProject.Forms.FrmAddNewEmployee.emptyMachineCheckBox.Checked = true;
                        My.MyProject.Forms.FrmEmployeeDetails.certificatesLabel.Text += "‣ Empty Machine" + Environment.NewLine;
                    }

                    if (item["Reachstacker"].Equals("yes"))
                    {
                        My.MyProject.Forms.FrmAddNewEmployee.reachstacherCheckBox.Checked = true;
                        My.MyProject.Forms.FrmEmployeeDetails.certificatesLabel.Text += "‣ Reachstacker" + Environment.NewLine;
                    }

                    if (!Information.IsDBNull(item["Other"]))
                    {
                        My.MyProject.Forms.FrmAddNewEmployee.otherCheckBox.Checked = true;
                        My.MyProject.Forms.FrmAddNewEmployee.otherTextBox.Text = Conversions.ToString(item["Other"]);
                        My.MyProject.Forms.FrmEmployeeDetails.skillsLabel.Text = Conversions.ToString(My.MyProject.Forms.FrmEmployeeDetails.skillsLabel.Text + Operators.AddObject(Operators.AddObject("‣ ", item["Other"]), Environment.NewLine));
                        My.MyProject.Forms.FrmEmployeeDetails.certificatesLabel.Text = Conversions.ToString(My.MyProject.Forms.FrmEmployeeDetails.certificatesLabel.Text + Operators.AddObject(Operators.AddObject("‣ ", item["Other"]), Environment.NewLine));
                    }
                }
            }

            // Dim newMstream As New System.IO.MemoryStream(CType(db.getEmployeePicture(userID), Byte()))
            // Create a new image from the bytes from the memory

        }

        private static BunifuDataGridView employeDataGridView = My.MyProject.Forms.FrmEmployeeManagement.BunifuDataGridView1;
        private static int employeeID;

        public static void terminateEmployee(DateTime terminationDate)
        {
            employeDataGridView = My.MyProject.Forms.FrmEmployeeManagement.BunifuDataGridView1;
            int selectedRow = employeDataGridView.CurrentRow.Index;
            employeeID = Conversions.ToInteger(employeDataGridView.Rows[selectedRow].Cells[6].Value);
            db.TerminateEmployee(employeeID, terminationDate);
            MdlEmpManagement.populateEmployeeList(My.MyProject.Forms.FrmEmployeeManagement.BunifuDataGridView1, My.MyProject.Forms.FrmEmployeeManagement.employeeStatus);
        }

        public static void suspendEmployee(DateTime terminationDate)
        {
            employeDataGridView = My.MyProject.Forms.FrmEmployeeManagement.BunifuDataGridView1;
            int selectedRow = employeDataGridView.CurrentRow.Index;
            employeeID = Conversions.ToInteger(employeDataGridView.Rows[selectedRow].Cells[6].Value);
            db.TerminateEmployee(employeeID, terminationDate);
            MdlEmpManagement.populateEmployeeList(My.MyProject.Forms.FrmEmployeeManagement.BunifuDataGridView1, My.MyProject.Forms.FrmEmployeeManagement.employeeStatus);
        }

        public static void reassignCardID(string cardID)
        {
            employeDataGridView = My.MyProject.Forms.FrmEmployeeManagement.BunifuDataGridView1;
            int selectedRow = employeDataGridView.CurrentRow.Index;
            string firstName = Conversions.ToString(employeDataGridView.Rows[selectedRow].Cells[1].Value);
            string lasttName = Conversions.ToString(employeDataGridView.Rows[selectedRow].Cells[2].Value);
            string aliaas = Conversions.ToString(employeDataGridView.Rows[selectedRow].Cells[0].Value);
            employeeID = Conversions.ToInteger(employeDataGridView.Rows[selectedRow].Cells[6].Value);

            // db._ID = employeeID

            if (Conversions.ToBoolean(db.cardAlreadyAssigned(cardID)))
            {
                string device = "";
                if (My.MyProject.Forms.FrmCardAssignment.isPhoneID)
                {
                    device = "device";
                }
                else
                {
                    device = "card";
                }

                int result = (int)MessageBox.Show("This " + device + " is already assigned to " + My.MyProject.Forms.FrmLoginWindow._employeeName + ". Would you like to reassign it to " + aliaas + " " + lasttName + "?", "Warning", MessageBoxButtons.YesNo);
                if (result == (int)DialogResult.Yes)
                {
                    db.dissociateCardID();
                    db.reassignCard(employeeID.ToString(), cardID);
                    My.MyProject.Forms.FrmCardAssignment.reassignCardTitleLabel.ForeColor = Color.Green;
                    My.MyProject.Forms.FrmCardAssignment.reassignCardTitleLabel.Text = device.Substring(0, 1).ToUpper() + device.Substring(1, device.Length - 1) + " assigned to " + firstName + " " + lasttName;
                    My.MyProject.Forms.FrmCardAssignment.PictureBox1.Image = My.Resources.Resources.icon_available;
                    My.MyProject.Forms.FrmCardAssignment.BackColor = Color.White;
                    MdlControllerModifier.pause(2000);
                    My.MyProject.Forms.FrmCardAssignment.Close();
                }
                else
                {
                    My.MyProject.Forms.FrmCardAssignment._cardID = "";
                }
            }
            else
            {
                string device = "";
                if (My.MyProject.Forms.FrmCardAssignment.isPhoneID)
                {
                    device = "device";
                }
                else
                {
                    device = "card";
                }

                int result = (int)MessageBox.Show("This " + device + " is not in use yet " + ". Would you like to assign it to " + aliaas + " " + lasttName + "?", "Warning", MessageBoxButtons.YesNo);
                if (result == (int)DialogResult.Yes)
                {
                    db.reassignCard(employeeID.ToString(), cardID);
                    My.MyProject.Forms.FrmCardAssignment.reassignCardTitleLabel.ForeColor = Color.Green;
                    My.MyProject.Forms.FrmCardAssignment.reassignCardTitleLabel.Text = device + " assigned to " + firstName + " " + lasttName;
                    My.MyProject.Forms.FrmCardAssignment.PictureBox1.Image = My.Resources.Resources.icon_available;
                    My.MyProject.Forms.FrmCardAssignment.BackColor = Color.White;
                    MdlControllerModifier.pause(2000);
                    My.MyProject.Forms.FrmCardAssignment.Close();
                }
                else
                {
                    My.MyProject.Forms.FrmCardAssignment._cardID = "";
                }
            }
        }

        public static void fillEmployeeDetails(int employeeID)
        {
            foreach (DataRow employee in (IEnumerable)db.getEmployee(employeeID).Rows)
            {
                My.MyProject.Forms.FrmEmployeeDetails.empIDLabel.Text = employee["ID"].ToString();
                userID = Conversions.ToInteger(employee["ID"].ToString());
                My.MyProject.Forms.FrmEmployeeDetails.empNameLabel.Text = Conversions.ToString(Operators.AddObject(Operators.AddObject(employee["First_Name"], " "), employee["Last_Name"]));
                if (!employee["Card_ID"].Equals("Not assigned"))
                {
                    My.MyProject.Forms.FrmAddNewEmployee.cardAddignedLabel.BackColor = Color.Green;
                    My.MyProject.Forms.FrmAddNewEmployee.cardAddignedLabel.Text = "Assigned";
                    My.MyProject.Forms.FrmEmployeeDetails.cardStatusLabel.Text = "Assigned";
                    My.MyProject.Forms.FrmEmployeeDetails.cardStatusLabel.BackColor = Color.Green;
                }

                var ftpModule = new MdlFtp();
                Bitmap ImageFromDB;
                if (!Information.IsDBNull(employee["EmployeePicturePath"]) && !employee["EmployeePicturePath"].Equals(""))
                {
                    ImageFromDB = ftpModule.GetFTPImage(Conversions.ToString(employee["EmployeePicturePath"]));
                    My.MyProject.Forms.FrmEmployeeDetails.PictureBox.BackgroundImage = ImageFromDB;
                }
                else
                {
                    My.MyProject.Forms.FrmEmployeeDetails.PictureBox.BackgroundImage = null;
                }

                if (employee["Status"].Equals("Active"))
                {
                    My.MyProject.Forms.FrmEmployeeDetails.statusLabel.Text = "    Active";
                    My.MyProject.Forms.FrmEmployeeDetails.statusLabel.ImageKey = "roundedGradientGreen.png";
                }
                else
                {
                    My.MyProject.Forms.FrmEmployeeDetails.statusLabel.Text = "    Not Active";
                    My.MyProject.Forms.FrmEmployeeDetails.statusLabel.ImageKey = "redBall.png";
                }

                My.MyProject.Forms.FrmEmployeeDetails.TypeLabel.Text = Conversions.ToString(employee["Type"]);
                My.MyProject.Forms.FrmEmployeeDetails.yardLabel.Text = Conversions.ToString(employee["Yard"]);
                My.MyProject.Forms.FrmEmployeeDetails.jobDescriptionLabel.Text = Conversions.ToString(employee["Job_Description"]);
                if (employee["Supervisor"].Equals(""))
                {
                    My.MyProject.Forms.FrmEmployeeDetails.supervisorLabel.Text = "N/A";
                }
                else
                {
                    My.MyProject.Forms.FrmEmployeeDetails.supervisorLabel.Text = Conversions.ToString(employee["Supervisor"]);
                }

                My.MyProject.Forms.FrmEmployeeDetails.aliasLabel.Text = Conversions.ToString(employee["Alias"]);
                My.MyProject.Forms.FrmEmployeeDetails.genderLabel.Text = Conversions.ToString(employee["Gender"]);
                if (MdlOptionsManagement.allowedToSensitiveInformation == false)
                {
                    My.MyProject.Forms.FrmEmployeeDetails.sinLabel.Text = "******";
                    My.MyProject.Forms.FrmEmployeeDetails.birthdayLabel.Text = "******";
                    My.MyProject.Forms.FrmEmployeeDetails.PayMethodLabel.Text = "******";
                    My.MyProject.Forms.FrmEmployeeDetails.addressLabel.Text = "******";
                    My.MyProject.Forms.FrmEmployeeDetails.endDateLabel.Text = "******";
                    My.MyProject.Forms.FrmEmployeeDetails.startDateLabel19.Text = "******";
                }
                else
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(employee["SIN_Number"], 0, false)))
                    {
                        My.MyProject.Forms.FrmEmployeeDetails.sinLabel.Text = "N/A";
                    }
                    else
                    {
                        My.MyProject.Forms.FrmEmployeeDetails.sinLabel.Text = Conversions.ToString(employee["SIN_Number"]);
                    }

                    if (!employee["Birth_Date"].Equals(""))
                    {
                        DateTime bd;
                        bd = Convert.ToDateTime(employee["Birth_Date"]);
                        My.MyProject.Forms.FrmEmployeeDetails.birthdayLabel.Text = bd.Date.ToString("MMM-dd-yyyy");
                    }
                    else
                    {
                        My.MyProject.Forms.FrmEmployeeDetails.birthdayLabel.Text = "N/A";
                    }

                    My.MyProject.Forms.FrmEmployeeDetails.PayMethodLabel.Text = Conversions.ToString(employee["Pay_Method"]);
                    if (!employee["Address"].Equals(""))
                    {
                        My.MyProject.Forms.FrmEmployeeDetails.addressLabel.Text = Conversions.ToString(employee["Address"]);
                    }
                    else
                    {
                        My.MyProject.Forms.FrmEmployeeDetails.addressLabel.Text = "N/A";
                    }

                    var sd = Convert.ToDateTime(employee["Start_Date"]);
                    My.MyProject.Forms.FrmEmployeeDetails.startDateLabel19.Text = sd.Date.ToString("MMM-dd-yyyy");
                    if (!Information.IsDBNull(employee["End_Date"]))
                    {
                        sd = Convert.ToDateTime(employee["End_Date"]);
                        My.MyProject.Forms.FrmEmployeeDetails.endDateLabel.Text = sd.Date.ToString("MMM-dd-yyyy");
                    }
                    else
                    {
                        My.MyProject.Forms.FrmEmployeeDetails.endDateLabel.Text = "N/A";
                    }
                }

                if (!employee["Phone_Number"].Equals(""))
                {
                    My.MyProject.Forms.FrmEmployeeDetails.phoneLabel.Text = Conversions.ToString(employee["Phone_Number"]);
                }
                else
                {
                    My.MyProject.Forms.FrmEmployeeDetails.phoneLabel.Text = "N/A";
                }

                if (!employee["Email"].Equals(""))
                {
                    My.MyProject.Forms.FrmEmployeeDetails.emailLabel.Text = Conversions.ToString(employee["Email"]);
                }
                else
                {
                    My.MyProject.Forms.FrmEmployeeDetails.emailLabel.Text = "N/A";
                }

                if (!employee["FirstName_Emerg_Contact"].Equals(""))
                {
                    My.MyProject.Forms.FrmEmployeeDetails.emergNameLabel.Text = Conversions.ToString(Operators.AddObject(Operators.AddObject(employee["FirstName_Emerg_Contact"], " "), employee["LastName_Emerg_Contact"]));
                }
                else
                {
                    My.MyProject.Forms.FrmEmployeeDetails.emergNameLabel.Text = "N/A";
                }

                if (!employee["PhoneNumber_Emerg_Contact"].Equals(""))
                {
                    My.MyProject.Forms.FrmEmployeeDetails.emergPhoneNumbLabel.Text = Conversions.ToString(employee["PhoneNumber_Emerg_Contact"]);
                }
                else
                {
                    My.MyProject.Forms.FrmEmployeeDetails.emergPhoneNumbLabel.Text = "N/A";
                }

                if (!employee["Relationship_Emerg_Contact"].Equals(""))
                {
                    My.MyProject.Forms.FrmEmployeeDetails.relationshipLabel.Text = Conversions.ToString(employee["Relationship_Emerg_Contact"]);
                }
                else
                {
                    My.MyProject.Forms.FrmEmployeeDetails.relationshipLabel.Text = "N/A";
                }

                fillSkillsCheckBoxes();
                break;
            }
        }

        public static void clearEmployeeDetails()
        {
            My.MyProject.Forms.FrmEmployeeDetails.supervisorLabel.Text = "N/A";
            My.MyProject.Forms.FrmEmployeeDetails.endDateLabel.Text = "N/A";
            My.MyProject.Forms.FrmEmployeeDetails.sinLabel.Text = "N/A";
            My.MyProject.Forms.FrmEmployeeDetails.phoneLabel.Text = "N/A";
            My.MyProject.Forms.FrmEmployeeDetails.emailLabel.Text = "N/A";
            My.MyProject.Forms.FrmEmployeeDetails.addressLabel.Text = "N/A";
            My.MyProject.Forms.FrmEmployeeDetails.emergNameLabel.Text = "N/A";
            My.MyProject.Forms.FrmEmployeeDetails.emergPhoneNumbLabel.Text = "N/A";
            My.MyProject.Forms.FrmEmployeeDetails.relationshipLabel.Text = "N/A";
        }

        public static string base64Encode(string sData)
        {
            try
            {
                var encData_byte = new byte[sData.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(sData);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }

        public static string base64Decode(string sData)
        {
            var encoder = new System.Text.UTF8Encoding();
            var utf8Decode = encoder.GetDecoder();
            var todecode_byte = Convert.FromBase64String(sData);
            int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            var decoded_char = new char[charCount];
            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            string result = new string(decoded_char);
            return result;
        }

        public static void saveClearance(BunifuDataGridView employeDataGridView)
        {
            var clearanceTreeView = My.MyProject.Forms.FrmClearance.TreeView1;
            int selectedRow = employeDataGridView.CurrentRow.Index;
            int selectedEmployee = Conversions.ToInteger(employeDataGridView.Rows[selectedRow].Cells[6].Value);
            string tableName;
            string columnName;

            // loop through root nodes
            foreach (TreeNode rootNode in clearanceTreeView.Nodes)
            {
                tableName = "Main_Menu_Clearance";
                columnName = rootNode.Text;
                int childNodeIndex = 0;
                if (rootNode.Checked)
                {
                    db.updateClearance(selectedEmployee, tableName, columnName.Replace(" ", "_"), 1);
                    columnName = rootNode.Text;
                    // loop through child nodle
                    foreach (TreeNode node in rootNode.Nodes)
                    {
                        columnName = Conversions.ToString(node.Text);
                        tableName = rootNode.Text.Replace(" ", "_") + "_Clearance";
                        var anode = rootNode.Nodes;
                        if (anode[childNodeIndex].Checked)
                        {
                            db.updateClearance(selectedEmployee, tableName, columnName.Replace(" ", "_"), 1);
                        }
                        else
                        {
                            db.updateClearance(selectedEmployee, tableName, columnName.Replace(" ", "_"), 0);
                        }

                        if (node.Nodes is object)
                        {
                            tableName = Conversions.ToString(Operators.AddObject(node.Text.Replace(" ", "_"), "_Clearance"));
                            TreeNodeCollection childNode = (TreeNodeCollection)node.Nodes;
                            for (int i = 0, loopTo = childNode.Count - 1; i <= loopTo; i++)
                            {
                                var chNodes = childNode[i];
                                if (chNodes.Checked)
                                {
                                    columnName = childNode[i].Text;
                                    db.updateClearance(selectedEmployee, tableName, columnName.Replace(" ", "_"), 1);
                                    if (chNodes.Nodes.Count > 0)
                                    {
                                        var lastNodes = chNodes.Nodes;
                                        for (int x = 0, loopTo1 = lastNodes.Count - 1; x <= loopTo1; x++)
                                        {
                                            if (lastNodes[x].Text.Equals("See sensitive information"))
                                            {
                                                columnName = lastNodes[x].Text;
                                                if (lastNodes[x].Checked)
                                                {
                                                    db.updateClearance(selectedEmployee, tableName, columnName.Replace(" ", "_"), 1);
                                                }
                                                else
                                                {
                                                    db.updateClearance(selectedEmployee, tableName, columnName.Replace(" ", "_"), 0);
                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    columnName = Conversions.ToString(node.Nodes[i].Text);
                                    db.updateClearance(selectedEmployee, tableName, columnName.Replace(" ", "_"), 0);
                                    if (chNodes.Nodes.Count > 0)
                                    {
                                        var lastNodes = chNodes.Nodes;
                                        for (int x = 0, loopTo2 = lastNodes.Count - 1; x <= loopTo2; x++)
                                        {
                                            if (lastNodes[x].Text.Equals("See sensitive information"))
                                            {
                                                columnName = lastNodes[x].Text;
                                                db.updateClearance(selectedEmployee, tableName, columnName.Replace(" ", "_"), 0);
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        childNodeIndex += 1;
                    }
                }
                else
                {
                    childNodeIndex = 0;
                    db.updateClearance(selectedEmployee, tableName, columnName.Replace(" ", "_"), 0);
                    foreach (TreeNode node in rootNode.Nodes)
                    {
                        // columnName = node.Text.Replace(" ", "_") + "_Clearance"
                        columnName = Conversions.ToString(node.Text);
                        tableName = rootNode.Text.Replace(" ", "_") + "_Clearance";
                        db.updateClearance(selectedEmployee, tableName, columnName.Replace(" ", "_"), 0);
                        if (node.Nodes is object)
                        {
                            for (int i = 0, loopTo3 = Conversions.ToInteger(Operators.SubtractObject(node.Nodes.Count, 1)); i <= loopTo3; i++)
                            {
                                tableName = Conversions.ToString(Operators.AddObject(node.Text.Replace(" ", "_"), "_Clearance"));
                                columnName = Conversions.ToString(node.Nodes[i].Text);
                                TreeNode chNodes = (TreeNode)node.Nodes[i];
                                db.updateClearance(selectedEmployee, tableName, columnName.Replace(" ", "_"), 1);
                                if (chNodes.Nodes.Count > 0)
                                {
                                    var lastNodes = chNodes.Nodes;
                                    for (int x = 0, loopTo4 = lastNodes.Count - 1; x <= loopTo4; x++)
                                    {
                                        if (lastNodes[x].Text.Equals("See sensitive information"))
                                        {
                                            columnName = lastNodes[x].Text;
                                            db.updateClearance(selectedEmployee, tableName, columnName.Replace(" ", "_"), 0);
                                        }
                                    }
                                }
                            }
                        }

                        childNodeIndex += 1;
                    }
                }
            }
        }
    }
}