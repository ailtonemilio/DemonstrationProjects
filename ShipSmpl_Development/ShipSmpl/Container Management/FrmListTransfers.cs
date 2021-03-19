using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmListTransfers
    {
        public FrmListTransfers()
        {
            InitializeComponent();
            _deleteButton.Name = "deleteButton";
            _transfersBunifuDataGridView.Name = "transfersBunifuDataGridView";
            _createTransfeRButton.Name = "createTransfeRButton";
        }

        private DatabaseHelperCeres dbCeres = new DatabaseHelperCeres();
        private DataRowCollection transfersList;
        private DataRowCollection completeTransfers;
        private List<string> completeTransferList = new List<string>();

        private void FrmListTransfers_Load(object sender, EventArgs e)
        {
            transfersList = dbCeres.getTableInfo("[Allowed Transfers]", "*", "order by [Date of Creation]").Rows;

            // For Each transfer In transfersList
            // If Not IsDBNull(transfer("Arrive")) Then
            // completeTransferList.Add()
            // End If
            // Next
            populateTransfers();
        }

        public void populateTransfers()
        {
            transfersBunifuDataGridView.Rows.Clear();
            DateTime due;
            string dueStr = "";
            foreach (DataRow transfer in transfersList)
            {
                if (!Information.IsDBNull(transfer["Due"]))
                {
                    due = Conversions.ToDate(transfer["Due"]);
                    dueStr = due.ToString("dd-MMM-yyy");
                }
                else
                {
                    dueStr = "N/A";
                }

                transfersBunifuDataGridView.Rows.Add(transfer["ID"], (object)false, transfer["Container Number"], transfer["Size"], transfer["Status"], transfer["Weight"], dueStr, transfer["Trucker Code"], transfer["From"], transfer["To"], "In Progress");
            }
        }

        public DataTable selectedTransfers = new DataTable();

        private void createTransfeRButton_Click(object sender, EventArgs e)
        {
            selectedTransfers.Clear();
            selectedTransfers.Columns.Clear();
            selectedTransfers.Columns.Add("id");
            selectedTransfers.Columns.Add("cont");
            selectedTransfers.Columns.Add("size");
            selectedTransfers.Columns.Add("status");
            selectedTransfers.Columns.Add("weight");
            selectedTransfers.Columns.Add("due");
            selectedTransfers.Columns.Add("trucker");
            selectedTransfers.Columns.Add("from");
            selectedTransfers.Columns.Add("to");
            // selectedTransfers.Clear()
            // selectedTransfers.Copy(FrmCreateTransfer.transfersBunifuDataGridView)
            foreach (DataGridViewRow row in transfersBunifuDataGridView.Rows)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row.Cells[1].Value, true, false)))
                {
                    selectedTransfers.Rows.Add(row.Cells[0].Value, row.Cells[2].Value, row.Cells[3].Value, row.Cells[4].Value, row.Cells[5].Value, row.Cells[6].Value, row.Cells[7].Value, row.Cells[8].Value, row.Cells[9].Value);
                }
            }

            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmCreateTransfer, this);
        }

        private void transfersBunifuDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                bool value = Conversions.ToBoolean(transfersBunifuDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                if (value == false)
                {
                    transfersBunifuDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                }
                else
                {
                    transfersBunifuDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
                }
            }

            checkAssignButtons();
        }

        private void DeleteCompanyButton_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmdeleteWarning.deleteRecord = "Transfer";
            string listOfContainers = "";
            for (int i = 0, loopTo = transfersBunifuDataGridView.Rows.Count - 1; i <= loopTo; i++)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(transfersBunifuDataGridView.Rows[i].Cells[1].Value, true, false)))
                {
                    listOfContainers = Conversions.ToString(listOfContainers + Operators.AddObject(transfersBunifuDataGridView.Rows[i].Cells[2].Value, ", "));
                }
            }

            listOfContainers = listOfContainers.Substring(0, listOfContainers.Length - 2);
            My.MyProject.Forms.FrmdeleteWarning.mainMessageLabel.Text = "Are you sure you want to delete transfer of container #: " + listOfContainers + "?";
            My.MyProject.Forms.FrmdeleteWarning.confirmationPanel.Hide();
            My.MyProject.Forms.FrmdeleteWarning.ButtonPanel.Show();
            My.MyProject.Forms.FrmdeleteWarning.yesBunifuButton.Enabled = true;
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmdeleteWarning, My.MyProject.Forms.FrmParentScreen);
        }

        public void checkAssignButtons()
        {
            for (int i = 0, loopTo = transfersBunifuDataGridView.Rows.Count - 1; i <= loopTo; i++)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(transfersBunifuDataGridView.Rows[i].Cells[0].Value, true, false)))
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
    }
}