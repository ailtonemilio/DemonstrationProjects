using Bunifu.UI.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmInOutGate
    {
        public FrmInOutGate()
        {
            InitializeComponent();
            _ExportCSVToolStripMenuItem.Name = "ExportCSVToolStripMenuItem";
            _OutGateReportToolStripMenuItem.Name = "OutGateReportToolStripMenuItem";
            _InOutReceiptsToolStripMenuItem.Name = "InOutReceiptsToolStripMenuItem";
            _tabinoutGate.Name = "tabinoutGate";
            _refreshInShapedButton.Name = "refreshInShapedButton";
            _STATUSDropdown1.Name = "STATUSDropdown1";
            _truckTextBox.Name = "truckTextBox";
            _releaseTextBox.Name = "releaseTextBox";
            _ssLineTextBox.Name = "ssLineTextBox";
            _conatinerTextBox.Name = "conatinerTextBox";
            _InGateDataGridView.Name = "InGateDataGridView";
            _addOutGateEntryButton.Name = "addOutGateEntryButton";
            _newEntryInBunifuButton.Name = "newEntryInBunifuButton";
            _editInBunifuButton.Name = "editInBunifuButton";
            _deleteInBunifuButton.Name = "deleteInBunifuButton";
            _refreshOutShapedButton.Name = "refreshOutShapedButton";
            _statusOutDropdown.Name = "statusOutDropdown";
            _TruckOutTextBox.Name = "TruckOutTextBox";
            _bkngTextBox.Name = "bkngTextBox";
            _SSLineOutTextBox.Name = "SSLineOutTextBox";
            _contOutTextBox.Name = "contOutTextBox";
            _OutGateDataGridView.Name = "OutGateDataGridView";
            _btnReject.Name = "btnReject";
            _editOutBunifuButton.Name = "editOutBunifuButton";
            _deleteOutBunifuButton.Name = "deleteOutBunifuButton";
        }

        private DataTable InOutDT = new DataTable();
        private DataTable searchTable = new DataTable();

        // Dim EDIRecordsDt As New DataTable
        public int numbOfSelecCans = 0;
        public bool isRefresh;
        private bool firstLoad;

        private void FrmInOutGate_Load(object sender, EventArgs e)
        {
            firstLoad = true;
            fromInBunifuDatePicker.Value = DateAndTime.Now;
            toInBunifuDatePicker.Value = DateAndTime.Now;
            fromOutBunifuDatePicker.Value = DateAndTime.Now;
            toOutBunifuDatePicker.Value = DateAndTime.Now;
            numbOfSelecCans = 0;
            STATUSDropdown1.SelectedIndex = 0;
            statusOutDropdown.SelectedIndex = 0;
            firstLoad = false;
            getInOutContainers();
        }

        public void getInOutContainers()
        {
            //       My.MyProject.Forms.FrmParentScreen.showLOadForm();
            if (tabinoutGate.SelectedIndex == 0)
            {
                getInOutGates(InGateDataGridView, "ingate");
            }
            else
            {
                getInOutGates(OutGateDataGridView, "outgate");
            }

            //   My.MyProject.Forms.FrmParentScreen.HideLoadForm();
        }

        public void getInOutGates(BunifuDataGridView dataGrid, string gateMode)
        {
            dataGrid.Rows.Clear();
            string collumns;
            string condition;
            int RecordCount = 0;
            decimal GrossWeight = 0m;
            string EDICan = "";
            string InGateStatus;
            string TempLine = "";
            string ThisLine = "";
            string TruckDriverName = "";
            string TruckNumber = "";
            DataRow InGateRow;
            string contSize = "";
            decimal tareWeight;
            string comments;
            string ediInfo;
            string gateAction = "";
            DateTime gateTimeDate;
            DateTime ediTimeDate;
            string ssLineCode;
            string carrierCode;
            collumns = @"[Unique ID], [Container Number], [In Gate EDI],[Out Gate EDI], [Should Send InGate EDI],[Yard Code In], [Trouble In-Gate],
                    [SS Line Code In], [Release Number], [Gate Date In],[Container Size], [Gross Weight], [TARE Weight],
                    [Carrier Code In], [Carrier Truck In], [Carrier DriverName In], [Comments In], [Gate Date Out],[In Gate EDI Date Time]
                     ,[Out Gate EDI Date Time], [Carrier Truck Out], [SS Line Code Out], [Carrier Code Out], [Carrier Truck out],
                    [Carrier DriverName Out], [Gross Weight Out], [Booking Number], [Hold Out-Gate], [Should Send OutGate EDI], [ContainerSize]";
            if (gateMode.Equals("ingate"))
            {
                condition = "Where Convert(date,[Gate Date In]) >= '" + fromInBunifuDatePicker.Value.Date + "' And Convert(date,[Gate Date In]) <= '" + toInBunifuDatePicker.Value.Date + "' Order By [Gate Date In]  DESC";
                gateAction = "IN-GATE";
            }
            else
            {
                condition = " Where Convert(date,[Gate Date Out]) >= '" + fromOutBunifuDatePicker.Value.Date + "' And Convert(date,[Gate Date Out]) <= '" + toOutBunifuDatePicker.Value.Date + "' Order By [Gate Date Out] DESC";
                gateAction = "OUT-GATE";
            }

            if (isRefresh)
            {
                InOutDT = dbCeres.getTableInfo("[Containers In-Out]", collumns, condition);
                searchTable = InOutDT;
                // EDIRecordsDt = dbCeres.getTableInfo("[EDI Records]", "*", "where [Date and Time] >= '" & fromInBunifuDatePicker.Value.Date & "' And [Date and Time] <= '" &
                // toInBunifuDatePicker.Value.Date & "' Order By [Date and Time] DESC")
            }

            foreach (DataRow row in searchTable.Rows)
            {

                // If row["Container Size") = ChrW(0) Then
                // contSize = "20 FT"
                // ElseIf row["Container Size") = ChrW(1) Then
                // contSize = "40 FT"
                // ElseIf row["Container Size") = ChrW(2) Then
                // contSize = "40 FT HC"
                // ElseIf row["Container Size") = ChrW(3) Then
                // contSize = "53 FT"
                // End If
                // Stop
                if (row["ContainerSize"] != DBNull.Value)
                {
                    contSize = Conversions.ToString(row["ContainerSize"]);
                }
                else
                {
                    contSize = "";
                }

                DateTime tempDate;
                object tempDateTime;
                DateTime tempTime;
                string ediTimeDateStr = "";
                if (gateMode.Equals("ingate"))
                {
                    gateTimeDate = Conversions.ToDate(row["Gate Date In"]);
                    if (row["In Gate EDI Date Time"] != DBNull.Value)
                    {
                        ediTimeDate = Conversions.ToDate(row["In Gate EDI Date Time"]);
                        ediTimeDateStr = ediTimeDate.ToString("dd-MMM-yyyy HH:mm");
                    }
                    else
                    {
                        ediTimeDateStr = "N/A";
                    }

                    if (row["Trouble In-Gate"] == DBNull.Value && row["Trouble In-Gate"] == DBNull.Value)
                    {
                        InGateStatus = "TROUBLE";
                    }
                    else
                    {
                        InGateStatus = "VALID";
                    }

                    if (row["Carrier Truck In"] == DBNull.Value)
                    {
                        TruckNumber = MdlContainerManagement.DoFunctions.PadToString(Conversions.ToString(' '), 10);
                    }
                    else
                    {
                        TruckNumber = MdlContainerManagement.DoFunctions.PadToString(Conversions.ToString(row["Carrier Truck In"]), 10);
                    }

                    if (row["Carrier DriverName In"] == DBNull.Value)
                    {
                        TruckDriverName = Strings.Trim("N/A");
                    }
                    else
                    {
                        TruckDriverName = Strings.Trim(Conversions.ToString(row["Carrier DriverName In"]));
                    }

                    GrossWeight = Conversions.ToDecimal(Strings.Trim(MdlContainerManagement.DoFunctions.CVS(Conversions.ToString(row["Gross Weight"])).ToString()));
                    if (row["TARE Weight"] == DBNull.Value)
                    {
                        tareWeight = 0m;
                    }
                    else
                    {
                        tareWeight = (decimal)MdlContainerManagement.DoFunctions.CVS(Conversions.ToString(row["TARE Weight"]));
                    }

                    comments = Strings.Trim(Conversions.ToString(row["Comments In"]));
                    if (row["SS Line Code In"] != DBNull.Value)
                    {
                        ssLineCode = Strings.Trim(Conversions.ToString(row["SS Line Code In"]));
                    }
                    else
                    {
                        ssLineCode = "N/A";
                    }

                    if (row["Carrier Code In"] != DBNull.Value)
                    {
                        carrierCode = Strings.Trim(Conversions.ToString(row["Carrier Code In"]));
                    }
                    else
                    {
                        carrierCode = "N/A";
                    }

                    string relNumb = "";
                    string yardIn = "";
                    string canNumb = "";
                    if (row["Release Number"] != DBNull.Value)
                    {
                        relNumb = Strings.Trim(Conversions.ToString(row["Release Number"]));
                    }
                    else
                    {
                    }

                    if (row["Yard Code In"] != DBNull.Value)
                    {
                        yardIn = Strings.Trim(Conversions.ToString(row["Yard Code In"]));
                    }

                    if (row["Container Number"] != DBNull.Value)
                    {
                        canNumb = Strings.Trim(Conversions.ToString(row["Container Number"]));
                    }

                    dataGrid.Rows.Add(row["Unique ID"], (object)false, canNumb, gateAction, yardIn, EDICan, ediTimeDateStr, "", InGateStatus, ssLineCode, relNumb, gateTimeDate.ToString("dd-MMM-yyyy"), gateTimeDate.ToString("HH:mm"), contSize, (object)GrossWeight, (object)tareWeight, carrierCode, TruckNumber, TruckDriverName);
                }
                else
                {
                    gateTimeDate = Conversions.ToDate(row["Gate Date Out"]);
                    if (row["Out Gate EDI Date Time"] != DBNull.Value)
                    {
                        ediTimeDate = Conversions.ToDate(row["Out Gate EDI Date Time"]);
                        ediTimeDateStr = ediTimeDate.ToString("dd-MMM-yyyy HH:mm");
                    }
                    else
                    {
                        ediTimeDateStr = "N/A";
                    }

                    if (row["Hold Out-Gate"] != DBNull.Value && Convert.ToBoolean(row["Hold Out-Gate"]) == true)
                    {
                        InGateStatus = "HOLD";
                    }
                    else
                    {
                        InGateStatus = "VALID";
                    }

                    if (row["Carrier Truck Out"] == DBNull.Value)
                    {
                        TruckNumber = "N/A";
                    }
                    else
                    {
                        TruckNumber = Strings.Trim(Conversions.ToString(row["Carrier Truck Out"]));
                    }

                    if (row["Carrier DriverName Out"] == DBNull.Value)
                    {
                        TruckDriverName = "N/A";
                    }
                    else
                    {
                        TruckDriverName = Strings.Trim(Conversions.ToString(row["Carrier DriverName Out"]));
                    }

                    GrossWeight = Conversions.ToDecimal(Strings.Trim(MdlContainerManagement.DoFunctions.CVS(Conversions.ToString(row["Gross Weight Out"])).ToString()));
                    if (row["TARE Weight"] != DBNull.Value)
                    {
                        tareWeight = (decimal)MdlContainerManagement.DoFunctions.CVS(Conversions.ToString(row["TARE Weight"]));
                    }
                    else
                    {
                        tareWeight = 0m;
                    }

                    string bkgNumb;
                    if (row["Booking Number"] != DBNull.Value)
                    {
                        bkgNumb = Strings.Trim(Conversions.ToString(row["Booking Number"]));
                    }
                    else
                    {
                        bkgNumb = "N/A";
                    }

                    string yardIn;
                    if (row["Yard Code In"] != DBNull.Value)
                    {
                        yardIn = Strings.Trim(Conversions.ToString(row["Yard Code In"]));
                    }
                    else
                    {
                        yardIn = "N/A";
                    }

                    if (row["SS Line Code Out"] != DBNull.Value)
                    {
                        ssLineCode = Strings.Trim(Conversions.ToString(row["SS Line Code Out"]));
                    }
                    else
                    {
                        ssLineCode = "N/A";
                    }

                    if (row["Carrier Code Out"] != DBNull.Value)
                    {
                        carrierCode = Strings.Trim(Conversions.ToString(row["Carrier Code Out"]));
                    }
                    else
                    {
                        carrierCode = "N/A";
                    }

                    dataGrid.Rows.Add(row["Unique ID"], (object)false, Strings.Trim(Conversions.ToString(row["Container Number"])), gateAction, yardIn, EDICan, ediTimeDateStr, "", InGateStatus, ssLineCode, bkgNumb, gateTimeDate.ToString("dd-MMM-yyyy"), gateTimeDate.ToString("HH:mm"), contSize, (object)GrossWeight, (object)tareWeight, carrierCode, TruckNumber, TruckDriverName);
                }
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            DataGridView focusedDataGrid;
            if (tabinoutGate.SelectedIndex == 0)
            {
                focusedDataGrid = InGateDataGridView;
            }
            else
            {
                focusedDataGrid = OutGateDataGridView;
            }

            var rows1 = focusedDataGrid.Rows;
            var headers = (from header in focusedDataGrid.Columns.Cast<DataGridViewColumn>()
                           select header.HeaderText).ToArray();
            headers = headers.Except(new[] { headers[1] }).ToArray();
            headers = headers.Except(new[] { headers[0] }).ToArray();
            var rows = from row in focusedDataGrid.Rows.Cast<DataGridViewRow>()
                       where !row.IsNewRow
                       select Array.ConvertAll(row.Cells.Cast<DataGridViewCell>().ToArray(), c => c.Value is object ? c.Value.ToString() : "");
            try
            {
                using (var sw = new System.IO.StreamWriter("csv.csv"))
                {
                    sw.WriteLine(string.Join(",", headers));
                    foreach (string[] r in rows)
                    {
                        string[] b = new string[1];
                        b = r;
                        b = r.Except(new[] { r[1] }).ToArray();
                        b = r.Except(new[] { r[0] }).ToArray();
                        sw.WriteLine(string.Join(",", b));
                    }
                }

                Process.Start("csv.csv");
            }
            catch (Exception ex)
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Error.", ex.Message, this);
            }
        }

        private DatabaseHelperCeres dbCeres = new DatabaseHelperCeres();

        private void deleteInBunifuButton_Click(object sender, EventArgs e)
        {
            // Call inGateContainersInOutList1.CheckedContainers()
            int recordID = 0;
            int focusedRow = 0;
            for (int i = 0, loopTo = InGateDataGridView.Rows.Count - 1; i <= loopTo; i++)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(InGateDataGridView.Rows[i].Cells[1].Value, true, false)))
                {
                    recordID = Conversions.ToInteger(InGateDataGridView.Rows[i].Cells[0].Value);
                    break;
                }
            }

            var recordInfo = dbCeres.getTableInfo("[Containers In-Out]", "*", "where [Unique ID] = " + recordID.ToString()).Rows[0];
            My.MyProject.Forms.FrmdeleteWarning.deleteRecord = "InGate";
            MdlContainerManagement.deleteRecordType = "InGate";
            My.MyProject.Forms.FrmdeleteWarning.confirmationKey = Strings.Trim(recordInfo["Container Number"].ToString());
            My.MyProject.Forms.FrmdeleteWarning.mainMessageLabel.Text = "This can not be undone. This will permanently delete the record and " + " all the other informations associated with it (In/Out Gate info, Time/Date In and Out, etc)." + Constants.vbNewLine + "Container #: " + Strings.Trim(recordInfo["Container Number"].ToString());
            My.MyProject.Forms.FrmdeleteWarning.confirmationPanel.Show();
            My.MyProject.Forms.FrmdeleteWarning.ButtonPanel.Show();
            My.MyProject.Forms.FrmdeleteWarning.yesBunifuButton.Enabled = false;
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmdeleteWarning, this);
            numbOfSelecCans = 0;
            for (int i = 0, loopTo1 = InGateDataGridView.Rows.Count - 1; i <= loopTo1; i++)
                InGateDataGridView.Rows[i].Cells[1].Value = false;
            checkButtons();
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            isRefresh = true;
            getInOutContainers();
            numbOfSelecCans = 0;
        }

        private void newEntryInBunifuButton_Click(object sender, EventArgs e)
        {
            isNewRecord = true;
            My.MyProject.Forms.FrmAddEditInGate.saveBunifuButton.Text = "SAVE";
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAddEditInGate, this);
        }

        public bool isNewRecord = false;

        private void editInBunifuButton_Click(object sender, EventArgs e)
        {
            isNewRecord = false;
            My.MyProject.Forms.FrmAddEditInGate.saveBunifuButton.Text = "UPDATE";
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAddEditInGate, this);
        }

        private void editOutBunifuButton_Click(object sender, EventArgs e)
        {
            isNewRecord = false;
            My.MyProject.Forms.FrmAddEditOutGate.saveBunifuButton.Text = "UPDATE";
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAddEditOutGate, this);
        }

        private void deleteOutBunifuButton_Click(object sender, EventArgs e)
        {
            int focusedRow = 0;
            int recordID = 0;
            DataRow recordInfo;
            for (int i = 0, loopTo = OutGateDataGridView.Rows.Count - 1; i <= loopTo; i++)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(OutGateDataGridView.Rows[i].Cells[1].Value, true, false)))
                {
                    recordID = Conversions.ToInteger(OutGateDataGridView.Rows[i].Cells[0].Value);
                    break;
                }
            }

            recordInfo = dbCeres.getTableInfo("[Containers In-Out]", "*", "where [Unique ID] = " + recordID.ToString()).Rows[0];
            My.MyProject.Forms.FrmdeleteWarning.deleteRecord = "OutGate";
            MdlContainerManagement.deleteRecordType = "OutGate";
            My.MyProject.Forms.FrmdeleteWarning.confirmationKey = Strings.Trim(recordInfo["Container Number"].ToString());
            My.MyProject.Forms.FrmdeleteWarning.mainMessageLabel.Text = "This can not be undone. This will permanently delete the record and " + " all the other informations associated with it (Out Gate info, Time/Date Out, etc)." + Constants.vbNewLine + "Container #: " + Strings.Trim(recordInfo["Container Number"].ToString());
            My.MyProject.Forms.FrmdeleteWarning.confirmationPanel.Show();
            My.MyProject.Forms.FrmdeleteWarning.ButtonPanel.Show();
            My.MyProject.Forms.FrmdeleteWarning.yesBunifuButton.Enabled = false;
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmdeleteWarning, this);
            numbOfSelecCans = 0;
            for (int i = 0, loopTo1 = InGateDataGridView.Rows.Count - 1; i <= loopTo1; i++)
                InGateDataGridView.Rows[i].Cells[1].Value = false;
            checkButtons();
        }

        private string GiveEDITick(char EDIStatus)
        {
            if (EDIStatus == '\u0001')
            {
                return "√";
            }
            else
            {
                return "";
            }
        }

        private string GiveGateStatus(char GateMode, char Status)
        {
            if (GateMode == '\u0001' & Status == '\u0001')
            {
                return "VALID";
            }
            else if (GateMode == '\u0001' & Status == '\u0002')
            {
                return "TROUBLE";
            }
            else if (GateMode == '\u0002' & Status == '\u0001')
            {
                return "VALID";
            }

            return default;
        }

        private string GiveContainerSize(char CanSize)
        {
            if (CanSize == '\0')
            {
                return "20Ft";
            }
            else if (CanSize == '\u0001')
            {
                return "40Ft SC";
            }
            else if (CanSize == '\u0002')
            {
                return "53Ft";
            }
            else if (CanSize == '\u0003')
            {
                return "40Ft HC";
            }
            else
            {
                return "";
            }
        }

        private string StripCommas(string ThisText)
        {
            short x = 0;
            string TempLine = "";
            TempLine = Conversions.ToString('"') + ThisText + Conversions.ToString('"');
            return TempLine;
        }

        private void addOutGateEntryButton_Click(object sender, EventArgs e)
        {
            isNewRecord = true;
            My.MyProject.Forms.FrmAddEditOutGate.saveBunifuButton.Text = "SAVE";
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAddEditOutGate, this);
        }

        private void BunifuDataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // to add complete/in progress images to datagridview
            try
            {
            }
            catch (Exception ex)
            {
            }

            BunifuDataGridView focusedDataGrid;
            if (tabinoutGate.SelectedIndex == 0)
            {
                focusedDataGrid = InGateDataGridView;
            }
            else
            {
                focusedDataGrid = OutGateDataGridView;
            }

            focusedDataGrid.Rows[e.RowIndex].Cells[5].Style.ForeColor = Color.Green;
            if (focusedDataGrid.Rows[e.RowIndex].Cells[3].Value.Equals("IN-GATE"))
            {
                focusedDataGrid.Rows[e.RowIndex].Cells[3].Style.BackColor = Color.Green;
                focusedDataGrid.Rows[e.RowIndex].Cells[3].Style.SelectionBackColor = Color.DarkGreen;
            }
            else
            {
                focusedDataGrid.Rows[e.RowIndex].Cells[3].Style.BackColor = Color.Firebrick;
                focusedDataGrid.Rows[e.RowIndex].Cells[3].Style.SelectionBackColor = Color.Maroon;
            }

            if (focusedDataGrid.Rows[e.RowIndex].Cells[8].Value.Equals("VALID"))
            {
                focusedDataGrid.Rows[e.RowIndex].Cells[8].Style.BackColor = Color.Green;
                focusedDataGrid.Rows[e.RowIndex].Cells[8].Style.SelectionBackColor = Color.DarkGreen;
            }
            else
            {
                focusedDataGrid.Rows[e.RowIndex].Cells[8].Style.BackColor = Color.Firebrick;
                focusedDataGrid.Rows[e.RowIndex].Cells[8].Style.SelectionBackColor = Color.Maroon;
            }
            // If focusedDataGrid.Rows(e.RowIndex).Cells(7).Value.ToString.Split(vbNewLine)(0).Equals("MANUAL") Then

            // focusedDataGrid.Rows(e.RowIndex).Cells(7).Style.BackColor = Color.Chocolate
            // focusedDataGrid.Rows(e.RowIndex).Cells(7).Style.SelectionBackColor = Color.SaddleBrown
            // Else
            // focusedDataGrid.Rows(e.RowIndex).Cells(7).Style.BackColor = Color.SlateGray
            // focusedDataGrid.Rows(e.RowIndex).Cells(7).Style.SelectionBackColor = Color.DimGray

            // End If
            focusedDataGrid.Rows[e.RowIndex].Cells[3].Style.ForeColor = Color.White;
            focusedDataGrid.Rows[e.RowIndex].Cells[8].Style.ForeColor = Color.White;
            focusedDataGrid.Rows[e.RowIndex].Cells[7].Style.ForeColor = Color.White;
        }

        private void InGateDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                bool value = Conversions.ToBoolean(InGateDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                if (value == false)
                {
                    InGateDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                    numbOfSelecCans += 1;
                }
                else
                {
                    InGateDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
                    numbOfSelecCans -= 1;
                }
            }

            // Enable/disable buttons
            checkButtons();
        }

        public void checkButtons()
        {
            if (numbOfSelecCans == 1)
            {
                deleteInBunifuButton.Enabled = true;
                addOutGateEntryButton.Enabled = true;
                editInBunifuButton.Enabled = true;
                InOutReceiptsToolStripMenuItem.Enabled = true;
                deleteOutBunifuButton.Enabled = true;
                editOutBunifuButton.Enabled = true;
            }
            else
            {
                deleteInBunifuButton.Enabled = false;
                editInBunifuButton.Enabled = false;
                addOutGateEntryButton.Enabled = false;
                InOutReceiptsToolStripMenuItem.Enabled = false;
                deleteOutBunifuButton.Enabled = false;
                addOutGateEntryButton.Enabled = false;
                editOutBunifuButton.Enabled = false;
            }
        }

        private void OutGateDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                bool value = Conversions.ToBoolean(OutGateDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                if (value == false)
                {
                    OutGateDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                    numbOfSelecCans += 1;
                }
                else
                {
                    OutGateDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
                    numbOfSelecCans -= 1;
                }
            }

            if (numbOfSelecCans == 1)
            {
                deleteOutBunifuButton.Enabled = true;
                editOutBunifuButton.Enabled = true;
            }
            else
            {
                deleteOutBunifuButton.Enabled = false;
                editOutBunifuButton.Enabled = false;
            }

            checkButtons();
        }

        private void containerCheckBox_CheckedChanged(object sender, BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                InGateDataGridView.Columns[""].Visible = true;
            }
            else
            {
                InGateDataGridView.Columns[2].Visible = false;
            }
        }

        private void BunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!firstLoad)
            {
                isRefresh = false;
                string search = "";
                string status;
                if (STATUSDropdown1.SelectedItem.Equals("VALID"))
                {
                    status = "[Trouble In-Gate] = 0 and ";
                }
                else if (STATUSDropdown1.SelectedItem.Equals("TROUBLE"))
                {
                    status = "[Trouble In-Gate] = 1 and ";
                }
                else
                {
                    status = "";
                }

                search = "[Container Number] Like '%" + conatinerTextBox.Text.ToUpper() + "%' and " + "[Yard Code In] Like '%" + locationTextBox.Text.ToUpper() + "%' and " + status + "[SS Line Code In] Like '%" + ssLineTextBox.Text.ToUpper() + "%' and " + "[Carrier Code In] Like '%" + carrierTextBox.Text.ToUpper() + "%' and " + "[Carrier Truck In] Like '%" + truckTextBox.Text.ToUpper() + "%' and " + "([Release Number] Like '%" + releaseTextBox.Text.ToUpper() + "%' or [Release Number] is null ) ";
                try
                {
                    searchTable = InOutDT.Select(search).CopyToDataTable();
                }
                catch
                {
                }

                getInOutGates(InGateDataGridView, "ingate");
            }
        }

        private void BunifuTextBox1Out_TextChanged(object sender, EventArgs e)
        {
            if (!firstLoad)
            {
                isRefresh = false;
                string search = "";
                string status;
                if (statusOutDropdown.SelectedItem.Equals("VALID"))
                {
                    status = "[Hold Out-Gate] = 0 and ";
                }
                else if (statusOutDropdown.SelectedItem.Equals("HOLD"))
                {
                    status = "[Hold Out-Gate] = 1 and ";
                }
                else
                {
                    status = "";
                }

                search = "[Container Number] Like '%" + contOutTextBox.Text.ToUpper() + "%' and " + "[Yard Code In] Like '%" + locationOutTextBox.Text.ToUpper() + "%' and " + status + "[SS Line Code Out] Like '%" + SSLineOutTextBox.Text.ToUpper() + "%' and " + "[Booking Number] Like '%" + bkngTextBox.Text.ToUpper() + "%' and " + "[Carrier Code Out] Like '%" + carrierOutTextBox.Text.ToUpper() + "%' and " + "[Carrier Truck Out] Like '%" + TruckOutTextBox.Text.ToUpper() + "%'";
                try
                {
                    searchTable = InOutDT.Select(search).CopyToDataTable();
                }
                catch
                {
                }

                getInOutGates(OutGateDataGridView, "outGate");
            }
        }

        private void tabinoutGate_SelectedIndexChanged(object sender, EventArgs e)
        {
            numbOfSelecCans = 0;
            for (int i = 0, loopTo = InGateDataGridView.Rows.Count - 1; i <= loopTo; i++)
                InGateDataGridView.Rows[i].Cells[1].Value = false;
            for (int i = 0, loopTo1 = OutGateDataGridView.Rows.Count - 1; i <= loopTo1; i++)
                OutGateDataGridView.Rows[i].Cells[1].Value = false;
            checkButtons();
        }

        private void BunifuButton1_Click_1(object sender, EventArgs e)
        {
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmOutGateReport, this);
        }

        private void BunifuButton2_Click(object sender, EventArgs e)
        {
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmReceiptsReport, this);
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            int recordId = 0;
            for (int i = 0, loopTo = OutGateDataGridView.Rows.Count - 1; i <= loopTo; i++)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(OutGateDataGridView.Rows[i].Cells[1].Value, true, false)))
                {
                    recordId = Conversions.ToInteger(OutGateDataGridView.Rows[i].Cells[0].Value);
                    break;
                }
            }

            dbCeres.rejectContainer(recordId);
        }
    }
}