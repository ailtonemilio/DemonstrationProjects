namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BookingChangeLog")]
    public partial class BookingChangeLog
    {
        public int BookingGroupID { get; set; }

        public int GroupCounter { get; set; }

        public int? BookingId { get; set; }

        [Required]
        [StringLength(40)]
        public string OldBookingNumber { get; set; }

        [Required]
        [StringLength(40)]
        public string NewBookingNumber { get; set; }

        public bool? AllowSplitBooking { get; set; }

        [StringLength(20)]
        public string CustomerReference { get; set; }

        [StringLength(20)]
        public string ShipperReference { get; set; }

        [StringLength(20)]
        public string ForwarderReference { get; set; }

        public int? DestinationID { get; set; }

        public short? NumberOfCans { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LastUpdate { get; set; }

        public bool? ActiveBooking { get; set; }

        public bool? OnERD { get; set; }

        [StringLength(15)]
        public string BookingTypeId { get; set; }

        [StringLength(15)]
        public string BookingServiceId { get; set; }

        [StringLength(15)]
        public string BookingStatusId { get; set; }

        [StringLength(20)]
        public string ExporterReference { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateTimeCreated { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DocCutOffDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? VgmCutOffDate { get; set; }

        public int? ModifiedByEmployeeId { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ModifDate { get; set; }

        public int BookingChangeLogId { get; set; }
    }
}
