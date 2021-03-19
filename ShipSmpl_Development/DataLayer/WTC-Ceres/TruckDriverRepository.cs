using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.Migrations;
using ModelLayer;
using ModelLayer.CustomModel;

namespace DataLayer.WTC_Ceres
{
    public class TruckDriverRepository : ITruckDriverRepository
    {
        private WTCCeresEntities db = new WTCCeresEntities();
        private TruckDriver td = new TruckDriver();
        private TruckDriverCompany tdc = new TruckDriverCompany();
        private Company c = new Company();

        public List<TruckDriver> GetAll()
        {
            return db.TruckDriver.ToList();
        }

        public List<TruckDriver> GetByPortPass(string PortPassId, WTCCeresEntities d)
        {
            var list = (from td in d.TruckDriver
                        join tdc in d.TruckDriverCompany on td.TruckDriverId equals tdc.TruckDriverId
                        join c in d.Company on tdc.CompanyId equals c.CompanyId
                        where td.PortPassId.Equals(PortPassId)
                        select td).ToList();

            var L = list;
            return L;
        }

        public List<TruckDriver> GetByTruckId(int TruckDriverId)
        {
            var L = db.TruckDriver.Where(t => t.TruckDriverId == TruckDriverId).ToList();
            return L;
        }

        public List<TruckDriverList> GetTruckDriverAllList(WTCCeresEntities d)
        {
            var listTruck = new List<TruckDriverList>();

            var list = (from td in d.TruckDriver
                        join tdc in d.TruckDriverCompany on td.TruckDriverId equals tdc.TruckDriverId
                        join c in d.Company on tdc.CompanyId equals c.CompanyId
                        select new
                        {
                            td.TruckDriverId,
                            td.FirstName,
                            td.LastName,
                            td.PortPassId,
                            td.TruckNumber,
                            td.SuspendTruckDriver,
                            c.CompanyId,
                            c.CompanyCode,
                            c.CompanyName,

                            tdc.TruckDriverCompanyId
                        }).ToList();

            foreach (var item in list)
            {
                listTruck.Add(new TruckDriverList
                {
                    TruckDriverId = item.TruckDriverId,
                    PortPassId = item.PortPassId,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    FullName = item.FirstName + " " + item.LastName,
                    TruckNumber = item.TruckNumber,
                    SuspendTruckDriver = item.SuspendTruckDriver,
                    CompanyId = item.CompanyId,
                    CompanyCode = item.CompanyCode,
                    CompanyName = item.CompanyName,
                    TruckDriverCompanyId = item.TruckDriverCompanyId
                });
            }

            return listTruck.ToList();
        }

        public bool Insert(string PortPassId, string TruckNumber, string FirstName, string LastName, bool SuspendyTruckDriver, int CompanyId)
        {
            bool isSave = true;
            try
            {
                //TruckDriver Table
                td.FirstName = FirstName;
                td.LastName = LastName;
                td.PortPassId = PortPassId;
                td.TruckNumber = TruckNumber.ToString();
                td.SuspendTruckDriver = SuspendyTruckDriver;
                db.TruckDriver.Add(td);
                db.SaveChanges();

                var L = (from r in db.TruckDriver
                         orderby r.TruckDriverId descending
                         select r).First();

                //TruckDriverCompany Table
                tdc.TruckDriverId = Convert.ToInt32(L.TruckDriverId);

                tdc.CompanyId = CompanyId;
                db.TruckDriverCompany.Add(tdc);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                string msg = ex.ToString();
                isSave = false;
            }
            return isSave;
        }

        public int LastTruckDriverId()
        {
            int lastID = 0;

            var LastId = (from r in db.TruckDriver
                          orderby r.TruckDriverId descending
                          select r).First();

            lastID = LastId.TruckDriverId;

            return lastID;
        }

        public bool SuspendTruckDriver(int TruckDriverId, bool Suspendy)
        {
            bool isSave = true;
            try
            {
                td = db.TruckDriver.Find(TruckDriverId);
                td.SuspendTruckDriver = Suspendy;

                db.TruckDriver.Attach(td);
                db.Entry(td).Property(p => p.SuspendTruckDriver).IsModified = true;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                string msg = ex.ToString();
                isSave = false;
            }
            return isSave;
        }

        public bool Update(int TruckDriverId, string PortPassId, string TruckNumber, string FirstName, string LastName, bool SuspendyTruckDriver)
        {
            bool isSave = true;
            try
            {
                td = db.TruckDriver.Find(TruckDriverId);
                td.TruckDriverId = TruckDriverId;
                td.PortPassId = PortPassId;
                td.TruckNumber = TruckNumber;
                td.FirstName = FirstName;
                td.LastName = LastName;
                td.SuspendTruckDriver = SuspendyTruckDriver;
                db.TruckDriver.AddOrUpdate(td);
                db.SaveChanges();
            }
            catch (Exception)
            {
                isSave = false;
            }
            return isSave;
        }
    }

    public interface ITruckDriverRepository
    {
        List<TruckDriver> GetAll();

        List<TruckDriver> GetByPortPass(string PortPassId, WTCCeresEntities d);

        List<TruckDriver> GetByTruckId(int TruckDriverId);

        List<TruckDriverList> GetTruckDriverAllList(WTCCeresEntities d);

        int LastTruckDriverId();

        bool Insert(string PortPassId, string TruckNumber, string FirstName, string LastName, bool SuspendyTruckDriver, int CompanyId);

        bool Update(int TruckDriverId, string PortPassId, string TruckNumber, string FirstName, string LastName, bool SuspendyTruckDriver);

        bool SuspendTruckDriver(int TruckDriverId, bool Suspendy);
    }
}