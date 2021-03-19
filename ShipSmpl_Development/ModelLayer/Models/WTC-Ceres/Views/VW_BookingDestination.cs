namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_BookingDestination
    {
        [Key]
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

        [StringLength(188)]
        public string DestAddrStr { get; set; }
    }
}
