using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using ModelLayer.CustomModel;
using WaitLoading;

namespace ShipSmpl
{
    public partial class frmVesselVoyageCSVUpdateType
    {
        public frmVesselVoyageCSVUpdateType()
        {
            InitializeComponent();
            _btnClose.Name = "btnClose";
            _btnClear.Name = "btnClear";
            _btnSave.Name = "btnSave";
            _dgvVesselVoyageCSV.Name = "dgvVesselVoyageCSV";
            _btnSave_2.Name = "btnSave_2";
            _ckbUpdateVoyage.Name = "ckbUpdateVoyage";
            _lblClosePanel.Name = "lblClosePanel";
        }

        private int countSyncError = 0;
        private WaitLoadingRun waitLoading = new WaitLoadingRun();
        public List<VesselVoyage> listVesselVoyage = new List<VesselVoyage>();
        public List<Vessel> ListVessel = new List<Vessel>();
        public List<VesselVoyageStatus> listVesselVoyageStatus = new List<VesselVoyageStatus>();
        public List<VesselVoyageList> listVesselVoyageList = new List<VesselVoyageList>();
        public List<VW_CompanyCompanyType> listCompany = new List<VW_CompanyCompanyType>();
        public List<CompanyAddress> listCompanyAddress = new List<CompanyAddress>();

        private void frmVesselVoyageCSVUpdate(object sender, EventArgs e)
        {
            LoadListVesselVoyage();
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlActions.Visible = false;
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearDataGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // waitLoading.Show()
            pnlActions.Visible = false;
            FieldsVerificationV2();
            if (countSyncError > 0)
            {
                waitLoading.Close();
                pnlMessageDefault.Visible = true;
                return;
            }

            SyncSaveV2();
            ClearDataGridView();
            My.MyProject.Forms.frmVesselVoyageList.SearchByColumn();
            // waitLoading.Close()
        }

        private void lblClosePanel_Click(object sender, EventArgs e)
        {
            pnlMessageDefault.Visible = false;
            pnlActions.Visible = false;
        }

        private void btnSave_2_Click(object sender, EventArgs e)
        {
            SyncSaveV2();
            My.MyProject.Forms.frmVesselVoyageList.LoadForm();
            My.MyProject.Forms.frmVesselVoyageList.SearchByColumn();
        }

        private void ckbUpdateVoyage_Click(object sender, EventArgs e)
        {
            if (ckbUpdateVoyage.Checked)
            {
                btnSave_2.Visible = true;
                lbMessage.Items.Add("You can synchronize. Use the Button below this message box.");
            }
            else
            {
                btnSave_2.Visible = false;
                lbMessage.Items.Add("To synchronize and update the data, enable the checkbox.");
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */

        // New Methods START --------------------------------------------------------
        public void LoadListVesselVoyage()
        {
            waitLoading.Show();
            listVesselVoyage = VesselVoyageService.GetVesselByActive(true, false);
            ListVessel = VesselService.GetVesselByActive(true, false);
            listCompany = CompanyService.GetCompaniesByTypeId(5);
            listVesselVoyageStatus = VesselVoyageStatusService.GetAll();
            listCompanyAddress = CompanyAddressService.GetAll();
            waitLoading.Close();
        }

        private bool DuplicateVoyage(string VoyageNumber, int VesselId, int PortNameId, int VesselVoyageId)
        {
            bool isUnique = false;
            var L = listVesselVoyageList.FindAll((p) => (p.VoyageNumber ?? "") == (VoyageNumber ?? "") & p.VesselId == VesselId & p.PortId == PortNameId & p.IsActiveTrip == true);
            if (L.Count > 0)
            {
                foreach (VesselVoyageList item in L)
                {
                    if (item.VesselVoyageId != VesselVoyageId)
                    {
                        isUnique = true;
                    }
                }
            }

            return isUnique;
        }

        private bool DuplicateVoyageInGrid(string VoyageNumber, string VesselName, string PortName)
        {
            bool isUnique = false;
            int countQty = 0;
            foreach (DataGridViewRow row in dgvVesselVoyageCSV.Rows)
            {
                try
                {
                    if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.ConditionalCompareObjectEqual(VoyageNumber, row.Cells[1].Value, false), Operators.ConditionalCompareObjectEqual(VesselName, row.Cells[2].Value, false)), Operators.ConditionalCompareObjectEqual(PortName, row.Cells[7].Value, false))))
                    {
                        countQty += 1;
                    }
                }
                catch (Exception ex)
                {
                }
            }

            if (countQty > 1)
            {
                isUnique = true;
            }

