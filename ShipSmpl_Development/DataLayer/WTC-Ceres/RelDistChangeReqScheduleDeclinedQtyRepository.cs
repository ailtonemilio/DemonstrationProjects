using ModelLayer;
using System;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class RelDistChangeReqScheduleDeclinedQtyRepository : IRelDistChangeReqScheduleDeclinedQtyRepository
    {
        public bool AddOrUpdate(RelDistChangeReqScheduleDeclinedQty relDistChangeReqScheduleDeclinedQty)
        {
            bool isSaved = true;
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    db.RelDistChangeReqScheduleDeclinedQty.AddOrUpdate(relDistChangeReqScheduleDeclinedQty);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    isSaved = false;
                }
            }

            return isSaved;
        }

        public bool Delete(int RelDistChangeReqScheduleDeclinedQtyId)
        {
            bool isSaved = true;
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    RelDistChangeReqScheduleDeclinedQty d = db.RelDistChangeReqScheduleDeclinedQty.Find(RelDistChangeReqScheduleDeclinedQtyId);
                    db.RelDistChangeReqScheduleDeclinedQty.Remove(d);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    isSaved = false;
                }
            }
            return isSaved;
        }

        public RelDistChangeReqScheduleDeclinedQty GetByRelDistChangeReqScheduleIdId(int RelDistChangeReqScheduleId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var l = db.RelDistChangeReqScheduleDeclinedQty.
                    Where(r => r.RelDistChangeReqScheduleId == RelDistChangeReqScheduleId).ToList();

                if (l.Count > 0)
                    return l[0];
                else
                    return null;
            }
        }
    }

    public interface IRelDistChangeReqScheduleDeclinedQtyRepository
    {
        bool AddOrUpdate(RelDistChangeReqScheduleDeclinedQty relDistChangeReqScheduleDeclinedQty);

        bool Delete(int RelDistChangeReqScheduleDeclinedQtyId);

        RelDistChangeReqScheduleDeclinedQty GetByRelDistChangeReqScheduleIdId(int RelDistChangeReqScheduleId);
    }
}