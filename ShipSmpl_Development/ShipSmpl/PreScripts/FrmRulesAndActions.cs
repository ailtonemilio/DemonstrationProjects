using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;

namespace ShipSmpl
{
    public partial class FrmRulesAndActions
    {
        public FrmRulesAndActions()
        {
            InitializeComponent();
            _rulesListView.Name = "rulesListView";
            _closeTouchButton.Name = "closeTouchButton";
            _ruleAndActionTextBox.Name = "ruleAndActionTextBox";
            _CompanyToolStripMenuItem.Name = "CompanyToolStripMenuItem";
            _EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            _DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            _createUpdateTouchButton.Name = "createUpdateTouchButton";
        }

        private DatabaseHelperCeres db = new DatabaseHelperCeres();
        public string tableName;
        public string nameOfAction;

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rulesListView.SelectedIndices.Count > 0)
            {
                EditToolStripMenuItem.Enabled = true;
                DeleteToolStripMenuItem.Enabled = true;
            }
            else
            {
                EditToolStripMenuItem.Enabled = false;
                DeleteToolStripMenuItem.Enabled = false;
            }
        }

        private void TouchButton1_Load(object sender, EventArgs e)
        {
            Close();
        }

        private void createUpdateTouchButton_Load(object sender, EventArgs e)
        {
            int selectedItem;
            int ruleID = 0;
            createUpdateTouchButton.Hide();
            ruleAndActionTextBox.Text = Strings.Trim(ruleAndActionTextBox.Text);
            if (!createUpdateTouchButton.Caption.Equals("Create " + nameOfAction))
            {
                selectedItem = rulesListView.FocusedItem.Index;
                ruleID = Conversions.ToInteger(rulesListView.Items[selectedItem].SubItems[1].Text);
            }

            if (!string.IsNullOrEmpty(ruleAndActionTextBox.Text))
            {
                db.saveRule(ruleID, tableName, ruleAndActionTextBox.Text);
                MdlScripts.populateMessageRules(rulesListView, tableName);
                titleLabel.Text = "Success!";
                titleLabel.BackColor = Color.Green;
                Size = (Size)new Point(533, 510);
                Location = new Point((int)Math.Round((My.MyProject.Computer.Screen.Bounds.Size.Width - Width) / 2d), (int)Math.Round((My.MyProject.Computer.Screen.Bounds.Size.Height - Height) / 2d));
                closeTouchButton.Location = new Point(470, 12);
                My.MyProject.Forms.FrmCreatePreScript.rulesListView.Items.Add(ruleAndActionTextBox.Text);
                ruleAndActionTextBox.Text = "";
            }
            else
            {
                titleLabel.Text = "Please write down the title";
                titleLabel.BackColor = Color.Red;
            }
        }

        private void FrmPreScriptRules_Load(object sender, EventArgs e)
        {
            createUpdateTouchButton.Caption = "Create " + nameOfAction;
            titleLabel.Text = "Manage " + nameOfAction + "s";
            subTitleLabel.Text = "Select existing " + nameOfAction.ToLower() + " to edit, delete or create a new one";
            ruleActionLabel.Text = nameOfAction + " Name";
            MdlScripts.populateMessageRules(rulesListView, tableName);
            Size = (Size)new Point(533, 510);
            Location = new Point((int)Math.Round((My.MyProject.Computer.Screen.Bounds.Size.Width - Width) / 2d), (int)Math.Round((My.MyProject.Computer.Screen.Bounds.Size.Height - Height) / 2d));
            closeTouchButton.Location = new Point(470, 12);
        }

        private void ruleTextBox_TextChanged(object sender, EventArgs e)
        {
            titleLabel.Text = "Manage Rules";
            titleLabel.BackColor = Color.FromArgb(64, 64, 0);
            availableTitlePictureBox.Show();
            if (db.infoAvailable(tableName, "where Title = '" + ruleAndActionTextBox.Text + "'") | string.IsNullOrEmpty(ruleAndActionTextBox.Text))
            {
                availableTitlePictureBox.Image = My.Resources.Resources.icon_available;
                createUpdateTouchButton.Show();
            }
            else
            {
                availableTitlePictureBox.Image = My.Resources.Resources.icon_not_available;
                createUpdateTouchButton.Show();
            }
        }

        private void rulesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rulesListView.SelectedIndices.Count > 0)
            {
                EditToolStripMenuItem.Enabled = true;
                DeleteToolStripMenuItem.Enabled = true;
            }
            else
            {
                EditToolStripMenuItem.Enabled = false;
                DeleteToolStripMenuItem.Enabled = false;
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedItem = rulesListView.FocusedItem.Index;
            int ruleID = Conversions.ToInteger(rulesListView.Items[selectedItem].SubItems[1].Text);
            db.deleteRows(tableName, "where ID = " + ruleID.ToString());
            MdlScripts.populateMessageRules(rulesListView, tableName);
            Size = (Size)new Point(533, 510);
            Location = new Point((int)Math.Round((My.MyProject.Computer.Screen.Bounds.Size.Width - Width) / 2d), (int)Math.Round((My.MyProject.Computer.Screen.Bounds.Size.Height - Height) / 2d));
            closeTouchButton.Location = new Point(470, 12);
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size = (Size)new Point(928, 510);
            Location = new Point((int)Math.Round((My.MyProject.Computer.Screen.Bounds.Size.Width - Width) / 2d), (int)Math.Round((My.MyProject.Computer.Screen.Bounds.Size.Height - Height) / 2d));
            closeTouchButton.Location = new Point(862, 12);
            int selectedItem = rulesListView.FocusedItem.Index;
            ruleAndActionTextBox.Text = rulesListView.Items[selectedItem].SubItems[0].Text;
            createUpdateTouchButton.Caption = "Update " + nameOfAction;
        }

        private void CompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size = (Size)new Point(928, 510);
            Location = new Point((int)Math.Round((My.MyProject.Computer.Screen.Bounds.Size.Width - Width) / 2d), (int)Math.Round((My.MyProject.Computer.Screen.Bounds.Size.Height - Height) / 2d));
            closeTouchButton.Location = new Point(862, 12);
        }
    }
}