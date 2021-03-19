using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class RelDistScheduleAcceptedService
    {
        private static IRelDistScheduleAcceptedRepository repository;

        static RelDistScheduleAcceptedService()
        {
            repository = new RelDistScheduleAcceptedRepository();
        }

        public bool AddOrUpdate(RelDistScheduleAccepted relDistScheduleAccepted)
        {
            return repository.AddOrUpdate(relDistScheduleAccepted);
        }

        public static RelDistScheduleAccepted GetById(int RelDistScheduleAcceptedId)
        {
            return repository.GetById(RelDistScheduleAcceptedId);
        }

        public static List<VW_RelDistReqSchRelDistSchAccpt>
            GetByReleaseDistributionRequestId(int ReleaseDistributionRequestId)
        {
            return repository.GetByReleaseDistributionRequestId(ReleaseDistributionRequestId);
        }
    }
}