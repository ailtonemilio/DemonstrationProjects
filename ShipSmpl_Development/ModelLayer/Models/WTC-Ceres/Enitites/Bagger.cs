namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bagger")]
    public partial class Bagger
    {
        public int BaggerId { get; set; }

        [StringLength(20)]
        public string BaggerName { get; set; }

        public int YardLocationId { get; set; }

        public virtual YardLocation YardLocation { get; set; }
    }
}
