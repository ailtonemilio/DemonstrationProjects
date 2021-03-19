namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_TransloadRecords
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TransloadID { get; set; }

        [StringLength(15)]
        public string UnitNumber { get; set; }

        public int? MiniBookingID { get; set; }

        [StringLength(43)]
        public string MinibookingNumber { get; set; }

        public int? BookServiceID { get; set; }

        public int? ContainerID { get; set; }

        [Column("Container Number")]
        [StringLength(11)]
        public string Container_Number { get; set; }

        [Column("Seal Number")]
        [StringLength(10)]
        public string Seal_Number { get; set; }

        public DateTime? PackedDate { get; set; }

        [StringLength(50)]
        public string CommodityPacked { get; set; }

        [StringLength(40)]
        public string CommodityName { get; set; }

        [StringLength(40)]
        public string GradeName { get; set; }

        [StringLength(50)]
        public string LotNumber { get; set; }

        public int? NumberOfBags { get; set; }

        [StringLength(10)]
        public string BagWeight { get; set; }

        [StringLength(4)]
        public string BagWeightUnit { get; set; }

        public double? LoadedMT { get; set; }
    }
}
