using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Drawing;

namespace ShipSmpl
{
    public partial class FrmDisplayTemplates
    {
        public FrmDisplayTemplates()
        {
            InitializeComponent();
            _templatesListView.Name = "templatesListView";
            _typeToolStripComboBox.Name = "typeToolStripComboBox";
            _searchWordToolStripTextBox1.Name = "searchWordToolStripTextBox1";
            _newToolStripMenuItem.Name = "newToolStripMenuItem";
            _EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            _DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
        }

        private DatabaseHelperCeres db = new DatabaseHelperCeres();

        private void FrmDisplayTemplates_Load(object sender, EventArgs e)
        {
            templatesListView.Columns.Add("Title", 400);
            templatesListView.Columns.Add("Type", 265);
            templatesListView.Columns.Add("Department", 300);
            templatesListView.Columns.Add("", 0);
            foreach (DataRow template in db.getTableInfo("[Message Templates]", "distinct([Company Type])", " order by [Company Type]").Rows)
                typeToolStripComboBox.Items.Add(template["Company Type"]);
            typeToolStripComboBox.SelectedIndex = 0;
        }

        private void typeToolStripComboBox_Click(object sender, EventArgs e)
        {
            MdlScripts.populateTemplates(searchWordToolStripTextBox1.Text, Conversions.ToString(typeToolStripComboBox.SelectedItem), templatesListView);
        }

        private void searchWordToolStripTextBox1_Click(object sender, EventArgs e)
        {
            if (searchWordToolStripTextBox1.Text.Equals("Find..."))
            {
                searchWordToolStripTextBox1.ForeColor = Color.Black;
                searchWordToolStripTextBox1.Text = "";
            }
        }

        private void searchWordToolStripTextBox1_LostFocus(object sender, EventArgs e)
        {
            if (searchWordToolStripTextBox1.Text.Equals(""))
            {
                searchWordToolStripTextBox1.ForeColor = Color.Gray;
                searchWordToolStripTextBox1.Text = "Find...";
            }
        }

        private void searchWordToolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!searchWordToolStripTextBox1.Text.Equals(""))
            {
                MdlScripts.populateTemplates(searchWordToolStripTextBox1.Text, Conversions.ToString(typeToolStripComboBox.SelectedItem), templatesListView);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmCreatePreScript.Show();
            isupdate = false;
            My.MyProject.Forms.FrmCreatePreScript.createTemplateTouchButton.Caption = "Create Template";
            My.MyProject.Forms.FrmCreatePreScript.titleLabel.Text = "Create new message template";
            My.MyProject.Forms.FrmCreatePreScript.availableTitle.Hide();
            My.MyProject.Forms.FrmCreatePreScript.createTemplateTouchButton.Update();
        }

        public bool isupdate = false;
        public string previousTitle = "";

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int templateId = Conversions.ToInteger(templatesListView.Items[templatesListView.FocusedItem.Index].SubItems[3].Text);
            My.MyProject.Forms.FrmCreatePreScript.Show();
            isupdate = true;
            previousTitle = templatesListView.Items[templatesListView.FocusedItem.Index].SubItems[0].Text;
            My.MyProject.Forms.FrmCreatePreScript.createTemplateTouchButton.Caption = "Update Template";
            My.MyProject.Forms.FrmCreatePreScript.titleLabel.Text = "Update message template";
            My.MyProject.Forms.FrmCreatePreScript.createTemplateTouchButton.Update();
            MdlScripts.populateTemplateInfo(templateId);
        }

        private void templatesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (templatesListView.FocusedItem.Index > -1)
            {
                EditToolStripMenuItem.Enabled = true;
                DeleteToolStripMenuItem.Enabled = true;
            }
        }

        private void templatesListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (templatesListView.SelectedItems.Count > 0)
            {
                EditToolStripMenuItem.Enabled = true;
                DeleteToolStripMenuItem.Enabled = true;
            }
        }

        public bool isTemplate = false;

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                var withBlock = My.MyProject.Forms.FrmContactsWarningMessage;
                My.MyProject.Forms.FrmDisplayContacts.isContact = false;
                withBlock.messageLabel.Text = "Are you sure you want to delete '" + templatesListView.Items[templatesListView.FocusedItem.Index].SubItems[0].Text + "' ? This cannot be undone.";
                withBlock.Show();
                isTemplate = true;
            }
        }

        private void typeToolStripComboBox_Click_1(object sender, EventArgs e)
        {
            MdlScripts.populateTemplates(searchWordToolStripTextBox1.Text, Conversions.ToString(typeToolStripComboBox.SelectedItem), templatesListView);
        }
    }
}