            return isUnique;
        }

        private bool UniqueVoyageUpdate(string VoyageNumber, int VesselId, int PortNameId)
        {
            bool isUnique = false;
            var L = listVesselVoyageList.FindAll((p) => (p.VoyageNumber ?? "") == (VoyageNumber ?? "") & p.VesselId == VesselId & p.PortId == PortNameId);
            if (L.Count > 0)
            {
            }

            return isUnique;
        }

        private void FieldsVerificationV2()
        {
            int countRow = 0;
            int IdVesselVoyage = 0;
            int countActive = 0;
            int countVoyageNumber = 0;
            int countPortName = 0;
            int countERD = 0;
            int countLRD = 0;
            int countETA = 0;
            int countETD = 0;
            int countVessel = 0;
            int countVoyageNumber_Vessel_Port = 0;
            int IdVessel = 0;
            int PortNameId = 0;
            string LineNum = "";
            pnlActions.Visible = false;
            lbMessage.Items.Clear();
            if (dgvVesselVoyageCSV.Rows.Count <= 1)
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("To update only one Vessel, use the Edit option.", "", this);
                return;
            }

            RemoveColorsGrid();
            foreach (DataGridViewRow row in dgvVesselVoyageCSV.Rows)
            {
                countRow += 1;
                try
                {
                    if (countRow < dgvVesselVoyageCSV.Rows.Count)
                    {
                        LineNum = "Row " + countRow.ToString();
                        row.Cells[0].Value = countRow.ToString();
                        string VoyageNumber = Conversions.ToString(row.Cells[1].Value);
                        string Vessel = Conversions.ToString(row.Cells[2].Value);
                        string ERD = Conversions.ToString(row.Cells[3].Value);
                        string LRD = Conversions.ToString(row.Cells[4].Value);
                        string ETA = Conversions.ToString(row.Cells[5].Value);
                        string ETD = Conversions.ToString(row.Cells[6].Value);
                        string PortName = Conversions.ToString(row.Cells[7].Value);
                        string Status = Conversions.ToString(row.Cells[8].Value);
                        string Active = Conversions.ToString(row.Cells[9].Value);
                        PortNameId = ReturnPortId(PortName);
                        IdVessel = ReturnsVesselId(Vessel);
                        IdVesselVoyage = ReturnsVesselVoyageId(VoyageNumber, IdVessel, PortNameId);
                        if (string.IsNullOrEmpty(VoyageNumber) | string.IsNullOrWhiteSpace(VoyageNumber))
                        {
                            row.Cells[1].Style.BackColor = Color.Red;
                            countVoyageNumber += 1;
                            lbMessage.Items.Add(LineNum + " - The field Voyage Number is Empty.");
                        }
                        else
                        {
                            row.Cells[1].Style.BackColor = Color.White;
                        }

                        if (string.IsNullOrEmpty(Vessel) | string.IsNullOrWhiteSpace(Vessel))
                        {
                            row.Cells[2].Style.BackColor = Color.Red;
                            countVessel += 1;
                            lbMessage.Items.Add(LineNum + " - Field Vessel is Empty.");
                        }
                        else if (IdVessel == 0)
                        {
                            row.Cells[2].Style.BackColor = Color.Red;
                            countVessel += 1;
                            lbMessage.Items.Add(LineNum + " - There is no Vessel with that Name. Please check and correct.");
                        }
                        else
                        {
                            row.Cells[2].Style.BackColor = Color.White;
                        }

                        if (string.IsNullOrEmpty(PortName) | string.IsNullOrWhiteSpace(PortName))
                        {
                            row.Cells[7].Style.BackColor = Color.Red;
                            countPortName += 1;
                            lbMessage.Items.Add(LineNum + " - Field Port Name is Empty.");
                        }
                        else if (PortNameId == 0)
                        {
                            row.Cells[7].Style.BackColor = Color.Red;
                            countPortName += 1;
                            lbMessage.Items.Add(LineNum + " - There is no Port Name with that Name. Please check and correct.");
                        }
                        else
                        {
                            row.Cells[7].Style.BackColor = Color.White;
                        }

                        if (string.IsNullOrEmpty(ERD) | string.IsNullOrWhiteSpace(ERD) | string.IsNullOrEmpty(ERD))
                        {
                            row.Cells[3].Style.BackColor = Color.Red;
                            countERD += 1;
                            lbMessage.Items.Add(LineNum + " - Field ERD is empty.");
                        }
                        else if (ValidateDate(ERD))
                        {
                            row.Cells[3].Style.BackColor = Color.White;
                        }
                        else
                        {
                            row.Cells[3].Style.BackColor = Color.Red;
                            countLRD += 1;
                            lbMessage.Items.Add(LineNum + " - Field ERD is not correct date formate. Please use this formate: dd/mm/yyyy hh:mm");
                        }

                        if (string.IsNullOrEmpty(LRD) | string.IsNullOrWhiteSpace(LRD) | string.IsNullOrEmpty(LRD))
                        {
                            row.Cells[4].Style.BackColor = Color.Red;
                            countLRD += 1;
                            lbMessage.Items.Add(LineNum + " - Field LRD is empty.");
                        }
                        else if (ValidateDate(LRD))
                        {
                            if (VerifyLRDIsMoreOrEqualToday(LRD))
                            {
                                row.Cells[4].Style.BackColor = Color.White;
                            }
                            else
                            {
                                row.Cells[4].Style.BackColor = Color.Red;
                                countLRD += 1;
                                lbMessage.Items.Add(LineNum + " - LRD must have a date greater than or equal to yesterday's date.");
                            }
                        }
                        else
                        {
                            row.Cells[4].Style.BackColor = Color.Red;
                            countLRD += 1;
                            lbMessage.Items.Add(LineNum + " - Field LRD is not correct date formate. Please use this formate: dd/mm/yyyy hh:mm");
                        }

                        if (string.IsNullOrEmpty(ETA) | string.IsNullOrWhiteSpace(ETA) | string.IsNullOrEmpty(ETA))
                        {
                            row.Cells[5].Style.BackColor = Color.White;
                        }
                        else if (ValidateDate(ETA))
                        {
                            row.Cells[5].Style.BackColor = Color.White;
                        }
                        else
                        {
                            row.Cells[5].Style.BackColor = Color.Red;
                            countETA += 1;
                            lbMessage.Items.Add(LineNum + " - Field ETA is not correct date formate. Please use this formate: dd/mm/yyyy hh:mm");
                        }

                        if (string.IsNullOrEmpty(ETD) | string.IsNullOrWhiteSpace(ETD) | string.IsNullOrEmpty(ETD))
                        {
                            row.Cells[6].Style.BackColor = Color.Red;
                            countETD += 1;
                            lbMessage.Items.Add(LineNum + " - ETD is empty.");
                        }
                        else if (ValidateDate(ETD))
                        {
                            if (string.IsNullOrEmpty(LRD) == false | string.IsNullOrWhiteSpace(LRD) == false)
                            {
                                if (ValidateDate(LRD))
                                {
                                    if (CompareETDIsEqualOrMoreLRD(ETD, LRD))
                                    {
                                        row.Cells[6].Style.BackColor = Color.White;
                                    }
                                    else
                                    {
                                        row.Cells[6].Style.BackColor = Color.Red;
                                        countETD += 1;
                                        lbMessage.Items.Add(LineNum + " - ETD must have a date greater than or equal to LRD date.");
                                    }
                                }
                                else
                                {
                                    row.Cells[6].Style.BackColor = Color.Red;
                                    countETD += 1;
                                    lbMessage.Items.Add(LineNum + " - Field LRD is not correct date formate. Please use this formate: dd/mm/yyyy hh:mm.");
                                }
                            }
                        }
                        else
                        {
                            row.Cells[6].Style.BackColor = Color.Red;
                            countETD += 1;
                            lbMessage.Items.Add(LineNum + " - Field ETD is not correct date formate. Please use this formate: dd/mm/yyyy hh:mm");
                        }

                        if (string.IsNullOrEmpty(Active))
                        {
                            row.Cells[9].Style.BackColor = Color.Red;
                            countActive += 1;
                            lbMessage.Items.Add(LineNum + " - Field is empty, please insert TRUE or FALSE in Field Active.");
                        }
                        else
                        {
                            switch (Active.ToUpper() ?? "")
                            {
                                case "TRUE":
                                    {
                                        // Verify Duplicate in Data Base
                                        if (DuplicateVoyage(VoyageNumber, IdVessel, PortNameId, IdVesselVoyage))
                                        {
                                            row.Cells[0].Style.BackColor = Color.Coral;
                                            row.Cells[1].Style.BackColor = Color.Coral;
                                            row.Cells[2].Style.BackColor = Color.Coral;
                                            row.Cells[3].Style.BackColor = Color.Coral;
                                            row.Cells[4].Style.BackColor = Color.Coral;
                                            row.Cells[5].Style.BackColor = Color.Coral;
                                            row.Cells[6].Style.BackColor = Color.Coral;
                                            row.Cells[7].Style.BackColor = Color.Coral;
                                            row.Cells[8].Style.BackColor = Color.Coral;
                                            row.Cells[9].Style.BackColor = Color.Coral;
                                            countVoyageNumber_Vessel_Port += 1;
                                            lbMessage.Items.Add(LineNum + " - There is already an active Vessel Voyage for this Vessel for the same Port Name.");
                                        }
                                        // Verify Duplicate in Data Grid View
                                        else if (DuplicateVoyageInGrid(VoyageNumber, Vessel, PortName))
                                        {
                                            row.Cells[0].Style.BackColor = Color.Coral;
                                            row.Cells[1].Style.BackColor = Color.Coral;
                                            row.Cells[2].Style.BackColor = Color.Coral;
                                            row.Cells[3].Style.BackColor = Color.Coral;
                                            row.Cells[4].Style.BackColor = Color.Coral;
                                            row.Cells[5].Style.BackColor = Color.Coral;
                                            row.Cells[6].Style.BackColor = Color.Coral;
                                            row.Cells[7].Style.BackColor = Color.Coral;
                                            row.Cells[8].Style.BackColor = Color.Coral;
                                            row.Cells[9].Style.BackColor = Color.Coral;
                                            countVoyageNumber_Vessel_Port += 1;
                                            lbMessage.Items.Add(LineNum + " - There is already an active Vessel Voyage for this Vessel for the same Port Name.");
                                        }

                                        break;
                                    }

                                case "FALSE":
                                    {
                                        row.Cells[9].Style.BackColor = Color.White;
                                        break;
                                    }

                                case var @case when @case == "":
                                    {
                                        row.Cells[9].Style.BackColor = Color.Red;
                                        countActive += 1;
                                        lbMessage.Items.Add(LineNum + " - Field is empty, please insert TRUE or FALSE in Field Active.");
                                        break;
                                    }

                                default:
                                    {
                                        row.Cells[9].Style.BackColor = Color.Red;
                                        countActive += 1;
                                        lbMessage.Items.Add(LineNum + " - Insert TRUE or FALSE in Field Active.");
                                        break;
                                    }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    string a = ex.ToString();
                    lbMessage.Items.Add(LineNum + " - An error has occurred that cannot be identified, please check the data provided.");
                }
            }

            if (countVoyageNumber > 0)
            {
                dgvVesselVoyageCSV.Columns[1].HeaderCell.Style.BackColor = Color.Red;
            }
            else
            {
                dgvVesselVoyageCSV.Columns[1].HeaderCell.Style.BackColor = Color.White;
            }

            if (countVessel > 0)
            {
                dgvVesselVoyageCSV.Columns[2].HeaderCell.Style.BackColor = Color.Red;
            }
            else
            {
                dgvVesselVoyageCSV.Columns[2].HeaderCell.Style.BackColor = Color.White;
            }

            if (countERD > 0)
            {
                dgvVesselVoyageCSV.Columns[3].HeaderCell.Style.BackColor = Color.Red;
            }
            else
            {
                dgvVesselVoyageCSV.Columns[3].HeaderCell.Style.BackColor = Color.White;
            }

            if (countLRD > 0)
            {
                dgvVesselVoyageCSV.Columns[4].HeaderCell.Style.BackColor = Color.Red;
            }
            else
            {
                dgvVesselVoyageCSV.Columns[4].HeaderCell.Style.BackColor = Color.White;
            }

            if (countETA > 0)
            {
                dgvVesselVoyageCSV.Columns[5].HeaderCell.Style.BackColor = Color.Red;
            }
            else
            {
                dgvVesselVoyageCSV.Columns[5].HeaderCell.Style.BackColor = Color.White;
            }

            if (countETD > 0)
            {
                dgvVesselVoyageCSV.Columns[6].HeaderCell.Style.BackColor = Color.Red;
            }
            else
            {
                dgvVesselVoyageCSV.Columns[6].HeaderCell.Style.BackColor = Color.White;
            }

            if (countPortName > 0)
            {
                dgvVesselVoyageCSV.Columns[7].HeaderCell.Style.BackColor = Color.Red;
            }
            else
            {
                dgvVesselVoyageCSV.Columns[7].HeaderCell.Style.BackColor = Color.White;
            }

            if (countActive > 0)
            {
                dgvVesselVoyageCSV.Columns[9].HeaderCell.Style.BackColor = Color.Red;
            }
            else
            {
                dgvVesselVoyageCSV.Columns[9].HeaderCell.Style.BackColor = Color.White;
            }

            countSyncError = countVoyageNumber + countVessel + countERD + countLRD + countETA + countETD + countPortName + countActive;

            // If countVoyageNumber_Vessel_Port > 0 And countSyncError = 0 Then
            // ckbUpdateVoyage.Visible = True
            // ckbUpdateVoyage.Checked = False
            // Else
            // ckbUpdateVoyage.Visible = False
            // ckbUpdateVoyage.Checked = False
            // End If

            countSyncError = countSyncError + countVoyageNumber_Vessel_Port;
        }

        private int ReturnsVesselId(string VesselName)
        {
            int Id = 0;
            var L = ListVessel.FindAll((p) => (p.VesselName ?? "") == (VesselName ?? ""));
            if (L.Count > 0)
            {
                foreach (Vessel item in L)
                    Id = item.VesselId;
            }

            return Id;
        }

        private int ReturnsVesselVoyageId(string VoyageNumber, int IdVessel, int PortNameId)
        {
            int Id = 0;
            var Lid = listVesselVoyageList.FindAll((p) => (p.VoyageNumber ?? "") == (VoyageNumber ?? "") & p.VesselId == IdVessel & p.PortId == PortNameId & p.IsActiveTrip == true);
            if (Lid.Count > 0)
            {
                foreach (var item in Lid)
                    Id = item.VesselVoyageId;
            }

            return Id;
        }

        private int ReturnPortId(string PortName)
        {
            int Id = 0;
            var L = listCompany.FindAll((p) => (p.CompanyName ?? "") == (PortName ?? ""));
            if (L.Count > 0)
            {
                foreach (VW_CompanyCompanyType item in L)
                    Id = item.CompanyId;
            }

            return Id;
        }

        private int ReturnVoyageStatusId(string VesselVoyageStatus)
        {
            int Id = 0;
            var L = listVesselVoyageStatus.FindAll((p) => (p.StatusName ?? "") == (VesselVoyageStatus ?? ""));
            if (L.Count > 0)
            {
                foreach (VesselVoyageStatus item in L)
                    Id = item.VesselVoyageStatusId;
            }

            return Id;
        }

        private void SyncSaveV2()
        {
            int countRow = 0;
            int IdVesselVoyage = 0;
            int IdVessel = 0;
            int VesselVoyageStatusId = 0;
            string PortCoutry = "";
            string PortCity = "";
            int PortNameId = 0;
            bool isActive = false;
            int countInsert = 0;
            int countUpdate = 0;
            if (dgvVesselVoyageCSV.Rows.Count > 1)
            {
                pnlSynchronizingData.Visible = true;
                ProgressBar1.Minimum = 0;
                ProgressBar1.Maximum = dgvVesselVoyageCSV.Rows.Count;
                ProgressBar1.Value = 0;
                ProgressBar1.Step = 1;
            }

            foreach (DataGridViewRow row in dgvVesselVoyageCSV.Rows)
            {
                countRow += 1;
                try
                {
                    if (countRow < dgvVesselVoyageCSV.Rows.Count)
                    {
                        string VoyageNumber = Conversions.ToString(row.Cells[1].Value);
                        string Vessel = Conversions.ToString(row.Cells[2].Value);
                        string ERD = Conversions.ToString(row.Cells[3].Value);
                        string LRD = Conversions.ToString(row.Cells[4].Value);
                        string ETA = Conversions.ToString(row.Cells[5].Value);
                        string ETD = Conversions.ToString(row.Cells[6].Value);
                        string PortName = Conversions.ToString(row.Cells[7].Value);
                        string Status = Conversions.ToString(row.Cells[8].Value);
                        string Active = Conversions.ToString(row.Cells[9].Value);
                        PortNameId = ReturnPortId(PortName);
                        VesselVoyageStatusId = ReturnVoyageStatusId(Status);
                        IdVessel = ReturnsVesselId(Vessel);
                        IdVesselVoyage = ReturnsVesselVoyageId(VoyageNumber, IdVessel, PortNameId);
                        ERD = ReturnDateFormat(ERD);
                        LRD = ReturnDateFormat(LRD);
                        ETA = ReturnDateFormat(ETA);
                        ETD = ReturnDateFormat(ETD);
                        
                        //var L = listCompanyAddress.FindAll((p) => p.CompanyId == PortNameId);

                        WTCCeresEntities db = new WTCCeresEntities();

                        var L = (from co in db.Company
                                 join ca in db.CompanyAddress on co.CompanyId equals ca.CompanyId
                                 join rc in db.RegionCity on ca.RegionCityId equals rc.RegionCityId
                                 join cr in db.CountryRegion on rc.CountryRegionId equals cr.CountryRegionId
                                 join c in db.Country on cr.CountryId equals c.CountryId
                                 where co.CompanyId == PortNameId
                                 select new {
                                     CountryName = c.CountryName,
                                     CityName = rc.CityName
                                 }).ToList();

                        if (L.Count > 0)
                        {
                            foreach (var item in L)
                            {
                                PortCoutry = item.CountryName.TrimEnd().ToUpper();
                                PortCity = item.CityName.TrimEnd().ToUpper();
                            }
                        }


                        if (Active.ToUpper().Equals("TRUE"))
                        {
                            isActive = true;
                        }
                        else
                        {
                            isActive = false;
                        }

                        if (IdVesselVoyage == 0)
                        {
                            if (VesselVoyageService.Insert(VoyageNumber, ERD, LRD, ETA, ETD, PortCity, PortCoutry, isActive, VesselVoyageStatusId, IdVessel, PortNameId))
                            {
                                countInsert += 1;
                                if (EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, VesselVoyageService.GetLastVesselVoyageId().ToString(), "INSERT", "VESSEL VOYAGE", "Create of vessel voyage information using CSV"))
                                {
                                }
                            }
                            else
                            {
                                pnlMessage.Visible = true;
                            }
                        }
                        else
                        {
                            var VVActive = default(bool);
                            var Lid = listVesselVoyageList.FindAll((p) => p.VesselVoyageId == IdVesselVoyage);
                            foreach (var item in Lid)
                                VVActive = item.IsActiveTrip == true;

                            // If Vessel Voyage is active, it updates Voayge, if it is not active it creates a new Vessel Voyage
                            if (VVActive)
                            {
                                if (VesselVoyageService.Update(IdVesselVoyage, VoyageNumber, ERD, LRD, ETA, ETD, PortCity, PortCoutry, isActive, VesselVoyageStatusId, IdVessel, PortNameId))
                                {
                                    countUpdate += 1;
                                    if (EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, IdVesselVoyage.ToString(), "UPDATE", "VESSEL VOYAGE", "Edition of vessel voyage information using CSV"))
                                    {
                                    }
                                }
                                else
                                {
                                    pnlMessage.Visible = true;
                                }
                            }
                            else if (VesselVoyageService.Insert(VoyageNumber, ERD, LRD, ETA, ETD, PortCity, PortCoutry, isActive, VesselVoyageStatusId, IdVessel, PortNameId))
                            {
                                countInsert += 1;
                                if (EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, VesselVoyageService.GetLastVesselVoyageId().ToString(), "INSERT", "VESSEL VOYAGE", "Create of vessel voyage information using CSV"))
                                {
                                }
                            }
                            else
                            {
                                pnlMessage.Visible = true;
                            }
                        }

                        ProgressBar1.PerformStep();
                    }
                }
                catch (Exception ex)
                {
                    string a = ex.ToString();
                    pnlMessage.Visible = true;
                }
            }

            pnlSynchronizingData.Visible = false;
            pnlActions.Visible = true;
            lblInserted.Text = countInsert.ToString();
            lblUpdated.Text = countUpdate.ToString();
            My.MyProject.Forms.frmVesselVoyageList.LoadForm();
        }

        // New Methods END --------------------------------------------------------

        public void ClearDataGridView()
        {
            dgvVesselVoyageCSV.Rows.Clear();
            pnlMessage.Visible = false;
            pnlMessageDefault.Visible = false;
            ckbUpdateVoyage.Checked = false;
            ckbUpdateVoyage.Visible = false;
            dgvVesselVoyageCSV.Columns[0].HeaderCell.Style.BackColor = Color.White;
            dgvVesselVoyageCSV.Columns[1].HeaderCell.Style.BackColor = Color.White;
            dgvVesselVoyageCSV.Columns[2].HeaderCell.Style.BackColor = Color.White;
            dgvVesselVoyageCSV.Columns[3].HeaderCell.Style.BackColor = Color.White;
            dgvVesselVoyageCSV.Columns[4].HeaderCell.Style.BackColor = Color.White;
            dgvVesselVoyageCSV.Columns[5].HeaderCell.Style.BackColor = Color.White;
            dgvVesselVoyageCSV.Columns[6].HeaderCell.Style.BackColor = Color.White;
            dgvVesselVoyageCSV.Columns[7].HeaderCell.Style.BackColor = Color.White;
            dgvVesselVoyageCSV.Columns[8].HeaderCell.Style.BackColor = Color.White;
        }

        public void RemoveColorsGrid()
        {
            foreach (DataGridViewRow row in dgvVesselVoyageCSV.Rows)
            {
                row.Cells[0].Style.BackColor = Color.White;
                row.Cells[1].Style.BackColor = Color.White;
                row.Cells[2].Style.BackColor = Color.White;
                row.Cells[3].Style.BackColor = Color.White;
                row.Cells[4].Style.BackColor = Color.White;
                row.Cells[5].Style.BackColor = Color.White;
                row.Cells[6].Style.BackColor = Color.White;
                row.Cells[7].Style.BackColor = Color.White;
                row.Cells[8].Style.BackColor = Color.White;
                row.Cells[9].Style.BackColor = Color.White;
            }
        }

        private void FieldsVerification()
        {
            waitLoading.Show();
            int countRow = 0;
            int countActive = 0;
            int countVoyageNumber = 0;
            int countPortName = 0;
            int countERD = 0;
            int countLRD = 0;
            int countETA = 0;
            int countETD = 0;
            int countVessel = 0;
            int countVoyageNumber_Vessel_Port = 0;
            int IdVessel = 0;
            int PortNameId = 0;
            lbMessage.Items.Clear();
            if (dgvVesselVoyageCSV.Rows.Count <= 1)
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("To update only one Vessel, use the Edit option.", "", this);
                return;
            }

            RemoveColorsGrid();
            foreach (DataGridViewRow row in dgvVesselVoyageCSV.Rows)
            {
                countRow += 1;
                try
                {
                    if (countRow < dgvVesselVoyageCSV.Rows.Count)
                    {
                        string VoyageNumber = Conversions.ToString(row.Cells[0].Value);
                        string Vessel = Conversions.ToString(row.Cells[1].Value);
                        string ERD = Conversions.ToString(row.Cells[2].Value);
                        string LRD = Conversions.ToString(row.Cells[3].Value);
                        string ETA = Conversions.ToString(row.Cells[4].Value);
                        string ETD = Conversions.ToString(row.Cells[5].Value);
                        string PortName = Conversions.ToString(row.Cells[6].Value);
                        string Status = Conversions.ToString(row.Cells[7].Value);
                        string Active = Conversions.ToString(row.Cells[8].Value);
                        if (string.IsNullOrEmpty(Vessel) | string.IsNullOrWhiteSpace(Vessel) | Vessel is object)
                        {
                            IdVessel = VesselService.GetVesselIdByVesselName(Vessel);
                        }

                        if (string.IsNullOrEmpty(PortName) | string.IsNullOrWhiteSpace(PortName) | PortName is object)
                        {
                            PortNameId = CompanyService.GetCompanyIdByCompanyName(PortName);
                        }

                        if (string.IsNullOrEmpty(VoyageNumber) | string.IsNullOrWhiteSpace(VoyageNumber))
                        {
                            row.Cells[0].Style.BackColor = Color.Red;
                            countVoyageNumber += 1;
                            lbMessage.Items.Add("Row " + countRow.ToString() + " - The field Voyage Number is Empty.");
                        }
                        else
                        {
                            row.Cells[0].Style.BackColor = Color.White;
                        }

                        if (string.IsNullOrEmpty(Vessel) | string.IsNullOrWhiteSpace(Vessel))
                        {
                            row.Cells[1].Style.BackColor = Color.Red;
                            countVessel += 1;
                            lbMessage.Items.Add("Row " + countRow.ToString() + " - Field Vessel is Empty.");
                        }
                        else if (IdVessel == 0)
                        {
                            row.Cells[1].Style.BackColor = Color.Red;
                            countVessel += 1;
                            lbMessage.Items.Add("Row " + countRow.ToString() + " - There is no Vessel with that Name. Please check and correct.");
                        }
                        else
                        {
                            row.Cells[1].Style.BackColor = Color.White;
                        }

                        if (string.IsNullOrEmpty(PortName) | string.IsNullOrWhiteSpace(PortName))
                        {
                            row.Cells[6].Style.BackColor = Color.Red;
                            countPortName += 1;
                            lbMessage.Items.Add("Row " + countRow.ToString() + " - Field Port Name is Empty.");
                        }
                        else if (PortNameId == 0)
                        {
                            row.Cells[6].Style.BackColor = Color.Red;
                            countPortName += 1;
                            lbMessage.Items.Add("Row " + countRow.ToString() + " - There is no Port Name with that Name. Please check and correct.");
                        }
                        else
                        {
                            row.Cells[6].Style.BackColor = Color.White;
                        }

                        if (string.IsNullOrEmpty(ERD) | string.IsNullOrWhiteSpace(ERD) | string.IsNullOrEmpty(ERD))
                        {
                            row.Cells[2].Style.BackColor = Color.Red;
                            countERD += 1;
                            lbMessage.Items.Add("Row " + countRow.ToString() + " - Field ERD is empty.");
                        }
                        else if (ValidateDate(ERD))
                        {
                            row.Cells[2].Style.BackColor = Color.White;
                        }
                        else
                        {
                            row.Cells[2].Style.BackColor = Color.Red;
                            countLRD += 1;
                            lbMessage.Items.Add("Row " + countRow.ToString() + " - Field ERD is not correct date formate. Please use this formate: dd/mm/yyyy hh:mm");
                        }

                        if (string.IsNullOrEmpty(LRD) | string.IsNullOrWhiteSpace(LRD) | string.IsNullOrEmpty(LRD))
                        {
                            row.Cells[3].Style.BackColor = Color.Red;
                            countLRD += 1;
                            lbMessage.Items.Add("Row " + countRow.ToString() + " - Field LRD is empty.");
                        }
                        else if (ValidateDate(LRD))
                        {
                            if (VerifyLRDIsMoreOrEqualToday(LRD))
                            {
                                row.Cells[3].Style.BackColor = Color.White;
                            }
                            else
                            {
                                row.Cells[3].Style.BackColor = Color.Red;
                                countLRD += 1;
                                lbMessage.Items.Add("Row " + countRow.ToString() + " - LRD must have a date greater than or equal to yesterday's date.");
                            }
                        }
                        else
                        {
                            row.Cells[3].Style.BackColor = Color.Red;
                            countLRD += 1;
                            lbMessage.Items.Add("Row " + countRow.ToString() + " - Field LRD is not correct date formate. Please use this formate: dd/mm/yyyy hh:mm");
                        }

                        if (string.IsNullOrEmpty(ETA) | string.IsNullOrWhiteSpace(ETA) | string.IsNullOrEmpty(ETA))
                        {
                            row.Cells[4].Style.BackColor = Color.White;
                        }
                        else if (ValidateDate(ETA))
                        {
                            row.Cells[4].Style.BackColor = Color.White;
                        }
                        else
                        {
                            row.Cells[4].Style.BackColor = Color.Red;
                            countETA += 1;
                            lbMessage.Items.Add("Row " + countRow.ToString() + " - Field ETA is not correct date formate. Please use this formate: dd/mm/yyyy hh:mm");
                        }

                        if (string.IsNullOrEmpty(ETD) | string.IsNullOrWhiteSpace(ETD) | string.IsNullOrEmpty(ETD))
                        {
                            row.Cells[5].Style.BackColor = Color.Red;
                            countETD += 1;
                            lbMessage.Items.Add("Row " + countRow.ToString() + " - ETD is empty.");
                        }
                        else if (ValidateDate(ETD))
                        {
                            if (string.IsNullOrEmpty(LRD) == false | string.IsNullOrWhiteSpace(LRD) == false)
                            {
                                if (ValidateDate(LRD))
                                {
                                    if (CompareETDIsEqualOrMoreLRD(ETD, LRD))
                                    {
                                        row.Cells[5].Style.BackColor = Color.White;
                                    }
                                    else
                                    {
                                        row.Cells[5].Style.BackColor = Color.Red;
                                        countETD += 1;
                                        lbMessage.Items.Add("Row " + countRow.ToString() + " - ETD must have a date greater than or equal to LRD date.");
                                    }
                                }
                                else
                                {
                                    row.Cells[5].Style.BackColor = Color.Red;
                                    countETD += 1;
                                    lbMessage.Items.Add("Row " + countRow.ToString() + " - Field LRD is not correct date formate. Please use this formate: dd/mm/yyyy hh:mm.");
                                }
                            }
                        }
                        else
                        {
                            row.Cells[5].Style.BackColor = Color.Red;
                            countETD += 1;
                            lbMessage.Items.Add("Row " + countRow.ToString() + " - Field ETD is not correct date formate. Please use this formate: dd/mm/yyyy hh:mm");
                        }

                        if (string.IsNullOrEmpty(Active))
                        {
                            row.Cells[8].Style.BackColor = Color.Red;
                            countActive += 1;
                            lbMessage.Items.Add("Row " + countRow.ToString() + " - Field is empty, please insert TRUE or FALSE in Field Active.");
                        }
                        else
                        {
                            switch (Active.ToUpper() ?? "")
                            {
                                case "TRUE":
                                    {
                                        if (VesselVoyageService.GetUniqueActiveVoyageByVoyageNumber_Vessel_Port(VoyageNumber, IdVessel, PortNameId))
                                        {
                                            row.Cells[0].Style.BackColor = Color.Coral;
                                            row.Cells[1].Style.BackColor = Color.Coral;
                                            row.Cells[2].Style.BackColor = Color.Coral;
                                            row.Cells[3].Style.BackColor = Color.Coral;
                                            row.Cells[4].Style.BackColor = Color.Coral;
                                            row.Cells[5].Style.BackColor = Color.Coral;
                                            row.Cells[6].Style.BackColor = Color.Coral;
                                            row.Cells[7].Style.BackColor = Color.Coral;
                                            row.Cells[8].Style.BackColor = Color.Coral;
                                            countVoyageNumber_Vessel_Port += 1;
                                            lbMessage.Items.Add("Row " + countRow.ToString() + " - There is already an active Vessel Voyage for this Vessel for the same Port Name.");
                                        }

                                        break;
                                    }

                                case "FALSE":
                                    {
                                        row.Cells[8].Style.BackColor = Color.White;
                                        break;
                                    }

                                case var @case when @case == "":
                                    {
                                        row.Cells[8].Style.BackColor = Color.Red;
                                        countActive += 1;
                                        lbMessage.Items.Add("Row " + countRow.ToString() + " - Field is empty, please insert TRUE or FALSE in Field Active.");
                                        break;
                                    }

                                default:
                                    {
                                        row.Cells[8].Style.BackColor = Color.Red;
                                        countActive += 1;
                                        lbMessage.Items.Add("Row " + countRow.ToString() + " - Insert TRUE or FALSE in Field Active.");
                                        break;
                                    }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    string a = ex.ToString();
                    lbMessage.Items.Add("Row " + countRow.ToString() + " - An error has occurred that cannot be identified, please check the data provided.");
                }
            }

            if (countVoyageNumber > 0)
            {
                dgvVesselVoyageCSV.Columns[0].HeaderCell.Style.BackColor = Color.Red;
            }
            else
            {
                dgvVesselVoyageCSV.Columns[0].HeaderCell.Style.BackColor = Color.White;
            }

            if (countVessel > 0)
            {
                dgvVesselVoyageCSV.Columns[1].HeaderCell.Style.BackColor = Color.Red;
            }
            else
            {
                dgvVesselVoyageCSV.Columns[1].HeaderCell.Style.BackColor = Color.White;
            }

            if (countERD > 0)
            {
                dgvVesselVoyageCSV.Columns[2].HeaderCell.Style.BackColor = Color.Red;
            }
            else
            {
                dgvVesselVoyageCSV.Columns[2].HeaderCell.Style.BackColor = Color.White;
            }

            if (countLRD > 0)
            {
                dgvVesselVoyageCSV.Columns[3].HeaderCell.Style.BackColor = Color.Red;
            }
            else
            {
                dgvVesselVoyageCSV.Columns[3].HeaderCell.Style.BackColor = Color.White;
            }

            if (countETA > 0)
            {
                dgvVesselVoyageCSV.Columns[4].HeaderCell.Style.BackColor = Color.Red;
            }
            else
            {
                dgvVesselVoyageCSV.Columns[4].HeaderCell.Style.BackColor = Color.White;
            }

            if (countETD > 0)
            {
                dgvVesselVoyageCSV.Columns[5].HeaderCell.Style.BackColor = Color.Red;
            }
            else
            {
                dgvVesselVoyageCSV.Columns[5].HeaderCell.Style.BackColor = Color.White;
            }

            if (countPortName > 0)
            {
                dgvVesselVoyageCSV.Columns[6].HeaderCell.Style.BackColor = Color.Red;
            }
            else
            {
                dgvVesselVoyageCSV.Columns[6].HeaderCell.Style.BackColor = Color.White;
            }

            if (countActive > 0)
            {
                dgvVesselVoyageCSV.Columns[8].HeaderCell.Style.BackColor = Color.Red;
            }
            else
            {
                dgvVesselVoyageCSV.Columns[8].HeaderCell.Style.BackColor = Color.White;
            }

            countSyncError = countVoyageNumber + countVessel + countERD + countLRD + countETA + countETD + countPortName + countActive;
            if (countVoyageNumber_Vessel_Port > 0 & countSyncError == 0)
            {
                ckbUpdateVoyage.Visible = true;
                ckbUpdateVoyage.Checked = false;
            }
            else
            {
                ckbUpdateVoyage.Visible = false;
                ckbUpdateVoyage.Checked = false;
            }

            countSyncError = countSyncError + countVoyageNumber_Vessel_Port;
            waitLoading.Close();
        }

        private void SyncSave()
        {
            int countRow = 0;
            int IdVesselVoyage = 0;
            int IdVessel = 0;
            int VesselVoyageStatusId = 0;
            string PortCoutry = "";
            string PortCiry = "";
            int PortNameId = 0;
            bool isActive = false;
            int countInsert = 0;
            int countUpdate = 0;
            if (dgvVesselVoyageCSV.Rows.Count > 1)
            {
                pnlSynchronizingData.Visible = true;
                ProgressBar1.Minimum = 0;
                ProgressBar1.Maximum = dgvVesselVoyageCSV.Rows.Count;
                ProgressBar1.Value = 0;
                ProgressBar1.Step = 1;
            }

            foreach (DataGridViewRow row in dgvVesselVoyageCSV.Rows)
            {
                countRow += 1;
                try
                {
                    if (countRow < dgvVesselVoyageCSV.Rows.Count)
                    {
                        string VoyageNumber = Conversions.ToString(row.Cells[0].Value);
                        string Vessel = Conversions.ToString(row.Cells[1].Value);
                        string ERD = Conversions.ToString(row.Cells[2].Value);
                        string LRD = Conversions.ToString(row.Cells[3].Value);
                        string ETA = Conversions.ToString(row.Cells[4].Value);
                        string ETD = Conversions.ToString(row.Cells[5].Value);
                        string PortName = Conversions.ToString(row.Cells[6].Value);
                        string Status = Conversions.ToString(row.Cells[7].Value);
                        string Active = Conversions.ToString(row.Cells[8].Value);
                        PortNameId = CompanyService.GetCompanyIdByCompanyName(PortName);
                        VesselVoyageStatusId = VesselVoyageStatusService.GetStatusIdByStatus(Status);
                        IdVessel = VesselService.GetVesselIdByVesselName(Vessel);

                        // Joining the Voyage Number + VesselId + PortNameId fields generates a unique voyage.
                        IdVesselVoyage = VesselVoyageService.GetVesselVoyageIdByVoyageNumber_Vessel_Port(VoyageNumber, IdVessel, PortNameId);
                        ERD = ReturnDateFormat(ERD);
                        LRD = ReturnDateFormat(LRD);
                        ETA = ReturnDateFormat(ETA);
                        ETD = ReturnDateFormat(ETD);
                        var L = CompanyAddressService.GetCompanyAddressByCompanyId(PortNameId).ToList();
                        foreach (var item in L)
                        {
                            // TODO : Update this code
                            // PortCoutry = item.Country.TrimEnd().ToUpper()
                            // PortCiry = item.City.TrimEnd().ToUpper()
                        }

                        if (Active.ToUpper().Equals("TRUE"))
                        {
                            isActive = true;
                        }
                        else
                        {
                            isActive = false;
                        }

                        if (IdVesselVoyage == 0)
                        {
                            if (VesselVoyageService.Insert(VoyageNumber, ERD, LRD, ETA, ETD, PortCiry, PortCoutry, isActive, VesselVoyageStatusId, IdVessel, PortNameId))
                            {
                                countInsert += 1;
                                if (EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, VesselVoyageService.GetLastVesselVoyageId().ToString(), "INSERT", "VESSEL VOYAGE", "Create of vessel voyage information using CSV"))
                                {
                                }
                            }
                            else
                            {
                                pnlMessage.Visible = true;
                            }
                        }
                        else if (VesselVoyageService.Update(IdVesselVoyage, VoyageNumber, ERD, LRD, ETA, ETD, PortCiry, PortCoutry, isActive, VesselVoyageStatusId, IdVessel, PortNameId))
                        {
                            countUpdate += 1;
                            if (EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, IdVesselVoyage.ToString(), "UPDATE", "VESSEL VOYAGE", "Edition of vessel voyage information using CSV"))
                            {
                            }
                        }
                        else
                        {
                            pnlMessage.Visible = true;
                        }

                        ProgressBar1.PerformStep();
                    }
                }
                catch (Exception ex)
                {
                    string a = ex.ToString();
                    pnlMessage.Visible = true;
                }
            }

            pnlSynchronizingData.Visible = false;
            if (pnlMessage.Visible == false)
            {
                pnlActions.Visible = true;
                lblActionsSummary.Visible = true;
                ClearDataGridView();
            }
        }

        private void FieldsVerificationDuplicate()
        {
            int countRow = 0;
            bool isActive = false;
            foreach (DataGridViewRow row in dgvVesselVoyageCSV.Rows)
            {
                countRow += 1;
                try
                {
                    if (countRow < dgvVesselVoyageCSV.Rows.Count)
                    {
                        string Active = Conversions.ToString(row.Cells[8].Value);
                        switch (Active.ToUpper() ?? "")
                        {
                            case "TRUE":
                                {
                                    if (Operators.ConditionalCompareObjectEqual(row.Cells[0].Style.BackColor, Color.Coral, false) & ckbUpdateVoyage.Checked)
                                    {
                                        row.Cells[0].Style.BackColor = Color.White;
                                        row.Cells[1].Style.BackColor = Color.White;
                                        row.Cells[2].Style.BackColor = Color.White;
                                        row.Cells[3].Style.BackColor = Color.White;
                                        row.Cells[4].Style.BackColor = Color.White;
                                        row.Cells[5].Style.BackColor = Color.White;
                                        row.Cells[6].Style.BackColor = Color.White;
                                        row.Cells[7].Style.BackColor = Color.White;
                                        row.Cells[8].Style.BackColor = Color.White;
                                        btnSave_2.Visible = true;
                                        lbMessage.Items.Clear();
                                        lbMessage.Items.Add("You can synchronize. Use the Button below this message box.");
                                    }
                                    else
                                    {
                                        FieldsVerification();
                                        ckbUpdateVoyage.Checked = false;
                                        btnSave_2.Visible = false;
                                    }

                                    break;
                                }
                        }
                    }
                }
                catch (Exception ex)
                {
                    string a = ex.ToString();
                    pnlMessage.Visible = true;
                }
            }
        }

        public static bool ValidateDate(string data)
        {
            var r = new Regex(@"(\d{2}\/\d{2}\/\d{4} \d{2}:\d{2})");
            return r.Match(data).Success;
        }

        private bool VerifyLRDIsMoreOrEqualToday(string _LRDDate)
        {
            bool isVerify = false;
            var DateToday = DateTime.Now.AddDays(-1).Date;
            var sp_DateLRD = _LRDDate.Split(new char[] { ' ' });
            var DateLRD = sp_DateLRD[0].Split(new char[] { '/' });
            string D = DateLRD[0];
            string M = DateLRD[1];
            string Y = DateLRD[2];
            string DD = Y + "-" + M + "-" + D + " " + sp_DateLRD[1];
            var DateLRD1 = Convert.ToDateTime(DD);
            if (DateLRD1.Date >= DateToday.Date)
            {
                isVerify = true;
            }

            return isVerify;
        }

        private string ReturnDateFormat(string _Date)
        {
            string isDate = "";
            if (string.IsNullOrEmpty(_Date) == false | string.IsNullOrWhiteSpace(_Date) == false)
            {
                var _Date1 = _Date.Split(new char[] { ' ' });
                var Date2 = _Date1[0].Split(new char[] { '/' });
                isDate = Date2[1].ToString() + "/" + Date2[0].ToString() + "/" + Date2[2].ToString() + " " + _Date1[1].ToString();
            }

            return isDate;
        }

        private bool CompareETDIsEqualOrMoreLRD(string _ETDDate, string _LRDDate)
        {
            bool isVerify = false;
            DateTime DateETD;
            DateTime DateLRD;
            var sp_DateTimeLRD = _LRDDate.Split(new char[] { ' ' });
            var sp_DateLRD = sp_DateTimeLRD[0].Split(new char[] { '/' });
            string D = sp_DateLRD[0];
            string M = sp_DateLRD[1];
            string Y = sp_DateLRD[2];
            string DD = Y + "-" + M + "-" + D + " " + sp_DateTimeLRD[1];
            DateLRD = Convert.ToDateTime(DD);
            var sp_DateTimeETD = _ETDDate.Split(new char[] { ' ' });
            var sp_DateETD = sp_DateTimeETD[0].Split(new char[] { '/' });
            string D1 = sp_DateETD[0];
            string M1 = sp_DateETD[1];
            string Y1 = sp_DateETD[2];
            string DD1 = Y1 + "-" + M1 + "-" + D1 + " " + sp_DateTimeETD[1];
            DateETD = Convert.ToDateTime(DD1);
            if (DateETD.Date >= DateLRD.Date)
            {
                isVerify = true;
            }

            return isVerify;
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */

        private void dgvVesselVoyageCSV_KeyDown(object sender, KeyEventArgs e)
        {
            // If the keys pressed are CTRL + V
            if (e.Control && e.KeyCode == Keys.V)
            {
                int TotItem = 0;
                int CountItem = 0;
                try
                {
                    foreach (string line in Clipboard.GetText().Split(Conversions.ToChar(Constants.vbNewLine)))
                        TotItem += 1;
                    TotItem = TotItem - 1;

                    // Starts the Cycle on the copied lines
                    foreach (string line in Clipboard.GetText().Split(Conversions.ToChar(Constants.vbNewLine)))
                    {
                        // Separates the columns for the current row
                        var item = line.Trim().Split(Conversions.ToChar(Constants.vbTab));

                        // Eliminates the last line that is normally completely empty
                        if (TotItem > CountItem)
                        {
                            // If the number of columns is different it shows an error message
                            if (item.Length != dgvVesselVoyageCSV.ColumnCount)
                            {
                                string str = "The number of columns copied is different" + " of the number of columns in the DataGridView";
                                throw new Exception(str);
                            }

                            // Adds the row to the DataGridView
                            dgvVesselVoyageCSV.Rows.Add(item);
                        }

                        CountItem += 1;
                    }
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("", ex.Message, this);
                }
            }
        }

        private void btnClosePnlAction_Click(object sender, EventArgs e)
        {
            ClearDataGridView();
            My.MyProject.Forms.frmVesselVoyageList.LoadForm();
            Close();
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}