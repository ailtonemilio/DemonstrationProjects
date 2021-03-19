using ModelLayer;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class RequestStatusRepository : IRequestStatusRepository
    {
        public List<RequestStatus> GetByFlowType(string FlowType)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.RequestStatus.Where(rs => rs.FlowType == FlowType).ToList();
            }
        }
    }

    public interface IRequestStatusRepository
    {
        List<RequestStatus> GetByFlowType(string FlowType);
    }
}