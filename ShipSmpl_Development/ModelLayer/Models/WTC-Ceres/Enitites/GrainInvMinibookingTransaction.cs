namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GrainInvMinibookingTransaction")]
    public partial class GrainInvMinibookingTransaction
    {
        public int GrainInvMinibookingTransactionId { get; set; }

        public int MinibookingId { get; set; }

        public int GrainInventoryTransactionId { get; set; }

        public virtual GrainInventoryTransaction GrainInventoryTransaction { get; set; }

        public virtual Minibooking Minibooking { get; set; }
    }
}
