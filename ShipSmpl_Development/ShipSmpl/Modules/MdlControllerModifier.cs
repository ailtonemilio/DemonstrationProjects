using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ShipSmpl
{
    static class MdlControllerModifier
    {
        private static DatabaseHelper db = new DatabaseHelper();

        public static void clearFields()
        {
            My.MyProject.Forms.FrmAddNewEmployee.firstNameTextBox.Text = "";
            My.MyProject.Forms.FrmAddNewEmployee.lastNameTextBox.Text = "";
            My.MyProject.Forms.FrmAddNewEmployee.aliasTextBox.Text = "";
            My.MyProject.Forms.FrmAddNewEmployee.phoneNumberTextBox.Text = "";
            My.MyProject.Forms.FrmAddNewEmployee.adressTextBox.Text = "";
            My.MyProject.Forms.FrmAddNewEmployee.startDateDateTimePicker.Value = DateTime.Now;
            My.MyProject.Forms.FrmAddNewEmployee.birthdateDateTimePicker.Value = DateTime.Now;
            My.MyProject.Forms.FrmAddNewEmployee.emergencyFirstNameTextBox.Text = "";
            My.MyProject.Forms.FrmAddNewEmployee.emergencyLastNameTextBox.Text = "";
            My.MyProject.Forms.FrmAddNewEmployee.emergencyPhoneNumberTextBox.Text = "";
            My.MyProject.Forms.FrmAddNewEmployee.relationshipTextBox.Text = "";
            My.MyProject.Forms.FrmAddNewEmployee.emailTextBox.Text = "";
            My.MyProject.Forms.FrmAddNewEmployee.typeComboBox.SelectedIndex = -1;
            My.MyProject.Forms.FrmAddNewEmployee.yardComboBox.SelectedIndex = -1;
            My.MyProject.Forms.FrmAddNewEmployee.genderComboBox.SelectedIndex = -1;
            My.MyProject.Forms.FrmAddNewEmployee.jobDescriptionComboBox.SelectedIndex = -1;
            My.MyProject.Forms.FrmAddNewEmployee.payMehodComboBox.SelectedIndex = -1;
            My.MyProject.Forms.FrmAddNewEmployee.titleScanLabel.Text = "Please scan the card assigned to employee";
            My.MyProject.Forms.FrmAddNewEmployee.titleScanLabel.ForeColor = Color.FromArgb(64, 64, 0);
            My.MyProject.Forms.FrmAddNewEmployee.ScanCardPictureBox.BackgroundImage = My.Resources.Resources.tapCardIcon2;
            My.MyProject.Forms.FrmAddNewEmployee.titlePersonalInfoLabel.Text = "Fill up all that apply";
            My.MyProject.Forms.FrmAddNewEmployee.titlePersonalInfoLabel.ForeColor = Color.FromArgb(64, 64, 0);
            My.MyProject.Forms.FrmAddNewEmployee.personalInfoButton.Text = "Save and Continue";
            My.MyProject.Forms.FrmAddNewEmployee.titleSkillsAndCertificationLabel.Text = "Fill up all the skills and certifications that apply";
            My.MyProject.Forms.FrmAddNewEmployee.titleSkillsAndCertificationLabel.ForeColor = Color.FromArgb(64, 64, 0);
            My.MyProject.Forms.FrmEditEntry.editEntryTitleLabel.Text = "Check the fields to be modified";
            My.MyProject.Forms.FrmEditEntry.editEntryTitleLabel.ForeColor = Color.FromArgb(64, 64, 0);
            My.MyProject.Forms.FrmAddNewEntry.editEntryTitleLabel.Text = "Select employee and entries to be created";
            My.MyProject.Forms.FrmAddNewEntry.editEntryTitleLabel.ForeColor = Color.FromArgb(64, 64, 0);
            My.MyProject.Forms.FrmTimeSheet.titleTimeManagementLabel.Text = "Select the employee to see detailed time sheet";
            My.MyProject.Forms.FrmTimeSheet.titleTimeManagementLabel.ForeColor = Color.FromArgb(64, 64, 0);
            My.MyProject.Forms.FrmAddNewEmployee.skillsCertificationButton.Text = "Save and Continue";
            My.MyProject.Forms.FrmAddNewEmployee.FinishButton.Text = "Cancel";
            My.MyProject.Forms.FrmAddNewEmployee.employeePictureBox.BackgroundImage = My.Resources.Resources.photoPfofile;
            My.MyProject.Forms.FrmAddNewEmployee.bagCheckBox.Checked = false;
            My.MyProject.Forms.FrmAddNewEmployee.baggerCheckBox.Checked = false;
            My.MyProject.Forms.FrmAddNewEmployee.BulkCheckBox.Checked = false;
            My.MyProject.Forms.FrmAddNewEmployee.bulk_HeadsCheckBox.Checked = false;
            My.MyProject.Forms.FrmAddNewEmployee.warehouseCheckBox.Checked = false;
            My.MyProject.Forms.FrmAddNewEmployee.yardManagerCheckBox.Checked = false;
            My.MyProject.Forms.FrmAddNewEmployee._700HysterCheckBox6.Checked = false;
            My.MyProject.Forms.FrmAddNewEmployee.driverLicenseCheckBox.Checked = false;
            My.MyProject.Forms.FrmAddNewEmployee.emptyMachineCheckBox.Checked = false;
            My.MyProject.Forms.FrmAddNewEmployee.firstAidCheckBox.Checked = false;
            My.MyProject.Forms.FrmAddNewEmployee.firstAidComboBox.Hide();
            My.MyProject.Forms.FrmAddNewEmployee.railcarMoverCheckBox8.Checked = false;
            My.MyProject.Forms.FrmAddNewEmployee.reachstacherCheckBox.Checked = false;
            My.MyProject.Forms.FrmAddNewEmployee.otherCheckBox.Checked = false;
            My.MyProject.Forms.FrmAddNewEmployee.otherTextBox.Text = "";
            My.MyProject.Forms.FrmAddNewEmployee.otherTextBox.Hide();
            My.MyProject.Forms.FrmAddNewEmployee.cardAddignedLabel.BackColor = Color.Firebrick;
            My.MyProject.Forms.FrmAddNewEmployee.cardAddignedLabel.Text = "Not assigned";
            My.MyProject.Forms.FrmAddNewEmployee.newEmployeeTabControl.TabPages.Remove(My.MyProject.Forms.FrmAddNewEmployee.certificationsTabPage);
            My.MyProject.Forms.FrmAddNewEmployee.newEmployeeTabControl.TabPages.Remove(My.MyProject.Forms.FrmAddNewEmployee.cardIDTabPage);
        }

        public static void pause(int interval)
        {
            var sw = new Stopwatch();
            sw.Start();
            while (sw.ElapsedMilliseconds < interval)
                // Allows UI to remain responsive
                Application.DoEvents();
        }

        public static void formatTabsbackToNormal()
        {
            My.MyProject.Forms.FrmAddNewEmployee.titleScanLabel.BackColor = Color.YellowGreen;
            My.MyProject.Forms.FrmAddNewEmployee.titleScanLabel.Text = "Informations saved with success";
            My.MyProject.Forms.FrmAddNewEmployee.FinishButton.Visible = false;
            pause(2000);
            My.MyProject.Forms.FrmAddNewEmployee.newEmployeeTabControl.SelectTab(0);
        }

        public static void warning(string code, Label message)
        {
            switch (code ?? "")
            {
                case "incomplete information":
                    {
                        message.ForeColor = Color.Firebrick;
                        message.Text = "Please, make sure all the required informations are filled";
                        break;
                    }

                case "card available":
                    {
                        message.ForeColor = Color.Firebrick;
                        message.Text = "Card is available to be assigned to employee. Click finish to complete";
                        break;
                    }

                case "card not available":
                    {
                        message.ForeColor = Color.Firebrick;
                        message.Text = "Card is already assigned to an employee. Scan another card to proceed";
                        break;
                    }

                case "Edit entry":
                    {
                        message.ForeColor = Color.Firebrick;
                        message.Text = "Please, make sure all the required informations are filled";
                        break;
                    }

                case "no item selected":
                    {
                        message.ForeColor = Color.Firebrick;
                        message.Text = "Please, select employee and make sure the clock-in box is tagged";
                        break;
                    }

                case "timesheet not complete":
                    {
                        message.Text = "Information missing for one or more selected employees.";
                        message.ForeColor = Color.Firebrick;
                        break;
                    }

                case "nothing selected":
                    {
                        message.Text = "Select the employee to proceed";
                        message.ForeColor = Color.Firebrick;
                        break;
                    }

                case "nothing selected report":
                    {
                        message.Text = "Please make sure to select the employee and the type of work to be compared";
                        message.ForeColor = Color.Firebrick;
                        break;
                    }

                case "Wrong time":
                    {
                        message.Text = "Clock out time cannot be less than clock in time";
                        message.ForeColor = Color.Firebrick;
                        break;
                    }

                default:
                    {
                        message.ForeColor = Color.Firebrick;
                        message.Text = "This employee already exist";
                        break;
                    }
            }
        }

        public static void populateEmployeeListSchedule(ListView employeeList, string conditions)
        {
            employeeList.Items.Clear();
            foreach (DataRow employee in db.getSpecificActiveEmployees(conditions).Rows)
                employeeList.Items.Add(new ListViewItem(new[] { Conversions.ToString(employee["Alias"]), Conversions.ToString(employee["First_Name"]), Conversions.ToString(employee["Last_Name"]), Conversions.ToString(employee["ID"]) }));
            employeeList.Update();
        }

        public static object hoursWorked(string startTime, string endTime)
        {
            var d1 = Convert.ToDateTime(startTime);
            var d2 = Convert.ToDateTime(endTime);
            string totalhoursWorked;
            var difference = d2 - d1;
            // round down total hours to integer'
            double hours = Math.Floor(difference.TotalHours);
            int minutes = difference.Minutes;
            string strMin;
            if (minutes < 10)
            {
                strMin = "0" + minutes.ToString();
                totalhoursWorked = Strings.Format("{0} Hours ", hours.ToString()) + ":" + strMin;
            }
            else
            {
                totalhoursWorked = Strings.Format("{0} Hours ", hours.ToString()) + ":" + Strings.Format(" {1} Minutes", minutes.ToString());
            }
            // Following line prints : 25 Hours 10 Minutes'

            return totalhoursWorked;
        }

        public static string formatPhoneNumber(string strPhoneNumber)
        {
            if (!string.IsNullOrEmpty(strPhoneNumber))
            {
                if (Regex.IsMatch(strPhoneNumber, "^[0-9 ]+$"))
                {
                    strPhoneNumber = Strings.Replace(strPhoneNumber, ")", "");
                    strPhoneNumber = Strings.Replace(strPhoneNumber, "(", "");
                    strPhoneNumber = Strings.Replace(strPhoneNumber, "-", "");
                    strPhoneNumber = Strings.Replace(strPhoneNumber, ".", "");
                    strPhoneNumber = Strings.Replace(strPhoneNumber, Strings.Space(1), "");
                    strPhoneNumber = Conversions.ToLong(strPhoneNumber).ToString("(###) ###-####");
                }
                else
                {
                    strPhoneNumber = "Wrong format";
                }
            }

            return strPhoneNumber;
        }
    }
}