using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class BookingTypeService
    {
        private static IBookingTypeRepository repository;

        static BookingTypeService()
        {
            repository = new BookingTypeRepository();
        }

        public static List<ModelLayer.BookingType> GetAll()
        {
            return repository.GetAll();
        }

        public static List<ModelLayer.BookingType> GetAll(WTCCeresEntities db)
        {
            return repository.GetAll(db);
        }
    }
}