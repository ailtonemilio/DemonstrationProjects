using ModelLayer;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class BookingTypeRepository : IBookingTypeRepository
    {
        public List<BookingType> GetAll()
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.BookingType.OrderBy(bt => bt.TypeName).ToList();
            }
        }

        public List<BookingType> GetAll(WTCCeresEntities db)
        {
            return db.BookingType.OrderBy(bt => bt.TypeName).ToList();
        }
    }

    public interface IBookingTypeRepository
    {
        List<BookingType> GetAll();

        List<BookingType> GetAll(WTCCeresEntities db);
    }
}