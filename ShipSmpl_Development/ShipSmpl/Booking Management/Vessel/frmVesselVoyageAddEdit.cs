using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using WaitLoading;

namespace ShipSmpl
{
    public partial class frmVesselVoyageAddEdit
    {
        public frmVesselVoyageAddEdit()
        {
            InitializeComponent();
            _btnSave.Name = "btnSave";
            _cboVessel.Name = "cboVessel";
            _cboVoyageStatus.Name = "cboVoyageStatus";
            _dtpETD.Name = "dtpETD";
            _dtpETA.Name = "dtpETA";
            _cboCompany.Name = "cboCompany";
            _dtpLRD.Name = "dtpLRD";
            _dtpERD.Name = "dtpERD";
            _btnCancelETA.Name = "btnCancelETA";
            _btnCancelLRD.Name = "btnCancelLRD";
            _btnCancelERD.Name = "btnCancelERD";
            _txtVoyageNumber.Name = "txtVoyageNumber";
            _btnCancelETD.Name = "btnCancelETD";
            _cboCountry.Name = "cboCountry";
            _btnClose.Name = "btnClose";
            _pbxRefreshComboBox.Name = "pbxRefreshComboBox";
        }

        public int VesselVoyageId;
        private string ETADate = "";
        private string ERDDate = "";
        private string LRDDate = "";
        private string ETDDate = "";

        private void frmVesselVoyageAddEdit_Load(object sender, EventArgs e)
        {
            LoadVesselVoyage();
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dtpERD.CustomFormat == "MMM dd, yyyy")
            {
                ERDDate = Conversions.ToString(dtpERD.Value);
            }

            if (dtpETD.CustomFormat == "MMM dd, yyyy")
            {
                ETDDate = Conversions.ToString(dtpETD.Value);
            }

            if (dtpLRD.CustomFormat == "MMM dd, yyyy")
            {
                LRDDate = Conversions.ToString(dtpLRD.Value);
            }

            if (dtpETA.CustomFormat == "MMM dd, yyyy")
            {
                ETADate = Conversions.ToString(dtpETA.Value);
            }

            if (VerifyFieldsIsEmpty())
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Please enter values for the fields.", "Fields that are highlighted cannot be empty.", this);
                return;
            }

            if (VerifyLRDIsMoreOrEqualToday(Conversions.ToDate(LRDDate)) == false)
            {
                dtpLRD.BackColor = Color.LightCoral;
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Please verify field LRD.", "LRD must have a date greater than or equal to today's date.", this);
                return;
            }

            if (CompareETDIsEqualOrMoreLRD(Conversions.ToDate(ETDDate), Conversions.ToDate(LRDDate)) == false)
            {
                dtpETD.BackColor = Color.LightCoral;
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Please verify fields ETD and LRD.", "ETD must have a date greater than or equal to LRD date.", this);
                return;
            }

