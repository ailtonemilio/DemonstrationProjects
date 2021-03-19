using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class InboundRequestRepository : IInboundRequestRepository
    {
        private InboundRequest ir = new InboundRequest();

        public bool Delete(int InboundRequestId)
        {
            bool isSaved = true;
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    ir = db.InboundRequest.Find(InboundRequestId);
                    db.InboundRequest.Remove(ir);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    string msg = ex.Message;
                    isSaved = false;
                }
            }
            return isSaved;
        }

        public List<VW_InboundRequest> GetByFilter(string SSLineCode, string StatusName, string ReleaseType, bool isOpenRequest)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var list = db.VW_InboundRequest.Where(ir => ir.SSLineCode.Contains(SSLineCode)
                                                        && ir.StatusName.Contains(StatusName)
                                                        && ir.ReleaseType.Contains(ReleaseType)
                                                        && ir.IsOpenRequest == isOpenRequest);
                return list.ToList();
            }
        }

        public InboundRequest GetById(int InboundRequestId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.InboundRequest.Find(InboundRequestId);
            }
        }

        public VW_InboundRequest GetVWById(int InboundRequestId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_InboundRequest.Where(ir => ir.InboundRequestId == InboundRequestId).ToList()[0];
            }
        }

        public List<VW_InboundRequest> GetByOpenStatus(bool isOpenRequest)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_InboundRequest.Where(ir => ir.IsOpenRequest == isOpenRequest).ToList();
            }
        }

        public int GetLastInboundRequestId()
        {
            return ir.InboundRequestId;
        }

        public bool AddOrUpdate(InboundRequest inboundRequest)
        {
            bool isSaved = true;
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    if (inboundRequest.InboundRequestId == 0)
                    {
                        db.InboundRequest.Add(inboundRequest);
                    }
                    else
                    {
                        db.InboundRequest.AddOrUpdate(inboundRequest);
                    }

                    db.SaveChanges();
                    ir = inboundRequest;
                }
                catch (Exception ex)
                {
                    string msg = ex.Message;
                    isSaved = false;
                }
            }
            return isSaved;
        }

        public List<VW_InboundReport> GetInboundReport(bool isopen)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                if (isopen == true)
                    return db.VW_InboundReport.Where(r => r.DlvStatus != "COMPLETED").ToList();
                else
                    return db.VW_InboundReport.Where(r => r.DlvStatus == "COMPLETED").ToList();
            }
        }
    }

    public interface IInboundRequestRepository
    {
        bool AddOrUpdate(InboundRequest inboundRequest);

        bool Delete(int InboundRequestId);

        int GetLastInboundRequestId();

        InboundRequest GetById(int InboundRequestId);

        VW_InboundRequest GetVWById(int InboundRequestId);

        List<VW_InboundReport> GetInboundReport(bool isComplete);

        List<VW_InboundRequest> GetByFilter(string SSLineCode, string StatusName, string ReleaseType, bool isOpenRequest);

        List<VW_InboundRequest> GetByOpenStatus(bool isOpenRequest);
    }
}