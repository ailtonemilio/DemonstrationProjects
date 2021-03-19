using Microsoft.VisualBasic.CompilerServices;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ShipSmpl
{
    static class MdlScripts
    {
        private static DatabaseHelperCeres db = new DatabaseHelperCeres();

        public static void addTagLabel(Label label, Color color, RichTextBox selectedRichTextBox)
        {
            // add tag to mesage text boxs
            {
                var withBlock = My.MyProject.Forms.FrmCreatePreScript;
                selectedRichTextBox.AppendText(label.Text);
                selectedRichTextBox.Update();
                var selectedFinds = default(RichTextBoxFinds);
                int foundIndex = 0;
                foundIndex = selectedRichTextBox.Find(label.Text, foundIndex + 1, -1, selectedFinds);
                foundIndex = selectedRichTextBox.Find(label.Text, foundIndex + 1, -1, selectedFinds);
                selectedRichTextBox.Focus();
                selectedRichTextBox.SelectionBackColor = color;
                selectedRichTextBox.SelectionColor = Color.White;
                selectedRichTextBox.SelectionStart = selectedRichTextBox.Text.Length + 1;
                selectedRichTextBox.SelectionBackColor = Color.White;
                selectedRichTextBox.SelectionColor = Color.Black;
            }
        }

        public static void populateTemplates(string searchWord, string selectedItem, ListView templatesListView)
        {
            templatesListView.Items.Clear();
            string condition = "";
            if (!searchWord.Equals("Find...") && !searchWord.Equals(""))
            {
                condition = "where Title Like '%" + searchWord + "%' or [Company Type] Like '%" + searchWord + "%' or " + "Department Like '%" + searchWord + "%'";
                if (!selectedItem.Equals("All"))
                {
                    condition += " and [Company Type] = '" + selectedItem + "'";
                }
            }
            else if (!string.IsNullOrEmpty(selectedItem))
            {
                if (!selectedItem.Equals("All"))
                {
                    condition = "where [Company Type] = '" + selectedItem + "'";
                }
            }

            foreach (DataRow template in db.getTableInfo("[Message Templates]", "*", condition).Rows)
                templatesListView.Items.Add(new ListViewItem(new[] { Conversions.ToString(template["Title"]), Conversions.ToString(template["Company Type"]), Conversions.ToString(template["Department"]), Conversions.ToString(template["ID"]) }));
        }

        public static void populateTemplateInfo(int templateID)
        {
            foreach (DataRow template in db.getTableInfo("[Message Templates]", "*", "where ID = " + templateID.ToString()).Rows)
            {
                {
                    var withBlock = My.MyProject.Forms.FrmCreatePreScript;
                    withBlock.messageRichTextBox.Rtf = Conversions.ToString(template["Message"]);
                    withBlock.tamplateTitleTextBox.Text = Conversions.ToString(template["Title"]);
                    withBlock.departmentComboBox.SelectedItem = template["Department"];
                    withBlock.typeComboBox.SelectedItem = template["Company Type"];
                    // 'messageRichTextBox.Text = messageRichTextBox.Rtf
                }
            }
        }

        public static void populateMessageRules(ListView rulesListView, string tableName)
        {
            rulesListView.Clear();
            rulesListView.Columns.Add("Title", 455);
            rulesListView.Columns.Add("", 0);
            foreach (DataRow rule in db.getTableInfo(tableName, "*", "").Rows)
                rulesListView.Items.Add(new ListViewItem(new[] { Conversions.ToString(rule["Title"]), Conversions.ToString(rule["ID"]) }));
        }

        public static void setRulesAndActions()
        {
            {
                var withBlock = My.MyProject.Forms.FrmCreatePreScript;
                int numberOfTags = withBlock.rulesListView.CheckedItems.Count;
                int selectedTag = 0;
                if (withBlock.isMessageRule)
                {
                    withBlock.ShapedLabelRule1.Hide();
                    withBlock.ShapedLabelRule1.Text = "";
                    withBlock.ShapedLabelRule2.Hide();
                    withBlock.ShapedLabelRule2.Text = "";
                    withBlock.ShapedLabelRule3.Hide();
                    withBlock.ShapedLabelRule3.Text = "";
                    withBlock.ShapedLabelRule4.Hide();
                    withBlock.ShapedLabelRule4.Text = "";
                    withBlock.ShapedLabelRule5.Hide();
                    withBlock.ShapedLabelRule5.Text = "";
                    withBlock.ShapedLabelRule6.Hide();
                    withBlock.ShapedLabelRule6.Text = "";
                }
                else
                {
                    withBlock.ShapedLabelAction1.Hide();
                    withBlock.ShapedLabelAction1.Text = "";
                    withBlock.ShapedLabelAction2.Hide();
                    withBlock.ShapedLabelAction2.Text = "";
                    withBlock.ShapedLabelAction3.Hide();
                    withBlock.ShapedLabelAction3.Text = "";
                    withBlock.ShapedLabelAction4.Hide();
                    withBlock.ShapedLabelAction4.Text = "";
                    withBlock.ShapedLabelAction5.Hide();
                    withBlock.ShapedLabelAction5.Text = "";
                    withBlock.ShapedLabelAction6.Hide();
                    withBlock.ShapedLabelAction6.Text = "";
                }

                foreach (ListViewItem item in withBlock.rulesListView.CheckedItems)
                {
                    if (withBlock.isMessageRule)
                    {
                        if (selectedTag == 0)
                        {
                            withBlock.ShapedLabelRule1.Show();
                            withBlock.ShapedLabelRule1.Text = Conversions.ToString(withBlock.ShapedLabelRule1.Text + item.Text);
                        }

                        if (selectedTag == 1)
                        {
                            withBlock.ShapedLabelRule2.Show();
                            withBlock.ShapedLabelRule2.Text = Conversions.ToString(withBlock.ShapedLabelRule2.Text + item.Text);
                        }

                        if (selectedTag == 2)
                        {
                            withBlock.ShapedLabelRule3.Show();
                            withBlock.ShapedLabelRule3.Text = Conversions.ToString(withBlock.ShapedLabelRule3.Text + item.Text);
                        }

                        if (selectedTag == 3)
                        {
                            withBlock.ShapedLabelRule4.Show();
                            withBlock.ShapedLabelRule4.Text = Conversions.ToString(withBlock.ShapedLabelRule4.Text + item.Text);
                        }

                        if (selectedTag == 4)
                        {
                            withBlock.ShapedLabelRule5.Show();
                            withBlock.ShapedLabelRule5.Text = Conversions.ToString(withBlock.ShapedLabelRule5.Text + item.Text);
                        }

                        if (selectedTag == 5)
                        {
                            withBlock.ShapedLabelRule6.Show();
                            withBlock.ShapedLabelRule6.Text = Conversions.ToString(withBlock.ShapedLabelRule6.Text + item.Text);
                        }

                        selectedTag += 1;
                    }
                    else
                    {
                        if (selectedTag == 0)
                        {
                            withBlock.ShapedLabelAction1.Show();
                            withBlock.ShapedLabelAction1.Text = Conversions.ToString(withBlock.ShapedLabelAction1.Text + item.Text);
                        }

                        if (selectedTag == 1)
                        {
                            withBlock.ShapedLabelAction2.Show();
                            withBlock.ShapedLabelAction2.Text = Conversions.ToString(withBlock.ShapedLabelAction2.Text + item.Text);
                        }

                        if (selectedTag == 2)
                        {
                            withBlock.ShapedLabelAction3.Show();
                            withBlock.ShapedLabelAction3.Text = Conversions.ToString(withBlock.ShapedLabelAction3.Text + item.Text);
                        }

                        if (selectedTag == 3)
                        {
                            withBlock.ShapedLabelAction4.Show();
                            withBlock.ShapedLabelAction4.Text = Conversions.ToString(withBlock.ShapedLabelAction4.Text + item.Text);
                        }

                        if (selectedTag == 4)
                        {
                            withBlock.ShapedLabelAction5.Show();
                            withBlock.ShapedLabelAction5.Text = Conversions.ToString(withBlock.ShapedLabelAction5.Text + item.Text);
                        }

                        if (selectedTag == 5)
                        {
                            withBlock.ShapedLabelAction6.Show();
                            withBlock.ShapedLabelAction6.Text = Conversions.ToString(withBlock.ShapedLabelAction6.Text + item.Text);
                        }

                        selectedTag += 1;
                    }
                }

                withBlock.rulesActionsPanel.Hide();
            }
        }
    }
}