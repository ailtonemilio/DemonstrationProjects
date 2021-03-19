namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_ReleaseDistributionRequest
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReleaseDistributionRequestId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RelOrderPickUpDropOffLocationId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CarrierId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RequestStatusId { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QtyRequested { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "smalldatetime")]
        public DateTime RequestDate { get; set; }

        [StringLength(40)]
        public string ReleaseNumber { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReleaseId { get; set; }

        [StringLength(30)]
        public string ReleaseType { get; set; }

        [StringLength(10)]
        public string CarrierCode { get; set; }

        [StringLength(100)]
        public string CarrierName { get; set; }

        [StringLength(10)]
        public string PickUpTerminalCode { get; set; }

        [StringLength(100)]
        public string PickUpTerminalName { get; set; }

        [StringLength(50)]
        public string YardName { get; set; }

        [StringLength(100)]
        public string YardAddress { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PickUpTerminalId { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DropOffYardLocationId { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(20)]
        public string StatusName { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool IsOpenRequest { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(11)]
        public string msg { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TotalAcceptedOfRequest { get; set; }
    }
}
