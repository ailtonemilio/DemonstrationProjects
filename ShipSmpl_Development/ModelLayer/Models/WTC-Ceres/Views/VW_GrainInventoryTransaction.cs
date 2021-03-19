namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_GrainInventoryTransaction
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GrainInventoryTransactionId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TransactionTypeId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string TransactionType { get; set; }

        [Key]
        [Column(Order = 3)]
        public double Quantity { get; set; }

        public DateTime? CreatedAt { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GrainInventoryId { get; set; }

        [StringLength(100)]
        public string CustomerNameGrainInv { get; set; }

        [StringLength(300)]
        public string BagDescription { get; set; }

        [StringLength(10)]
        public string BagSizeName { get; set; }

        [StringLength(7)]
        public string BagWeightName { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BagId { get; set; }

        [Key]
        [Column(Order = 6)]
        public double InitialQuantity { get; set; }

        public double? RemainingQuantity { get; set; }

        [StringLength(18)]
        public string MiniUnitNumber { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CommodityId { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GradeId { get; set; }

        [StringLength(21)]
        public string GradeCommodityCode { get; set; }

        [StringLength(81)]
        public string GradeCommodityName { get; set; }

        [StringLength(10)]
        public string GradeCode { get; set; }

        [StringLength(10)]
        public string CommodityCode { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UnitSourceId { get; set; }

        [StringLength(15)]
        public string UnitNumber { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StorageId { get; set; }

        [Key]
        [Column(Order = 11)]
        public double QtyInStorage { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StorageTypeId { get; set; }

        [StringLength(30)]
        public string StorageTypeName { get; set; }

        [StringLength(52)]
        public string StorageUnitNumber { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MiniUnitId { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GrainInvStorageLocationId { get; set; }

        [StringLength(30)]
        public string StorageLocation { get; set; }
    }
}
