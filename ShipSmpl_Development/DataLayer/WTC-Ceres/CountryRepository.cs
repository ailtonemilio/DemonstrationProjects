using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class CountryRepository : ICountryRepository
    {
        private Country c = new Country();

        public bool Delete(int Id)
        {
            bool isSaved = true;
            try
            {
                using (WTCCeresEntities db = new WTCCeresEntities())
                {
                    c = db.Country.Find(Id);
                    db.Country.Remove(c);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                string msg = ex.ToString();
                isSaved = false;
            }
            return isSaved;
        }

        public List<Country> GetAll()
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.Country.ToList();
            }
        }

        public List<Country> GetAll(WTCCeresEntities db)
        {
            return db.Country.OrderBy(c => c.CountryName).ToList();
        }

        public List<Country> GetById(int Id)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var listById = db.Country.Where(p => p.CountryId == Id);
                return listById.ToList();
            }
        }

        public bool Insert(string Code, string CountryName, int PhoneCode)
        {
            bool isSave = true;
            try
            {
                using (WTCCeresEntities db = new WTCCeresEntities())
                {
                    c.Code = Code;
                    c.CountryName = CountryName;
                    c.PhoneCode = PhoneCode;
                    db.Country.Add(c);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                string msg = ex.ToString();
                isSave = false;
            }
            return isSave;
        }

        public bool Update(int CountryId, string Code, string CountryName, int PhoneCode)
        {
            bool isSave = true;
            try
            {
                using (WTCCeresEntities db = new WTCCeresEntities())
                {
                    c = db.Country.Find(CountryId);
                    c.CountryId = CountryId;
                    c.Code = Code;
                    c.CountryName = CountryName;
                    c.PhoneCode = PhoneCode;
                    db.Country.AddOrUpdate(c);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                string msg = ex.ToString();
                isSave = false;
            }
            return isSave;
        }
    }

    public interface ICountryRepository
    {
        List<Country> GetAll();

        List<Country> GetAll(WTCCeresEntities db);

        List<Country> GetById(int Id);

        //List<VesselList> GetVesselListAll();
        bool Insert(string Code, string CountryName, int PhoneCode);

        bool Update(int CountryId, string Code, string CountryName, int PhoneCode);

        bool Delete(int Id);
    }
}