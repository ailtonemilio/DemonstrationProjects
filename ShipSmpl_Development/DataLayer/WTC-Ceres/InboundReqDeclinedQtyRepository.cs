using ModelLayer;
using ModelLayer.CustomModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class InboundReqDeclinedQtyRepository : IInboundReqDeclinedQtyRepository
    {
        private InboundReqDeclinedQty irdq = new InboundReqDeclinedQty();

        public bool AddOrUpdate(InboundReqDeclinedQty inboundReqDeclinedQty)
        {
            bool isSaved = true;
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    irdq = inboundReqDeclinedQty;
                    db.InboundReqDeclinedQty.AddOrUpdate(irdq);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    isSaved = false;
                }
            }
            return isSaved;
        }

        public bool Delete(int InboundReqDeclinedQtyId)
        {
            bool isSaved = true;
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    irdq = db.InboundReqDeclinedQty.Find(InboundReqDeclinedQtyId);
                    db.InboundReqDeclinedQty.Remove(irdq);
                    db.SaveChanges();
                }
                catch
                {
                    isSaved = false;
                }
            }
            return isSaved;
        }

        public InboundReqDeclinedQty GetById(int InboundReqDeclinedQtyId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.InboundReqDeclinedQty.Find(InboundReqDeclinedQtyId);
            }
        }

        List<VW_InboundReqDeclinedQty> IInboundReqDeclinedQtyRepository.GetVWByInboundRequestId(int InboundRequestId)
        {
            var InboundReqDeclinedQtyList = new List<VW_InboundReqDeclinedQty>();
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                List<InboundReqDeclinedQty> List = (db.InboundReqDeclinedQty.Where(i => i.InboundRequestId == InboundRequestId)).ToList();

                foreach (var item in List)
                {
                    InboundReqDeclinedQtyList.Add(new VW_InboundReqDeclinedQty
                    {
                        InboundRequestId = item.InboundRequestId,
                        QtyDeclined = item.QtyDeclined,
                        SSLineName = item.InboundRequest.Company.CompanyName,
                        DeclineStatus = item.DeclineStatus,
                        Notes = item.Notes,
                        CreatedAt = item.CreatedAt
                    }); ;
                }
            }
            return InboundReqDeclinedQtyList;
        }

        public List<VW_InboundReqDeclinedQty> GetVWById(int InboundReqDeclinedQtyId)
        {
            var InboundReqDeclinedQtyList = new List<VW_InboundReqDeclinedQty>();
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                List<InboundReqDeclinedQty> List = (db.InboundReqDeclinedQty.Where(i => i.InboundRequestId == InboundReqDeclinedQtyId)).ToList();

                foreach (var item in List)
                {
                    InboundReqDeclinedQtyList.Add(new VW_InboundReqDeclinedQty
                    {
                        InboundRequestId = item.InboundRequestId,
                        QtyDeclined = item.QtyDeclined,
                        SSLineName = item.InboundRequest.Company.CompanyName,
                        DeclineStatus = item.DeclineStatus,
                        Notes = item.Notes,
                        CreatedAt = item.CreatedAt
                    }); ;
                }
            }
            return InboundReqDeclinedQtyList;
        }

        public List<InboundReqDeclinedQty> GetVWByInboundRequestId(int InboundRequestId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.InboundReqDeclinedQty.Where(i => i.InboundRequestId == InboundRequestId).ToList();
            }
        }
    }

    public interface IInboundReqDeclinedQtyRepository
    {
        bool AddOrUpdate(InboundReqDeclinedQty inboundReqDeclinedQty);

        bool Delete(int InboundReqDeclinedQtyId);

        List<VW_InboundReqDeclinedQty> GetVWById(int InboundReqDeclinedQtyId);

        InboundReqDeclinedQty GetById(int InboundReqDeclinedQtyId);

        //List<InboundReqDeclinedQty> GetByInboundRequestId(int InboundRequestId);

        List<VW_InboundReqDeclinedQty> GetVWByInboundRequestId(int InboundRequestId);
    }
}