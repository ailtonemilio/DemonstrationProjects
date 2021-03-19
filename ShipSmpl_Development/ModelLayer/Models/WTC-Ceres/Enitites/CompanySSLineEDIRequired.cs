namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanySSLineEDIRequired")]
    public partial class CompanySSLineEDIRequired
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CompanyId { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool EDIRequired { get; set; }

        public virtual Company Company { get; set; }

        public virtual Company Company1 { get; set; }
    }
}
