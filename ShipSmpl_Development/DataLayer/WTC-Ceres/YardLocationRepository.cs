using ModelLayer;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class YardLocationRepository : IYardLocationRepository
    {
        public List<YardLocation> GetAll()
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.YardLocation.OrderBy(y => y.YardName).ToList();
            }
        }
    }

    public interface IYardLocationRepository
    {
        List<YardLocation> GetAll();
    }
}