using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Dynamic;

namespace DataLayer.WTC_Ceres
{
    public class BookingRepository : IBookingRepository
    {
        private Booking b = new Booking();

        public bool AddOrUpdate(Booking booking, WTCCeresEntities db)
        {
            bool isSaved = true;

            b = booking;
            try
            {
                if (booking.BookingId == 0)
                {
                    db.Booking.Add(b);
                }
                else
                {
                    db.Booking.AddOrUpdate(b);
                }

                db.SaveChanges();
            }
            catch (Exception e)
            {
                string message = e.Message;
                isSaved = false;
            }

            return isSaved;
        }

        public bool Delete(Booking booking)
        {
            bool isSaved = true;
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    db.Booking.Remove(booking);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    string message = e.Message;
                    isSaved = false;
                }
            }
            return isSaved;
        }

        public List<VW_Booking> GetAllByActiveStatus(bool ActiveBooking)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_Booking.Where(b => b.ActiveBooking == ActiveBooking).OrderBy(b => b.BookingNumber).ToList();
            }
        }

        public List<VW_Booking> GetAllVW(bool ActiveBooking)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_Booking.Where(b => b.ActiveBooking == ActiveBooking).OrderBy(b => b.BookingNumber).ToList();
            }
        }

        public List<Booking> GetAll()
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.Booking.OrderBy(b => b.BookingNumber).ToList();
            }
        }

        public List<VW_Booking> GetAllVW()
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_Booking.OrderBy(b => b.BookingNumber).ToList();
            }
        }

        public List<VW_Booking> GetByFilter(List<VW_Booking> BookingList, string SortArgument, int SortType)
        {
            // var list = BookingList.OrderByDescending(b => b.BookingNumber);

            ////   return list.ToList();

            //var list = default(object);
            //switch (SortArgument ?? "")
            //{
            //    case "BookingNumber":
            //        {
            //            if (SortType == 0)
            //            {
            //                list = BookingList.OrderBy(b => b.BookingNumber);
            //            }
            //            else
            //            {
            //                list = BookingList.OrderByDescending(b => b.BookingNumber);
            //            }

            //            break;
            //        }

            //    case "BookingType":
            //        {
            //            if (SortType == 0)
            //            {
            //                list = BookingList.OrderBy(String.Format("BookingNumber@0", Request.Query));
            //            }
            //            else
            //            {
            //                list = BookingList.OrderByDescending(b => b.BookingType);
            //            }

            //            break;
            //        }

            //    case "CustomerName":
            //        {
            //            if (SortType == 0)
            //            {
            //                list = BookingList.OrderBy(b => b.CustomerName);
            //            }
            //            else
            //            {
            //                list = BookingList.OrderByDescending(b => b.CustomerName);
            //            }

            //            break;
            //        }

            //    case "ForwarderName":
            //        {
            //            if (SortType == 0)
            //            {
            //                list = BookingList.OrderBy(b => b.ForwarderName);
            //            }
            //            else
            //            {
            //                list = BookingList.OrderByDescending(b => b.ForwarderName);
            //            }

            //            break;
            //        }

            //    case "ServiceCode":
            //        {
            //            if (SortType == 0)
            //            {
            //                list = BookingList.OrderBy(b => b.ServiceCode);
            //            }
            //            else
            //            {
            //                list = BookingList.OrderByDescending(b => b.ServiceCode);
            //            }

            //            break;
            //        }

            //    case "SSLineCode":
            //        {
            //            if (SortType == 0)
            //            {
            //                list = BookingList.OrderBy(b => b.SSLineCode);
            //            }
            //            else
            //            {
            //                list = BookingList.OrderByDescending(b => b.SSLineCode);
            //            }

            //            break;
            //        }

            //    case "ERD":
            //        {
            //            if (SortType == 0)
            //            {
            //                BookingList = BookingList.OrderBy(b => b.ERD);
            //            }
            //            else
            //            {
            //                BookingList = BookingList.OrderByDescending(b => b.ERD);
            //            }

            //            break;
            //        }

            //    case "LRD":
            //        {
            //            if (SortType == 0)
            //            {
            //                BookingList = BookingList.OrderBy(b => b.LRD);
            //            }
            //            else
            //            {
            //                BookingList = BookingList.OrderByDescending(b => b.LRD);
            //            }

            //            break;
            //        }

            //    case "VesselName":
            //        {
            //            if (SortMode.ASC == SortType)
            //            {
            //                BookingList = BookingList.OrderBy(b => b.VesselName);
            //            }
            //            else
            //            {
            //                BookingList = BookingList.OrderByDescending(b => b.VesselName);
            //            }

            //            break;
            //        }

            //    case "TerminalName":
            //        {
            //            if (SortMode.ASC == SortType)
            //            {
            //                BookingList = BookingList.OrderBy(b => b.TerminalName);
            //            }
            //            else
            //            {
            //                BookingList = BookingList.OrderByDescending(b => b.TerminalName);
            //            }

            //            break;
            //        }

            //    case "SplitBooking":
            //        {
            //            if (SortMode.ASC == SortType)
            //            {
            //                BookingList = BookingList.OrderBy(b => b.SplitBooking);
            //            }
            //            else
            //            {
            //                BookingList = BookingList.OrderByDescending(b => b.SplitBooking);
            //            }

            //            break;
            //        }
            //}

            return null;
        }

        public VW_Booking GetVWById(int BookingId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_Booking.Where(b => b.BookingId == BookingId).ToList()[0];
            }
        }

        public Booking GetById(int BookingId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.Booking.Find(BookingId);
            }
        }

        public Booking GetById(int BookingId, WTCCeresEntities db)
        {
            return db.Booking.Find(BookingId);
        }

        public int GetLastBookingId()
        {
            return b.BookingId;
        }

        public bool UpdateBookingStatus(int BookingId, bool Active, int BookingStatusId)
        {
            bool isSaved = true;
            try
            {
                using (WTCCeresEntities db = new WTCCeresEntities())
                {
                    b = db.Booking.Find(BookingId);
                    b.ActiveBooking = Active;
                    b.BookingStatusId = BookingStatusId;

                    db.Booking.AddOrUpdate(b);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                isSaved = false;
            }

            return isSaved;
        }
    }

    public interface IBookingRepository
    {
        List<VW_Booking> GetAllByActiveStatus(bool ActiveBooking);

        List<Booking> GetAll();

        List<VW_Booking> GetAllVW();

        List<VW_Booking> GetAllVW(bool ActiveBooking);

        List<VW_Booking> GetByFilter(List<VW_Booking> BookingList, string SortArgument, int SortType);

        Booking GetById(int BookingId);

        Booking GetById(int BookingId, WTCCeresEntities db);

        VW_Booking GetVWById(int BookingId);

        bool AddOrUpdate(Booking Booking, WTCCeresEntities db);

        bool Delete(Booking Booking);

        int GetLastBookingId();

        bool UpdateBookingStatus(int BookingId, bool Active, int BookingStatusId);
    }
}