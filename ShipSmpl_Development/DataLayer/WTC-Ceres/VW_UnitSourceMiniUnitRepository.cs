using ModelLayer;
using System.Collections.Generic;
using System.Linq;
using static DataLayer.WTC_Ceres.VW_UnitSourceMiniUnitRepository;

namespace DataLayer.WTC_Ceres
{
    public class VW_UnitSourceMiniUnitRepository : IVW_UnitSourceMiniUnitRepository
    {
        private VW_UnitSourceMiniUnit td = new VW_UnitSourceMiniUnit();

        public List<VW_UnitSourceMiniUnit> GetAll(bool isActive)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var list = db.VW_UnitSourceMiniUnit.Where(us => us.Active == isActive
                && us.CustomerId != null
                && us.ShipperId != null).OrderBy(us => us.UnitNumber).OrderBy(us => us.MiniUnitOrder);
                return list.ToList();
            }
        }

        public List<VW_UnitSourceMiniUnit> GetByFilter(string CustomerName, List<string> CargoType, string MiniUnitNumber)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_UnitSourceMiniUnit.Where(us => us.UnitStatus != "RELEASED"
                                                             && us.Active == true
                                                             && us.CustomerName == CustomerName
                                                             && CargoType.Contains(us.CargoTypeCode)
                                                              && us.MiniunitNumber.Contains(MiniUnitNumber)).OrderBy(us => us.MiniunitNumber).ToList();
            }
        }

        public List<VW_UnitSourceMiniUnit> GetByMiniUnitNumber(string MiniUnitNumber)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var list = db.VW_UnitSourceMiniUnit.Where(us => us.Active == true
                                                              && us.MiniunitNumber.Contains(MiniUnitNumber)).OrderBy(us => us.MiniunitNumber);
                return list.ToList();
            }
        }

        public List<VW_UnitSourceMiniUnit> GetByUnitSourceById(int UnitSourceId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_UnitSourceMiniUnit.Where(mu => mu.UnitSourceId == UnitSourceId).ToList();
            }
        }

        public List<VW_UnitSourceMiniUnit> GetByUnitSourceListById(List<int> UnitSourceIdList)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_UnitSourceMiniUnit.Where(mu => UnitSourceIdList.Contains(mu.UnitSourceId)).ToList();
            }
        }

        public interface IVW_UnitSourceMiniUnitRepository
        {
            List<VW_UnitSourceMiniUnit> GetAll(bool isActive);

            List<VW_UnitSourceMiniUnit> GetByMiniUnitNumber(string MiniUnitNumber);

            List<VW_UnitSourceMiniUnit> GetByFilter(string CustomerName, List<string> CargoType, string MiniUnitNumber);

            List<VW_UnitSourceMiniUnit> GetByUnitSourceListById(List<int> UnitSourceIdList);

            List<VW_UnitSourceMiniUnit> GetByUnitSourceById(int UnitSourceId);
        }
    }
}