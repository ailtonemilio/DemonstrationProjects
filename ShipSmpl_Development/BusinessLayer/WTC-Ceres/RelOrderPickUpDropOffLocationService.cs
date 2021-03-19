using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class RelOrderPickUpDropOffLocationService
    {
        private static IRelOrderPickUpDropOffLocationRepository repository;

        static RelOrderPickUpDropOffLocationService()
        {
            repository = new RelOrderPickUpDropOffLocationRepository();
        }

        public static List<VW_RelOrderPickUpDropOffLocation> GetByReleaseOrderId(int ReleaseOrderId)
        {
            return repository.GetByReleaseOrderId(ReleaseOrderId);
        }

        public static List<VW_RelOrderPickUpDropOffLocation> GetByInboundRequestId(int InboundRequestId)
        {
            return repository.GetByInboundRequestId(InboundRequestId);
        }

        public bool AddOrUpdate(RelOrderPickUpDropOffLocation relOrderPickUpDropOffLocation)
        {
            return repository.AddOrUpdate(relOrderPickUpDropOffLocation);
        }

        public bool Delete(int RelOrderPickUpDropOffLocationId)
        {
            return repository.Delete(RelOrderPickUpDropOffLocationId);
        }

        public static RelOrderPickUpDropOffLocation GetById(int RelOrderPickUpDropOffLocationId)
        {
            return repository.GetById(RelOrderPickUpDropOffLocationId);
        }

        public static List<VW_RelOrderPickUpDropOffLocation> GetAllByOpenStatus(bool isOpenRequest)
        {
            return repository.GetAllByOpenStatus(isOpenRequest);
        }
    }
}