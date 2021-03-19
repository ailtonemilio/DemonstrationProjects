using ModelLayer;
using ModelLayer.CustomModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer
{
    public class RelDistChangeSchRequestedRepository : IRelDistChangeSchRequestedRepository
    {
        public bool AddOrUpdate(RelDistChangeReqSchedule relDistChangeReqSchedule)
        {
            bool isSaved = true;
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    db.RelDistChangeReqSchedule.AddOrUpdate(relDistChangeReqSchedule);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    isSaved = false;
                }
            }
            return isSaved;
        }

        public RelDistChangeReqSchedule GetById(int RelDistChangeReqScheduleId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.RelDistChangeReqSchedule.Find(RelDistChangeReqScheduleId);
            }
        }

        public List<VW_RelDistChangeSchRequested> GetByRelDistRequestId(int ReleaseDistributionRequestId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var list = new List<VW_RelDistChangeSchRequested>();

                var l = (from origReq in db.RelDistRequestSchedule
                         join reqChang in db.RelDistChangeReqSchedule on origReq.RelDistRequestScheduleId equals reqChang.RelDistRequestScheduleId
                         join relDistReq in db.ReleaseDistributionRequest on origReq.ReleaseDistributionRequestId equals relDistReq.ReleaseDistributionRequestId
                         where relDistReq.ReleaseDistributionRequestId == ReleaseDistributionRequestId
                         select new
                         {
                             RelDistRequestScheduleId = origReq.RelDistRequestScheduleId,
                             OrigFromDate = origReq.FromDate,
                             OrigToDate = origReq.ToDate,
                             OrigQtyRequested = origReq.QtyRequested,

                             RelDistChangeReqScheduleId = reqChang.RelDistChangeReqScheduleId,
                             FromDateChange = reqChang.FromDate,
                             ToDateChange = reqChang.ToDate,
                             QtyRequestdChange = reqChang.QtyProposed,
                             CarrierMessage = reqChang.CarrierMessage,
                             isRead = reqChang.isRead,
                             ChangeReqStatusId = reqChang.RequestStatusId,
                             ChangeReqStatus = reqChang.RequestStatus.StatusName,
                             WTCMessage = reqChang.WTCNote
                         });

                foreach (var item in l)
                    list.Add(new VW_RelDistChangeSchRequested()
                    {
                        RelDistRequestScheduleId = item.RelDistRequestScheduleId,
                        OrigFromDate = item.OrigFromDate,
                        OrigToDate = item.OrigToDate,
                        OrigQtyRequested = item.OrigQtyRequested,

                        RelDistChangeReqScheduleId = item.RelDistChangeReqScheduleId,
                        FromDateChange = item.FromDateChange,
                        ToDateChange = item.ToDateChange,
                        QtyRequestdChange = item.QtyRequestdChange,
                        CarrierMessage = item.CarrierMessage,
                        isRead = item.isRead,
                        ChangeReqStatusId = item.ChangeReqStatusId,
                        ChangeReqStatus = item.ChangeReqStatus,
                        WTCMessage = item.WTCMessage
                    });

                return list.ToList();
            }
        }
    }

    public interface IRelDistChangeSchRequestedRepository
    {
        List<VW_RelDistChangeSchRequested> GetByRelDistRequestId(int ReleaseDistributionRequestId);

        RelDistChangeReqSchedule GetById(int RelDistChangeReqScheduleId);

        bool AddOrUpdate(RelDistChangeReqSchedule relDistChangeReqSchedule);
    }
}