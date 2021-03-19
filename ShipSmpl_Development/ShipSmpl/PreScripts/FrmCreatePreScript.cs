using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Drawing;

namespace ShipSmpl
{
    public partial class FrmCreatePreScript
    {
        public FrmCreatePreScript()
        {
            InitializeComponent();
            _companyNameShapedLabel.Name = "companyNameShapedLabel";
            _containerWeightShapedLabel.Name = "containerWeightShapedLabel";
            _bookingStatusShapedLabel.Name = "bookingStatusShapedLabel";
            _TouchButton2.Name = "TouchButton2";
            _createTemplateTouchButton.Name = "createTemplateTouchButton";
            _tamplateTitleTextBox.Name = "tamplateTitleTextBox";
            _messageRichTextBox.Name = "messageRichTextBox";
            _containerNumberShapedLabel.Name = "containerNumberShapedLabel";
            _dateShapedLabel.Name = "dateShapedLabel";
            _bookingNumberShapedLabel.Name = "bookingNumberShapedLabel";
            _addActionLabel.Name = "addActionLabel";
            _addRuleLabel.Name = "addRuleLabel";
            _Button1.Name = "Button1";
            _editRulesLabel.Name = "editRulesLabel";
        }

        private DatabaseHelperCeres db = new DatabaseHelperCeres();
        public bool isMessageRule;

        private void TouchButton2_Load(object sender, EventArgs e)
        {
            Close();
        }

        private void containerNumberShapedLabel_Click(object sender, EventArgs e)
        {
            MdlScripts.addTagLabel(containerNumberShapedLabel, Color.Teal, messageRichTextBox);
        }

        private void companyNameShapedLabel_Click(object sender, EventArgs e)
        {
            MdlScripts.addTagLabel(companyNameShapedLabel, Color.FromArgb(192, 64, 0), messageRichTextBox);
        }

        private void dateShapedLabel_Click(object sender, EventArgs e)
        {
            MdlScripts.addTagLabel(dateShapedLabel, Color.FromArgb(128, 64, 64), messageRichTextBox);
        }

        private void containerWeightShapedLabel_Click(object sender, EventArgs e)
        {
            MdlScripts.addTagLabel(containerWeightShapedLabel, Color.Green, messageRichTextBox);
        }

        private void bookingNumberShapedLabel_Click(object sender, EventArgs e)
        {
            MdlScripts.addTagLabel(bookingNumberShapedLabel, Color.Olive, messageRichTextBox);
        }

        private void bookingStatusShapedLabel_Click(object sender, EventArgs e)
        {
            MdlScripts.addTagLabel(bookingStatusShapedLabel, Color.Gray, messageRichTextBox);
        }

