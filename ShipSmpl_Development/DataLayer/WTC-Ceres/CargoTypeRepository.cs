using ModelLayer;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class CargoTypeRepository : ICargoTypeRepository
    {
        public List<CargoType> GetAll()
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.CargoType.OrderBy(ct => ct.CargoTypeName).ToList();
            }
        }

        public List<CargoType> GetAll(WTCCeresEntities db)
        {
            return db.CargoType.OrderBy(ct => ct.CargoTypeName).ToList();
        }
    }

    public interface ICargoTypeRepository
    {
        List<CargoType> GetAll();

        List<CargoType> GetAll(WTCCeresEntities db);
    }
}