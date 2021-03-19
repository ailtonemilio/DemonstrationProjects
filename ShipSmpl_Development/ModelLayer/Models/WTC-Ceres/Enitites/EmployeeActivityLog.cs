namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeActivityLog")]
    public partial class EmployeeActivityLog
    {
        public int EmployeeActivityLogId { get; set; }

        public int EmployeeId { get; set; }

        [StringLength(50)]
        public string RecordModified { get; set; }

        [StringLength(15)]
        public string ActionTaken { get; set; }

        [StringLength(25)]
        public string ModuleName { get; set; }

        [Column(TypeName = "text")]
        public string Detail { get; set; }

        public DateTime? CreatedAt { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
