namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_Booking
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
        public string BookingStatus { get; set; }

        [StringLength(15)]
        public string BookingType { get; set; }

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
        public int VesselVoyageId { get; set; }

        [StringLength(10)]
        public string BkCarrierOutCode { get; set; }
    }
}
