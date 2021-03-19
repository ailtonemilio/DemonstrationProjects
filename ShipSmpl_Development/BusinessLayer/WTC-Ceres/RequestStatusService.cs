using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class RequestStatusService
    {
        private static IRequestStatusRepository repository;

        static RequestStatusService()
        {
            repository = new RequestStatusRepository();
        }

        public static List<RequestStatus> GetByFlowType(string FlowType)
        {
            return repository.GetByFlowType(FlowType);
        }
    }
}