using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using static DataLayer.MinibookingRepository;

namespace DataLayer
{
    public class MinibookingRepository : IMinibookingRepository
    {
        private Minibooking mb = new Minibooking();
        private VW_BookingMinibooking VWBookingJoinMB = new VW_BookingMinibooking();
        private Booking b = new Booking();

        public List<Minibooking> GetAll()
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.Minibooking.ToList();
            }
        }

        public Minibooking GetById(int Id)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.Minibooking.Find(Id);
            }
        }

        public VW_BookingMinibooking GeVWById(int Id)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_BookingMinibooking.Where(m => m.MiniBookingId == Id).ToList()[0];
            }
        }

        public List<VW_BookingMinibooking> GetJointBooking(bool activeStatus)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var list = db.VW_BookingMinibooking.Where(mb => mb.ActiveBooking == activeStatus).OrderBy(m => m.MinibookingNumber).ToList();

                var emptyItem = new VW_BookingMinibooking();

                emptyItem.BookingNumber = "";

                list.Insert(0, emptyItem);

                return list.ToList();
            }
        }

        public List<VW_BookingMinibooking> GetJointBookingByBookingId(int BookingId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var list = db.VW_BookingMinibooking.Where(mb => mb.BookingId == BookingId).ToList();

                return list;
            }
        }

        public List<VW_BookingMinibooking> GetJointBookingByMinibooking(string MinibookingNumber, bool ActiveBooking)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var list = db.VW_BookingMinibooking.Where(mb => mb.BookingNumber.Contains(MinibookingNumber)
                                                        && mb.ActiveBooking == ActiveBooking).ToList();

                return list;
            }
        }

        public List<VW_BookingMinibooking> GetJointBookingByCustomer(string customer)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var list = db.VW_BookingMinibooking.Where(mb => mb.CustomerName == customer).ToList();

                return list;
            }
        }

        public List<VW_BookingMinibooking> GetJointBookingByFilters(bool activeStatus, DateTime fromDate, DateTime toDate)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                DateTime minDate = new DateTime(1753, 1, 1);
                List<VW_BookingMinibooking> list;
                if (fromDate.Date == minDate.Date)
                {
                    list = db.VW_BookingMinibooking.Where(mb => mb.ActiveBooking == activeStatus).ToList();
                }
                else
                {
                    list = db.VW_BookingMinibooking.Where(mb => mb.ActiveBooking == activeStatus
                                                    && (mb.CreatedAt >= fromDate.Date
                                                    && mb.CreatedAt <= toDate)
                                                 ).ToList();
                }

                return list;
            }
        }

        public bool UpdateBKCansNumb(string BookingNumber, int QtyOfCans)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                bool isSaved = true;

                try
                {
                    b = db.Booking.Find(BookingNumber);
                    b.TotalQtyOfCans = QtyOfCans;
                    db.Booking.AddOrUpdate(b);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    isSaved = false;
                }
                return isSaved;
            }
        }

        public bool UpdateMBCansNumb(int MBId, int QtyOfCans)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                bool isSaved = true;

                try
                {
                    mb = db.Minibooking.Find(MBId);
                    mb.NumberOfContainer = QtyOfCans;
                    db.Minibooking.AddOrUpdate(mb);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    isSaved = false;
                }
                return isSaved;
            }
        }

        public List<VW_BookingMinibooking> GetJointBookingByBookingList(List<string> BookingNumber)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_BookingMinibooking.Where(b => BookingNumber.Contains(b.BookingNumber)).ToList();
            }
        }

        public List<VW_BookingMinibooking> GetJointBookingToAsnByFilter(string CustomerName, List<string> Bookingervice, string SearchWord)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_BookingMinibooking.Where(b => b.ActiveBooking == true
                                                         && b.CustomerName.Contains(CustomerName)
                                                         && Bookingervice.Contains(b.ServiceCode)
                                                         && b.BookingNumber.Contains(SearchWord)).ToList();
            }
        }

        public bool AddOrUpdate(Minibooking minibooking, WTCCeresEntities db)
        {
            bool isSaved = true;

            try
            {
                if (minibooking.MiniBookingId == 0)
                {
                    db.Minibooking.Add(minibooking);
                }
                else
                {
                    db.Minibooking.AddOrUpdate(minibooking);
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

        public bool Delete(int minibookingId)
        {
            bool isSaved = true;
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    mb = db.Minibooking.Find(minibookingId);
                    db.Minibooking.Remove(mb);

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

        public bool Delete(int minibookingId, WTCCeresEntities db)
        {
            bool isSaved = true;

            try
            {
                mb = db.Minibooking.Find(minibookingId);
                db.Minibooking.Remove(mb);

                db.SaveChanges();
            }
            catch (Exception e)
            {
                string message = e.Message;
                isSaved = false;
            }

            return isSaved;
        }

        public bool UpdateCarrierOut(int MinibookingId, int CarrierOutId)
        {
            bool isSaved = true;
            try
            {
                using (WTCCeresEntities db = new WTCCeresEntities())
                {
                    mb = db.Minibooking.Find(MinibookingId);

                    mb.CarrierOutId = CarrierOutId;

                    db.Minibooking.AddOrUpdate(mb);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                string msg = e.Message;
                isSaved = false;
            }
            return isSaved;
        }

        public List<Minibooking> GetAllByBookingId(int BookingId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.Minibooking.Where(mb => mb.BookingId == BookingId).ToList();
            }
        }

        public List<Minibooking> GetAllByBookingId(int BookingId, WTCCeresEntities db)
        {
            return db.Minibooking.Where(mb => mb.BookingId == BookingId).ToList();
        }

        public VW_BookingMinibooking GetByBookingAndMbOrder(string BookingNumber, int MbOrder)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_BookingMinibooking.Where(m => m.BookingNumber == BookingNumber
                                                      && m.MiniBookingOrder == MbOrder).ToList()[0];
            }
        }

        public interface IMinibookingRepository
        {
            List<Minibooking> GetAll();

            Minibooking GetById(int Id);

            List<Minibooking> GetAllByBookingId(int BookingId);

            List<Minibooking> GetAllByBookingId(int BookingId, WTCCeresEntities db);

            VW_BookingMinibooking GeVWById(int Id);

            List<VW_BookingMinibooking> GetJointBookingByCustomer(string customer);

            List<VW_BookingMinibooking> GetJointBooking(bool activeStatus);

            List<VW_BookingMinibooking> GetJointBookingToAsnByFilter(string CustomerName, List<string> BoookingService, string SearchWord);

            List<VW_BookingMinibooking> GetJointBookingByMinibooking(string MinibookingNumber, bool ActiveBooking);

            List<VW_BookingMinibooking> GetJointBookingByFilters(bool activeStatus, DateTime fromDate, DateTime toDate);

            List<VW_BookingMinibooking> GetJointBookingByBookingId(int Booking);

            List<VW_BookingMinibooking> GetJointBookingByBookingList(List<string> BookingNumber);

            bool UpdateMBCansNumb(int MBId, int QtyOfCans);

            bool UpdateBKCansNumb(string BookingNumber, int QtyOfCans);

            bool AddOrUpdate(Minibooking minibooking, WTCCeresEntities db);

            bool UpdateCarrierOut(int MinibookingId, int CarrierOutId);

            bool Delete(int minibookingId);

            bool Delete(int minibookingId, WTCCeresEntities db);

            VW_BookingMinibooking GetByBookingAndMbOrder(string BookingNumber, int MbOrder);
        }
    }
}