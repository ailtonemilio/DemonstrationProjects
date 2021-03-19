using BusinessLayer.WTC_Ceres;
using DataLayer.WTC_Ceres;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer.CustomModel;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmDisplayContacts
    {
        public FrmDisplayContacts()
        {
            InitializeComponent();
            _addNewContactButton.Name = "addNewContactButton";
            _editContactButton.Name = "editContactButton";
            _deleteContactButton.Name = "deleteContactButton";
            _findContactTextBox.Name = "findContactTextBox";
            _tbSearchCompany.Name = "tbSearchCompany";
            _contactsBunifuDataGridView.Name = "contactsBunifuDataGridView";
            _companiesBunifuDataGridView.Name = "companiesBunifuDataGridView";
            _EditButton.Name = "EditButton";
            _DeleteCompanyButton.Name = "DeleteCompanyButton";
            _newCompanyButton.Name = "newCompanyButton";
        }

        private DatabaseHelperCeres db = new DatabaseHelperCeres();
        private SortableBindingList<VW_Company> companyList = new SortableBindingList<VW_Company>();

        public bool isAnUpdate { get; set; } = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            companyList = new SortableBindingList<VW_Company>(CompanyService.GetAllActiveVWCompany().Where(c => c.CompanyId != 0).ToList());
            VWCompanyBindingSource.DataSource = companyList;
            // With typeComboBox
            // .DataSource = CompanyService.GetAllCompanyType()
            // .DisplayMember = "DescCompanyType"
            // .ValueMember = "CompanyTypeId"
            // End With

            // typeComboBox.SelectedIndex = 0
            // FrmAddOrganization.typeComboBox.SelectedIndex = 0
        }

        private void CompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isAnUpdate = false;
            My.MyProject.Forms.FrmAddOrganization.loadForm();
            My.MyProject.Forms.FrmAddOrganization.typeNewCompanyModePanel.Visible = true;
            My.MyProject.Forms.FrmAddOrganization.typeNewCompanyModePanel.BringToFront();
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAddOrganization, My.MyProject.Forms.FrmParentScreen);
            companyList = new SortableBindingList<VW_Company>(CompanyService.GetAllActiveVWCompany().Where(c => c.CompanyId != 0).ToList());
            VWCompanyBindingSource.DataSource = companyList;
            // 'focusedForm = FrmAddOrganization
            // FrmAddOrganization.ShowDialog()
            // FrmAddOrganization.TableLayoutPanel14.Visible = False
        }

        public Form focusedForm = new Form();

        private void EditButton_Click(object sender, EventArgs e)
        {
            VW_Company c = (VW_Company)companiesBunifuDataGridView.CurrentRow.DataBoundItem;
            My.MyProject.Forms.FrmAddOrganization.loadForm();
            My.MyProject.Forms.FrmAddOrganization.PopulateInfo(c.CompanyId);
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAddOrganization, My.MyProject.Forms.FrmParentScreen);
            companyList = new SortableBindingList<VW_Company>(CompanyService.GetAllActiveVWCompany().Where(cvw => cvw.CompanyId != 0).ToList());
            VWCompanyBindingSource.DataSource = companyList;
        }

        public bool editContactIsClicked;

        private void ToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            isNewContact = false;
            int selectedRow = contactsBunifuDataGridView.CurrentRow.Index;
            editContactIsClicked = true;
            My.MyProject.Forms.FrmAddContact.Label14.Text = Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject("Edit ", contactsBunifuDataGridView.Rows[selectedRow].Cells[0].Value), " "), contactsBunifuDataGridView.Rows[selectedRow].Cells[1].Value));
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAddContact, My.MyProject.Forms.FrmParentScreen);
        }

        private void companiesBunifuDataGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.populateContacts(findContactTextBox.Text);
        }

        private void typeToolStripComboBox_Click(object sender, EventArgs e)
        {
            activateOrDeactivateButtons();
            companiesBunifuDataGridView.AutoResizeColumns();
        }

        private void ToolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            var l = companyList.Where(c => c.CompanyName.ToUpper().Contains(tbSearchCompany.Text.ToUpper()) | c.CompanyCode.ToUpper().Contains(tbSearchCompany.Text.ToUpper()) | c.Website.ToUpper().Contains(tbSearchCompany.Text.ToUpper()) | c.CategoryName.ToUpper().Contains(tbSearchCompany.Text.ToUpper()) | c.Email.ToUpper().Contains(tbSearchCompany.Text.ToUpper())).ToList();
            VWCompanyBindingSource.DataSource = l;
            activateOrDeactivateButtons();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRow = companiesBunifuDataGridView.CurrentCell.RowIndex;
            var companyName = companiesBunifuDataGridView.Rows[selectedRow].Cells[1].Value;
            if (companiesBunifuDataGridView.SelectedRows.Count > 0)
            {
                isContact = false;
                var result = My.MyProject.Forms.MessageBoxCeresYesNo.ShowDialog("Are you sure about this?", Conversions.ToString(Operators.AddObject(Operators.AddObject("Are you sure you want to delete '", companyName), "' ? This can not be undone.")), My.Resources.Resources.warning, this);
                if (result == DialogResult.Yes)
                {
                    var cs = new CompanyService();
                    int companyId = Conversions.ToInteger(companiesBunifuDataGridView.Rows[companiesBunifuDataGridView.CurrentRow.Index].Cells[4].Value);
                    cs.Delete(companyId);
                    // populateCompanies("")
                }
            }

            if (companiesBunifuDataGridView.Rows.Count > 0)
            {
                addNewContactButton.Enabled = true;
                EditButton.Enabled = true;
                DeleteCompanyButton.Enabled = true;
                this.populateContacts(findContactTextBox.Text);
            }
            else
            {
                contactsBunifuDataGridView.Rows.Clear();
                EditButton.Enabled = false;
                addNewContactButton.Enabled = false;
                DeleteCompanyButton.Enabled = false;
            }
        }

        public bool isNewContact = false;

        private void adNewContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isNewContact = true;
            int selectedRow = companiesBunifuDataGridView.CurrentCell.RowIndex;
            var companyName = companiesBunifuDataGridView.Rows[selectedRow].Cells[1].Value;
            var mainCompanyAddress = db.getTableInfo("[Addresses]", "Address", "where [Main Address] = 1").Rows[0];
            My.MyProject.Forms.FrmAddContact.WorkAddressRichTextBox.Text = Conversions.ToString(mainCompanyAddress["Address"]);
            My.MyProject.Forms.FrmAddContact.organizationTextBox.Text = Conversions.ToString(companyName);
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAddContact, My.MyProject.Forms.FrmParentScreen);

            // FrmAddContact.ShowDialog()
        }

        private void companiesBunifuDataGridView_1(object sender, EventArgs e)
        {
            activateOrDeactivateButtons();
        }

        private void ToolStripTextBox1_Click_1(object sender, EventArgs e)
        {
            activateOrDeactivateButtons();
        }

        private void contactsListView_Click(object sender, EventArgs e)
        {
            activateOrDeactivateButtons();
        }

        private void findContactToolStripTextBox_Click(object sender, EventArgs e)
        {
            activateOrDeactivateButtons();
        }

        private void findContactToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            this.populateContacts(findContactTextBox.Text);
        }

        public bool isContact = true;

        private void deleteContactToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (companiesBunifuDataGridView.SelectedRows.Count > 0)
            {
                int selectedRow = contactsBunifuDataGridView.CurrentCell.RowIndex;
                string firstName = Conversions.ToString(contactsBunifuDataGridView.Rows[selectedRow].Cells[0].Value);
                string lastName = Conversions.ToString(contactsBunifuDataGridView.Rows[selectedRow].Cells[1].Value);
                isContact = true;
                My.MyProject.Forms.FrmContactsWarningMessage.messageLabel.Text = "Are you sure you want to delete contact '" + firstName + " " + lastName + "' ? This can not be undone.";
                MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmContactsWarningMessage, My.MyProject.Forms.FrmParentScreen);
            }
        }

        public void populateContacts(string searchWord)
        {
            int count = contactsBunifuDataGridView.Rows.Count - 1;
            while (count >= 0)
            {
                contactsBunifuDataGridView.Rows.RemoveAt(count);
                count = contactsBunifuDataGridView.Rows.Count - 1;
            }

            string condition = "";
            if (companiesBunifuDataGridView.SelectedRows.Count > 0)
            {
                int selectedRow = companiesBunifuDataGridView.CurrentCell.RowIndex;
                int companyID = Conversions.ToInteger(companiesBunifuDataGridView.Rows[selectedRow].Cells[4].Value);
                if (!searchWord.Equals(""))
                {
                    condition = "where [First Name] LIKE '%" + searchWord + "%' or [Last Name] Like '%" + searchWord + "%' or [Phone] Like '%" + searchWord + "%' or department Like '%" + searchWord + "%' or Mobile Like '%" + searchWord + "%' " + "and [Company ID] =" + companyID.ToString();
                }
                else
                {
                    condition = "where [Company ID] =" + companyID.ToString();
                }

                foreach (DataRow contact in db.getTableInfo("Contacts", "*", condition).Rows)
                    contactsBunifuDataGridView.Rows.Add(contact["First Name"], contact["Last Name"], contact["Email"], contact["Mobile"], contact["Department"], contact["ID"]);
            }
        }

        public void activateOrDeactivateButtons()
        {
            if (companiesBunifuDataGridView.Rows.Count > 0)
            {
                EditButton.Enabled = true;
                DeleteCompanyButton.Enabled = true;
                addNewContactButton.Enabled = true;
            }
            // populateContacts(findContactTextBox.Text)
            else
            {
                // contactsBunifuDataGridView.Rows.Clear()
                EditButton.Enabled = false;
                DeleteCompanyButton.Enabled = false;
                addNewContactButton.Enabled = false;
            }

            if (contactsBunifuDataGridView.SelectedRows.Count > 0)
            {
                editContactButton.Enabled = true;
                deleteContactButton.Enabled = true;
            }
            else
            {
                editContactButton.Enabled = false;
                deleteContactButton.Enabled = false;
            }
        }
    }
}