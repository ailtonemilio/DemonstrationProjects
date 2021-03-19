using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using System;

namespace ShipSmpl
{
    public partial class FrmAddEditRegionCity
    {
        public FrmAddEditRegionCity()
        {
            InitializeComponent();
            _tbSave.Name = "tbSave";
            _cancelButton.Name = "cancelButton";
        }

        private CountryRegion cr = new CountryRegion();
        private RegionCity rc = new RegionCity();
        private CountryRegionService crService = new CountryRegionService();
        private RegionCityService rcService = new RegionCityService();

        private void btnAddRegionCity_Click(object sender, EventArgs e)
        {
        }

        public void PopulateInfo(VW_RegionCity vw, bool isNewRecord)
        {
            using (var db = new WTCCeresEntities())
            {
                {
                    var withBlock = cboRegionCode;
                    withBlock.DataSource = CountryRegionService.GetByCountryId(vw.CountryId, db);
                    withBlock.DisplayMember = "RegionCode";
                    withBlock.ValueMember = "CountryRegionId";
                }
            }

            if (isNewRecord)
            {
                tbCityCode.Text = "";
                tbCityName.Text = "";
                cboRegionCode.SelectedIndex = 0;
                lblCountry.Text = vw.CountryName;
                cr = new CountryRegion();
                rc = new RegionCity();
                cr.CountryId = vw.CountryId;
            }
            else
            {
                using (var db = new WTCCeresEntities())
                {
                    cr = CountryRegionService.GetById(vw.CountryRegionId, db);
                    rc = new RegionCity();
                    rc = RegionCityService.GetById(vw.RegionCityId, db);
                    cboRegionCode.SelectedValue = vw.CountryRegionId;
                    tbCityCode.Text = vw.CityCode;
                    lblCountry.Text = vw.CountryName;
                    tbCityName.Text = vw.CityName;
                }
            }
        }

        private void tbSave_Click(object sender, EventArgs e)
        {
            using (var db = new WTCCeresEntities())
            {
                rc.CityName = MdlDataCleasing.TrimAll(tbCityName.Text);
                rc.CityCode = MdlDataCleasing.TrimAll(tbCityCode.Text);
                rc.CountryRegionId = Conversions.ToInteger(cboRegionCode.SelectedValue);
                if (rcService.AddOrUpdate(rc, db))
                {
                    Close();
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}