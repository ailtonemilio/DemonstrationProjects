using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class RelDistRequestScheduleService
    {
        private static IRelDistRequestScheduleRepository repository;

        static RelDistRequestScheduleService()
        {
            repository = new RelDistRequestScheduleRepository();
        }

        public static RelDistRequestSchedule GetById(int RelDistRequestScheduleId)
        {
            return repository.GetById(RelDistRequestScheduleId);
        }

        public static VW_RelDistRequestSchedule GetVWById(int RelDistRequestScheduleId)
        {
            return repository.GetVWById(RelDistRequestScheduleId);
        }

        public static List<VW_RelDistRequestSchedule> GetAllVWByRelDistReqId(int ReleaseDistributionRequestId)
        {
            return repository.GetAllVWByRelDistReqId(ReleaseDistributionRequestId);
        }

        public static List<RelDistRequestSchedule> GetAllByRelDistReqId(int ReleaseDistributionRequestId)
        {
            return repository.GetAllByRelDistReqId(ReleaseDistributionRequestId);
        }

        public bool AddOrUpdate(RelDistRequestSchedule relDistRequestSchedule)
        {
            return repository.AddOrUpdate(relDistRequestSchedule);
        }

        public bool Delete(int relDistRequestScheduleId)
        {
            return repository.Delete(relDistRequestScheduleId);
        }
    }
}