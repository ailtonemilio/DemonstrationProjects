namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_RelDistChangeReqSchedule
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

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QtyRequestedSchedule { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RequestStatusSchId { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(20)]
        public string StatusNameSch { get; set; }

        [Key]
        [Column(Order = 16, TypeName = "smalldatetime")]
        public DateTime FromDate { get; set; }

        [Key]
        [Column(Order = 17, TypeName = "smalldatetime")]
        public DateTime ToDate { get; set; }

        [Key]
        [Column(Order = 18, TypeName = "smalldatetime")]
        public DateTime DateRequested { get; set; }

        [Key]
        [Column(Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RelDistRequestScheduleId { get; set; }

        [Key]
        [Column(Order = 20)]
        [StringLength(20)]
        public string StatusNameChange { get; set; }

        [Key]
        [Column(Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RelDistChangeReqScheduleId { get; set; }

        [Key]
        [Column(Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QtyProposed { get; set; }

        [Key]
        [Column(Order = 23, TypeName = "smalldatetime")]
        public DateTime FromDateChange { get; set; }

        [Key]
        [Column(Order = 24, TypeName = "smalldatetime")]
        public DateTime ToDateChange { get; set; }

        [Key]
        [Column(Order = 25, TypeName = "smalldatetime")]
        public DateTime DateRequestedChange { get; set; }
    }
}
