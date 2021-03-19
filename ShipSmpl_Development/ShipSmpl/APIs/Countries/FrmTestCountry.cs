using ShipSmpl.Countries;
using System;
using System.Collections.Generic;

namespace ShipSmpl
{
    public partial class FrmTestCountry
    {
        public FrmTestCountry()
        {
            InitializeComponent();
            _cboCountry.Name = "cboCountry";
            _cboRegion.Name = "cboRegion";
            _cboCity.Name = "cboCity";
        }

        private CountriesAPI API = new CountriesAPI();
        private List<Country> countriesList = new List<Country>();
        private List<CountryRegion> regionList = new List<CountryRegion>();
        private List<City> cityList = new List<City>();

        private async void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            Country country = (Country)cboCountry.SelectedItem;
            regionList = await API.GetAllRegions(country.code);
            cboRegion.DataSource = regionList;
        }

        private async void cboRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            CountryRegion reg = (CountryRegion)cboRegion.SelectedItem;
            cityList = await API.GetAllCities(reg);
            cboCity.DataSource = cityList;
        }

        private async void cboCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            // cityList = Await API.GetAllCities(cboCity.SelectedValue)
            // cboCity.DataSource = cityList
        }

        private async void FrmTestCountry_Load(object sender, EventArgs e)
        {
            countriesList = await API.GetAllCountries();
            {
                var withBlock = cboRegion;
                withBlock.DataSource = regionList;
                withBlock.DisplayMember = "region";
                withBlock.ValueMember = "region";
            }

            {
                var withBlock1 = cboCity;
                withBlock1.DataSource = cityList;
                withBlock1.DisplayMember = "city";
            }

            {
                var withBlock2 = cboCountry;
                withBlock2.DataSource = countriesList;
                withBlock2.DisplayMember = "name";
                withBlock2.ValueMember = "code";
                withBlock2.SelectedIndex = 0;
            }
        }
    }
}