using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class RelDistRequestScheduleRepository : IRelDistRequestScheduleRepository
    {
        public bool AddOrUpdate(RelDistRequestSchedule relDistRequestSchedule)
        {
            bool isSaved = true;
            try
            {
                using (WTCCeresEntities db = new WTCCeresEntities())
                {
                    db.RelDistRequestSchedule.AddOrUpdate(relDistRequestSchedule);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                string msg = e.Message;
                isSaved = false;
            }

            return isSaved;
        }

        public bool Delete(int relDistRequestScheduleId)
        {
            bool isSaved = true;
            try
            {
                using (WTCCeresEntities db = new WTCCeresEntities())
                {
                    var r = db.RelDistRequestSchedule.Find(relDistRequestScheduleId);
                    db.RelDistRequestSchedule.Remove(r);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                string msg = e.Message;
                isSaved = false;
            }

            return isSaved;
        }

        public List<VW_RelDistRequestSchedule> GetAllVWByRelDistReqId(int ReleaseDistributionRequestId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_RelDistRequestSchedule.Where(r => r.ReleaseDistributionRequestId == ReleaseDistributionRequestId).ToList();
            }
        }
        public List<RelDistRequestSchedule> GetAllByRelDistReqId(int ReleaseDistributionRequestId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.RelDistRequestSchedule.Where(r => r.ReleaseDistributionRequestId == ReleaseDistributionRequestId).ToList();
            }
        }

        public RelDistRequestSchedule GetById(int RelDistRequestScheduleId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.RelDistRequestSchedule.Find(RelDistRequestScheduleId);
            }
        }

        public VW_RelDistRequestSchedule GetVWById(int RelDistRequestScheduleId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var list = db.VW_RelDistRequestSchedule.Where(r => r.RelDistRequestScheduleId == RelDistRequestScheduleId).ToList();

                if (list.Count > 0)
                    return list[0];
                else
                    return null;
            }
        }
    }

    public interface IRelDistRequestScheduleRepository
    {
        RelDistRequestSchedule GetById(int RelDistRequestScheduleId);

        VW_RelDistRequestSchedule GetVWById(int RelDistRequestScheduleId);

        List<VW_RelDistRequestSchedule> GetAllVWByRelDistReqId(int ReleaseDistributionRequestId);
        List<RelDistRequestSchedule> GetAllByRelDistReqId(int ReleaseDistributionRequestId);

        bool AddOrUpdate(RelDistRequestSchedule relDistRequestSchedule);

        bool Delete(int relDistRequestScheduleId);
    }
}