        private void createTemplateTouchButton_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tamplateTitleTextBox.Text) & !string.IsNullOrEmpty(messageRichTextBox.Text))
            {
                if (isNewTitle)
                {
                    titleLabel.BackColor = Color.FromArgb(0, 64, 64);
                    int templateID = 0;
                    if (My.MyProject.Forms.FrmDisplayTemplates.isupdate)
                    {
                        templateID = Conversions.ToInteger(My.MyProject.Forms.FrmDisplayTemplates.templatesListView.Items[My.MyProject.Forms.FrmDisplayTemplates.templatesListView.FocusedItem.Index].SubItems[3].Text);
                    }

                    db.saveTemplate(templateID, Strings.Trim(tamplateTitleTextBox.Text), Conversions.ToString(typeComboBox.SelectedItem), Conversions.ToString(departmentComboBox.SelectedItem), messageRichTextBox);
                    // display confirmation message and clean fields

                    if (My.MyProject.Forms.FrmDisplayTemplates.isupdate)
                    {
                        titleLabel.Text = "Template updated!";
                    }
                    else
                    {
                        titleLabel.Text = "Template created!";
                    }

                    titleLabel.BackColor = Color.Green;
                    messageRichTextBox.Text = "";
                    tamplateTitleTextBox.Text = "";
                    typeComboBox.SelectedIndex = 0;
                    departmentComboBox.SelectedIndex = 0;
                    MdlScripts.populateTemplates(My.MyProject.Forms.FrmDisplayTemplates.searchWordToolStripTextBox1.Text, Conversions.ToString(My.MyProject.Forms.FrmDisplayTemplates.typeToolStripComboBox.SelectedItem), My.MyProject.Forms.FrmDisplayTemplates.templatesListView);
                    if (My.MyProject.Forms.FrmDisplayTemplates.isupdate)
                    {
                        titleLabel.Text = "Template updated!";
                    }
                    // Me.Close()
                    else
                    {
                        titleLabel.Text = "Template created!";
                    }
                }
                else
                {
                    titleLabel.Text = "Template title already exists";
                    titleLabel.BackColor = Color.Firebrick;
                }
            }
        }

        private void FrmCreatePreScript_Load(object sender, EventArgs e)
        {
            foreach (DataRow department in db.getTableInfo("Contacts", "distinct(Department)", "order by department").Rows)
                departmentComboBox.Items.Add(department["Department"]);
            departmentComboBox.SelectedIndex = 0;
            typeComboBox.SelectedIndex = 0;
        }

        private void messageRichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!messageRichTextBox.Text.Equals(""))
            {
                titleLabel.Text = "Create Template";
                titleLabel.BackColor = Color.FromArgb(0, 64, 64);
            }
        }

        private bool isNewTitle = true;

        private void tamplateTitleTextBox_TextChanged(object sender, EventArgs e)
        {
            availableTitle.Show();
            titleLabel.BackColor = Color.FromArgb(0, 64, 64);
            if (My.MyProject.Forms.FrmDisplayTemplates.isupdate)
            {
                titleLabel.Text = "Update message template";
            }
            else
            {
                titleLabel.Text = "Create new message template";
            }

            if (!string.IsNullOrEmpty(tamplateTitleTextBox.Text))
            {
                if (My.MyProject.Forms.FrmDisplayTemplates.isupdate & !My.MyProject.Forms.FrmDisplayTemplates.previousTitle.Equals(tamplateTitleTextBox.Text) | My.MyProject.Forms.FrmDisplayTemplates.isupdate == false)
                {
                    string condition = "where Title = '" + tamplateTitleTextBox.Text + "'";
                    if (db.infoAvailable("[Message Templates]", condition))
                    {
                        availableTitle.Image = My.Resources.Resources.icon_available;
                        isNewTitle = true;
                    }
                    else
                    {
                        availableTitle.Image = My.Resources.Resources.icon_not_available;
                        isNewTitle = false;
                    }
                }
                else
                {
                    availableTitle.Hide();
                    isNewTitle = true;
                }
            }
            else
            {
                availableTitle.Image = My.Resources.Resources.icon_not_available;
                isNewTitle = false;
            }
        }

        private void editRulesLabel_Click(object sender, EventArgs e)
        {
            if (isMessageRule)
            {
                My.MyProject.Forms.FrmRulesAndActions.tableName = "[Message Rules]";
                My.MyProject.Forms.FrmRulesAndActions.nameOfAction = "Rule";
            }
            else
            {
                My.MyProject.Forms.FrmRulesAndActions.tableName = "[Message Actions]";
                My.MyProject.Forms.FrmRulesAndActions.nameOfAction = "Action";
            }

            My.MyProject.Forms.FrmRulesAndActions.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MdlScripts.setRulesAndActions();
        }

        private void addRuleLabel_Click(object sender, EventArgs e)
        {
            rulesActionsPanel.Location = new Point(838, 268);
            MdlScripts.populateMessageRules(rulesListView, "[Message Rules]");
            isMessageRule = true;
            if (rulesActionsPanel.Visible & isMessageRule == false)
            {
                rulesActionsPanel.Visible = false;
            }
            else
            {
                rulesActionsPanel.Visible = true;
            }
        }

        private void addActionLabel_Click(object sender, EventArgs e)
        {
            rulesActionsPanel.Location = new Point(838, 375);
            MdlScripts.populateMessageRules(rulesListView, "[Message Actions]");
            isMessageRule = false;
            if (rulesActionsPanel.Visible & isMessageRule == true)
            {
                rulesActionsPanel.Visible = false;
            }
            else
            {
                rulesActionsPanel.Visible = true;
            }
        }
    }
}