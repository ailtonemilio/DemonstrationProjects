using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class ReleaseDistributionRequestService
    {
        private static IReleaseDistributionRepository repository;

        static ReleaseDistributionRequestService()
        {
            repository = new ReleaseDistributionRequestRepository();
        }

        public bool AddOrUpdate(ReleaseDistributionRequest releaseDistributionRequest)
        {
            return repository.AddOrUpdate(releaseDistributionRequest);
        }

        public bool Delete(int ReleaseDistributionRequestId)
        {
            return repository.Delete(ReleaseDistributionRequestId);
        }

        public List<VW_ReleaseDistributionRequest> GetByFilter(string ReleaseNumber, string TerminalName, string CarrierCode,
                                                        string YardName)
        {
            return repository.GetByFilter(ReleaseNumber, TerminalName, CarrierCode, YardName);
        }

        public static List<VW_ReleaseDistributionRequest> GetByReleaseStatus(bool openDistributions)
        {
            return repository.GetAllByCompleteStatus(openDistributions);
        }

        public static ReleaseDistributionRequest GetById(int ReleaseDistributionRequestId)
        {
            return repository.GetById(ReleaseDistributionRequestId);
        }

        public static List<VW_ReleaseDistributionRequest> GetByRelPUDOId(int RelPUDOId)
        {
            return repository.GetByRelPUDOId(RelPUDOId);
        }
    }
}