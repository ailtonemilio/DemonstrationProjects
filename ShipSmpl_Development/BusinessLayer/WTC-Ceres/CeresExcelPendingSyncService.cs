using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class CeresExcelPendingSyncService
    {
        private static ICeresExcelPendingSyncRepository repository;

        static CeresExcelPendingSyncService()
        {
            repository = new CeresExcelPendingSyncRepository();
        }

        public bool AddOrUpdate(CeresExcelPendingSync ceresExcelPendingSync)
        {
            return repository.AddOrUpdate(ceresExcelPendingSync);
        }

        public bool AddOrUpdate(CeresExcelPendingSync ceresExcelPendingSync, WTCCeresEntities db)
        {
            return repository.AddOrUpdate(ceresExcelPendingSync, db);
        }

        public bool Delete(int CeresExcelPendingSyncId)
        {
            return repository.Delete(CeresExcelPendingSyncId);
        }

        public static List<CeresExcelPendingSync> GetAll()
        {
            return repository.GetAll();
        }

        public static List<VW_CeresExcelPendingSyncBooking> GetAllVW()
        {
            return repository.GetAllVW();
        }
    }
}