using ModelLayer;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class BookingServiceRepository : IBookingServiceRepository
    {
        public List<BookingService> GetAll()
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.BookingService.OrderBy(bs => bs.ServiceCode).ToList();
            }
        }

        public List<BookingService> GetAll(WTCCeresEntities db)
        {
            return db.BookingService.OrderBy(bs => bs.ServiceCode).ToList();
        }
    }

    public interface IBookingServiceRepository
    {
        List<BookingService> GetAll();

        List<BookingService> GetAll(WTCCeresEntities db);
    }
}