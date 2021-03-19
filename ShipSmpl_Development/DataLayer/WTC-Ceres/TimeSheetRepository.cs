using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
namespace DataLayer.WTC_Ceres
{
    public class TimeSheetRepository : ITimeSheetRepository
    {
        private WTCCeresEntities db = new WTCCeresEntities();
        private TimeSheet ts = new TimeSheet();

        public bool Delete(int TimeSheetId)
        {
            bool isSaved = true;
            try
            {
                ts = db.TimeSheet.Find(TimeSheetId);
                db.TimeSheet.Remove(ts);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                isSaved = false;
            }

            return isSaved;
        }

        public List<TimeSheet> GetAll()
        {
            return db.TimeSheet.OrderByDescending(t => t.StartTimeDate).ToList();
        }

        public List<TimeSheet> GetById(int Id)
        {
            var listById = db.TimeSheet.Where(p => p.TimeSheetId == Id);
            return listById.ToList();
        }

        public bool Insert(int EmployeeId, DateTime StatTimeDate, DateTime EndTimeDate, string PunchType, string DeviceName, string SiteLocation, string DeviceIPAddress)
        {
            bool isSaved = true;
            try
            {
                var t = new TimeSheet();
                t.EmployeeId = EmployeeId;
                t.StartTimeDate = StatTimeDate;
                t.EndTimeDate = EndTimeDate;
                t.PunchType = PunchType;
                t.DeviceName = DeviceName;
                t.SiteLocation = SiteLocation;
                t.DeviceIPAddress = DeviceIPAddress;
                db.TimeSheet.AddOrUpdate(t);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                throw;
            }
            return isSaved;
        }

        public bool Update(int TimeSheetId, int EmployeeId, DateTime StatTimeDate, DateTime EndTimeDate, string PunchType, string DeviceName, string SiteLocation, string DeviceIPAddress)
        {
            bool isSaved = true;
            try
            {
                ts = db.TimeSheet.Find(TimeSheetId);
                ts.EmployeeId = EmployeeId;
                ts.StartTimeDate = StatTimeDate;
                ts.EndTimeDate = EndTimeDate;
                ts.PunchType = PunchType;
                ts.DeviceName = DeviceName;
                ts.SiteLocation = SiteLocation;
                ts.DeviceIPAddress = DeviceIPAddress;
                db.TimeSheet.AddOrUpdate(ts);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                throw;
            }
            return isSaved;
        }
    }

    public interface ITimeSheetRepository
    {
        List<TimeSheet> GetAll();

        List<TimeSheet> GetById(int Id);

        bool Update(int TimeSheetId, int EmployeeId, DateTime StatTimeDate, DateTime EndTimeDate, string PunchType, string DeviceName, string SiteLocation, string DeviceIPAddress);

        bool Insert(int EmployeeId, DateTime StatTimeDate, DateTime EndTimeDate, string PunchType, string DeviceName, string SiteLocation, string DeviceIPAddress);

        bool Delete(int TimeSheetId);
    }
}
