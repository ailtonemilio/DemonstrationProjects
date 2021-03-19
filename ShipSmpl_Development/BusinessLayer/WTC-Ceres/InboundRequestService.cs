using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class InboundRequestService
    {
        private static IInboundRequestRepository repository;

        static InboundRequestService()
        {
            repository = new InboundRequestRepository();
        }

        public bool AddOrUpdate(InboundRequest inboundRequest)
        {
            return repository.AddOrUpdate(inboundRequest);
        }

        public bool Delete(int InboundRequestId)
        {
            return repository.Delete(InboundRequestId);
        }

        public static List<VW_InboundRequest> GetByFilter(string SSLineCode, string StatusName, string ReleaseType, bool isOpenRequest)
        {
            return repository.GetByFilter(SSLineCode, StatusName, ReleaseType, isOpenRequest);
        }

        public static List<VW_InboundRequest> GetByOpenStatus(bool isOpenRequest)
        {
            return repository.GetByOpenStatus(isOpenRequest);
        }

        public int GetLastInboundRequestId()
        {
            return repository.GetLastInboundRequestId();
        }

        public static InboundRequest GetById(int InboundRequestId)
        {
            return repository.GetById(InboundRequestId);
        }

        public static VW_InboundRequest GetVWById(int InboundRequestId)
        {
            return repository.GetVWById(InboundRequestId);
        }

        public static List<VW_InboundReport> GetInboundReport(bool isComplete)
        {
            return repository.GetInboundReport(isComplete);
        }
    }
}