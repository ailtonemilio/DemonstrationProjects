
namespace ShipSmpl
{
    static class MdlEnum
    {
        public enum TransactionType
        {
            RECEIVE = 1,
            SEND = 2,
            USE = 3,
            ADJUST = 4,
            ASSIGNMENT = 5
        }

        public enum SortMode
        {
            ASC = 0,
            DESC = 1
        }

        public enum BookingStatus
        {
            DELETED = 1,
            REACTIVATED = 2,
            COMPLETED = 3,
            CANCELLED = 4,
            ACTIVE = 5
        }

        public enum ContainerSize
        {
            _20FT = 1,
            _40FT = 2,
            _40FTHC = 3,
            _52FT = 4
        }

        public enum RequestStatus
        {
            ACCEPTED = 1,
            FOLLOW_UP = 2,
            PENDING_REPLY = 3,
            DECLINED = 4,
            IN_PROCESS = 5,
            LATE = 6,
            COMPLETE = 7,
            UPCOMING = 8
        }

        public enum UnitStatus
        {
            AVAILABLE = 1,
            IN_TRANSIT = 2,
            CALLED = 3,
            MISSED = 4,
            ON_HAND = 5,
            NOT_TRACING = 6,
            USER_CREATED = 7,
            RELEASED = 8
        }

        public enum BookingType
        {
            EXPORT = 1,
            REPO = 2,
            IMPORT = 3
        }

        public enum CompanyType
        {
            Unassigned = 0,
            Consignee = 1,
            Customer = 2,
            Shipper = 3,
            Steamship_Line = 4,
            Container_Terminal = 5,
            Drayage_Provider = 6,
            Importer = 7,
            Exporter = 8,
            Port = 9,
            Rail_Road = 10,
            Freight_Forwarder = 11
        }

        public enum CompanyCategory
        {
            CUSTOMER = 1,
            VENDOR = 2,
            CUSTOMER_VENDOR = 3
        }
    }
}