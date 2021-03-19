namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UnitSource")]
    public partial class UnitSource
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UnitSource()
        {
            MiniUnit = new HashSet<MiniUnit>();
            UnitSourceActiveUpdate = new HashSet<UnitSourceActiveUpdate>();
        }

        public int UnitSourceId { get; set; }

        [StringLength(15)]
        public string UnitNumber { get; set; }

        [StringLength(15)]
        public string UnitLine { get; set; }

        [StringLength(15)]
        public string UnitType { get; set; }

        [StringLength(50)]
        public string OriginLocation { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ETADate { get; set; }

        [StringLength(50)]
        public string ETALocation { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LastTraced { get; set; }

        [StringLength(50)]
        public string LastLocation { get; set; }

        [StringLength(35)]
        public string Sequence { get; set; }

        [StringLength(35)]
        public string Track { get; set; }

        public int? DemurageDays { get; set; }

        public int? InTransitDays { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BillDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CallDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ArrivalDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AvailableDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReleaseDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EmptyDate { get; set; }

        public double? TotalBilled { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LastUpdate { get; set; }

        public bool? ActiveUpdates { get; set; }

        public bool? Active { get; set; }

        public int? RecordKey { get; set; }

        [StringLength(35)]
        public string RailIncShipperName { get; set; }

        [StringLength(300)]
        public string CargoDescription { get; set; }

        public int? ShipperId { get; set; }

        public int UnitStatusId { get; set; }

        public int CargoTypeId { get; set; }

        [StringLength(15)]
        public string OriginalUnitNumber { get; set; }

        public virtual CargoType CargoType { get; set; }

        public virtual Company Company { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MiniUnit> MiniUnit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UnitSourceActiveUpdate> UnitSourceActiveUpdate { get; set; }

        public virtual UnitStatus UnitStatus { get; set; }
    }
}
