namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_ContainersInOutDrayage
    {
        [Key]
        [Column("Unique ID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Unique_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string rate { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string rateType { get; set; }

        [StringLength(11)]
        public string containerNumb { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(40)]
        public string bkrelNumber { get; set; }

        public DateTime? GateDateTime { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string pickUpCode { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(40)]
        public string pickUpName { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(10)]
        public string dropOffCode { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(40)]
        public string dropOffName { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(10)]
        public string truckID { get; set; }

        [StringLength(8000)]
        public string driverName { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int streetTurn { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(10)]
        public string carrierCode { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(50)]
        public string carrierName { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(15)]
        public string truckDriverId { get; set; }

        public DateTime? EDIDateTime { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(10)]
        public string SSLineCode { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(50)]
        public string SSLineName { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(5)]
        public string drayageType { get; set; }
    }
}
