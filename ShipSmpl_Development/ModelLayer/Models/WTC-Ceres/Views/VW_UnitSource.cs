namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_UnitSource
    {
        public bool? MuHasDiffCust { get; set; }

        [StringLength(100)]
        public string CustomerName { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UnitSourceId { get; set; }

        [StringLength(15)]
        public string UnitNumber { get; set; }

        [StringLength(15)]
        public string UnitLine { get; set; }

        [StringLength(10)]
        public string CargoType { get; set; }

        [StringLength(15)]
        public string UnitStatus { get; set; }

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

        public double? TotalBilled { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LastUpdate { get; set; }

        public bool? ActiveUpdates { get; set; }

        public bool? Active { get; set; }

        public int? RecordKey { get; set; }

        [StringLength(300)]
        public string CargoDescription { get; set; }

        public int? ShipperId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UnitStatusId { get; set; }

        [StringLength(100)]
        public string ShipperName { get; set; }

        [StringLength(10)]
        public string ShipperCode { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CargoTypeId { get; set; }

        [StringLength(6)]
        public string CargoTypeCode { get; set; }

        [StringLength(15)]
        public string OriginalUnitNumber { get; set; }

        [StringLength(35)]
        public string RailIncShipperName { get; set; }
    }
}
