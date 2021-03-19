using DataLayer.WTC_Ceres;
using ModelLayer;
using System;
using System.Collections.Generic;

namespace BusinessLayer.WTCOperations
{
    public class TimeSheetService
    {
        static ITimeSheetRepository repository;

        static TimeSheetService()
        {
            repository = new TimeSheetRepository();
        }
        public static List<TimeSheet> GetAll()
        {
            return repository.GetAll();
        }

        public static List<TimeSheet> GetById(int Id)
        {
            return repository.GetById(Id);
        }

        public static bool Insert(int EmployeeId, DateTime StatTimeDate, DateTime EndTimeDate, string PunchType, string DeviceName, string SiteLocation, string DeviceIPAddress)
        {
            return repository.Insert(EmployeeId, StatTimeDate, EndTimeDate, PunchType, DeviceName, SiteLocation, DeviceIPAddress);
        }

        public static bool Update(int Id, int EmployeeId, DateTime StatTimeDate, DateTime EndTimeDate, string PunchType, string DeviceName, string SiteLocation, string DeviceIPAddress)
        {
            return repository.Update(Id, EmployeeId, StatTimeDate, EndTimeDate, PunchType, DeviceName, SiteLocation, DeviceIPAddress);
        }

        public static bool Delete(int Id)
        {
            return repository.Delete(Id);
        }
    }

}
