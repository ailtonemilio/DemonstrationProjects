using DataLayer;
using ModelLayer;
using System;
using System.Collections.Generic;
using static DataLayer.MinibookingRepository;

namespace BusinessLayer
{
    public class MinibookingService
    {
        private static IMinibookingRepository repository;

        static MinibookingService()
        {
            repository = new MinibookingRepository();
        }

        public List<Minibooking> GetAll()
        {
            return repository.GetAll();
        }

        public static List<Minibooking> GetAllByBookingId(int BookingId)
        {
            return repository.GetAllByBookingId(BookingId);
        }

        public static List<Minibooking> GetAllByBookingId(int BookingId, WTCCeresEntities db)
        {
            return repository.GetAllByBookingId(BookingId, db);
        }

        public static Minibooking GetById(int Id)
        {
            return repository.GetById(Id);
        }

        public static VW_BookingMinibooking GeVWById(int Id)
        {
            return repository.GeVWById(Id);
        }

        public static List<VW_BookingMinibooking> GetJointBookingByFilters(bool activeStatus, DateTime fromDate, DateTime toDate)
        {
            return repository.GetJointBookingByFilters(activeStatus, fromDate, toDate);
        }

        public static List<VW_BookingMinibooking> GetJointBooking(bool activeStatus)
        {
            return repository.GetJointBooking(activeStatus);
        }

        public static List<VW_BookingMinibooking> GetJointBookingByMinibooking(string MinibookingNumber, bool activeBooking)
        {
            return repository.GetJointBookingByMinibooking(MinibookingNumber, activeBooking);
        }

        public bool UpdateMBCansNumb(int MBId, int QtyOfCans)
        {
            return repository.UpdateMBCansNumb(MBId, QtyOfCans);
        }

        public bool UpdateBKCansNumb(string BookingNumber, int QtyOfCans)
        {
            return repository.UpdateBKCansNumb(BookingNumber, QtyOfCans);
        }

        public static List<VW_BookingMinibooking> GetJointBookingByBookingId(int BookingId)
        {
            return repository.GetJointBookingByBookingId(BookingId);
        }

        public List<VW_BookingMinibooking> GetJointBookingByCustomer(string customer)
        {
            return repository.GetJointBookingByCustomer(customer);
        }

        public static List<VW_BookingMinibooking> GetJointBookingByBookingList(List<string> BookingNumber)
        {
            return repository.GetJointBookingByBookingList(BookingNumber);
        }

        public static List<VW_BookingMinibooking> GetJointBookingToAsnByFilter(string CustomerName, List<string> BookingService, string SearchWord)
        {
            return repository.GetJointBookingToAsnByFilter(CustomerName, BookingService, SearchWord);
        }

        public bool UpdateCarrierOut(int MinibookingId, int CarrierOutId)
        {
            return repository.UpdateCarrierOut(MinibookingId, CarrierOutId);
        }

        public bool AddOrUpdate(Minibooking minibooking, WTCCeresEntities db)
        {
            return repository.AddOrUpdate(minibooking, db);
        }

        public bool Delete(int MinibookingId)
        {
            return repository.Delete(MinibookingId);
        }

        public bool Delete(int MinibookingId, WTCCeresEntities db)
        {
            return repository.Delete(MinibookingId, db);
        }

        public static VW_BookingMinibooking GetByBookingAndMbOrder(string BookingNumber, int MbOrder)
        {
            return repository.GetByBookingAndMbOrder(BookingNumber, MbOrder);
        }
    }
}