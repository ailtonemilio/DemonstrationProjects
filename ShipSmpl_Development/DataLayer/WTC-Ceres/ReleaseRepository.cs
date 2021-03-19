using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class ReleaseRepository : IReleaseRepository
    {
        private Release r = new Release();

        public bool AddOrUpdate(Release release)
        {
            bool isSaved = true;

            try
            {
                using (WTCCeresEntities db = new WTCCeresEntities())
                {
                    r = release;

                    if (r.ReleaseId == 0)
                        db.Release.Add(r);
                    else
                        db.Release.AddOrUpdate(r);

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

        public bool Delete(int ReleaseId)
        {
            bool isSaved = true;

            try
            {
                using (WTCCeresEntities db = new WTCCeresEntities())
                {
                    r = db.Release.Find(ReleaseId);

                    db.Release.Remove(r);
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

        public List<VW_Release> GetAllVWByInboundReqId(int InboundRequestId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_Release.Where(r => r.InboundRequestId == InboundRequestId).ToList();
            }
        }

        public int GetLastReleaseId()
        {
            return r.ReleaseId;
        }

        public VW_Release GetVWByReleaseId(int ReleaseId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var list = db.VW_Release.Where(r => r.ReleaseId == ReleaseId).ToList();
                if (list.Count > 0)
                    return list[0];
                else
                    return null;
            }
        }

        public Release GetByReleaseId(int ReleaseId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.Release.Find(ReleaseId);
            }
        }
    }

    public interface IReleaseRepository
    {
        bool AddOrUpdate(Release release);

        bool Delete(int ReleaseId);

        int GetLastReleaseId();

        VW_Release GetVWByReleaseId(int ReleaseId);

        Release GetByReleaseId(int ReleaseId);

        List<VW_Release> GetAllVWByInboundReqId(int InboundRequestId);
    }
}