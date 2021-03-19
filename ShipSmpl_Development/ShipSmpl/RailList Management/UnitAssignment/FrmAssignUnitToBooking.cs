using BusinessLayer;
using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class frmAssignUnitToBooking
    {
        public frmAssignUnitToBooking()
        {
            InitializeComponent();
            _btnCancel.Name = "btnCancel";
            _txtBookingNumber.Name = "txtBookingNumber";
            _btnAssignBooking.Name = "btnAssignBooking";
            _closeFlatButton.Name = "closeFlatButton";
            _dgvAllBookings.Name = "dgvAllBookings";
            _dgvMiniUnit.Name = "dgvMiniUnit";
            _btnBalToStorage.Name = "btnBalToStorage";
            _btnRemoveUnit.Name = "btnRemoveUnit";
        }

        private List<string> SelectedCargosList = new List<string>();
        public DataTable mbMU = new DataTable();
        private int numbSelectMB = 0;
        private int RecordKey;
        private MiniUnitService muService = new MiniUnitService();
        private List<string> shouldNotAssignList = new List<string>();
        private CeresExcelPendingSyncService CeresExcService = new CeresExcelPendingSyncService();
        private object numbSelectMU = 0;
        public bool shouldChangeCustomer;
        private string[] _strMiniUnitIdList;

        public string[] strMiniUnitIdList
        {
            get
            {
                return _strMiniUnitIdList;
            }

            set
            {
                _strMiniUnitIdList = value;
            }
        }

        public object get_strMiniUnitIdItem(int i)
        {
            return _strMiniUnitIdList[i];
        }

        public void set_strMiniUnitIdItem(int i, object value)
        {
            _strMiniUnitIdList[i] = Conversions.ToString(value);
        }

        private void frmAssignUnitToBooking_Load(object sender, EventArgs e)
        {
            LoadForm();
            Timer1.Interval = 300;
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private void closeLabel_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.frmMiniUnitToAssign.selectedMUID.Clear();
            My.MyProject.Forms.FrmRailList.LoadForm(true);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.frmMiniUnitToAssign.selectedMUID.Clear();
            My.MyProject.Forms.FrmRailList.LoadForm(true);
            Close();
        }

        private void dgvAllBookings_SelectionChanged(object sender, EventArgs e)
        {
            var mbID = default(int);
            if (dgvAllBookings.Rows.Count > 0)
            {
                try
                {
                    VW_BookingMinibooking mbRow = (VW_BookingMinibooking)dgvAllBookings.CurrentRow.DataBoundItem;
                    mbID = mbRow.MiniBookingId;
                }
                catch
                {
                }
            }
            else
            {
                mbID = 0;
            }

            getCmdyAndGrades(mbID);
        }

        private void dgvMiniUnit_SelectionChanged(object sender, EventArgs e)
        {
            getAsnBookings();
        }

        private void btnSearchBooking_Click(object sender, EventArgs e)
        {
            this.LoadGridMiniBooking(txtBookingNumber.Text);
        }

        private void dgvAllBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                bool value = Conversions.ToBoolean(dgvAllBookings.Rows[e.RowIndex].Cells[0].Value);
                VW_BookingMinibooking mbRow;
                VW_UnitSourceMiniUnit muRow;
                mbRow = (VW_BookingMinibooking)dgvAllBookings.Rows[e.RowIndex].DataBoundItem;
                if (value == false)
                {
                    dgvAllBookings.Rows[e.RowIndex].Cells[0].Value = true;
                    numbSelectMU = +1;
                    // selectedUnits.Add(muID, MUSource)

                    // Check if mini unit is already assigned to mini booking
                    for (int i = 0, loopTo = dgvMiniUnit.Rows.Count - 1; i <= loopTo; i++)
                    {
                        muRow = (VW_UnitSourceMiniUnit)dgvMiniUnit.Rows[i].DataBoundItem;

                        // check if mu was already assigned
                        if (Information.IsNothing(muRow.CommodityId) || muRow.CommodityId == 0)
                        {
                            var result = My.MyProject.Forms.MessageBoxCeresYesNo.ShowDialog("Warning:", "There's no commodity added to the unit '" + muRow.MiniunitNumber + "' Yet. Would you like to add it now? " + "If No is selected, the unit will not be added to the booking", My.Resources.Resources.caution, this);
                            if (result == DialogResult.Yes)
                            {
                                My.MyProject.Forms.FrmEditAddRailList.isNewRecord = false;
                                var unit = UnitSourceService.GetVWById(muRow.UnitSourceId);
                                var unitList = new List<VW_UnitSource>();
                                unitList.Add(unit);
                                My.MyProject.Forms.FrmEditAddRailList.isMultiEdit = false;
                                My.MyProject.Forms.FrmEditAddRailList.isNewRecord = false;
                                My.MyProject.Forms.FrmEditAddRailList.LoadForm(unitList);
                                Close();
                                MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmEditAddRailList, My.MyProject.Forms.FrmParentScreen);
                            }
                            else
                            {
                                shouldNotAssignList.Add(muRow.ToString() + "|" + mbRow.MiniBookingId.ToString());
                            }
                        }
                        // If cmdty and grade doesnt exist in mb, ask if should add.

                        else if (MdlBookingManagement.miniUnitMissingCommodity(mbRow.MiniBookingId, muRow.CommodityId, muRow.GradeId))
                        {
                            var result = My.MyProject.Forms.MessageBoxCeresYesNo.ShowDialog("Commodity and Rate doesn't match", "The commodity and grade of the unit '" + muRow.MiniunitNumber + "' (" + muRow.GradeCode + " " + muRow.CommodityCode + ") is not added to the booking '" + mbRow.BookingNumber + "'. Would you like to add it now? " + "If No is selected, the unit will not be added to the booking", My.Resources.Resources.caution, this);
                            if (result == DialogResult.Yes)
                            {
                                MdlBookingManagement.saveBkgCommodity(mbRow.MiniBookingId, muRow.CommodityId, muRow.GradeId);
                                getCmdyAndGrades(mbRow.MiniBookingId);
                                // muRow =
                                //VWUnitSourceMiniUnitBindingSource.DataSource.Item(muRow) = MiniUnitService.GetVWByMUId(muRow.MiniUnitId);
                            }
                            else
                            {
                                shouldNotAssignList.Add(muRow.MiniUnitId.ToString() + "|" + mbRow.MiniBookingId.ToString());
                            }
                        }
                        else if (MdlBookingManagement.miniUnitAlreadyAssigned(muRow.MiniUnitId, mbRow.MiniBookingId, Conversions.ToBoolean(0)))
                        {
                            shouldNotAssignList.Add(muRow.MiniUnitId.ToString() + "|" + mbRow.MiniBookingId.ToString());
                            My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Unit source already added to booking", "Selected Unit source is already added to the booking " + mbRow.BookingNumber + ", so it will not be added again.", this);
                        }
                        // If cmdty and grade doesnt exist in mb, ask if should add.

                        if (mbRow.CustomerId != muRow.CustomerId)
                        {
                            var result = My.MyProject.Forms.MessageBoxCustomerMatchingWarning.ShowDialog(mbRow, muRow, this);
                            if (result == DialogResult.Yes & shouldChangeCustomer == true)
                            {
                                muRow.CustomerId = mbRow.CustomerId;
                                MdlBookingManagement.updateCustomer(MiniUnitService.GetById(muRow.MiniUnitId));
                            }
                            else
                            {
                                shouldNotAssignList.Add(muRow.MiniUnitId.ToString() + "|" + mbRow.MiniBookingId.ToString());
                            }
                        }
                    }
                }
                else
                {
                    dgvAllBookings.Rows[e.RowIndex].Cells[0].Value = false;
                    numbSelectMU = -1;
                    for (int i = 0, loopTo1 = dgvMiniUnit.Rows.Count - 1; i <= loopTo1; i++)
                    {
                        muRow = (VW_UnitSourceMiniUnit)dgvMiniUnit.Rows[i].DataBoundItem;
                        shouldNotAssignList.Remove(muRow.MiniUnitId.ToString() + "|" + mbRow.MiniBookingId.ToString());
                    }
                }
            }

            checkAsnButton();
        }

        private void btnAssignBooking_Click(object sender, EventArgs e)
        {
            assignUnitsToBookings();
        }

        private void txtBookingNumber_TextChanged(object sender, EventArgs e)
        {
            // LoadGridMiniBooking(txtBookingNumber.Text)
            Timer1.Stop();
            Timer1.Start();
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private void LoadForm()
        {
            txtBookingNumber.Text = "";
            // RecordKey = FrmRailList.selectedRecordKey(0)
            // LoadGridMiniUnit(RecordKey)
            LoadGridMiniBooking("");
        }

        private void checkAsnButton()
        {
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectGreater(numbSelectMU, 0, false)))
            {
                btnAssignBooking.Enabled = true;
            }
            else
            {
                btnAssignBooking.Enabled = false;
            }

            if (dgvMiniUnit.Rows.Count == 0)
            {
                btnAssignBooking.Enabled = false;
                btnRemoveUnit.Enabled = false;
                btnBalToStorage.Enabled = false;
            }
            else
            {
                btnAssignBooking.Enabled = true;
                btnRemoveUnit.Enabled = true;
                btnBalToStorage.Enabled = true;
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private void LoadGridMiniBooking(string BookingNumber)
        {
            VW_UnitSourceMiniUnit muRow = (VW_UnitSourceMiniUnit)dgvMiniUnit.Rows[0].DataBoundItem;
            SelectedCargosList.Clear();
            if (muRow.CargoTypeCode.Equals("BAG"))
            {
                SelectedCargosList.Add("BAG");
            }
            else
            {
                SelectedCargosList.Add("BLK");
                SelectedCargosList.Add("BGR");
            }

            VWBookingMinibooking.DataSource = MinibookingService.GetJointBookingToAsnByFilter(muRow.CustomerName, SelectedCargosList, txtBookingNumber.Text);
            shouldNotAssignList.Clear();
            checkAsnButton();
        }

        private void getMatchBooking()
        {

            // Dim muRow As VW_UnitSourceMiniUnit =  For Each row As DataGridViewRow In dgvMiniUnits.Rows
            // If row.Cells(1).Value.ToString.Contains(tbSearchUnits.Text) Then
            // dgvMiniUnits.CurrentCell = row.Cells(1)
            // End If

            // Next .Rows(0).DataBoundItem
            // VWBookingMinibooking.DataSource = MinibookingService.GetJointBookingToAsnByFilter(muRow.CustomerName, SelectedCargosList, txtBookingNumber.Text)

            foreach (DataGridViewRow row in dgvAllBookings.Rows)
            {
                if (row.Cells[1].Value.ToString().Contains(txtBookingNumber.Text))
                {
                    dgvAllBookings.CurrentCell = row.Cells[1];
                }
            }
        }

        private void getCmdyAndGrades(int mbID)
        {
            VWMinibookingCommodityBindingSource.DataSource = MinibookingCommodityService.GetMinibookingCommodityByMbId(mbID);
        }

        private void assignUnitsToBookings()
        {
            MdlLoadingSetting.waitForm.Show();
            AssignUnitsToBooking();
            // AssignUnitsToBookingsExcel()

            shouldNotAssignList.Clear();
            checkAsnButton();
            MdlLoadingSetting.waitForm.Close();
            var resultDialog = My.MyProject.Forms.MessageBoxCeresYesNo.ShowDialog("Success!", "The units were assigned to the bookings with success. Would you like to keep assigning?", My.Resources.Resources.icon_available, this);
            getAsnBookings();
            if (resultDialog == DialogResult.No)
            {
                Close();
            }
        }

        private void AssignUnitsToBooking()
        {
            string muIDmbID;
            int railListID = 0;
            var bus = new MinibookingMiniUnitAssignmentService();
            VW_UnitSourceMiniUnit muRow;
            var mbRow = default(VW_BookingMinibooking);
            for (int i = 0, loopTo = dgvMiniUnit.Rows.Count - 1; i <= loopTo; i++)
            {
                muRow = (VW_UnitSourceMiniUnit)dgvMiniUnit.Rows[i].DataBoundItem;
                railListID = (int)muRow.RecordKey;
                for (int s = 0, loopTo1 = dgvAllBookings.Rows.Count - 1; s <= loopTo1; s++)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dgvAllBookings.Rows[s].Cells[0].Value, true, false)))
                    {
                        mbRow = (VW_BookingMinibooking)dgvAllBookings.Rows[s].DataBoundItem;
                        muIDmbID = muRow.MiniUnitId.ToString() + "|" + mbRow.MiniBookingId.ToString();
                        if (!shouldNotAssignList.Contains(muIDmbID))
                        {
                            bus.Insert(mbRow.MiniBookingId, muRow.MiniUnitId);
                            EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, "UnitId: " + muRow.MiniUnitId.ToString() + " | MbId: " + mbRow.MiniBookingId.ToString(), "ASSIGN", "UNIT", "Unit Source " + muRow.MiniunitNumber + " assigned to booking " + mbRow.BookingNumber);
                        }
                    }
                }

                var cep = new CeresExcelPendingSync();
                cep.RecordId = mbRow.MiniBookingId;
                cep.EmployeeId = My.MyProject.Forms.FrmLoginWindow._userID;
                cep.SyncType = "UNIT ASSIGNMENT";
                cep.ExtraInfo = "";
                cep.CurrentStatus = "QUEUE";
                cep.QtyOfAttempts = 0;
                cep.SyncMessage = "ADDED TO QUEUE";
                cep.CreatedAt = DateAndTime.Now;
                CeresExcService.AddOrUpdate(cep);
            }
        }

        // Private Sub AssignUnitsToBookingsExcel()

        // Dim miniUnits As List(Of VW_MinibookingMiniUnitAssignment), miniUnitIds As New List(Of Integer),
        // miniBookingIds As New Dictionary(Of Integer, String), muRow As VW_UnitSourceMiniUnit, mbRow As VW_BookingMinibooking

        // Dim muIDmbID As String, railListID As Integer = 0, bus As New MinibookingMiniUnitAssignmentService
        // For i = 0 To dgvMiniUnit.Rows.Count - 1

        // muRow = dgvMiniUnit.Rows(i).DataBoundItem
        // railListID = muRow.RecordKey
        // For s = 0 To dgvAllBookings.Rows.Count - 1
        // If dgvAllBookings.Rows(s).Cells(0).Value = True Then
        // mbRow = dgvAllBookings.Rows(s).DataBoundItem

        // muIDmbID = muRow.MiniUnitId.ToString + "|" + mbRow.MiniBookingId.ToString

        // If Not shouldNotAssignList.Contains(muIDmbID) Then
        // If Not miniBookingIds.ContainsKey(mbRow.MiniBookingId) Then
        // miniBookingIds.Add(mbRow.MiniBookingId, mbRow.BookingNumber)
        // End If
        // End If

        // End If
        // Next
        // Next

        // 'For Each mb In miniBookingIds
        // '    miniUnits = MinibookingMiniUnitAssignmentService.GetByMiniBookingId(mb.Key)
        // '    updateUnitsInExcelFile(mb.Value, miniUnits)
        // 'Next

        // 'getAsnUnits()

        // End Sub

        private void getAsnBookings()
        {
            if (dgvMiniUnit.Rows.Count > 0)
            {
                int index = dgvMiniUnit.CurrentRow.Index;
                var newRowBalToStorage = new VW_MinibookingMiniUnitAssignment();
                VW_UnitSourceMiniUnit mu = (VW_UnitSourceMiniUnit)dgvMiniUnit.CurrentRow.DataBoundItem;
                var mbmuasnList = MinibookingMiniUnitAssignmentService.GetByMiniUnitId(mu.MiniUnitId);
                if (mu.BalanceToStorageAllowed == true == true)
                {
                    newRowBalToStorage.BookingNumber = "BAL. TO STORAGE";
                    mbmuasnList.Add(newRowBalToStorage);
                    btnBalToStorage.Text = "RM. BAL. TO STORAGE";
                }
                else
                {
                    btnBalToStorage.Text = "BAL. TO STORAGE";
                }

                VWMinibookingMiniUnitAssignmentBindingSource.DataSource = mbmuasnList;
            }
            else
            {
                VWMinibookingMiniUnitAssignmentBindingSource.DataSource = MinibookingMiniUnitAssignmentService.GetByMiniUnitId(0);
                dgvAsnBookings.DataSource = VWMinibookingMiniUnitAssignmentBindingSource;
            }
        }

        private void btnRemoveUnit_Click(object sender, EventArgs e)
        {
            if (dgvMiniUnit.Rows.Count > 0)
            {
                VW_UnitSourceMiniUnit unitRow;
                unitRow = (VW_UnitSourceMiniUnit)dgvMiniUnit.CurrentRow.DataBoundItem;
                VWUnitSourceMiniUnitBindingSource.Remove(unitRow);
                dgvMiniUnit.DataSource = VWUnitSourceMiniUnitBindingSource;
            }

            checkAsnButton();
        }

        private void dgvMiniUnits_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

            // Dim BaToStorage = dgvMiniUnits.Rows(e.RowIndex).Cells("BalToStorageBtn")
            var BalanceInstruxCode = dgvMiniUnit.Rows[e.RowIndex].Cells["BalanceInstruxCode"];
            BalanceInstruxCode.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            BalanceInstruxCode.Style.Font = new Font(Font, FontStyle.Bold);
            if (BalanceInstruxCode.Value.Equals("BLTS"))
            {
                BalanceInstruxCode.Style.BackColor = Color.OrangeRed;
                BalanceInstruxCode.Style.SelectionBackColor = Color.OrangeRed;
            }
            else
            {
                BalanceInstruxCode.Style.BackColor = Color.White;
                BalanceInstruxCode.Style.SelectionBackColor = Color.Gray;
            }

            BalanceInstruxCode.Style.ForeColor = Color.White;
            BalanceInstruxCode.Style.SelectionForeColor = Color.White;
        }

        private void btnBalToStorage_Click(object sender, EventArgs e)
        {
            VW_UnitSourceMiniUnit miniUnitRow = (VW_UnitSourceMiniUnit)dgvMiniUnit.CurrentRow.DataBoundItem;
            string message;
            string titleMessage;
            if (miniUnitRow.BalanceToStorageAllowed == false == true)
            {
                titleMessage = "Balance to storage:";
                message = "The remaining balance of unit " + miniUnitRow.MiniunitNumber + " WILL be send to storage at the end of transload." + Constants.vbNewLine + "Confirm balance to storage?";
            }
            else
            {
                titleMessage = "Remove balance to storage:";
                message = "The remaining balance of unit " + miniUnitRow.MiniunitNumber + " WILL NOT be send to storage at the end of transload." + Constants.vbNewLine + "Confirm remove balance to storage?";
            }

            var result = My.MyProject.Forms.MessageBoxCeresYesNo.ShowDialog(titleMessage, message, My.Resources.Resources.warning, this);
            if (result == DialogResult.Yes)
            {
                if (miniUnitRow.BalanceToStorageAllowed == false == true)
                {
                    muService.UpdateBalanceAllowedStorage(miniUnitRow.MiniUnitId, true);
                    miniUnitRow.BalanceInstruxCode = "BLTS";
                    miniUnitRow.BalanceToStorageAllowed = true;
                }
                else
                {
                    muService.UpdateBalanceAllowedStorage(miniUnitRow.MiniUnitId, false);
                    miniUnitRow.BalanceInstruxCode = "";
                    miniUnitRow.BalanceToStorageAllowed = false;
                }

                getAsnBookings();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (Timer1.Interval >= 300 & Timer1.Interval < 600)
            {
                Timer1.Stop();
                getMatchBooking();
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}