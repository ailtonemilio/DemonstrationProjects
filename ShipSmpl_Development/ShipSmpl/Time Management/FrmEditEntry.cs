using Bunifu.UI.WinForms;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;

namespace ShipSmpl
{
    public partial class FrmEditEntry
    {
        public FrmEditEntry()
        {
            InitializeComponent();
            _reasonNewEntryComboBox.Name = "reasonNewEntryComboBox";
            _clockInCheckBox.Name = "clockInCheckBox";
            _clockOutCheckBox.Name = "clockOutCheckBox";
            _closeLabel.Name = "closeLabel";
            _createNewEntryButton.Name = "createNewEntryButton";
            _cancelButton.Name = "cancelButton";
        }

        private DatabaseHelper db = new DatabaseHelper();

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (clockInCheckBox.Checked)
            {
                clockInTimePicker.Show();
                clockInDateTimePicker.Show();
            }
            else
            {
                clockInTimePicker.Hide();
                clockInDateTimePicker.Hide();
            }
        }

        private BunifuDataGridView summaryList = My.MyProject.Forms.FrmTimeSheet.summaryBunifuDataGridView;

        private void clockOutCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (clockOutCheckBox.Checked)
            {
                clockOutTimePicker.Show();
                clockoOutDateTimePicker.Show();
                int selectedEntry = My.MyProject.Forms.FrmTimeSheet.summaryBunifuDataGridView.CurrentCell.RowIndex;
                // Dim selectedItemS As Integer = FrmTimeSheet.summaryListView.FocusedItem.Index
                string typeWorker = Conversions.ToString(My.MyProject.Forms.FrmTimeSheet.summaryBunifuDataGridView.Rows[selectedEntry].Cells[7].Value);
                if (shiftTypeComboBox.SelectedItem.Equals("Hourly") & typeWorker.Equals("Crew"))
                {
                }
            }
            else
            {
                clockOutTimePicker.Hide();
                clockoOutDateTimePicker.Hide();
                Panel2.Hide();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var cIn = Convert.ToDateTime(clockInDateTimePicker.Value.ToShortDateString() + " " + clockInTimePicker.Value.ToShortTimeString());
            var cOut = Convert.ToDateTime(clockoOutDateTimePicker.Value.ToShortDateString() + " " + clockOutTimePicker.Value.ToShortTimeString());
            if (string.IsNullOrEmpty(modifiedByTextBox.Text) | reasonNewEntryComboBox.SelectedIndex == -1)
            {
                MdlControllerModifier.warning("Edit entry", editEntryTitleLabel);
            }
            else if (reasonNewEntryComboBox.SelectedItem.Equals("Other") & string.IsNullOrEmpty(RichTextBox1.Text))
            {
                MdlControllerModifier.warning("Edit entry", editEntryTitleLabel);
            }
            else if (clockOutCheckBox.Checked & cIn > cOut)
            {
                MdlControllerModifier.warning("Wrong time", editEntryTitleLabel);
            }
            else
            {
                int selectedItemD = My.MyProject.Forms.FrmTimeSheet.detailsBunifuDataGridView.CurrentCell.RowIndex;
                int selectedItemS = My.MyProject.Forms.FrmTimeSheet.summaryBunifuDataGridView.CurrentCell.RowIndex;
                if (shiftTypeComboBox.SelectedItem.Equals("Hourly") & My.MyProject.Forms.FrmTimeSheet.summaryBunifuDataGridView.Rows[selectedItemS].Cells[7].Value.Equals("Crew") & workDoneListView.CheckedIndices.Count == 0 & clockOutCheckBox.Checked)
                {
                    MdlControllerModifier.warning("Edit entry", editEntryTitleLabel);
                }
                else
                {
                    MdlTimeManagement.updatePunchInfo();
                    int userId = Conversions.ToInteger(My.MyProject.Forms.FrmTimeSheet.summaryBunifuDataGridView.Rows[selectedItemS].Cells[7].Value.Equals("Crew"));
                    MdlTimeManagement.populateDetails(Conversions.ToInteger(My.MyProject.Forms.FrmTimeSheet.summaryBunifuDataGridView.Rows[selectedItemS].Cells[6].Value));
                    MdlControllerModifier.clearFields();
                    Close();
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmEditEntry_Load(object sender, EventArgs e)
        {
            modifiedByTextBox.Text = My.MyProject.Forms.FrmLoginWindow._employeeName;
            clockInTimePicker.Value = DateTime.Now;
            clockOutTimePicker.Value = DateTime.Now;
            int selectedItem = My.MyProject.Forms.FrmTimeSheet.detailsBunifuDataGridView.CurrentCell.RowIndex;
            string dateE;
            string startTimeStr;
            {
                var withBlock = My.MyProject.Forms.FrmTimeSheet;
                dateE = Conversions.ToString(withBlock.detailsBunifuDataGridView.Rows[selectedItem].Cells[0].Value);
                startTimeStr = Conversions.ToString(withBlock.detailsBunifuDataGridView.Rows[selectedItem].Cells[1].Value);
            }

            var startTime = Convert.ToDateTime(dateE + " " + startTimeStr);
            clockInTimePicker.Value = startTime;
            Panel2.Show();
            MdlTimeManagement.populateWorks(workDoneListView);
        }

        private void reasonNewEntryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (reasonNewEntryComboBox.SelectedItem.Equals("Other"))
            {
                Panel1.Show();
            }
            else
            {
                Panel1.Hide();
            }
        }

        private void closeLabel_MouseHover(object sender, EventArgs e)
        {
            closeLabel.BackColor = Color.Gray;
        }

        private void closeLabel_MouseLeave(object sender, EventArgs e)
        {
            closeLabel.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}