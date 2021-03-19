namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_BookingBagInventoryAssignment
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BagInventoryId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MinibookingId { get; set; }

        public DateTime? CreatedAt { get; set; }

        [StringLength(15)]
        public string BookingType { get; set; }

        [StringLength(5)]
        public string ServiceCode { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerId { get; set; }

        [StringLength(50)]
        public string ShipperReference { get; set; }

        [StringLength(50)]
        public string ForwarderReference { get; set; }

        public string VesselName { get; set; }

        [StringLength(50)]
        public string VoyageNumber { get; set; }

        public DateTime? SailingDate { get; set; }

        public DateTime? LRD { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DocCutOffDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? VgmCutOffDate { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TotalQtyOfCans { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string ContainerSize { get; set; }

        public bool? ActiveBooking { get; set; }

        [StringLength(15)]
        public string BookingStatus { get; set; }

        [StringLength(188)]
        public string DestAddrStr { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool HoldMinibooking { get; set; }

        public bool? OnERD { get; set; }

        [StringLength(15)]
        public string Expr1 { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ExporterId { get; set; }

        [StringLength(100)]
        public string ExporterName { get; set; }

        [StringLength(50)]
        public string ExporterReference { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(40)]
        public string BookingNumber { get; set; }

        [StringLength(43)]
        public string MinibookingNumber { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(40)]
        public string Expr2 { get; set; }

        public bool? isMainBooking { get; set; }

        public int? MiniBookingOrder { get; set; }

        public int? NumberOfContainer { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(10)]
        public string Expr3 { get; set; }

        [StringLength(10)]
        public string CarrierCodeOut { get; set; }

        [StringLength(100)]
        public string CarrierNameOut { get; set; }

        [StringLength(10)]
        public string TerminalCode { get; set; }

        [StringLength(100)]
        public string TerminalName { get; set; }

        [StringLength(100)]
        public string FreeTime { get; set; }

        [StringLength(20)]
        public string BagProvider { get; set; }

        [StringLength(10)]
        public string Tagging { get; set; }

        [StringLength(20)]
        public string Bagtype { get; set; }

        [StringLength(10)]
        public string AmountRequested { get; set; }

        [StringLength(10)]
        public string SpecialMax { get; set; }

        [StringLength(10)]
        public string BagWeight { get; set; }

        [StringLength(4)]
        public string BagWeightUnit { get; set; }

        [StringLength(30)]
        public string LotNumber { get; set; }

        [StringLength(20)]
        public string SpecialInstrux { get; set; }

        [StringLength(300)]
        public string SpecialInstruxNote { get; set; }

        [StringLength(20)]
        public string GradeBy { get; set; }

        [StringLength(20)]
        public string PhytosanitaryBy { get; set; }

        [StringLength(30)]
        public string InspectionBy { get; set; }

        [StringLength(30)]
        public string FumigationBy { get; set; }

        [StringLength(60)]
        public string Other { get; set; }

        [StringLength(300)]
        public string TerminalEffcFee { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Expr5 { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Expr6 { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ShipperId { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ForwarderId { get; set; }

        public int? TerminalId { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SSLineId { get; set; }

        [StringLength(15)]
        public string Expr7 { get; set; }

        [StringLength(50)]
        public string CustomerReference { get; set; }

        [StringLength(100)]
        public string CustomerNameBooking { get; set; }

        [StringLength(100)]
        public string SSLineName { get; set; }

        [StringLength(10)]
        public string SSLineCode { get; set; }

        [StringLength(100)]
        public string Expr8 { get; set; }

        [StringLength(10)]
        public string Expr9 { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(4)]
        public string SplitBooking { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TotalQuantity { get; set; }

        [StringLength(20)]
        public string BagColor { get; set; }

        [StringLength(100)]
        public string CustomerNameInventory { get; set; }

        [StringLength(4)]
        public string BagYear { get; set; }

        public DateTime? StorageDate { get; set; }

        [Key]
        [Column(Order = 16)]
        public bool ActiveBag { get; set; }

        public int? Remaining { get; set; }

        [StringLength(31)]
        public string LeftPercentage { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Expr4 { get; set; }

        [Key]
        [Column(Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BagId { get; set; }

        [Key]
        [Column(Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BagSizeId { get; set; }

        [Key]
        [Column(Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BagWeightId { get; set; }

        [Key]
        [Column(Order = 21)]
        [StringLength(10)]
        public string ColorType { get; set; }

        [Key]
        [Column(Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BagLogoId { get; set; }

        [Key]
        [Column(Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ColorId { get; set; }

        [StringLength(300)]
        public string BagDescription { get; set; }

        [StringLength(200)]
        public string LogoDescription { get; set; }

        [StringLength(10)]
        public string BagSizeName { get; set; }

        [StringLength(4)]
        public string BagWeightName { get; set; }

        [StringLength(2)]
        public string BagUnit { get; set; }

        [Key]
        [Column(Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BookingBagAssignmentId { get; set; }
    }
}
