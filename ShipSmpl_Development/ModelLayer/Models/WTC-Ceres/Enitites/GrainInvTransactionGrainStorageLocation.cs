namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GrainInvTransactionGrainStorageLocation")]
    public partial class GrainInvTransactionGrainStorageLocation
    {
        public int GrainInvTransactionGrainStorageLocationId { get; set; }

        public int GrainInventoryTransactionId { get; set; }

        public int GrainInvStorageLocationId { get; set; }

        public virtual GrainInventoryTransaction GrainInventoryTransaction { get; set; }

        public virtual GrainInvStorageLocation GrainInvStorageLocation { get; set; }
    }
}
