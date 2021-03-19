using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;
using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using ModelLayer.CustomModel;
using WaitLoading;

namespace ShipSmpl
{
    public partial class frmVesselVoyageList
    {
        public frmVesselVoyageList()
        {
            InitializeComponent();
            _txtERD.Name = "txtERD";
            _txtVoyageNumber.Name = "txtVoyageNumber";
            _txtVessel.Name = "txtVessel";
            _txtPortCity.Name = "txtPortCity";
            _txtPortName.Name = "txtPortName";
            _txtPortCountry.Name = "txtPortCountry";
            _txtETD.Name = "txtETD";
            _txtETA.Name = "txtETA";
            _txtLRD.Name = "txtLRD";
            _activeToggleSwitch.Name = "activeToggleSwitch";
            _dgvVessel.Name = "dgvVessel";
            _btnUpdateActive.Name = "btnUpdateActive";
            _btnDelete.Name = "btnDelete";
            _btnEdit.Name = "btnEdit";
            _btnAdd.Name = "btnAdd";
            _btnCSVUpdate.Name = "btnCSVUpdate";
            _cbCheckAll.Name = "cbCheckAll";
        }

        private WaitLoadingRun waitLoading = new WaitLoadingRun();
        private string sortMode;
        private object VesselId = 0;
        public List<VesselVoyageList> listVesselVoyage;
        public List<VesselVoyageList> listVesselVoyageActive;
        public List<VesselVoyageList> selectedVesselVoyage = new List<VesselVoyageList>();
        private int selectCountVessel = 0;
        private bool ActiveVoyage;

        // Load Combox for Add or Edit
        public List<Country> listCountry = new List<Country>();

        public List<Vessel> listVessel = new List<Vessel>();
        public List<CompaniesName> listCompany = new List<CompaniesName>();
        public List<VesselVoyageStatus> listVesselVoyageStatus = new List<VesselVoyageStatus>();

        private void frmVesselVoyageList_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */

