namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GrainInventoryTransfer")]
    public partial class GrainInventoryTransfer
    {
        public int GrainInventoryTransferId { get; set; }

        public int GiverGrainInventoryId { get; set; }

        public int ReceiverGrainInventoryId { get; set; }

        public int GrainInventoryTransactionId { get; set; }

        public virtual GrainInventory GrainInventory { get; set; }

        public virtual GrainInventory GrainInventory1 { get; set; }

        public virtual GrainInventoryTransaction GrainInventoryTransaction { get; set; }
    }
}
