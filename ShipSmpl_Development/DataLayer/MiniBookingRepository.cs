using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;


using static DataLayer.MiniBookingRepository;

namespace DataLayer
{

    public class MiniBookingRepository : IMiniBookingRepository
    {
        private WTCCeresEntities db = new WTCCeresEntities();
        private Mini_Bookings mb = new Mini_Bookings();
        private VW_BookingJoinMB VWBookingJoinMB = new VW_BookingJoinMB();
        private Bookings b = new Bookings();


       

        public List<Mini_Bookings> GetAll()
        {
            return db.Mini_Bookings.ToList();

        }

        public List<Mini_Bookings> GetById(int Id)
        {
            var listById = db.Mini_Bookings.Where(mb => mb.Record_ID == Id);

            return listById.ToList();
        }

        public List<VW_BookingJoinMB> GetJointBooking(bool activeStatus)
        {
            var list = db.VW_BookingJoinMB.Where(mb => mb.Active_Booking == activeStatus).ToList();

            return list;

        }
        public List<VW_BookingJoinMB> GetJointBookingByCustomer(string customer)
        {
            var list = db.VW_BookingJoinMB.Where(mb => mb.Customer_Name == customer).ToList();

            return list;

        }


        public interface IMiniBookingRepository
        {
            List<Mini_Bookings> GetAll();
            List<Mini_Bookings> GetById(int Id);
            List<VW_BookingJoinMB> GetJointBookingByCustomer(string customer);
            List<VW_BookingJoinMB> GetJointBooking(bool activeStatus);
            //bool Insert(string Code
            //                   , string Name
            //                   , string Email
            //                   , string Website
            //                   , string Type
            //                   , string Notes
            //                   , int Rating
            //                   , int CustomerID
            //                   , bool RequiresID
            //                   );

            //bool Update(int Id
            //                   , string Code
            //                   , string Name
            //                   , string Email
            //                   , string Website
            //                   , string Type
            //                   , string Notes
            //                   , int Rating
            //                   , int CustomerID
            //                   , bool RequiresID
            //                   );

            // bool Delete(int Id);
        }
    }
}