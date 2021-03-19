namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_GrainInvMinibookingAssignment
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GrainInvMinibookingAssignmentId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MinibookingId { get; set; }

        public DateTime? AssignedAt { get; set; }

        [Key]
        [Column(Order = 2)]
        public double QuantityAssigned { get; set; }

        [StringLength(100)]
        public string ForwarderName { get; set; }

        [StringLength(10)]
        public string ForwarderCode { get; set; }

        public DateTime? ERD { get; set; }

        [StringLength(10)]
        public string TerminalCode { get; set; }

        [StringLength(100)]
        public string TerminalName { get; set; }

        [StringLength(10)]
        public string SsLineCode { get; set; }

        [StringLength(100)]
        public string SSLineName { get; set; }

        [StringLength(50)]
        public string CustomerReference { get; set; }

        [StringLength(15)]
        public string BookingStatus { get; set; }

        [StringLength(100)]
        public string CustomerName { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SSLineId { get; set; }

        public int? TerminalId { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ForwarderId { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ShipperId { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerId { get; set; }

        [StringLength(100)]
        public string ReleaseFromName { get; set; }

        [StringLength(10)]
        public string ReleaseFromCode { get; set; }

        public int? NumberOfContainer { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(40)]
        public string BookingNumber { get; set; }

        [StringLength(43)]
        public string MinibookingNumber { get; set; }

        [StringLength(5)]
        public string BookingService { get; set; }

        [StringLength(15)]
        public string BookingType { get; set; }

        [StringLength(100)]
        public string CustomerNameGrainInv { get; set; }

        [StringLength(300)]
        public string BagDescription { get; set; }

        [StringLength(10)]
        public string BagSizeName { get; set; }

        [StringLength(7)]
        public string BagWeightName { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BagId { get; set; }

        [Key]
        [Column(Order = 9)]
        public double InitialQuantity { get; set; }

        public double? RemainingQuantity { get; set; }

        [StringLength(18)]
        public string MiniUnitNumber { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GradeId { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CommodityId { get; set; }

        [StringLength(10)]
        public string GradeCode { get; set; }

        [StringLength(21)]
        public string GradeCommodityCode { get; set; }

        [StringLength(10)]
        public string CommodityCode { get; set; }

        [StringLength(15)]
        public string UnitNumber { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UnitSourceId { get; set; }

        [StringLength(30)]
        public string StorageTypeName { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StorageTypeId { get; set; }

        [Key]
        [Column(Order = 14)]
        public double QtyInStorage { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StorageId { get; set; }

        [StringLength(52)]
        public string StorageUnitNumber { get; set; }

        [StringLength(15)]
        public string UnitType { get; set; }

        public int? RailListId { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UnitStatusId { get; set; }

        [StringLength(15)]
        public string UnitStatus { get; set; }

        [StringLength(10)]
        public string CargoType { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ETADate { get; set; }

        [StringLength(50)]
        public string ETALocation { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LastTraced { get; set; }

        [StringLength(50)]
        public string LastLocation { get; set; }

        public int? DemurageDays { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BillDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CallDate { get; set; }

        [StringLength(100)]
        public string ShipperName { get; set; }

        [StringLength(10)]
        public string ShipperCode { get; set; }

        [StringLength(50)]
        public string OriginLocation { get; set; }

        [StringLength(15)]
        public string UnitLine { get; set; }

        public decimal? TotalBilledMU { get; set; }

        [StringLength(500)]
        public string Comments { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GrainInvStorageLocationId { get; set; }

        [StringLength(2)]
        public string BagUnit { get; set; }

        [StringLength(10)]
        public string AmountRequested { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(4)]
        public string SplitBooking { get; set; }

        [Key]
        [Column(Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GrainInventoryId { get; set; }

        [Key]
        [Column(Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MiniUnitId { get; set; }

        [StringLength(50)]
        public string VoyageNumber { get; set; }
    }
}
