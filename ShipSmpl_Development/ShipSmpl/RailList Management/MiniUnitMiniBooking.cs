
namespace ShipSmpl
{
    public class MiniUnitMiniBooking
    {
        public int MBID { get; set; }
        public string BookingNumber { get; set; }
        public int MUID { get; set; }
        public string UnitNumber { get; set; }

        public MiniUnitMiniBooking()
        {
        }

        public MiniUnitMiniBooking(int _MBID, string _BookingNumber, int _MUID, string _UnitNumber)
        {
            MBID = _MBID;
            BookingNumber = _BookingNumber;
            MUID = _MUID;
            UnitNumber = _UnitNumber;
        }
    }
}