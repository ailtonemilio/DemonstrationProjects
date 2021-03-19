using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class CountryRegionRepository : ICountryRegionRepository
    {
        public bool AddOrUpdate(CountryRegion countryRegion, WTCCeresEntities db)
        {
            bool isSaved = true;

            try
            {
                db.CountryRegion.AddOrUpdate(countryRegion);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                isSaved = false;
            }

            return isSaved;
        }

        public List<CountryRegion> GetByCountryId(int CountryId, WTCCeresEntities db)
        {
            return db.CountryRegion.Where(cr => cr.CountryId == CountryId).OrderBy(cr => cr.RegionCode).ToList();
        }

        public CountryRegion GetById(int CountryRegionId, WTCCeresEntities db)
        {
            return db.CountryRegion.Find(CountryRegionId);
        }
    }

    public interface ICountryRegionRepository
    {
        List<CountryRegion> GetByCountryId(int CountryId, WTCCeresEntities db);

        CountryRegion GetById(int CountryRegionId, WTCCeresEntities db);

        bool AddOrUpdate(CountryRegion countryRegion, WTCCeresEntities db);
    }
}