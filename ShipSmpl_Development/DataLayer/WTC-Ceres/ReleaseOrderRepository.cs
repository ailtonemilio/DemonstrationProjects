using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class ReleaseOrderRepository : IReleaseDetailRepository
    {
        private ReleaseOrder rd = new ReleaseOrder();

        public bool AddOrUpdate(ReleaseOrder releaseDetail)
        {
            bool isSaved = true;
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    rd = releaseDetail;
                    if (releaseDetail.ReleaseOrderId == 0)
                        db.ReleaseOrder.Add(rd);
                    else
                        db.ReleaseOrder.AddOrUpdate(rd);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    string msg = ex.Message;
                    isSaved = false;
                }
            }
            return isSaved;
        }

        public bool Delete(int ReleaseOrderId)
        {
            bool isSaved = true;
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    rd = db.ReleaseOrder.Find(ReleaseOrderId);
                    db.ReleaseOrder.Remove(rd);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    string msg = ex.Message;
                    isSaved = false;
                }
            }
            return isSaved;
        }

        public List<VW_ReleaseOrder> GetAllVWByReleaseId(int ReleaseId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_ReleaseOrder.Where(r => r.ReleaseId == ReleaseId).
                    OrderByDescending(r => r.DateAccepted != null ? r.DateAccepted : DateTime.MinValue).ToList();
            }
        }

        public List<ReleaseOrder> GetAllByReleaseId(int ReleaseId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.ReleaseOrder.Where(r => r.ReleaseId == ReleaseId).
                    OrderByDescending(r => r.DateAccepted != null ? r.DateAccepted : DateTime.MinValue).ToList();
            }
        }

        public List<VW_ReleaseOrder> GetAllVWByInboundRequestId(int InboundRequestId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_ReleaseOrder.Where(r => r.InboundRequestId == InboundRequestId).
                     OrderByDescending(r => r.DateAccepted != null ? r.DateAccepted : DateTime.MinValue).ToList();
            }
        }

        public List<ReleaseOrder> GetAllByInboundRequestId(int InboundRequestId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.ReleaseOrder.Where(r => r.InboundRequestId == InboundRequestId).ToList();
            }
        }

        public int GetLastReleaseOrderId()
        {
            return rd.ReleaseOrderId;
        }
    }

    public interface IReleaseDetailRepository
    {
        List<VW_ReleaseOrder> GetAllVWByReleaseId(int ReleaseId);

        List<ReleaseOrder> GetAllByReleaseId(int ReleaseId);

        List<VW_ReleaseOrder> GetAllVWByInboundRequestId(int InboundRequestId);

        List<ReleaseOrder> GetAllByInboundRequestId(int InboundRequestId);

        bool AddOrUpdate(ReleaseOrder releaseOrder);

        bool Delete(int ReleaseOrderId);

        int GetLastReleaseOrderId();
    }
}