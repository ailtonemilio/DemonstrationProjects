namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_InboundReport
    {
        [Key]
        [Column(Order = 0, TypeName = "smalldatetime")]
        public DateTime FromDate { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "smalldatetime")]
        public DateTime ToDate { get; set; }

        [StringLength(100)]
        public string CarrierName { get; set; }

        [StringLength(40)]
        public string ReleaseNumber { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReleaseId { get; set; }

        [StringLength(100)]
        public string PickUpTerminalName { get; set; }

        [StringLength(50)]
        public string DropOff { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QtyAccepted { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TotalIngated { get; set; }

        [StringLength(9)]
        public string DlvStatus { get; set; }

        [StringLength(36)]
        public string TotalIngAndPercent { get; set; }
    }
}
