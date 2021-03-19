using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.WTC_Ceres
{
    public class BookingService
    {
        private static IBookingRepository repository;

        static BookingService()
        {
            repository = new BookingRepository();
        }

        public static List<VW_Booking> GetAllVWByActiveStatus(bool ActiveBooking)
        {
            return repository.GetAllByActiveStatus(ActiveBooking);
        }

        public static List<Booking> GetAll()
        {
            return repository.GetAll();
        }

        public static List<Booking> GetAllByActiveStatus(bool ActiveBooking)
        {
            return repository.GetAll().Where(b => b.ActiveBooking == ActiveBooking).ToList();
        }

        public static List<VW_Booking> GetAllVW()
        {
            return repository.GetAllVW();
        }

        public static List<VW_Booking> GetAllVWByActive(bool ActiveBooking)
        {
            return repository.GetAllVW(ActiveBooking);
        }

        public static bool UpdateBookingStatus(int BookingId, bool Active, int BookingStatusId)
        {
            return repository.UpdateBookingStatus(BookingId, Active, BookingStatusId);
        }

        public static Booking GetById(int BookingId)
        {
            return repository.GetById(BookingId);
        }

        public static Booking GetById(int BookingId, WTCCeresEntities db)
        {
            return repository.GetById(BookingId, db);
        }

        public static VW_Booking GetVWById(int BookingId)
        {
            return repository.GetVWById(BookingId);
        }

        public bool AddOrUpdate(Booking Booking, WTCCeresEntities db)
        {
            return repository.AddOrUpdate(Booking, db);
        }

        public bool Delete(Booking Booking)
        {
            return repository.Delete(Booking);
        }

        public int GetLastBookingId()
        {
            return repository.GetLastBookingId();
        }

        public static List<VW_Booking> GetByFilter(List<VW_Booking> BookingList, string SortArgument, int SortType)
        {
            return repository.GetByFilter(BookingList, SortArgument, SortType);
        }
    }
}