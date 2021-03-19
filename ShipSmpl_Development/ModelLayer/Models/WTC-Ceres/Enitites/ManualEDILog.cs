namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ManualEDILog")]
    public partial class ManualEDILog
    {
        [Key]
        public int ManEDIId { get; set; }

        public int? EDIRecordID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EDIModDateTime { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EDIOriginalDateTime { get; set; }

        public virtual EDI_Records EDI_Records { get; set; }
    }
}
