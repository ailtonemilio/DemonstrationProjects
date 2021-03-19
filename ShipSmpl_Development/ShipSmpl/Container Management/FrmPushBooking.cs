using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.IO;

namespace ShipSmpl
{
    public partial class FrmPushBooking
    {
        public FrmPushBooking()
        {
            InitializeComponent();
            _BookingList1.Name = "BookingList1";
        }

        private Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
        private Workbook XLWorkbook;
        public System.Data.SqlClient.SqlConnection DBConnect;

        private void FrmPushBooking_Load(object sender, EventArgs e)
        {
            BookingList1.BookingsListMode = WTC_CeresControls.BookingList.ModeOfBookingsList.BookingsPushList;
            BookingList1.TakeBookingList(FetchActiveBookings());
        }

        public string FetchActiveBookings()
        {
            string SQL = "";
            string BookingLine = "";
            string BookingNumber = "";
            string CustomerName = "";
            SQL = "Select Distinct [Original Booking], [Customer Name] From [Bookings]  Order By [Original Booking]";
            DBConnect = new System.Data.SqlClient.SqlConnection(DatabaseHelperCeres.StrConnWTCCeres);
            DBConnect.Open();
            var DbObjDataTable = new System.Data.DataTable();
            var DbObjAdapter = new System.Data.SqlClient.SqlDataAdapter(SQL, DBConnect);
            var DbObjCommand = new System.Data.SqlClient.SqlCommandBuilder(DbObjAdapter);
            DbObjAdapter.Fill(DbObjDataTable);
            foreach (DataRow BookNum in DbObjDataTable.Rows)
            {
                BookingNumber = MdlContainerManagement.DoFunctions.PadToString(Conversions.ToString(BookNum["Original Booking"]), 40);
                CustomerName = MdlContainerManagement.DoFunctions.PadToString(Conversions.ToString(BookNum["Customer Name"]), 50);
                BookingLine += Conversions.ToString('\0') + BookingNumber + CustomerName + Conversions.ToString('\0');
            }

            DBConnect.Close();
            return BookingLine;
        }

        private void BookingList1_PushBookingNumbers(string BookingNumbers)
        {
            int x = 0;
            string ShippingLines = "";
            ShippingLines = FetchShippingLines();
            var loopTo = Strings.Len(BookingNumbers);
            for (x = 1; x <= loopTo; x += 44)
            {
                if (PushExcelBooking(Strings.RTrim(Strings.Mid(BookingNumbers, x + 4, 40)), ShippingLines) == true)
                {
                    BookingList1.TaggedAsPushed(Strings.Mid(BookingNumbers, x, 4));
                }
            }

            BookingList1.RefreshBookingList();
        }

        public string FetchShippingLines()
        {
            string ShipLineCode;
            string ShipLineName;
            string FinalLine = "";
            var DbObjAdapter = new System.Data.SqlClient.SqlDataAdapter("Select Code, Name From Companies where Type = 'Steamship Line' Order by Name Asc", DBConnect);
            var DbObjCommand = new System.Data.SqlClient.SqlCommandBuilder(DbObjAdapter);
            var DbObjDataTable = new System.Data.DataTable();
            DbObjAdapter.Fill(DbObjDataTable);
            foreach (DataRow ContainerRow in DbObjDataTable.Rows)
            {
                ShipLineCode = Conversions.ToString(ContainerRow["Code"]).ToUpper();
                ShipLineName = MdlContainerManagement.DoFunctions.PadToString("(" + Strings.RTrim(ShipLineCode) + ") " + Strings.RTrim(Conversions.ToString(ContainerRow["Name"]).ToUpper()), (short)50);
                FinalLine += ShipLineCode + ShipLineName;
            }

            return FinalLine;
        }