            if (VesselVoyageId == 0)
            {
                // 5 - Verify Duplicate voyage
                if (VesselVoyageService.GetUniqueActiveVoyageByVoyageNumber_Vessel_Port(txtVoyageNumber.Text, Conversions.ToInteger(cboVessel.SelectedValue), Conversions.ToInteger(cboCompany.SelectedValue)))
                {
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("It is not possible to include the voyage", "There is already an active Vessel Voyage for this Vessel for the same Port Name", this);
                    return;
                }

                if (VesselVoyageService.Insert(txtVoyageNumber.Text, ERDDate, LRDDate, ETADate, ETDDate, txtCity.Text, cboCountry.Text, ckbActive.Checked, Conversions.ToInteger(cboVoyageStatus.SelectedValue), Conversions.ToInteger(cboVessel.SelectedValue), Conversions.ToInteger(cboCompany.SelectedValue)))
                {
                    if (EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, VesselVoyageService.GetLastVesselVoyageId().ToString(), "INSERT", "VESSEL VOYAGE", "Create of vessel voyage information"))
                    {
                    }

                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("The vessel voyage has been successfully inserted.", "", this);
                    var comp = cboCompany.Text.Split('-');
                    My.MyProject.Forms.frmVesselVoyageList.LoadFormAddItem(Conversions.ToInteger(VesselVoyageService.GetLastVesselVoyageId().ToString()), txtVoyageNumber.Text, ERDDate, LRDDate, ETADate, ETDDate, Convert.ToDateTime(LRDDate), txtCity.Text, cboCountry.Text, ckbActive.Checked, Conversions.ToInteger(cboVessel.SelectedValue), Conversions.ToInteger(cboCompany.SelectedValue), Conversions.ToInteger(cboVoyageStatus.SelectedValue), cboVessel.Text, cboVoyageStatus.Text, cboCompany.Text, comp[0].Trim(), comp[1].TrimEnd());
                    My.MyProject.Forms.frmVesselVoyageList.SearchByColumn();
                }
                else
                {
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Error inserting the vessel voyage, try again if the error persists inform the IT department. #1353", "ERROR", this);
                }
            }
            else
            {
                // 5 - Verify Duplicate voyage
                if (VesselVoyageService.GetUniqueActiveVoyageByVoyageNumber_Vessel_Port_Update(txtVoyageNumber.Text, Conversions.ToInteger(cboVessel.SelectedValue), Conversions.ToInteger(cboCompany.SelectedValue), VesselVoyageId) == false)
                {
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("There is already an active Vessel Voyage for this Vessel for the same Port Name. Try again.", "", this);
                    return;
                }

                if (VesselVoyageService.Update(VesselVoyageId, txtVoyageNumber.Text, ERDDate, LRDDate, ETADate, ETDDate, txtCity.Text, cboCountry.Text, ckbActive.Checked, Conversions.ToInteger(cboVoyageStatus.SelectedValue), Conversions.ToInteger(cboVessel.SelectedValue), Conversions.ToInteger(cboCompany.SelectedValue)))
                {
                    if (EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, VesselVoyageId.ToString(), "UPDATE", "VESSEL VOYAGE", "Edition of vessel voyage information"))
                    {
                    }

                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Vessel voyage has been updated successfully.", "Updated!", this);
                    My.MyProject.Forms.frmVesselVoyageList.LoadForm();
                    My.MyProject.Forms.frmVesselVoyageList.SearchByColumn();
                }
                else
                {
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Error updating the vessel voyage, try again if the error persists inform the IT department. #1354", "Error", this);
                }
            }

            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtpERD_ValueChanged(object sender, EventArgs e)
        {
            dtpERD.CustomFormat = "MMM dd, yyyy";
            dtpERD.BackColor = Color.White;
        }

        private void dtpLRD_ValueChanged(object sender, EventArgs e)
        {
            dtpLRD.CustomFormat = "MMM dd, yyyy";
            dtpLRD.BackColor = Color.White;
        }

        private void dtpETA_ValueChanged(object sender, EventArgs e)
        {
            dtpETA.CustomFormat = "MMM dd, yyyy";
        }

        private void dtpETD_ValueChanged(object sender, EventArgs e)
        {
            dtpETD.CustomFormat = "MMM dd, yyyy";
            dtpETD.BackColor = Color.White;
        }

        private void btnCancelERD_Click(object sender, EventArgs e)
        {
            dtpERD.CustomFormat = " ";
        }

        private void btnCancelLRD_Click(object sender, EventArgs e)
        {
            dtpLRD.CustomFormat = " ";
        }

        private void btnCancelETA_Click(object sender, EventArgs e)
        {
            dtpETA.CustomFormat = " ";
        }

        private void btnCancelETD_Click(object sender, EventArgs e)
        {
            dtpETD.CustomFormat = " ";
        }

        private void cboCountry_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void cboCompany_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadCountryAndCity();
            cboCompany.BackColor = Color.White;
        }

        private void txtVoyageNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtVoyageNumber.BackColor = Color.White;
        }

        private void dtpERD_KeyPress(object sender, KeyPressEventArgs e)
        {
            dtpERD.BackColor = Color.White;
        }

        private void cboVessel_KeyPress(object sender, KeyPressEventArgs e)
        {
            cboVessel.BackColor = Color.White;
        }

        private void cboVessel_SelectedValueChanged(object sender, EventArgs e)
        {
            cboVessel.BackColor = Color.White;
        }

        private void cboVoyageStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            cboVoyageStatus.BackColor = Color.White;
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */

        private bool VerifyFieldsIsEmpty()
        {
            bool isFieldEmpty = false;
            if (string.IsNullOrEmpty(ERDDate) | string.IsNullOrEmpty(ETDDate) | string.IsNullOrEmpty(LRDDate) | string.IsNullOrEmpty(txtVoyageNumber.Text) | string.IsNullOrEmpty(cboVessel.Text) | string.IsNullOrEmpty(cboCompany.Text))
            {
                isFieldEmpty = true;
            }

            if (string.IsNullOrEmpty(ERDDate))
            {
                dtpERD.BackColor = Color.LightCoral;
            }

            if (string.IsNullOrEmpty(ETDDate))
            {
                dtpETD.BackColor = Color.LightCoral;
            }

            if (string.IsNullOrEmpty(LRDDate))
            {
                dtpLRD.BackColor = Color.LightCoral;
            }

            if (string.IsNullOrEmpty(txtVoyageNumber.Text))
            {
                txtVoyageNumber.BackColor = Color.LightCoral;
            }

            if (string.IsNullOrEmpty(cboVessel.Text))
            {
                cboVessel.BackColor = Color.LightCoral;
            }

            if (string.IsNullOrEmpty(cboCompany.Text))
            {
                cboCompany.BackColor = Color.LightCoral;
            }

            if (string.IsNullOrEmpty(cboVoyageStatus.Text))
            {
                cboVoyageStatus.BackColor = Color.LightCoral;
            }

            return isFieldEmpty;
        }

        private void LoadComboBox()
        {
            VesselVoyageStatusBindingSource.DataSource = My.MyProject.Forms.frmVesselVoyageList.listVesselVoyageStatus;
            CountryBindingSource.DataSource = My.MyProject.Forms.frmVesselVoyageList.listCountry;
            CompaniesNameBindingSource.DataSource = My.MyProject.Forms.frmVesselVoyageList.listCompany;
            VesselBindingSource.DataSource = My.MyProject.Forms.frmVesselVoyageList.listVessel;
        }

        private void LoadCountryAndCity()
        {
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(cboCompany.SelectedValue, null, false)))
            {
                if (string.IsNullOrEmpty(cboCompany.SelectedValue.ToString()) == false)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cboCompany.SelectedValue, 0, false)))
                    {
                        cboCountry.Text = "";
                        txtCity.Text = "";
                    }
                    else
                    {
                        using (var db = new WTCCeresEntities())
                        {
                            var L = CompanyAddressService.GetCompanyAddressByCompanyId(Conversions.ToInteger(cboCompany.SelectedValue), db).ToList();
                            foreach (var item in L)
                            {
                                cboCountry.Text = item.RegionCity.CountryRegion.Country.CountryName.ToUpper();
                                txtCity.Text = item.RegionCity.CityName.ToUpper();
                            }
                        }
                    }
                }
                else
                {
                    cboCountry.Text = "";
                    txtCity.Text = "";
                }
            }
            else
            {
                cboCountry.Text = "";
                txtCity.Text = "";
            }
        }

        public void LoadVesselVoyage()
        {
            //  WaitForm.Show();
            if (VesselVoyageId == 0)
            {
                txtCity.Text = "";
                txtVoyageNumber.Text = "";
                LoadComboBox();
                cboCompany.Text = "";
                cboCountry.Text = "";
                cboVessel.Text = "";
                cboVoyageStatus.Text = "";
                dtpLRD.CustomFormat = " ";
                dtpETD.CustomFormat = " ";
                dtpERD.CustomFormat = " ";
                dtpETA.CustomFormat = " ";
                lblTitleVessel.Text = "Add Vessel Voyage";
            }
            else
            {
                var L = VesselVoyageService.GetById(VesselVoyageId);
                LoadComboBox();
                foreach (var item in L)
                {
                    txtVoyageNumber.Text = item.VoyageNumber;
                    cboCompany.SelectedValue = item.PortId;
                    LoadCountryAndCity();
                    // cboCountry.Text = item.PortCountry
                    // txtCity.Text = item.PortCity
                    cboVessel.SelectedValue = item.VesselId;
                    cboVoyageStatus.SelectedValue = item.VesselVoyageStatusId;
                    ckbActive.Checked = item.IsActiveTrip == true;
                    if (item.LRD is null)
                    {
                        dtpLRD.CustomFormat = " ";
                    }
                    else
                    {
                        dtpLRD.Value = (DateTime)item.LRD;
                    }

                    if (item.ETD is null)
                    {
                        dtpETD.CustomFormat = " ";
                    }
                    else
                    {
                        dtpETD.Value = (DateTime)item.ETD;
                    }

                    if (item.ERD is null)
                    {
                        dtpERD.CustomFormat = " ";
                    }
                    else
                    {
                        dtpERD.Value = (DateTime)item.ERD;
                    }

                    if (item.ETA is null)
                    {
                        dtpETA.CustomFormat = " ";
                    }
                    else
                    {
                        dtpETA.Value = (DateTime)item.ETA;
                    }

                    lblTitleVessel.Text = "Update Vessel Voyage";
                }
            }

            //  WaitForm.Close();
        }

        private bool VerifyLRDIsMoreOrEqualToday(DateTime _LRDDate)
        {
            bool isVerify = false;
            if (string.IsNullOrEmpty(Conversions.ToString(_LRDDate)) == false)
            {
                DateTime DateToday = Conversions.ToDate(DateTime.Now.AddDays(-1).ToShortDateString());
                DateTime DateLRD = Conversions.ToDate(_LRDDate.ToShortDateString());
                if (DateLRD >= DateToday)
                {
                    isVerify = true;
                }
            }

            return isVerify;
        }

        private bool CompareETDIsEqualOrMoreLRD(DateTime _ETDDate, DateTime _LRDDate)
        {
            bool isVerify = false;
            DateTime DateETD = Conversions.ToDate(_ETDDate.ToShortDateString());
            DateTime DateLRD = Conversions.ToDate(_LRDDate.ToShortDateString());
            if (DateETD >= DateLRD)
            {
                isVerify = true;
            }

            return isVerify;
        }

        private void pbxRefreshComboBox_Click(object sender, EventArgs e)
        {
            //   WaitForm.Show();
            VesselVoyageStatusBindingSource.DataSource = VesselVoyageStatusService.GetAll();
            CountryBindingSource.DataSource = CountryService.GetAll();
            CompaniesNameBindingSource.DataSource = CompanyService.GetCompaniesCodeAndNameByTypeId(5);
            VesselBindingSource.DataSource = VesselService.GetVesselByActive(true, true);
            //  WaitForm.Close();
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}