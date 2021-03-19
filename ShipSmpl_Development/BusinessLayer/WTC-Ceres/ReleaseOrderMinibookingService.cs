using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class ReleaseOrderMinibookingService
    {
        private static IReleaseOrderMinibookingRepository repository;

        static ReleaseOrderMinibookingService()
        {
            repository = new ReleaseOrderMinibookingRepository();
        }

        public static List<VW_ReleaseOrderMinibooking> GetAllVWByReleaseId(int ReleaseId)
        {
            return repository.GetAllVWByReleaseId(ReleaseId);
        }

        public static List<VW_ReleaseOrderMinibooking> GetAllVWByMinibookingId(int MinibookingId)
        {
            return repository.GetAllVWByMinibookingId(MinibookingId);
        }

        public static List<ReleaseOrderMinibooking> GetAllByReleaseOrderId(int ReleaseOrderId)
        {
            return repository.GetAllByReleaseOrderId(ReleaseOrderId);
        }

        public bool AddOrUpdate(ReleaseOrderMinibooking releaseDetailMinibooking)
        {
            return repository.AddOrUpdate(releaseDetailMinibooking);
        }

        public bool Delete(int ReleaseDetailMiniboolingId)
        {
            return repository.Delete(ReleaseDetailMiniboolingId);
        }

        public static List<VW_ReleaseOrderMinibooking> GetAllVWByRelOrderId(int ReleaseOrderId)
        {
            return repository.GetAllVWByRelOrderId(ReleaseOrderId);
        }
    }
}