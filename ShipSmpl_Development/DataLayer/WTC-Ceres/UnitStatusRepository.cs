using ModelLayer;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class UnitStatusRepository : IUnitStatusRepository
    {
        public List<UnitStatus> GetAll()
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.UnitStatus.OrderBy(us => us.StatusName).ToList();
            }
        }

        public List<UnitStatus> GetAll(WTCCeresEntities db)
        {
            return db.UnitStatus.OrderBy(us => us.StatusName).ToList();
        }
    }

    public interface IUnitStatusRepository
    {
        List<UnitStatus> GetAll();

        List<UnitStatus> GetAll(WTCCeresEntities db);
    }
}