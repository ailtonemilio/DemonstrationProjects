namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_ReleaseOrder
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QtyAcceptedInOrder { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateAccepted { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReleaseOrderId { get; set; }

        [StringLength(40)]
        public string ReleaseNumber { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReleaseId { get; set; }

        [StringLength(10)]
        public string SSLineCOde { get; set; }

        [StringLength(100)]
        public string SSLineName { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ShippingLineId { get; set; }

        [StringLength(30)]
        public string ReleaseType { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QtyRequested { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InboundRequestId { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool isOpenRequest { get; set; }

        [StringLength(4000)]
        public string RelOrder { get; set; }
    }
}
