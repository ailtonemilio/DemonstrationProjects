using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class MiniUnitService
    {
        private static IMiniUnitRepository repository;

        static MiniUnitService()
        {
            repository = new MiniUnitRepository();
        }

        public static List<VW_UnitSourceMiniUnit> GetAll(List<string> ExceptUnitStatuses)
        {
            return repository.GetAll(ExceptUnitStatuses);
        }

        public static List<VW_UnitSourceMiniUnit> GetAll(List<string> ExceptUnitStatuses, WTCCeresEntities db)
        {
            return repository.GetAll(ExceptUnitStatuses, db);
        }

        public static MiniUnit GetById(int MiniUnitId)
        {
            return repository.GetById(MiniUnitId);
        }

        public bool InsertOrUpdateList(List<MiniUnit> MUList)
        {
            return repository.InsertOrUpdateList(MUList);
        }

        public bool InsertOrUpdate(MiniUnit MURecord)
        {
            return repository.InsertOrUpdate(MURecord);
        }

        public bool Delete(int MiniUnitId)
        {
            return repository.Delete(MiniUnitId);
        }

        public static List<MiniUnit> GetAllByUSId(int UnitSourceId)
        {
            return repository.GetByUSId(UnitSourceId);
        }

        public static List<VW_UnitSourceMiniUnit> GetUsMuVwByUSId(int UnitSourceId)
        {
            return repository.GetUsMuVwByUSId(UnitSourceId);
        }

        public bool UpdateBalanceAllowedStorage(int MiniUnitId, bool BalanceToStorageAllowed)
        {
            return repository.UpdateBalanceAllowedStorage(MiniUnitId, BalanceToStorageAllowed);
        }

        public static VW_UnitSourceMiniUnit GetVWByMUId(int MiniUnitId)
        {
            return repository.GetVWByMUId(MiniUnitId);
        }
    }
}