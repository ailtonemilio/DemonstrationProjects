using BusinessLayer;
using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmRailList
    {
        public FrmRailList()
        {
            InitializeComponent();
            _ExportCSVToolStripMenuItem.Name = "ExportCSVToolStripMenuItem";
            _MissingUnitsToolStripMenuItem.Name = "MissingUnitsToolStripMenuItem";
            _CMLErrorsToolStripMenuItem.Name = "CMLErrorsToolStripMenuItem";
            _CommodityManagementMenuItem.Name = "CommodityManagementMenuItem";
            _btnAddManyUnita.Name = "btnAddManyUnita";
            _unitSourcesTabControl.Name = "unitSourcesTabControl";
            _dgvBookingUnit.Name = "dgvBookingUnit";
            _btnUnassign.Name = "btnUnassign";
            _dgvMU.Name = "dgvMU";
            _activeToggleSwitch.Name = "activeToggleSwitch";
            _RailList1.Name = "RailList1";
            _btnNewUnit.Name = "btnNewUnit";
            _btnAssociateBooking.Name = "btnAssociateBooking";
            _btnEditUnit.Name = "btnEditUnit";
        }

        private string[] BookingInfo;
        public string formMode;
        private string DBConnect = DatabaseHelperCeres.StrConnWTCCeres;
        public string[] selectedUnitNumber;
        public int[] selectedRecordKey;
        public List<int> SelectedUniSourceId = new List<int>();
        private string focusedUnitNumber;
        private int focusedUnitID;
        private DatabaseHelperCeres dbCeres = new DatabaseHelperCeres();

        private void FrmRailList_Load(object sender, EventArgs e)
        {
            LoadForm(true);
        }

        public void LoadForm(bool Refresh)
        {
            if (Refresh == true)
            {
                Show();
                RailList1.TakeRailList(FetchRailList(true), true);
                // Call CompareAgainstUnitSources(True)
                RailList1.Select();
                btnAssociateBooking.Enabled = false;
                btnEditUnit.Enabled = false;
            }
            else
            {
                RailList1.RequestSelectedUnitNumbers();
                MdlLoadingSetting.showDialogForm(My.MyProject.Forms.frmAssignUnitToBooking, ParentForm);
            }
            // CarregaUnit()
        }

        private void loadDataGrid()
        {
            switch (unitSourcesTabControl.SelectedIndex)
            {
                case 0:
                    {
                        dgvBookingUnit.DataSource = MinibookingMiniUnitAssignmentService.GetByUnitSourceId(focusedUnitID);
                        break;
                    }

                case 1:
                    {
                        VWUnitSourceMiniUnitBindingSource.DataSource = MiniUnitService.GetUsMuVwByUSId(focusedUnitID);
                        break;
                    }

                case 2:
                    {
                        break;
                    }
                    // populateReconciliation()
            }
        }

        public string FetchRailList(bool ActiveUnits)
        {
            short DayAmt = 0;
            int RecCount = 0;
            string BookingNumbers = "";
            string Sql = "";
            MdlContainerManagement.RailSight RailStructure;
            int TotalRecords = 0;
            string TempLine = "";
            var UnitLineStatus = default(char);
            if (ActiveUnits == true)
            {
                Sql = "Select * From VW_UnitSource Where Active = 1 and UnitStatus <> 'RELEASED' Order By UnitNumber";
            }
            else
            {
                Sql = "Select * From VW_UnitSource Where Active = 0 UnitStatus = 'RELEASED'  Order By UnitNumber";
            }

            var DbObjDataTable = new DataTable();
            var DbObjAdapter = new System.Data.SqlClient.SqlDataAdapter(Sql, DBConnect);
            var DbObjCommand = new System.Data.SqlClient.SqlCommandBuilder(DbObjAdapter);
            DbObjAdapter.Fill(DbObjDataTable);
            TotalRecords = DbObjDataTable.Rows.Count;
            if (TotalRecords > 0)
            {
                BookingInfo = new string[TotalRecords];
                Refresh();
                foreach (DataRow RailListRow in DbObjDataTable.Rows)
                {
                    RailStructure.UnitNumber = MdlContainerManagement.DoFunctions.PadToString(Conversions.ToString(RailListRow["OriginalUnitNumber"]), 16);
                    // .CustomerName = DoFunctions.PadToString(RailListRow("Consignee Name"), 50)
                    RailStructure.CustomerName = MdlContainerManagement.DoFunctions.PadToString(Conversions.ToString(RailListRow["CustomerName"]), 50);
                    RailStructure.UnitStatus = RailList1.ConvertUnitStatus(Conversions.ToString(RailListRow["UnitStatus"]));
                    if (Information.IsDate(RailListRow["LastTraced"]) == true)
                    {
                        RailStructure.LastUpdate = MdlContainerManagement.DoFunctions.DateToNum(DateAndTime.DateValue(Conversions.ToString(RailListRow["LastTraced"])));
                    }
                    else
                    {
                        RailStructure.LastUpdate = MdlContainerManagement.DoFunctions.MKL(0);
                    }

                    if (!(Information.IsDBNull(RailListRow["CallDate"]) == true))
                    {
                        RailStructure.CallDate = MdlContainerManagement.DoFunctions.DateToNum(Conversions.ToDate(RailListRow["CallDate"]));
                    }
                    else
                    {
                        RailStructure.CallDate = MdlContainerManagement.DoFunctions.MKL(0);
                    }

                    RailStructure.ArrivalDate = MdlContainerManagement.DoFunctions.MKL(0);
                    if (Information.IsDate(RailListRow["BillDate"]) == true)
                    {
                        RailStructure.WayBillDate = MdlContainerManagement.DoFunctions.DateToNum(DateAndTime.DateValue(Conversions.ToString(RailListRow["BillDate"])));
                    }
                    else
                    {
                        RailStructure.WayBillDate = MdlContainerManagement.DoFunctions.MKL(0);
                    }
                    // .ShipperName = DoFunctions.PadToString(RailListRow("Shipper Name"), 35)
                    RailStructure.ShipperName = MdlContainerManagement.DoFunctions.PadToString(Conversions.ToString(RailListRow["ShipperName"]), 35);
                    if (RailListRow.IsNull("OriginLocation") == true)
                    {
                        RailStructure.OriginLocation = MdlContainerManagement.DoFunctions.PadToString(Conversions.ToString(' '), 35);
                    }
                    else
                    {
                        RailStructure.OriginLocation = MdlContainerManagement.DoFunctions.PadToString(Conversions.ToString(RailListRow["OriginLocation"]), 35);
                    }

                    if (RailListRow.IsNull("UnitLine") == true)
                    {
                        RailStructure.SASC = MdlContainerManagement.DoFunctions.PadToString("", 4);
                    }
                    else
                    {
                        RailStructure.SASC = MdlContainerManagement.DoFunctions.PadToString(Conversions.ToString(RailListRow["UnitLine"]), 4);
                    }

                    if (RailListRow.IsNull("ETADate") == true)
                    {
                        RailStructure.ETADate = MdlContainerManagement.DoFunctions.MKL(0);
                        RailStructure.ETADays = MdlContainerManagement.DoFunctions.MKI(0);
                    }
                    else
                    {
                        RailStructure.ETADate = MdlContainerManagement.DoFunctions.DateToNum(DateAndTime.DateValue(Conversions.ToString(RailListRow["ETADate"])));
                        DayAmt = (short)DateAndTime.DateDiff(DateInterval.Day, DateAndTime.Today.Date, DateAndTime.DateValue(Conversions.ToString(RailListRow["ETADate"])));
                        if (DayAmt > 0)
                        {
                            RailStructure.ETADays = MdlContainerManagement.DoFunctions.MKI(DayAmt);
                        }
                        else
                        {
                            RailStructure.ETADays = MdlContainerManagement.DoFunctions.MKI(0);
                        }
                    }

                    RailStructure.EquipType = MdlContainerManagement.DoFunctions.PadToString(Conversions.ToString(RailListRow["UnitType"]), 6);
                    if (RailListRow.IsNull("TotalBilled") == true)
                    {
                        RailStructure.WgtMT = MdlContainerManagement.DoFunctions.MKS(0f);
                    }
                    else
                    {
                        RailStructure.WgtMT = MdlContainerManagement.DoFunctions.MKS(Conversions.ToSingle(RailListRow["TotalBilled"]));
                    }

                    RailStructure.Bags = MdlContainerManagement.DoFunctions.MKL(0);
                    if (RailListRow.IsNull("LastLocation") == true)
                    {
                        RailStructure.SightingLocation = MdlContainerManagement.DoFunctions.PadToString(Conversions.ToString(' '), 13);
                    }
                    else
                    {
                        RailStructure.SightingLocation = MdlContainerManagement.DoFunctions.PadToString(Conversions.ToString(RailListRow["LastLocation"]), 13);
                    }

                    RailStructure.CaargoDescription = MdlContainerManagement.DoFunctions.PadToString(Conversions.ToString(' '), 15);
                    BookingInfo[RecCount] = "";
                    TempLine += Conversions.ToString('\0') + RailStructure.UnitNumber + RailStructure.CustomerName + Conversions.ToString(RailStructure.UnitStatus) + RailStructure.LastUpdate + RailStructure.SightingLocation + RailStructure.ETADate + RailStructure.ETADays + RailStructure.CallDate + RailStructure.ArrivalDate + RailStructure.WayBillDate + RailStructure.ShipperName + RailStructure.OriginLocation + RailStructure.SASC + RailStructure.EquipType + RailStructure.WgtMT + RailStructure.Bags + RailStructure.CaargoDescription + Conversions.ToString(UnitLineStatus) + MdlContainerManagement.DoFunctions.MKL(0) + MdlContainerManagement.DoFunctions.MKL(Conversions.ToInteger(RailListRow["UnitSourceId"]));
                    RecCount += 1;
                }
            }

            deactivateBtns();
            return TempLine;
        }

        public char ConvertUnitStatus(string UnitStatus)
        {
            if (UnitStatus == "CALLED")
            {
                return '\u0006';
            }
            else if (UnitStatus == "IN TRANSIT")
            {
                return '\u0003';
            }
            else if (UnitStatus == "NOT TRACING")
            {
                return '\u0004';
            }
            else if (UnitStatus == "AVAILABLE")
            {
                return '\u0005';
            }
            else if (UnitStatus == "MISSED")
            {
                return '\a';
            }
            else if (UnitStatus == "ON HAND")
            {
                return '\b';
            }
            else
            {
                return '\0';
            }
            // GiveRailStatusColour(Mid(Linee, 68, 1), StatusText)
        }

        private string FetchThisBooking(string ThisBookNumber, int railListID)
        {
            short x = 0;
            short cnt = 0;
            string SQL = "";
            string BookingLine = "";
            string BookingNumber = "";
            string DeliverBook = "";
            string SSLineCode = "";
            string DeliverCanTotal = "";
            string LRDDate = "";
            char LRDTime = '\0';
            string TerminalName = "";
            string VesselName = "";
            char SplitBooking = '\0';
            string DeliverBookings = "";
            string TempLine = "";
            string ChangedMask = "";
            string DeliverReadyCans = "";
            int BookCount = 0;
            short TotalCans = 0;
            short DeliverCans = 0;
            string bkLetter;
            string unit;
            string recordKeyQuery;
            if (railListID == 0)
            {
                recordKeyQuery = "[RailListID] is null";
            }
            else
            {
                recordKeyQuery = "[RailListID] = '" + railListID.ToString() + "'";
            }

            SQL = @"select b.*, [MiniBookingOrder], MiniUnitOrder, bus.Unit from Bookings as b
 join MiniBooking as mb on b.[Booking Number] = mb.[BookingNumber] and
b.[Booking Number] = '" + ThisBookNumber + @"'
join [Booking Unit Sources] bus on bus.[Minibooking ID] = mb.[MiniBookingId] and " + recordKeyQuery + " and Unit = '" + focusedUnitNumber + @"'
 left join MiniUnit as mu on mu.MiniUnitId = bus.MiniUnitID order by [MiniBookingOrder] ";
            var DbObjDataTable = new DataTable();
            var DbObjAdapter = new System.Data.SqlClient.SqlDataAdapter(SQL, DBConnect);
            var DbObjCommand = new System.Data.SqlClient.SqlCommandBuilder(DbObjAdapter);
            DbObjAdapter.Fill(DbObjDataTable);
            Refresh();
            foreach (DataRow BookNum in DbObjDataTable.Rows)
            {
                bool multiMB = DbObjDataTable.Select(Conversions.ToString(Operators.AddObject(Operators.AddObject("[Booking Number] = '", BookNum["Booking Number"]), "'"))).Length > 1;
                if (multiMB)
                {
                    bkLetter = "(" + MdlBookingManagement.digitToLetter(BookNum["MiniBookingOrder"]) + ")";
                }
                else
                {
                    bkLetter = "";
                }

                BookingNumber = MdlContainerManagement.DoFunctions.PadToString(Strings.Trim(Conversions.ToString(BookNum["Booking Number"])) + bkLetter, 40);
                if (!string.IsNullOrEmpty(Strings.RTrim(BookingNumber)))
                {
                    if (!BookNum.IsNull("LRD") & Information.IsDate(BookNum["LRD"]))
                    {
                        LRDDate = MdlContainerManagement.DoFunctions.DateToNum(DateAndTime.DateValue(Conversions.ToString(BookNum["LRD"])));
                    }
                    else
                    {
                        LRDDate = MdlContainerManagement.DoFunctions.MKL(0);
                    }

                    if (BookNum.IsNull("Terminal Name") == true)
                    {
                        TerminalName = MdlContainerManagement.DoFunctions.PadToString(Conversions.ToString(' '), 40);
                    }
                    else
                    {
                        TerminalName = MdlContainerManagement.DoFunctions.PadToString(Conversions.ToString(BookNum["Terminal Name"]), 40);
                    }

                    if (BookNum.IsNull("Vessel Name") == true)
                    {
                        VesselName = MdlContainerManagement.DoFunctions.PadToString(Conversions.ToString(' '), 50);
                    }
                    else
                    {
                        VesselName = MdlContainerManagement.DoFunctions.PadToString(Conversions.ToString(BookNum["Vessel Name"]), 50);
                    }

                    if (BookNum.IsNull("Split Booking") == false && Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(BookNum["Split Booking"], true, false)))
                    {
                        SplitBooking = '\u0001';
                    }
                    else
                    {
                        SplitBooking = '\0';
                    }

                    if (BookNum.IsNull("SS Line Code") == true)
                    {
                        SSLineCode = MdlContainerManagement.DoFunctions.PadToString(Conversions.ToString(' '), 10);
                    }
                    else
                    {
                        SSLineCode = MdlContainerManagement.DoFunctions.PadToString(Conversions.ToString(BookNum["SS Line Code"]), 10);
                    }

                    LRDTime = '\0';
                    ChangedMask = Conversions.ToString('\0') + Conversions.ToString('\0') + Conversions.ToString('\0') + Conversions.ToString('\0');

                    // DeliverBook = Mid(DeliverBookings, x, 40)
                    DeliverCanTotal = MdlContainerManagement.DoFunctions.MKL(Conversions.ToInteger(BookNum["Number Of Cans"]));
                    if (multiMB)
                    {
                        if (!Information.IsDBNull(BookNum["MiniUnitOrder"]))
                        {
                            bkLetter = "(" + MdlBookingManagement.digitToLetter(BookNum["MiniUnitOrder"]).ToUpper() + ")";
                        }
                        else
                        {
                            bkLetter = "";
                        }
                    }
                    else
                    {
                        bkLetter = "";
                    }

                    unit = MdlContainerManagement.DoFunctions.PadToString(Strings.Trim(Conversions.ToString(BookNum["Unit"])) + bkLetter, 40);
                    TempLine = Conversions.ToString('\0') + BookingNumber + unit + SSLineCode + LRDDate + Conversions.ToString(LRDTime) + TerminalName + VesselName + Conversions.ToString(SplitBooking) + DeliverCanTotal + MdlContainerManagement.DoFunctions.MKL(0) + MdlContainerManagement.DoFunctions.MKL(0) + MdlContainerManagement.DoFunctions.MKL(0) + MdlContainerManagement.DoFunctions.MKL(0) + ChangedMask;
                    BookingLine += TempLine;

                    // Next x
                    // End If
                }
            }

            return BookingLine;
        }

        private void FoundChangeRequest(string DeliverIndex, string ChangeRequest, ref string ChangeStatus, ref string LRDDate, ref char LRDTime, ref string TerminalName, ref string VesselName)
        {
            int x = 0;
            string DeliverLine = "";
            var loopTo = Strings.Len(ChangeRequest);
            for (x = 1; x <= loopTo; x += 108)
            {
                if ((DeliverIndex ?? "") == (Strings.Mid(ChangeRequest, x, 2) ?? ""))
                {
                    DeliverLine = Strings.Mid(ChangeRequest, x + 2, 106);
                    if (Strings.Mid(DeliverLine, 8, 1) != Conversions.ToString('\0'))
                    {
                        var midTmp = Strings.Mid(DeliverLine, 8, 1);
                        StringType.MidStmtStr(ref ChangeStatus, 1, 1, midTmp);
                        LRDDate = Strings.Mid(DeliverLine, 9, 4);
                    }

                    if (Strings.Mid(DeliverLine, 13, 1) != Conversions.ToString('\0'))
                    {
                        var midTmp1 = Strings.Mid(DeliverLine, 13, 1);
                        StringType.MidStmtStr(ref ChangeStatus, 2, 1, midTmp1);
                        LRDTime = Conversions.ToChar(Strings.Mid(DeliverLine, 14, 1));
                    }

                    if (Strings.Mid(DeliverLine, 15, 1) != Conversions.ToString('\0'))
                    {
                        var midTmp2 = Strings.Mid(DeliverLine, 15, 1);
                        StringType.MidStmtStr(ref ChangeStatus, 3, 1, midTmp2);
                        TerminalName = MdlContainerManagement.DoFunctions.PadToString(Strings.Mid(DeliverLine, 16, 40), 40);
                    }

                    if (Strings.Mid(DeliverLine, 56, 1) != Conversions.ToString('\0'))
                    {
                        var midTmp3 = Strings.Mid(DeliverLine, 56, 1);
                        StringType.MidStmtStr(ref ChangeStatus, 4, 1, midTmp3);
                        VesselName = MdlContainerManagement.DoFunctions.PadToString(Strings.Mid(DeliverLine, 57, 50), 50);
                    }

                    return;
                }
            }
        }

        private void FrmRailList_Resize(object sender, EventArgs e)
        {
            {
                var withBlock = this;
                RailList1.Width = withBlock.Width - 60;

                // RailList1.Height = .Height - (RailBookingList1.Height + 230)
                ShapedPanel2.Width = withBlock.Width - 60;
            }
        }

        private void RailList1_ExportRailListCSVs(short RecLgt, string RailList)
        {
            int x = 0;
            string ETADays = "";
            string CSVLine = "";
            string ThisCSVFile = "";
            string TempLine = "";
            var NumCount = new string[5];
            string LastTrace = "";
            string BillDate = "";
            string ETADate = "";
            string UnitStatus = "";
            float WeightMT;
            System.IO.StreamWriter file;
            ThisCSVFile = System.IO.Path.GetTempPath() + "RailList-" + DateTime.Today.ToString("dd-MMM-yyyy") + "-" + Strings.Format(DateAndTime.TimeOfDay, "hhmmss") + ".CSV";
            if (System.IO.File.Exists(ThisCSVFile) == true)
            {
                System.IO.File.Delete(ThisCSVFile);
            }

            file = My.MyProject.Computer.FileSystem.OpenTextFileWriter(ThisCSVFile, true);
            file.WriteLine("Unit #" + Conversions.ToString(',') + "Customer" + Conversions.ToString(',') + "Status" + Conversions.ToString(',') + "Last Trace" + Conversions.ToString(',') + "Location" + Conversions.ToString(',') + "ETA Date" + Conversions.ToString(',') + "Days" + Conversions.ToString(',') + "Call Date" + Conversions.ToString(',') + "Arrival Date" + Conversions.ToString(',') + "Bill Date" + Conversions.ToString(',') + "Shipper" + Conversions.ToString(',') + "Origin" + Conversions.ToString(',') + "Carrier" + Conversions.ToString(',') + "Type" + Conversions.ToString(',') + "Wgt MT" + Conversions.ToString(',') + "Bags" + Conversions.ToString(',') + "Commodity" + Conversions.ToString(',') + "Track" + Conversions.ToString(',') + "Notes");
            var loopTo = Strings.Len(RailList);
            for (x = 1; RecLgt >= 0 ? x <= loopTo : x >= loopTo; x += RecLgt)
            {
                CSVLine = Strings.Mid(RailList, x, RecLgt);
                UnitStatus = GiveUnitStatus(Conversions.ToChar(Strings.Mid(CSVLine, 62, 1)));
                if ((Strings.Mid(CSVLine, 63, 4) ?? "") == (MdlContainerManagement.DoFunctions.MKL(0) ?? ""))
                {
                    LastTrace = "";
                }
                else
                {
                    LastTrace = MdlContainerManagement.DoFunctions.NumToDate(Strings.Mid(CSVLine, 63, 4));
                }

                if ((Strings.Mid(CSVLine, 80, 4) ?? "") == (MdlContainerManagement.DoFunctions.MKL(0) ?? ""))
                {
                    ETADate = "";
                }
                else
                {
                    ETADate = MdlContainerManagement.DoFunctions.NumToDate(Strings.Mid(CSVLine, 80, 4));
                }

                if ((Strings.Mid(CSVLine, 84, 2) ?? "") == (MdlContainerManagement.DoFunctions.MKI(0) ?? ""))
                {
                    ETADays = "";
                }
                else
                {
                    ETADays = MdlContainerManagement.DoFunctions.CVI(Strings.Mid(CSVLine, 84, 2)).ToString();
                }

                if ((Strings.Mid(CSVLine, 94, 4) ?? "") == (MdlContainerManagement.DoFunctions.MKL(0) ?? ""))
                {
                    BillDate = "";
                }
                else
                {
                    BillDate = MdlContainerManagement.DoFunctions.NumToDate(Strings.Mid(CSVLine, 94, 4));
                }

                if ((Strings.Mid(CSVLine, 163, 4) ?? "") == (MdlContainerManagement.DoFunctions.MKL(0) ?? ""))
                {
                    WeightMT = 0f;
                }
                else
                {
                    WeightMT = MdlContainerManagement.DoFunctions.CVL(Strings.Mid(CSVLine, 163, 4));
                }

                TempLine = Strings.RTrim(Strings.Mid(CSVLine, 2, 10)) + Conversions.ToString(',') + Strings.RTrim(Strings.Mid(CSVLine, 12, 50)) + Conversions.ToString(',') + UnitStatus + Conversions.ToString(',') + LastTrace + Conversions.ToString(',') + MdlContainerManagement.StripCommas(Strings.RTrim(Strings.Mid(CSVLine, 67, 13))) + Conversions.ToString(',') + ETADate + Conversions.ToString(',') + ETADays + Conversions.ToString(',') + "" + Conversions.ToString(',') + "" + Conversions.ToString(',') + BillDate + Conversions.ToString(',') + Strings.RTrim(Strings.Mid(CSVLine, 98, 35)) + Conversions.ToString(',') + MdlContainerManagement.StripCommas(Strings.RTrim(Strings.Mid(CSVLine, 133, 35))) + Conversions.ToString(',') + Strings.RTrim(Strings.Mid(CSVLine, 168, 4)) + Conversions.ToString(',') + Strings.RTrim(Strings.Mid(CSVLine, 172, 6)) + Conversions.ToString(',') + MdlContainerManagement.DoFunctions.CVS(Strings.Mid(CSVLine, 178, 4)).ToString() + Conversions.ToString(',') + "" + Conversions.ToString(',') + MdlContainerManagement.StripCommas(Strings.RTrim(Strings.Mid(CSVLine, 186, 15))); // RTrim(Mid(CSVLine, 157, 6)) + Chr(44) + CStr(WeightMT) + Chr(44) + "" + Chr(44) + StripCommas(RTrim(Mid(CSVLine, 171, 13))) + Chr(44) + StripCommas(RTrim(Mid(CSVLine, 184, 15)))
                file.WriteLine(TempLine);
            }

            file.Close();
            Process.Start("EXCEL.EXE", ThisCSVFile);
        }

        private void RailList1_FetchRailUnitBookings(string UnitNumber, int RecordID, int unitID)
        {
            focusedUnitID = RecordID;
            loadDataGrid();
        }

 
        private void RailList1_RequestRailListModse(bool ActiveUnits)
        {
            MdlLoadingSetting.waitForm.Show();
            RailList1.TakeRailList(FetchRailList(ActiveUnits), true);
            // Call CompareAgainstUnitSources()

            MdlLoadingSetting.waitForm.Close();
        }

        private void BunifuToggleSwitch1_OnValuechange(object sender, EventArgs e)
        {
            MdlLoadingSetting.waitForm.Show();
            try
            {
                RailList1.TakeRailList(FetchRailList(activeToggleSwitch.Value), true);
            }
            // Call CompareAgainstUnitSources(activeToggleSwitch.Value)
            // Call CompareAgainstUnitSources()
            catch (Exception ex)
            {
                string msg = ex.Message;
            }

            MdlLoadingSetting.waitForm.Close();
        }

        // Private Sub manualReleaseBtn_Click(sender As Object, e As EventArgs) Handles manualReleaseBtn.Click

        // showDialogForm(FrmReleaseRailUnit, Me)
        // 'Call FrmReleaseRailUnit.TakeUnitsToRelease(RailList1.GetReleaseUnits())
        // End Sub

        private string GiveUnitStatus(char StatusCode)
        {
            if (StatusCode == '\u0003')
            {
                return "In Transit";
            }
            else if (StatusCode == '\u0004')
            {
                return "Not Tracing";
            }
            else if (StatusCode == '\u0005')
            {
                return "Available";
            }
            else if (StatusCode == '\u0006')
            {
                return "CALLED";
            }
            else if (StatusCode == '\a')
            {
                return "MISSED";
            }
            else if (StatusCode == '\b')
            {
                return "On-Hand";
            }
            else
            {
                return "";
            }
        }

        // Private Sub RailList1_ReleaseUnits(UnitList As String) Handles RailList1.ReleaseUnits
        // Call FrmReleaseRailUnit.TakeUnitsToRelease(UnitList)
        // End Sub

        private void RailList1_UnitedSelected(bool Selected)
        {
            if (Selected)
            {
                manualReleaseBtn.Enabled = true;
                btnEditUnit.Enabled = true;
                btnAssociateBooking.Enabled = true;
            }
            else
            {
                manualReleaseBtn.Enabled = false;
                btnEditUnit.Enabled = false;
                btnAssociateBooking.Enabled = false;
            }

            RailList1.RequestSelectedUnitNumbers();
        }

        private void RailList1_GiveSelectionRequested(int UnitTotal, string[] UNitNumbers, int[] RecordIDs, int[] UnitIDs)
        {
            selectedUnitNumber = UNitNumbers;
            selectedRecordKey = RecordIDs;
            SelectedUniSourceId.Clear();
            foreach (var unit in UnitIDs)
                SelectedUniSourceId.Add(unit);
            // SelectedUniSourceId = UnitIDs
        }

        private void btnAssociateBooking_Click(object sender, EventArgs e)
        {
            RailList1.RequestSelectedUnitNumbers();
            var muRow = new VW_UnitSourceMiniUnit();
            var mbMU = new DataTable();
            var muRowList = new List<VW_UnitSourceMiniUnit>();
            var multiMUList = new List<VW_UnitSourceMiniUnit>();
            var muListToAssign = new List<VW_UnitSourceMiniUnit>();
            string diffCargosList = "";
            string diffCustomerList = "";
            var SelectedUs = UnitSourceService.GetByUnitSourceListById(SelectedUniSourceId);
            if (hasSameCargoTypes(SelectedUs, ref diffCargosList) == false)
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Can not proceed:", "It Seems like different cargo types has been selected. Please, select only one type of cargo type to continue." + Constants.vbNewLine + "Units:" + Constants.vbNewLine + diffCargosList, this);
                return;
            }
            else if (hasSameCustomers(SelectedUs, ref diffCustomerList) == false)
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Can not proceed:", "It Seems like different Customers has been selected. Please, select the same customer name  to continue." + Constants.vbNewLine + "Units:" + Constants.vbNewLine + diffCustomerList, this);
                return;
            }

            {
                var withBlock = My.MyProject.Forms.frmMiniUnitToAssign;

                // Lopp through selected Unit sources
                for (int i = 0, loopTo = SelectedUniSourceId.Count - 1; i <= loopTo; i++)
                {
                    // Get All MiniUnits from unitID
                    muRowList = VW_UnitSOurceMiniUnitService.GetByUnitSourceById(SelectedUniSourceId[i]);

                    // If more than one mu, send them to Form where user will pick the mini unit
                    if (muRowList.Count > 1)
                    {
                        foreach (var mu in muRowList)
                            multiMUList.Add(mu);
                        withBlock.VWUnitSourceMiniUnitBindingSource.DataSource = multiMUList;
                    }

                    // If theres only one MU, send it straigt to Form where mini unit will be asn to minibooking
                    else if (muRowList.Count == 1)
                    {
                        muListToAssign.Add(muRowList[0]);
                        My.MyProject.Forms.frmAssignUnitToBooking.dgvMiniUnit.DataSource = muListToAssign;
                    }

                    // If there's no mini unit, give the option to edit unit source, and repeat process
                    else if (My.MyProject.Forms.MessageBoxCeresYesNo.ShowDialog("There is not Mini Unit for this Unit.", "Create Mini Unit ?", My.Resources.Resources.caution, this) == DialogResult.Yes)
                    {
                        // FrmEditAddRailList.

                        var unit = UnitSourceService.GetVWById(SelectedUniSourceId[i]);
                        var unitList = new List<VW_UnitSource>();
                        unitList.Add(unit);
                        My.MyProject.Forms.FrmEditAddRailList.isNewRecord = false;
                        My.MyProject.Forms.FrmEditAddRailList.isMultiEdit = false;
                        My.MyProject.Forms.FrmEditAddRailList.LoadForm(unitList);
                        RailList1.RequestSelectedUnitNumbers();
                        MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmEditAddRailList, My.MyProject.Forms.FrmParentScreen);
                        muRowList = VW_UnitSOurceMiniUnitService.GetByUnitSourceById(SelectedUniSourceId[i]);
                        if (muRowList.Count > 1)
                        {
                            foreach (var mu in muRowList)
                                multiMUList.Add(mu);
                            withBlock.VWUnitSourceMiniUnitBindingSource.DataSource = multiMUList;
                        }
                        else if (muRowList.Count == 1)
                        {
                            muListToAssign.Add(muRowList[0]);
                            My.MyProject.Forms.frmAssignUnitToBooking.dgvMiniUnit.DataSource = muListToAssign;
                        }
                    }
                }

                if (My.MyProject.Forms.frmMiniUnitToAssign.VWUnitSourceMiniUnitBindingSource.Count > 1)
                {
                    MdlLoadingSetting.showDialogForm(My.MyProject.Forms.frmMiniUnitToAssign, this);
                }
                else if (Convert.ToInt32(((List<object>)My.MyProject.Forms.frmAssignUnitToBooking.dgvMiniUnit.DataSource).Count) > 0)
                {
                    MdlLoadingSetting.showDialogForm(My.MyProject.Forms.frmAssignUnitToBooking, this);
                }
                else
                {
                    RailList1.TakeRailList(FetchRailList(true), true);
                }
            }
        }

        private bool hasSameCargoTypes(List<VW_UnitSource> selectedUnits, ref string diffCargosList)
        {
            string firstCargoId = "";
            bool isSameCargo = true;
            firstCargoId = selectedUnits[0].CargoTypeCode;
            foreach (var unit in selectedUnits)
            {
                if ((firstCargoId ?? "") != (unit.CargoTypeCode ?? ""))
                {
                    if (!((firstCargoId.Equals("BLK") | firstCargoId.Equals("BGR")) & (unit.CargoTypeCode.Equals("BLK") | unit.CargoTypeCode.Equals("BGR"))))
                    {
                        isSameCargo = false;
                    }
                }

                diffCargosList += unit.UnitNumber + " - " + unit.CargoType + Constants.vbNewLine;
            }

            return isSameCargo;
        }

        private bool hasSameCustomers(List<VW_UnitSource> selectedUnits, ref string diffCustomerList)
        {
            string firstCustomer = "";
            bool isSameCustomer = true;
            firstCustomer = selectedUnits[0].CustomerName;
            isSameCustomer = true;
            foreach (var unit in selectedUnits)
            {
                if ((firstCustomer ?? "") != (unit.CustomerName ?? ""))
                {
                    isSameCustomer = false;
                }

                diffCustomerList += unit.UnitNumber + " - " + unit.CustomerName + Constants.vbNewLine;
            }

            return isSameCustomer;
        }

        public void deactivateBtns()
        {
            btnAssociateBooking.Enabled = false;
            btnEditUnit.Enabled = false;
        }

        private void btnEditUnit_Click(object sender, EventArgs e)
        {
            RailList1.RequestSelectedUnitNumbers();
            if (SelectedUniSourceId.Count > 1)
            {
                var unitList = new List<VW_UnitSource>();
                unitList = UnitSourceService.GetByUnitSourceListById(SelectedUniSourceId);
                My.MyProject.Forms.FrmEditAddRailList.isMultiEdit = true;
                My.MyProject.Forms.FrmEditAddRailList.isNewRecord = false;
                My.MyProject.Forms.FrmEditAddRailList.LoadForm(unitList);
                MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmEditAddRailList, ParentForm);
            }
            else
            {
                var unit = UnitSourceService.GetVWById(SelectedUniSourceId[0]);
                var unitList = new List<VW_UnitSource>();
                unitList.Add(unit);
                My.MyProject.Forms.FrmEditAddRailList.isMultiEdit = false;
                My.MyProject.Forms.FrmEditAddRailList.isNewRecord = false;
                My.MyProject.Forms.FrmEditAddRailList.LoadForm(unitList);
                MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmEditAddRailList, ParentForm);
            }
        }

        private void btnNewUnit_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmEditAddRailList.isNewRecord = true;
            My.MyProject.Forms.FrmEditAddRailList.LoadForm(null);
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmEditAddRailList, ParentForm);
        }

        private void ExportCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RailList1.GetCSV();
        }

        

        private void unitSourcesTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDataGrid();
        }

        private void populateReconciliation()
        {
            var recDT = new DataTable();
            string query;
            decimal totalBilled = 0m;
            decimal totalLoaded = 0m;
            decimal totalReconciliation = 0m;
            dgvReconciliation.Rows.Clear();
            query = "where UnitSource = '" + focusedUnitNumber + "'";
            recDT = dbCeres.getTableInfo("VW_BookingUnitsReconciliation", "*", query);
            if (recDT.Rows.Count > 0)
            {
                foreach (DataRow row in recDT.Rows)
                {
                    if (!Information.IsDBNull(row["Loaded"]))
                    {
                        totalLoaded = Conversions.ToDecimal(Operators.AddObject(totalLoaded, row["Loaded"]));
                    }

                    if (!Information.IsDBNull(row["TotalBilled"]))
                    {
                        totalBilled = Conversions.ToDecimal(Operators.AddObject(totalBilled, row["TotalBilled"]));
                    }

                    if (!Information.IsDBNull(row["Reconciliation"]))
                    {
                        totalReconciliation = Conversions.ToDecimal(Operators.AddObject(totalReconciliation, row["Reconciliation"]));
                    }

                    dgvReconciliation.Rows.Add("", row["UnitSource"], row["BookingNumber"], row["CustomerName"], row["TotalBilled"]);
                }
            }

            lblTotBillUnit.Text = totalBilled.ToString();
            lbltotBillBk.Text = totalLoaded.ToString();
            lblDisc.Text = totalReconciliation.ToString();
        }

        // Private Sub dgvReconciliation_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvReconciliation.CellPainting

        // MergeEqualCells(e, dgvReconciliation)
        // End Sub

        private void btnUnassign_Click(object sender, EventArgs e)
        {
            UnassignUnits();
        }

        private void dgvBookingUnit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                bool value = Conversions.ToBoolean(dgvBookingUnit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                if (value == false)
                {
                    dgvBookingUnit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                }
                else
                {
                    dgvBookingUnit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
                }
            }

            btnUnassign.Enabled = false;
            for (int i = 0, loopTo = dgvBookingUnit.Rows.Count - 1; i <= loopTo; i++)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dgvBookingUnit.Rows[i].Cells[0].Value, true, false)))
                {
                    btnUnassign.Enabled = true;
                    break;
                }
            }
        }

        private void UnassignUnits()
        {
            var mbus = new MinibookingMiniUnitAssignmentService();
            var isUnassigned = default(bool);
            var mbIdList = new Dictionary<int, string>();
            List<VW_MinibookingMiniUnitAssignment> assignedCansList;
            VW_MinibookingMiniUnitAssignment muAsn;
            MdlLoadingSetting.waitForm.Show();
            for (int i = 0, loopTo = dgvBookingUnit.Rows.Count - 1; i <= loopTo; i++)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dgvBookingUnit.Rows[i].Cells[0].Value, true, false)))
                {
                    muAsn = (VW_MinibookingMiniUnitAssignment)dgvBookingUnit.Rows[i].DataBoundItem;
                    if (!mbIdList.ContainsKey(muAsn.MinibookingId))
                    {
                        mbIdList.Add(muAsn.MinibookingId, Strings.Trim(muAsn.BookingNumber));
                    }

                    isUnassigned = mbus.Delete(muAsn.AssignmentId, muAsn.isStorageUnit == true);
                    if (muAsn.isStorageUnit == true)
                    {
                        EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, "UnitId: " + muAsn.MiniUnitId.ToString() + " | MbId: " + muAsn.MinibookingId.ToString(), "UNASSIGN", "UNIT", "Storage Unit Source " + muAsn.MiniUnitNumber + " unassigned from booking " + muAsn.BookingNumber);
                    }
                    else
                    {
                        EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, "UnitId: " + muAsn.MiniUnitId.ToString() + " | MbId: " + muAsn.MinibookingId.ToString(), "UNASSIGN", "UNIT", "Unit Source " + muAsn.MiniUnitNumber + " unassigned from booking " + muAsn.BookingNumber);
                    }
                }
            }

            foreach (var value in mbIdList)
                // updateUnitsInExcelFile(value.Value, assignedCansList)
                assignedCansList = MinibookingMiniUnitAssignmentService.GetByMiniBookingId(value.Key);
            dgvBookingUnit.DataSource = MinibookingMiniUnitAssignmentService.GetByUnitSourceId(focusedUnitID);
            MdlLoadingSetting.waitForm.Close();
            if (isUnassigned)
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Sucess!", "Unit source(s) unassigned with success!", this);
            }

            btnUnassign.Enabled = false;
        }

        private void dgvBookingUnit_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var splitCel = dgvBookingUnit.Rows[e.RowIndex].Cells["SplitBooking"];
            var service = dgvBookingUnit.Rows[e.RowIndex].Cells["ServiceCode"];
            splitCel.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBookingUnit.Rows[e.RowIndex].Cells[4].Style.Font = new Font(Font, FontStyle.Bold);
            dgvBookingUnit.Rows[e.RowIndex].Cells[5].Style.Font = new Font(Font, FontStyle.Bold);
            service.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            service.Style.Font = new Font(Font, FontStyle.Bold);
            splitCel.Style.Font = new Font(Font, FontStyle.Bold);
            service.Style.Font = new Font(Font, FontStyle.Bold);
            service.Style.ForeColor = Color.White;
            service.Style.SelectionForeColor = Color.White;
            if (splitCel.Value.Equals("DNS"))
            {
                splitCel.Style.BackColor = Color.Red;
            }
            else
            {
                splitCel.Style.BackColor = Color.Green;
            }

            switch (service.Value)
            {
                case "BAG":
                    {
                        service.Style.SelectionBackColor = Color.Olive;
                        service.Style.BackColor = Color.DarkKhaki;
                        break;
                    }

                case "BGR":
                    {
                        service.Style.SelectionBackColor = Color.DarkGoldenrod;
                        service.Style.BackColor = Color.Goldenrod;
                        break;
                    }

                case "BLK":
                    {
                        service.Style.SelectionBackColor = Color.DarkKhaki;
                        service.Style.BackColor = Color.DarkSeaGreen;
                        break;
                    }
            }

            splitCel.Style.ForeColor = Color.White;
        }

        private void dgvMU_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var BalanceInstrux = dgvMU.Rows[e.RowIndex].Cells["BalanceInstruxCode"];
            BalanceInstrux.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            BalanceInstrux.Style.Font = new Font(Font, FontStyle.Bold);
            dgvMU.Rows[e.RowIndex].Cells[4].Style.Font = new Font(Font, FontStyle.Bold);
            dgvMU.Rows[e.RowIndex].Cells[8].Style.Font = new Font(Font, FontStyle.Bold);
            // dgvBookingUnit.Rows(e.RowIndex).Cells(17).Style.Font = New Font(Me.Font, FontStyle.Bold)

            // If UnitStatusCel.Value.Equals("IN-TRANSIT") Then
            // UnitStatusCel.Style.BackColor = Color.FromArgb(64, 64, 64)
            // ElseIf UnitStatusCel.Value.Equals("NOT TRACING") Then
            // UnitStatusCel.Style.BackColor = Color.Red
            // ElseIf UnitStatusCel.Value.Equals("AVAILABLE") Then
            // UnitStatusCel.Style.BackColor = Color.DarkGreen
            // ElseIf UnitStatusCel.Value.Equals("CALLED") Then
            // UnitStatusCel.Style.BackColor = Color.Orange
            // ElseIf UnitStatusCel.Value.Equals("MISSED") Then
            // UnitStatusCel.Style.BackColor = Color.IndianRed
            // ElseIf UnitStatusCel.Value.Equals("ON-HAND") Then
            // UnitStatusCel.Style.BackColor = Color.OliveDrab
            // Else
            // UnitStatusCel.Style.BackColor = Color.Gainsboro
            // End If

            if (!Information.IsNothing(BalanceInstrux.Value))
            {
                if (BalanceInstrux.Value.Equals("BLTS"))
                {
                    BalanceInstrux.Style.BackColor = Color.OrangeRed;
                }
                else
                {
                    BalanceInstrux.Style.BackColor = Color.DarkGray;
                }
                // UnitStatusCel.Style.ForeColor = Color.White
                BalanceInstrux.Style.ForeColor = Color.White;
            }
        }

        private void CommodityManagementMenuItem_Click(object sender, EventArgs e)
        {
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.frmCommodityGrainMain, this);
        }

        private void btnAddManyUnita_Click(object sender, EventArgs e)
        {
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAddMultipleUnits, this);
            RailList1.TakeRailList(FetchRailList(true), true);
        }
    }
}