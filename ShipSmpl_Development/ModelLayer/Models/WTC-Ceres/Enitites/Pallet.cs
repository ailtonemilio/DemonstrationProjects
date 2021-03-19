namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pallet")]
    public partial class Pallet
    {
        public int PalletId { get; set; }

        [StringLength(30)]
        public string PalletName { get; set; }

        public int YardLocationId { get; set; }

        public virtual YardLocation YardLocation { get; set; }
    }
}
