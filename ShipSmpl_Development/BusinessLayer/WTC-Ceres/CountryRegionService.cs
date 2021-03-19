using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class CountryRegionService
    {
        private static ICountryRegionRepository repository;

        static CountryRegionService()
        {
            repository = new CountryRegionRepository();
        }

        public static List<CountryRegion> GetByCountryId(int CountryId, WTCCeresEntities db)
        {
            return repository.GetByCountryId(CountryId, db);
        }

        public static CountryRegion GetById(int CountryRegionId, WTCCeresEntities db)
        {
            return repository.GetById(CountryRegionId, db);
        }

        public bool AddOrUpdate(CountryRegion countryRegion, WTCCeresEntities db)
        {
            return repository.AddOrUpdate(countryRegion, db);
        }
    }
}