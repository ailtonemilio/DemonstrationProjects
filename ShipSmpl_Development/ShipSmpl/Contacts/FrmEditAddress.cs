using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using System;

namespace ShipSmpl
{
    public partial class FrmEditAddress
    {
        public FrmEditAddress()
        {
            InitializeComponent();
            _cancelButton.Name = "cancelButton";
            _country1ComboBox1.Name = "country1ComboBox1";
            _btnEditRegionCity.Name = "btnEditRegionCity";
            _btnAddRegionCity.Name = "btnAddRegionCity";
            _BunifuButton1.Name = "BunifuButton1";
        }

        private bool firstLoad = true;
        private bool isCompany;
        private RegionCity rc = new RegionCity();
        private CompanyAddress cp = new CompanyAddress();

        private void Button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public void LoadForm()
        {
            firstLoad = true;
            using (var db = new WTCCeresEntities())
            {
                {
                    var withBlock = country1ComboBox1;
                    withBlock.DataSource = CountryService.GetAll(db);
                    withBlock.DisplayMember = "CountryName";
                    withBlock.ValueMember = "CountryId";
                }

                {
                    var withBlock1 = cboCity;
                    withBlock1.DataSource = RegionCityService.GetRegionCityVWByCountryId(Conversions.ToInteger(country1ComboBox1.SelectedValue), db);
                    withBlock1.DisplayMember = "CityAndRegion";
                    withBlock1.ValueMember = "RegionCityId";
                }
            }

            firstLoad = false;
        }

        private void GetRegionCities()
        {
            using (var db = new WTCCeresEntities())
            {
                cboCity.DataSource = RegionCityService.GetRegionCityVWByCountryId(Conversions.ToInteger(country1ComboBox1.SelectedValue), db);
                cboCity.DisplayMember = "CityAndRegion";
                cboCity.ValueMember = "RegionCityId";
            }
        }

        public void PopulateInfo(int CompanyAddressId)
        {
            isCompany = isCompany;
            LoadForm();
            using (var db = new WTCCeresEntities())
            {
                cp = CompanyAddressService.GetById(CompanyAddressId, db);
                rc = cp.RegionCity;
                country1ComboBox1.SelectedValue = rc.CountryRegion.CountryId;
                cboCity.SelectedValue = rc.RegionCityId;
                address1TextBox2.Text = cp.StreetAddress;
                locationDescription1TextBox1.Text = cp.AddressDescription;
                postal1TextBox1.Text = cp.ZipCode;
                phone1TextBox.Text = cp.Phone;
                fax1TextBox.Text = cp.Fax;
            }
        }

        private void country1ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!firstLoad)
            {
                GetRegionCities();
            }
        }

        private void btnAddRegionCity_Click(object sender, EventArgs e)
        {
            var rcvw = new VW_RegionCity();
            rcvw.CountryId = Conversions.ToInteger(country1ComboBox1.SelectedValue);
            rcvw.CountryName = country1ComboBox1.Text;
            My.MyProject.Forms.FrmAddEditRegionCity.PopulateInfo(rcvw, true);
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAddEditRegionCity, this);
            using (var db = new WTCCeresEntities())
            {
                GetRegionCities();
            }
        }

        private void btnEditRegionCity_Click(object sender, EventArgs e)
        {
            VW_RegionCity rc = (VW_RegionCity)cboCity.SelectedItem;
            My.MyProject.Forms.FrmAddEditRegionCity.PopulateInfo(rc, false);
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAddEditRegionCity, this);
            using (var db = new WTCCeresEntities())
            {
                cboCity.DataSource = RegionCityService.GetRegionCityVWByCountryId(Conversions.ToInteger(country1ComboBox1.SelectedValue), db);
            }
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            var cpService = new CompanyAddressService();
            cp.StreetAddress = MdlDataCleasing.TrimAll(address1TextBox2.Text);
            cp.AddressDescription = MdlDataCleasing.TrimAll(locationDescription1TextBox1.Text);
            cp.ZipCode = MdlDataCleasing.TrimAll(postal1TextBox1.Text);
            cp.Phone = MdlDataCleasing.TrimAll(phone1TextBox.Text);
            cp.Fax = MdlDataCleasing.TrimAll(fax1TextBox.Text);
            cp.RegionCityId = (int?)cboCity.SelectedValue;
            using (var db = new WTCCeresEntities())
            {
                if (cpService.AddOrUpdate(cp, db))
                {
                    My.MyProject.Forms.FrmAddOrganization.addrList.Add(cp);
                    My.MyProject.Forms.FrmAddOrganization.CompanyAddressBindingSource.DataSource = null;
                    My.MyProject.Forms.FrmAddOrganization.CompanyAddressBindingSource.DataSource = My.MyProject.Forms.FrmAddOrganization.addrList;
                    Close();
                }
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}