        public bool PushExcelBooking(string BookingNumber, string SteamShipLines)
        {
            string ExcelFile = "";
            string LRDDate = "";
            string ERDDate = "";
            string VesselName = "";
            string VoyageNumber = "";
            short x = 0;
            string ShipLine = "";
            string ShipPort = "";
            string ContainerSize;
            string ContainerNumber = "";
            short NumOfContainers = 0;
            ExcelFile = @"\\server-one\Brian\WTC\Open\" + BookingNumber + ".xls";
            if (File.Exists(ExcelFile) == true)
            {
                try
                {
                    XLWorkbook = Excel.Workbooks.Open(ExcelFile, ReadOnly: true);
                    XLWorkbook.Application.DisplayAlerts = false;
                    Worksheet LoadPlansheet = XLWorkbook.Sheets[15];
                    var LoadPlanRange = LoadPlansheet.UsedRange;
                    object[,] LoadPlanArray = (object[,])LoadPlanRange.get_Value(XlRangeValueDataType.xlRangeValueDefault);
                    if (LoadPlanArray.GetUpperBound(0) >= 18 & LoadPlanArray.GetUpperBound(1) >= 13)
                    {
                        LRDDate = Conversions.ToString(LoadPlanArray[6, 13]);
                        ERDDate = Conversions.ToString(LoadPlanArray[9, 13]);
                        if (ERDDate == "12:00:00 AM")
                        {
                            ERDDate = "";
                        }

                        VesselName = Conversions.ToString(LoadPlanArray[15, 13]);
                        VoyageNumber = Conversions.ToString(LoadPlanArray[18, 13]);
                    }

                    Worksheet VGMsheet = (Worksheet)XLWorkbook.Sheets[(object)3];
                    var r = VGMsheet.UsedRange;
                    object[,] VGMArray = (object[,])r.get_Value(XlRangeValueDataType.xlRangeValueDefault);
                    if (VGMArray is object)
                    {
                        if (VGMArray.GetUpperBound(0) >= 22)
                        {
                            ShipLine = Conversions.ToString(VGMArray[13, 2]);
                            ShipPort = Conversions.ToString(VGMArray[17, 2]);
                            ContainerSize = Conversions.ToString(VGMArray[19, 4]);
                            NumOfContainers = (short)Conversions.ToInteger(VGMArray[19, 2]);
                            x = 1;
                            while (!string.IsNullOrEmpty(Strings.RTrim(Conversions.ToString(VGMArray[21 + x, 1]))))
                            {
                                ContainerNumber = Strings.RTrim(Conversions.ToString(VGMArray[21 + x, 1]));
                                UpdateDatabase(BookingNumber + ".XLS", GiveExcelShipLineCode(ShipLine), ShipPort, ContainerSize, LRDDate, ERDDate, VesselName, VoyageNumber, ContainerNumber, Conversions.ToString(VGMArray[21 + x, 2]), Conversions.ToString(VGMArray[21 + x, 3]), Conversions.ToString(VGMArray[21 + x, 4]), Conversions.ToString(VGMArray[21 + x, 5]), Conversions.ToString(VGMArray[21 + x, 6]), SteamShipLines);
                                x = (short)(x + 1);
                            }
                        }
                    }

                    XLWorkbook.Close(false);
                    return true;
                }
                catch (Exception ex)
                {
                    XLWorkbook.Close(false);
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Error:", ex.Message, this);
                    return false;
                }
            }

            return default;
        }

        public string GiveExcelShipLineCode(string SSLine)
        {
            if (SSLine == "APL")
            {
                return "APL";
            }
            else if (SSLine == "CCNI")
            {
                return "CCNI";
            }
            else if (SSLine == "CHINA SHIPPING")
            {
                return "CSCL";
            }
            else if (SSLine == "CMA CGM")
            {
                return "CMA";
            }
            else if (SSLine == "COSCO")
            {
                return "COSC";
            }
            else if (SSLine == "CSAV")
            {
                return "CSAV";
            }
            else if (SSLine == "EVERGREEN")
            {
                return "EVGR";
            }
            else if (SSLine == "HAMBURG SUD")
            {
                return "HBG";
            }
            else if (SSLine == "HANJIN")
            {
                return "HNJN";
            }
            else if (SSLine == "HAPAG LLOYD")
            {
                return "HAP";
            }
            else if (SSLine == "HYUNDAI")
            {
                return "HYND";
            }
            else if (SSLine == "K-Line")
            {
                return "KLIN";
            }
            else if (SSLine == "MAERSK")
            {
                return "MRSK";
            }
            else if (SSLine == "MOL")
            {
                return "MOL";
            }
            else if (SSLine == "MSC")
            {
                return "MSC";
            }
            else if (SSLine == "NYK")
            {
                return "NYK";
            }
            else if (SSLine == "ONE")
            {
                return "ONE";
            }
            else if (SSLine == "OOCL")
            {
                return "OOCL";
            }
            else if (SSLine == "PIL")
            {
                return "PIL";
            }
            else if (SSLine == "SETH")
            {
                return "SETH";
            }
            else if (SSLine == "SM LINE")
            {
                return "SML";
            }
            else if (SSLine == "SAFMARINE")
            {
                return "SAF";
            }
            else if (SSLine == "UASC")
            {
                return "UASC";
            }
            else if (SSLine == "US LINES")
            {
                return "USL";
            }
            else if (SSLine == "YANG MING")
            {
                return "YGMG";
            }
            else if (SSLine == "ZIM")
            {
                return "ZIM";
            }
            else
            {
                return SSLine;
            }
        }

