
namespace ShipSmpl.Countries
{
    public class Country
    {
        public string name { get; set; }
        public string code { get; set; }
    }

    public class CountryRegion
    {
        public string region { get; set; }
        public string country { get; set; }
    }

    public class City
    {
        public string city { get; set; }
        public string country { get; set; }
        public string region { get; set; }
    }
}