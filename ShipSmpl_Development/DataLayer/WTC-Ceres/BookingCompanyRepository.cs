using ModelLayer;
using System;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class BookingCompanyRepository : IBookingCompanyRepository
    {
        public bool AddOrUpdate(BookingCompany bookingCompany, WTCCeresEntities db)
        {
            bool isSaved = true;

            try
            {
                db.BookingCompany.AddOrUpdate(bookingCompany);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                string msg = e.InnerException.InnerException.Message.ToString();
                isSaved = false;
            }
            return isSaved;
        }

        public BookingCompany GetByFiltersId(int BookingId, int CompanyTypeId, WTCCeresEntities db)
        {
            var l = db.BookingCompany.Where(b => b.BookingId == BookingId &
                                       b.CompanyTypeId == CompanyTypeId).ToList();

            if (l.Count > 0)
                return l[0];
            else
                return null;
        }
    }

    public interface IBookingCompanyRepository
    {
        bool AddOrUpdate(BookingCompany bookingCompany, WTCCeresEntities db);

        BookingCompany GetByFiltersId(int BookingId, int CompanyTypeId, WTCCeresEntities db);
    }
}