using DataLayer.WTC_Ceres;
using ModelLayer;
using ModelLayer.CustomModel;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class InboundReqDeclinedQtyService
    {
        private static IInboundReqDeclinedQtyRepository repository;

        static InboundReqDeclinedQtyService()
        {
            repository = new InboundReqDeclinedQtyRepository();
        }

        public bool AddOrUpdate(InboundReqDeclinedQty inboundReqDeclinedQty)
        {
            return repository.AddOrUpdate(inboundReqDeclinedQty);
        }

        public bool Delete(int InboundReqDeclinedQtyId)
        {
            return repository.Delete(InboundReqDeclinedQtyId);
        }

        public static List<VW_InboundReqDeclinedQty> GetVWById(int InboundReqDeclinedQtyId)
        {
            return repository.GetVWById(InboundReqDeclinedQtyId);
        }

        public static InboundReqDeclinedQty GetById(int InboundReqDeclinedQtyId)
        {
            return repository.GetById(InboundReqDeclinedQtyId);
        }

        //List<InboundReqDeclinedQty> GetByInboundRequestId(int InboundRequestId);

        public static List<VW_InboundReqDeclinedQty> GetVWByInboundRequestId(int InboundRequestId)
        {
            return repository.GetVWByInboundRequestId(InboundRequestId);
        }
    }
}