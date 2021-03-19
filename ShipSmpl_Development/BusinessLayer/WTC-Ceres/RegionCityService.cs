using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class RegionCityService
    {
        private static IRegionCityRepository repository;

        static RegionCityService()
        {
            repository = new RegionCityRepository();
        }

        public static List<RegionCity> GetByCountryRegionId(int CountryRegionId, WTCCeresEntities db)
        {
            return repository.GetByCountryRegionId(CountryRegionId, db);
        }

        public static List<VW_RegionCity> GetRegionCityVWByCountryId(int CountryId, WTCCeresEntities db)
        {
            return repository.GetRegionCityVWByCountryId(CountryId, db);
        }

        public static RegionCity GetById(int RegionCityId, WTCCeresEntities db)
        {
            return repository.GetById(RegionCityId, db);
        }

        public bool AddOrUpdate(RegionCity regionCity, WTCCeresEntities db)
        {
            return repository.AddOrUpdate(regionCity, db);
        }
    }
}