using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class InboundFollowUpRepository : IInboundFollowUpRepository
    {
        private InboundFollowUpRequest ifur = new InboundFollowUpRequest();

        public bool AddOrUpdate(InboundFollowUpRequest inboundFollowUpRequest)
        {
            bool isSaved = true;

            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    if (inboundFollowUpRequest.InboundFollowUpRequestId == 0)
                        db.InboundFollowUpRequest.Add(inboundFollowUpRequest);
                    else
                        db.InboundFollowUpRequest.AddOrUpdate(inboundFollowUpRequest);

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

        public bool Delete(int InboundFollowUpRequestId)
        {
            bool isSaved = true;

            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    ifur = db.InboundFollowUpRequest.Find(InboundFollowUpRequestId);

                    db.InboundFollowUpRequest.Remove(ifur);
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

        public List<VW_InboundFollowUpRequest> GetByFilter(string SSLineName)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var list = db.VW_InboundFollowUpRequest.Where(i => i.SSLineName.Contains(SSLineName));
                return list.ToList();
            }
        }

        public InboundFollowUpRequest GetByOpenInboundRequestId(int InbpundRequestId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    var list = db.InboundFollowUpRequest.Where(i => i.InboundRequestId == InbpundRequestId
                                                                    & i.isOpenFollowUp == true);
                    return list.ToList()[0];
                }
                catch
                {
                    return null;
                }
            }
        }
    }

    public interface IInboundFollowUpRepository
    {
        bool AddOrUpdate(InboundFollowUpRequest inboundFollowUpRequest);

        bool Delete(int InboundFollowUpRequestId);

        InboundFollowUpRequest GetByOpenInboundRequestId(int InbpundRequestId);

        List<VW_InboundFollowUpRequest> GetByFilter(string SSLineName);
    }
}