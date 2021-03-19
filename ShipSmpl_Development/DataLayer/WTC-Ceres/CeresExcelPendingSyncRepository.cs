using ModelLayer;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class CeresExcelPendingSyncRepository : ICeresExcelPendingSyncRepository
    {
        private bool isSaved = true;

        public bool AddOrUpdate(CeresExcelPendingSync ceresExcelPendingSync)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    db.CeresExcelPendingSync.AddOrUpdate(ceresExcelPendingSync);
                    db.SaveChanges();
                }
                catch
                {
                    isSaved = false;
                }
            }

            return isSaved;
        }

        public bool AddOrUpdate(CeresExcelPendingSync ceresExcelPendingSync, WTCCeresEntities db)
        {
            try
            {
                db.CeresExcelPendingSync.AddOrUpdate(ceresExcelPendingSync);
                db.SaveChanges();
            }
            catch
            {
                isSaved = false;
            }

            return isSaved;
        }

        public bool Delete(int CeresExcelPendingSyncId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    var c = db.CeresExcelPendingSync.Find(CeresExcelPendingSyncId);
                    db.CeresExcelPendingSync.Remove(c);
                    db.SaveChanges();
                }
                catch
                {
                    isSaved = false;
                }
            }

            return isSaved;
        }

        public List<CeresExcelPendingSync> GetAll()
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.CeresExcelPendingSync.OrderBy(c => c.CreatedAt).ToList();
            }
        }

        public List<VW_CeresExcelPendingSyncBooking> GetAllVW()
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_CeresExcelPendingSyncBooking.OrderBy(c => c.CreatedAt).ToList();
            }
        }
    }

    public interface ICeresExcelPendingSyncRepository
    {
        bool AddOrUpdate(CeresExcelPendingSync ceresExcelPendingSync);

        bool AddOrUpdate(CeresExcelPendingSync ceresExcelPendingSync, WTCCeresEntities db);

        bool Delete(int CeresExcelPendingSyncId);

        List<CeresExcelPendingSync> GetAll();

        List<VW_CeresExcelPendingSyncBooking> GetAllVW();
    }
}