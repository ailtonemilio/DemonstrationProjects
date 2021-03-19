namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_GrainInventory
    {
        [StringLength(100)]
        public string CustomerNameGrainInv { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GrainInventoryId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerIdGrainInv { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MiniUnitId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BagId { get; set; }

        [StringLength(300)]
        public string BagDescription { get; set; }

        [StringLength(10)]
        public string BagSizeName { get; set; }

        [StringLength(7)]
        public string BagWeightName { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerIdMU { get; set; }

        [StringLength(100)]
        public string CustomerNameMU { get; set; }

        [Key]
        [Column(Order = 5)]
        public double InitialQuantity { get; set; }

        public decimal? TotalBilledMU { get; set; }

        [StringLength(21)]
        public string GradeCommodityCode { get; set; }

        [StringLength(18)]
        public string MiniUnitNumber { get; set; }

        [StringLength(81)]
        public string GradeCommodityName { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CommodityId { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GradeId { get; set; }

        [StringLength(15)]
        public string UnitNumber { get; set; }

        [StringLength(500)]
        public string Comments { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UnitSourceId { get; set; }

        [StringLength(10)]
        public string CargoType { get; set; }

        public int? MiniUnitOrder { get; set; }

        public int? RailListId { get; set; }

        [StringLength(15)]
        public string UnitStatus { get; set; }

        [StringLength(15)]
        public string UnitType { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LastTraced { get; set; }

        [StringLength(50)]
        public string LastLocation { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ETADate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CallDate { get; set; }

        public int? DemurageDays { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BillDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReleaseDate { get; set; }

        [StringLength(100)]
        public string ShipperName { get; set; }

        [StringLength(10)]
        public string ShipperCode { get; set; }

        [StringLength(15)]
        public string UnitLine { get; set; }

        public double? RemainingQuantity { get; set; }

        [StringLength(10)]
        public string GradeCode { get; set; }

        [StringLength(10)]
        public string CommodityCode { get; set; }
    }
}
