using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class ReleaseOrderMinibookingRepository : IReleaseOrderMinibookingRepository
    {
        private ReleaseOrderMinibooking rdm = new ReleaseOrderMinibooking();

        public bool AddOrUpdate(ReleaseOrderMinibooking releaseDetailMinibooking)
        {
            bool isSaved = true;

            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    rdm = releaseDetailMinibooking;

                    if (releaseDetailMinibooking.ReleaseOrderMinibookingId == 0)
                        db.ReleaseOrderMinibooking.Add(releaseDetailMinibooking);
                    else
                        db.ReleaseOrderMinibooking.AddOrUpdate(releaseDetailMinibooking);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    string msg = ex.Message + " - " + ex.InnerException.Message;
                    isSaved = false;
                }
            }

            return isSaved;
        }

        public bool Delete(int ReleaseDetailMiniboolingId)
        {
            bool isSaved = true;

            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    rdm = db.ReleaseOrderMinibooking.Find(ReleaseDetailMiniboolingId);

                    db.ReleaseOrderMinibooking.Remove(rdm);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    string msg = ex.Message + " - " + ex.InnerException.Message;
                    isSaved = false;
                }
            }

            return isSaved;
        }

        public List<VW_ReleaseOrderMinibooking> GetAllVWByMinibookingId(int MinibookingId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_ReleaseOrderMinibooking.Where(r => r.MinibookingId == MinibookingId).ToList();
            }
        }

        public List<ReleaseOrderMinibooking> GetAllByReleaseOrderId(int ReleaseOrderId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.ReleaseOrderMinibooking.Where(r => r.ReleaseOrderId == ReleaseOrderId).ToList();
            }
        }

        public List<VW_ReleaseOrderMinibooking> GetAllVWByRelOrderId(int ReleaseOrderId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_ReleaseOrderMinibooking.Where(r => r.ReleaseOrderId == ReleaseOrderId).ToList();
            }
        }

        public List<VW_ReleaseOrderMinibooking> GetAllVWByReleaseId(int ReleaseId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_ReleaseOrderMinibooking.Where(r => r.ReleaseId == ReleaseId).ToList();
            }
        }
    }

    public interface IReleaseOrderMinibookingRepository
    {
        List<VW_ReleaseOrderMinibooking> GetAllVWByReleaseId(int ReleaseId);

        List<VW_ReleaseOrderMinibooking> GetAllVWByMinibookingId(int ReleaseOrderId);

        List<ReleaseOrderMinibooking> GetAllByReleaseOrderId(int MinibookingId);

        List<VW_ReleaseOrderMinibooking> GetAllVWByRelOrderId(int ReleaseOrderId);

        bool AddOrUpdate(ReleaseOrderMinibooking releaseDetailMinibooking);

        bool Delete(int ReleaseDetailMiniboolingId);
    }
}