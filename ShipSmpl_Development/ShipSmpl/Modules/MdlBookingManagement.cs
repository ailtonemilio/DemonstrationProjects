using BusinessLayer.WTC_Ceres;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ShipSmpl
{
    static class MdlBookingManagement
    {
        private static CeresExcelPendingSyncService CeresExcService = new CeresExcelPendingSyncService();
        private static string StrConnWTCCeres = DatabaseHelperCeres.StrConnWTCCeres;
        private static MinibookingMiniUnitAssignmentService mbmuAsnService = new MinibookingMiniUnitAssignmentService();
        private static MinibookingCommodityService mbcService = new MinibookingCommodityService();

        // Dim focusedOpenPath As String = "C:\Users\Vania Oliveira\Desktop\Booking"
        private static string focusedOpenPath = @"\\server-one\Brian\WTC\Open";
        private static string focusedCompletedPath = @"\\server-one\Brian\WTC\";

        public struct MiniBookStruct
        {
            public short NumberOfCans;
            public string ContainerSize;
            public int MiniBookingOrder;
            public string SSLineCode;
            public string AmountRequested;
            public string SpecialMax;
            public string BagWeight;
            public string BagWeightUnit;
            public string LotNumber;
            public string BagProvider;
            public string BagTagging;
            public string BagType;
            public string GradeBy;
            public string PhytosanitaryBy;
            public string InspectionBy;
            public string FumigationBy;
            public string Other;
            public string TerminalEffcyFee;
            public string SpecialInstrux;
            public string SpecialInstruxNotes;
        }

        public struct CustomerInfo
        {
            public string Address1;
            public string Address2;
            public string Address3;
            public string Phone;
            public string Fax;
            public string Attention;
            public bool PCR;
        }

        public struct Transload
        {
            public short UnitNumber;
            public string ContainerNumber;
            public string SealNumber;
            public float Amount;
            public DateTime PackDate;
            public string PackedBy;
            public string UnitSource;
            public string CommodityCode;
            public string CommodityName;
            public string GradeCode;
            public string GradeName;
            public string LotNumber;
            public float BagWeight;
            public string WeightUnit;
            public float WeightMT;
            public string Comments;
        }

        public struct SplitedCanInfo
        {
            public int ContainerId;
            public string ContainerNumber;
            public string MinibookingNumber;
            public string MinibookingTempId;
        }

        public static List<SplitedCanInfo> SplitedCansList = new List<SplitedCanInfo>();
        public static Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
        public static Workbook XLWorkbook;
        private static DatabaseHelperCeres db = new DatabaseHelperCeres();

        public static void AssignSplitCansToExcel(List<VW_ContainersByBooking> containerList, string miniBookingNumber, Workbook XLWorkbook)
        {
            short YSt = 8;
            string HSState;
            string canTARE = "";
            string pickUpDate = "";
            try
            {
                string ThisXLSFile = "";
                ThisXLSFile = focusedOpenPath + @"\" + Strings.Trim(miniBookingNumber) + ".xls";
                Worksheet ContainerSheet = (Worksheet)XLWorkbook.Sheets[(object)2];
                foreach (var can in containerList)
                {
                    YSt = (short)findExcelLine(ContainerSheet, "");
                    canTARE = Conversions.ToString(can.TareWeightIn);
                    pickUpDate = Conversions.ToString(can.Gate_Date_In);
                    HSState = getCanStressLevel((decimal)can.GrossWeightIn, can.ContainerSize);
                    ContainerSheet.Cells[(object)YSt, (object)13] = Strings.Trim(can.Container_Number);
                    ContainerSheet.Cells[(object)YSt, (object)14] = HSState;
                    ContainerSheet.Cells[(object)YSt, (object)15] = canTARE;
                    ContainerSheet.Cells[(object)YSt, (object)16] = pickUpDate;
                    ContainerSheet.Cells[(object)YSt, (object)21] = Strings.Trim(can.Carrier_Code_In);
                    if ((can.Hold_Out_Gate == false | Information.IsNothing(can.Hold_Out_Gate)) == true)
                    {
                        ContainerSheet.Cells[(object)YSt, (object)19] = miniBookingNumber;
                    }
                    else
                    {
                        ContainerSheet.Cells[(object)YSt, (object)19] = miniBookingNumber + "-HOLD";
                    }

                    YSt = (short)(YSt + 1);
                    // End If

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occured. Please close this tab and try again. Error: " + ex.Message);
            }
        }

        public static string getCanStressLevel(decimal canGrossWeight, string canSize)
        {
            switch (canSize ?? "")
            {
                case "20 FT":
                    {
                        if ((double)canGrossWeight >= 30.48d)
                        {
                            return "H";
                        }
                        else
                        {
                            return "S";
                        }

                        break;
                    }

                default:
                    {
                        return "S";
                    }
            }
        }

        // Public Sub RemoveSplitCansFromExcel(ByVal containerList As List(Of VW_ContainersByBooking), bookingNumber As String, minibookingId As Integer, numbOfCansInBk As Integer)
        // Dim rowID As Integer = 0, YSt As Int16 = 8, canTARE As String = "", pickUpDate As String = "", DeliverBookCell As String = "", contNumber As String

        // Dim ThisXLSFile = focusedOpenPath + "\" + Trim(bookingNumber) + ".xls"

        // If File.Exists(ThisXLSFile) Then

        // If IsExcelFileOpened(ThisXLSFile) = False Then
        // XLWorkbook = Excel.Workbooks.Open(ThisXLSFile, ReadOnly:=False)

        // XLWorkbook.Application.DisplayAlerts = False

        // Dim ContainerSheet As Worksheet = XLWorkbook.Sheets(2)

        // Try

        // '    unassignFromExcel(ContainerSheet, numbOfCansInBk)
        // Dim SetupSheet As Worksheet = XLWorkbook.Sheets(1)
        // SetupSheet.Range("I6").Value = (SetupSheet.Range("I6").Value - containerList.Count)

        // Dim allContainersInBooking As List(Of VW_ContainersByBooking) = Containers_In_OutService.GetContainersByMiniBookingId(minibookingId)
        // AssignContainersToExcel(ContainerSheet, allContainersInBooking)

        // XLWorkbook.Application.DisplayAlerts = True
        // XLWorkbook.Save()
        // XLWorkbook.Close()
        // Catch ex As Exception
        // XLWorkbook.Close()
        // End Try

        // End If
        // End If

        // End Sub

        public static int findExcelLine(Worksheet ContainerSheet, string valueToFind)
        {
            int line = 8;
            object dlvdBK;
            for (int i = line; i <= 52; i++)
            {
                dlvdBK = ContainerSheet.Cells[(object)i, (object)13].value;
                if (valueToFind.Equals(""))
                {
                    if (string.IsNullOrEmpty(Conversions.ToString(dlvdBK)))
                    {
                        return i;
                    }
                }
                else if (!Information.IsNothing(dlvdBK) && Strings.Trim(Conversions.ToString(dlvdBK)).Equals(Strings.Trim(valueToFind)))
                {
                    return i;
                }
            }

            return default;
        }

        // Public Function moveExcelBooking(ByVal reason As String, bookingNumber As String)

        // Dim fileDeleted As Boolean = True
        // Try

        // Dim dirList = Directory.GetDirectories(focusedCompletedPath)
        // Dim dirClosedPath As String = dirList(dirList.Length - 2)
        // If File.Exists(Path.Combine(focusedOpenPath, bookingNumber + ".xls")) = True Then
        // Select Case reason
        // Case "COMPLETED"
        // My.Computer.FileSystem.MoveFile(focusedOpenPath + "\" + bookingNumber + ".xls",
        // dirClosedPath + "\" + bookingNumber + ".xls")
        // Case Else
        // '      deleteCSVFile(focusedOpenPath, bookingNumber)
        // End Select
        // Else
        // fileDeleted = False
        // MessageBoxCeresOK.ShowDialog("Excel file not found.", bookingNumber + ".xls was not found at " +
        // focusedOpenPath + ", so it could not be moved to " + dirClosedPath, FrmBookingList)
        // End If
        // Catch
        // fileDeleted = False
        // End Try
        // Return fileDeleted
        // End Function

        public static string digitToLetter(object num)
        {
            try
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectGreater(num, 0, false)) && Conversions.ToBoolean(Operators.ConditionalCompareObjectLess(num, 27, false)))
                {
                    char c;
                    c = Convert.ToChar(Operators.AddObject(num, 64));
                    return Conversions.ToString(c);
                }
                else
                {
                    return "";
                }
            }
            catch
            {
                return "";
            }
        }

        public static int letterToDigit(string letter)
        {
            try
            {
                return Convert.ToInt32(Convert.ToChar(letter)) - 64;
            }
            catch
            {
                return 0;
            }
        }

        // Check if mini Unit was assigned
        public static bool miniUnitAlreadyAssigned(int muORStorageId, int mbID, bool isUnitFromStorage)
        {
            return mbmuAsnService.MiniUnitAlreadyAssigned(muORStorageId, mbID, isUnitFromStorage);
        }

        public static bool miniUnitMissingCommodity(int mbID, int comdtyId, int gradeId)
        {
            bool miniUnitMissingCmdyGrade;
            var list = MinibookingCommodityService.GetMinibookingCommodityByMbId(mbID);
            miniUnitMissingCmdyGrade = list.Where(mbc => mbc.CommodityId == comdtyId & mbc.GradeId == gradeId).ToList().Count == 0;
            return miniUnitMissingCmdyGrade;
        }

        public static void saveBkgCommodity(int MinibookingId, int CommodityId, int GradeId)
        {
            var mbCmdty = new MiniBookingCommodity();
            mbCmdty.MiniBookingId = MinibookingId;
            mbCmdty.CommodityId = CommodityId;
            mbCmdty.GradeId = GradeId;
            mbcService.AddOrUpdate(mbCmdty);
        }

        public static string getCommodities(int mbID)
        {
            string commodities = "";
            var mbCommodityList = MinibookingCommodityService.GetMinibookingCommodityByMbId(mbID);
            foreach (var cmdty in mbCommodityList)
                commodities += cmdty.GradeCode + " " + cmdty.CommodityCode + " | ";
            if (mbCommodityList.Count == 0)
            {
                commodities = "";
            }

            return commodities;
        }

        public static bool isAssignedToOthersMBs(int muID)
        {
            bool isAsnToOtherMbs;
            var unitSourcesDT = new System.Data.DataTable();
            string condition;
            string query;
            var muList = MinibookingMiniUnitAssignmentService.GetByMiniUnitId(muID).Where(mu => mu.isStorageUnit == false).ToList();
            isAsnToOtherMbs = muList.Count > 0;
            if (isAsnToOtherMbs == true)
            {
                var muRow = muList[0];
                if (Information.IsNothing(muRow.RailListId))
                {
                    My.MyProject.Forms.MessageBoxCustomerMatchingWarning.recordKey = 0;
                }
                else
                {
                    My.MyProject.Forms.MessageBoxCustomerMatchingWarning.recordKey = muRow.RailListId;
                }

                if (Information.IsNothing(muRow.UnitSourceId))
                {
                    My.MyProject.Forms.MessageBoxCustomerMatchingWarning.unitSourceID = 0;
                }
                else
                {
                    My.MyProject.Forms.MessageBoxCustomerMatchingWarning.unitSourceID = muRow.UnitSourceId;
                }
            }
            else
            {
                My.MyProject.Forms.MessageBoxCustomerMatchingWarning.recordKey = 0;
            }

            return isAsnToOtherMbs;
        }

        public static void updateCustomer(MiniUnit muID)
        {
            // db.updateMUCustomer(muID, custId)
            var muService = new MiniUnitService();
            muService.InsertOrUpdate(muID);
        }

        public static bool miniBookingMissingCommodity(int muID, int cmdtyId, int gradeId)
        {
            bool miniUnitMissingCmdyGrade;
            string condition;
            condition = "where MiniUnitId = " + muID.ToString() + " and (CommodityId = '" + cmdtyId.ToString() + "' and GradeId = '" + gradeId.ToString() + "')";
            miniUnitMissingCmdyGrade = db.getTableInfo("MiniUnit", "*", condition).Rows.Count == 0;
            return miniUnitMissingCmdyGrade;
        }

        // Public Sub saveExcelBooking(ByVal OldBkNumber As String, UpdatedBkNumber As VW_Booking)
        // Dim x As Int16 = 0, CreateCnt As Int16 = 0, MiniBooks As Int16 = 0, BookingNumber As String = "", ExcelFile As String = "",
        // NewExcelFile As String = "", BookRow As DataRow, MiniBookArray() As MiniBookStruct, ModExcelFile As String = "", OLDFileBooking As String

        // OldBkNumber = OldBkNumber.Replace(vbTab, "")
        // OLDFileBooking = OldBkNumber.Replace(vbTab, "")

        // Dim DbObjDataTable As New System.Data.DataTable
        // Dim DbObjAdapter = New System.Data.SqlClient.SqlDataAdapter("Select * From [VW_Booking] Where BookingId  = '" + UpdatedBkNumber.BookingId.ToString + "'", StrConnWTCCeres)
        // Dim DbObjCommand = New System.Data.SqlClient.SqlCommandBuilder(DbObjAdapter)

        // DbObjAdapter.Fill(DbObjDataTable)

        // For Each BookRow In DbObjDataTable.Rows
        // MiniBooks = FetchMiniBookings(RTrim(BookRow("BookingId")), MiniBookArray)

        // For x = 0 To MiniBooks

        // 'Try
        // If MiniBooks = 0 Then
        // BookingNumber = RTrim(BookRow("BookingNumber"))
        // '     BookingNumber = BookingNumber.Replace(vbTab, "")
        // OldBkNumber = OLDFileBooking
        // '    OldBkNumber = OLDFileBooking.Replace(vbTab, "")
        // Else

        // BookingNumber = RTrim(BookRow("BookingNumber")) + "(" + digitToLetter(MiniBookArray(x).MiniBookingOrder) + ")"
        // '    BookingNumber = BookingNumber.Replace(vbTab, "")
        // OldBkNumber = OLDFileBooking + "(" + digitToLetter(MiniBookArray(x).MiniBookingOrder) + ")"
        // '     OldBkNumber = OLDFileBooking.Replace(vbTab, "")
        // End If
        // 'BookingNumber = UpdatedBkNumber

        // ExcelFile = BookingNumber + ".xls"
        // CreateCnt += 1

        // ' To rename booking
        // If (File.Exists(Path.Combine(focusedOpenPath, OldBkNumber + ".xls")) = True And FrmBookingList.formMode.Equals("Edit")) And Not OldBkNumber.Equals(BookingNumber) Then
        // Try
        // My.Computer.FileSystem.RenameFile(focusedOpenPath + "\" + OldBkNumber + ".xls", ExcelFile)
        // Catch ex As Exception
        // waitForm.Close()
        // MessageBoxCeresOK.ShowDialog("Error renaming file:", ex.Message, FrmEditAddBooking)
        // Exit Sub
        // End Try

        // End If

        // If File.Exists(Path.Combine(focusedOpenPath, ExcelFile)) = False Then
        // XLWorkbook = Excel.Workbooks.Open(focusedOpenPath + "\00B 1BKG MASTER-CERES.xls", ReadOnly:=False)

        // NewExcelFile = focusedOpenPath + "\" + ExcelFile
        // Else
        // XLWorkbook = Excel.Workbooks.Open(focusedOpenPath + "\" + ExcelFile, ReadOnly:=False)

        // ModExcelFile = focusedOpenPath + "\" + ExcelFile
        // End If

        // Dim BookSetupSheet As Worksheet = XLWorkbook.Sheets(1)

        // If Not IsDBNull(BookRow("CustomerId")) Then
        // Dim ThisCustomer As CustomerInfo = FetchCustomerInfo(BookRow("CustomerId"))
        // XLWorkbook.Application.DisplayAlerts = False
        // Dim companie As VW_CompanyCompanyType = CompanyService.GetById(BookRow("CustomerId"))

        // BookSetupSheet.Range("A2").Value = Trim(companie.CompanyName)
        // BookSetupSheet.Range("A3").Value = ThisCustomer.Address1
        // BookSetupSheet.Range("A4").Value = ThisCustomer.Address2
        // BookSetupSheet.Range("A5").Value = ThisCustomer.Address3
        // BookSetupSheet.Range("A6").Value = ThisCustomer.Phone
        // BookSetupSheet.Range("A7").Value = ThisCustomer.Fax
        // BookSetupSheet.Range("A8").Value = ThisCustomer.Attention

        // BookSetupSheet.Unprotect()
        // BookSetupSheet.Range("A9").Value = companie.RateCode
        // Dim BkCreatedDate As DateTime, newRateDate As DateTime = New DateTime(2020, 10, 1)

        // If Not IsDBNull(BookRow("CreatedAt")) Then
        // BkCreatedDate = BookRow("CreatedAt")
        // Else
        // BkCreatedDate = Nothing
        // End If

        // ''Code to set up customer rates
        // If Not IsNothing(companie.RateCode) AndAlso (Not IsNothing(BkCreatedDate) AndAlso BkCreatedDate.Date >= newRateDate.Date) Then

        // Dim RateSheetName(2) As String, CurrentRate As String = "", WorkSheetNames() As String, SheetIndex As Int16 = 0
        // RateSheetName(0) = "Additional"
        // RateSheetName(1) = "DMG"
        // RateSheetName(2) = "INVOICE"

        // Call GetWorkSheetNames(XLWorkbook, WorkSheetNames)

        // For i = 0 To 2

        // If MatchRateSheet(RateSheetName(i), WorkSheetNames, SheetIndex) = True Then
        // Dim ThisSheet As Worksheet = XLWorkbook.Sheets(SheetIndex)
        // If i = 0 Then
        // CurrentRate = StripForRate(ThisSheet.Range("D15").Formula)
        // End If

        // Call UpdateThisSheet(CurrentRate, companie.RateCode, ThisSheet)

        // If i = 2 Then
        // If companie.RateCode.Equals("WTC") Then
        // ThisSheet.Range("B47").Value = "WTC FORWARDING PACKAGE"
        // Else
        // ThisSheet.Range("B47").Value = ""
        // End If
        // End If

        // End If
        // Next i
        // End If
        // End If
        // Try
        // If Not IsDBNull(BookRow("CreatedAt")) Then
        // BookSetupSheet.Range("B11").Value = BookRow("CreatedAt")
        // End If
        // If FrmBookingList.formMode.Equals("Edit") Then
        // BookSetupSheet.Range("B12").Value = Now
        // End If
        // Catch
        // End Try

        // BookSetupSheet.Range("I2").Value = BookRow("ServiceCode")
        // BookSetupSheet.Range("I3").Value = BookingNumber
        // BookSetupSheet.Range("I4").Value = DateValue(BookRow("LRD"))
        // BookSetupSheet.Range("I6").Value = MiniBookArray(x).NumberOfCans ' BookRow("Number Of Cans")

        // If BookRow("AllowSplitBooking") = True Then
        // BookSetupSheet.Range("I18").Value = "N/A"
        // Else
        // BookSetupSheet.Range("I18").Value = "DO NOT SPLIT"
        // End If

        // If MiniBookArray(x).ContainerSize.Equals("20 FT") Then
        // BookSetupSheet.Range("I13").Value = "20' (8'6'')"
        // ElseIf MiniBookArray(x).ContainerSize.Equals("40 FT") Then
        // BookSetupSheet.Range("I13").Value = "40' (8'6'')"
        // ElseIf MiniBookArray(x).ContainerSize.Equals("40 FT HC") Then
        // BookSetupSheet.Range("I13").Value = "40' HC (9'6'')"
        // Else
        // BookSetupSheet.Range("I13").Value = ""
        // End If

        // BookSetupSheet.Range("K2").Value = RTrim(BookRow("CustomerReference"))
        // BookSetupSheet.Range("K3").Value = RTrim(BookRow("ForwarderName"))
        // BookSetupSheet.Range("K4").Value = RTrim(BookRow("ForwarderReference"))

        // BookSetupSheet.Range("K6").Value = RTrim(BookRow("SSLineCode"))
        // BookSetupSheet.Range("K7").Value = RTrim(BookRow("VesselName"))
        // BookSetupSheet.Range("K8").Value = RTrim(BookRow("VoyageNumber"))
        // If BookRow.IsNull("SailingDate") = False Then
        // BookSetupSheet.Range("K9").Value = BookRow("SailingDate")
        // End If
        // BookSetupSheet.Application.DisplayAlerts = False
        // If BookRow.IsNull("TerminalName") = False Then

        // BookSetupSheet.Range("K10").Value = RTrim(BookRow("TerminalName"))

        // End If
        // If Not IsDBNull(BookRow("DestAddrStr")) Then
        // BookSetupSheet.Range("K11").Value = BookRow("DestAddrStr")
        // Else
        // BookSetupSheet.Range("K11").Value = ""
        // End If
        // BookSetupSheet.Range("K15").Value = MiniBookArray(x).AmountRequested
        // BookSetupSheet.Range("K16").Value = MiniBookArray(x).SpecialMax
        // BookSetupSheet.Range("K17").Value = MiniBookArray(x).BagWeight
        // BookSetupSheet.Range("K18").Value = MiniBookArray(x).BagWeightUnit
        // BookSetupSheet.Range("K19").Value = MiniBookArray(x).LotNumber

        // BookSetupSheet.Range("M2").Value = MiniBookArray(x).BagProvider
        // BookSetupSheet.Range("M3").Value = MiniBookArray(x).BagTagging
        // BookSetupSheet.Range("M4").Value = MiniBookArray(x).BagType

        // BookSetupSheet.Range("M6").Value = MiniBookArray(x).GradeBy
        // BookSetupSheet.Range("M7").Value = MiniBookArray(x).PhytosanitaryBy
        // BookSetupSheet.Range("M8").Value = MiniBookArray(x).InspectionBy
        // BookSetupSheet.Range("M9").Value = MiniBookArray(x).FumigationBy
        // BookSetupSheet.Range("M10").Value = MiniBookArray(x).SpecialInstrux ' MiniBookArray(x).Other
        // BookSetupSheet.Range("M11").Value = MiniBookArray(x).TerminalEffcyFee

        // BookSetupSheet.Range("M13").Value = MiniBookArray(x).SpecialInstruxNotes ' MiniBookArray(x).SpecialInstrux
        // 'BookSetupSheet.Range("M14").Value = MiniBookArray(x).SpecialInstruxNotes

        // If FrmBookingList.formMode.Equals("Split") Then
        // AssignSplitBookingCans(XLWorkbook, FrmEditAddBooking.oldBkNumb, UpdatedBkNumber, BookingNumber)

        // End If
        // BookSetupSheet.Application.DisplayAlerts = True
        // BookSetupSheet.Protect()
        // XLWorkbook.Application.DisplayAlerts = True

        // If Not NewExcelFile.Equals("") Then
        // XLWorkbook.SaveAs(NewExcelFile)
        // Else
        // XLWorkbook.Save()

        // End If

        // XLWorkbook.Close(False)

        // Next x

        // Next
        // End Sub

        // Private Sub UpdateThisSheet(CurrentRate As String, RateType As String, CurrentWorkSheet As Worksheet)

        // CurrentWorkSheet.Unprotect()
        // CurrentWorkSheet.Cells.Replace(What:=CurrentRate, Replacement:="[00C TRL RATES.xls]" + RateType, LookAt:=2, SearchOrder:=1, MatchCase:=False, SearchFormat:=False, ReplaceFormat:=False)
        // CurrentWorkSheet.Protect(DrawingObjects:=True, Contents:=True, Scenarios:=True)

        // End Sub

        // Private Sub GetWorkSheetNames(XLWorkbook As Workbook, ByRef WorkSheetNames() As String)
        // Dim TotalSheets As Int16 = 0, SheetCount As Int16 = 0, Sheet As Worksheet

        // TotalSheets = XLWorkbook.Worksheets.Count
        // ReDim WorkSheetNames(TotalSheets - 1)

        // For Each Sheet In XLWorkbook.Worksheets
        // WorkSheetNames(SheetCount) = Sheet.Name
        // SheetCount += 1
        // Next
        // End Sub

        // Private Function StripForRate(RateRefrence As String) As String
        // Dim x As Int16 = 0, RateChar As Char = Chr(0), StartPad As Boolean = False, CloseBracket As Boolean = False, TempLine As String = ""

        // For x = 1 To Len(RateRefrence)
        // RateChar = Mid(RateRefrence, x, 1)
        // If RateChar = "[" Then
        // StartPad = True
        // ElseIf RateChar = "]" Then
        // CloseBracket = True
        // End If

        // If StartPad = True And CloseBracket = False Then
        // TempLine += Mid(RateRefrence, x, 1)
        // ElseIf StartPad = True And CloseBracket = True Then
        // If RateChar = Chr(32) Then
        // Return TempLine
        // Else
        // TempLine += Mid(RateRefrence, x, 1)
        // End If
        // End If
        // Next x

        // Return ""
        // End Function

        // Private Function MatchRateSheet(ThisSheet As String, WorkSheetNames() As String, ByRef SheetIndex As Int16) As Boolean
        // Dim x As Int16 = 0
        // For x = 0 To WorkSheetNames.Length - 1
        // If ThisSheet = WorkSheetNames(x) Then
        // SheetIndex = x + 1
        // Return True
        // End If
        // Next x

        // Return False
        // End Function

        // Public Sub RemoveSplitBookingCans(ByVal BookingId As Integer, newBookingNumber As String)
        // Dim cansToBeTransferredIdList As New List(Of Integer), cansToBeTransByMb As New List(Of Integer), oldBkNumb As String
        // For Each can In SplitedCansList
        // cansToBeTransferredIdList.Add(can.ContainerId)
        // Next
        // Dim mbService As New MinibookingService, newTotalMbCans As Integer, newTotalBkCans As Integer = 0
        // Dim canMbList As List(Of VW_ContainersByBooking) = Containers_In_OutService.GetByIds(cansToBeTransferredIdList)
        // Dim mbList As List(Of VW_BookingMinibooking) = MinibookingService.GetJointBookingByBookingId(BookingId)
        // Dim canByMB As List(Of VW_ContainersByBooking)

        // oldBkNumb = canMbList(0).BookingNumber
        // 'clear excel

        // '' Remove selected cans from all mb files
        // For Each mb In mbList

        // 'Get all containers asn to old mb
        // canByMB = canMbList.Where(Function(c) c.MiniBookingId = mb.MiniBookingId).ToList
        // 'Remove containers from old mb file
        // RemoveSplitCansFromExcel(canByMB, mb.BookingNumber, mb.MiniBookingId, mb.NumberOfContainer)

        // ' Update total in minibooking
        // newTotalMbCans = (mb.NumberOfContainer - canByMB.Count)
        // mbService.UpdateMBCansNumb(mb.MiniBookingId, newTotalMbCans)

        // newTotalBkCans += newTotalMbCans
        // Next
        // ' Update total in booking
        // mbService.UpdateBKCansNumb(oldBkNumb, newTotalBkCans)
        // End Sub

        // Public Sub AssignContainersToExcel(ByVal ContainerSheet As Worksheet, containerList As List(Of VW_ContainersByBooking))
        // Dim rowID As Integer = 0, YSt As Int16 = 8
        // ContainerSheet.Unprotect()
        // For Each contNumb In containerList

        // ContainerSheet.Cells(YSt, 13) = Trim(contNumb.Container_Number)
        // ContainerSheet.Cells(YSt, 14) = getCanStressLevel(contNumb.GrossWeightIn, contNumb.ContainerSize)
        // ContainerSheet.Cells(YSt, 15) = contNumb.TareWeightIn
        // ContainerSheet.Cells(YSt, 16) = contNumb.Gate_Date_In

        // If Not IsDBNull(contNumb.Gate_Date_Out) Then
        // ContainerSheet.Cells(YSt, 20) = contNumb.Gate_Date_Out
        // Else
        // Dim gateOut As Excel.Range = ContainerSheet.Cells(YSt, 20)
        // gateOut.Select()
        // gateOut.ClearContents()

        // End If

        // If Not IsDBNull(contNumb.Carrier_Code_In) Then

        // ContainerSheet.Cells(YSt, 21) = Trim(contNumb.Carrier_Code_In)
        // Else
        // Dim carrierIn As Excel.Range = ContainerSheet.Cells(YSt, 21)
        // carrierIn.Select()
        // carrierIn.ClearContents()
        // End If

        // If Not IsDBNull(contNumb.Carrier_Code_Out) Then

        // ContainerSheet.Cells(YSt, 22) = Trim(contNumb.Carrier_Code_Out)
        // Else
        // Dim carrierIn As Excel.Range = ContainerSheet.Cells(YSt, 22)
        // carrierIn.Select()
        // carrierIn.ClearContents()
        // End If

        // If Not IsDBNull(contNumb.Hold_Out_Gate) AndAlso contNumb.Hold_Out_Gate = False Then

        // ContainerSheet.Cells(YSt, 19) = Trim(contNumb.MinibookingNumber)
        // ElseIf contNumb.Hold_Out_Gate = True Then
        // ContainerSheet.Cells(YSt, 19) = Trim(contNumb.MinibookingNumber) + "-HOLD"

        // End If
        // YSt += 1

        // Next
        // ContainerSheet.Protect()
        // End Sub

        // Public Sub AssignSplitBookingCans(ByVal XLWorkbook As Workbook, oldBkNumb As String, newBkNumb As VW_Booking, currentBk As String)

        // Dim BkgJoinMbList As List(Of VW_BookingMinibooking) = MinibookingService.GetJointBookingByBookingId(newBkNumb.BookingId)

        // Dim cansToBeTransferredToNewMb As New List(Of Integer)
        // ' Assign containers to new booking
        // For Each mb In BkgJoinMbList
        // cansToBeTransferredToNewMb.Clear()

        // For Each can In SplitedCansList
        // If can.MinibookingNumber.Equals(mb.BookingNumber) Then
        // 'reassign can
        // cansToBeTransferredToNewMb.Add(can.ContainerId)
        // End If
        // Next

        // If cansToBeTransferredToNewMb.Count > 0 And currentBk.Equals(mb.BookingNumber) Then
        // Dim canByMB = Containers_In_OutService.GetByIds(cansToBeTransferredToNewMb)
        // db.saveContrSplitReassignment(cansToBeTransferredToNewMb, mb.MiniBookingId, Trim(mb.BookingNumber))
        // AssignSplitCansToExcel(canByMB, mb.BookingNumber, XLWorkbook)

        // End If
        // Next

        // End Sub

        // Public Function FetchMiniBookings(BookingId As Integer, ByRef MiniBookArray() As MiniBookStruct) As Int16
        // Dim TotalMiniBooks As Int16 = 0, MiniCnt As Int16 = 0, MiniBook As DataRow

        // Dim DbObjDataTable As New System.Data.DataTable
        // Dim DbObjAdapter = New System.Data.SqlClient.SqlDataAdapter("Select * From [VW_BookingMiniBooking] Where [BookingId]  = '" & BookingId.ToString & "' Order By [MiniBookingOrder]", StrConnWTCCeres)
        // Dim DbObjCommand = New System.Data.SqlClient.SqlCommandBuilder(DbObjAdapter)

        // DbObjAdapter.Fill(DbObjDataTable)

        // If DbObjDataTable.Rows.Count <> 0 Then
        // TotalMiniBooks = DbObjDataTable.Rows.Count - 1
        // ReDim MiniBookArray(TotalMiniBooks)

        // For Each MiniBook In DbObjDataTable.Rows
        // With MiniBookArray(MiniCnt)
        // .NumberOfCans = MiniBook("NumberOfContainer")
        // .ContainerSize = MiniBook("ContainerSize")
        // .MiniBookingOrder = MiniBook("MinibookingOrder")
        // .AmountRequested = MiniBook("AmountRequested")
        // .SpecialMax = MiniBook("SpecialMax")
        // If Not IsDBNull(MiniBook("BagWeight")) Then
        // .BagWeight = MiniBook("BagWeight")
        // Else
        // .BagWeight = 0
        // End If

        // .BagWeightUnit = MiniBook("BagWeightUnit")

        // If Not IsDBNull(MiniBook("LotNumber")) Then
        // .LotNumber = MiniBook("LotNumber")
        // Else
        // .LotNumber = ""
        // End If

        // If Not IsDBNull(MiniBook("BagProvider")) Then
        // .BagProvider = MiniBook("BagProvider")
        // Else
        // .BagProvider = ""
        // End If

        // If Not IsDBNull(MiniBook("Tagging")) Then
        // .BagTagging = MiniBook("Tagging")
        // Else
        // .BagTagging = ""
        // End If

        // If Not IsDBNull(MiniBook("BagType")) Then
        // .BagType = MiniBook("BagType")
        // Else
        // .BagType = ""
        // End If

        // .GradeBy = MiniBook("GradeBy")
        // .PhytosanitaryBy = MiniBook("PhytosanitaryBy")
        // If Not IsDBNull(MiniBook("InspectionBy")) Then
        // .InspectionBy = MiniBook("InspectionBy")
        // Else
        // .InspectionBy = "N/A"
        // End If

        // .FumigationBy = MiniBook("FumigationBy")
        // If Not IsDBNull(MiniBook("Other")) Then
        // .Other = MiniBook("Other")
        // Else
        // .Other = ""
        // End If

        // If IsDBNull(MiniBook("TerminalEffcFee")) Then
        // .TerminalEffcyFee = ""
        // Else
        // .TerminalEffcyFee = MiniBook("TerminalEffcFee")
        // End If

        // .SpecialInstrux = MiniBook("SpecialInstrux")
        // If Not IsDBNull(MiniBook("SpecialInstruxNote")) Then
        // .SpecialInstruxNotes = MiniBook("SpecialInstruxNote")
        // Else
        // .SpecialInstruxNotes = ""
        // End If

        // End With
        // MiniCnt += 1
        // Next

        // Return TotalMiniBooks
        // Else
        // Return -1
        // End If
        // End Function

        // Public Sub UpdateBookings(CustomerNumber As Int32, ThisBooking As String, ExcelFileName As String, BookingSources As String, UnitComodities As String, DeliveredBookings As String)
        // Dim BookingNum As String = ""
        // Dim CustomerName As String = ""
        // Dim NumOfContainers As String = ""
        // Dim SSLineCode As String = ""
        // Dim VesselName As String = ""
        // Dim LRD As String = ""
        // Dim BookingType As String = ""
        // Dim TerminalCode As String = ""
        // Dim SplitBooking As Boolean = False

        // Dim DbObjDataTable As New System.Data.DataTable

        // BookingNum = RTrim(Mid(ThisBooking, 1, 20))
        // CustomerName = UCase(RTrim(Mid(ThisBooking, 21, 50)))
        // NumOfContainers = Mid(ThisBooking, 71, 2)
        // SSLineCode = RTrim(Mid(ThisBooking, 73, 10))
        // VesselName = RTrim(Mid(ThisBooking, 83, 50))
        // LRD = Mid(ThisBooking, 133, 4)
        // BookingType = Mid(ThisBooking, 137, 3)
        // TerminalCode = RTrim(Mid(ThisBooking, 140, 10))
        // If Mid(ThisBooking, 150, 1) = Chr(1) Then
        // SplitBooking = True
        // Else
        // SplitBooking = False
        // End If

        // Dim DbObjAdapter = New System.Data.SqlClient.SqlDataAdapter("Select * From  Bookings Where [Booking Number] = '" & BookingNum & "'", StrConnWTCCeres)
        // Dim DbObjCommand = New System.Data.SqlClient.SqlCommandBuilder(DbObjAdapter)

        // DbObjAdapter.Fill(DbObjDataTable)

        // If DbObjDataTable.Rows.Count = 0 Then
        // Dim DBObj_NewRow = DbObjDataTable.NewRow()
        // DBObj_NewRow("Booking Number") = BookingNum
        // DBObj_NewRow("Booking Type") = BookingType
        // DBObj_NewRow("Split Booking") = SplitBooking
        // DBObj_NewRow("Customer ID") = CustomerNumber
        // DBObj_NewRow("Customer Name") = CustomerName
        // DBObj_NewRow("Excel File Name") = ExcelFileName
        // DBObj_NewRow("Sources") = BookingSources
        // DBObj_NewRow("Unit Commodities") = UnitComodities
        // DBObj_NewRow("Number Of Containers") = NumOfContainers
        // DBObj_NewRow("Terminal Code") = TerminalCode
        // DBObj_NewRow("Terminal Name") = "" ' GiveTerminalName(TerminalCode)
        // DBObj_NewRow("SS Line Code") = SSLineCode
        // DBObj_NewRow("Vessel Name") = VesselName
        // DBObj_NewRow("LRD") = DateValue(DoFunctions.NumToDate(LRD))
        // DBObj_NewRow("Last Update") = DateValue(Date.Today.ToString)
        // DBObj_NewRow("RV Dates") = "" ' GenerateBlankRVDates(CVI(NumOfContainers))
        // DBObj_NewRow("Delivered Bookings") = DeliveredBookings
        // DBObj_NewRow("Previous RV State") = "" ' GivePreviousRVLine(DBObj_NewRow)
        // DBObj_NewRow("Active Booking") = True

        // DbObjDataTable.Rows.Add(DBObj_NewRow)
        // DbObjAdapter.Update(DbObjDataTable)

        // End If

        // End Sub

        // Public Function FetchCustomerInfo(CustomerID As Int32) As CustomerInfo
        // Dim CustomerRow As DataRow

        // Dim DbObjDataTable As New System.Data.DataTable
        // Dim DbObjAdapter
        // DbObjAdapter = New System.Data.SqlClient.SqlDataAdapter("select  cs.CompanyId as CompId, cs.Companyname, isPCR, cs.DescCompanyType, a.* from VW_CompanyCompanyType as cs
        // left join Addresses a on cs.CompanyId = a.[Company ID]
        // Where  a.[Company Id] = " & CustomerID, StrConnWTCCeres)
        // Dim DbObjCommand = New System.Data.SqlClient.SqlCommandBuilder(DbObjAdapter)

        // DbObjAdapter.Fill(DbObjDataTable)

        // With FetchCustomerInfo
        // If DbObjDataTable.Rows.Count > 0 Then
        // CustomerRow = DbObjDataTable.Rows(0)

        // If Not IsDBNull(CustomerRow("Address")) Then
        // .Address1 = RTrim(CustomerRow("Address"))
        // .Address2 = RTrim(CustomerRow("City")) + "," + RTrim(CustomerRow("Province"))
        // .Address3 = RTrim(CustomerRow("Zip Code"))
        // .Phone = RTrim(CustomerRow("Phone"))
        // .Fax = RTrim(CustomerRow("Fax"))
        // .Attention = RTrim("Attention")
        // Else
        // .Address1 = ""
        // .Address2 = ""
        // .Address3 = ""
        // .Phone = ""
        // .Fax = ""
        // .Attention = ""
        // End If

        // If CustomerRow.IsNull("isPCR") = False AndAlso CustomerRow("isPCR") = True Then
        // .PCR = True
        // Else
        // .PCR = False
        // End If
        // Else
        // .Address1 = ""
        // .Address2 = ""
        // .Address3 = ""
        // .Phone = ""
        // .Fax = ""
        // .Attention = ""
        // .PCR = True

        // End If
        // End With
        // End Function

        // Public Function deleteCSVFile(ByVal filePath As String, fileName As String) As Boolean

        // If File.Exists(Path.Combine(filePath, fileName + ".xls")) = True Then
        // Try
        // My.Computer.FileSystem.DeleteFile(filePath + "\" + fileName + ".xls")
        // Return True
        // Catch ex As Exception
        // MessageBoxCeresOK.ShowDialog("Error deleting Excel file.", "Error: " + ex.Message, FrmEditAddBooking)
        // Return False
        // End Try
        // Return True
        // End If
        // Return False
        // End Function

        // Public Sub updateUnitsInExcelFile(BookingNumber As String, miniUnits As List(Of VW_MinibookingMiniUnitAssignment))

        // Dim ExcelFile As String = "", ThisXLSFile As String = "", YSt As Integer

        // ExcelFile = BookingNumber + ".xls"

        // ThisXLSFile = focusedOpenPath + "\" + ExcelFile

        // If File.Exists(ThisXLSFile) Then

        // If IsExcelFileOpened(ThisXLSFile) = False Then
        // XLWorkbook = Excel.Workbooks.Open(ThisXLSFile, ReadOnly:=False)

        // XLWorkbook.Application.DisplayAlerts = False

        // Dim UnitSheet As Worksheet = XLWorkbook.Sheets(2)
        // clearBkUnits(UnitSheet)

        // For Each miniUnit In miniUnits

        // YSt = findAvailUnitSourceExcelLine(UnitSheet, "")

        // UnitSheet.Cells(YSt, 3) = miniUnit.MiniUnitNumber

        // If miniUnit.CargoType.Equals("BULK") Then
        // 'MT
        // UnitSheet.Cells(YSt, 9) = miniUnit.TotalBilledMU
        // UnitSheet.Cells(YSt, 10) = 0
        // Else
        // 'MT
        // UnitSheet.Cells(YSt, 9) = miniUnit.BilledByUnit
        // 'BAGS
        // UnitSheet.Cells(YSt, 10) = miniUnit.TotalBilledMU
        // End If

        // UnitSheet.Cells(YSt, 4) = Trim(miniUnit.GradeCode)
        // UnitSheet.Cells(YSt, 5) = Trim(miniUnit.CommodityCode)

        // Next

        // XLWorkbook.Application.DisplayAlerts = True
        // XLWorkbook.Close(True)
        // Else
        // waitForm.Close()
        // MsgBox(ThisXLSFile + ": Is Currently Opened!", MsgBoxStyle.OkOnly)

        // End If
        // Else

        // XLWorkbook.Application.DisplayAlerts = True
        // MsgBox(ThisXLSFile + ": Is Not Found!", MsgBoxStyle.OkOnly)
        // XLWorkbook.Close(False)
        // End If

        // End Sub

        // Public Function findAvailUnitSourceExcelLine(ByVal UnitSheet As Worksheet, valueToFind As String) As Integer
        // Dim line As Integer = 8, lineText As String

        // For i = line To 52
        // lineText = UnitSheet.Cells(i, 3).value

        // If valueToFind.Equals("") Or valueToFind.Equals("TBA") Then

        // If String.IsNullOrEmpty(lineText) OrElse lineText.Equals("TBA") Then
        // Return i
        // End If
        // Else
        // If lineText.Equals(valueToFind) Then
        // Return i
        // End If
        // End If
        // Next

        // End Function

        // Private Sub clearBkUnits(UnitSheet As Worksheet)
        // Dim YSt As Integer, blankLines As Integer = 0

        // UnitSheet.Select()

        // For i = 8 To 52
        // YSt = i

        // If IsNothing(UnitSheet.Cells(YSt, 3).Value) OrElse (UnitSheet.Cells(YSt, 3).Value.Equals("") Or UnitSheet.Cells(YSt, 3).Value.Equals("TBA")) Then
        // blankLines += 1
        // End If
        // If blankLines = 3 Then Exit For

        // 'Dim unitNumberCell As Excel.Range = UnitSheet.Cells(YSt, 3)
        // 'unitNumberCell.Select()
        // 'unitNumberCell.Formula = "=IF(Setup!$I$11>=3.5,"TBA","")"

        // Dim unitNumberCell As Excel.Range = UnitSheet.Cells(YSt, 3)

        // If Not IsNothing(unitNumberCell.Value) AndAlso (Not unitNumberCell.Value.ToString().Contains("/")) AndAlso (Not unitNumberCell.Value.ToString().Contains("-")) Then
        // unitNumberCell.Value = "TBA"

        // Dim g1 As Excel.Range = UnitSheet.Cells(YSt, 4)
        // g1.Select()
        // g1.ClearContents()

        // Dim c1 As Excel.Range = UnitSheet.Cells(YSt, 5)
        // c1.Select()
        // c1.ClearContents()

        // Dim g2 As Excel.Range = UnitSheet.Cells(YSt, 6)
        // g2.Select()
        // g2.ClearContents()

        // Dim c2 As Excel.Range = UnitSheet.Cells(YSt, 7)
        // c2.Select()
        // c2.ClearContents()

        // Dim mtWeightCell As Excel.Range = UnitSheet.Cells(YSt, 9)
        // mtWeightCell.Select()
        // mtWeightCell.ClearContents()

        // Dim bagNumbCell As Excel.Range = UnitSheet.Cells(YSt, 10)
        // bagNumbCell.Select()
        // bagNumbCell.ClearContents()
        // End If

        // Next
        // End Sub

        public static void SaveCeresExcelLog(int recordId, string syncType, string extraInfo, WTCCeresEntities db)
        {
            var cep = new CeresExcelPendingSync();
            cep.RecordId = recordId;
            cep.EmployeeId = My.MyProject.Forms.FrmLoginWindow._userID;
            cep.SyncType = syncType;
            cep.ExtraInfo = extraInfo;
            cep.CurrentStatus = "QUEUE";
            cep.QtyOfAttempts = 0;
            cep.SyncMessage = "ADDED TO QUEUE";
            cep.CreatedAt = DateAndTime.Now;
            CeresExcService.AddOrUpdate(cep, db);
        }

        public static bool IsOdd(int iNum)
        {
            bool IsOddRet = default;
            IsOddRet = iNum / 2 * 2 != iNum;
            return IsOddRet;
        }

        public static IList<T> Clone<T>(IList<T> listToClone) where T : ICloneable
        {
            return listToClone.Select(item => (T)item.Clone()).ToList();
        }
    }
}