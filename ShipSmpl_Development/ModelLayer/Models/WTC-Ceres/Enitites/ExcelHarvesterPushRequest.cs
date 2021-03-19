namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExcelHarvesterPushRequest")]
    public partial class ExcelHarvesterPushRequest
    {
        [Key]
        public int RecordID { get; set; }

        public int? MiniBookingID { get; set; }

        [StringLength(50)]
        public string MiniBookingNumber { get; set; }

        public int? ContainerID { get; set; }

        [StringLength(11)]
        public string ContainerNumber { get; set; }

        [StringLength(20)]
        public string Action { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ActionDateTime { get; set; }
    }
}
