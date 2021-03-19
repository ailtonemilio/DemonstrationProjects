using DataLayer.WTC_Ceres;
using ModelLayer;

namespace BusinessLayer.WTC_Ceres
{
    public class BookingCompanyService
    {
        private static IBookingCompanyRepository repository;

        static BookingCompanyService()
        {
            repository = new BookingCompanyRepository();
        }

        public bool AddOrUpdate(BookingCompany bookingCompany, WTCCeresEntities db)
        {
            return repository.AddOrUpdate(bookingCompany, db);
        }

        public static BookingCompany GetByFiltersId(int BookingId, int CompanyTypeId, WTCCeresEntities db)
        {
            return repository.GetByFiltersId(BookingId, CompanyTypeId, db);
        }
    }
}