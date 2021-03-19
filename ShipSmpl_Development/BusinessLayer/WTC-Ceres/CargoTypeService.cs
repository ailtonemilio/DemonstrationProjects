using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class CargoTypeService
    {
        private static ICargoTypeRepository repository;

        static CargoTypeService()
        {
            repository = new CargoTypeRepository();
        }

        public static List<CargoType> GetAll()
        {
            return repository.GetAll();
        }

        public static List<CargoType> GetAll(WTCCeresEntities db)
        {
            return repository.GetAll(db);
        }
    }
}