        private void UpdateDatabase(string ExcelFileName, string ShipLine, string ShipPort, string ContainerSize, string LRDDate, string ERDDate, string VesselName, string VoyageNumber, string ContainerNumber, string SealNumber, string TareWgt, string NetWgt, string GrossWgt, string BookingNum, string AllSteamShipLines)
        {
            int RecordCount = 0;
            if (string.IsNullOrEmpty(ContainerNumber) | Strings.Len(ContainerNumber) != 11 | MdlContainerManagement.ValidateContainer(ContainerNumber) == false | !string.IsNullOrEmpty(SealNumber) & Strings.Len(SealNumber) != 7)
            {
                return;
            }
            else
            {
                bool HoldBooking = ShouldHoldBooking(Strings.UCase(BookingNum));

                // DBConnect = New SqlClient.SqlConnection("Server=tcp:WTC-Ceres.database.windows.net,1433;Initial Catalog=WTC-Ceres;Persist Security Info=False;User ID=CeresAdmin;Password=C3r3$@dm!n;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
                // DBConnect.Open()

                var DbObjAdapter = new System.Data.SqlClient.SqlDataAdapter("Select * From [Containers In-Out] Where [Container Number] = '" + ContainerNumber + "'", DBConnect);
                var DbObjCommand = new System.Data.SqlClient.SqlCommandBuilder(DbObjAdapter);
                var DbObjDataTable = new System.Data.DataTable();
                bool OutGated;
                string ThisCarrierID;
                string CarrierID;
                DbObjAdapter.Fill(DbObjDataTable);
                if (DbObjDataTable.Rows.Count == 0)
                {
                    var DBObj_NewRow = DbObjDataTable.NewRow();
                    DBObj_NewRow["Container Number"] = ContainerNumber;
                    DBObj_NewRow["Container Size"] = AssignContainerSize(ContainerSize);
                    DBObj_NewRow["Booking Number"] = BookingNum;
                    DBObj_NewRow["LRD"] = LRDDate;
                    DBObj_NewRow["ERD"] = ERDDate;
                    DBObj_NewRow["Seal Number"] = SealNumber;
                    DBObj_NewRow["SS Line Code Out"] = ShipLine;
                    DBObj_NewRow["SS Line Name Out"] = GiveShippingLineName(ShipLine, AllSteamShipLines);
                    DBObj_NewRow["Vessel Name"] = VesselName;
                    DBObj_NewRow["Voyage Number"] = VoyageNumber;
                    DBObj_NewRow["Terminal Code Out"] = GiveTerminalCode(ShipPort);
                    DBObj_NewRow["Terminal Name Out"] = ShipPort;
                    DBObj_NewRow["Cargo Weight Out"] = MdlContainerManagement.DoFunctions.MKS((float)Conversion.Val(NetWgt));
                    DBObj_NewRow["Tare Weight Out"] = MdlContainerManagement.DoFunctions.MKS((float)Conversion.Val(TareWgt));
                    DBObj_NewRow["Gross Weight Out"] = MdlContainerManagement.DoFunctions.MKS((float)Conversion.Val(GrossWgt));
                    DBObj_NewRow["Excel Filename Out"] = ExcelFileName;
                    DBObj_NewRow["Container Out-Gated"] = false;
                    DBObj_NewRow["Hold Out-Gate"] = HoldBooking;
                    DbObjDataTable.Rows.Add(DBObj_NewRow);
                    DbObjAdapter.Update(DbObjDataTable);
                }
                else
                {
                    RecordCount = DbObjDataTable.Rows.Count - 1;
                    if (Information.IsDBNull(DbObjDataTable.Rows[RecordCount]["Container Out-Gated"]) == true)
                    {
                        OutGated = false;
                    }
                    else
                    {
                        OutGated = Conversions.ToBoolean(DbObjDataTable.Rows[RecordCount]["Container Out-Gated"]);
                    }

                    DbObjDataTable.Rows[RecordCount]["Booking Number"] = BookingNum;
                    DbObjDataTable.Rows[RecordCount]["LRD"] = LRDDate;
                    DbObjDataTable.Rows[RecordCount]["ERD"] = ERDDate;
                    DbObjDataTable.Rows[RecordCount]["Seal Number"] = SealNumber;
                    DbObjDataTable.Rows[RecordCount]["SS Line Code Out"] = ShipLine;
                    DbObjDataTable.Rows[RecordCount]["SS Line Name Out"] = GiveShippingLineName(ShipLine, AllSteamShipLines);
                    DbObjDataTable.Rows[RecordCount]["Vessel Name"] = VesselName;
                    DbObjDataTable.Rows[RecordCount]["Voyage Number"] = VoyageNumber;
                    DbObjDataTable.Rows[RecordCount]["Terminal Code Out"] = GiveTerminalCode(ShipPort);
                    DbObjDataTable.Rows[RecordCount]["Terminal Name Out"] = ShipPort;
                    DbObjDataTable.Rows[RecordCount]["Cargo Weight Out"] = MdlContainerManagement.DoFunctions.MKS((float)Conversion.Val(NetWgt));
                    DbObjDataTable.Rows[RecordCount]["Tare Weight Out"] = MdlContainerManagement.DoFunctions.MKS((float)Conversion.Val(TareWgt));
                    DbObjDataTable.Rows[RecordCount]["Gross Weight Out"] = MdlContainerManagement.DoFunctions.MKS((float)Conversion.Val(GrossWgt));
                    DbObjDataTable.Rows[RecordCount]["Excel Filename Out"] = ExcelFileName;
                    DbObjDataTable.Rows[RecordCount]["Hold Out-Gate"] = HoldBooking;
                    DbObjAdapter.Update(DbObjDataTable);
                }

                DBConnect.Close();
            }
        }

