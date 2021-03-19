namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_EmployeeActivityLog
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeActivityLogId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
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

        [StringLength(30)]
        public string AliasName { get; set; }
    }
}
