using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;

namespace ShipSmpl
{
    public partial class FrmdeleteWarning
    {
        public FrmdeleteWarning()
        {
            InitializeComponent();
            _noBunifuButton.Name = "noBunifuButton";
            _yesBunifuButton.Name = "yesBunifuButton";
            _Label2.Name = "Label2";
            _confirmationBunifuTextBox.Name = "confirmationBunifuTextBox";
        }

        private DatabaseHelper db = new DatabaseHelper();
        private DatabaseHelperCeres dbCeres = new DatabaseHelperCeres();
        public string deleteRecord = "";
        public string confirmationKey = "";
        public string buttonPressed = "";

        private void FrmWarningBox_Load(object sender, EventArgs e)
        {
            imageWarningLabel.ImageIndex = 0;
            tileLabel.Show();
            buttonPressed = "";
            confirmationBunifuTextBox.Text = "";
            confirmationBunifuTextBox.Select();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            buttonPressed = "Cancel";
            Close();
            confirmationBunifuTextBox.Text = "";
        }

        private void Label2_MouseHover(object sender, EventArgs e)
        {
            Label2.BackColor = Color.LightCoral;
        }

        private void Label2_MouseLeave(object sender, EventArgs e)
        {
            Label2.BackColor = Color.IndianRed;
        }

        private void noBunifuButton_Click(object sender, EventArgs e)
        {
            buttonPressed = "Cancel";
            Close();
        }

        private void yesBunifuButton_Click(object sender, EventArgs e)
        {
            buttonPressed = "Yes";
            MdlLoadingSetting.waitForm.Show();
            int recordID = 0;
            object dataRows;
            string tabName = "";
            if (deleteRecord.Equals("InGate"))
            {
                for (int i = 0, loopTo = My.MyProject.Forms.FrmInOutGate.InGateDataGridView.Rows.Count - 1; i <= loopTo; i++)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(My.MyProject.Forms.FrmInOutGate.InGateDataGridView.Rows[i].Cells[1].Value, true, false)))
                    {
                        recordID = Conversions.ToInteger(My.MyProject.Forms.FrmInOutGate.InGateDataGridView.Rows[i].Cells[0].Value);
                        break;
                    }
                }

                // dataRows = dbCeres.getTableInfo("[Containers In-Out]", "*", "where [Unique ID] = " + recordID.ToString).Rows(0)
                dbCeres.deleteRows("[Containers In-Out]", "where [Unique ID] = " + recordID.ToString());
                tabName = "IN-GATE";

                // dbLogs.createInOutGateLog(dataRows)

                EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, recordID.ToString(), "DELETE", tabName, "");
                My.MyProject.Forms.FrmInOutGate.getInOutContainers();
            }
            else if (deleteRecord.Equals("OutGate"))
            {
                for (int i = 0, loopTo1 = My.MyProject.Forms.FrmInOutGate.OutGateDataGridView.Rows.Count - 1; i <= loopTo1; i++)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(My.MyProject.Forms.FrmInOutGate.OutGateDataGridView.Rows[i].Cells[1].Value, true, false)))
                    {
                        recordID = Conversions.ToInteger(My.MyProject.Forms.FrmInOutGate.OutGateDataGridView.Rows[i].Cells[0].Value);
                        break;
                    }
                }

                dbCeres.clearOutGate(recordID.ToString());
                tabName = "OUT-GATE";
                EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, recordID.ToString(), "DELETE", tabName, "");
                My.MyProject.Forms.FrmInOutGate.getInOutContainers();
            }
            else if (deleteRecord.Equals("Transfer"))
            {
                // Dim currentRow As Integer = FrmListTransfers.transfersBunifuDataGridView.CurrentRow.Index
                for (int i = My.MyProject.Forms.FrmListTransfers.transfersBunifuDataGridView.Rows.Count - 1; i >= 0; i -= 1)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(My.MyProject.Forms.FrmListTransfers.transfersBunifuDataGridView.Rows[i].Cells[1].Value, true, false)))
                    {
                        recordID = Conversions.ToInteger(My.MyProject.Forms.FrmListTransfers.transfersBunifuDataGridView.Rows[i].Cells[0].Value);
                        dbCeres.deleteRows("[Allowed Transfers]", "where [ID] = " + recordID.ToString());
                        My.MyProject.Forms.FrmListTransfers.transfersBunifuDataGridView.Rows.RemoveAt(i);
                    }
                }
            }
            else if (deleteRecord.Equals("Block"))
            {
                // Dim currentRow As Integer = FrmListTransfers.transfersBunifuDataGridView.CurrentRow.Index
                for (int i = My.MyProject.Forms.FrmListBlockedContainers.blockContBunifuDataGridView.Rows.Count - 1; i >= 0; i -= 1)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(My.MyProject.Forms.FrmListBlockedContainers.blockContBunifuDataGridView.Rows[i].Cells[1].Value, true, false)))
                    {
                        recordID = Conversions.ToInteger(My.MyProject.Forms.FrmListBlockedContainers.blockContBunifuDataGridView.Rows[i].Cells[0].Value);
                        dbCeres.deleteRows("[Blocked Containers]", "where [ID] = " + recordID.ToString());
                        My.MyProject.Forms.FrmListBlockedContainers.blockContBunifuDataGridView.Rows.RemoveAt(i);
                    }
                }
            }
            else if (deleteRecord.Equals("assign"))
            {
                My.MyProject.Forms.FrmAssignContainer.isDeletedFromExcel = true;
                Close();
            }
            else if (deleteRecord.Equals("Booking"))
            {
            }

            // Dim currentRow As Integer = FrmListTransfers.transfersBunifuDataGridView.CurrentRow.Index
            // Dim bokngNumb As String = FrmBookingList.selectedBookings(0)
            // dbCeres.deleteRows("[Bookings]", "where [Booking Number] = '" + bokngNumb + "'")
            // FrmBookingList.FetchBookingListing(True, "")
            else
            {
                Close();
            }
            // record deletion into Logs Database

            mainMessageLabel.Text = "Record was deleted successfully";
            imageWarningLabel.ImageIndex = 1;
            tileLabel.Hide();
            confirmationPanel.Hide();
            confirmationBunifuTextBox.Text = "";
            ButtonPanel.Hide();
            MdlLoadingSetting.waitForm.Close();
        }

        private void confirmationBunifuTextBox_TextChanged(object sender, EventArgs e)
        {
            if (confirmationBunifuTextBox.Text.Equals(confirmationKey))
            {
                yesBunifuButton.Enabled = true;
            }
            else
            {
                yesBunifuButton.Enabled = false;
            }
        }
    }
}