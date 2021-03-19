using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;

namespace ShipSmpl
{
    public partial class FrmCreateUsernameAndPassword
    {
        public FrmCreateUsernameAndPassword()
        {
            InitializeComponent();
            _cancelButton.Name = "cancelButton";
            _saveButton.Name = "saveButton";
        }

        private DatabaseHelper db = new DatabaseHelper();

        private void loginButton_Click(object sender, EventArgs e)
        {
            var employeDataGridView = My.MyProject.Forms.FrmEmployeeManagement.BunifuDataGridView1;
            int employeeID = Conversions.ToInteger(employeDataGridView.Rows[employeDataGridView.CurrentRow.Index].Cells[6].Value);
            if (string.IsNullOrEmpty(usernameTextBox.Text) | string.IsNullOrEmpty(passwordTextBox.Text) | string.IsNullOrEmpty(confirmTextBox.Text))
            {
                nameOfemployeLabel.Text = "Please, make sure to fill all the required fields";
                nameOfemployeLabel.BackColor = Color.Firebrick;
            }
            else if (!confirmTextBox.Text.Equals(passwordTextBox.Text))
            {
                nameOfemployeLabel.Text = "Passwords don't match";
                nameOfemployeLabel.BackColor = Color.Firebrick;
            }
            else if (employeDataGridView.SelectedRows.Count > 0)
            {
                db.createUsername(employeeID, Strings.Trim(usernameTextBox.Text), MdlModifyData.base64Encode(Strings.Trim(passwordTextBox.Text)));
                nameOfemployeLabel.Text = "Success";
                nameOfemployeLabel.BackColor = Color.Green;
            }
            else
            {
                nameOfemployeLabel.Text = "Please, select an employee to proceed";
                nameOfemployeLabel.BackColor = Color.Firebrick;
            }
            // MdlControllerModifier.deactivateButtons(FrmEmployeeManagement.modifyButton,
            // FrmEmployeeManagement.terminateButton,
            // FrmEmployeeManagement.cardIDButton,
            // FrmEmployeeManagement.deleteButton)
            MdlControllerModifier.pause(2000);
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
            nameOfemployeLabel.Text = "Select Employee and fill up the informations";
            nameOfemployeLabel.BackColor = Color.DarkSlateGray;
        }

        private void FrmCreateUsernameAndPassword_Load(object sender, EventArgs e)
        {
            var employeDataGridView = My.MyProject.Forms.FrmEmployeeManagement.BunifuDataGridView1;
            string firstName = Conversions.ToString(employeDataGridView.Rows[employeDataGridView.CurrentRow.Index].Cells[1].Value);
            string lastName = Conversions.ToString(employeDataGridView.Rows[employeDataGridView.CurrentRow.Index].Cells[2].Value);
            nameOfemployeLabel.Text = "Create username and password for " + firstName + " " + lastName;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}