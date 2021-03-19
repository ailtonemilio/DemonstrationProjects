using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class DrayageSchemeRepository : IDrayageSchemeRepository
    {
        private WTCCeresEntities db = new WTCCeresEntities();
        private DrayageScheme ds = new DrayageScheme();
        //private Companies cp = new Companies();

        public bool Delete(int Id)
        {
            bool isDelete = true;
            try
            {
                ds = db.DrayageScheme.Find(Id);
                db.DrayageScheme.Remove(ds);
                db.SaveChanges();
            }
            catch (Exception)
            {
                isDelete = false;
            }
            return isDelete;
        }

        public List<DrayageScheme> GetAll()
        {
            return db.DrayageScheme.ToList();
        }

        public List<object> GetDrayageScheme(int truckingCompanyId, string rateType)
        {
            DateTime minDate = Convert.ToDateTime("1753-01-01");
            var dsEntries = (from dr in db.DrayageSchemeRate
                             where dr.RateType == rateType && dr.TruckingCompanyId == truckingCompanyId
                             select new
                             {
                                 drayageRateId = dr.DrayageRateId,
                                 drayageSchemeId = dr.DrayageSchemeId,
                                 truckingCompanyId = dr.TruckingCompanyId,
                                 fromDockId = dr.FromDockId,
                                 toDockId = dr.ToDockId,
                                 truckingCompany = dr.TruckingCompany,
                                 fromDock = dr.FromDock,
                                 toDock = dr.ToDock,
                                 fromDate = dr.FromDate,
                                 toDate = dr.ToDate,
                                 rateType = dr.RateType,
                                 rate = dr.Rate
                             }
                 ).ToList();

            return dsEntries.ToList<object>();
        }

        public List<object> GetAssignedRates(int truckingCompanyId, string rateType, string startDate)
        {
            DateTime minDate = Convert.ToDateTime("1753-01-01");
            DateTime fromDate = Convert.ToDateTime(startDate);
            string fromDateStr = fromDate.Date.ToString();

            var dsEntries = (from dr in db.DrayageSchemeRate
                             where dr.RateType == rateType && dr.TruckingCompanyId == truckingCompanyId &&
                             dr.FromDate <= fromDate && dr.FromDate >= fromDate
                             select new
                             {
                                 drayageRateId = dr.DrayageRateId,
                                 drayageSchemeId = dr.DrayageSchemeId,
                                 truckingCompanyId = dr.TruckingCompanyId,
                                 fromDockId = dr.FromDockId,
                                 toDockId = dr.ToDockId,
                                 truckingCompany = dr.TruckingCompany,
                                 fromDock = dr.FromDock,
                                 toDock = dr.ToDock,
                                 fromDate = dr.FromDate,
                                 toDate = dr.ToDate,
                                 rateType = dr.RateType,
                                 rate = dr.Rate
                             }
                 ).ToList();

            return dsEntries.ToList<object>();
        }

        public List<DrayageScheme> GetById(int Id)
        {
            var listById = db.DrayageScheme.Where(p => p.DrayageSchemeId == Id);

            return listById.ToList();
        }

        public List<DrayageScheme> GetByTruckId(int Id)
        {
            var listById = db.DrayageScheme.Where(p => p.TruckingCompanyId == Id);

            return listById.ToList();
        }

        public bool Insert(int TruckingCompanyID, int FromDockID, int ToDockID)
        {
            bool isSave = true;
            try
            {
                ds.TruckingCompanyId = TruckingCompanyID;
                ds.FromDockId = FromDockID;
                ds.ToDockId = ToDockID;
                db.DrayageScheme.Add(ds);
                db.SaveChanges();
            }
            catch (Exception)
            {
                isSave = false;
            }
            return isSave;
        }

        public int GetLastId()
        {
            int Id = 0;

            var Idd = db.DrayageScheme.SqlQuery("select MAX(DrayageSchemeId) as DrayageSchemeId from DrayageScheme").ToList();

            foreach (var item in Idd)
            {
                Id = item.DrayageSchemeId;
            }

            return Id;
        }

        public bool Update(int Id, int TruckingCompanyID, int FromDockID, int ToDockID)
        {
            bool isSave = true;
            try
            {
                ds = db.DrayageScheme.Find(Id);
                ds.TruckingCompanyId = TruckingCompanyID;
                ds.FromDockId = FromDockID;
                ds.ToDockId = ToDockID;
                db.DrayageScheme.AddOrUpdate(ds);
                db.SaveChanges();
            }
            catch (Exception)
            {
                isSave = false;
            }
            return isSave;
        }

        public int GetByFromToId(int truckingCompanyID, int fromDockID, int toDockID)
        {
            int Id = 0;

            //var Idd = db.DrayageScheme.SqlQuery("select DrayageSchemeId as DrayageSchemeId from DrayageScheme where TruckingCompanyId = " + truckingCompanyID.ToString() +
            //    "and  FromDockID = " + fromDockID.ToString() +
            //    " and toDockID = " + toDockID.ToString()).ToList();

            var Idd = from dr in db.DrayageScheme
                      where dr.TruckingCompanyId == truckingCompanyID &&
                      dr.FromDockId == fromDockID &&
                      dr.ToDockId == toDockID
                      select dr;

            foreach (var item in Idd)
            {
                Id = item.DrayageSchemeId;
            }

            return Id;
        }
    }

    public interface IDrayageSchemeRepository
    {
        List<DrayageScheme> GetAll();

        List<DrayageScheme> GetById(int Id);

        int GetByFromToId(int truckingCompanyID, int fromDockID, int toDockID);

        int GetLastId();

        List<DrayageScheme> GetByTruckId(int Id);

        List<object> GetDrayageScheme(int truckingCompanyId, string rateType);

        List<object> GetAssignedRates(int truckingCompanyId, string rateType, string startDate);

        bool Insert(int TruckingCompanyID, int FromDockID, int ToDockID);

        bool Update(int Id, int TruckingCompanyID, int FromDockID, int ToDockID);

        bool Delete(int Id);
    }
}