        private void btnAdd_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.frmVesselVoyageAddEdit.VesselVoyageId = 0;
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.frmVesselVoyageAddEdit, this);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedVesselVoyage.Count > 1)
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("This type of update must be done only one vessel voyage at a time.", "", this);
            }
            else if (selectedVesselVoyage.Count == 1)
            {
                My.MyProject.Forms.frmVesselVoyageAddEdit.VesselVoyageId = Conversions.ToInteger(dgvVessel.CurrentRow.Cells[1].Value);
                MdlLoadingSetting.showDialogForm(My.MyProject.Forms.frmVesselVoyageAddEdit, this);
            }
            else if (selectedVesselVoyage.Count == 0)
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("You must select a Vessel Voyage!", "", this);
            }
        }

        private void activeToggleSwitch_Click(object sender, EventArgs e)
        {
            if (activeToggleSwitch.Value == true)
                _btnUpdateActive.Visible = true;
            else
                _btnUpdateActive.Visible = false;

            SearchByColumn();
        }

        private void txtVoyageNumber_TextChange(object sender, EventArgs e)
        {
            SearchByColumn();
        }

        private void txtERD_TextChange(object sender, EventArgs e)
        {
            SearchByColumn();
        }

        private void txtLRD_TextChange(object sender, EventArgs e)
        {
            SearchByColumn();
        }

        private void txtETA_TextChange(object sender, EventArgs e)
        {
            SearchByColumn();
        }

        private void txtETD_TextChange(object sender, EventArgs e)
        {
            SearchByColumn();
        }

        private void txtPortCountry_TextChange(object sender, EventArgs e)
        {
            SearchByColumn();
        }

        private void txtPortCity_TextChange(object sender, EventArgs e)
        {
            SearchByColumn();
        }

        private void txtVessel_TextChange(object sender, EventArgs e)
        {
            SearchByColumn();
        }

        private void txtPortName_TextChange(object sender, EventArgs e)
        {
            SearchByColumn();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (My.MyProject.Forms.MessageBoxCeresYesNo.ShowDialog("Are you sure you want to delete this Vessel Voyage?", "", My.Resources.Resources.caution, this) == DialogResult.Yes)
            {
                if (VesselVoyageService.Delete(Conversions.ToInteger(dgvVessel.CurrentRow.Cells[1].Value)))
                {
                    DeleteItemList(Conversions.ToInteger(dgvVessel.CurrentRow.Cells[1].Value));
                    SearchByColumn();
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Vessel voyage was successfully deleted.", "Vessel deleted.", this);
                    btnUpdateActive.Visible = false;
                }
                else
                {
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Vessel voyage cannot be deleted, try again or contact the IT department. #1536", "Error", this);
                }
            }
        }

        private void btnCSVUpdate_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.frmVesselVoyageCSVUpdateType.ClearDataGridView();
            My.MyProject.Forms.frmVesselVoyageCSVUpdateType.listVesselVoyageList = listVesselVoyageActive;
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.frmVesselVoyageCSVUpdateType, this);
        }

        private void btnUpdateActive_Click(object sender, EventArgs e)
        {
            if (activeToggleSwitch.Value == true)
            {
                if (My.MyProject.Forms.MessageBoxCeresYesNo.ShowDialog("Are you sure you want to disable the selected vessels voyage?", "", My.Resources.Resources.warning, this) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvVessel.Rows)
                    {
                        try
                        {
                            string value = Conversions.ToString(row.Cells[0].Value);
                            short IdVessel = Conversions.ToShort(row.Cells[1].Value);
                            if (!Information.IsNothing(value) && value.Equals("✔"))
                            {
                                VesselVoyageService.UpdateIsActive(IdVessel, false);
                            }
                        }
                        catch (Exception ex)
                        {
                            string a = ex.ToString();
                        }
                    }

                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Information updated successfully.", "", this);
                    btnUpdateActive.Visible = false;
                    cbCheckAll.Checked = false;
                }
            }
            else if (My.MyProject.Forms.MessageBoxCeresYesNo.ShowDialog("Are you sure you want to activate the selected vessels voyage?", "", My.Resources.Resources.warning, this) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvVessel.Rows)
                {
                    try
                    {
                        string value = Conversions.ToString(row.Cells[0].Value);
                        short IdVessel = Conversions.ToShort(row.Cells[1].Value);
                        if (!Information.IsNothing(value) && value.Equals("✔"))
                        {
                            VesselVoyageService.UpdateIsActive(IdVessel, true);
                        }
                    }
                    catch (Exception ex)
                    {
                        string a = ex.ToString();
                    }
                }

                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Information updated successfully.", "", this);
                btnUpdateActive.Visible = false;
                cbCheckAll.Checked = false;
            }

            waitLoading.Show();
            listVesselVoyage = VesselVoyageService.GetVesselVoyageListAll();
            SearchByColumn();
            waitLoading.Close();
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia *//* TODO ERROR: Skipped RegionDirectiveTrivia */

        public void LoadForm()
        {
            listVesselVoyageStatus = VesselVoyageStatusService.GetAll();
            listCountry = CountryService.GetCountryDropBox();
            listCompany = CompanyService.GetCompaniesCodeAndNameByTypeId(5);
            listVessel = VesselService.GetVesselByActive(true, true);
            VesselVoyageService.UpdateIsActiveDateLRDLessThanYesterday();
            listVesselVoyage = VesselVoyageService.GetVesselVoyageListAll();
            SearchByColumn();
        }

        public void LoadFormAddItem(int VesselVoyageId, string VoyageNumber, string ERD, string LRD, string ETA, string ETD, DateTime LRDDateTime, string PortCity, string PortCountry, bool IsActiveTrip, int VesselId, int PortId, int VesselVoyageStatusId, string VesselName, string StatusName, string CompanyCodeName, string CompanyCode, string CompanyName)
        {
            var newList = new List<VesselVoyageList>();
            newList.Add(new VesselVoyageList(VesselVoyageId, VoyageNumber, Conversions.ToDate(ERD), Conversions.ToDate(LRD), Conversions.ToDate(ETA), Conversions.ToDate(ETD), LRDDateTime, PortCity, PortCountry, IsActiveTrip, VesselId, PortId, VesselVoyageStatusId, VesselName, StatusName, CompanyCodeName, CompanyCode, CompanyName));
            listVesselVoyage.AddRange(newList);
        }

        public void DeleteItemList(int VesselVoyageId)
        {
            var removeList = listVesselVoyage;
            removeList.RemoveAll((p) => p.VesselVoyageId == VesselVoyageId);
        }

        public void SearchByColumn()
        {
            var List = (from b in listVesselVoyage
                        where b.VoyageNumber.StartsWith(txtVoyageNumber.Text) & b.ERD.ToString().StartsWith(txtERD.Text) & b.LRD.ToString().StartsWith(txtLRD.Text) & b.ETA.ToString().StartsWith(txtETA.Text) & b.ETD.ToString().StartsWith(txtETD.Text) & b.PortCity.Contains(txtPortCity.Text) & b.PortCountry.Contains(txtPortCountry.Text) & b.VesselName.Contains(txtVessel.Text) & b.CompanyCodeName.StartsWith(txtPortName.Text) & b.IsActiveTrip.Equals(activeToggleSwitch.Value)
                        select b).ToList();
            listVesselVoyageActive = List.ToList();
            VesselVoyageListBindingSource.DataSource = List.ToList();
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia *//* TODO ERROR: Skipped RegionDirectiveTrivia */

        private void dgvVessel_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string ColName = dgvVessel.Columns[e.ColumnIndex].DataPropertyName;
            string querySort;
            List<VesselVoyageList> list;

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

            var currentList = new List<VesselVoyageList>();
            currentList = (List<VesselVoyageList>)VesselVoyageListBindingSource.DataSource;
            list = currentList.OrderBy(querySort).ToList();
            VesselVoyageListBindingSource.DataSource = list;
        }

        private void dgvVessel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedVesselVoyage = new List<VesselVoyageList>();
            if (e.ColumnIndex == 0)
            {
                try
                {
                    string value = Conversions.ToString(dgvVessel.Rows[e.RowIndex].Cells[0].Value);
                    VesselVoyageList BkRow = (VesselVoyageList)dgvVessel.Rows[e.RowIndex].DataBoundItem;
                    if (!Information.IsNothing(value) && value.Equals("   "))
                    {
                        dgvVessel.Rows[e.RowIndex].Cells[0].Value = "✔";
                    }
                    else
                    {
                        dgvVessel.Rows[e.RowIndex].Cells[0].Value = "   ";
                    }
                }
                catch (Exception ex)
                {
                    string a = ex.ToString();
                }

                foreach (DataGridViewRow row in dgvVessel.Rows)
                {
                    try
                    {
                        string value = Conversions.ToString(row.Cells[0].Value);
                        if (!Information.IsNothing(value) && value.Equals("✔"))
                        {
                            var VVRow = new VesselVoyageList();
                            VVRow = (VesselVoyageList)row.DataBoundItem;
                            selectedVesselVoyage.Add(VVRow);
                        }
                    }
                    catch (Exception ex)
                    {
                        string b = ex.ToString();
                    }
                }

                lblQtySelected.Text = selectedVesselVoyage.Count.ToString();
                if (Convert.ToInt32(selectedVesselVoyage.Count) >= 1 && _activeToggleSwitch.Value == true)
                {
                    btnUpdateActive.Visible = true;
                }
                else
                {
                    btnUpdateActive.Visible = false;
                }
            }
        }

        private void dgvVessel_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var checkCell = dgvVessel.Rows[e.RowIndex].Cells["check"];
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
        }

        private void cbCheckAll_Click(object sender, EventArgs e)
        {
            if (cbCheckAll.Checked)
            {
                for (int i = 0, loopTo = dgvVessel.Rows.Count - 1; i <= loopTo; i++)
                {
                    dgvVessel.Rows[i].Cells[0].Value = "✔";
                    selectCountVessel += 1;
                }
                lblQtySelected.Text = selectCountVessel.ToString();
            }
            else
            {
                for (int i = 0, loopTo1 = dgvVessel.Rows.Count - 1; i <= loopTo1; i++)
                    dgvVessel.Rows[i].Cells[0].Value = "   ";

                lblQtySelected.Text = "0";
               
            }

            if (_activeToggleSwitch.Value == true && cbCheckAll.Checked)
                btnUpdateActive.Visible = true;
            else
                btnUpdateActive.Visible = false;
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}