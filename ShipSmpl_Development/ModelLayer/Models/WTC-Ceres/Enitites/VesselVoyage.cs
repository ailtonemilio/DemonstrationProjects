namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VesselVoyage")]
    public partial class VesselVoyage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VesselVoyage()
        {
            Booking = new HashSet<Booking>();
        }

        public int VesselVoyageId { get; set; }

        [StringLength(50)]
        public string VoyageNumber { get; set; }

        public DateTime? ERD { get; set; }

        public DateTime? LRD { get; set; }

        public DateTime? ETA { get; set; }

        public DateTime? ETD { get; set; }

        [StringLength(100)]
        public string PortCity { get; set; }

        [StringLength(100)]
        public string PortCountry { get; set; }

        public bool? IsActiveTrip { get; set; }

        public int? VesselId { get; set; }

        public int? PortId { get; set; }

        public int? VesselVoyageStatusId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Booking { get; set; }

        public virtual Company Company { get; set; }

        public virtual Vessel Vessel { get; set; }

        public virtual VesselVoyageStatus VesselVoyageStatus { get; set; }
    }
}
