namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_MinibookingMiniUnitAssignment
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AssignmentId { get; set; }

        public bool? ActiveBooking { get; set; }

        public DateTime? AssignedAt { get; set; }

        public DateTime? ERD { get; set; }

        [StringLength(100)]
        public string CustomerName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string BookingNumber { get; set; }

        [StringLength(43)]
        public string MinibookingNumber { get; set; }

        [StringLength(15)]
        public string BookingStatus { get; set; }

        [StringLength(50)]
        public string CustomerReference { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ShipperId { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ForwarderId { get; set; }

        public int? TerminalId { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SSLineId { get; set; }

        [StringLength(10)]
        public string AmountRequested { get; set; }

        [StringLength(20)]
        public string Bagtype { get; set; }

        public int? NumberOfContainer { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(10)]
        public string ContainerSize { get; set; }

        [StringLength(10)]
        public string TerminalCode { get; set; }

        [StringLength(100)]
        public string TerminalName { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(4)]
        public string SplitBooking { get; set; }

        [StringLength(10)]
        public string SsLineCode { get; set; }

        [StringLength(100)]
        public string SSLineName { get; set; }

        [StringLength(2)]
        public string BagUnit { get; set; }

        [StringLength(4)]
        public string BagWeightName { get; set; }

        public double? TotalBilledMU { get; set; }

        [StringLength(10)]
        public string CommodityCode { get; set; }

        [StringLength(21)]
        public string CommodityGrade { get; set; }

        [StringLength(40)]
        public string GradeName { get; set; }

        [StringLength(10)]
        public string GradeCode { get; set; }

        [StringLength(15)]
        public string UnitNumber { get; set; }

        [StringLength(52)]
        public string MiniUnitNumber { get; set; }

        [StringLength(500)]
        public string Comments { get; set; }

        [StringLength(250)]
        public string MULocation { get; set; }

        [StringLength(15)]
        public string UnitType { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MiniUnitId { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MinibookingId { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UnitSourceId { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RailListId { get; set; }

        [StringLength(15)]
        public string UnitStatus { get; set; }

        [StringLength(10)]
        public string CargoType { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LastTraced { get; set; }

        [StringLength(50)]
        public string LastLocation { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ETADate { get; set; }

        public int? DemurageDays { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CallDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BillDate { get; set; }

        [StringLength(100)]
        public string ShipperName { get; set; }

        [StringLength(50)]
        public string OriginLocation { get; set; }

        [StringLength(15)]
        public string UnitLine { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GrainInvStorageLocationId { get; set; }

        public int? MiniBookingOrder { get; set; }

        public bool? isStorageUnit { get; set; }

        public decimal? BilledByUnit { get; set; }

        [Key]
        [Column(Order = 13)]
        public bool BalanceToStorageAllowed { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(15)]
        public string BalanceInstrux { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(3)]
        public string BalanceInstruxCode { get; set; }

        [StringLength(18)]
        public string OriginalMiniunitNumber { get; set; }

        [StringLength(15)]
        public string OriginalUnitNumber { get; set; }

        public int? QtyCansInMb { get; set; }

        [StringLength(5)]
        public string ServiceCode { get; set; }

        [StringLength(15)]
        public string ServiceName { get; set; }

        [StringLength(40)]
        public string CommodityName { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BookingServiceId { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UnitStatusId { get; set; }
    }
}
