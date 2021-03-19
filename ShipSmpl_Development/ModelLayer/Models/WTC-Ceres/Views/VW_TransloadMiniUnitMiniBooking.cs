namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_TransloadMiniUnitMiniBooking
    {
        public int? UnitSourceId { get; set; }

        public int? MiniUnitId { get; set; }

        [StringLength(40)]
        public string CommodityName { get; set; }

        [StringLength(40)]
        public string GradeName { get; set; }

        public double? TotalBilledMU { get; set; }

        public DateTime? ERD { get; set; }

        public DateTime? LRD { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BookingServiceId { get; set; }

        [StringLength(5)]
        public string ServiceCode { get; set; }

        public bool? AllowSplitBooking { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BookingId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MiniBookingId { get; set; }

        [StringLength(43)]
        public string MinibookingNumber { get; set; }

        [StringLength(10)]
        public string SSLineCode { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TotalQtyOfCans { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Partial { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Ready { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Delivered { get; set; }

        public bool? ActiveBooking { get; set; }

        [StringLength(100)]
        public string CustomerName { get; set; }

        [StringLength(30)]
        public string LotNumber { get; set; }

        [StringLength(10)]
        public string SpecialMax { get; set; }

        [StringLength(10)]
        public string AmountRequested { get; set; }

        [StringLength(10)]
        public string BagWeight { get; set; }

        [StringLength(4)]
        public string BagWeightUnit { get; set; }

        [StringLength(20)]
        public string Bagtype { get; set; }

        [StringLength(20)]
        public string BagProvider { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(10)]
        public string ContainerSize { get; set; }

        [StringLength(20)]
        public string GradeBy { get; set; }

        [StringLength(20)]
        public string PhytosanitaryBy { get; set; }

        [StringLength(30)]
        public string InspectionBy { get; set; }

        [StringLength(30)]
        public string FumigationBy { get; set; }

        [StringLength(20)]
        public string SpecialInstrux { get; set; }

        [StringLength(300)]
        public string SpecialInstruxNote { get; set; }

        [StringLength(10)]
        public string CargoType { get; set; }
    }
}
