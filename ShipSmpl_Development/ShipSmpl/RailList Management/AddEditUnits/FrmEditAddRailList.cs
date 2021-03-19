using Bunifu.UI.WinForms.BunifuButton;
using Bunifu.UI.WinForms.BunifuTextbox;
using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ShipSmpl
{

    /// <summary>
    /// 
    /// </summary>
    public partial class FrmEditAddRailList
    {
        public FrmEditAddRailList()
        {
            InitializeComponent();
            _txtUnitNumber.Name = "txtUnitNumber";
            _txtSequence.Name = "txtSequence";
            _txtLastLocation.Name = "txtLastLocation";
            _txtETALocation.Name = "txtETALocation";
            _nudDemurageDays.Name = "nudDemurageDays";
            _nudInTransitDays.Name = "nudInTransitDays";
            _cboCargoType.Name = "cboCargoType";
            _cboUnitStatus.Name = "cboUnitStatus";
            _cboUnitType.Name = "cboUnitType";
            _txtTrack.Name = "txtTrack";
            _btnEraseModETALocation.Name = "btnEraseModETALocation";
            _btnEraseModCarrier.Name = "btnEraseModCarrier";
            _txtCarrier.Name = "txtCarrier";
            _btnEraseModOrigin.Name = "btnEraseModOrigin";
            _txtOrigin.Name = "txtOrigin";
            _btnEraseModShipper.Name = "btnEraseModShipper";
            _cboShipper.Name = "cboShipper";
            _btnClearETADate.Name = "btnClearETADate";
            _txtETADate.Name = "txtETADate";
            _btnEraseModETADate.Name = "btnEraseModETADate";
            _btnEraseModlastTraceddate.Name = "btnEraseModlastTraceddate";
            _btnClearLastTraceddate.Name = "btnClearLastTraceddate";
            _dtpLastTraced.Name = "dtpLastTraced";
            _btnEraseLastLocation.Name = "btnEraseLastLocation";
            _nudTotalBilledWeight.Name = "nudTotalBilledWeight";
            _btnEraseModTotalBilled.Name = "btnEraseModTotalBilled";
            _btnClearReleaseDate.Name = "btnClearReleaseDate";
            _btnClearCalldate.Name = "btnClearCalldate";
            _btnClearAvailDate.Name = "btnClearAvailDate";
            _btnClearBillDate.Name = "btnClearBillDate";
            _txtCallDate.Name = "txtCallDate";
            _txtBillDate.Name = "txtBillDate";
            _btnEraseModRelDate.Name = "btnEraseModRelDate";
            _btnEraseAvailableDate.Name = "btnEraseAvailableDate";
            _txtReleaseDate.Name = "txtReleaseDate";
            _txtAvailableDate.Name = "txtAvailableDate";
            _btnEraseModCallDate.Name = "btnEraseModCallDate";
            _btnEraseModBilldate.Name = "btnEraseModBilldate";
            _btnEraseModArrivaldate.Name = "btnEraseModArrivaldate";
            _btnClearArrivalDate.Name = "btnClearArrivalDate";
            _txtArrivalDate.Name = "txtArrivalDate";
            _btnEraseModStatus.Name = "btnEraseModStatus";
            _btnEraseModCargoType.Name = "btnEraseModCargoType";
            _btnEraseModUnitType.Name = "btnEraseModUnitType";
            _cancelButton.Name = "cancelButton";
            _btnSaveInboundCargo.Name = "btnSaveInboundCargo";
            _tbLotNumber.Name = "tbLotNumber";
            _cboGrade.Name = "cboGrade";
            _txtComments.Name = "txtComments";
            _txtLocation.Name = "txtLocation";
            _cboCustomer.Name = "cboCustomer";
            _nudTotalUNBilled.Name = "nudTotalUNBilled";
            _nudPCUNPiecesWeight.Name = "nudPCUNPiecesWeight";
            _rbMT.Name = "rbMT";
            _rbKG.Name = "rbKG";
            _rbLB.Name = "rbLB";
            _nudPCWeight.Name = "nudPCWeight";
            _rbMTPC.Name = "rbMTPC";
            _rbLBPC.Name = "rbLBPC";
            _nudTotalBilled.Name = "nudTotalBilled";
            _previousButton.Name = "previousButton";
            _nextButton.Name = "nextButton";
            _btnAddMiniUnit.Name = "btnAddMiniUnit";
            _btnAssociateBooking.Name = "btnAssociateBooking";
            _btnDeleteMiniUnit.Name = "btnDeleteMiniUnit";
            _btnEraseMod.Name = "btnEraseMod";
            _rmvMultiBk.Name = "rmvMultiBk";
            _btnStartOver.Name = "btnStartOver";
        }

        public YardTabletControls.GeneralFunctions DoFunctions = new YardTabletControls.GeneralFunctions();
        private DatabaseHelperCeres dbCeres = new DatabaseHelperCeres();
        private DataTable serviceTable = new DataTable();
        public DataTable railListRecord = new DataTable();
        private DataTable unitServiceDT;
        private DataRow railListRow;
        public string UnitNumber;
        public int RecordKey;
        public int UnitSourceId;
        private DataTable MUToAssign;

        // Public originalMiniUnitTable As New DataTable
        public DataTable UpDateMiniUnitTable = new DataTable();
        public int focusedMU = 0;
        private int muOrder = 1;
        public bool isNewRecord;
        public bool isMultiEdit;
        private MiniUnit focusedRow;
        private int tempIDMB = 0;
        public int focusedMB = 0;
        private bool isEnableNewUnit;
        private int MiniUnitId;
        private int MiniUnitOrder;
        public string myString;
        private DataTable unitSourceDT = new DataTable();
        public List<MiniUnit> miniUnitDT = new List<MiniUnit>();
        public int focusedMiniUnit = 0;
        private bool firstLoad = true;
        private List<UnitSource> AllUnits = new List<UnitSource>();
        private UnitSource us = new UnitSource();
        private List<VW_UnitSource> originalMultiEditUnitsList = new List<VW_UnitSource>();
        private List<VW_UnitSource> modifiedMultiEditUnitsList = new List<VW_UnitSource>();
        private UnitSourceService usServ = new UnitSourceService();

        // Dim listUSActive As List(Of UnitSourceActive)
        public decimal splitNumber;
        private DataUnitSource clsUnit = new DataUnitSource();
        private bool isModField = true;

        // Variable "Date" Type
        private DateTime ETADate;
        private DateTime LastTraced;
        private DateTime BillDate;
        private DateTime CallDate;
        private DateTime ArrivalDate;
        private DateTime AvailableDate;
        private DateTime ReleaseDate;

        private void FrmEditAddRailList_Load(object sender, EventArgs e)
        {
            AllUnits = UnitSourceService.GetByActiveStatus(Conversions.ToBoolean(1));
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private void cancelButton_Click(object sender, EventArgs e)
        {
            UnitSourceId = 0;
            RecordKey = 0;
            UnitNumber = "";
            Close();
        }

        private void btnAddMiniUnit_Click(object sender, EventArgs e)
        {
            var selectedRow = miniUnitDT[focusedMiniUnit];
            decimal total;
            decimal currentBileld;
            currentBileld = (decimal)selectedRow.TotalBilled;
            if (cboCargoType.Text.Equals("BULK"))
            {
                total = nudTotalBilledWeight.Value;
                My.MyProject.Forms.frmSplitMiniUnit.totalLabel.Text = total.ToString("0.###");
                My.MyProject.Forms.frmSplitMiniUnit.currentMUTotal.Text = currentBileld.ToString("0.###");
            }
            else
            {
                total = nudTotalBilledWeight.Value;
                My.MyProject.Forms.frmSplitMiniUnit.totalLabel.Text = total.ToString("0");
                My.MyProject.Forms.frmSplitMiniUnit.currentMUTotal.Text = currentBileld.ToString("0");
            }

            My.MyProject.Forms.frmSplitMiniUnit.UnitSourceId = UnitSourceId;
            My.MyProject.Forms.frmSplitMiniUnit.RecordKey = RecordKey;
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.frmSplitMiniUnit, this);
            return;
        }

        private void btnAssociateBooking_Click(object sender, EventArgs e)
        {

            // If fieldsGoodToGo() Then
            // selectMiniUnits()
            // populateMUtoAsgn()

            // If MUToAssign.Rows.Count > 1 Then
            // showDialogForm(frmMiniUnitToAssign, Me)
            // Else
            // showDialogForm(frmAssignUnitToBooking, Me)
            // End If
            // Else
            // MessageBoxCeresOK.ShowDialog("Information missing", "Please, check the mandatory fields.", Me)
            // End If

        }

        private void selectMiniUnits()
        {
            string qr;
            string unit = "";
            string unitsFound = "";
            unit = MdlUnits.ReformatCarNumber(Strings.Trim(txtUnitNumber.Text));
            VerifyEmptyDates();

            // 3 - Insert ou Update
            clsUnit.SaveUnitSource(unit, Conversions.ToString(cboUnitStatus.SelectedValue), Conversions.ToString(cboUnitType.SelectedItem), Conversions.ToString(cboCargoType.SelectedValue), txtOrigin.Text, txtCarrier.Text, Conversions.ToInteger(cboShipper.Text), Conversions.ToString(ETADate), txtETALocation.Text, Conversions.ToString(LastTraced), txtLastLocation.Text, txtSequence.Text, txtTrack.Text, nudDemurageDays.Value.ToString(), nudInTransitDays.Value.ToString(), Conversions.ToString(BillDate), Conversions.ToString(CallDate), Conversions.ToString(ArrivalDate), Conversions.ToString(AvailableDate), Conversions.ToString(ReleaseDate), nudTotalBilledWeight.Value.ToString(), nudTotalBilledWeight.Value.ToString(), lblLastUpdate.Text, "1", "1", RecordKey, UnitSourceId);

            // 4 - Get Last UnitSourceId
            if (UnitSourceId == 0)
            {
                // 4.1 - Insert the last MiniUnitId inserted in the table
                SaveUpdateMiniUnit(clsUnit.LastUnitSourceId());
                UnitSourceId = clsUnit.LastUnitSourceId();
            }
            else
            {
                // 4.2 - Insert MiniUnitId
                SaveUpdateMiniUnit(UnitSourceId);
            }

            // Repopulate miniunitDT

            qr = @"select MU.MiniUnitId, US.UnitNumber, Mu.RecordKey, MU.MiniUnitOrder, US.CargoType, MU.CustomerName, MU.CustomerId, MU.CommodityCode, MU.GradeGrade
                            Inner Join UnitSource US on MU.UnitSourceId = US.UnitSourceId
                            where MU.UnitSourceId =" + UnitSourceId.ToString();
            MUToAssign = dbCeres.getDataByQuery(qr);

            // 2 - Verify Date Fields

        }

        private void btnDeleteMiniUnit_Click(object sender, EventArgs e)
        {
            var copyDelete = new List<MiniUnit>();
            DialogResult result;
            string bkLetter = "(" + MdlBookingManagement.digitToLetter(miniUnitDT[focusedMiniUnit].MiniUnitOrder).ToUpper() + ")";
            result = My.MyProject.Forms.MessageBoxCeresYesNo.ShowDialog("Delete Mini Unit:", "Are you sure you want to delete the mini unit: " + txtUnitNumber.Text + bkLetter, My.Resources.Resources.caution, this);
            if (result == DialogResult.Yes)
            {
                {
                    var withBlock = My.MyProject.Forms.FrmModifyMUBilledValues;
                    withBlock.tempDeletedMUDT.Clear();
                    foreach (var item in miniUnitDT)
                        withBlock.tempDeletedMUDT.Add(item);
                    withBlock.tempDeletedMUDT.Remove(miniUnitDT[focusedMiniUnit]);
                    withBlock.loadForm(true);
                    MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmModifyMUBilledValues, this);
                    UpdateMUOrder();
                }
            }
        }

        private void UpdateMUOrder()
        {
            int orderNumb = 1;
            foreach (var mu in miniUnitDT)
            {
                mu.MiniUnitOrder = orderNumb;
                orderNumb += 1;
            }
        }

        private void VerifyEmptyDates()
        {
            if (!txtETADate.CustomFormat.Equals(" "))
            {
                ETADate = txtETADate.Value;
            }
            else
            {
                ETADate = DateTime.MinValue;
            }

            if (!dtpLastTraced.CustomFormat.Equals(" "))
            {
                LastTraced = dtpLastTraced.Value;
            }
            else
            {
                LastTraced = DateTime.MinValue;
            }

            if (!txtBillDate.CustomFormat.Equals(" "))
            {
                BillDate = txtBillDate.Value;
            }
            else
            {
                BillDate = DateTime.MinValue;
            }

            if (!txtCallDate.CustomFormat.Equals(" "))
            {
                CallDate = txtCallDate.Value;
            }
            else
            {
                CallDate = DateTime.MinValue;
            }

            if (!txtArrivalDate.CustomFormat.Equals(" "))
            {
                ArrivalDate = txtArrivalDate.Value;
            }
            else
            {
                ArrivalDate = DateTime.MinValue;
            }

            if (!txtAvailableDate.CustomFormat.Equals(" "))
            {
                AvailableDate = txtAvailableDate.Value;
            }
            else
            {
                AvailableDate = DateTime.MinValue;
            }

            if (!txtReleaseDate.CustomFormat.Equals(" "))
            {
                ReleaseDate = txtReleaseDate.Value;
            }
            else
            {
                ReleaseDate = DateTime.MinValue;
            }
        }

        /// <summary>
        /// Method created to validate the Total of the Unit with the Mini Unit
        /// </summary>
        /// <param name="Total">Fields Main Unit: Total Billed Weight or Total Billed Pieces</param>
        /// <param name="TotalMiniUnit">Fields Mini Unit: M.U. Billed Weight or M.U. Billed Pieces</param>
        /// <returns></returns>
        public bool VerifyTotalWeightAndPieces(decimal Total, decimal TotalMiniUnit)
        {
            bool IsValid = false;
            bool unitAlreadyExist = false;
            if (Total != TotalMiniUnit)
            {
                IsValid = true;
            }

            return IsValid;
        }

        private void btnSaveInboundCargo_Click(object sender, EventArgs e)
        {

            // 1 - Verify Fields
            string unit = MdlUnits.ReformatCarNumber(Strings.Trim(txtUnitNumber.Text));
            if (fieldsGoodToGo() == false)
            {
                return;
            }
            // 2 - Verify Date Fields
            VerifyEmptyDates();

            // 3 - Insert ou Update
            var usServ = new UnitSourceService();
            // My.MyProject.Forms.FrmParentScreen.showLOadForm();
            if (isMultiEdit)
            {
                foreach (var u in modifiedMultiEditUnitsList)
                    SaveUnitSource(u);
            }
            else
            {
                string CarNumber = Strings.Trim(txtUnitNumber.Text);
                if (Strings.Mid(CarNumber, 4, 1) != "U")
                {
                    CarNumber = MdlUnits.ReformatCarNumber(CarNumber);
                }

                us.UnitNumber = CarNumber;
                us.OriginalUnitNumber = Strings.Trim(txtUnitNumber.Text);
                us.UnitStatusId = Conversions.ToInteger(cboUnitStatus.SelectedValue);
                us.UnitType = Conversions.ToString(cboUnitType.SelectedItem);
                us.CargoTypeId = Conversions.ToInteger(cboCargoType.SelectedValue);
                us.OriginLocation = txtOrigin.Text;
                us.UnitLine = txtCarrier.Text;
                us.ETALocation = txtETALocation.Text;
                us.Sequence = txtSequence.Text;
                us.Track = txtTrack.Text;
                us.LastLocation = txtLastLocation.Text;
                us.DemurageDays = (int?)nudDemurageDays.Value;
                us.InTransitDays = (int?)nudInTransitDays.Value;
                us.TotalBilled = (double?)nudTotalBilledWeight.Value;
                us.LastUpdate = DateAndTime.Now;
                us.ActiveUpdates = true;
                us.Active = true;
                us.RecordKey = RecordKey;
                us.CargoDescription = "";
                us.ShipperId = (int?)cboShipper.SelectedValue;
                var minDate = Convert.ToDateTime("01-01-0001");
                if (minDate.Date == ETADate.Date)
                    us.ETADate = default;
                else
                    us.ETADate = ETADate;
                if (minDate.Date == BillDate.Date)
                    us.BillDate = default;
                else
                    us.BillDate = BillDate;
                if (minDate.Date == CallDate.Date)
                    us.CallDate = default;
                else
                    us.CallDate = CallDate;
                if (minDate.Date == AvailableDate.Date)
                    us.AvailableDate = default;
                else
                    us.AvailableDate = AvailableDate;
                if (minDate.Date == ArrivalDate.Date)
                    us.ArrivalDate = default;
                else
                    us.ArrivalDate = ArrivalDate;
                if (minDate.Date == LastTraced.Date)
                    us.LastTraced = default;
                else
                    us.LastTraced = LastTraced;
                if (minDate.Date == ReleaseDate.Date)
                    us.ReleaseDate = default;
                else
                    us.ReleaseDate = ReleaseDate;
                usServ.AddOrUpdate(us);
                UnitSourceId = usServ.GetLastUnitSourceId();
                // 4.2 - Save MiniUnitId
                SaveUpdateMiniUnit(UnitSourceId);
            }

            //    My.MyProject.Forms.FrmParentScreen.HideLoadForm();
            My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Unit Source successfully saved!", "", this);
            My.MyProject.Forms.FrmRailList.RailList1.TakeRailList(My.MyProject.Forms.FrmRailList.FetchRailList(true), true);

            // 6 - Clear All Information and close the Form
            UnitSourceId = 0;
            RecordKey = 0;
            UnitNumber = "";
            Close();
        }

        private void SaveUnitSource(VW_UnitSource selectedUnit)
        {
            us = UnitSourceService.GetById(selectedUnit.UnitSourceId);
            us.UnitStatusId = selectedUnit.UnitStatusId;
            us.UnitType = selectedUnit.UnitType;
            us.OriginLocation = selectedUnit.OriginLocation;
            us.UnitLine = selectedUnit.UnitLine;
            us.ETALocation = selectedUnit.ETALocation;
            us.Sequence = selectedUnit.Sequence;
            us.Track = selectedUnit.Track;
            us.LastLocation = selectedUnit.LastLocation;
            us.DemurageDays = selectedUnit.DemurageDays;
            us.InTransitDays = selectedUnit.InTransitDays;
            us.LastUpdate = DateAndTime.Now;
            us.ActiveUpdates = selectedUnit.ActiveUpdates;
            us.Active = selectedUnit.Active;
            us.RecordKey = selectedUnit.RecordKey;
            us.CargoDescription = selectedUnit.CargoDescription;
            us.ShipperId = selectedUnit.ShipperId;
            us.ETADate = selectedUnit.ETADate;
            us.BillDate = selectedUnit.BillDate;
            us.CallDate = selectedUnit.CallDate;
            us.AvailableDate = selectedUnit.AvailableDate;
            us.ArrivalDate = selectedUnit.ArrivalDate;
            us.LastTraced = selectedUnit.LastTraced;
            us.ReleaseDate = selectedUnit.ReleaseDate;
            bool issaved = usServ.AddOrUpdate(us);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            focusedMiniUnit += 1;
            focusedRow = miniUnitDT[focusedMiniUnit];
            PopulateMU();
            checkArrowButtons();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (focusedMiniUnit > 0)
            {
                focusedMiniUnit -= 1;
            }

            focusedRow = miniUnitDT[focusedMiniUnit];
            PopulateMU();
            checkArrowButtons();
        }

        private void cboService_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnabeDisabeMiniUnitByType(cboCargoType.Text);
            if (miniUnitDT.Count > 1 & firstLoad == false & totalBilledInMUs() != nudTotalBilledWeight.Value & !cboCargoType.Text.Equals(""))
            {
                My.MyProject.Forms.FrmModifyMUBilledValues.loadForm(false);
                MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmModifyMUBilledValues, this);
            }

            if (firstLoad == false)
            {
                clearNotUsedService(cboCargoType.Text);
                PopulateMU();
                EnabeDisabeMiniUnitByType(cboCargoType.Text);
            }
        }

        private void clearNotUsedService(string focusedService)
        {
            foreach (var mu in miniUnitDT)
            {
                if (focusedService.Equals("BULK"))
                {
                    mu.BilledByUnit = 0;
                    mu.BilledByUnitUnitType = "";
                    mu.UnBilledByUnit = 0;
                    mu.UnBilledByUnitUnitType = "";
                }
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public void LoadForm(List<VW_UnitSource> unitList)
        {
            MdlLoadingSetting.waitForm.Show();
            firstLoad = true;
            ClearFields();
            ClearFieldMain();
            miniUnitDT.Clear();
            ClearAllDataTable();
            if (!isMultiEdit)
            {
                if (!Information.IsNothing(unitList))
                {
                    // UnitNumber = unitList(0).UnitNumber
                    UnitSourceId = unitList[0].UnitSourceId;
                }
                else
                {
                    UnitNumber = "";
                }

                txtUnitNumber.Enabled = true;
                nudTotalBilledWeight.Enabled = true;
            }
            else
            {
                UnitNumber = "MULTI EDIT";
                txtUnitNumber.Enabled = false;
                nudTotalBilledWeight.Value = 0m;
                nudTotalBilledWeight.Enabled = false;
                UnitSourceId = 0;
            }

            if (isNewRecord == false)
            {
                lblTitleLastUpdate.Text = "Last Update";
                lblTitleForm.Text = "Edit Unit";
                populateComboBoxes();
                populateComboGradeCommodity();
                focusedMB = 0;
                tempIDMB = 0;

                // 3 - Carregar UnitSource Main
                LoadFieldsByUnitSourceOrRailList();
                if (!isMultiEdit)
                {
                    miniUnitDT = MiniUnitService.GetAllByUSId(UnitSourceId);
                    us = UnitSourceService.GetById(unitList[0].UnitSourceId);
                    btnAddMiniUnit.Enabled = true;
                    btnDeleteMiniUnit.Enabled = true;
                    isEnableNewUnit = true;
                    focusedRow = miniUnitDT[0];
                    PopulateMU();
                    checkArrowButtons();
                    Size = new Size(1618, 804);
                    pnlMultiEdit.Visible = false;
                }
                else
                {
                    Size = new Size(1618, 984);
                    pnlMultiEdit.Visible = true;
                    CreateUnitsCopy(unitList, ref originalMultiEditUnitsList);
                    CreateUnitsCopy(unitList, ref modifiedMultiEditUnitsList);
                    txtUnitNumber.Text = "MULTI EDIT";
                    VWUnitSourceBindingSource.DataSource = modifiedMultiEditUnitsList;
                }
            }

            // 
            else
            {
                us = new UnitSource();
                populateComboBoxes();
                populateComboGradeCommodity();
                lblLastUpdate.Text = "";
                lblTitleLastUpdate.Text = "";
                lblTitleForm.Text = "Add Unit";
                btnAddMiniUnit.Enabled = false;
                btnDeleteMiniUnit.Enabled = false;
                miniUnitDT = MiniUnitService.GetAllByUSId(0);
                addMUToDataTable();
                // miniUnitDT.Columns.Add("tempID")

                // btnAddMiniUnit.Enabled = False
                btnDeleteMiniUnit.Enabled = false;
                // btnAssociateBooking.Visible = False
                isModField = true;
                nudTotalBilled.Value = nudTotalBilledWeight.Value;
                isModField = false;
                // btnAssociateBooking.Visible = False
            }

            checkModRecButtons();
            checkModTextFields();
            checkModCBOFields();
            firstLoad = false;
            MdlLoadingSetting.waitForm.Close();
        }

        public List<VW_Booking> CreateUnitsCopy(List<VW_UnitSource> originaList, ref List<VW_UnitSource> targetList)
        {
            targetList.Clear();
            VW_UnitSource u;
            foreach (var unit in originaList)
            {
                u = new VW_UnitSource();
                u.UnitSourceId = unit.UnitSourceId;
                u.UnitNumber = unit.UnitNumber;
                u.UnitLine = unit.UnitLine;
                u.UnitType = unit.UnitType;
                u.OriginLocation = unit.OriginLocation;
                u.ETADate = unit.ETADate;
                u.ETALocation = unit.ETALocation;
                u.LastTraced = unit.LastTraced;
                u.LastLocation = unit.LastLocation;
                u.Sequence = unit.Sequence;
                u.Track = unit.Track;
                u.DemurageDays = unit.DemurageDays;
                u.InTransitDays = unit.InTransitDays;
                u.BillDate = unit.BillDate;
                u.CallDate = unit.CallDate;
                u.ArrivalDate = unit.ArrivalDate;
                u.AvailableDate = unit.AvailableDate;
                u.ReleaseDate = unit.ReleaseDate;
                u.TotalBilled = unit.TotalBilled;
                u.LastUpdate = unit.LastUpdate;
                u.ActiveUpdates = unit.ActiveUpdates;
                u.Active = unit.Active;
                u.RecordKey = unit.RecordKey;
                u.RailIncShipperName = unit.RailIncShipperName;
                u.CargoDescription = unit.CargoDescription;
                u.ShipperId = unit.ShipperId;
                u.ShipperName = unit.ShipperName;
                u.UnitStatusId = unit.UnitStatusId;
                u.UnitStatus = unit.UnitStatus;
                u.CargoTypeId = unit.CargoTypeId;
                u.CargoType = unit.CargoType;
                u.OriginalUnitNumber = unit.OriginalUnitNumber;
                targetList.Add(u);
            }

            return default;
        }

        private void LoadFieldsByUnitSourceOrRailList()
        {
            // 1 - Verifica se tem UnitSourceId
            // railListRecord = dbCeres.getTableInfo("[Rail List]", "*", "where [Record Key] = '" + FrmRailList.selectedRecordKey(0).ToString() + "'")

            // railListRecord = dbCeres.getTableInfo("[Rail List]", "*", "where [Record Key] = '" + RecordKey.ToString() + "'")
            // If railListRecord.Rows.Count > 0 Then
            // railListRow = railListRecord.Rows(0)
            // End If
            // If UnitSourceId = 0 Then
            // '2 - verifica se tem o RecordKey vinculado ao Unit Source
            // If clsUnit.verifyTable("UnitSource", "RecordKey", RecordKey) Then
            // Dim usTempTable = clsUnit.getDataTable("UnitSource", "*", "where RecordKey = " + RecordKey.ToString())

            // If usTempTable.Rows.Count > 0 Then
            // UnitSourceId = usTempTable.Rows(0).Item("UnitSourceId")
            // Else
            // UnitSourceId = 0
            // End If

            // LoadUnitSource()
            // Else
            // populateRailInfo()
            // End If
            // Else
            LoadUnitSource();
            // End If
            // Verify fields Update with Rail List Table
            // LoadCheckFields()
        }

        public void LoadUnitSource()
        {
            DateTime eDate;
            DataTable unitServiceDT;
            string query;
            // Verifica se tem Record Key vinculado a Unit Source se for maior que Zero Existe
            unitSourceDT = dbCeres.getTableInfo("VW_UnitSource", "*", "where UnitSourceId = " + UnitSourceId.ToString());
            foreach (DataRow us in unitSourceDT.Rows)
            {
                txtUnitNumber.Text = Conversions.ToString(us["UnitNumber"]);
                cboCargoType.SelectedValue = us["CargoTypeId"];
                cboUnitStatus.SelectedValue = us["UnitStatusId"];
                cboUnitType.SelectedItem = Strings.Trim(Conversions.ToString(us["UnitType"]));
                if (!Information.IsDBNull(us["ShipperId"]))
                {
                    cboShipper.SelectedValue = us["ShipperId"];
                }
                else if (railListRecord.Rows.Count > 0 && railListRow.IsNull("Shipper Name") == false)
                {
                    cboShipper.Text = Strings.Trim(Conversions.ToString(railListRow["Shipper Name"]));
                }

                if (!Information.IsDBNull(us["UnitLine"]))
                {
                    txtCarrier.Text = Conversions.ToString(us["UnitLine"]);
                }
                else if (railListRecord.Rows.Count > 0 && railListRow.IsNull("SASC") == false)
                {
                    txtCarrier.Text = Strings.Trim(Conversions.ToString(railListRow["SASC"]));
                }
                else
                {
                    txtCarrier.Text = "";
                }

                if (!Information.IsDBNull(us["OriginLocation"]))
                {
                    txtOrigin.Text = Conversions.ToString(us["OriginLocation"]);
                }
                else
                {
                    txtOrigin.Text = "";
                }

                if (!Information.IsDBNull(us["ETALocation"]))
                {
                    txtETALocation.Text = Conversions.ToString(us["ETALocation"]);
                }
                else if (railListRecord.Rows.Count > 0 && railListRow.IsNull("ETA Location") == false)
                {
                    txtETALocation.Text = Strings.Trim(Conversions.ToString(railListRow["ETA Location"]));
                }
                else
                {
                    txtETALocation.Text = "";
                }

                if (!Information.IsDBNull(us["LastLocation"]))
                {
                    txtLastLocation.Text = Conversions.ToString(us["LastLocation"]);
                }
                else if (railListRecord.Rows.Count > 0 && railListRow.IsNull("Sighting Location") == false)
                {
                    txtLastLocation.Text = Strings.Trim(Conversions.ToString(railListRow["Sighting Location"]));
                }
                else
                {
                    txtLastLocation.Text = "";
                }

                if (!Information.IsDBNull(us["Sequence"]))
                {
                    txtSequence.Text = Conversions.ToString(us["Sequence"]);
                }
                else
                {
                    txtSequence.Text = "";
                }

                if (!Information.IsDBNull(us["Track"]))
                {
                    txtTrack.Text = Conversions.ToString(us["Track"]);
                }
                else
                {
                    txtTrack.Text = "";
                }

                if (!Information.IsDBNull(us["DemurageDays"]))
                {
                    nudDemurageDays.Value = Conversions.ToDecimal(us["DemurageDays"]);
                }
                else
                {
                    nudDemurageDays.Value = 0m;
                }

                if (!Information.IsDBNull(us["InTransitDays"]))
                {
                    nudInTransitDays.Text = Conversions.ToString(us["InTransitDays"]);
                }
                else
                {
                    nudInTransitDays.Text = 0.ToString();
                }

                if (us["CargoType"].Equals("BULK"))
                {
                    if (!Information.IsDBNull(us["TotalBilled"]))
                    {
                        nudTotalBilledWeight.Value = Conversions.ToDecimal(us["TotalBilled"]);
                    }
                    else
                    {
                        nudTotalBilledWeight.Value = nudTotalBilledWeight.Value;
                    }
                }
                else if (Information.IsDBNull(us["CargoType"]))
                {
                    if (railListRecord.Rows.Count > 0 && railListRow.IsNull("Way Bill Net Wgt") == false)
                    {
                        nudTotalBilledWeight.Value = Conversions.ToDecimal(railListRow["Way_Bill_Net_Wgt"]);
                    }
                    else
                    {
                        nudTotalBilledWeight.Value = nudTotalBilledWeight.Value;
                    }
                }
                else if (!Information.IsDBNull(us["TotalBilled"]))
                {
                    nudTotalBilledWeight.Value = Conversions.ToDecimal(us["TotalBilled"]);
                }
                else
                {
                    nudTotalBilledWeight.Value = nudTotalBilledWeight.Value;
                }

                // Dates
                if (us.IsNull("ETADate") == false)
                {
                    eDate = Conversions.ToDate(us["ETADate"]);
                    LoadDatePicker(txtETADate);
                    txtETADate.Value = eDate;
                    btnClearETADate.Visible = true;
                }
                else if (railListRecord.Rows.Count > 0 && railListRow.IsNull("ETA_Date_Time") == false)
                {
                    LoadDatePicker(txtETADate);
                    txtETADate.Value = Conversions.ToDate(railListRow["ETA_Date_Time"]);
                    btnClearETADate.Visible = true;
                }

                if (us.IsNull("LastTraced") == false)
                {
                    LoadDatePicker(dtpLastTraced);
                    eDate = Conversions.ToDate(us["LastTraced"]);
                    dtpLastTraced.Value = eDate;
                    btnClearLastTraceddate.Visible = true;
                }
                else if (railListRecord.Rows.Count > 0 && railListRow.IsNull("Sighting_Date_Time") == false)
                {
                    LoadDatePicker(dtpLastTraced);
                    dtpLastTraced.Value = Conversions.ToDate(railListRow["Sighting_Date_Time"]);
                    btnClearLastTraceddate.Visible = true;
                }

                if (us.IsNull("BillDate") == false)
                {
                    LoadDatePicker(txtBillDate);
                    eDate = Conversions.ToDate(us["BillDate"]);
                    txtBillDate.Value = eDate;
                    btnClearBillDate.Visible = true;
                }
                else if (railListRecord.Rows.Count > 0 && railListRow.IsNull("Way Bill Date") == false)
                {
                    LoadDatePicker(txtBillDate);
                    eDate = Conversions.ToDate(railListRow["Way Bill Date"]);
                    txtBillDate.Value = eDate;
                    btnClearBillDate.Visible = true;
                }

                if (us.IsNull("CallDate") == false)
                {
                    LoadDatePicker(txtCallDate);
                    eDate = Conversions.ToDate(us["CallDate"]);
                    try
                    {
                        txtCallDate.Value = eDate;
                    }
                    catch
                    {
                    }

                    btnClearCalldate.Visible = true;
                }
                else if (railListRecord.Rows.Count > 0 && railListRow.IsNull("Rail Car Called Date") == false)
                {
                    LoadDatePicker(txtCallDate);
                    eDate = Conversions.ToDate(railListRow["Rail Car Called Date"]);
                    txtCallDate.Value = eDate;
                    btnClearCalldate.Visible = true;
                }

                if (us.IsNull("ArrivalDate") == false)
                {
                    LoadDatePicker(txtArrivalDate);
                    eDate = Conversions.ToDate(us["ArrivalDate"]);
                    txtArrivalDate.Value = eDate;
                    btnClearArrivalDate.Visible = true;
                }
                else if (railListRecord.Rows.Count > 0 && railListRow.IsNull("Rail Car Arrived Date") == false)
                {
                    LoadDatePicker(txtArrivalDate);
                    eDate = Conversions.ToDate(railListRow["Rail Car Arrived Date"]);
                    txtArrivalDate.Value = eDate;
                    btnClearArrivalDate.Visible = true;
                }

                if (us.IsNull("AvailableDate") == false)
                {
                    LoadDatePicker(txtAvailableDate);
                    eDate = Conversions.ToDate(us["AvailableDate"]);
                    if (eDate > DateTime.MinValue)
                    {
                        txtAvailableDate.Value = eDate;
                        btnClearAvailDate.Visible = true;
                    }
                    else if (railListRecord.Rows.Count > 0 && railListRow.IsNull("Rail Car Available Date") == false)
                    {
                        LoadDatePicker(txtAvailableDate);
                        eDate = Conversions.ToDate(railListRow["Rail Car Available Date"]);
                        txtAvailableDate.Value = eDate;
                        btnClearAvailDate.Visible = true;
                    }
                }
                else if (railListRecord.Rows.Count > 0 && railListRow.IsNull("Rail Car Available Date") == false)
                {
                    LoadDatePicker(txtAvailableDate);
                    eDate = Conversions.ToDate(railListRow["Rail Car Available Date"]);
                    txtAvailableDate.Value = eDate;
                    btnClearAvailDate.Visible = true;
                }

                if (us.IsNull("ReleaseDate") == false)
                {
                    LoadDatePicker(txtReleaseDate);
                    eDate = Conversions.ToDate(us["ReleaseDate"]);
                    txtReleaseDate.Value = eDate;
                    btnClearReleaseDate.Visible = true;
                }
                else if (railListRecord.Rows.Count > 0 && railListRow.IsNull("Rail Car Released Date") == false)
                {
                    eDate = Conversions.ToDate(railListRow["Rail Car Released Date"]);
                    txtReleaseDate.Value = eDate;
                    LoadDatePicker(txtReleaseDate);
                    btnClearReleaseDate.Visible = true;
                }

                if (us.IsNull("LastUpdate") == true)
                {
                    lblLastUpdate.Text = "";
                    lblTitleLastUpdate.Text = "";
                }
                else
                {
                    eDate = Conversions.ToDate(us["LastUpdate"]);
                    lblLastUpdate.Text = Conversions.ToString(eDate);
                    lblTitleLastUpdate.Text = "Last Update:";
                }
            }
            // checkModRecButtons()

        }

        private void ClearAllDataTable()
        {
            miniUnitDT.Clear();
            UpDateMiniUnitTable.Clear();
            UpDateMiniUnitTable.Dispose();
            railListRecord.Rows.Clear();
        }

        private void GoLastPosition()
        {
            int a = MiniUnitOrder;
            for (int index = a, loopTo = miniUnitDT.Count - 1; index <= loopTo; index++)
                nextButton_Click(null, null);
        }

        public void checkArrowButtons()
        {
            // if more than one mb
            if (miniUnitDT.Count > 1)
            {
                if (focusedMiniUnit == 0)
                {
                    nextButton.Enabled = true;
                    previousButton.Enabled = false;
                    nextButton.IdleIconLeftImage = My.Resources.Resources.nextEnabled;
                    previousButton.IdleIconRightImage = My.Resources.Resources.previousDisabled;
                    string stringmb = "";
                    if (miniUnitDT.Count - 1 > 1)
                    {
                        stringmb = "MiniUnits";
                    }
                    else
                    {
                        stringmb = "MiniUnit";
                    }

                    MiniUnitOrder = 1;
                    mbTitleMiniUnit.Text = "MiniUnit " + MiniUnitOrder.ToString() + " | Total MU: " + miniUnitDT.Count.ToString();
                }
                // mbTitleLabel.BackColor = Color.DarkGreen
                else
                {
                    nextButton.Enabled = true;
                    if (focusedMiniUnit + 1 == miniUnitDT.Count)
                    {
                        nextButton.IdleIconLeftImage = My.Resources.Resources.nextDisabled;
                        nextButton.Enabled = false;
                    }
                    else
                    {
                        nextButton.IdleIconLeftImage = My.Resources.Resources.nextEnabled;
                    }

                    previousButton.Enabled = true;
                    previousButton.IdleIconRightImage = My.Resources.Resources.previousEnabled;
                    MiniUnitOrder = focusedMiniUnit + 1;
                    mbTitleMiniUnit.Text = "MiniUnit " + MiniUnitOrder.ToString() + " | Total MU: " + miniUnitDT.Count.ToString();
                    // mbTitleLabel.BackColor = Color.FromArgb(192, 64, 0)
                }
            }
            else
            {
                nextButton.Enabled = false;
                previousButton.Enabled = false;
                nextButton.IdleIconLeftImage = My.Resources.Resources.nextDisabled;
                previousButton.IdleIconRightImage = My.Resources.Resources.previousDisabled;
                MiniUnitOrder = focusedMiniUnit + 1;
                mbTitleMiniUnit.Text = "MiniUnit " + MiniUnitOrder.ToString() + " | Total MB: " + miniUnitDT.Count.ToString();
            }
        }

        private string GiveUnitType(string EQCode, string UnitNum)
        {
            string UnitType = "";
            if (Strings.Mid(EQCode, 1, 1) == "A")
            {
                UnitType = "BOX";
            }
            else if (Strings.Mid(EQCode, 1, 1) == "C")
            {
                UnitType = "HOPPER";
            }
            else if (Strings.Mid(EQCode, 1, 1) == "U")
            {
                UnitType = "IMDL";
            }
            else if (Strings.Mid(UnitNum, 4, 1) == "U")
            {
                UnitType = "IMDL";
            }
            else
            {
                UnitType = "N/A";
            }

            return UnitType;
        }

        private string GiveServiceType(char Service)
        {
            string ServiceType = "";
            if (Service == '\u0001')
            {
                ServiceType = "BAG";
            }
            else if (Service == '\u0002')
            {
                ServiceType = "BAGGER";
            }
            else if (Service == '\u0003')
            {
                ServiceType = "BULK";
            }

            return ServiceType;
        }

        private void EnabeDisabeMiniUnitByType(string UnitType)
        {
            switch (UnitType ?? "")
            {
                case "BULK":
                    {
                        nudTotalBilled.DecimalPlaces = 3;
                        nudTotalBilledWeight.DecimalPlaces = 3;
                        lblBilled.Text = "Total Billed Weight:";
                        Label26.Text = "Total Unloaded Weight:";
                        lblBilledUnit.Text = "MT";
                        Label11.Text = "MT";
                        Label62.Text = "MT";
                        piecesUnitWeightContainer.Hide();
                        pcunitUnContainer.Hide();
                        nudPCUNPiecesWeight.Value = 0m;
                        nudPCWeight.Value = 0m;
                        break;
                    }

                default:
                    {
                        nudTotalBilled.DecimalPlaces = 0;
                        nudTotalBilledWeight.Value = Convert.ToInt32(nudTotalBilledWeight.Value);
                        nudTotalBilledWeight.DecimalPlaces = 0;
                        lblBilled.Text = "Total Billed Pieces:";
                        Label26.Text = "Total Unloaded Pieces:";
                        lblBilledUnit.Text = "PC";
                        Label11.Text = "PC";
                        Label62.Text = "PC";
                        piecesUnitWeightContainer.Show();
                        pcunitUnContainer.Show();
                        break;
                    }
            }
        }

        private bool fieldsGoodToGo()
        {
            warningLabel.Text = "";
            btnSaveInboundCargo.Enabled = false;
            txtUnitNumber.Enabled = true;
            cboCargoType.Enabled = true;
            nudTotalBilledWeight.Enabled = true;
            pnlMUBillDetails.Enabled = true;
            pnlMU.Enabled = true;
            if (!isMultiEdit)
            {
                string unit = MdlUnits.ReformatCarNumber(Strings.Trim(txtUnitNumber.Text));
                var unitFound = default(UnitSource);
                if (string.IsNullOrEmpty(txtUnitNumber.Text))
                {
                    warningLabel.Text = "Unit number can not be empty";
                    txtUnitNumber.BorderColorIdle = Color.Firebrick;
                    return false;
                }
                else if (MdlUnits.UnitAlreadyExist(unit, AllUnits, ref unitFound) == true && isNewRecord == true)
                {
                    warningLabel.Text = "Unit number already exist";
                    txtUnitNumber.BorderColorIdle = Color.Firebrick;
                    return false;
                }
                else
                {
                    txtUnitNumber.BorderColorIdle = Color.DimGray;
                }

                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cboCargoType.SelectedValue, 0, false)))
                {
                    warningLabel.Text = "Cargo type can not be empty";
                    return false;
                }

                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cboCommodity.SelectedValue, 0, false)))
                {
                    warningLabel.Text = "Commodity can not be empty";
                    return false;
                }

                foreach (var mu in miniUnitDT)
                {
                    if (mu.CustomerId == 0)
                    {
                        warningLabel.Text = "Customer can not be empty";
                        // cboCustomer.Color = Color.Firebrick
                        return false;
                    }
                }

                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cboUnitStatus.SelectedValue, 0, false)))
                {
                    warningLabel.Text = "Unit status can not be empty";
                    // cboCustomer.Color = Color.Firebrick
                    return false;
                }

                if (nudTotalBilledWeight.Value == 0m)
                {
                    warningLabel.Text = "Total billed weight can not be 0";
                    return false;
                }
            }
            else
            {
                txtUnitNumber.Enabled = false;
                cboCargoType.Enabled = false;
                nudTotalBilledWeight.Enabled = false;
                pnlMUBillDetails.Enabled = false;
                pnlMU.Enabled = false;
            }

            btnSaveInboundCargo.Enabled = true;
            return true;
        }

        public void ClearFields()
        {
            // originalMiniUnitTable.Clear()
            MiniUnitId = 0;
            focusedMiniUnit = 0;
            populateComboGradeCommodity();

            // --------Bulk -------------------------------

            txtLocation.Text = "";
            txtComments.Text = "";
            tbLotNumber.Text = "";
            warningLabel.Text = "";

            // -------Pieces -----------------------------
            nudTotalBilled.Value = 0m;
            nudPCWeight.Value = 0m;
            nudTotalUNBilled.Value = 0m;
            nudPCUNPiecesWeight.Value = 0m;
            rbKG.Checked = true;
            rbLB.Checked = false;
            rbMT.Checked = false;
            rbKGPC.Checked = true;
            rbLBPC.Checked = false;
            rbMTPC.Checked = false;
        }

        public void ClearFieldMain()
        {
            UnitNumber = "";
            // RecordKey = 0
            txtUnitNumber.Text = "";
            cboUnitType.SelectedItem = "";
            txtOrigin.Text = "";
            txtCarrier.Text = "";
            txtETALocation.Text = "";
            txtLastLocation.Text = "";
            txtSequence.Text = "";
            txtTrack.Text = "";
            nudDemurageDays.Value = 0m;
            nudInTransitDays.Value = 0m;
            nudTotalBilledWeight.Value = 0m;
            ClearDatePicker(txtETADate);
            ClearDatePicker(dtpLastTraced);
            ClearDatePicker(txtBillDate);
            ClearDatePicker(txtCallDate);
            ClearDatePicker(txtArrivalDate);
            ClearDatePicker(txtAvailableDate);
            ClearDatePicker(txtReleaseDate);
            btnClearETADate.Hide();
            btnClearLastTraceddate.Hide();
            btnClearBillDate.Hide();
            btnClearCalldate.Hide();
            btnClearArrivalDate.Hide();
            btnClearAvailDate.Hide();
            btnClearReleaseDate.Hide();
            btnEraseModShipper.Hide();
            btnEraseModOrigin.Hide();
            btnEraseModCarrier.Hide();
            btnEraseModETADate.Hide();
            btnEraseModETALocation.Hide();
            btnEraseModlastTraceddate.Hide();
            btnEraseLastLocation.Hide();
            btnEraseModBilldate.Hide();
            btnEraseModCallDate.Hide();
            btnEraseModArrivaldate.Hide();
            btnEraseAvailableDate.Hide();
            btnEraseModRelDate.Hide();
            btnEraseModTotalBilled.Hide();
        }

        public void ClearDatePicker(DateTimePicker DatePicker)
        {
            DatePicker.Format = DateTimePickerFormat.Custom;
            DatePicker.CustomFormat = " ";
        }

        public void LoadDatePicker(DateTimePicker DatePicker)
        {
            DatePicker.Format = DateTimePickerFormat.Custom;
            DatePicker.CustomFormat = "MMM dd, yyyy";
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public void SaveUpdateMiniUnit(int UnitSourceId)
        {
            var muService = new MiniUnitService();
            foreach (var MU in miniUnitDT)
            {
                MU.UnitSourceId = UnitSourceId;
                MU.isMultiMU = miniUnitDT.Count > 1;
            }

            muService.InsertOrUpdateList(miniUnitDT);
        }

        public void PopulateMU()
        {
            isModField = false;
            if (focusedMiniUnit == -1)
            {
                focusedMiniUnit = 0;
            }

            var muInfo = miniUnitDT[focusedMiniUnit];
            if (!Information.IsNothing(muInfo.MiniUnitId))
            {
                MiniUnitId = muInfo.MiniUnitId;
            }

            // ----------Mini Unit Bulk Variables receive the values

            // **** Billed
            if (!Information.IsNothing(muInfo.BilledByUnit))
            {
                nudPCWeight.Value = (decimal)muInfo.BilledByUnit;
            }
            else
            {
                nudPCWeight.Value = 0m;
            }

            if (!Information.IsNothing(muInfo.BilledByUnitUnitType))
            {
                if (muInfo.BilledByUnitUnitType.Equals("KG"))
                {
                    rbKGPC.Checked = true;
                }
                else if (muInfo.BilledByUnitUnitType.Equals("LB"))
                {
                    rbLBPC.Checked = true;
                }
                else
                {
                    rbMTPC.Checked = true;
                }
            }
            else if (rbKGPC.Checked == true)
            {
                muInfo.BilledByUnitUnitType = "KG";
            }
            else if (rbLBPC.Checked == true)
            {
                muInfo.BilledByUnitUnitType = "LB";
            }
            else
            {
                muInfo.BilledByUnitUnitType = "MT";
            }

            // **** Unloaded

            if (!Information.IsNothing(muInfo.UnBilledByUnit))
            {
                nudPCUNPiecesWeight.Value = (decimal)muInfo.UnBilledByUnit;
            }
            else
            {
                nudPCUNPiecesWeight.Value = 0m;
            }

            if (!Information.IsNothing(muInfo.UnBilledByUnitUnitType))
            {
                if (muInfo.UnBilledByUnitUnitType == "KG")
                {
                    rbKG.Checked = true;
                }
                else if (muInfo.UnBilledByUnitUnitType == "LB")
                {
                    rbLB.Checked = true;
                }
                else
                {
                    rbMT.Checked = true;
                }
            }
            else if (rbKG.Checked == true)
            {
                muInfo.UnBilledByUnitUnitType = "KG";
            }
            else if (rbLB.Checked == true)
            {
                muInfo.UnBilledByUnitUnitType = "LB";
            }
            else
            {
                muInfo.UnBilledByUnitUnitType = "MT";
            }

            if (miniUnitDT.Count == 1)
            {
                isModField = true;
                nudTotalBilled.Value = nudTotalBilledWeight.Value;
                isModField = false;
            }
            else
            {
                nudTotalBilled.Value = (decimal)muInfo.TotalBilled;
            }

            if (!Information.IsNothing(muInfo.UnBilled))
            {
                nudTotalUNBilled.Value = (decimal)muInfo.UnBilled;
            }
            else
            {
                nudTotalUNBilled.Value = 0m;
            }

            // nudPCWeightUnit.Value = muInfo("PCWeightUnit")
            if (!Information.IsNothing(muInfo.CommodityId))
            {
                cboCommodity.SelectedValue = muInfo.CommodityId;
            }
            else
            {
                cboCommodity.SelectedValue = 0;
            }

            if (!Information.IsNothing(muInfo.GradeId))
            {
                cboGrade.SelectedValue = muInfo.GradeId;
            }
            else
            {
                cboGrade.SelectedValue = 0;
            }

            if (!Information.IsNothing(muInfo.MULocation))
            {
                txtLocation.Text = muInfo.MULocation;
            }
            else
            {
                txtLocation.Text = "";
            }

            if (!Information.IsNothing(muInfo.Comments))
            {
                txtComments.Text = muInfo.Comments;
            }
            else
            {
                txtComments.Text = "";
            }

            if (!Information.IsNothing(muInfo.LotNumber))
            {
                tbLotNumber.Text = muInfo.LotNumber;
            }
            else
            {
                tbLotNumber.Text = "";
            }

            if (!Information.IsNothing(muInfo.CustomerId))
            {
                cboCustomer.SelectedValue = muInfo.CustomerId;
            }
            else
            {
                cboCustomer.SelectedValue = 0;
            }

            isModField = true;
            UpdateMUOrder();
        }

        private void addMUToDataTable()
        {
            decimal totalBilled;
            string commodity;
            string grade;
            string location;
            string comments;
            decimal billedByUnit;
            string billedBuUnitType;
            int totalUnBilled;
            int UNBilledByUnit;
            string UNBilledBuUnitType;
            string lotNumb;
            location = txtLocation.Text;
            comments = txtComments.Text;
            lotNumb = tbLotNumber.Text;

            // ----------Mini Unit Pieces Variables receive the values
            totalBilled = nudTotalBilled.Value;
            billedByUnit = nudPCWeight.Value;
            // PCCommodity = cboPCCommodity.Text
            // PCGrade = cboPCGrade.Text
            totalUnBilled = (int)Math.Round(nudTotalUNBilled.Value);
            if (rbKG.Checked)
            {
                UNBilledBuUnitType = "KG";
            }
            else if (rbLB.Checked)
            {
                UNBilledBuUnitType = "LB";
            }
            else
            {
                UNBilledBuUnitType = "MT";
            }

            if (rbKGPC.Checked)
            {
                billedBuUnitType = "KG";
            }
            else if (rbLBPC.Checked)
            {
                billedBuUnitType = "LB";
            }
            else
            {
                billedBuUnitType = "MT";
            }

            UNBilledByUnit = (int)Math.Round(nudPCUNPiecesWeight.Value);
            muOrder = miniUnitDT.Count + 1;
            var newRow = new MiniUnit();
            if (focusedMiniUnit == 0)
            {
                newRow.MiniUnitOrder = 1;
            }
            else
            {
                newRow.MiniUnitOrder = muOrder;
            }

            newRow.TotalBilled = totalBilled;
            newRow.UnBilled = totalUnBilled;
            newRow.BilledByUnit = billedByUnit;
            newRow.BilledByUnitUnitType = billedBuUnitType;
            newRow.UnBilledByUnit = UNBilledByUnit;
            newRow.UnBilledByUnitUnitType = UNBilledBuUnitType;
            newRow.MULocation = location;
            newRow.Comments = comments;
            newRow.LotNumber = lotNumb;
            newRow.MiniUnitId = 0;
            cboGrade.SelectedValue = 0;
            newRow.CommodityId = Conversions.ToInteger(cboCommodity.SelectedValue);

            // '       newRow("CustomerName") = cboCustomer.Text

            newRow.CustomerId = Conversions.ToInteger(cboCustomer.SelectedValue);
            miniUnitDT.Add(newRow);
        }

        private void getBookinNumber(int RecordKey)
        {
            string a;
            foreach (DataRow rail in clsUnit.getDataTable("[Rail List]", "[Booking Numbers]", "where [Record Key] = " + RecordKey.ToString()).Rows)
            {
                if (rail.IsNull("Booking Numbers") == false)
                {
                    a = Conversions.ToString(rail["Booking Numbers"]);
                }
            }
        }

        // Private Function getGradeCode(ByVal GradeName As String) As String
        // Dim com As DataRow
        // Dim Code As String = Nothing
        // For Each com In dbCeres.getTableInfo("Grade", "[GradeCode]", "where [GradeName] = '" + GradeName + "' and [GradeName] <> '' ").Rows
        // If com.IsNull("Grade Code") = False Then
        // Code = Trim(com("Grade Code"))
        // End If
        // Next
        // Return Code
        // End Function

        private void populateComboGradeCommodity()
        {
            {
                var withBlock = cboGrade;
                withBlock.DataSource = GradeService.GetAll();
                withBlock.DisplayMember = "GradeName";
                withBlock.ValueMember = "GradeId";
            }

            {
                var withBlock1 = cboCommodity;
                withBlock1.DataSource = CommodityService.GetAll();
                withBlock1.DisplayMember = "CommodityName";
                withBlock1.ValueMember = "CommodityId";
            }

            cboGrade.SelectedValue = 0;
            cboCommodity.SelectedValue = 0;
        }

        private void populateComboBoxes()
        {
            isModField = false;
            using (var db = new WTCCeresEntities())
            {
                cboShipper.DataSource = CompanyService.GetAllByCompanyTypeId((int)MdlEnum.CompanyType.Steamship_Line, db);
                var categories = new List<int>();
                categories.Add((int)MdlEnum.CompanyCategory.CUSTOMER);
                categories.Add((int)MdlEnum.CompanyCategory.CUSTOMER_VENDOR);
                cboCustomer.DataSource = CompanyService.GetByCompanyCategoryId(categories, db);
                {
                    var withBlock = cboUnitStatus;
                    withBlock.DataSource = UnitStatusService.GetAll(db);
                    withBlock.DisplayMember = "StatusName";
                    withBlock.ValueMember = "UnitStatusId";
                }

                // UnitType
                cboUnitType.Items.Clear();
                cboUnitType.Items.Add("");
                cboUnitType.Items.Add("BOX");
                cboUnitType.Items.Add("HOPPER");
                cboUnitType.Items.Add("IMDL");

                // Cargo Type
                {
                    var withBlock1 = cboCargoType;
                    withBlock1.DataSource = CargoTypeService.GetAll();
                    withBlock1.DisplayMember = "CargoTypeName";
                    withBlock1.ValueMember = "CargoTypeId";
                }
            }

            // cboService.Text = dbCeres.getBookingService(RecordKey)

            EnabeDisabeMiniUnitByType(cboCargoType.Text);
            isModField = true;
        }

        private string getCargoType(char statusCode)
        {
            if (statusCode == '\u0002')
            {
                return "BAGGER";
            }
            else if (statusCode == '\u0003')
            {
                return "BULK";
            }
            else if (statusCode == '\u0004')
            {
                return "PALLET";
            }
            else if (statusCode == '\u0005')
            {
                return "TOTE";
            }

            return default;
        }

        private void checkModRecButtons()
        {
            showEditButton(btnClearETADate, btnEraseModETADate, "ETA_Date_Time", txtETADate);
            showEditButton(btnClearReleaseDate, btnEraseModRelDate, "Rail Car Released Date", txtReleaseDate);
            showEditButton(btnClearAvailDate, btnEraseAvailableDate, "Rail Car Available Date", txtAvailableDate);
            showEditButton(btnClearArrivalDate, btnEraseModArrivaldate, "Rail Car Arrived Date", txtArrivalDate);
            showEditButton(btnClearCalldate, btnEraseModCallDate, "Rail Car Called Date", txtCallDate);
            showEditButton(btnClearLastTraceddate, btnEraseModlastTraceddate, "Sighting_Date_Time", dtpLastTraced);
            showEditButton(btnClearBillDate, btnEraseModBilldate, "Way Bill Date", txtBillDate);
        }

        private void showEditButton(BunifuButton clearDateButton, BunifuButton eraseEditButton, string railListColName, DateTimePicker focusedDate)
        {
            if (railListRecord.Rows.Count > 0)
            {
                if (dateMatch(railListColName, focusedDate))
                {
                    eraseEditButton.Visible = false;
                }
                else
                {
                    eraseEditButton.Visible = true;
                }
            }
        }

        private void ttsETADate_OnValuechange(object sender, EventArgs e)
        {
            if (!firstLoad)
            {
                if (isMultiEdit)
                {
                    foreach (var u in modifiedMultiEditUnitsList)
                        u.ETADate = txtETADate.Value;
                    VWUnitSourceBindingSource.DataSource = null;
                    VWUnitSourceBindingSource.DataSource = modifiedMultiEditUnitsList;
                }

                LoadDatePicker(txtETADate);
                checkModRecButtons();
                btnClearETADate.Show();
            }
        }

        private void ttsReleaseDate_OnValuechange(object sender, EventArgs e)
        {
            if (!firstLoad)
            {
                if (isMultiEdit)
                {
                    foreach (var u in modifiedMultiEditUnitsList)
                        u.ReleaseDate = txtReleaseDate.Value;
                    VWUnitSourceBindingSource.DataSource = null;
                    VWUnitSourceBindingSource.DataSource = modifiedMultiEditUnitsList;
                }

                LoadDatePicker(txtReleaseDate);
                checkModRecButtons();
                btnClearReleaseDate.Show();
            }
        }

        private void ttsAvailableDate_OnValuechange(object sender, EventArgs e)
        {
            if (!firstLoad)
            {
                if (isMultiEdit && !firstLoad)
                {
                    foreach (var u in modifiedMultiEditUnitsList)
                        u.AvailableDate = txtAvailableDate.Value;
                    VWUnitSourceBindingSource.DataSource = null;
                    VWUnitSourceBindingSource.DataSource = modifiedMultiEditUnitsList;
                }

                LoadDatePicker(txtAvailableDate);
                checkModRecButtons();
                btnClearAvailDate.Show();
            }
        }

        private void ttsArrivalDate_OnValuechange(object sender, EventArgs e)
        {
            if (!firstLoad)
            {
                if (isMultiEdit)
                {
                    foreach (var u in modifiedMultiEditUnitsList)
                        u.ArrivalDate = txtArrivalDate.Value;
                    VWUnitSourceBindingSource.DataSource = null;
                    VWUnitSourceBindingSource.DataSource = modifiedMultiEditUnitsList;
                }

                LoadDatePicker(txtArrivalDate);
                checkModRecButtons();
                btnClearArrivalDate.Show();
            }
        }

        private void ttsCallDate_OnValuechange(object sender, EventArgs e)
        {
            if (!firstLoad)
            {
                if (isMultiEdit)
                {
                    foreach (var u in modifiedMultiEditUnitsList)
                        u.CallDate = txtCallDate.Value;
                    VWUnitSourceBindingSource.DataSource = null;
                    VWUnitSourceBindingSource.DataSource = modifiedMultiEditUnitsList;
                }

                LoadDatePicker(txtCallDate);
                checkModRecButtons();
                btnClearCalldate.Show();
            }
        }

        private void ttsBillDate_OnValuechange(object sender, EventArgs e)
        {
            if (!firstLoad)
            {
                if (isMultiEdit)
                {
                    foreach (var u in modifiedMultiEditUnitsList)
                        u.BillDate = txtBillDate.Value;
                    VWUnitSourceBindingSource.DataSource = null;
                    VWUnitSourceBindingSource.DataSource = modifiedMultiEditUnitsList;
                }

                LoadDatePicker(txtBillDate);
                checkModRecButtons();
                btnClearBillDate.Show();
            }
        }

        private void ttsLastTraced_OnValuechange(object sender, EventArgs e)
        {
            if (!firstLoad)
            {
                if (isMultiEdit)
                {
                    foreach (var u in modifiedMultiEditUnitsList)
                        u.LastTraced = dtpLastTraced.Value;
                    VWUnitSourceBindingSource.DataSource = null;
                    VWUnitSourceBindingSource.DataSource = modifiedMultiEditUnitsList;
                }

                LoadDatePicker(dtpLastTraced);
                checkModRecButtons();
                btnClearLastTraceddate.Show();
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        // Public Sub VerifyField(ByVal check As Bunifu.UI.WinForms.BunifuCheckBox, ByVal Field As String)
        // If check.Checked Then
        // '1 - Insert to List
        // listUSActive.Add(New UnitSourceActive(Field, MiniUnitId, UnitSourceId))
        // Else
        // '2 - Check if it is in the list, if it is remove.
        // listUSActive.RemoveAll(Function(m As UnitSourceActive) m.UnitSourceId = UnitSourceId And m.MiniUnitId = MiniUnitId And m.Field = Field)
        // End If
        // End Sub

        private void nudTotalBilledWeight_ValueChanged(object sender, EventArgs e)
        {
            if (RecordKey == 0 & UnitSourceId == 0)
            {
                if (isNewRecord == true & miniUnitDT.Count == 1)
                {
                    nudTotalBilled.Value = nudTotalBilledWeight.Value;
                }
            }

            if (nudTotalBilledWeight.Value == 0m)
            {
                nudTotalBilledWeight.BackColor = Color.Firebrick;
                nudTotalBilledWeight.ForeColor = Color.White;
            }
            else
            {
                nudTotalBilledWeight.BackColor = Color.White;
                nudTotalBilledWeight.ForeColor = Color.Black;
                if (isNewRecord == false & miniUnitDT.Count == 1)
                {
                    nudTotalBilled.Value = nudTotalBilledWeight.Value;
                }
            }

            if (railListRecord.Rows.Count > 0)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(nudTotalBilledWeight.Value, railListRow["Way_Bill_Net_Wgt"], false)))
                {
                    btnEraseModTotalBilled.Show();
                }
            }
            else
            {
                btnEraseModTotalBilled.Hide();
            }

            if (miniUnitDT.Count > 1 & firstLoad == false & totalBilledInMUs() != nudTotalBilledWeight.Value)
            {
                My.MyProject.Forms.FrmModifyMUBilledValues.loadForm(false);
                MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmModifyMUBilledValues, this);
            }
            else if (miniUnitDT.Count == 1)
            {
                nudTotalBilled.Value = nudTotalBilledWeight.Value;
            }
        }

        private decimal totalBilledInMUs()
        {
            decimal totalBilledMU = 0m;
            foreach (var mu in miniUnitDT)
            {
                try
                {
                    totalBilledMU = (decimal)(totalBilledMU + mu.TotalBilled);
                }
                catch
                {
                }
            }

            return totalBilledMU;
        }

        private void resetDate(string railListcolName, DateTimePicker dateTimePicker, BunifuButton clearDateButton)
        {
            if (railListRecord.Rows.Count > 0 && !Information.IsNothing(railListRow[railListcolName]))
            {
                dateTimePicker.CustomFormat = "MMM dd, yyyy";
                dateTimePicker.Value = Conversions.ToDate(railListRow[railListcolName]);
                clearDateButton.Show();
            }
            else if (Information.IsNothing(railListRow[railListcolName]))
            {
                dateTimePicker.CustomFormat = " ";
                clearDateButton.Hide();
            }
        }

        private bool dateMatchRailList(string railListColName, string unitSourceColName)
        {
            if (railListRecord.Rows.Count > 1)
            {
                var railListDate = railListRow[railListColName];
                var unitSourceDate = unitSourceDT.Rows[0][unitSourceColName];
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(railListDate, unitSourceDate, false)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        private void btnClearETADate_Click(object sender, EventArgs e)
        {
            txtETADate.CustomFormat = " ";
            btnClearETADate.Hide();
            if (isMultiEdit)
            {
                foreach (var u in modifiedMultiEditUnitsList)
                    u.ETADate = default;
                VWUnitSourceBindingSource.DataSource = null;
                VWUnitSourceBindingSource.DataSource = modifiedMultiEditUnitsList;
            }

            showEditButton(btnClearETADate, btnEraseModETADate, "ETA_Date_Time", txtETADate);
            // checkModRecButtons()
            // btnEraseModETADate.Hide()
        }

        private void btnClearLastTraceddate_Click(object sender, EventArgs e)
        {
            dtpLastTraced.CustomFormat = " ";
            btnClearLastTraceddate.Hide();
            if (isMultiEdit)
            {
                foreach (var u in modifiedMultiEditUnitsList)
                    u.LastTraced = default;
                VWUnitSourceBindingSource.DataSource = null;
                VWUnitSourceBindingSource.DataSource = modifiedMultiEditUnitsList;
            }

            showEditButton(btnClearLastTraceddate, btnEraseModlastTraceddate, "Sighting_Date_Time", dtpLastTraced);
        }

        private void btnClearBillDate_Click(object sender, EventArgs e)
        {
            txtBillDate.CustomFormat = " ";
            btnClearBillDate.Hide();
            if (isMultiEdit)
            {
                foreach (var u in modifiedMultiEditUnitsList)
                    u.BillDate = default;
                VWUnitSourceBindingSource.DataSource = null;
                VWUnitSourceBindingSource.DataSource = modifiedMultiEditUnitsList;
            }

            showEditButton(btnClearBillDate, btnEraseModBilldate, "Way Bill Date", txtBillDate);
        }

        private void btnClearCalldate_Click(object sender, EventArgs e)
        {
            txtCallDate.CustomFormat = " ";
            btnClearCalldate.Hide();
            if (isMultiEdit)
            {
                foreach (var u in modifiedMultiEditUnitsList)
                    u.CallDate = default;
                VWUnitSourceBindingSource.DataSource = null;
                VWUnitSourceBindingSource.DataSource = modifiedMultiEditUnitsList;
            }

            showEditButton(btnClearCalldate, btnEraseModCallDate, "Rail Car Called Date", txtCallDate);
        }

        private void btnClearArrivalDate_Click(object sender, EventArgs e)
        {
            txtArrivalDate.CustomFormat = " ";
            btnClearArrivalDate.Hide();
            if (isMultiEdit)
            {
                foreach (var u in modifiedMultiEditUnitsList)
                    u.ArrivalDate = default;
                VWUnitSourceBindingSource.DataSource = null;
                VWUnitSourceBindingSource.DataSource = modifiedMultiEditUnitsList;
            }

            showEditButton(btnClearArrivalDate, btnEraseModArrivaldate, "Rail Car Arrived Date", txtArrivalDate);
        }

        private void btnClearAvailDate_Click(object sender, EventArgs e)
        {
            txtAvailableDate.CustomFormat = " ";
            btnClearAvailDate.Hide();
            if (isMultiEdit)
            {
                foreach (var u in modifiedMultiEditUnitsList)
                    u.AvailableDate = default;
                VWUnitSourceBindingSource.DataSource = null;
                VWUnitSourceBindingSource.DataSource = modifiedMultiEditUnitsList;
            }

            showEditButton(btnClearAvailDate, btnEraseAvailableDate, "Rail Car Available Date", txtAvailableDate);
        }

        private void btnClearReleaseDate_Click(object sender, EventArgs e)
        {
            txtReleaseDate.CustomFormat = " ";
            btnClearReleaseDate.Hide();
            if (isMultiEdit)
            {
                foreach (var u in modifiedMultiEditUnitsList)
                    u.ReleaseDate = default;
                VWUnitSourceBindingSource.DataSource = null;
                VWUnitSourceBindingSource.DataSource = modifiedMultiEditUnitsList;
            }

            showEditButton(btnClearReleaseDate, btnEraseModRelDate, "Rail Car Released Date", txtReleaseDate);
        }

        private void btnEraseModETADate_Click(object sender, EventArgs e)
        {
            resetDate("ETA_Date_Time", txtETADate, btnClearETADate);
            btnEraseModETADate.Hide();
        }

        private void btnEraseModlastTraceddate_Click(object sender, EventArgs e)
        {
            resetDate("Sighting_Date_Time", dtpLastTraced, btnClearLastTraceddate);
            btnEraseModlastTraceddate.Hide();
        }

        private void btnEraseModBilldate_Click(object sender, EventArgs e)
        {
            resetDate("Way Bill Date", txtBillDate, btnClearBillDate);
            btnEraseModBilldate.Hide();
        }

        private void btnEraseModCallDate_Click(object sender, EventArgs e)
        {
            resetDate("Rail Car Called Date", txtCallDate, btnClearCalldate);
            btnEraseModCallDate.Hide();
        }

        private void btnEraseModArrivaldate_Click(object sender, EventArgs e)
        {
            resetDate("Rail Car Arrived Date", txtCallDate, btnClearArrivalDate);
            btnEraseModArrivaldate.Hide();
        }

        private void btnEraseAvailableDate_Click(object sender, EventArgs e)
        {
            resetDate("Rail Car Available Date", txtAvailableDate, btnClearAvailDate);
            btnEraseAvailableDate.Hide();
        }

        private void btnEraseModRelDate_Click(object sender, EventArgs e)
        {
            resetDate("Rail Car Released Date", txtReleaseDate, btnClearReleaseDate);
            btnEraseModRelDate.Hide();
        }

        private void btnEraseModShipper_Click(object sender, EventArgs e)
        {
            btnEraseModShipper.Hide();
        }

        private bool dateMatch(string railListCollname, DateTimePicker focusedDate)
        {
            DateTime railDate;
            DateTime unitDate;
            if (unitSourceDT.Rows.Count > 0 & railListRecord.Rows.Count > 0)
            {
                var railListDate = railListRecord.Rows[0];
                var unitSourceDate = unitSourceDT.Rows[0];
                if (!Information.IsDBNull(railListDate[railListCollname]))
                {
                    railDate = Conversions.ToDate(railListDate[railListCollname]);
                }
                else if (Information.IsDBNull(railListDate[railListCollname]) & !focusedDate.CustomFormat.Equals(" "))
                {
                    return false;
                }
                else
                {
                    return true;
                }

                if (railDate.Date == focusedDate.Value.Date)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (unitSourceDT.Rows.Count == 0 & railListRecord.Rows.Count > 0)
            {
                var railListDate = railListRecord.Rows[0];
                if (!Information.IsDBNull(railListDate[railListCollname]))
                {
                    railDate = Conversions.ToDate(railListDate[railListCollname]);
                }
                else if (Information.IsNothing(railListDate[railListCollname]) & !focusedDate.CustomFormat.Equals(" "))
                {
                    return false;
                }
                else
                {
                    return true;
                }

                if (railDate.Date == focusedDate.Value.Date & !focusedDate.CustomFormat.Equals(" "))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        private void checkModTextFields()
        {
            checlkModTextField("Origin Location", txtOrigin, btnEraseModOrigin);
            checlkModTextField("SASC", txtCarrier, btnEraseModCarrier);
            checlkModTextField("ETA Location", txtETALocation, btnEraseModETALocation);
            checlkModTextField("Sighting Location", txtLastLocation, btnEraseLastLocation);
        }

        private void checkModCBOFields()
        {
            checkModCBO("EQ Type Code", cboUnitType, btnEraseModUnitType);
            checkModCBO("UnitStatus", cboUnitStatus, btnEraseModStatus);
            checkModCBO("Booking Service", cboCargoType, btnEraseModCargoType);
            checkModCBO("Shipper Name", cboShipper, btnEraseModShipper);
        }

        private void checlkModTextField(string railListcolName, BunifuTextBox fieldValue, BunifuButton eraseModDate)
        {
            if (fieldStringMatch(railListcolName, fieldValue))
            {
                eraseModDate.Hide();
            }
            else
            {
                eraseModDate.Show();
            }
        }

        private void resetTextField(string railColName, BunifuTextBox textField)
        {
            if (!Information.IsNothing(railListRow[railColName]))
            {
                textField.Text = Strings.Trim(Conversions.ToString(railListRow[railColName]));
            }
            else
            {
                textField.Text = "";
            }
        }

        private void resetCBOField(string railListColName, ComboBox cboField)
        {
            string railListValue;
            if (!railListColName.Equals("Booking Service"))
            {
                if (!Information.IsNothing(railListRow[railListColName]))
                {
                    if (railListColName.Equals("Unit Status"))
                    {
                    }
                    // railListValue = GiveUnitStatus(Mid(railListRow("Unit Status"), 2, 1))

                    else if (railListColName.Equals("EQ Type Code"))
                    {
                        railListValue = GiveUnitType(Strings.Trim(Conversions.ToString(railListRow["EQ Type Code"])), Strings.Trim(Conversions.ToString(railListRow["Unit Number"])));
                    }
                    else if (railListColName.Equals("Shipper Name"))
                    {
                        railListValue = Strings.Trim(Conversions.ToString(railListRow["Shipper Name"]));
                    }
                }
            }
            else if (railListColName.Equals("Booking Service"))
            {
                if (!Information.IsNothing(unitServiceDT))
                {
                    if (unitServiceDT.Rows.Count > 0)
                    {
                        railListValue = Strings.Trim(Conversions.ToString(unitServiceDT.Rows[0]["Booking Service"]));
                        switch (railListValue ?? "")
                        {
                            case "BLK":
                                {
                                    railListValue = "BULK";
                                    break;
                                }

                            case "BAG":
                                {
                                    railListValue = "BAG";
                                    break;
                                }

                            case "BGR":
                                {
                                    railListValue = "BAGGER";
                                    break;
                                }

                            default:
                                {
                                    railListValue = "";
                                    break;
                                }
                        }
                    }
                    else
                    {
                        railListValue = "";
                    }
                }
                else
                {
                    railListValue = "";
                }

                cboField.Text = railListValue;
            }
        }

        private void checkModCBO(string railListcolName, ComboBox fieldValue, BunifuButton btnEraseModCBO)
        {
            if (fieldCBOMatch(railListcolName, fieldValue))
            {
                btnEraseModCBO.Hide();
            }
            else
            {
                btnEraseModCBO.Show();
            }
        }

        private bool fieldCBOMatch(string railListColName, ComboBox cboField)
        {
            string railListValue = "";
            if (railListRecord.Rows.Count > 0)
            {
                var railListDate = railListRecord.Rows[0];
                if (!railListColName.Equals("Booking Service"))
                {
                    if (!Information.IsNothing(railListDate[railListColName]))
                    {
                        if (railListColName.Equals("Unit Status"))
                        {
                        }
                        // railListValue = GiveUnitStatus(Mid(railListRow("Unit Status"), 2, 1))

                        else if (railListColName.Equals("EQ Type Code"))
                        {
                            railListValue = GiveUnitType(Strings.Trim(Conversions.ToString(railListRow["EQ Type Code"])), Strings.Trim(Conversions.ToString(railListRow["Unit Number"])));
                        }
                        else if (railListColName.Equals("Shipper Name"))
                        {
                            railListValue = Strings.Trim(Conversions.ToString(railListRow["Shipper Name"]));
                        }

                        if (Strings.Trim(railListValue).Equals(Strings.Trim(cboField.Text)))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else if (Information.IsNothing(railListDate[railListColName]) & !string.IsNullOrEmpty(cboField.Text))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else if (railListColName.Equals("Booking Service"))
                {
                    if (!Information.IsNothing(unitServiceDT))
                    {
                        if (unitServiceDT.Rows.Count > 0)
                        {
                            railListValue = Strings.Trim(Conversions.ToString(unitServiceDT.Rows[0]["Booking Service"]));
                            switch (railListValue ?? "")
                            {
                                case "BLK":
                                    {
                                        railListValue = "BULK";
                                        break;
                                    }

                                case "BAG":
                                    {
                                        railListValue = "BAG";
                                        break;
                                    }

                                case "BGR":
                                    {
                                        railListValue = "BAGGER";
                                        break;
                                    }

                                default:
                                    {
                                        railListValue = "";
                                        break;
                                    }
                            }
                        }
                        else
                        {
                            railListValue = "";
                        }
                    }
                    else
                    {
                        railListValue = "";
                    }

                    if (Strings.Trim(railListValue).Equals(Strings.Trim(cboField.Text)))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (Information.IsNothing(railListDate[railListColName]) & !string.IsNullOrEmpty(cboField.Text))
                {
                    return false;
                }
                else
                {
                    return true;
                }

                return true;
            }
            else
            {
                return true;
            }
        }

        private bool fieldStringMatch(string railListCollname, BunifuTextBox textField)
        {
            string railInfo;
            if (railListRecord.Rows.Count > 0)
            {
                var railListDate = railListRecord.Rows[0];
                if (!Information.IsNothing(railListDate[railListCollname]))
                {
                    if (Strings.Trim(Conversions.ToString(railListDate[railListCollname])).Equals(Strings.Trim(textField.Text)))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (Information.IsNothing(railListDate[railListCollname]) & !string.IsNullOrEmpty(textField.Text))
                {
                    return false;
                }
                else
                {
                    return true;
                }

                return true;
            }
            else
            {
                return true;
            }
        }

        private void txtOrigin_TextChanged(object sender, EventArgs e)
        {
            if (isMultiEdit && !firstLoad)
            {
                foreach (var u in modifiedMultiEditUnitsList)
                    u.OriginLocation = Strings.Trim(txtOrigin.Text);
                VWUnitSourceBindingSource.DataSource = null;
                VWUnitSourceBindingSource.DataSource = modifiedMultiEditUnitsList;
            }
            else if (!firstLoad)
            {
                checkModCBOFields();
            }
        }

        private void btnEraseModOrigin_Click(object sender, EventArgs e)
        {
            resetTextField("Origin Location", txtOrigin);
            btnEraseModOrigin.Hide();
        }

        private void btnEraseModCarrier_Click(object sender, EventArgs e)
        {
            resetTextField("SASC", txtCarrier);
            btnEraseModCarrier.Hide();
        }

        private void btnEraseModETALocation_Click(object sender, EventArgs e)
        {
            resetTextField("ETA Location", txtETALocation);
            btnEraseModETALocation.Hide();
        }

        private void cboUnitStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isMultiEdit && !firstLoad)
            {
                foreach (var u in modifiedMultiEditUnitsList)
                {
                    u.UnitStatusId = Conversions.ToInteger(cboUnitStatus.SelectedValue);
                    u.UnitStatus = cboUnitStatus.Text;
                }

                VWUnitSourceBindingSource.DataSource = null;
                VWUnitSourceBindingSource.DataSource = modifiedMultiEditUnitsList;
            }
            else if (!firstLoad)
            {
                checkModCBOFields();
            }
        }

        private void cboUnitType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isMultiEdit && !firstLoad)
            {
                foreach (var u in modifiedMultiEditUnitsList)
                    u.UnitType = cboUnitType.Text;
                VWUnitSourceBindingSource.DataSource = null;
                VWUnitSourceBindingSource.DataSource = modifiedMultiEditUnitsList;
            }
            else if (!firstLoad)
            {
                checkModCBOFields();
            }
        }

        private void cboCargoType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!firstLoad)
            {
                checkModCBOFields();
            }
        }

        private void cboShipper_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isMultiEdit && !firstLoad)
            {
                foreach (var u in modifiedMultiEditUnitsList)
                {
                    u.ShipperId = (int?)cboShipper.SelectedValue;
                    u.ShipperName = cboShipper.Text;
                }

                VWUnitSourceBindingSource.DataSource = null;
                VWUnitSourceBindingSource.DataSource = modifiedMultiEditUnitsList;
            }
            else if (!firstLoad)
            {
                checkModCBOFields();
            }
        }

        private void btnEraseModUnitType_Click(object sender, EventArgs e)
        {
            resetCBOField("EQ Type Code", cboUnitType);
            btnEraseModUnitType.Hide();
        }

        private void btnEraseModStatus_Click(object sender, EventArgs e)
        {
            resetCBOField("Unit Status", cboUnitStatus);
            btnEraseModStatus.Hide();
        }

        private void btnEraseModCargoType_Click(object sender, EventArgs e)
        {
            resetCBOField("Booking Service", cboCargoType);
            btnEraseModCargoType.Hide();
        }

        private void nudDemurageDays_ValueChanged(object sender, EventArgs e)
        {
            if (isMultiEdit && !firstLoad)
            {
                foreach (var u in modifiedMultiEditUnitsList)
                    u.DemurageDays = (int?)nudDemurageDays.Value;
                VWUnitSourceBindingSource.DataSource = null;
                VWUnitSourceBindingSource.DataSource = modifiedMultiEditUnitsList;
            }
        }

        private void btnEraseModTotalBilled_Click(object sender, EventArgs e)
        {
            if (railListRecord.Rows.Count > 0)
            {
                nudTotalBilledWeight.Value = Conversions.ToDecimal(railListRow["Way_Bill_Net_Wgt"]);
            }

            btnEraseModTotalBilled.Hide();
        }

        private void txtUnitNumber_TextChanged(object sender, EventArgs e)
        {
            fieldsGoodToGo();
        }

        private void txtCarrier_TextChanged(object sender, EventArgs e)
        {
            if (isMultiEdit && !firstLoad)
            {
                foreach (var u in modifiedMultiEditUnitsList)
                    u.UnitLine = Strings.Trim(txtCarrier.Text);
                VWUnitSourceBindingSource.DataSource = null;
                VWUnitSourceBindingSource.DataSource = modifiedMultiEditUnitsList;
            }
            else if (!firstLoad)
            {
                checkModCBOFields();
            }
        }

        private void txtETALocation_TextChanged(object sender, EventArgs e)
        {
            if (isMultiEdit && !firstLoad)
            {
                foreach (var u in modifiedMultiEditUnitsList)
                    u.ETALocation = Strings.Trim(txtETALocation.Text);
                VWUnitSourceBindingSource.DataSource = null;
                VWUnitSourceBindingSource.DataSource = modifiedMultiEditUnitsList;
            }
        }

        private void txtLastLocation_TextChanged(object sender, EventArgs e)
        {
            if (isMultiEdit && !firstLoad)
            {
                foreach (var u in modifiedMultiEditUnitsList)
                    u.LastLocation = Strings.Trim(txtLastLocation.Text);
                VWUnitSourceBindingSource.DataSource = null;
                VWUnitSourceBindingSource.DataSource = modifiedMultiEditUnitsList;
            }
        }

        private void txtSequence_TextChanged(object sender, EventArgs e)
        {
            if (isMultiEdit && !firstLoad)
            {
                foreach (var u in modifiedMultiEditUnitsList)
                    u.Sequence = Strings.Trim(txtSequence.Text);
                VWUnitSourceBindingSource.DataSource = null;
                VWUnitSourceBindingSource.DataSource = modifiedMultiEditUnitsList;
            }
        }

        private void txtTrack_TextChanged(object sender, EventArgs e)
        {
            if (isMultiEdit && !firstLoad)
            {
                foreach (var u in modifiedMultiEditUnitsList)
                    u.Track = Strings.Trim(txtTrack.Text);
                VWUnitSourceBindingSource.DataSource = null;
                VWUnitSourceBindingSource.DataSource = modifiedMultiEditUnitsList;
            }
        }

        private void nudInTransitDays_ValueChanged(object sender, EventArgs e)
        {
            if (isMultiEdit && !firstLoad)
            {
                foreach (var u in modifiedMultiEditUnitsList)
                    u.InTransitDays = (int?)nudInTransitDays.Value;
                VWUnitSourceBindingSource.DataSource = null;
                VWUnitSourceBindingSource.DataSource = modifiedMultiEditUnitsList;
            }
        }

        private void btnStartOver_Click(object sender, EventArgs e)
        {
            modifiedMultiEditUnitsList = new List<VW_UnitSource>();
            CreateUnitsCopy(originalMultiEditUnitsList, ref modifiedMultiEditUnitsList);
            VWUnitSourceBindingSource.DataSource = null;
            VWUnitSourceBindingSource.DataSource = modifiedMultiEditUnitsList;
        }

        private void rmvMultiBk_Click(object sender, EventArgs e)
        {
            if (dgvMultiBk.Rows.Count > 0)
            {
                VW_UnitSource selectedUnit = (VW_UnitSource)dgvMultiBk.CurrentRow.DataBoundItem;
                modifiedMultiEditUnitsList.Remove(selectedUnit);
                VWUnitSourceBindingSource.DataSource = modifiedMultiEditUnitsList;
                rmvMultiBk.Enabled = true;
                btnEraseMod.Enabled = true;
            }
            else
            {
                rmvMultiBk.Enabled = false;
                btnEraseMod.Enabled = false;
            }
        }

        private void btnEraseMod_Click(object sender, EventArgs e)
        {
            int selectedIndex = dgvMultiBk.CurrentRow.Index;
            VW_UnitSource selectedUnit = (VW_UnitSource)dgvMultiBk.CurrentRow.DataBoundItem;

            // Create clone from original list
            var clonedOrigList = new List<VW_UnitSource>();
            CreateUnitsCopy(originalMultiEditUnitsList, ref clonedOrigList);

            // Replace information for original
            var originalUnitInfo = clonedOrigList.Where(b => b.UnitSourceId == selectedUnit.UnitSourceId).ElementAtOrDefault(0);
            modifiedMultiEditUnitsList[selectedIndex] = originalUnitInfo;
            VWUnitSourceBindingSource.DataSource = modifiedMultiEditUnitsList;
        }

        private void btnEraseLastLocation_Click(object sender, EventArgs e)
        {
            resetTextField("Sighting Location", txtLastLocation);
            btnEraseLastLocation.Hide();
        }

        private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstLoad == false)
            {
                if (isModField == true)
                {
                    var selectedRow = miniUnitDT[focusedMiniUnit];
                    selectedRow.CustomerId = Conversions.ToInteger(cboCustomer.SelectedValue);
                    selectedRow.CommodityId = Conversions.ToInteger(cboCommodity.SelectedValue);
                    selectedRow.GradeId = Conversions.ToInteger(cboGrade.SelectedValue);
                }
            }

            fieldsGoodToGo();
        }

        private void nudBKBilledWeight_ValueChanged(object sender, EventArgs e)
        {
            if (isModField == true)
            {
                var selectedRow = miniUnitDT[focusedMiniUnit];
                selectedRow.TotalBilled = nudTotalBilled.Value;
                selectedRow.BilledByUnit = nudPCWeight.Value;
                selectedRow.UnBilled = nudTotalUNBilled.Value;
                selectedRow.UnBilledByUnit = nudPCUNPiecesWeight.Value;
                if (nudTotalBilled.Value > 0m)
                {
                    btnAddMiniUnit.Enabled = true;
                }
                else
                {
                    btnAddMiniUnit.Enabled = false;
                }
            }
        }

        private void rbKG_CheckedChanged(object sender, EventArgs e)
        {
            if (firstLoad == false)
            {
                if (isModField == true)
                {
                    string PCUNBilledType;
                    var selectedRow = miniUnitDT[focusedMiniUnit];
                    string PCBilledType;
                    if (rbKG.Checked)
                    {
                        PCUNBilledType = "KG";
                    }
                    else if (rbLB.Checked)
                    {
                        PCUNBilledType = "LB";
                    }
                    else
                    {
                        PCUNBilledType = "MT";
                    }

                    if (rbKGPC.Checked)
                    {
                        PCBilledType = "KG";
                    }
                    else if (rbLBPC.Checked)
                    {
                        PCBilledType = "LB";
                    }
                    else
                    {
                        PCBilledType = "MT";
                    }

                    selectedRow.UnBilledByUnitUnitType = PCUNBilledType;
                    selectedRow.BilledByUnitUnitType = PCBilledType;
                }
            }
        }

        private void txtBKLocation_TextChanged(object sender, EventArgs e)
        {
            if (isModField == true)
            {
                var selectedRow = miniUnitDT[focusedMiniUnit];
                selectedRow.MULocation = txtLocation.Text;
                selectedRow.Comments = txtComments.Text;
                selectedRow.LotNumber = tbLotNumber.Text;
            }
        }

        public void SplitMU()
        {
            int focusedCopyMU;
            var focusedRow = miniUnitDT[focusedMiniUnit];
            var newRow = new MiniUnit();
            DataTable sortedTable;
            UpdateMUOrder();
            newRow.MiniUnitId = 0;
            newRow.MiniUnitOrder = miniUnitDT.Count + 1;
            newRow.UnitSourceId = focusedRow.UnitSourceId;
            newRow.TotalBilled = splitNumber;
            newRow.UnBilled = focusedRow.UnBilled;
            newRow.BilledByUnit = focusedRow.BilledByUnit;
            newRow.BilledByUnitUnitType = focusedRow.BilledByUnitUnitType;
            newRow.UnBilledByUnit = focusedRow.UnBilledByUnit;
            newRow.UnBilledByUnitUnitType = focusedRow.UnBilledByUnitUnitType;
            newRow.MULocation = focusedRow.MULocation;
            newRow.Comments = focusedRow.Comments;
            newRow.CustomerId = focusedRow.CustomerId;
            newRow.GradeId = focusedRow.GradeId;
            newRow.LotNumber = focusedRow.LotNumber;
            newRow.CommodityId = focusedRow.CommodityId;
            miniUnitDT.Add(newRow);
            miniUnitDT[focusedMiniUnit].TotalBilled = focusedRow.TotalBilled - splitNumber;
            focusedMiniUnit = miniUnitDT.Count - 1;
            focusedRow = miniUnitDT[focusedMiniUnit];
            PopulateMU();
            checkArrowButtons();
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}