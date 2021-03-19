namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_EDIPerformanceAudit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UniqueID { get; set; }

        [StringLength(40)]
        public string BookingNumber { get; set; }

        [StringLength(10)]
        public string SSLineCode { get; set; }

        [StringLength(50)]
        public string SSLineName { get; set; }

        [StringLength(11)]
        public string ContainerNumber { get; set; }

        public DateTime? GateDate { get; set; }

        public DateTime? EDIDate { get; set; }

        [StringLength(10)]
        public string GateMode { get; set; }

        public DateTime? ConfHandShakeDateTime { get; set; }

        public DateTime? RequestDate { get; set; }

        [Column("Input Source")]
        [StringLength(80)]
        public string Input_Source { get; set; }
    }
}
