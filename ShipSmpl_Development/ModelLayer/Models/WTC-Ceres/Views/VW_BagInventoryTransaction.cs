namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_BagInventoryTransaction
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string TransactionType { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BagInventoryTransactionId { get; set; }

        public int? BagInventoryId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BagQuantity { get; set; }

        public DateTime? TransactionDate { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TransactionTypeId { get; set; }

        [StringLength(2)]
        public string BagUnit { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string ColorType { get; set; }

        [StringLength(20)]
        public string ColorName { get; set; }

        [StringLength(300)]
        public string BagDescription { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BagLogoId { get; set; }

        [StringLength(4)]
        public string BagWeightName { get; set; }

        [StringLength(10)]
        public string BagSizeName { get; set; }

        [StringLength(30)]
        public string LocationName { get; set; }

        public int? YardLocationId { get; set; }

        [StringLength(50)]
        public string YardLocationName { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TransactionQuantity { get; set; }
    }
}
