namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BookingDestination")]
    public partial class BookingDestination
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BookingDestination()
        {
            Booking = new HashSet<Booking>();
        }

        public int BookingDestinationId { get; set; }

        [StringLength(3)]
        public string CountryCode { get; set; }

        [StringLength(100)]
        public string OriginalRegionName { get; set; }

        [StringLength(100)]
        public string RegionName { get; set; }

        [StringLength(80)]
        public string City { get; set; }

        [StringLength(200)]
        public string AddressDestination { get; set; }

        [StringLength(50)]
        public string Coordinates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Booking { get; set; }
    }
}
