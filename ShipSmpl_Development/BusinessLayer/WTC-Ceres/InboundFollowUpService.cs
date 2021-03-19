using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class InboundFollowUpService
    {
        private static IInboundFollowUpRepository repository;

        static InboundFollowUpService()
        {
            repository = new InboundFollowUpRepository();
        }

        public bool AddOrUpdate(InboundFollowUpRequest inboundFollowUpRequest)
        {
            return repository.AddOrUpdate(inboundFollowUpRequest);
        }

        public bool Delete(int InboundFollowUpRequestId)
        {
            return repository.Delete(InboundFollowUpRequestId);
        }

        public List<VW_InboundFollowUpRequest> GetByFilter(string SSLineName)
        {
            return repository.GetByFilter(SSLineName);
        }

        public static InboundFollowUpRequest GetByOpenInboundRequestId(int InboundRequestId)
        {
            return repository.GetByOpenInboundRequestId(InboundRequestId);
        }
    }
}