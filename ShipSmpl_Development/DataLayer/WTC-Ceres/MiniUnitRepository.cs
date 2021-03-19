using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class MiniUnitRepository : IMiniUnitRepository
    {
        private MiniUnit mu = new MiniUnit();

        public bool Delete(int MiniUnitId)
        {
            bool isDeleted = true;
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    mu = db.MiniUnit.Find(MiniUnitId);
                    db.MiniUnit.Remove(mu);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    string message = e.Message;
                    isDeleted = false;
                }
            }
            return isDeleted;
        }

        public List<VW_UnitSourceMiniUnit> GetAll(List<string> ExceptUnitStatuses)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_UnitSourceMiniUnit.Where(mu => ExceptUnitStatuses.Contains(mu.UnitStatus)).ToList();
            }
        }

        public List<VW_UnitSourceMiniUnit> GetAll(List<string> ExceptUnitStatuses, WTCCeresEntities db)
        {
            return db.VW_UnitSourceMiniUnit.Where(mu => ExceptUnitStatuses.Contains(mu.UnitStatus)).ToList();
        }

        public MiniUnit GetById(int MiniUnitId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.MiniUnit.Find(MiniUnitId);
            }
        }

        public List<MiniUnit> GetByUSId(int UnitSourceId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var listById = db.MiniUnit.Where(mu => mu.UnitSourceId == UnitSourceId);

                return listById.ToList();
            }
        }

        public List<VW_UnitSourceMiniUnit> GetUsMuVwByUSId(int UnitSourceId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var listById = db.VW_UnitSourceMiniUnit.Where(mu => mu.UnitSourceId == UnitSourceId);

                return listById.ToList();
            }
        }

        public VW_UnitSourceMiniUnit GetVWByMUId(int MiniUnitId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_UnitSourceMiniUnit.Where(mu => mu.MiniUnitId == MiniUnitId).ToList()[0];
            }
        }

        public bool InsertOrUpdate(MiniUnit MURecord)
        {
            bool isSaved = true;
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    if (MURecord.MiniUnitId == 0)
                    {
                        db.MiniUnit.Add(MURecord);
                    }
                    else
                    {
                        db.MiniUnit.AddOrUpdate(MURecord);
                    }
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    string message = ex.Message;
                    isSaved = false;
                }
            }
            return isSaved;
        }

        public bool InsertOrUpdateList(List<MiniUnit> MUList)
        {
            bool isSaved = true;
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    foreach (MiniUnit MURecord in MUList)
                    {
                        if (MURecord.MiniUnitId == 0)
                        {
                            db.MiniUnit.Add(MURecord);
                        }
                        else
                        {
                            db.MiniUnit.AddOrUpdate(MURecord);
                        }
                    }
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    string message = ex.Message;
                    isSaved = false;
                }
            }
            return isSaved;
        }

        public bool UpdateBalanceAllowedStorage(int MiniUnitId, bool BalanceToStorageAllowed)
        {
            bool isSaved = true;
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    mu = db.MiniUnit.Find(MiniUnitId);
                    mu.BalanceToStorageAllowed = BalanceToStorageAllowed;
                    db.MiniUnit.AddOrUpdate(mu);

                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    string message = ex.Message;
                    isSaved = false;
                }
            }
            return isSaved;
        }
    }

    public interface IMiniUnitRepository
    {
        List<VW_UnitSourceMiniUnit> GetAll(List<string> ExceptUnitStatuses);

        List<VW_UnitSourceMiniUnit> GetAll(List<string> ExceptUnitStatuses, WTCCeresEntities db);

        MiniUnit GetById(int MiniUnitId);

        List<MiniUnit> GetByUSId(int UnitSourceId);

        VW_UnitSourceMiniUnit GetVWByMUId(int MiniUnitId);

        List<VW_UnitSourceMiniUnit> GetUsMuVwByUSId(int UnitSourceId);

        bool InsertOrUpdateList(List<MiniUnit> MUList);

        bool InsertOrUpdate(MiniUnit MURecord);

        bool UpdateBalanceAllowedStorage(int MiniUnitId, bool BalanceToStorageAllowed);

        bool Delete(int MiniUnitId);
    }
}