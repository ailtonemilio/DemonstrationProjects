namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BagInventoryTransaction")]
    public partial class BagInventoryTransaction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BagInventoryTransaction()
        {
            BookingBagUsage = new HashSet<BookingBagUsage>();
        }

        public int BagInventoryTransactionId { get; set; }

        public int Quantity { get; set; }

        public DateTime? TransactionDate { get; set; }

        public int TransactionTypeId { get; set; }

        public int? BagLocationId { get; set; }

        public virtual BagLocation BagLocation { get; set; }

        public virtual TransactionType TransactionType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingBagUsage> BookingBagUsage { get; set; }
    }
}
