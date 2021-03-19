namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_BookingMinibooking
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BookingId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string BookingNumber { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BookingTypeId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BookingServiceId { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BookingStatusId { get; set; }

        public bool? OnERD { get; set; }

        public bool? ActiveBooking { get; set; }

        public bool? AllowSplitBooking { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TotalQtyOfCans { get; set; }

        [StringLength(50)]
        public string CustomerReference { get; set; }

        [StringLength(50)]
        public string ShipperReference { get; set; }

        [StringLength(50)]
        public string ForwarderReference { get; set; }

        [StringLength(50)]
        public string ExporterReference { get; set; }

        public string VesselName { get; set; }

        [StringLength(50)]
        public string VoyageNumber { get; set; }

        public DateTime? SailingDate { get; set; }

        public DateTime? ERD { get; set; }

        public DateTime? LRD { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DocCutOffDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? VgmCutOffDate { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerId { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ShipperId { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ForwarderId { get; set; }

        public int? TerminalId { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ExporterId { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SSLineId { get; set; }

        public int? BookingDestinationId { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedAt { get; set; }

        [StringLength(15)]
        public string ServiceName { get; set; }

        [StringLength(5)]
        public string ServiceCode { get; set; }

        [StringLength(188)]
        public string DestAddrStr { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(4)]
        public string SplitBooking { get; set; }

        [StringLength(4000)]
        public string ERDStr { get; set; }

        [StringLength(4000)]
        public string LRDStr { get; set; }

        [StringLength(4000)]
        public string CreatedAtStr { get; set; }

        [StringLength(100)]
        public string CustomerName { get; set; }

        [StringLength(10)]
        public string CustomerCode { get; set; }

        [StringLength(100)]
        public string ShipperName { get; set; }

        [StringLength(10)]
        public string ShipperCode { get; set; }

        [StringLength(100)]
        public string ForwarderName { get; set; }

        [StringLength(10)]
        public string ForwarderCode { get; set; }

        [StringLength(100)]
        public string TerminalName { get; set; }

        [StringLength(10)]
        public string TerminalCode { get; set; }

        [StringLength(100)]
        public string ExporterName { get; set; }

        [StringLength(10)]
        public string ExporterCode { get; set; }

        [StringLength(100)]
        public string SSLineName { get; set; }

        [StringLength(10)]
        public string SSLineCode { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MiniBookingId { get; set; }

        public bool? isMainBooking { get; set; }

        public int? MiniBookingOrder { get; set; }

        public int? NumberOfContainer { get; set; }

        [StringLength(100)]
        public string FreeTime { get; set; }

        [StringLength(20)]
        public string BagProvider { get; set; }

        [StringLength(10)]
        public string Tagging { get; set; }

        [StringLength(10)]
        public string AmountRequested { get; set; }

        [StringLength(20)]
        public string Bagtype { get; set; }

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

        [StringLength(60)]
        public string Other { get; set; }

        [StringLength(30)]
        public string FumigationBy { get; set; }

        [StringLength(300)]
        public string TerminalEffcFee { get; set; }

        public int? CarrierOutId { get; set; }

        [StringLength(100)]
        public string CarrierNameOut { get; set; }

        [StringLength(10)]
        public string CarrierCodeOut { get; set; }

        [StringLength(15)]
        public string BookingStatus { get; set; }

        [StringLength(15)]
        public string BookingType { get; set; }

        [StringLength(2)]
        public string BagUnit { get; set; }

        [StringLength(300)]
        public string BagName { get; set; }

        [StringLength(4)]
        public string BagWeightName { get; set; }

        [StringLength(43)]
        public string MinibookingNumber { get; set; }

        public bool? isMultiMB { get; set; }

        [Key]
        [Column(Order = 13)]
        public bool HoldMinibooking { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(4)]
        public string HoldMinibookingStr { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ContainerSizeId { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(10)]
        public string ContainerSize { get; set; }

        [Key]
        [Column(Order = 17)]
        public bool isClosedMB { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(6)]
        public string isClosedMBSrt { get; set; }
    }
}
