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
using WaitLoading;

namespace ShipSmpl
{
    public partial class frmVesselList
    {
        public frmVesselList()
        {
            InitializeComponent();
            _txtCapacity.Name = "txtCapacity";
            _txtYear.Name = "txtYear";
            _txtFlag.Name = "txtFlag";
            _txtVesselName.Name = "txtVesselName";
            _txtVesselOwner.Name = "txtVesselOwner";
            _txtManager.Name = "txtManager";
            _activeToggleSwitch.Name = "activeToggleSwitch";
            _dgvVessel.Name = "dgvVessel";
            _btnDelete.Name = "btnDelete";
            _btnEdit.Name = "btnEdit";
            _btnAdd.Name = "btnAdd";
            _btnCSVUpdate.Name = "btnCSVUpdate";
            _btnUpdateActive.Name = "btnUpdateActive";
        }

        private WaitLoadingRun waitLoading = new WaitLoadingRun();
        private string sortMode;
        private object VesselId = 0;
        public List<Vessel> listVessel;
        public List<Vessel> selectedVessel = new List<Vessel>();
        private int selectCountVessel = 0;

        private void frmVesselList_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */

        private void btnAdd_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.frmVesselAddEdit.VesselId = 0;
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.frmVesselAddEdit, this);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedVessel.Count > 1)
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("This type of update must be done only one vessel at a time. Or, you must select the CSV Vessel Update option.", "", this);
            }
            else if (selectedVessel.Count != 0)
            {
                My.MyProject.Forms.frmVesselAddEdit.VesselId = Conversions.ToInteger(dgvVessel.CurrentRow.Cells[1].Value);
                MdlLoadingSetting.showDialogForm(My.MyProject.Forms.frmVesselAddEdit, this);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if you have any VesselVoyage attached to this vessel
            if (VesselVoyageService.GetVerificationVesselVoyageByVesselId(Conversions.ToInteger(dgvVessel.CurrentRow.Cells[1].Value)))
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("This Vessel is connected to one or more trips, active or not active for this reason it cannot be excluded.", "Warning", this);
                return;
            }

            if (My.MyProject.Forms.MessageBoxCeresYesNo.ShowDialog("Are you sure you want to delete this Vessel?", "", My.Resources.Resources.caution, this) == DialogResult.Yes)
            {
                if (VesselService.Delete(Conversions.ToInteger(dgvVessel.CurrentRow.Cells[1].Value)))
                {
                    LoadForm();
                    SearchByColumn();
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Vessel was successfully deleted.", "Vessel deleted.", this);
                }
                else
                {
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Vessel cannot be deleted, try again or contact the IT department. #1536", "Error", this);
                }
            }
        }

        private void activeToggleSwitch_Click(object sender, EventArgs e)
        {
            SearchByColumn();
        }

        private void txtVesselName_TextChange(object sender, EventArgs e)
        {
            SearchByColumn();
        }

        private void txtVesselOwner_TextChange(object sender, EventArgs e)
        {
            SearchByColumn();
        }

        private void txtManager_TextChange(object sender, EventArgs e)
        {
            SearchByColumn();
        }

        private void txtCapacity_TextChange(object sender, EventArgs e)
        {
            SearchByColumn();
        }

        private void txtYear_TextChange(object sender, EventArgs e)
        {
            SearchByColumn();
        }

        private void txtFlag_TextChange(object sender, EventArgs e)
        {
            SearchByColumn();
        }

        private void btnCSVUpdate_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.frmVesselCSVUpdate.ClearDataGridView();
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.frmVesselCSVUpdate, this);
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia *//* TODO ERROR: Skipped RegionDirectiveTrivia */

        public void LoadForm()
        {
            listVessel = VesselService.GetAll();
            SearchByColumn();
        }

        public void LoadFormAddItem(int VesselId, string VesselName, string VesselOwner, string Manager, decimal Capacity, int VesselYear, string Flag, bool IsActiveVessel)
        {
            var newList = new List<Vessel>();
            newList.Add(new Vessel(VesselId, VesselName, VesselOwner, Manager, Capacity, VesselYear, Flag, IsActiveVessel));
            listVessel.AddRange(newList);
        }

        public void DeleteItemList(int VesselId)
        {
            var removeList = listVessel;
            removeList.RemoveAll((p) => p.VesselId == VesselId);
        }

        private bool VerifySelectionItem()
        {
            bool isVerify = false;
            if (selectedVessel.Count > 1)
            {
                isVerify = true;
            }

            return isVerify;
        }

        public void SearchByColumn()
        {
            try
            {
                var List = (from b in listVessel
                            where b.VesselName.Contains(txtVesselName.Text) & b.VesselOwner.Contains(txtVesselOwner.Text) & b.Manager.Contains(txtManager.Text) & b.Capacity.ToString().StartsWith(txtCapacity.Text) & b.VesselYear.ToString().StartsWith(txtYear.Text) & b.Flag.ToUpper().StartsWith(txtFlag.Text) & b.IsActiveVessel.Equals(activeToggleSwitch.Value)
                            select b).ToList();
                VesselBindingSource.DataSource = List.ToList();
            }
            catch (Exception ex)
            {
                string msg = ex.ToString();
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia *//* TODO ERROR: Skipped RegionDirectiveTrivia */

        private void dgvVessel_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string ColName = dgvVessel.Columns[e.ColumnIndex].DataPropertyName;
            string querySort;
            List<Vessel> list;

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

            var currentList = new List<Vessel>();
            currentList = (List<Vessel>)VesselBindingSource.DataSource;
            list = currentList.OrderBy(querySort).ToList();
            VesselBindingSource.DataSource = list;
        }

        private void dgvVessel_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            selectedVessel = new List<Vessel>();
            if (e.ColumnIndex == 0)
            {
                try
                {
                    string value = Conversions.ToString(dgvVessel.Rows[e.RowIndex].Cells[0].Value);
                    Vessel BkRow = (Vessel)dgvVessel.Rows[e.RowIndex].DataBoundItem;
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
                }

                foreach (DataGridViewRow row in dgvVessel.Rows)
                {
                    try
                    {
                        string value = Conversions.ToString(row.Cells[0].Value);
                        if (!Information.IsNothing(value) && value.Equals("✔"))
                        {
                            var VRow = new Vessel();
                            VRow = (Vessel)row.DataBoundItem;
                            selectedVessel.Add(VRow);
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }

                lblQtySelected.Text = selectedVessel.Count.ToString();
                if (Convert.ToInt32(selectedVessel.Count) >= 1)
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

        private void btnUpdateActive_Click(object sender, EventArgs e)
        {
            if (activeToggleSwitch.Value == true)
            {
                if (My.MyProject.Forms.MessageBoxCeresYesNo.ShowDialog("Are you sure you want to disable the selected vessels?", "", My.Resources.Resources.warning, this) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvVessel.Rows)
                    {
                        try
                        {
                            string value = Conversions.ToString(row.Cells[0].Value);
                            short IdVessel = Conversions.ToShort(row.Cells[1].Value);
                            if (!Information.IsNothing(value) && value.Equals("✔"))
                            {
                                VesselService.UpdateIsActive(IdVessel, false);
                            }
                        }
                        catch (Exception ex)
                        {
                            string a = ex.ToString();
                        }
                    }

                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Information updated successfully.", "", this);
                    btnUpdateActive.Visible = false;
                }
            }
            else if (My.MyProject.Forms.MessageBoxCeresYesNo.ShowDialog("Are you sure you want to activate the selected vessels?", "", My.Resources.Resources.warning, this) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvVessel.Rows)
                {
                    try
                    {
                        string value = Conversions.ToString(row.Cells[0].Value);
                        short IdVessel = Conversions.ToShort(row.Cells[1].Value);
                        if (!Information.IsNothing(value) && value.Equals("✔"))
                        {
                            VesselService.UpdateIsActive(IdVessel, true);
                        }
                    }
                    catch (Exception ex)
                    {
                        string a = ex.ToString();
                    }
                }

                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Information updated successfully.", "", this);
                btnUpdateActive.Visible = false;
            }

            LoadForm();
            SearchByColumn();
        }

        // 'Criar metodo para dar update nos vessel no campo isActive

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}