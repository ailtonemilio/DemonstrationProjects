namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_RelDistReqSchRelDistSchAccpt
    {
        [StringLength(40)]
        public string ReleaseNumber { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QtyRequested { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "smalldatetime")]
        public DateTime FromDateReq { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "smalldatetime")]
        public DateTime ToDateReq { get; set; }

        public int? QtyAccepted { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FromDateAcpt { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ToDateAcpt { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateAccepted { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string StatusNameSch { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RequestStatusSchId { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReleaseDistributionRequestId { get; set; }
    }
}
