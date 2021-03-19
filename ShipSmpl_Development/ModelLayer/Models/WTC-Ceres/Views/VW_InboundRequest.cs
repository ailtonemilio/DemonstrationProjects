namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_InboundRequest
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InboundRequestId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ShippingLineId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RequestStatusId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ContainerSizeId { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QtyRequested { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BookingTypeId { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool IsOpenRequest { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "smalldatetime")]
        public DateTime DateRequested { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(15)]
        public string ContainerState { get; set; }

        [StringLength(15)]
        public string ReleaseType { get; set; }

        [StringLength(10)]
        public string SSLineCode { get; set; }

        [StringLength(100)]
        public string SSLineName { get; set; }

        [StringLength(25)]
        public string StatusName { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(10)]
        public string ContainerSizeName { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TotalQtyAccptOfRequest { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InboundReqDeclinedQtyId { get; set; }
    }
}
