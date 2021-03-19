namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_CeresExcelPendingSyncBooking
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CeresExcelPendingSyncId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RecordId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeId { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(60)]
        public string SyncType { get; set; }

        [StringLength(100)]
        public string ExtraInfo { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(30)]
        public string CurrentStatus { get; set; }

        public int? QtyOfAttempts { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(200)]
        public string SyncMessage { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime CreatedAt { get; set; }

        [StringLength(40)]
        public string MinibookingNumber { get; set; }
    }
}
