using ModelLayer;
using ModelLayer.CustomModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class Containers_In_OutRepository : IContainers_In_OutRepository
    {
        private WTCCeresEntities db = new WTCCeresEntities();
        private Containers_In_Out cio = new Containers_In_Out();
        private VW_ContainersInOutDrayage vw_cio = new VW_ContainersInOutDrayage();
        private ContainerMinibooking cm = new ContainerMinibooking();

        public List<Containers_In_Out> GetAll()
        {
            return db.Containers_In_Out.ToList();
        }

        public Containers_In_Out GetByContainerNumber(string ContainerNumber)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.Containers_In_Out.Where(c => c.Container_Number == ContainerNumber &&
                                                    (c.Container_Rejected == null ||
                                                    c.Container_Rejected == false)).ToList()[0];
            }
        }

        public List<Containers_In_Out> GetById(int Id)
        {
            using (WTCCeresEntities dba = new WTCCeresEntities())
            {
                var list = dba.Containers_In_Out.Where(p => p.Unique_ID == Id).ToList();
                return list;
            }
        }

        public List<VW_ContainersByBooking> GetByIds(List<int> IdList)
        {
            var list = from cans in db.VW_ContainersByBooking
                       where IdList.Contains(cans.Unique_ID)
                       select cans;
            return list.ToList();
        }

        public List<Containers_In_Out> GetByInOutGateByDateRange(DateTime startDate, DateTime endDate, bool DateIn, bool DateOut)
        {
            var listDoc = new List<Containers_In_Out>();

            if (DateIn && DateOut)
            {
                var list = db.Containers_In_Out.Where((p => (p.Gate_Date_In >= startDate && p.Gate_Date_In <= endDate) || (p.Gate_Date_Out >= startDate && p.Gate_Date_Out <= endDate))).ToList();
                listDoc = list;
            }
            else
            {
                if (DateIn)
                {
                    var list = db.Containers_In_Out.Where(p => p.Gate_Date_In >= startDate && p.Gate_Date_In <= endDate).ToList();
                    listDoc = list;
                }
                else
                {
                    var list = db.Containers_In_Out.Where(p => p.Gate_Date_Out >= startDate && p.Gate_Date_Out <= endDate).ToList();
                    listDoc = list;
                }
            }

            return listDoc.ToList();
        }

        public List<Containers_In_OutReport> GetByInOutGateReportByDateRange(DateTime startDate, DateTime endDate)
        {
            string G_Date_In = "";
            string EDIDate = "";
            string CalcG_Date_In = "";
            string CalcEDIDate = "";
            string GateType = "";
            string AVGDate = "";

            int Year = 0;
            int Month = 0;
            int Day = 0;
            int Hour = 0;
            int Minute = 0;
            int Second = 0;
            int TotSecond = 0;

            var listContainers_In_OutReport = new List<Containers_In_OutReport>();
            var listInOrder = new List<Containers_In_OutReport>();

            var list = (from c in db.VW_EDIPerformanceAudit
                        where c.EDIDate != null
                                && c.GateDate >= startDate && c.GateDate <= endDate
                        select new
                        {
                            Booking_Number = c.BookingNumber.TrimEnd(),
                            SS_Line_Code_In = c.SSLineCode.TrimEnd(),
                            SS_Line_Name_In = c.SSLineName.TrimEnd(),
                            Container_Number = c.ContainerNumber.TrimEnd(),
                            Gate_Date_In = c.GateDate,
                            Gate_EDI_Date = c.EDIDate,
                            Gate_Type = c.GateMode,
                            RequestDate = c.RequestDate,
                            InputSource = c.Input_Source,
                        }).ToList();

            foreach (var item in list)
            {
                G_Date_In = string.Format("{0:dd-MM-yyyy HH:mm:ss}", item.Gate_Date_In);
                CalcG_Date_In = string.Format("{0:dd-MM-yyyy HH:mm:ss}", item.Gate_Date_In);

                EDIDate = string.Format("{0:dd-MM-yyyy HH:mm:ss}", item.Gate_EDI_Date);
                CalcEDIDate = string.Format("{0:dd-MM-yyyy HH:mm:ss}", item.Gate_EDI_Date);

                if (item.Gate_Type == "IN-GATE")
                {
                    GateType = "IN";
                }
                else
                {
                    GateType = "OUT";
                }

                if (!String.IsNullOrEmpty(CalcG_Date_In) && !String.IsNullOrEmpty(CalcEDIDate))
                {
                    string[] d = CalcG_Date_In.Split(' ');
                    string[] d1 = d[0].Split('-');
                    string[] d2 = d[1].Split(':');

                    Day = Convert.ToInt32(d1[0]);
                    Month = Convert.ToInt32(d1[1]);
                    Year = Convert.ToInt32(d1[2]);

                    Hour = Convert.ToInt32(d2[0]);
                    Minute = Convert.ToInt32(d2[1]);
                    Second = Convert.ToInt32(d2[2]);

                    var dt1 = new DateTime(Year, Month, Day, Hour, Minute, Second);

                    string[] t = CalcEDIDate.Split(' ');
                    string[] t1 = t[0].Split('-');
                    string[] t2 = t[1].Split(':');

                    Day = Convert.ToInt32(t1[0]);
                    Month = Convert.ToInt32(t1[1]);
                    Year = Convert.ToInt32(t1[2]);

                    Hour = Convert.ToInt32(t2[0]);
                    Minute = Convert.ToInt32(t2[1]);
                    Second = Convert.ToInt32(t2[2]);

                    var dt2 = new DateTime(Year, Month, Day, Hour, Minute, Second);

                    TimeSpan ts = dt2 - dt1;

                    if (ts.Days > 0)
                    {
                        Hour = Convert.ToInt32((ts.Days * 60) + ts.Hours);
                    }
                    else
                    {
                        Hour = Convert.ToInt32(ts.Hours);
                    }

                    Minute = Convert.ToInt32(ts.Minutes);
                    Second = Convert.ToInt32(ts.Seconds);

                    AVGDate = Hour.ToString() + "h " + Minute.ToString() + "m " + Second.ToString() + "s";
                    TotSecond = (Hour * 3600) + (Minute * 60) + Second;
                }
                else
                {
                    AVGDate = "0h 0m 0s";
                    Hour = 0;
                    Minute = 0;
                    Second = 0;
                    TotSecond = 0;
                }

                listContainers_In_OutReport.Add(new Containers_In_OutReport
                {
                    Booking_Number = item.Booking_Number,
                    SS_Line_Code_In = item.SS_Line_Code_In,
                    SS_Line_Name_In = item.SS_Line_Name_In,
                    Container_Number = item.Container_Number,
                    Gate_Date_In = G_Date_In,
                    Gate_EDI_Date = EDIDate,
                    Gate_Type = GateType,
                    RequestDate = string.Format("{0:dd-MM-yyyy HH:mm:ss}", item.RequestDate),
                    InputSource = item.InputSource,
                    AVG_Delay = AVGDate,
                    EDIHour = Hour,
                    EDIMinute = Minute,
                    EDISecond = Second,
                    EDITotSecond = TotSecond
                }); ;
            }

            return listContainers_In_OutReport.OrderBy(c => c.EDITotSecond).ToList();
        }

        //public List<VW_ContainersByBooking> GetByMBIds(int Id)
        //{
        //    var list = db.VW_ContainersByBooking.Where(c => c.MiniBookingId == Id);
        //    return list.ToList();
        //}

        public List<VW_ContainersByBooking> GetContainersByBookingAndStatus(bool OutGateStatus, string BookingNumber)
        {
            if (OutGateStatus == false)
            {
                return db.VW_ContainersByBooking.Where(c => (c.Container_Out_Gated == OutGateStatus || c.Container_Out_Gated == null)
           && c.MinibookingNumber == BookingNumber).ToList();
            }
            else
            {
                return db.VW_ContainersByBooking.Where(c => (c.Container_Out_Gated == OutGateStatus)
          && c.BookingNumber == BookingNumber).ToList();
            }
        }

        public List<VW_ContainersByBooking> GetContainersByBookingNumber(string BookingNumber)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_ContainersByBooking.Where(c => c.BookingNumber == BookingNumber).ToList();
            }
        }

        public List<VW_ContainersByBooking> GetContainersByBookingNumber(string BookingNumber, WTCCeresEntities db)
        {
            return db.VW_ContainersByBooking.Where(c => c.BookingNumber == BookingNumber).ToList();
        }

        public List<VW_ContainersByBooking> GetContainersByMiniBookingId(int MiniBookingId)
        {
            return db.VW_ContainersByBooking.Where(c => c.MiniBookingId == MiniBookingId).
                OrderBy(c => c.AssignedAt).OrderBy(c => c.Gate_Date_In).ToList();
        }

        public bool UnassignContainerFromMinibooking(int ContainerInOutId, int MinibookingId, bool isBookingChange)
        {
            bool isSaved = true;
            try
            {
                var canToRemove = db.Containers_In_Out.Find(ContainerInOutId);
                try
                {
                    var can = db.ContainerMinibooking.Where(c => c.ContainerInOutId == ContainerInOutId && c.MinibookingId == MinibookingId).ToList()[0];
                    db.ContainerMinibooking.Remove(can);
                }
                catch (Exception ex)
                {
                }
                canToRemove.Booking_Number = null;
                canToRemove.Excel_Booking_Number = null;
                canToRemove.In_Gate_To_Excel = null;
                canToRemove.Assigned_To_Excel = null;
                canToRemove.Assigned_To_Extra = null;
                canToRemove.Assigned_To_Storage = null;
                canToRemove.MiniBookingId = null;

                if (isBookingChange)
                {
                    canToRemove.Carrier_Code_Out = null;
                    canToRemove.Carrier_Name_Out = null;
                    canToRemove.Seal_Number = null;
                    canToRemove.CargoWeight = null;
                    canToRemove.Cargo_Weight_Out = null;
                    canToRemove.Gate_Date_Out = null;
                }
                db.Containers_In_Out.AddOrUpdate(canToRemove);
                db.SaveChanges();
            }
            catch
            {
                isSaved = false;
            }
            return isSaved;
        }
    }

    public interface IContainers_In_OutRepository
    {
        List<Containers_In_Out> GetAll();

        List<Containers_In_Out> GetById(int Id);

        List<VW_ContainersByBooking> GetByIds(List<int> IdList);

        Containers_In_Out GetByContainerNumber(String ContainerNumber);

        //ist<VW_ContainersByBooking> GetByMBId(int Id);

        Boolean UnassignContainerFromMinibooking(int ContainerInOutId, int MinibookingId, bool isBookingChange);

        List<VW_ContainersByBooking> GetContainersByMiniBookingId(int MinibookingId);

        List<VW_ContainersByBooking> GetContainersByBookingAndStatus(bool OutGateStatus, string BookingNumber);

        List<VW_ContainersByBooking> GetContainersByBookingNumber(string BookingNumber);

        List<VW_ContainersByBooking> GetContainersByBookingNumber(string BookingNumber, WTCCeresEntities db);

        List<Containers_In_Out> GetByInOutGateByDateRange(DateTime startDate, DateTime endDate, bool DateIn, bool DateOut);

        List<Containers_In_OutReport> GetByInOutGateReportByDateRange(DateTime startDate, DateTime endDate);
    }
}