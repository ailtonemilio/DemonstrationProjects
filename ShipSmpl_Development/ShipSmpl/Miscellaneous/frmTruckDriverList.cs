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
    public partial class frmTruckDriverList
    {
        public frmTruckDriverList()
        {
            InitializeComponent();
            _activeToggleSwitch.Name = "activeToggleSwitch";
            _txtTruckNumber.Name = "txtTruckNumber";
            _txtTruckCompany.Name = "txtTruckCompany";
            _txtLastName.Name = "txtLastName";
            _txtFirstName.Name = "txtFirstName";
            _txtPassId.Name = "txtPassId";
            _dgvTruckDrivers.Name = "dgvTruckDrivers";
            _btnUpdateDriver.Name = "btnUpdateDriver";
            _btnAddCompanyToDriver.Name = "btnAddCompanyToDriver";
            _btnAddDriver.Name = "btnAddDriver";
            _btnSuspend.Name = "btnSuspend";
        }

        private WaitLoadingRun waitLoading = new WaitLoadingRun();
        private string sortMode;
        public List<TruckDriverList> listTruckDriver;
        public List<TruckDriverList> selectedTruckDriver = new List<TruckDriverList>();
        private frmAddCompanyToDriver frmAddCompanyToDriver = new frmAddCompanyToDriver();

        private void frmTruckDriverList_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */

        private void btnSuspend_Click(object sender, EventArgs e)
        {
            // Se activeToggleSwitch = True na base de dados tem que estar false
            if (activeToggleSwitch.Value == true)
            {
                if (My.MyProject.Forms.MessageBoxCeresYesNo.ShowDialog("Are you sure you want to suspend the selected truck driver?", "", My.Resources.Resources.warning, this) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvTruckDrivers.Rows)
                    {
                        try
                        {
                            string value = Conversions.ToString(row.Cells[0].Value);
                            short IdTruckDriver = Conversions.ToShort(row.Cells[1].Value);
                            if (!Information.IsNothing(value) && value.Equals("✔"))
                            {
                                if (TruckDriverService.SuspendTruckDriver(IdTruckDriver, false) == false)
                                {
                                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Error updating data. Contact the IT department. Code Error #1365.", "", this);
                                    return;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            string a = ex.ToString();
                        }
                    }

                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Information updated successfully.", "", this);
                    // btnSuspend.Visible = False
                }
            }
            else if (My.MyProject.Forms.MessageBoxCeresYesNo.ShowDialog("Are you sure you want to revoke suspend the selected truck driver?", "", My.Resources.Resources.warning, this) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvTruckDrivers.Rows)
                {
                    try
                    {
                        string value = Conversions.ToString(row.Cells[0].Value);
                        short IdTruckDriver = Conversions.ToShort(row.Cells[1].Value);
                        if (!Information.IsNothing(value) && value.Equals("✔"))
                        {
                            if (TruckDriverService.SuspendTruckDriver(IdTruckDriver, false) == true)
                            {
                                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Error updating data. Contact the IT department. Code Error #1365.", "", this);
                                return;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string a = ex.ToString();
                    }
                }

                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Information updated successfully.", "", this);
                // btnSuspend.Visible = False
            }

            waitLoading.Show();
            using (var db = new WTCCeresEntities())
            {
                listTruckDriver = TruckDriverService.GetTruckDriverAllList(db);
            }

            SearchByColumn();
            waitLoading.Close();
        }

        private void activeToggleSwitch_Click(object sender, EventArgs e)
        {
            SearchByColumn();
        }

        private void btnAddCompanyToDriver_Click(object sender, EventArgs e)
        {
            if (VerifyLine() == true)
            {
                MdlLoadingSetting.showDialogForm(frmAddCompanyToDriver, this);
            }
        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.frmEditTruckDrivers.TruckDriverId = 0;
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.frmEditTruckDrivers, this);
        }

        private void btnUpdateDriver_Click(object sender, EventArgs e)
        {
            if (VerifyLine() == true)
            {
                MdlLoadingSetting.showDialogForm(My.MyProject.Forms.frmEditTruckDrivers, this);
            }
        }

        private void txtPassId_TextChange(object sender, EventArgs e)
        {
            SearchByColumn();
        }

        private void txtFirstName_TextChange(object sender, EventArgs e)
        {
            SearchByColumn();
        }

        private void txtLastName_TextChange(object sender, EventArgs e)
        {
            SearchByColumn();
        }

        private void txtTruckCompany_TextChange(object sender, EventArgs e)
        {
            SearchByColumn();
        }

        private void txtTruckNumber_TextChange(object sender, EventArgs e)
        {
            SearchByColumn();
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */

        public bool VerifyLine()
        {
            bool isVerify = false;
            string value = 0.ToString();
            int IdTruckDrive = 0;
            int countLine = 0;
            foreach (DataGridViewRow row in dgvTruckDrivers.Rows)
            {
                try
                {
                    value = Conversions.ToString(row.Cells[0].Value);
                    if (!Information.IsNothing(value) && value.Equals("✔"))
                    {
                        countLine += 1;
                        IdTruckDrive = Conversions.ToInteger(row.Cells[1].Value);
                    }
                }
                catch (Exception ex)
                {
                    string a = ex.ToString();
                }
            }

            if (countLine == 0)
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Select Truck Driver for update.", "", this);
                return false;
                return default;
            }

            if (countLine > 1)
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Select only one Truck Driver for update.", "", this);
                return false;
                return default;
            }

            My.MyProject.Forms.frmEditTruckDrivers.TruckDriverId = IdTruckDrive;
            frmAddCompanyToDriver.DriverId = IdTruckDrive;
            return true;
        }

        public void VerifyUSer()
        {
            int us = My.MyProject.Forms.FrmLoginWindow._userID;
            if (My.MyProject.Forms.FrmLoginWindow._userID == 163 | My.MyProject.Forms.FrmLoginWindow._userID == 124)
            {
                btnUpdateDriver.Visible = true;
            }
            else
            {
                btnUpdateDriver.Visible = false;
            }
        }

        public void LoadForm()
        {
            using (var db = new WTCCeresEntities())
            {
                listTruckDriver = TruckDriverService.GetTruckDriverAllList(db);
            }

            SearchByColumn();
        }

        public void SearchByColumn()
        {
            waitLoading.Show();
            bool isSuspend;
            if (activeToggleSwitch.Value == true)
            {
                isSuspend = false;
            }
            else
            {
                isSuspend = true;
            }

            var List = (from b in listTruckDriver
                        where b.PortPassId.StartsWith(txtPassId.Text) & b.FirstName.StartsWith(txtFirstName.Text) & b.LastName.StartsWith(txtLastName.Text) & b.CompanyName.StartsWith(txtTruckCompany.Text) & b.TruckNumber.ToString().StartsWith(txtTruckNumber.Text) & b.SuspendTruckDriver.Equals(isSuspend)
                        select b).ToList();
            TruckDriverListBindingSource.DataSource = List.ToList();
            waitLoading.Close();
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */

        private void dgvTruckDrivers_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string ColName = dgvTruckDrivers.Columns[e.ColumnIndex].DataPropertyName;
            string querySort;
            List<TruckDriverList> list;

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

            var currentList = new List<TruckDriverList>();
            currentList = (List<TruckDriverList>)TruckDriverListBindingSource.DataSource;
            list = currentList.OrderBy(querySort).ToList();
            TruckDriverListBindingSource.DataSource = list;
        }

        private void dgvTruckDrivers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedTruckDriver = new List<TruckDriverList>();
            if (e.ColumnIndex == 0)
            {
                try
                {
                    string value = Conversions.ToString(dgvTruckDrivers.Rows[e.RowIndex].Cells[0].Value);
                    TruckDriverList BkRow = (TruckDriverList)dgvTruckDrivers.Rows[e.RowIndex].DataBoundItem;
                    if (!Information.IsNothing(value) && value.Equals("   "))
                    {
                        dgvTruckDrivers.Rows[e.RowIndex].Cells[0].Value = "✔";
                    }
                    else
                    {
                        dgvTruckDrivers.Rows[e.RowIndex].Cells[0].Value = "   ";
                    }
                }
                catch (Exception ex)
                {
                }

                foreach (DataGridViewRow row in dgvTruckDrivers.Rows)
                {
                    try
                    {
                        string value = Conversions.ToString(row.Cells[0].Value);
                        if (!Information.IsNothing(value) && value.Equals("✔"))
                        {
                            var TDRow = new TruckDriverList();
                            TDRow = (TruckDriverList)row.DataBoundItem;
                            selectedTruckDriver.Add(TDRow);
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }

                lblQtySelected.Text = selectedTruckDriver.Count.ToString();
                // If Convert.ToInt32(selectedTruckDriver.Count()) >= 1 Then
                // btnSuspend.Visible = True
                // Else
                // btnSuspend.Visible = False
                // End If
            }
        }

        private void dgvTruckDrivers_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var checkCell = dgvTruckDrivers.Rows[e.RowIndex].Cells["check"];
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

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}