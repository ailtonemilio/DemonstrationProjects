using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ShipSmpl.Countries
{
    public class CountriesAPI
    {
        public List<Country> AllCoutries = new List<Country>();
        public List<CountryRegion> AllRegions = new List<CountryRegion>();
        public List<City> AllCities = new List<City>();
        private string API_KEY = "5a0696583250ae94aa57b744c1a41711";

        public async Task<List<Country>> GetAllCountries()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://battuta.medunes.net/api/");
            var responseMessage = await client.GetAsync("country/all/?key=" + API_KEY, HttpCompletionOption.ResponseContentRead);
            string resultArray = await responseMessage.Content.ReadAsStringAsync();
            var countryList = new List<Country>();
            countryList = JsonConvert.DeserializeObject<List<Country>>(resultArray);
            AllCoutries = countryList;
            return countryList;
        }

        public async Task<List<CountryRegion>> GetAllRegions(string CountryCode)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://battuta.medunes.net/api/");
                var responseMessage = await client.GetAsync("region/" + CountryCode.ToLower() + "/all/?key=" + API_KEY, HttpCompletionOption.ResponseContentRead);
                string resultArray = await responseMessage.Content.ReadAsStringAsync();
                var regionList = new List<CountryRegion>();
                regionList = JsonConvert.DeserializeObject<List<CountryRegion>>(resultArray);
                AllRegions = regionList;
                return regionList;
            }
            catch (Exception ex)
            {
                string msg = ex.Message.ToString();
                return null;
            }
        }

        public async Task<List<City>> GetAllCities(CountryRegion region)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://battuta.medunes.net/api/");
            var responseMessage = await client.GetAsync("city/" + region.country + "/search/?region=" + region.region + "&key=" + API_KEY, HttpCompletionOption.ResponseContentRead);
            string resultArray = await responseMessage.Content.ReadAsStringAsync();
            var citiesList = new List<City>();
            citiesList = JsonConvert.DeserializeObject<List<City>>(resultArray);
            AllCities = citiesList;
            return citiesList;
        }
    }
}