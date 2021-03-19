using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class ReleaseOrderService
    {
        private static IReleaseDetailRepository repository;

        static ReleaseOrderService()
        {
            repository = new ReleaseOrderRepository();
        }

        public static List<VW_ReleaseOrder> GetAllVWByReleaseId(int ReleaseId)
        {
            return repository.GetAllVWByReleaseId(ReleaseId);
        }

        public static List<ReleaseOrder> GetAllByReleaseId(int ReleaseId)
        {
            return repository.GetAllByReleaseId(ReleaseId);
        }

        public static List<VW_ReleaseOrder> GetAllVWByInboundRequestId(int InboundRequestId)
        {
            return repository.GetAllVWByInboundRequestId(InboundRequestId);
        }

        public static List<ReleaseOrder> GetAllByInboundRequestId(int InboundRequestId)
        {
            return repository.GetAllByInboundRequestId(InboundRequestId);
        }

        public bool AddOrUpdate(ReleaseOrder releaseOrder)
        {
            return repository.AddOrUpdate(releaseOrder);
        }

        public bool Delete(int ReleaseOrderId)
        {
            return repository.Delete(ReleaseOrderId);
        }

        public int GetLastReleaseOrderId()
        {
            return repository.GetLastReleaseOrderId();
        }
    }
}