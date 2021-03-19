namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TEF_Rate
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(10)]
        public string RateType { get; set; }

        public TimeSpan? WkDaydCutOffTime { get; set; }

        public decimal? WkDaysDayRate { get; set; }

        public decimal? WkDaysNightRate { get; set; }

        public TimeSpan? WkEndsCutOffTime { get; set; }

        public decimal? WkEndsDayRate { get; set; }

        public decimal? WkEndsNightRate { get; set; }

        [StringLength(60)]
        public string Terminal { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FromDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ToDate { get; set; }
    }
}
