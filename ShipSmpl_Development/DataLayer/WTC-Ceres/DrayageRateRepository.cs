using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class DrayageRateRepository : IDrayageRateRepository
    {
        private WTCCeresEntities db = new WTCCeresEntities();
        private DrayageRate dr = new DrayageRate();

        public bool Delete(int Id)
        {
            bool isDelete = true;
            try
            {
                dr = db.DrayageRate.Find(Id);
                db.DrayageRate.Remove(dr);
                db.SaveChanges();
            }
            catch (Exception)
            {
                isDelete = false;
            }
            return isDelete;
        }

        public List<DrayageRate> GetAll()
        {
            return db.DrayageRate.ToList();
        }

        public List<DrayageRate> GetById(int Id)
        {
            var listById = db.DrayageRate.Where(p => p.DrayageRateId == Id);

            return listById.ToList();
        }

        public bool Insert(int drayageSchemID, DateTime fromDate, DateTime toDate, decimal rate, string rateType)
        {
            bool isSave = true;
            try
            {
                dr.DrayageSchemeId = drayageSchemID;
                dr.FromDate = fromDate;
                dr.ToDate = toDate;
                dr.Rate = rate;
                dr.RateType = rateType;
                db.DrayageRate.Add(dr);
                db.SaveChanges();
            }
            catch (Exception)
            {
                isSave = false;
            }
            return isSave;
        }

        public bool Update(int Id, int drayageSchemID, DateTime fromDate, DateTime toDate, decimal rate, string rateType)
        {
            bool isSave = true;
            try
            {
                dr = db.DrayageRate.Find(Id);
                dr.DrayageRateId = Id;
                dr.DrayageSchemeId = drayageSchemID;
                dr.FromDate = fromDate.Date;
                dr.ToDate = toDate.Date;
                dr.Rate = rate;
                dr.RateType = rateType;
                db.DrayageRate.AddOrUpdate(dr);
                db.SaveChanges();
            }
            catch (Exception)
            {
                isSave = false;
            }
            return isSave;
        }
    }

    public interface IDrayageRateRepository
    {
        List<DrayageRate> GetAll();

        List<DrayageRate> GetById(int Id);

        bool Insert(int drayageSchemID, DateTime fromDate, DateTime toDate, decimal rate, string rateType);

        bool Update(int Id, int drayageSchemID, DateTime fromDate, DateTime toDate, decimal rate, string rateType);

        bool Delete(int Id);
    }
}