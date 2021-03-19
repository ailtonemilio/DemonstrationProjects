namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BookingBagUsage")]
    public partial class BookingBagUsage
    {
        public int BookingBagUsageId { get; set; }

        public int BookingBagAssignmentId { get; set; }

        public int BagInventoryTransactionId { get; set; }

        public virtual BagInventoryTransaction BagInventoryTransaction { get; set; }

        public virtual BookingBagAssignment BookingBagAssignment { get; set; }
    }
}
