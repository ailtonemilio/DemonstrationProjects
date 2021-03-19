using BusinessLayer.WTC_Ceres;
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
    public partial class FrmAssignToUnits
    {
        public FrmAssignToUnits()
        {
            InitializeComponent();
            _cancelButton.Name = "cancelButton";
            _closeFlatButton.Name = "closeFlatButton";
            _dgvSelectedBkg.Name = "dgvSelectedBkg";
            _assignBunifuButton1.Name = "assignBunifuButton1";
            _tbSearchUnits.Name = "tbSearchUnits";
            _btnRemoveMB.Name = "btnRemoveMB";
            _dgvMiniUnits.Name = "dgvMiniUnits";
            _tbSearchStorageUnit.Name = "tbSearchStorageUnit";
            _dgvStorageUnits.Name = "dgvStorageUnits";
            _tbCargoType.Name = "tbCargoType";
            _tbType.Name = "tbType";
        }

        private DatabaseHelperCeres dbCeres = new DatabaseHelperCeres();
        private DataTable miniUnits = new DataTable();
        private MiniUnitService muService = new MiniUnitService();
        private int numbSelectMU = 0;
        private List<string> BkServicesList = new List<string>();
        private CeresExcelPendingSyncService CeresExcService = new CeresExcelPendingSyncService();
        private List<VW_UnitSourceMiniUnit> UnitMUList = new List<VW_UnitSourceMiniUnit>();

        // Dim selectedUnits As New Dictionary(Of Int32, String)
        private DataTable commoditiesDT = new DataTable();
        private DataTable companiesDT = new DataTable();
        private DataTable gradesDT = new DataTable();
        public bool shouldChangeCustomer;
        public List<VW_BookingMinibooking> OriginalMBSelectedList = new List<VW_BookingMinibooking>();

        // ------------------------------------Of MiniUnitID, MiniBookingID
        public List<string> shouldNotAssignList = new List<string>();
        public List<string> shouldNotAssignStorageList = new List<string>();

        private void FrmAssignToUnits_Load(object sender, EventArgs e)
        {
            numbSelectMU = 0;
            Timer1.Interval = 300;
            shouldNotAssignList.Clear();
            shouldNotAssignStorageList.Clear();
            VWBookingMinibooking.DataSource = OriginalMBSelectedList;
            populateMiniUnits();
        }

        private void populateMiniUnits()
        {
            BkServicesList.Clear();
            if (OriginalMBSelectedList.Count > 0)
            {
                var selectedMBRow = OriginalMBSelectedList[0];
                if (selectedMBRow.ServiceCode.Equals("BAG"))
                {
                    BkServicesList.Add("BAG");
                }
                else
                {
                    BkServicesList.Add("BLK");
                    BkServicesList.Add("OTHER");
                }

                UnitMUList = VW_UnitSOurceMiniUnitService.GetByFilter(selectedMBRow.CustomerName, BkServicesList, "");
                VWUnitSourceMiniUnitBindingSource.DataSource = UnitMUList;
                VWGrainUnitStorageBindingSource.DataSource = GrainInventoryService.GetAllGrainInventoryUnitsByFilter(selectedMBRow.CustomerName, BkServicesList, Strings.Trim(tbSearchStorageUnit.Text));
            }
        }

        private void miniUnitsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            object selectedRow;
            bool value;
            DataGridView focusedDgv;
            int mbId;
            VW_BookingMinibooking selectedMBRow;
            if (e.ColumnIndex == 0)
            {
                if (tabUnits.SelectedIndex == 0)
                {
                    value = Conversions.ToBoolean(dgvMiniUnits.Rows[e.RowIndex].Cells[0].Value);
                    selectedRow = new VW_UnitSourceMiniUnit();
                    selectedRow = (VW_UnitSourceMiniUnit)dgvMiniUnits.Rows[e.RowIndex].DataBoundItem;
                    focusedDgv = dgvMiniUnits;
                }
                else
                {
                    value = Conversions.ToBoolean(dgvStorageUnits.Rows[e.RowIndex].Cells[0].Value);
                    selectedRow = new VW_GrainUnitStorage();
                    selectedRow = (VW_GrainUnitStorage)dgvStorageUnits.Rows[e.RowIndex].DataBoundItem;
                    focusedDgv = dgvStorageUnits;
                }

                if (value == false)
                {
                    focusedDgv.Rows[e.RowIndex].Cells[0].Value = true;
                    numbSelectMU += 1;
                    checkCmdtyAndCustomer(selectedRow);
                }
                else
                {
                    focusedDgv.Rows[e.RowIndex].Cells[0].Value = false;
                    numbSelectMU -= 1;
                    for (int i = 0, loopTo = dgvSelectedBkg.Rows.Count - 1; i <= loopTo; i++)
                    {

                        selectedMBRow = new VW_BookingMinibooking();
                        selectedMBRow = (VW_BookingMinibooking)dgvSelectedBkg.Rows[i].DataBoundItem;

                        if (tabUnits.SelectedIndex == 0)
                        {
                            VW_UnitSourceMiniUnit r = new VW_UnitSourceMiniUnit();
                            r = (VW_UnitSourceMiniUnit)dgvMiniUnits.Rows[e.RowIndex].DataBoundItem;

                            shouldNotAssignList.Remove(r.MiniUnitId.ToString() + "|" + selectedMBRow.MiniBookingId.ToString());
                        }
                        else
                        {
                            VW_GrainUnitStorage r = new VW_GrainUnitStorage();
                            r = (VW_GrainUnitStorage)dgvStorageUnits.Rows[e.RowIndex].DataBoundItem;

                            shouldNotAssignStorageList.Remove(r.GrainInventoryId.ToString() + "|" + selectedMBRow.MiniBookingId.ToString());
                        }
                    }
                }

                checkAsnButton();

                // VWUnitSourceMiniUnitBindingSource.DataSource = VW_UnitSOurceMiniUnitService.GetByFilter(selectedMBRow.CustomerName, BkServicesList, "")
            }
        }

        private void checkCmdtyAndCustomer(object unitRow)
        {
            int muID;
            string MUSource;
            string cmdtyName;
            string gradeName;
            int cmdtyId;
            int gradeId;
            VW_BookingMinibooking selectedMBRow;
            VW_UnitSourceMiniUnit mu = (VW_UnitSourceMiniUnit)unitRow;

            VW_GrainUnitStorage g = new VW_GrainUnitStorage();
            try
            {
                g = (VW_GrainUnitStorage)unitRow;
            }
            catch { }
         

            muID = mu.MiniUnitId;


            MUSource = Conversions.ToString(mu.MiniunitNumber);

            // selectedUnits.Add(muID, MUSource)

            cmdtyName = Conversions.ToString(mu.CommodityName);
            gradeName = Conversions.ToString(mu.GradeName);
            cmdtyId = Conversions.ToInteger(mu.CommodityId);
            gradeId = Conversions.ToInteger(mu.GradeId);

            // Check if mini unit is already assigned to mini booking
            for (int i = 0, loopTo = dgvSelectedBkg.Rows.Count - 1; i <= loopTo; i++)
            {
                selectedMBRow = (VW_BookingMinibooking)dgvSelectedBkg.Rows[i].DataBoundItem;
                bool muAlreadyAsn;
                // check if mu was already assigned
                if (tabUnits.SelectedIndex == 0)
                {
                    muAlreadyAsn = MdlBookingManagement.miniUnitAlreadyAssigned(muID, selectedMBRow.MiniBookingId, false);
                }
                else
                {

                    g = (VW_GrainUnitStorage)unitRow;
                    muAlreadyAsn = MdlBookingManagement.miniUnitAlreadyAssigned(g.GrainInvStorageLocationId, selectedMBRow.MiniBookingId, true);
                }

                if (muAlreadyAsn)
                {
                    shouldNotAssignList.Add(muID.ToString() + "|" + selectedMBRow.MiniBookingId.ToString());
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Unit source already added to booking", "Selected Unit source is already added to the booking " + selectedMBRow.BookingNumber + ", so it will not be added again.", this);
                }

                // If cmdty doesn't exist, add to unit source.
                if (cmdtyId == 0)
                {
                    var result = My.MyProject.Forms.MessageBoxCeresYesNo.ShowDialog("Warning:", "There's no commodity added to the unit '" + MUSource + "' Yet. Would you like to add it now? " + "If No is selected, the unit will not be added to the booking", My.Resources.Resources.caution, this);
                    if (result == DialogResult.Yes)
                    {
                        var unit = UnitSourceService.GetVWById(Conversions.ToInteger(mu.UnitSourceId));
                        var unitList = new List<VW_UnitSource>();
                        unitList.Add(unit);
                        My.MyProject.Forms.FrmEditAddRailList.isNewRecord = false;
                        My.MyProject.Forms.FrmEditAddRailList.isMultiEdit = false;
                        My.MyProject.Forms.FrmEditAddRailList.LoadForm(unitList);
                        Close();
                        MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmEditAddRailList, My.MyProject.Forms.FrmParentScreen);
                    }
                    // If tabUnits.SelectedIndex = 0 Then
                    // VWUnitSourceMiniUnitBindingSource.DataSource.Item(unitRow) = MiniUnitService.GetVWByMUId(unitRow.MiniUnitId)
                    // 'VWUnitSourceMiniUnitBindingSource.DataSource

                    // End If
                    else if (tabUnits.SelectedIndex == 0)
                    {
                        shouldNotAssignList.Add(muID.ToString() + "|" + selectedMBRow.MiniBookingId.ToString());
                    }
                    else
                    {

                        g = (VW_GrainUnitStorage)unitRow;
                        shouldNotAssignStorageList.Add(g.GrainInvStorageLocationId.ToString() + "|" + selectedMBRow.MiniBookingId.ToString());
                    }
                }
                // If cmdty and grade doesnt exist in mb, ask if should add.
                else if (MdlBookingManagement.miniUnitMissingCommodity(selectedMBRow.MiniBookingId, cmdtyId, gradeId))
                {
                    var result = My.MyProject.Forms.MessageBoxCeresYesNo.ShowDialog("Commodity and Rate doesn't match", "The commodity and grade of the unit '" + MUSource + "' (" + gradeName + " " + cmdtyName + ") is not added to the booking '" + selectedMBRow.BookingNumber + "'. Would you like to add it now? " + "If No is selected, the unit will not be added to the booking", My.Resources.Resources.caution, this);
                    if (result == DialogResult.Yes)
                    {
                        MdlBookingManagement.saveBkgCommodity(selectedMBRow.MiniBookingId, cmdtyId, gradeId);
                    }
                    else if (tabUnits.SelectedIndex == 0)
                    {
                        shouldNotAssignList.Add(muID.ToString() + "|" + selectedMBRow.MiniBookingId.ToString());
                    }
                    else
                    {

                        shouldNotAssignStorageList.Add(g.GrainInvStorageLocationId.ToString() + "|" + selectedMBRow.MiniBookingId.ToString());
                    }
                }

                if (mu.CustomerId != selectedMBRow.CustomerId)
                {
                    var result = My.MyProject.Forms.MessageBoxCustomerMatchingWarning.ShowDialog(selectedMBRow, unitRow, this);
                    if (result == DialogResult.Yes & shouldChangeCustomer == true)
                    {
                        MdlBookingManagement.updateCustomer(MiniUnitService.GetById(muID));

                        // update muDataGridView
                        VWUnitSourceMiniUnitBindingSource.DataSource = VW_UnitSOurceMiniUnitService.GetByFilter(Conversions.ToString(mu.CustomerName), BkServicesList, Strings.Trim(tbSearchStorageUnit.Text));
                    }
                    else if (tabUnits.SelectedIndex == 0)
                    {
                        shouldNotAssignList.Add(muID.ToString() + "|" + selectedMBRow.MiniBookingId.ToString());
                    }
                    else
                    {
                        shouldNotAssignStorageList.Add(g.GrainInvStorageLocationId.ToString() + "|" + selectedMBRow.MiniBookingId.ToString());
                    }
                }
            }
        }

        private void checkAsnButton()
        {
            if (numbSelectMU > 0)
            {
                assignBunifuButton1.Enabled = true;
            }
            else
            {
                assignBunifuButton1.Enabled = false;
            }

            if (dgvSelectedBkg.Rows.Count == 0)
            {
                assignBunifuButton1.Enabled = false;
            }
        }

        private void findText()
        {
            for (int i = 0, loopTo = dgvMiniUnits.Rows.Count - 1; i <= loopTo; i++)
            {
                if (Conversions.ToBoolean(dgvMiniUnits.Rows[i].Cells[2].Value.ToString().Contains(dgvMiniUnits.Text.ToUpper())))
                {
                    dgvMiniUnits.CurrentCell = dgvMiniUnits.Rows[i].Cells[0];
                    return;
                }
            }
        }

        private void searchBunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            Timer1.Stop();
            Timer1.Start();
        }

        private void getMatchingUnits()
        {
            if (tabUnits.SelectedIndex == 0)
            {
                // Dim selectedMBRow As VW_BookingMinibooking = dgvSelectedBkg.Rows(0).DataBoundItem
                // VWUnitSourceMiniUnitBindingSource.DataSource = VW_UnitSOurceMiniUnitService.GetByFilter(selectedMBRow.CustomerName, BkServicesList, Trim(tbSearchUnits.Text))
                foreach (DataGridViewRow row in dgvMiniUnits.Rows)
                {
                    if (row.Cells[1].Value.ToString().Contains(tbSearchUnits.Text))
                    {
                        dgvMiniUnits.CurrentCell = row.Cells[1];
                    }
                }
            }
            else
            {
                VW_BookingMinibooking selectedMBRow = (VW_BookingMinibooking)dgvSelectedBkg.Rows[0].DataBoundItem;
                VWGrainUnitStorageBindingSource.DataSource = GrainInventoryService.GetAllGrainInventoryUnitsByFilter(selectedMBRow.CustomerName, BkServicesList, Strings.Trim(tbSearchStorageUnit.Text));
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (Timer1.Interval >= 300 & Timer1.Interval < 600)
            {
                Timer1.Stop();
                getMatchingUnits();
            }
        }

        private void closeFlatButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void assignBunifuButton1_Click(object sender, EventArgs e)
        {
            MdlLoadingSetting.waitForm.Show();
            numbSelectMU = 0;
            AssignUnitsToBookings();
            checkAsnButton();
            shouldNotAssignList.Clear();
            shouldNotAssignStorageList.Clear();

            // selectedUnits.Clear()
            assignBunifuButton1.Enabled = false;
            assignBunifuButton1.Refresh();
            // DISPLAY SUCCESS MESSAGE!

            MdlLoadingSetting.waitForm.Close();
            var resultDialog = My.MyProject.Forms.MessageBoxCeresYesNo.ShowDialog("Success!", "The units were assigned to the bookings with success. Would you like to keep assigning?", My.Resources.Resources.icon_available, this);
            populateMiniUnits();
            checkAsnButton();
            if (resultDialog == DialogResult.No)
            {
                Close();
            }
            else
            {
            }
        }

        private void AssignUnitsToBookings()
        {
            string muIDmbID;
            var bus = new MinibookingMiniUnitAssignmentService();
            var gis = new GrainInventoryService();
            VW_BookingMinibooking mbRow;
            VW_UnitSourceMiniUnit unitRowUnit;
            VW_GrainUnitStorage unitRowStorage;
            for (int i = 0, loopTo = dgvSelectedBkg.Rows.Count - 1; i <= loopTo; i++)
            {
                mbRow = (VW_BookingMinibooking)dgvSelectedBkg.Rows[i].DataBoundItem;
                if (tabUnits.SelectedIndex == 0)
                {
                    for (int s = 0, loopTo1 = dgvMiniUnits.Rows.Count - 1; s <= loopTo1; s++)
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dgvMiniUnits.Rows[s].Cells[0].Value, true, false)))
                        {
                            unitRowUnit = (VW_UnitSourceMiniUnit)dgvMiniUnits.Rows[s].DataBoundItem;
                            muIDmbID = unitRowUnit.MiniUnitId.ToString() + "|" + mbRow.MiniBookingId.ToString();

                            // If mini munit key and mini booking key is not on the should not assign list,
                            // then assign unit to bkg
                            if (!shouldNotAssignList.Contains(muIDmbID))
                            {
                                // 'dbCeres.assignUnitsToMiniBkgs(unitID, mbID, bkgNumber, unitNumber, recordKey)
                                bus.Insert(mbRow.MiniBookingId, unitRowUnit.MiniUnitId);
                                EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, "UnitId: " + unitRowUnit.MiniUnitId.ToString() + " | MbId: " + mbRow.MiniBookingId.ToString(), "ASSIGN", "UNIT", "Unit Source " + unitRowUnit.MiniunitNumber + " assigned to booking " + mbRow.BookingNumber);
                            }
                        }
                    }
                }
                else
                {
                    for (int s = 0, loopTo2 = dgvStorageUnits.Rows.Count - 1; s <= loopTo2; s++)
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dgvStorageUnits.Rows[s].Cells[0].Value, true, false)))
                        {
                            unitRowStorage = (VW_GrainUnitStorage)dgvStorageUnits.Rows[s].DataBoundItem;
                            muIDmbID = unitRowStorage.MiniUnitId.ToString() + "|" + mbRow.MiniBookingId.ToString();

                            // If mini munit key and mini booking key is not on the should not assign list,
                            // then assign unit to bkg
                            if (!shouldNotAssignList.Contains(muIDmbID))
                            {
                                gis.InsertGrainInvMinibookingAssignment(mbRow.MiniBookingId, unitRowStorage.GrainInvStorageLocationId, (float)unitRowStorage.QtyInStorage, DateAndTime.Now);
                                gis.InsertGrainInventoryTransaction(unitRowStorage.GrainInventoryId, (int)MdlEnum.TransactionType.ASSIGNMENT, (float)unitRowStorage.QtyInStorage, DateAndTime.Now);
                                gis.InsertGrainInvMinibookingTransaction(mbRow.MiniBookingId, gis.GetLastGrainInventoryTransactionId());
                                EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, "UnitId: " + unitRowStorage.MiniUnitId.ToString() + " | MbId: " + mbRow.MiniBookingId.ToString(), "ASSIGN", "UNIT", "Storage Unit Source " + unitRowStorage.StorageUnitNumber + " assigned to booking " + mbRow.BookingNumber);
                            }
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

            shouldNotAssignList.Clear();
            assignBunifuButton1.Update();
            checkAsnButton();
        }

        private void dgvSelectedBkg_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSelectedBkg.Rows.Count > 0)
            {
                btnRemoveMB.Enabled = true;
                VW_BookingMinibooking mbRow = (VW_BookingMinibooking)dgvSelectedBkg.CurrentRow.DataBoundItem;
                getAsnUnits(mbRow.MiniBookingId);
            }
            else
            {
                checkAsnButton();
                btnRemoveMB.Enabled = false;
                getAsnUnits(0);
            }
        }

        private object AssignedUnits;

        private void getAsnUnits(int mbId)
        {
            var miniUnitAssign = new List<VW_MinibookingMiniUnitAssignment>();
            bool multipleMB;
            string bkgLetter = "";
            miniUnitAssign = MinibookingMiniUnitAssignmentService.GetByMiniBookingId(mbId);
            dgvUnitsAsnToBks.DataSource = miniUnitAssign;
            AssignedUnits = miniUnitAssign;
        }

        private void btnRemoveMB_Click(object sender, EventArgs e)
        {
            if (dgvSelectedBkg.Rows.Count > 0)
            {
                VW_BookingMinibooking selectedRow;
                selectedRow = (VW_BookingMinibooking)dgvSelectedBkg.CurrentRow.DataBoundItem;
                VWBookingMinibooking.Remove(selectedRow);
                dgvSelectedBkg.DataSource = VWBookingMinibooking;
            }
        }

        private void tbCargoType_TextChanged(object sender, EventArgs e)
        {
            var FilteredList = UnitMUList.Where(m => m.CargoType.Contains(tbCargoType.Text) & m.UnitType.Contains(tbType.Text) & m.CommodityGrade.Contains(tbCommodity.Text));
            VWUnitSourceMiniUnitBindingSource.DataSource = FilteredList.ToList();
        }
    }
}