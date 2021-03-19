namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_GrainInvMinibookingTransaction
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GrainInvMinibookingTransactionId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MinibookingId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GrainInventoryTransactionId { get; set; }

        [StringLength(15)]
        public string BookingType { get; set; }

        [StringLength(5)]
        public string BookingService { get; set; }

        [StringLength(43)]
        public string MinibookingNumber { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(40)]
        public string BookingNumber { get; set; }

        [StringLength(100)]
        public string CustomerName { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TransactionTypeId { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(10)]
        public string TransactionType { get; set; }

        [Key]
        [Column(Order = 6)]
        public double Quantity { get; set; }

        public DateTime? CreatedAt { get; set; }

        [StringLength(30)]
        public string LotNumber { get; set; }

        [StringLength(50)]
        public string CustomerReference { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UnitSourceId { get; set; }

        [StringLength(15)]
        public string UnitNumber { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StorageId { get; set; }

        [StringLength(18)]
        public string MiniUnitNumber { get; set; }

        [StringLength(10)]
        public string BagSizeName { get; set; }

        [StringLength(7)]
        public string BagWeightName { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GrainInventoryId { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MiniUnitId { get; set; }
    }
}