        public string GiveTerminalCode(string TerminalCode)
        {
            if (TerminalCode == "AHEER")
            {
                return "AHEER";
            }
            else if (TerminalCode == "CENTERM")
            {
                return "CT";
            }
            else if (TerminalCode == "COAST")
            {
                return "COAST";
            }
            else if (TerminalCode == "COLUMBIA CONTAINERS")
            {
                return "CCL";
            }
            else if (TerminalCode == "CN")
            {
                return "CN";
            }
            else if (TerminalCode == "CP")
            {
                return "CP";
            }
            else if (TerminalCode == "DELCO")
            {
                return "DELCO";
            }
            else if (TerminalCode == "DELTAPORT")
            {
                return "DP";
            }
            else if (TerminalCode == "EUROASIA")
            {
                return "EURO";
            }
            else if (TerminalCode == "FRASER/SURREY")
            {
                return "FSD";
            }
            else if (TerminalCode == "FRASER SURREY DOCKS")
            {
                return "FSD";
            }
            else if (TerminalCode == "HARBOUR LINK")
            {
                return "HARBOUR";
            }
            else if (TerminalCode == "MARCO")
            {
                return "MARCO";
            }
            else if (TerminalCode == "MISC")
            {
                return "MISC";
            }
            else if (TerminalCode == "PACIFIC GATEWAY")
            {
                return "PACIFIC";
            }
            else if (TerminalCode == "RAYMONT")
            {
                return "RMT";
            }
            else if (TerminalCode == "TDK")
            {
                return "TDK";
            }
            else if (TerminalCode == "VANTERM")
            {
                return "VT";
            }
            else
            {
                return TerminalCode;
            }
        }

        public bool ShouldHoldBooking(string BookingNum)
        {
            int x;
            if (Strings.Len(BookingNum) >= 4)
            {
                var loopTo = Strings.Len(BookingNum);
                for (x = 1; x <= loopTo; x++)
                {
                    if (Strings.Mid(BookingNum, x, 4) == "HOLD")
                    {
                        return true;
                    }
                }

                return false;
            }
            else
            {
                return false;
            }
        }

        public string AssignContainerSize(object ContainerSize)
        {
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(ContainerSize, "20' (8'6'')", false)))
            {
                return Conversions.ToString('\0');
            }
            else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(ContainerSize, "40' (8'6'')", false)))
            {
                return Conversions.ToString('\u0001');
            }
            else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(ContainerSize, "40' HC (9'6'')", false)))
            {
                return Conversions.ToString('\u0001');
            }
            else
            {
                return Conversions.ToString('\n');
            }
        }

        private string GiveShippingLineName(string ShipLineCode, string AllShippingLines)
        {
            short x;
            var loopTo = (short)Strings.Len(AllShippingLines);
            for (x = 1; x <= loopTo; x += 60)
            {
                if ((ShipLineCode ?? "") == (Strings.RTrim(Strings.Mid(AllShippingLines, x, 10)) ?? ""))
                {
                    return Strings.RTrim(Strings.Mid(AllShippingLines, x + 10, 50));
                }
            }

            return "";
        }
    }
}