using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessLayer.WTC_Ceres;

namespace ShipSmpl
{
    public partial class frmVesselAddEdit
    {
        public frmVesselAddEdit()
        {
            InitializeComponent();
            _btnClose.Name = "btnClose";
            _txtVesselName.Name = "txtVesselName";
            _txtVesselCapacity.Name = "txtVesselCapacity";
            _txtVesselYear.Name = "txtVesselYear";
            _btnSave.Name = "btnSave";
        }

        public int VesselId;

        private void frmVesselAddEdit_Load(object sender, EventArgs e)
        {
            LoadVessel(VesselId);
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVesselName.Text))
            {
                txtVesselName.BackColor = Color.LightCoral;
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("The Vessel Name field cannot be empty.", "", this);
                return;
            }

            if (string.IsNullOrEmpty(txtVesselCapacity.Text))
            {
                txtVesselCapacity.Text = "0";
            }

            if (string.IsNullOrEmpty(txtVesselYear.Text))
            {
                txtVesselYear.Text = "0";
            }

            if (VesselId == 0)
            {
                if (VesselService.Insert(txtVesselName.Text, txtVesselOwner.Text, txtVesselManager.Text, Convert.ToDecimal(txtVesselCapacity.Text), Convert.ToInt32(txtVesselYear.Text), cboFlag.Text, ckbActive.Checked))
                {
                    if (EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, VesselService.GetLastVesselId().ToString(), "INSERT", "VESSEL", "Insert of vessel information"))
                    {
                    }

                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("The Vessel has been successfully inserted.", "Inserted!", this);
                    My.MyProject.Forms.frmVesselList.LoadFormAddItem(VesselService.GetLastVesselId(), txtVesselName.Text, txtVesselOwner.Text, txtVesselManager.Text, Convert.ToDecimal(txtVesselCapacity.Text), Convert.ToInt32(txtVesselYear.Text), cboFlag.Text, ckbActive.Checked);
                    My.MyProject.Forms.frmVesselList.SearchByColumn();
                }
                else
                {
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Error inserting the vessel, try again if the error persists inform the IT department. #1351", "Error", this);
                }
            }
            else if (VesselService.Update(VesselId, txtVesselName.Text, txtVesselOwner.Text, txtVesselManager.Text, Convert.ToDecimal(txtVesselCapacity.Text), Convert.ToInt32(txtVesselYear.Text), cboFlag.Text, ckbActive.Checked))
            {
                if (EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, VesselId.ToString(), "UPDATE", "VESSEL", "Edition of vessel information"))
                {
                }

                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Vessel has been updated successfully.", "Updated!", this);
                My.MyProject.Forms.frmVesselList.LoadForm();
                My.MyProject.Forms.frmVesselList.SearchByColumn();
            }
            else
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Error updating the vessel, try again if the error persists inform the IT department. #1352", "Error", this);
            }

            Close();
        }

        private void txtVesselYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtVesselCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = '.';
                if (txtVesselCapacity.Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia *//* TODO ERROR: Skipped RegionDirectiveTrivia */

        public void LoadVessel(int VesselId)
        {
            if (VesselId == 0)
            {
                txtVesselName.Text = "";
                txtVesselOwner.Text = "";
                txtVesselManager.Text = "";
                txtVesselCapacity.Text = "";
                txtVesselYear.Text = "";
                ckbActive.Checked = true;
                lblTitleVessel.Text = "Add Vessel";
                CountryBindingSource.DataSource = CountryService.GetCountryDropBox();
                cboFlag.Text = "";
            }
            else
            {
                var L = VesselService.GetById(VesselId);
                CountryBindingSource.DataSource = CountryService.GetCountryDropBox();
                foreach (var item in L)
                {
                    txtVesselName.Text = item.VesselName;
                    txtVesselOwner.Text = item.VesselOwner;
                    txtVesselCapacity.Text = item.Capacity.ToString();
                    if (item.VesselYear is null)
                    {
                        txtVesselYear.Text = "";
                    }
                    else
                    {
                        txtVesselYear.Text = item.VesselYear.ToString();
                    }

                    txtVesselManager.Text = item.Manager;
                    ckbActive.Checked = item.IsActiveVessel == true;
                    lblTitleVessel.Text = "Update Vessel";
                    cboFlag.Text = item.Flag;
                }
            }
        }

        private void txtVesselName_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtVesselName.BackColor = Color.White;
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}