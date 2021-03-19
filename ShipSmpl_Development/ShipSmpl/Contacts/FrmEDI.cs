using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmEDI
    {
        public FrmEDI()
        {
            InitializeComponent();
            _userServerCheckBox.Name = "userServerCheckBox";
            _emailEDICheckBox.Name = "emailEDICheckBox";
            _saveButton.Name = "saveButton";
            _cancelButton.Name = "cancelButton";
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (emailEDICheckBox.Checked)
            {
                ediEmailTableLayoutPanel.Show();
            }
            else
            {
                ediEmailTableLayoutPanel.Hide();
            }
        }

        private void CheckBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (userServerCheckBox.Checked)
            {
                serverTableLayoutPanel.Show();
                Size = (Size)new Point(1338, 803);
                StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                serverTableLayoutPanel.Hide();
                Size = (Size)new Point(1338, 485);
                StartPosition = FormStartPosition.CenterScreen;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var edi = new Dictionary<string, string>();
            int requireEDI = 0;
            int allowPresend = 0;
            int useFTP = 0;
            int useEmail = 0;
            if (requireEDIInOutGatesCheckBox1.Checked)
            {
                requireEDI = 1;
            }

            if (preSendsCheckBox2.Checked)
            {
                allowPresend = 1;
            }

            if (userServerCheckBox.Checked)
            {
                useFTP = 1;
            }

            if (emailEDICheckBox.Checked)
            {
                useEmail = 1;
            }

            edi.Add("Client ID", clientTextBox.Text);
            edi.Add("Sender ID", senderTextBox.Text);
            edi.Add("Client SCAC Code", codeTextBox.Text);
            edi.Add("Version", versionTextBox.Text);
            edi.Add("Security Code", securityCodeTextBox1.Text);
            edi.Add("Line Delimiter", lineDelimeterTextBox2.Text);
            edi.Add("Require EDI", requireEDI.ToString());
            edi.Add("AllowPresend", allowPresend.ToString());
            edi.Add("Use FTP", useFTP.ToString());
            edi.Add("Use Email", useEmail.ToString());
            edi.Add("Email", emailTextBox3.Text);
            edi.Add("Server Name", serverNameTextBox6.Text);
            edi.Add("User Name", userNameTextBox5.Text);
            edi.Add("Password", passwordTextBox7.Text);
            edi.Add("IP Address", ipAddressTextBox8.Text);
            edi.Add("Port Number", portNumberNumericUpDown1.Value.ToString());
            edi.Add("Folder Name", folderNameTextBox10.Text);
            edi.Add("Booking Prefix", prefixTextBox9.Text);
            My.MyProject.Forms.FrmAddOrganization.edi = edi;
            My.MyProject.Forms.FrmAddOrganization.ediTextBox.Text = clientTextBox.Text;
            Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmEDI_Load(object sender, EventArgs e)
        {
            Size = (Size)new Point(1338, 485);
            StartPosition = FormStartPosition.CenterScreen;
        }
    }
}