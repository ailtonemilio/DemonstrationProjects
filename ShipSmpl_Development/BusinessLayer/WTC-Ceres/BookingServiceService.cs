using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class BookingServiceService
    {
        private static IBookingServiceRepository repository;

        static BookingServiceService()
        {
            repository = new BookingServiceRepository();
        }

        public static List<ModelLayer.BookingService> GetAll()
        {
            return repository.GetAll();
        }

        public static List<ModelLayer.BookingService> GetAll(WTCCeresEntities db)
        {
            return repository.GetAll(db);
        }
    }
}