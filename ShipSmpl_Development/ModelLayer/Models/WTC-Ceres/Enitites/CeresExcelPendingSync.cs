namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CeresExcelPendingSync")]
    public partial class CeresExcelPendingSync
    {
        public int CeresExcelPendingSyncId { get; set; }

        public int RecordId { get; set; }

        public int EmployeeId { get; set; }

        [Required]
        [StringLength(60)]
        public string SyncType { get; set; }

        [StringLength(100)]
        public string ExtraInfo { get; set; }

        [Required]
        [StringLength(30)]
        public string CurrentStatus { get; set; }

        public int? QtyOfAttempts { get; set; }

        [Required]
        [StringLength(200)]
        public string SyncMessage { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
