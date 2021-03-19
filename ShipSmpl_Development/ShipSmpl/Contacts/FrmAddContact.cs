using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmAddContact
    {
        public FrmAddContact()
        {
            InitializeComponent();
            _newDepartamentLabel.Name = "newDepartamentLabel";
            _areaFaxTextBox.Name = "areaFaxTextBox";
            _areaWorkPhoneTextBox.Name = "areaWorkPhoneTextBox";
            _areaMobileTextBox.Name = "areaMobileTextBox";
            _saveButton.Name = "saveButton";
            _cancelButton.Name = "cancelButton";
            _editButton.Name = "editButton";
        }

        private DatabaseHelperCeres db = new DatabaseHelperCeres();

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void areaMobileTextBox_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & !char.IsControl(e.KeyChar))
            {
                e.KeyChar = Conversions.ToChar("");
            }
        }

        private void areaFaxTextBox_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & !char.IsControl(e.KeyChar))
            {
                e.KeyChar = Conversions.ToChar("");
            }
        }

        private void areaWorkPhoneTextBox_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & !char.IsControl(e.KeyChar))
            {
                e.KeyChar = Conversions.ToChar("");
            }
        }

        public Dictionary<string, string> secondAddress = new Dictionary<string, string>();

        private void saveButton_Click(object sender, EventArgs e)
        {
            int contactID = 0;
            // Dim contactID As Integer = 0

            int selectedRow = My.MyProject.Forms.FrmDisplayContacts.companiesBunifuDataGridView.CurrentCell.RowIndex;
            int companyID = Conversions.ToInteger(My.MyProject.Forms.FrmDisplayContacts.companiesBunifuDataGridView.Rows[selectedRow].Cells[4].Value);
            if (!string.IsNullOrEmpty(firstNameTextBox.Text))
            {
                if (My.MyProject.Forms.FrmDisplayContacts.isNewContact == false)
                {
                    int selectedRowContact = My.MyProject.Forms.FrmDisplayContacts.contactsBunifuDataGridView.CurrentCell.RowIndex;
                    contactID = Conversions.ToInteger(My.MyProject.Forms.FrmDisplayContacts.contactsBunifuDataGridView.Rows[selectedRowContact].Cells[5].Value);
                }

                if (!string.IsNullOrEmpty(homeAddressRichTextBox.Text))
                {
                    db.saveAddress(secondAddress, companyID, "Contact", 0);
                }

                db.saveContact(contactID, companyID, firstNameTextBox.Text, lastNameTextBox.Text, Strings.Trim(areaWorkPhoneTextBox.Text + " " + workPhoneTextBox.Text), Strings.Trim(areaMobileTextBox.Text + " " + mobileTextBox.Text), Strings.Trim(areaFaxTextBox.Text + " " + faxTextBox.Text), Strings.Trim(emailTextBox.Text), extensionTextBox.Text, departamentComboBox.Text.ToUpper(), db.getLastAddress(companyID), notesRichTextBox.Text);
                Close();
            }
            else
            {
            }

            My.MyProject.Forms.FrmDisplayContacts.populateContacts("");
        }

        public bool isContact = false;

        private void Button1_Click(object sender, EventArgs e)
        {
            int contactID = 0;
            if (My.MyProject.Forms.FrmDisplayContacts.isNewContact == false)
            {
                int selectedRowContact = My.MyProject.Forms.FrmDisplayContacts.contactsBunifuDataGridView.CurrentCell.RowIndex;
                contactID = Conversions.ToInteger(My.MyProject.Forms.FrmDisplayContacts.contactsBunifuDataGridView.Rows[selectedRowContact].Cells[5].Value);
            }

            string query = "";
            var secondAddress = db.getTableInfo("Addresses A, Contacts C", "A.ID", "where A.ID = C.[Second Address ID] and C.ID = " + contactID.ToString());
            if (secondAddress.Rows.Count != 0)
            {
                int secondAddressID = Conversions.ToInteger(secondAddress.Rows[0]["ID"]);
                // populateAddressInfo("where [ID] = " + secondAddressID.ToString)
            }

            My.MyProject.Forms.FrmEditAddress.Show();
            // addAddresses(1)
            isContact = true;
        }

        private bool editDepartment = false;

        private void newDepartamentLabel_Click(object sender, EventArgs e)
        {
            if (editDepartment == false)
            {
                departamentComboBox.DropDownStyle = ComboBoxStyle.DropDown;
                departamentComboBox.Text = "";
                editDepartment = true;
            }
            else if (editDepartment)
            {
                departamentComboBox.Items.Add(departamentComboBox.Text.ToUpper());
                departamentComboBox.SelectedIndex = departamentComboBox.Items.Count - 1;
                departamentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                editDepartment = false;
            }
        }
    }
}