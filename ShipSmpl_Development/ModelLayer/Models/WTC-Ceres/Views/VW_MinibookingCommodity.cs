namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_MinibookingCommodity
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MiniBookingCommodityId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MiniBookingId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CommodityId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GradeId { get; set; }

        [StringLength(10)]
        public string GradeCode { get; set; }

        [StringLength(40)]
        public string GradeName { get; set; }

        [StringLength(10)]
        public string CommodityCode { get; set; }

        [StringLength(40)]
        public string CommodityName { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(40)]
        public string BookingNumber { get; set; }

        [StringLength(43)]
        public string MinibookingNumber { get; set; }

        [StringLength(21)]
        public string GradeCommodityCode { get; set; }

        [StringLength(81)]
        public string GradeCommodityName { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BookingId { get; set; }
    }
}
