using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class ReleaseService
    {
        private static IReleaseRepository repository;

        static ReleaseService()
        {
            repository = new ReleaseRepository();
        }

        public bool AddOrUpdate(Release release)
        {
            return repository.AddOrUpdate(release);
        }

        public bool Delete(int ReleaseId)
        {
            return repository.Delete(ReleaseId);
        }

        public int GetLastReleaseId()
        {
            return repository.GetLastReleaseId();
        }

        public static List<VW_Release> GetAllVWByInboundReqId(int InboundRequestId)
        {
            return repository.GetAllVWByInboundReqId(InboundRequestId);
        }

        public static VW_Release GetVWByReleaseId(int ReleaseId)
        {
            return repository.GetVWByReleaseId(ReleaseId);
        }

        public static Release GetByReleaseId(int ReleaseId)
        {
            return repository.GetByReleaseId(ReleaseId);
        }
    }
}