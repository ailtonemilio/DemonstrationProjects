using DataLayer;
using ModelLayer;
using ModelLayer.CustomModel;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class RelDistChangeSchRequestedService
    {
        private static IRelDistChangeSchRequestedRepository repository;

        static RelDistChangeSchRequestedService()
        {
            repository = new RelDistChangeSchRequestedRepository();
        }

        public static List<VW_RelDistChangeSchRequested> GetByRelDistRequestId(int ReleaseDistributionRequestId)
        {
            return repository.GetByRelDistRequestId(ReleaseDistributionRequestId);
        }

        public static RelDistChangeReqSchedule GetById(int RelDistChangeReqScheduleId)
        {
            return repository.GetById(RelDistChangeReqScheduleId);
        }

        public bool AddOrUpdate(RelDistChangeReqSchedule relDistChangeReqSchedule)
        {
            return repository.AddOrUpdate(relDistChangeReqSchedule);
        }
    }
}