using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class EmployeeActivityLogService
    {
        private static IEmployeeActivityLogRepository repository;

        static EmployeeActivityLogService()
        {
            repository = new EmployeeActivityLogRepository();
        }

        public static List<EmployeeActivityLog> GetAll()
        {
            return repository.GetAll();
        }

        public static bool Insert(int EmployeeId, string RecordModified, string ActionTaken, string ModuleName, string Detail, WTCCeresEntities db)
        {
            return repository.Insert(EmployeeId, RecordModified, ActionTaken, ModuleName, Detail, db);
        }

        public static bool Insert(int EmployeeId, string RecordModified, string ActionTaken, string ModuleName, string Detail)
        {
            return repository.Insert(EmployeeId, RecordModified, ActionTaken, ModuleName, Detail);
        }
    }
}