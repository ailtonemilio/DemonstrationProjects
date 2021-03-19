using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class UnitStatusService
    {
        private static IUnitStatusRepository repository;

        static UnitStatusService()
        {
            repository = new UnitStatusRepository();
        }

        public static List<UnitStatus> GetAll()
        {
            return repository.GetAll();
        }

        public static List<UnitStatus> GetAll(WTCCeresEntities db)
        {
            return repository.GetAll(db);
        }
    }
}