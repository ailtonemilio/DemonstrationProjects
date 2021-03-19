namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_ReleaseOrderMinibooking
    {
        [StringLength(40)]
        public string ReleaseNumber { get; set; }

        [StringLength(30)]
        public string ReleaseType { get; set; }

        [StringLength(43)]
        public string MinibookingNumber { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(40)]
        public string BookingNumber { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QtyAcceptedInOrder { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateAccepted { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReleaseOrderId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReleaseId { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MinibookingId { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReleaseOrderMinibookingId { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QtyRequestedMb { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AssignmentOrder { get; set; }
    }
}
