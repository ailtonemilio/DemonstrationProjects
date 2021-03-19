using DataLayer.WTC_Ceres;
using ModelLayer;

namespace BusinessLayer.WTC_Ceres
{
    public class RelDistChangeReqScheduleDeclinedQtyService
    {
        private static IRelDistChangeReqScheduleDeclinedQtyRepository repository;

        static RelDistChangeReqScheduleDeclinedQtyService()
        {
            repository = new RelDistChangeReqScheduleDeclinedQtyRepository();
        }

        public bool AddOrUpdate(RelDistChangeReqScheduleDeclinedQty relDistChangeReqScheduleDeclinedQty)
        {
            return repository.AddOrUpdate(relDistChangeReqScheduleDeclinedQty);
        }

        public bool Delete(int RelDistChangeReqScheduleDeclinedQtyId)
        {
            return repository.Delete(RelDistChangeReqScheduleDeclinedQtyId);
        }

        public static RelDistChangeReqScheduleDeclinedQty GetByRelDistChangeReqScheduleIdId(int RelDistChangeReqScheduleId)
        {
            return repository.GetByRelDistChangeReqScheduleIdId(RelDistChangeReqScheduleId);
        }
    }
}