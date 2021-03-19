namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_ExcelHarvesterPushRequest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RecordID { get; set; }

        public int? MiniBookingID { get; set; }

        [StringLength(43)]
        public string MinibookingNumber { get; set; }

        [StringLength(20)]
        public string Action { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ActionDateTime { get; set; }
    }
}
