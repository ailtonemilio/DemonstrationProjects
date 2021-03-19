namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UnitSourceActiveUpdate")]
    public partial class UnitSourceActiveUpdate
    {
        public int UnitSourceActiveUpdateId { get; set; }

        [Required]
        [StringLength(20)]
        public string Field { get; set; }

        public int? MiniUnitId { get; set; }

        public int? UnitSourceId { get; set; }

        public virtual UnitSource UnitSource { get; set; }
    }
}
