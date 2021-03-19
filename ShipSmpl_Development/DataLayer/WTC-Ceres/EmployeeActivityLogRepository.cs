using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class EmployeeActivityLogRepository : IEmployeeActivityLogRepository
    {
        private EmployeeActivityLog eal = new EmployeeActivityLog();

        public List<EmployeeActivityLog> GetAll()
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.EmployeeActivityLog.ToList();
            }
        }

        public bool Insert(int EmployeeId, string RecordModified, string ActionTaken, string ModuleName, string Detail)
        {
            bool isSaved = true;
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    eal.EmployeeId = EmployeeId;
                    eal.RecordModified = RecordModified;
                    eal.ActionTaken = ActionTaken;
                    eal.ModuleName = ModuleName;
                    eal.Detail = Detail;
                    eal.CreatedAt = DateTime.Now;
                    db.EmployeeActivityLog.Add(eal);
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

        public bool Insert(int EmployeeId, string RecordModified, string ActionTaken, string ModuleName, string Detail, WTCCeresEntities db)
        {
            bool isSaved = true;
            try
            {
                eal.EmployeeId = EmployeeId;
                eal.RecordModified = RecordModified;
                eal.ActionTaken = ActionTaken;
                eal.ModuleName = ModuleName;
                eal.Detail = Detail;
                eal.CreatedAt = DateTime.Now;
                db.EmployeeActivityLog.Add(eal);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                isSaved = false;
            }
            return isSaved;
        }
    }

    public interface IEmployeeActivityLogRepository
    {
        List<EmployeeActivityLog> GetAll();

        bool Insert(int EmployeeId, string RecordModified, string ActionTaken, string ModuleName, string Detail);

        bool Insert(int EmployeeId, string RecordModified, string ActionTaken, string ModuleName, string Detail, WTCCeresEntities db);
    }
}