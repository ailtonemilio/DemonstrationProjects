using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class TruckDriverCompanyRepository : ITruckDriverCompanyRepository
    {
        private WTCCeresEntities db = new WTCCeresEntities();
        private TruckDriverCompany tdc = new TruckDriverCompany();

        public bool Delete(int TruckDriverCompanyId)
        {
            bool isDelete = true;
            try
            {
                tdc = db.TruckDriverCompany.Find(TruckDriverCompanyId);
                db.TruckDriverCompany.Remove(tdc);
                db.SaveChanges();
            }
            catch (Exception)
            {
                isDelete = false;
            }
            return isDelete;
        }

        public List<TruckDriverCompany> GetAll()
        {
            var L = db.TruckDriverCompany.ToList();
            return L;
        }

        public List<TruckDriverCompany> GetById(int TruckDriverCompanyId)
        {
            var L = db.TruckDriverCompany.Where(t => t.TruckDriverCompanyId == TruckDriverCompanyId).ToList();
            return L;
        }

        public bool Insert(int TruckDriverId, int CompanyId)
        {
            bool isSave = true;
            try
            {
                tdc.TruckDriverId = TruckDriverId;
                tdc.CompanyId = CompanyId;
                db.TruckDriverCompany.Add(tdc);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                e.ToString();
                isSave = false;
            }
            return isSave;
        }

        public int LastTruckDriverCompanyId()
        {
            int lastID = 0;

            var LastId = (from r in db.TruckDriverCompany
                          orderby r.TruckDriverCompanyId descending
                          select r).First();

            lastID = LastId.TruckDriverCompanyId;

            return lastID;
        }

        public bool Update(int TruckDriverCompanyId, int TruckDriverId, int CompanyId)
        {
            bool isSave = true;
            try
            {
                tdc = db.TruckDriverCompany.Find(TruckDriverCompanyId);
                tdc.TruckDriverId = TruckDriverId;
                tdc.CompanyId = CompanyId;
                db.TruckDriverCompany.AddOrUpdate(tdc);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                e.ToString();
                isSave = false;
            }
            return isSave;
        }
    }

    public interface ITruckDriverCompanyRepository
    {
        List<TruckDriverCompany> GetAll();

        List<TruckDriverCompany> GetById(int TruckDriverCompanyId);

        int LastTruckDriverCompanyId();

        bool Insert(int TruckDriverId, int CompanyId);

        bool Update(int TruckDriverCompanyId, int TruckDriverId, int CompanyId);

        bool Delete(int TruckDriverCompanyId);
    }
}