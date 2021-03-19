using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class BookingDestinationService
    {
        private static IBookingDestinationRepository repository;

        static BookingDestinationService()
        {
            repository = new BookingDestinationRepository();
        }

        public static List<VW_BookingDestination> GetByFilters(string SearchWord)
        {
            return repository.GetByFilters(SearchWord);
        }

        public bool AddOrUpdate(BookingDestination bookingDestination)
        {
            return repository.AddOrUpdate(bookingDestination);
        }

        public bool Delete(BookingDestination bookingDestination)
        {
            return repository.Delete(bookingDestination);
        }

        public static VW_BookingDestination GetVWById(int BookingDestinationId)
        {
            return repository.GetVWById(BookingDestinationId);
        }

        public static VW_BookingDestination GetVWById(int BookingDestinationId, WTCCeresEntities db)
        {
            return repository.GetVWById(BookingDestinationId, db);
        }

        public static BookingDestination GetById(int BookingDestinationId)
        {
            return repository.GetById(BookingDestinationId);
        }
    }
}