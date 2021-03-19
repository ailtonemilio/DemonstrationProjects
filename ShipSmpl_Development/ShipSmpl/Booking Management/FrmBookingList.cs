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
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmBookingList
    {
        public FrmBookingList()
        {
            InitializeComponent();
            _ExportCSVToolStripMenuItem.Name = "ExportCSVToolStripMenuItem";
            _tbSSLine.Name = "tbSSLine";
            _tbBooking.Name = "tbBooking";
            _tbType.Name = "tbType";
            _tbCustomer.Name = "tbCustomer";
            _tbDestination.Name = "tbDestination";
            _tbService.Name = "tbService";
            _tbLRD.Name = "tbLRD";
            _tbERD.Name = "tbERD";
            _tbDock.Name = "tbDock";
            _tbSplit.Name = "tbSplit";
            _tbCarrier.Name = "tbCarrier";
            _dgvBookings.Name = "dgvBookings";
            _btnUpdateCarrier.Name = "btnUpdateCarrier";
            _btnActivateDeactivateBooking.Name = "btnActivateDeactivateBooking";
            _updateButton.Name = "updateButton";
            _btnSplit.Name = "btnSplit";
            _asnUnitSourcesButton.Name = "asnUnitSourcesButton";
            _activeToggleSwitch.Name = "activeToggleSwitch";
            _unitSourcesTabControl.Name = "unitSourcesTabControl";
            _dgvBookingUnit.Name = "dgvBookingUnit";
            _btnUnassign.Name = "btnUnassign";
            _dgvMinibooking.Name = "dgvMinibooking";
            _pushButton.Name = "pushButton";
            _newBookingButton.Name = "newBookingButton";
        }

        public string formMode;
        private string[] BookingSources;
        private DatabaseHelperCeres dbCeres = new DatabaseHelperCeres();
        private string DBConnect = DatabaseHelperCeres.StrConnWTCCeres;
        public List<VW_Booking> selectedBookings = new List<VW_Booking>();
        public string[] selectedBookingsToAsng;
        private bool firstLoad;
        private TimeSpan span;
        public int secondsToSearch = 1;
        private CeresExcelPendingSyncService CeresExcService = new CeresExcelPendingSyncService();

        // Public selectedMBID As New Dictionary(Of Integer, String)
        public DialogResult resultNoInstrux;

        public bool shouldRefresh;
        private int[] selecteMiniUnitIds;
        private int[] selecteMinibookingIds;
        private string sortMode;
        private object record;
        public VW_Booking FocusedBookingObj;
        public List<VW_Booking> BKList;
        public List<VW_Booking> BKListAll = new List<VW_Booking>();

        private struct BookList
        {
            public string BookNumber;
            public string CustomerName;
            public string Forwarder;
            public string BookService;
            public string Destination;
            public string SSLineCode;
            public string ERDDate;
            public string ERDTime;
            public string LRDDate;
            public string LRDTime;
            public string DockName;
            public string Vessel;
            public string BookStatus;
            public string NumOfMBs;
            public string ContainerInfo;
        }

        private struct OutGateContainers
        {
            public string YardCode;
            public string DateOut;
            public string CarrierOut;
            public char CanStatus;
            public string SealNumber;
            public string CargoWeight;
            public string CarrierTruck;
            public string CarrierDriver;
        }

        private string AssignContainerInfo(string BookingNumber, string NumOfCans, string BookCansAssigned)
        {
            int x = 0;
            var loopTo = Strings.Len(BookCansAssigned);
            for (x = 1; x <= loopTo; x += 48)
            {
                if ((BookingNumber ?? "") == (Strings.Mid(BookCansAssigned, x, 40) ?? ""))
                {
                    return Strings.Mid(BookCansAssigned, x + 40, 8);
                }
            }

            return NumOfCans + NumOfCans + MdlContainerManagement.DoFunctions.MKI(0) + MdlContainerManagement.DoFunctions.MKI(0);
        }

        private string AssignMiniBooking(string BookNumber, string MiniBookings)
        {
            int x = 0;
            var loopTo = Strings.Len(MiniBookings);
            for (x = 1; x <= loopTo; x += 52)
            {
                if ((BookNumber ?? "") == (Strings.Mid(MiniBookings, x, 40) ?? ""))
                {
                    return Strings.Mid(MiniBookings, x + 40, 12);
                }
            }

            return MdlContainerManagement.DoFunctions.MKI(0) + MdlContainerManagement.DoFunctions.PadToString(Conversions.ToString(' '), 10);
        }

        private void populateDgv(string bookingNumb)
        {
            if (!firstLoad)
            {
                var mbmuasnList = MinibookingMiniUnitAssignmentService.GetByOriginalBookingNumber(FocusedBookingObj.BookingNumber);
                switch (unitSourcesTabControl.SelectedIndex)
                {
                    case 0:
                        {
                            VWMinibookingMiniUnitAssignmentBindingSource.DataSource = mbmuasnList;
                            break;
                        }

                    case 1:
                        {
                            try
                            {
                                InOutContainerList2.TakeContainerList(FetchContainerList(FocusedBookingObj.BookingNumber));
                            }
                            catch
                            {
                            }

                            break;
                        }

                    case 2:
                        {
                            FocusedBookingObj = (VW_Booking)dgvBookings.CurrentRow.DataBoundItem;
                            VWBookingMinibookingBindingSource.DataSource = MinibookingService.GetJointBookingByBookingId(FocusedBookingObj.BookingId);
                            break;
                        }

                    case 3:
                        {
                            populateStuffing(bookingNumb);
                            break;
                        }
                }
            }
        }

        private string FetchContainerList(string BookingNumbers)
        {
            string ThisLine = "";
            string TempLine = "";
            var ContainersOut = default(OutGateContainers);
            System.Data.SqlClient.SqlConnection DBConnect;
            DBConnect = new System.Data.SqlClient.SqlConnection(DatabaseHelperCeres.StrConnWTCCeres);
            DBConnect.Open();
            var DbObjDataTable = new DataTable();
            var DbObjAdapter = new System.Data.SqlClient.SqlDataAdapter("Select * From VW_ContainersByBooking Where  [BookingNumber] = '" + FocusedBookingObj.BookingNumber + "' Order By [Gate Date Out] DESC", DBConnect);
            var DbObjCommand = new System.Data.SqlClient.SqlCommandBuilder(DbObjAdapter);
            DbObjAdapter.Fill(DbObjDataTable);
            foreach (DataRow CansOutRow in DbObjDataTable.Rows)
            {
                if (CansOutRow.IsNull("Cargo Weight Out") == true)
                {
                    ContainersOut.CargoWeight = MdlContainerManagement.DoFunctions.MKS(0f);
                }
                else
                {
                    ContainersOut.CargoWeight = Conversions.ToString(CansOutRow["Cargo Weight Out"]);
                }

                if (CansOutRow.IsNull("Seal Number") == true)
                {
                    ContainersOut.SealNumber = MdlContainerManagement.DoFunctions.PadToString(Conversions.ToString(' '), 10);
                }
                else
                {
                    ContainersOut.SealNumber = Conversions.ToString(CansOutRow["Seal Number"]);
                }

                if (CansOutRow.IsNull("Carrier Truck Out") == true)
                {
                    ContainersOut.CarrierTruck = MdlContainerManagement.DoFunctions.PadToString(Conversions.ToString(' '), 10);
                }
                else
                {
                    ContainersOut.CarrierTruck = Conversions.ToString(CansOutRow["Carrier Truck Out"]);
                }

                if (CansOutRow.IsNull("Carrier DriverName Out") == true)
                {
                    ContainersOut.CarrierDriver = MdlContainerManagement.DoFunctions.PadToString(Conversions.ToString(' '), 40);
                }
                else
                {
                    ContainersOut.CarrierDriver = Conversions.ToString(CansOutRow["Carrier DriverName Out"]);
                }

                if (CansOutRow.IsNull("MinibookingId") == false)
                {
                    if (CansOutRow.IsNull("Container Out-Gated") == false && Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(CansOutRow["Container Out-Gated"], true, false)))
                    {
                        ContainersOut.YardCode = MdlContainerManagement.DoFunctions.PadToString(Conversions.ToString(CansOutRow["Yard Code Out"]), 10);
                        ContainersOut.DateOut = MdlContainerManagement.DoFunctions.DateToNum(Conversions.ToDate(CansOutRow["Gate Date Out"]));
                        ContainersOut.CarrierOut = Conversions.ToString(CansOutRow["Carrier Code Out"]);
                        ContainersOut.CanStatus = '\u0003';
                    }
                    else
                    {
                        ContainersOut.YardCode = MdlContainerManagement.DoFunctions.PadToString(Conversions.ToString(CansOutRow["Yard Code In"]), 10);
                        ContainersOut.DateOut = MdlContainerManagement.DoFunctions.MKL(0);
                        ContainersOut.CarrierOut = MdlContainerManagement.DoFunctions.PadToString(Conversions.ToString(' '), 10);
                        if (!string.IsNullOrEmpty(Strings.RTrim(ContainersOut.SealNumber)))
                        {
                            ContainersOut.CanStatus = '\u0002';
                        }
                        else
                        {
                            ContainersOut.CanStatus = '\u0001';
                        }
                    }
                }
                else if (CansOutRow.IsNull("Assigned To Extra") == false && Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(CansOutRow["Assigned To Extra"], true, false)))
                {
                    ContainersOut.CanStatus = '\u0005';
                }
                else if (CansOutRow.IsNull("Assigned To Storage") == false && Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(CansOutRow["Assigned To Storage"], true, false)))
                {
                    ContainersOut.CanStatus = '\u0004';
                }
                else
                {
                    ContainersOut.CanStatus = 'd';
                }

                ThisLine = Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Conversions.ToString('\0') + MdlContainerManagement.DoFunctions.PadToString(Conversions.ToString(CansOutRow["MinibookingNumber"]), 40), CansOutRow["Container Number"]), CansOutRow["SS Line Code Out"]), CansOutRow["Container Size"]), ContainersOut.YardCode), ContainersOut.SealNumber), ContainersOut.CargoWeight), ContainersOut.CanStatus), ContainersOut.DateOut), ContainersOut.CarrierOut), ContainersOut.CarrierTruck), ContainersOut.CarrierDriver));
                if (Strings.Len(ThisLine) == 152)
                {
                    TempLine += ThisLine;
                }
            }

            DBConnect.Close();
            return TempLine;
        }

        private string FetchBookimgContainersAssigned()
        {
            string TempLine = "";
            short CanOS = 0;
            var DbObjDataTable = new DataTable();
            var DbObjAdapter = new System.Data.SqlClient.SqlDataAdapter("Select * From [Booking List Containers Assignment]", DBConnect);
            var DbObjCommand = new System.Data.SqlClient.SqlCommandBuilder(DbObjAdapter);
            DbObjAdapter.Fill(DbObjDataTable);
            foreach (DataRow CanAssignRow in DbObjDataTable.Rows)
            {
                CanOS = Conversions.ToShort(Operators.SubtractObject(CanAssignRow["Number Of Cans"], CanAssignRow["Assigned"]));
                if (CanOS < 1)
                    CanOS = 0;
                TempLine += MdlContainerManagement.DoFunctions.PadToString(Conversions.ToString(CanAssignRow["Booking Number"]), 40) + MdlContainerManagement.DoFunctions.MKI(Conversions.ToInteger(CanAssignRow["Number Of Cans"])) + MdlContainerManagement.DoFunctions.MKI(CanOS) + MdlContainerManagement.DoFunctions.MKI(Conversions.ToInteger(CanAssignRow["Ready"])) + MdlContainerManagement.DoFunctions.MKI(Conversions.ToInteger(CanAssignRow["Delivered"]));
            }

            return TempLine;
        }

        private void populateStuffing(string bookingNumb)
        {
            var stuffingDt = new DataTable();
            string contNumb;
            string SealNumb;
            decimal translAmt;
            DateTime packDate;
            string unitSource;
            string cmdtyGradeCode;
            string lotNumb;
            string packedBy;
            string bagWeight;
            decimal weightMT;
            string query;
            string service;
            query = @"  select bt.*, b.ServiceCode from [Booking Transload] as bt join
  VW_BookingMinibooking as b on bt.[Booking NUmber]  = b.MinibookingNumber where bt.[Booking Number] = '" + bookingNumb + "'";
            //      stuffingDt = dbCeres.getDataByQuery(query);
            dgvStuffing.Rows.Clear();
            foreach (DataRow row in stuffingDt.Rows)
            {
                contNumb = Strings.Trim(Conversions.ToString(row["Container Number"]));
                if (row["Seal Number"] != DBNull.Value)
                {
                    SealNumb = Strings.Trim(Conversions.ToString(row["Seal Number"]));
                }
                else
                {
                    SealNumb = "";
                }

                unitSource = Strings.Trim(Conversions.ToString(row["Unit Source"]));
                if (row["ServiceCode"] != DBNull.Value)
                {
                    service = Strings.Trim(Conversions.ToString(row["ServiceCode"]));
                }
                else
                {
                    service = "";
                }

                cmdtyGradeCode = Strings.Trim(Strings.Trim(Conversions.ToString(row["Grade Name"])) + " " + Strings.Trim(Conversions.ToString(row["Commodity Name"])));
                bagWeight = Strings.Trim(Conversions.ToString(row["Bag Weight"])).ToString() + " " + Strings.Trim(Conversions.ToString(row["Weight Unit"]));
                translAmt = Conversions.ToDecimal(row["Transload Amount"]);
                weightMT = Conversions.ToDecimal(row["Weight Mt"]);
                lotNumb = Strings.Trim(Conversions.ToString(row["Lot Number"]));
                packedBy = Strings.Trim(Conversions.ToString(row["Packed By"]));
                packDate = Conversions.ToDate(row["Pack Date"]);
                dgvStuffing.Rows.Add(row["Record ID"], contNumb, SealNumb, unitSource, service, cmdtyGradeCode, bagWeight, weightMT.ToString("0.####"), translAmt.ToString("0.####"), lotNumb, packDate.ToString("dd-MMM-yyyy"), packedBy);
            }
        }

        private void FrmBookingList_Resize(object sender, EventArgs e)
        {
            {
                var withBlock = this;
                // NewBookingListing2.Width = .Width - 70
                // listBookPanel.Width = .Width - 70

                // RailList1.Width = .Width - 70

                unitSourcesTabControl.Width = withBlock.Width - 70;
            }
        }

        private bool MatchMiniBooking(string BookingNumber, short MiniBookOrder, string CarrierCode, ref string TempLine)
        {
            int x = 0;
            var loopTo = Strings.Len(TempLine);
            for (x = 1; x <= loopTo; x += 52)
            {
                if ((BookingNumber ?? "") == (Strings.Mid(TempLine, x, 40) ?? ""))
                {
                    var midTmp = MdlContainerManagement.DoFunctions.MKI(MdlContainerManagement.DoFunctions.CVI(Strings.Mid(TempLine, x + 40, 2)) + 1);
                    StringType.MidStmtStr(ref TempLine, x + 40, 2, midTmp);
                    if (MiniBookOrder == 1)
                    {
                        StringType.MidStmtStr(ref TempLine, x + 42, 10, CarrierCode);
                    }

                    return true;
                }
            }

            return false;
        }

        private void newBookingButton_Click(object sender, EventArgs e)
        {
            // populateBookingInfo(selectedBooking)
            // My.MyProject.Forms.FrmParentScreen.showLOadForm();
            shouldRefresh = false;
            My.MyProject.Forms.FrmEditAddBooking.isNewRecod = true;
            My.MyProject.Forms.FrmEditAddBooking.isMultiEdit = false;
            My.MyProject.Forms.FrmEditAddBooking.loadForm(null);
            //  My.MyProject.Forms.FrmParentScreen.HideLoadForm();
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmEditAddBooking, ParentForm);
            CheckButtons();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            shouldRefresh = true;
            // Call NewBookingListing2.RequestSelectedBookings()
            // My.MyProject.Forms.FrmParentScreen.showLOadForm();
            {
                var withBlock = My.MyProject.Forms.FrmEditAddBooking;
                withBlock.isNewRecod = false;
                if (selectedBookings.Count > 1)
                {
                    withBlock.isMultiEdit = true;
                }
                else
                {
                    withBlock.isMultiEdit = false;
                }

                FocusedBookingObj = (VW_Booking)dgvBookings.CurrentRow.DataBoundItem;
                withBlock.oldBkNumb = FocusedBookingObj.BookingNumber;
                withBlock.loadForm(selectedBookings);
                // My.MyProject.Forms.FrmParentScreen.HideLoadForm();
                MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmEditAddBooking, My.MyProject.Forms.FrmParentScreen);
                CheckButtons();
            }
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            DialogResult result;
            // Call NewBookingListing2.RequestSelectedBookings()
            try
            {
                if (btnActivateDeactivateBooking.Text.Equals("Reactivate Booking"))
                {
                    foreach (var booking in selectedBookings)
                    {
                        MdlLoadingSetting.waitForm.Show();
                        BusinessLayer.WTC_Ceres.BookingService.UpdateBookingStatus(booking.BookingId, true, (int)MdlEnum.BookingStatus.REACTIVATED);
                        EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, booking.BookingNumber, "UPDATE", "BOOKING", "Booking reactivated");
                        // '     NewBookingListing2.TakeBookingList(FetchBookingListing(True, "Edit"))
                        BKListAll = BusinessLayer.WTC_Ceres.BookingService.GetAllVW();
                        BKList = BKListAll.Where(b => b.ActiveBooking == activeToggleSwitch.Value).ToList();
                        VWBookingBindingSource.DataSource = BKList;
                        CheckButtons();
                        MdlLoadingSetting.waitForm.Close();
                    }
                }
                else
                {
                    result = My.MyProject.Forms.FrmDeactivateBooking.ShowDialog("Choose  reason for deactivating the booking:", this);
                    if (result == DialogResult.Yes)
                    {
                        MdlLoadingSetting.waitForm.Show();
                        var reason = My.MyProject.Forms.FrmDeactivateBooking.Reason;
                        foreach (VW_Booking booking in selectedBookings)
                        {
                            var containersUnderBk = Containers_In_OutService.GetContainersByBookingAndStatus(false, booking.BookingId.ToString());
                            if (containersUnderBk.Count == 0)
                            {
                                switch (reason)
                                {
                                    case "COMPLETED":
                                        {
                                            BusinessLayer.WTC_Ceres.BookingService.UpdateBookingStatus(booking.BookingId, false, (int)MdlEnum.BookingStatus.COMPLETED);
                                            EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, booking.BookingNumber.ToString(), "EDIT", "BOOKING", "Booking " + booking.BookingNumber + " tagged as completed");
                                            break;
                                        }

                                    case "CANCELLED":
                                        {
                                            BusinessLayer.WTC_Ceres.BookingService.UpdateBookingStatus(booking.BookingId, false, (int)MdlEnum.BookingStatus.CANCELLED);
                                            EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, booking.BookingNumber.ToString(), "CANCELLED", "BOOKING", "Booking " + booking.BookingNumber + " tagged as cancelled");
                                            break;
                                        }

                                    default:
                                        {
                                            BusinessLayer.WTC_Ceres.BookingService.UpdateBookingStatus(booking.BookingId, false, (int)MdlEnum.BookingStatus.DELETED);
                                            EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, booking.BookingNumber.ToString(), "DELETE", "BOOKING", "Booking " + booking.BookingNumber + " tagged as deleted");
                                            break;
                                        }
                                }

                                BKListAll = BusinessLayer.WTC_Ceres.BookingService.GetAllVW();
                                BKList = BKListAll.Where(b => b.ActiveBooking == activeToggleSwitch.Value).ToList();
                                MdlLoadingSetting.waitForm.Close();
                                VWBookingBindingSource.DataSource = BKList;
                                CheckButtons();
                            }
                            else
                            {
                                MdlLoadingSetting.waitForm.Close();
                                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Error deactivating booking " + booking.BookingId.ToString(), "Error details: There are containers in-gated but not out-gated under booking : " + containersUnderBk[0].MinibookingNumber, this);
                            }
                        }
                    }
                }
            }
            catch
            {
            }
        }

        private void asnUnitSourcesButton_Click(object sender, EventArgs e)
        {
            var mbRow = new VW_BookingMinibooking();
            var mbRowList = new List<VW_BookingMinibooking>();
            var multiMBList = new List<VW_BookingMinibooking>();
            var mbToAssignList = new List<VW_BookingMinibooking>();
            var mbService = new MinibookingService();
            My.MyProject.Forms.FrmAssignToUnits.OriginalMBSelectedList.Clear();
            var bkLists = new List<string>();
            foreach (var bk in selectedBookings)
                bkLists.Add(bk.BookingNumber);
            var blList = MinibookingService.GetJointBookingByBookingList(bkLists);
            string diffServiceList = "";
            string diffCustomerList = "";

            if (hasSameBkService(blList, ref diffServiceList) == false)
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Can not proceed:", "It Seems like different service types has been selected. Please, select only one type of service to continue." + Constants.vbNewLine + "Bookings:" + Constants.vbNewLine + diffServiceList, this);
                return;
            }
            else if (hasSameCustomers(blList, ref diffCustomerList) == false)
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Can not proceed:", "It Seems like different Customers has been selected. Please, select the same customer name  to continue." + Constants.vbNewLine + "Bookings:" + Constants.vbNewLine + diffCustomerList, this);
                return;
            }

            {
                var withBlock = My.MyProject.Forms.FrmMiniBookingWarning;
                foreach (var bkng in selectedBookings)
                {
                    mbRowList = MinibookingService.GetJointBookingByBookingId(bkng.BookingId);
                    if (mbRowList.Count > 1)
                    {
                        foreach (var mb in mbRowList)
                            multiMBList.Add(mb);
                        withBlock.VWBookingMinibooking.DataSource = multiMBList;
                    }
                    else
                    {
                        try
                        {
                            mbToAssignList.Add(mbRowList[0]);
                            My.MyProject.Forms.FrmAssignToUnits.OriginalMBSelectedList = mbToAssignList;
                        }
                        catch
                        {
                            resultNoInstrux = My.MyProject.Forms.MessageBoxCeresYesNo.ShowDialog("No minibooking added", "The minibooking of this bookig doesn't exist or was deleted.  " + " Would you like to edit the booking now?", My.Resources.Resources.caution, this);
                            if (resultNoInstrux == DialogResult.Yes)
                            {
                                formMode = "Edit";
                                shouldRefresh = false;
                                MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmEditAddBooking, this);

                                // check if user actually updated the booking. If dialog result is yes, then it was updated
                                if (!(resultNoInstrux == DialogResult.Yes))
                                {
                                    return;
                                }
                                else
                                {
                                    // update mbDT variable

                                    mbRowList = MinibookingService.GetJointBookingByBookingId(FocusedBookingObj.BookingId);
                                    if (mbRowList.Count > 1)
                                    {
                                        foreach (var mb in mbRowList)
                                            multiMBList.Add(mb);
                                        withBlock.VWBookingMinibooking.DataSource = multiMBList;
                                    }
                                    else
                                    {
                                        mbToAssignList.Add(mbRowList[0]);
                                        My.MyProject.Forms.FrmAssignToUnits.OriginalMBSelectedList = mbToAssignList;
                                    }
                                }
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                }

                if (multiMBList.Count > 0)
                {
                    MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmMiniBookingWarning, this);
                }
                else
                {
                    MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAssignToUnits, this);
                }
            }
        }

        private bool hasSameBkService(List<VW_BookingMinibooking> selectednk, ref string diffCargosList)
        {
            string firstCargoId = "";
            bool isSameCargo = true;
            firstCargoId = selectednk[0].ServiceCode;
            foreach (var bk in selectednk)
            {
                if ((firstCargoId ?? "") != (bk.ServiceCode ?? ""))
                {
                    if (!((firstCargoId.Equals("BLK") | firstCargoId.Equals("BGR")) & (bk.ServiceCode.Equals("BLK") | bk.ServiceCode.Equals("BGR"))))
                    {
                        isSameCargo = false;
                    }
                }

                diffCargosList += bk.BookingNumber + " - " + bk.ServiceCode + Constants.vbNewLine;
            }

            return isSameCargo;
        }

        private bool hasSameCustomers(List<VW_BookingMinibooking> selectedUnits, ref string diffCustomerList)
        {
            string firstCustomerId = "";
            bool isSameCustomer = true;
            firstCustomerId = selectedUnits[0].CustomerId.ToString();
            isSameCustomer = true;
            foreach (var bk in selectedUnits)
            {
                if (Conversions.ToDouble(firstCustomerId) != bk.CustomerId)
                {
                    isSameCustomer = false;
                }

                diffCustomerList += bk.BookingNumber + " - " + bk.CustomerName + Constants.vbNewLine;
            }

            return isSameCustomer;
        }

        private void ExportCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdlLoadingSetting.waitForm.Show();
            var rows1 = dgvBookings.Rows;
            var headers = (from header in dgvBookings.Columns.Cast<DataGridViewColumn>()
                           select header.HeaderText).ToArray();
            var rows = from row in dgvBookings.Rows.Cast<DataGridViewRow>()
                       where !row.IsNewRow
                       select Array.ConvertAll(row.Cells.Cast<DataGridViewCell>().ToArray(), c => c.Value is object ? c.Value.ToString() : "");
            try
            {
                using (var sw = new System.IO.StreamWriter("csv.csv"))
                {
                    sw.WriteLine(string.Join(",", headers));
                    foreach (var r in rows)
                        sw.WriteLine(string.Join(",", r));
                }

                Process.Start("csv.csv");
            }
            catch (Exception ex)
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Error.", ex.Message, this);
            }

            MdlLoadingSetting.waitForm.Close();
        }

        private void pushButton_Click(object sender, EventArgs e)
        {
            int x = 0;
            string ShippingLines = "";
            VW_BookingMinibooking mbObj;

            // *** Shipping lines used in Excel have its own codes  ***
            MdlLoadingSetting.waitForm.Show();
            ShippingLines = MdlContainerManagement.FetchShippingLines();
            for (int i = 0, loopTo = dgvMinibooking.Rows.Count - 1; i <= loopTo; i++)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dgvMinibooking.Rows[i].Cells[0].Value, true, false)))
                {
                    mbObj = (VW_BookingMinibooking)dgvMinibooking.Rows[i].DataBoundItem;
                    if (MdlContainerManagement.FetchExcelFiles(mbObj.BookingNumber, mbObj.MinibookingNumber, ShippingLines, mbObj.MiniBookingId) == true)
                    {
                        // *** Confirmed Booking got Pushed ***
                        MdlLoadingSetting.waitForm.Close();
                        if (MdlContainerManagement.successPushing)
                        {
                            MdlLoadingSetting.waitForm.Close();
                            My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Success!", "The booking numbers were pushed.", this);
                        }
                        else
                        {
                            MdlLoadingSetting.waitForm.Close();
                            My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Something went wrong", "Please contanct the IT department for more information.", this);
                        }
                    }
                    else
                    {
                    }
                }
            }

            MdlLoadingSetting.waitForm.Close();
        }

        private void unitSourcesTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvBookings.Rows.Count > 0)
            {
                FocusedBookingObj = (VW_Booking)dgvBookings.CurrentRow.DataBoundItem;
                populateDgv(FocusedBookingObj.BookingNumber);
            }
        }

        private void dgvMB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                bool value = Conversions.ToBoolean(dgvMinibooking.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                if (value == false)
                {
                    dgvMinibooking.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                }
                else
                {
                    dgvMinibooking.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
                }
            }

            pushButton.Enabled = false;
            for (int i = 0, loopTo = dgvMinibooking.Rows.Count - 1; i <= loopTo; i++)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dgvMinibooking.Rows[i].Cells[0].Value, true, false)))
                {
                    pushButton.Enabled = true;
                }
            }
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
                }
            }
        }

        private void btnUnassign_Click(object sender, EventArgs e)
        {
            UnassignUnits();
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            // My.MyProject.Forms.FrmParentScreen.showLOadForm();
            var cansToOutgate = Containers_In_OutService.GetContainersByBookingAndStatus(false, FocusedBookingObj.BookingNumber);
            if (cansToOutgate.Count > 0)
            {
                formMode = "Split";
                shouldRefresh = true;
                My.MyProject.Forms.FrmEditAddBooking.oldBkNumb = FocusedBookingObj.BookingNumber;
                {
                    var withBlock = My.MyProject.Forms.FrmSplitbooking;
                    withBlock.reasignCans = false;
                    withBlock.dgvCansToTransfer.DataSource = cansToOutgate.ToList();
                    MdlBookingManagement.SplitedCansList.Clear();
                    withBlock.dgvCansToTransfer.Columns[0].Visible = false;
                    withBlock.dgvCansAsnMb.Rows.Clear();
                    //    My.MyProject.Forms.FrmParentScreen.HideLoadForm();
                    withBlock.ShowDialog(this);
                    if (withBlock.DialogResult == DialogResult.Yes)
                    {
                        My.MyProject.Forms.FrmEditAddBooking.selectedCans = withBlock.SelectedCans;
                        MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmEditAddBooking, this);
                    }
                }
            }
            else
            {
                //  My.MyProject.Forms.FrmParentScreen.HideLoadForm();
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Cannot split this booking.", "All the containers of this booking were already outgated. Please create a new booking instead.", this);
            }
        }

        private void activeToggleSwitch_OnValuechange(object sender, EventArgs e)
        {
            if (!firstLoad)
            {
                //  My.MyProject.Forms.FrmParentScreen.showLOadForm();
                if (BKListAll.Count == 0)
                {
                    BKListAll = BusinessLayer.WTC_Ceres.BookingService.GetAllVW();
                }

                // '        NewBookingListing2.TakeBookingList(FetchBookingListing(activeToggleSwitch.Value, ""))

                BKList = BKListAll.Where(b => b.ActiveBooking == activeToggleSwitch.Value).ToList();
                VWBookingBindingSource.DataSource = BKList;
                CheckButtons();
                if (activeToggleSwitch.Value == true)
                {
                    btnActivateDeactivateBooking.Text = "Deactivate Booking";
                }
                else
                {
                    btnActivateDeactivateBooking.Text = "Reactivate Booking";
                }

                //   My.MyProject.Forms.FrmParentScreen.HideLoadForm();
            }
        }

        private void dgvBookingUnit_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var UnitStatusCel = dgvBookingUnit.Rows[e.RowIndex].Cells["UnitStatus"];
            var BalanceInstrux = dgvBookingUnit.Rows[e.RowIndex].Cells["BalanceInstrux"];
            BalanceInstrux.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            BalanceInstrux.Style.Font = new Font(Font, FontStyle.Bold);
            UnitStatusCel.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UnitStatusCel.Style.Font = new Font(Font, FontStyle.Bold);
            dgvBookingUnit.Rows[e.RowIndex].Cells[4].Style.Font = new Font(Font, FontStyle.Bold);
            dgvBookingUnit.Rows[e.RowIndex].Cells[8].Style.Font = new Font(Font, FontStyle.Bold);
            // dgvBookingUnit.Rows(e.RowIndex).Cells[17).Style.Font = New Font(Me.Font, FontStyle.Bold)

            if (UnitStatusCel.Value.Equals("IN-TRANSIT"))
            {
                UnitStatusCel.Style.BackColor = Color.FromArgb(64, 64, 64);
            }
            else if (UnitStatusCel.Value.Equals("NOT TRACING"))
            {
                UnitStatusCel.Style.BackColor = Color.Red;
            }
            else if (UnitStatusCel.Value.Equals("AVAILABLE"))
            {
                UnitStatusCel.Style.BackColor = Color.DarkGreen;
            }
            else if (UnitStatusCel.Value.Equals("CALLED"))
            {
                UnitStatusCel.Style.BackColor = Color.Orange;
            }
            else if (UnitStatusCel.Value.Equals("MISSED"))
            {
                UnitStatusCel.Style.BackColor = Color.IndianRed;
            }
            else if (UnitStatusCel.Value.Equals("ON-HAND"))
            {
                UnitStatusCel.Style.BackColor = Color.OliveDrab;
            }
            else
            {
                UnitStatusCel.Style.BackColor = Color.DarkGray;
            }

            if (BalanceInstrux.Value.Equals("BAL. TO STORAGE"))
            {
                BalanceInstrux.Style.BackColor = Color.OrangeRed;
            }
            else
            {
                BalanceInstrux.Style.BackColor = Color.DarkGray;
            }

            UnitStatusCel.Style.ForeColor = Color.White;
            BalanceInstrux.Style.ForeColor = Color.White;
        }

        private void dgvBookings_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            firstLoad = true;
            string ColName = dgvBookings.Columns[e.ColumnIndex].DataPropertyName;
            string querySort;
            if (!string.IsNullOrEmpty(ColName))
            {
                if (ColName.Equals("ERDStr"))
                    ColName = "ERD";
                if (ColName.Equals("LRDStr"))
                    ColName = "LRD";
                List<VW_Booking> list;

                // If sort mode was asc, now it will be desc
                if (Information.IsNothing(sortMode) || sortMode.Equals("ASC"))
                {
                    querySort = ColName + " DESC";
                    sortMode = "DESC";
                }
                else
                {
                    querySort = ColName + " ASC";
                    sortMode = "ASC";
                }

                // list = VWBookingBindingSource.DataSource.
                var currentList = new List<VW_Booking>();
                currentList = (List<VW_Booking>)VWBookingBindingSource.DataSource;
                list = currentList.OrderBy(querySort).ToList();
                // BKList = list
                VWBookingBindingSource.DataSource = list;
            }
            else
            {
                // Select many bookings at once

                selectedBookings = new List<VW_Booking>();
                foreach (DataGridViewRow row in dgvBookings.Rows)
                {
                    string value = Conversions.ToString(row.Cells[0].Value);
                    if (Information.IsNothing(value) || value.Equals("   "))
                    {
                        row.Cells[0].Value = "✔";
                        var BkRow = new VW_Booking();
                        BkRow = (VW_Booking)row.DataBoundItem;
                        selectedBookings.Add(BkRow);
                    }
                    else
                    {
                        row.Cells[0].Value = "   ";
                    }
                }
            }

            CheckButtons();
            firstLoad = false;
        }

        // Public Declare Function GetTickCount Lib "kernel32" () As Long

        // Sub Pause(Length As Long)
        // Dim OldTime As Long
        // OldTime = GetTickCount
        // Do

        // If GetTickCount >= OldTime + Length Then Exit Do
        // Loop
        // End Sub

        // Declare Sub Sleep Lib "kernel32" Alias "Sleep" (ByVal dwMilliseconds As Long)

        // Public Sub Main()
        // Sleep(1000) 'sleep for 1 second
        // End Sub

        private void tbBooking_TextChanged(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Start();
        }

        private void dgvBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedBookings = new List<VW_Booking>();
            if (e.ColumnIndex == 0)
            {
                try
                {
                    string value = Conversions.ToString(dgvBookings.Rows[e.RowIndex].Cells[0].Value);
                    VW_Booking BkRow = (VW_Booking)dgvBookings.Rows[e.RowIndex].DataBoundItem;
                    if (!Information.IsNothing(value) && value.Equals("   "))
                    {
                        dgvBookings.Rows[e.RowIndex].Cells[0].Value = "✔";
                    }

                    // selectedBookings.Add(BkRow)
                    else
                    {
                        dgvBookings.Rows[e.RowIndex].Cells[0].Value = "   ";
                    }
                }
                catch (Exception ex)
                {
                }

                foreach (DataGridViewRow row in dgvBookings.Rows)
                {
                    try
                    {
                        string value = Conversions.ToString(row.Cells[0].Value);
                        if (!Information.IsNothing(value) && value.Equals("✔"))
                        {
                            var BkRow = new VW_Booking();
                            BkRow = (VW_Booking)row.DataBoundItem;
                            selectedBookings.Add(BkRow);
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }

            CheckButtons();
        }

        private void dgvBookings_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var SplitBookingCel = dgvBookings.Rows[e.RowIndex].Cells["SplitBooking"];
            var ServiceCodeCel = dgvBookings.Rows[e.RowIndex].Cells["ServiceCode"];
            var BookingTypeCel = dgvBookings.Rows[e.RowIndex].Cells["BookingType"];
            var BookingNumberCel = dgvBookings.Rows[e.RowIndex].Cells["BookingNumber"];
            var LRDCel = dgvBookings.Rows[e.RowIndex].Cells["LRDStr"];
            var checkCell = dgvBookings.Rows[e.RowIndex].Cells["check"];
            var cans = dgvBookings.Rows[e.RowIndex].Cells["TotalQtyOfCans"];
            var carrier = dgvBookings.Rows[e.RowIndex].Cells["BkCarrierOutCode"];
            checkCell.Style.Font = new Font("Arial", 15.5f, FontStyle.Bold);
            checkCell.Style.ForeColor = Color.Black;
            checkCell.Style.SelectionForeColor = Color.Black;
            if (MdlBookingManagement.IsOdd(e.RowIndex))
            {
                checkCell.Style.SelectionBackColor = Color.FromKnownColor(KnownColor.Control);
            }
            else
            {
                checkCell.Style.SelectionBackColor = Color.White;
            }

            checkCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (Information.IsNothing(checkCell.Value))
                checkCell.Value = "   ";
            BookingNumberCel.Style.Font = new Font("Arial", 10f, FontStyle.Bold);
            BookingNumberCel.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            cans.Style.Font = new Font("Arial", 10f, FontStyle.Bold);
            carrier.Style.Font = new Font("Arial", 10f, FontStyle.Bold);
            cans.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            carrier.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            LRDCel.Style.Font = new Font("Arial", 10f, FontStyle.Bold);
            LRDCel.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SplitBookingCel.Style.ForeColor = Color.White;
            SplitBookingCel.Style.SelectionForeColor = Color.White;
            SplitBookingCel.Style.Font = new Font("Arial", 10f, FontStyle.Bold);
            SplitBookingCel.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ServiceCodeCel.Style.ForeColor = Color.White;
            ServiceCodeCel.Style.SelectionForeColor = Color.White;
            ServiceCodeCel.Style.Font = new Font("Arial", 10f, FontStyle.Bold);
            ServiceCodeCel.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            BookingTypeCel.Style.ForeColor = Color.White;
            BookingTypeCel.Style.SelectionForeColor = Color.White;
            BookingTypeCel.Style.Font = new Font("Arial", 10f, FontStyle.Bold);
            BookingTypeCel.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (SplitBookingCel.Value.Equals("DNS"))
            {
                SplitBookingCel.Style.BackColor = Color.Red;
                SplitBookingCel.Style.SelectionBackColor = Color.Red;
            }
            else
            {
                SplitBookingCel.Style.BackColor = Color.Green;
                SplitBookingCel.Style.SelectionBackColor = Color.Green;
            }
            // REPO Color.Thistle
            // EXPORT Color.PowderBlue
            switch (ServiceCodeCel.Value)
            {
                case "BAG":
                    {
                        ServiceCodeCel.Style.SelectionBackColor = Color.Olive;
                        ServiceCodeCel.Style.BackColor = Color.DarkKhaki;
                        break;
                    }

                case "BGR":
                    {
                        ServiceCodeCel.Style.SelectionBackColor = Color.DarkGoldenrod;
                        ServiceCodeCel.Style.BackColor = Color.Goldenrod;
                        break;
                    }

                case "BLK":
                    {
                        ServiceCodeCel.Style.SelectionBackColor = Color.DarkKhaki;
                        ServiceCodeCel.Style.BackColor = Color.DarkSeaGreen;
                        break;
                    }
            }

            switch (BookingTypeCel.Value)
            {
                case "EXPORT":
                    {
                        BookingTypeCel.Style.SelectionBackColor = Color.Sienna;
                        BookingTypeCel.Style.BackColor = Color.Chocolate;
                        break;
                    }

                case "IMPORT":
                    {
                        BookingTypeCel.Style.SelectionBackColor = Color.DarkGoldenrod;
                        BookingTypeCel.Style.BackColor = Color.Goldenrod;
                        break;
                    }

                case "REPO":
                    {
                        BookingTypeCel.Style.SelectionBackColor = Color.Chocolate;
                        BookingTypeCel.Style.BackColor = Color.Peru;
                        break;
                    }
            }
        }

        private void dgvBookings_SelectionChanged(object sender, EventArgs e)
        {
            bool isTabEvent = My.MyProject.Forms.FrmParentScreen.isTabEvent;
            if (dgvBookings.Rows.Count > 0 && !firstLoad && !isTabEvent && dgvBookings.CurrentCell.ColumnIndex != 0)
            {
                FocusedBookingObj = (VW_Booking)dgvBookings.CurrentRow.DataBoundItem;
                populateDgv(FocusedBookingObj.BookingNumber);
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
            var listOfMb = new List<int>();
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
                        EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, "UnitId: " + muAsn.AssignmentId.ToString() + " | MbId: " + muAsn.MinibookingId.ToString(), "UNASSIGN", "UNIT", "Storage Unit Source " + muAsn.MiniUnitNumber + " unassigned from booking " + muAsn.BookingNumber);
                    }
                    else
                    {
                        EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, "UnitId: " + muAsn.AssignmentId.ToString() + " | MbId: " + muAsn.MinibookingId.ToString(), "UNASSIGN", "UNIT", "Unit Source " + muAsn.MiniUnitNumber + " unassigned from booking " + muAsn.BookingNumber);
                    }

                    if (!listOfMb.Contains(muAsn.MinibookingId))
                    {
                        listOfMb.Add(muAsn.MinibookingId);
                    }
                }
            }

            foreach (var id in listOfMb)
            {
                var cep = new CeresExcelPendingSync();
                cep.RecordId = id;
                cep.EmployeeId = My.MyProject.Forms.FrmLoginWindow._userID;
                cep.SyncType = "UNIT ASSIGNMENT";
                cep.ExtraInfo = "";
                cep.CurrentStatus = "QUEUE";
                cep.QtyOfAttempts = 0;
                cep.SyncMessage = "ADDED TO QUEUE";
                cep.CreatedAt = DateAndTime.Now;
                CeresExcService.AddOrUpdate(cep);
            }

            dgvBookingUnit.DataSource = MinibookingMiniUnitAssignmentService.GetByBookingNumber(FocusedBookingObj.BookingNumber);
            MdlLoadingSetting.waitForm.Close();
            if (isUnassigned)
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Sucess!", "Unit source(s) unassigned with success!", this);
            }
        }

        private void CheckButtons()
        {
            int NumberOfSelected = 0;
            selectedBookings.Clear();
            foreach (DataGridViewRow col in dgvBookings.Rows)
            {
                if (!Information.IsNothing(col.Cells[0].Value) && col.Cells[0].Value.Equals("✔"))
                {
                    NumberOfSelected += 1;
                    var bk = new VW_Booking();
                    bk = (VW_Booking)col.DataBoundItem;
                    selectedBookings.Add(bk);
                }
            }

            // updateButton.Enabled = False
            btnActivateDeactivateBooking.Enabled = false;
            btnSplit.Enabled = false;
            asnUnitSourcesButton.Enabled = false;
            btnUpdateCarrier.Enabled = false;
            if (NumberOfSelected == 1)
            {
                btnActivateDeactivateBooking.Enabled = true;
                updateButton.Enabled = true;
                btnSplit.Enabled = true;
                asnUnitSourcesButton.Enabled = true;
                btnUpdateCarrier.Enabled = true;
            }
            else if (NumberOfSelected > 1)
            {
                updateButton.Enabled = true;
                asnUnitSourcesButton.Enabled = true;
                btnUpdateCarrier.Enabled = true;
            }

            lblQtySelected.Text = selectedBookings.Count.ToString();
        }

        private void btnUpdateCarrier_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmEditMBsCarrierOut.populateGrid(selectedBookings);
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmEditMBsCarrierOut, this);
            BKListAll = BusinessLayer.WTC_Ceres.BookingService.GetAllVW();
            BKList = BKListAll.Where(b => b.ActiveBooking == activeToggleSwitch.Value).ToList();
            VWBookingBindingSource.DataSource = BKList;
            VWBookingBindingSource.DataSource = BKList;
            selectedBookings.Clear();
            CheckButtons();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (!firstLoad)
            {
                if (timer.Interval >= 300 & timer.Interval < 600)
                {
                    timer.Stop();
                    selectedBookings.Clear();
                    firstLoad = true;
                    if (tgFilter.Value == true)
                    {
                        var list = BKList.Where(b => b.BookingNumber.ToUpper().Contains(tbBooking.Text) & b.BookingType.ToUpper().Contains(tbType.Text) & b.CustomerName.ToUpper().Contains(tbCustomer.Text) & b.ForwarderName.ToUpper().Contains(tbForwarder.Text) & b.ServiceCode.ToUpper().Contains(tbService.Text) & b.SSLineCode.ToUpper().Contains(tbSSLine.Text) & b.ERDStr.ToUpper().Contains(tbERD.Text) & b.LRDStr.ToUpper().Contains(tbLRD.Text) & b.TerminalName.ToUpper().Contains(tbDock.Text) & b.VesselName.ToUpper().Contains(tbVessel.Text) & b.SplitBooking.ToUpper().Contains(tbSplit.Text) & b.DestAddrStr.Contains(tbDestination.Text) & b.BkCarrierOutCode.ToUpper().Contains(tbCarrier.Text)).ToList();
                        VWBookingBindingSource.DataSource = list;
                    }
                    else
                    {
                        foreach (DataGridViewRow row in dgvBookings.Rows)
                        {
                            // Dim lastCharacters As String = row.Cells[1).Value.ToString.
                            if (row.Cells[1].Value.ToString().EndsWith(tbBooking.Text) && !string.IsNullOrEmpty(Strings.Trim(tbBooking.Text)))
                            {
                                dgvBookings.CurrentCell = row.Cells[1];
                            }
                        }
                    }

                    firstLoad = false;
                }

                CheckButtons();
            }
        }

        private void dgvMinibooking_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var isClosed = dgvMinibooking.Rows[e.RowIndex].Cells["isClosedMBSrt"];
            var canNumb = dgvMinibooking.Rows[e.RowIndex].Cells["MinibookingNumber"];
            var numbOfCans = dgvMinibooking.Rows[e.RowIndex].Cells["NumberOfContainer"];
            var holdMb = dgvMinibooking.Rows[e.RowIndex].Cells["HoldMinibookingStr"];
            isClosed.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            holdMb.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            isClosed.Style.Font = new Font(Font, FontStyle.Bold);
            holdMb.Style.Font = new Font(Font, FontStyle.Bold);
            numbOfCans.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            numbOfCans.Style.Font = new Font(Font, FontStyle.Bold);
            canNumb.Style.Font = new Font(Font, FontStyle.Bold);
            isClosed.Style.ForeColor = Color.White;
            if (isClosed.Value.Equals("CLOSED"))
            {
                isClosed.Style.BackColor = Color.Red;
                isClosed.Style.SelectionBackColor = Color.Red;
            }
            else
            {
                isClosed.Style.BackColor = Color.Green;
                isClosed.Style.SelectionBackColor = Color.Green;
            }

            if (holdMb.Value.Equals("HOLD"))
            {
                holdMb.Style.ForeColor = Color.White;
                holdMb.Style.SelectionForeColor = Color.White;
                holdMb.Style.BackColor = Color.DarkOrange;
                holdMb.Style.SelectionBackColor = Color.DarkOrange;
            }
        }

        private void FrmBookingList_Load(object sender, EventArgs e)
        {
            //      My.MyProject.Forms.FrmParentScreen.showLOadForm();
            firstLoad = true;
            shouldRefresh = true;
            if (BKListAll.Count == 0)
            {
                BKListAll = BusinessLayer.WTC_Ceres.BookingService.GetAllVW();
            }

            BKList = BKListAll.Where(b => b.ActiveBooking == activeToggleSwitch.Value).ToList();
            VWBookingBindingSource.DataSource = BKList;
            CheckButtons();
            timer.Interval = 300;
            firstLoad = false;
            //   My.MyProject.Forms.FrmParentScreen.HideLoadForm();
        }
    }
}