namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_BagInventory
    {
        public int? BagInventoryId { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TotalQuantity { get; set; }

        [StringLength(20)]
        public string BagColor { get; set; }

        [StringLength(100)]
        public string CustomerName { get; set; }

        public DateTime? StorageDate { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool ActiveBag { get; set; }

        public int? Remaining { get; set; }

        [StringLength(31)]
        public string LeftPercentage { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BagId { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BagSizeId { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BagWeightId { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(10)]
        public string ColorType { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BagLogoId { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ColorId { get; set; }

        [StringLength(300)]
        public string BagDescription { get; set; }

        [StringLength(10)]
        public string BagSizeName { get; set; }

        [StringLength(4)]
        public string BagWeightName { get; set; }

        [StringLength(2)]
        public string BagUnit { get; set; }

        [StringLength(200)]
        public string ImagePath { get; set; }

        [StringLength(200)]
        public string LogoDescription { get; set; }

        [StringLength(4)]
        public string BagYear { get; set; }
    }
}
