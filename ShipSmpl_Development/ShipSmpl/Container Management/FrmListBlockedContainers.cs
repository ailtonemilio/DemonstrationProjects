using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmListBlockedContainers
    {
        public FrmListBlockedContainers()
        {
            InitializeComponent();
            _searchBunifuTextBox1.Name = "searchBunifuTextBox1";
            _refheshInShapedButton.Name = "refheshInShapedButton";
            _deleteButton.Name = "deleteButton";
            _blockContBunifuDataGridView.Name = "blockContBunifuDataGridView";
            _createTransfeRButton.Name = "createTransfeRButton";
        }

        private DatabaseHelperCeres dbCeres = new DatabaseHelperCeres();

        private void createTransfeRButton_Click(object sender, EventArgs e)
        {
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmBlockContainer, this);
        }

        public void populateBlockedList()
        {
            blockContBunifuDataGridView.Rows.Clear();
            string condition = "where [Blocked Date] >= '" + Conversions.ToString(fromInBunifuDatePicker.Value.Date) + "' and [Blocked Date] <= '" + Conversions.ToString(toInBunifuDatePicker.Value.Date) + "'";
            DateTime blockedDate;
            var endBlock = default(DateTime);
            string endBlockStr;
            string status;
            foreach (DataRow cont in dbCeres.getTableInfo("[Blocked Containers]", "*", condition).Rows)
            {
                blockedDate = Conversions.ToDate(cont["Blocked Date"]);
                // endBlock = cont("Block End Date")
                if (!Information.IsDBNull(cont["Block End Date"]))
                {
                    endBlock = Conversions.ToDate(cont["Block End Date"]);
                    endBlockStr = endBlock.ToString("dd-MMM-yyyy");
                }
                else
                {
                    endBlockStr = "";
                }

                if (endBlock.Date < DateAndTime.Now.Date)
                {
                    status = "NOT BLOCKED";
                }
                else
                {
                    status = "BLOCKED";
                }

                blockContBunifuDataGridView.Rows.Add(cont["ID"], (object)false, Strings.Trim(Conversions.ToString(cont["Container Number"])), "(" + Strings.Trim(Conversions.ToString(cont["SS Line Code"])) + ") " + Strings.Trim(Conversions.ToString(cont["SS Line Name"])), blockedDate.ToString("dd-MMM-yyyy"), endBlockStr, status);
            }
        }

        private void blockContBunifuDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // to add complete/in progress images to datagridview

            if (blockContBunifuDataGridView.Rows[e.RowIndex].Cells[6].Value.Equals("BLOCKED"))
            {
                blockContBunifuDataGridView.Rows[e.RowIndex].Cells[6].Style.BackColor = Color.Firebrick;
            }
            else
            {
                blockContBunifuDataGridView.Rows[e.RowIndex].Cells[6].Style.BackColor = Color.Green;
            }
        }

        private void FrmListBlockedContainers_Load(object sender, EventArgs e)
        {
            fromInBunifuDatePicker.Value = DateAndTime.Now.AddMonths(-2);
            toInBunifuDatePicker.Value = DateAndTime.Now;
            populateBlockedList();
        }

        private void findText()
        {
            for (int i = 0, loopTo = blockContBunifuDataGridView.Rows.Count - 1; i <= loopTo; i++)
            {
                if (Conversions.ToBoolean(blockContBunifuDataGridView.Rows[i].Cells[2].Value.ToString().Contains(searchBunifuTextBox1.Text.ToUpper())))
                {
                    // cell.Style.BackColor = Color.Yellow
                    // summaryBunifuDataGridView.Rows(i).Selected = True

                    blockContBunifuDataGridView.CurrentCell = blockContBunifuDataGridView.Rows[i].Cells[1];
                    return;
                }
            }
        }

        private void searchBunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            findText();
        }

        private void searchBunifuTextBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void transfersBunifuDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                bool value = Conversions.ToBoolean(blockContBunifuDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                if (value == false)
                {
                    blockContBunifuDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                }
                else
                {
                    blockContBunifuDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
                }
            }

            checkAssignButtons();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmdeleteWarning.deleteRecord = "Block";
            string listOfContainers = "";
            for (int i = 0, loopTo = blockContBunifuDataGridView.Rows.Count - 1; i <= loopTo; i++)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(blockContBunifuDataGridView.Rows[i].Cells[1].Value, true, false)))
                {
                    listOfContainers = Conversions.ToString(listOfContainers + Operators.AddObject(blockContBunifuDataGridView.Rows[i].Cells[2].Value, ", "));
                }
            }

            listOfContainers = listOfContainers.Substring(0, listOfContainers.Length - 2);
            My.MyProject.Forms.FrmdeleteWarning.mainMessageLabel.Text = "Are you sure you want to remove the block of container #: " + listOfContainers + "?";
            My.MyProject.Forms.FrmdeleteWarning.confirmationPanel.Hide();
            My.MyProject.Forms.FrmdeleteWarning.ButtonPanel.Show();
            My.MyProject.Forms.FrmdeleteWarning.yesBunifuButton.Enabled = true;
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmdeleteWarning, My.MyProject.Forms.FrmParentScreen);
        }

        public void checkAssignButtons()
        {
            for (int i = 0, loopTo = blockContBunifuDataGridView.Rows.Count - 1; i <= loopTo; i++)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(blockContBunifuDataGridView.Rows[i].Cells[1].Value, true, false)))
                {
                    deleteButton.Enabled = true;
                    return;
                }
                else
                {
                    deleteButton.Enabled = false;
                }
            }
        }

        private void refheshInShapedButton_Click(object sender, EventArgs e)
        {
            populateBlockedList();
        }
    }
}