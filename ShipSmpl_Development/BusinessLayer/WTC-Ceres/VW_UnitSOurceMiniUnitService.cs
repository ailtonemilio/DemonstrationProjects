using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class VW_UnitSOurceMiniUnitService
    {
        private static VW_UnitSourceMiniUnitRepository repository;

        static VW_UnitSOurceMiniUnitService()
        {
            repository = new VW_UnitSourceMiniUnitRepository();
        }

        public static List<VW_UnitSourceMiniUnit> GetAll(bool isActive)
        {
            return repository.GetAll(isActive);
        }

        public static List<VW_UnitSourceMiniUnit> GetByFilter(string MiniUnitNumber)
        {
            return repository.GetByMiniUnitNumber(MiniUnitNumber);
        }

        public static List<VW_UnitSourceMiniUnit> GetByUnitSourceListById(List<int> UnitSourceIdList)
        {
            return repository.GetByUnitSourceListById(UnitSourceIdList);
        }

        public static List<VW_UnitSourceMiniUnit> GetByUnitSourceById(int UnitSourceId)
        {
            return repository.GetByUnitSourceById(UnitSourceId);
        }

        public static List<VW_UnitSourceMiniUnit> GetByFilter(string CustomerName, List<string> CargoType, string MiniUnitNumber)
        {
            return repository.GetByFilter(CustomerName, CargoType, MiniUnitNumber);
        }
    }
}