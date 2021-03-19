using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class BookingDestinationRepository : IBookingDestinationRepository
    {
        private BookingDestination bd = new BookingDestination();

        public bool AddOrUpdate(BookingDestination bookingDestination)
        {
            bool isSaved = true;

            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    if (bookingDestination.BookingDestinationId == 0)
                    {
                        db.BookingDestination.Add(bookingDestination);
                    }
                    else
                    {
                        db.BookingDestination.AddOrUpdate(bookingDestination);
                    }

                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    string message = ex.Message;
                    isSaved = false;
                }
            }
            return isSaved;
        }

        public bool Delete(BookingDestination bookingDestination)
        {
            bool isSaved = true;

            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    db.BookingDestination.Remove(bookingDestination);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    string message = ex.Message;
                    isSaved = false;
                }
            }
            return isSaved;
        }

        public List<VW_BookingDestination> GetByFilters(string SearchWord)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_BookingDestination.Where(bd => bd.DestAddrStr.Contains(SearchWord)
                                                        && bd.BookingDestinationId != 0).Take(100).ToList();
            }
        }

        public BookingDestination GetById(int BookingDestinationId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.BookingDestination.Find(BookingDestinationId);
            }
        }

        public VW_BookingDestination GetVWById(int BookingDestinationId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_BookingDestination.Where(bd => bd.BookingDestinationId == BookingDestinationId).ToList()[0];
            }
        }

        public VW_BookingDestination GetVWById(int BookingDestinationId, WTCCeresEntities db)
        {
            return db.VW_BookingDestination.Where(bd => bd.BookingDestinationId == BookingDestinationId).ToList()[0];
        }
    }

    public interface IBookingDestinationRepository
    {
        List<VW_BookingDestination> GetByFilters(string SearchWord);

        BookingDestination GetById(int BookingDestinationId);

        VW_BookingDestination GetVWById(int BookingDestinationId);

        VW_BookingDestination GetVWById(int BookingDestinationId, WTCCeresEntities db);

        bool AddOrUpdate(BookingDestination bookingDestination);

        bool Delete(BookingDestination bookingDestination);
    }
}