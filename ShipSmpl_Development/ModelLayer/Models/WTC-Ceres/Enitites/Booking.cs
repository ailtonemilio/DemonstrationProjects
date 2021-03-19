namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Booking")]
    public partial class Booking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Booking()
        {
            BookingCompany = new HashSet<BookingCompany>();
            Minibooking = new HashSet<Minibooking>();
        }

        public int BookingId { get; set; }

        [Required]
        [StringLength(40)]
        public string BookingNumber { get; set; }

        public int BookingTypeId { get; set; }

        public int BookingServiceId { get; set; }

        public int BookingStatusId { get; set; }

        public bool? OnERD { get; set; }

        public bool? ActiveBooking { get; set; }

        public bool? AllowSplitBooking { get; set; }

        public int TotalQtyOfCans { get; set; }

        [StringLength(50)]
        public string ShipperReference { get; set; }

        [StringLength(50)]
        public string ForwarderReference { get; set; }

        [StringLength(50)]
        public string ExporterReference { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DocCutOffDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? VgmCutOffDate { get; set; }

        public int? BookingDestinationId { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedAt { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LastUpdated { get; set; }

        public int VesselVoyageId { get; set; }

        public virtual BookingDestination BookingDestination { get; set; }

        public virtual BookingService BookingService { get; set; }

        public virtual BookingStatus BookingStatus { get; set; }

        public virtual BookingType BookingType { get; set; }

        public virtual VesselVoyage VesselVoyage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingCompany> BookingCompany { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Minibooking> Minibooking { get; set; }
    }
}
