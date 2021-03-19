using Microsoft.VisualBasic.CompilerServices;
using System;

namespace ShipSmpl
{
    public partial class FrmContactsWarningMessage
    {
        public FrmContactsWarningMessage()
        {
            InitializeComponent();
            _noBunifuButton.Name = "noBunifuButton";
            _yesBunifuButton.Name = "yesBunifuButton";
            _Label2.Name = "Label2";
        }

        private DatabaseHelperCeres db = new DatabaseHelperCeres();

        private void TouchButton1_Load(object sender, EventArgs e)
        {
            Close();
        }

        private void TouchButton2_Load(object sender, EventArgs e)
        {
            Close();
        }

        private void yesTouchButton_Load(object sender, EventArgs e)
        {
            if (My.MyProject.Forms.FrmDisplayContacts.isContact)
            {
                int selectedRowContact = My.MyProject.Forms.FrmDisplayContacts.contactsBunifuDataGridView.CurrentCell.RowIndex;
                int contactID = Conversions.ToInteger(My.MyProject.Forms.FrmDisplayContacts.contactsBunifuDataGridView.Rows[selectedRowContact].Cells[5].Value);
                db.deleteRows("Contacts", " where ID = " + contactID.ToString());
                My.MyProject.Forms.FrmDisplayContacts.contactsBunifuDataGridView.Rows.RemoveAt(selectedRowContact);
            }
            else if (My.MyProject.Forms.FrmDisplayTemplates.isTemplate)
            {
                db.deleteRows("[Message Templates]", " where ID = " + My.MyProject.Forms.FrmDisplayTemplates.templatesListView.Items[My.MyProject.Forms.FrmDisplayTemplates.templatesListView.FocusedItem.Index].SubItems[3].Text);
                My.MyProject.Forms.FrmDisplayTemplates.templatesListView.Items[My.MyProject.Forms.FrmDisplayTemplates.templatesListView.FocusedItem.Index].Remove();
            }
            else
            {
                int selectedRow = My.MyProject.Forms.FrmDisplayContacts.companiesBunifuDataGridView.CurrentCell.RowIndex;
                int companyID = Conversions.ToInteger(My.MyProject.Forms.FrmDisplayContacts.companiesBunifuDataGridView.Rows[selectedRow].Cells[4].Value);
                db.deleteRows("Company", " where CompanyID = " + companyID.ToString());
                My.MyProject.Forms.FrmDisplayContacts.companiesBunifuDataGridView.Rows.RemoveAt(selectedRow);
            }

            Close();
        }

        private void okTouchButton_ButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}