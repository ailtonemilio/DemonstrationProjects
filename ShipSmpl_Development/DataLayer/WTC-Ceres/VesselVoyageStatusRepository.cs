using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class VesselVoyageStatusRepository : IVesselTripStatusRepository
    {
        private VesselVoyageStatus vs = new VesselVoyageStatus();
        private WTCCeresEntities db = new WTCCeresEntities();

        public bool Delete(int Id)
        {
            bool isSaved = true;
            try
            {
                using (WTCCeresEntities d = new WTCCeresEntities())
                {
                    vs = d.VesselVoyageStatus.Find(Id);
                    d.VesselVoyageStatus.Remove(vs);
                    d.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                isSaved = false;
            }
            return isSaved;
        }

        public List<VesselVoyageStatus> GetAll()
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VesselVoyageStatus.ToList();
            }
        }

        public List<VesselVoyageStatus> GetById(int Id)
        {
            var listById = db.VesselVoyageStatus.Where(p => p.VesselVoyageStatusId == Id);
            return listById.ToList();
        }

        public bool Insert(string StatusName)
        {
            bool isSave = true;
            try
            {
                using (WTCCeresEntities db = new WTCCeresEntities())
                {
                    vs.StatusName = StatusName;

                    db.VesselVoyageStatus.Add(vs);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                isSave = false;
            }
            return isSave;
        }

        public bool Update(int VesselId, string StatusName)
        {
            bool isSave = true;
            try
            {
                using (WTCCeresEntities db = new WTCCeresEntities())
                {
                    vs = db.VesselVoyageStatus.Find(VesselId);
                    vs.StatusName = StatusName;
                    db.VesselVoyageStatus.AddOrUpdate(vs);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                isSave = false;
            }
            return isSave;
        }
    }

    public interface IVesselTripStatusRepository
    {
        List<VesselVoyageStatus> GetAll();

        List<VesselVoyageStatus> GetById(int Id);

        bool Insert(string StatusName);
        bool Update(int VesselTripStatus, string StatusName);
        bool Delete(int Id);
    }
}
