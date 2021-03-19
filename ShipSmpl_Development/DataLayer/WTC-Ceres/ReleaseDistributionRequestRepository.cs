using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class ReleaseDistributionRequestRepository : IReleaseDistributionRepository
    {
        private ReleaseDistributionRequest rdr = new ReleaseDistributionRequest();

        public bool AddOrUpdate(ReleaseDistributionRequest releaseDistributionRequest)
        {
            bool isSaved = true;

            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                if (releaseDistributionRequest.ReleaseDistributionRequestId == 0)
                    db.ReleaseDistributionRequest.Add(releaseDistributionRequest);
                else
                    db.ReleaseDistributionRequest.AddOrUpdate(releaseDistributionRequest);
                db.SaveChanges();
                return isSaved;
            }
        }

        public bool Delete(int ReleaseDistributionRequestId)
        {
            bool isSaved = true;
            try
            {
                using (WTCCeresEntities db = new WTCCeresEntities())
                {
                    rdr = db.ReleaseDistributionRequest.Find(ReleaseDistributionRequestId);
                    db.ReleaseDistributionRequest.Remove(rdr);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                isSaved = false;
            }
            return isSaved;
        }

        public List<VW_ReleaseDistributionRequest> GetByFilter(string ReleaseNumber, string TerminalName, string CarrierCode,
            string YardName)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var list = db.VW_ReleaseDistributionRequest.Where(r => r.ReleaseNumber.Contains(ReleaseNumber)
                                                                   && r.PickUpTerminalName.Contains(TerminalName)
                                                                   && r.CarrierCode.Contains(CarrierCode)
                                                                   && r.YardName.Contains(YardName));
                return list.ToList();
            }
        }

        public ReleaseDistributionRequest GetById(int ReleaseDistributionRequestId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                rdr = db.ReleaseDistributionRequest.Find(ReleaseDistributionRequestId);
                return rdr;
            }
        }

        public List<VW_ReleaseDistributionRequest> GetByRelPUDOId(int RelPUDOId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var list = db.VW_ReleaseDistributionRequest.Where(r => r.RelOrderPickUpDropOffLocationId == RelPUDOId);
                return list.ToList();
            }
        }

        public List<VW_ReleaseDistributionRequest> GetAllByCompleteStatus(bool openDistributions)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                if (openDistributions == true)
                {
                    var list = db.VW_ReleaseDistributionRequest.Where(r => r.QtyRequested != r.TotalAcceptedOfRequest);
                    return list.ToList();
                }
                else
                {
                    var list = db.VW_ReleaseDistributionRequest.Where(r => r.QtyRequested == r.TotalAcceptedOfRequest);
                    return list.ToList();
                }
            }
        }

        public int GetLastReleaseDistributionRequestId()
        {
            return rdr.ReleaseDistributionRequestId;
        }
    }

    public interface IReleaseDistributionRepository
    {
        bool AddOrUpdate(ReleaseDistributionRequest releaseDistributionRequest);

        bool Delete(int ReleaseDistributionRequestId);

        int GetLastReleaseDistributionRequestId();

        ReleaseDistributionRequest GetById(int ReleaseDistributionRequestId);

        List<VW_ReleaseDistributionRequest> GetByFilter(string ReleaseNumber, string TerminalName, string CarrierCode,
                                                        string YardName);

        List<VW_ReleaseDistributionRequest> GetByRelPUDOId(int RelPUDOId);

        List<VW_ReleaseDistributionRequest> GetAllByCompleteStatus(bool ActiveStatus);
    }
}