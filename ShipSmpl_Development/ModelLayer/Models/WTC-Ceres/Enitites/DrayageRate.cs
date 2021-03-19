namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DrayageRate")]
    public partial class DrayageRate
    {
        public int DrayageRateId { get; set; }

        public int? DrayageSchemeId { get; set; }

        [StringLength(15)]
        public string RateType { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FromDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ToDate { get; set; }

        public decimal? Rate { get; set; }

        public virtual DrayageScheme DrayageScheme { get; set; }
    }
}
