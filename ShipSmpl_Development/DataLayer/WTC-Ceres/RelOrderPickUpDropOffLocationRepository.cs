using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class RelOrderPickUpDropOffLocationRepository : IRelOrderPickUpDropOffLocationRepository
    {
        public bool AddOrUpdate(RelOrderPickUpDropOffLocation relOrderPickUpDropOffLocation)
        {
            bool isSaved = true;
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    db.RelOrderPickUpDropOffLocation.AddOrUpdate(relOrderPickUpDropOffLocation);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    string msg = ex.InnerException.Message;
                    isSaved = false;
                }
            }

            return isSaved;
        }

        public bool Delete(int RelOrderPickUpDropOffLocationId)
        {
            bool isSaved = true;
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    RelOrderPickUpDropOffLocation rel = db.RelOrderPickUpDropOffLocation.Find(RelOrderPickUpDropOffLocationId);
                    db.RelOrderPickUpDropOffLocation.Remove(rel);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    string msg = ex.InnerException.Message;
                    isSaved = false;
                }
            }

            return isSaved;
        }

        public RelOrderPickUpDropOffLocation GetById(int RelOrderPickUpDropOffLocationId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.RelOrderPickUpDropOffLocation.Find(RelOrderPickUpDropOffLocationId);
            }
        }

        public List<VW_RelOrderPickUpDropOffLocation> GetByReleaseOrderId(int ReleaseOrderId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_RelOrderPickUpDropOffLocation.Where(p => p.ReleaseOrderId == ReleaseOrderId).ToList();
            }
        }

        public List<VW_RelOrderPickUpDropOffLocation> GetByInboundRequestId(int InboundRequestId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_RelOrderPickUpDropOffLocation.Where(p => p.InboundRequestId == InboundRequestId).ToList();
            }
        }

        public List<VW_RelOrderPickUpDropOffLocation> GetAllByOpenStatus(bool isOpenRequest)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_RelOrderPickUpDropOffLocation.Where(r => r.isOpenRequest == isOpenRequest).ToList();
            }
        }
    }

    public interface IRelOrderPickUpDropOffLocationRepository
    {
        List<VW_RelOrderPickUpDropOffLocation> GetByReleaseOrderId(int ReleaseOrderId);

        List<VW_RelOrderPickUpDropOffLocation> GetByInboundRequestId(int InboundRequestId);

        List<VW_RelOrderPickUpDropOffLocation> GetAllByOpenStatus(bool isOpenRequest);

        RelOrderPickUpDropOffLocation GetById(int RelOrderPickUpDropOffLocationId);

        bool AddOrUpdate(RelOrderPickUpDropOffLocation relOrderPickUpDropOffLocation);

        bool Delete(int RelOrderPickUpDropOffLocationId);
    }
}