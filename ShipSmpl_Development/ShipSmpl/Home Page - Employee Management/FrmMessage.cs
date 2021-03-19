using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmMessage
    {
        public FrmMessage()
        {
            InitializeComponent();
            _sendEmailTouchButton.Name = "sendEmailTouchButton";
            _canceEmaillTouchButton.Name = "canceEmaillTouchButton";
            _cancelMessageTouchButton.Name = "cancelMessageTouchButton";
            _sendMessageTouchButton.Name = "sendMessageTouchButton";
        }

        private void cancelMessageTouchButton_Load(object sender, EventArgs e)
        {
            Close();
        }

        private void canceEmaillTouchButton_Load(object sender, EventArgs e)
        {
            Close();
        }

        private void sendEmailTouchButton_Load(object sender, EventArgs e)
        {
            string receiver = Strings.Trim(ToEmailComboBox.Text.Split('-')[1]);
            if (!string.IsNullOrEmpty(ToEmailComboBox.Text) & !string.IsNullOrEmpty(messageEmailRichTextBox.Text))
            {
                MdlOptionsManagement.sendEmailNotification(ToEmailComboBox.Text, "WesternTransloadingIT@gmail.com", subjectEmailTextBox.Text, messageEmailRichTextBox.Text);
            }
        }

        private void FrmMessage_Load(object sender, EventArgs e)
        {
            var db = new DatabaseHelper();
            fromEmailTextBox.Text = "WesternTransloadingIT@gmail.com";
            foreach (DataRow employee in (IEnumerable)db.getAllActiveEmployees("and email <> '' ").Rows)
                ToEmailComboBox.Items.Add(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(employee["Alias"], " "), employee["Last_Name"]), " - "), employee["Email"]));
            foreach (DataRow employee in db.getAllActiveEmployees("").Rows)
            {
                ToEmailComboBox.Items.Add(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(employee["Alias"], " "), employee["Last_Name"]), " - "), employee["Email"]));
                employeesListView.Items.Add(new ListViewItem(new[] { Conversions.ToString(Operators.AddObject(Operators.AddObject(employee["Alias"], " "), employee["Last_Name"])), Conversions.ToString(employee["ID"]) }));
            }
        }

        private DatabaseHelper db = new DatabaseHelper();
        private bool messageSaved = false;

        private void sendMessageTouchButton_Load(object sender, EventArgs e)
        {
            if (messageSaved == false)
            {
                if (!string.IsNullOrEmpty(subjectTextBox.Text) & !string.IsNullOrEmpty(messageEmployeeRichTextBox.Text) & employeesListView.SelectedIndices.Count > 0)
                {
                    db.saveNotification(Conversions.ToInteger(employeesListView.Items[employeesListView.FocusedItem.Index].SubItems[1].Text), "Message", "MESSAGE - " + subjectTextBox.Text, messageEmployeeRichTextBox.Text, " where ID = 0");
                    titleemployeeLabel.BackColor = Color.Green;
                    titleemployeeLabel.Text = "Message sent!";
                    titleemployeeLabel.Update();
                    MdlControllerModifier.pause(2000);
                    Close();
                }
                else
                {
                    titleemployeeLabel.Text = "Please, make sure the employee is selected and all the fields are filled up";
                    titleemployeeLabel.BackColor = Color.Red;
                }

                messageSaved = true;
            }
        }
    }
}