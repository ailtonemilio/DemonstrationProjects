using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class RegionCityRepository : IRegionCityRepository
    {
        public bool AddOrUpdate(RegionCity regionCity, WTCCeresEntities db)
        {
            bool isSaved = true;

            try
            {
                db.RegionCity.AddOrUpdate(regionCity);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                isSaved = false;
            }

            return isSaved;
        }

        public List<RegionCity> GetByCountryRegionId(int CountryRegionId, WTCCeresEntities db)
        {
            return db.RegionCity.Where(cr => cr.CountryRegionId == CountryRegionId).OrderBy(cr => cr.CityName).ToList();
        }

        public RegionCity GetById(int RegionCityId, WTCCeresEntities db)
        {
            return db.RegionCity.Find(RegionCityId);
        }

        public List<VW_RegionCity> GetRegionCityVWByCountryId(int CountryId, WTCCeresEntities db)
        {
            return db.VW_RegionCity.Where(cr => cr.CountryId == CountryId).OrderBy(cr => cr.RegionCode).ToList();
        }
    }

    public interface IRegionCityRepository
    {
        RegionCity GetById(int RegionCityId, WTCCeresEntities db);

        bool AddOrUpdate(RegionCity regionCity, WTCCeresEntities db);

        List<RegionCity> GetByCountryRegionId(int CountryRegionId, WTCCeresEntities db);

        List<VW_RegionCity> GetRegionCityVWByCountryId(int CountryId, WTCCeresEntities db);
    }
}