using ModelLayer;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class RelDistScheduleAcceptedRepository : IRelDistScheduleAcceptedRepository
    {
        public bool AddOrUpdate(RelDistScheduleAccepted relDistScheduleAccepted)
        {
            bool isSaved = true;
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    db.RelDistScheduleAccepted.AddOrUpdate(relDistScheduleAccepted);
                    db.SaveChanges();
                }
                catch
                {
                    isSaved = false;
                }
            }
            return isSaved;
        }

        public RelDistScheduleAccepted GetById(int RelDistScheduleAcceptedId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.RelDistScheduleAccepted.Find(RelDistScheduleAcceptedId);
            }
        }

        public List<VW_RelDistReqSchRelDistSchAccpt> GetByReleaseDistributionRequestId(int ReleaseDistributionRequestId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_RelDistReqSchRelDistSchAccpt.
                    Where(r => r.ReleaseDistributionRequestId == ReleaseDistributionRequestId).
                                            OrderBy(r => r.DateAccepted).ToList();
            }
        }
    }

    public interface IRelDistScheduleAcceptedRepository
    {
        bool AddOrUpdate(RelDistScheduleAccepted relDistScheduleAccepted);

        RelDistScheduleAccepted GetById(int RelDistScheduleAcceptedId);

        List<VW_RelDistReqSchRelDistSchAccpt> GetByReleaseDistributionRequestId(int ReleaseDistributionRequestId);
    }
}