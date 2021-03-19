namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GrainInventoryTransaction")]
    public partial class GrainInventoryTransaction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GrainInventoryTransaction()
        {
            GrainInventoryTransfer = new HashSet<GrainInventoryTransfer>();
            GrainInvMinibookingTransaction = new HashSet<GrainInvMinibookingTransaction>();
            GrainInvTransactionGrainStorageLocation = new HashSet<GrainInvTransactionGrainStorageLocation>();
        }

        public int GrainInventoryTransactionId { get; set; }

        public int GrainInventoryId { get; set; }

        public int TransactionTypeId { get; set; }

        public double Quantity { get; set; }

        public DateTime? CreatedAt { get; set; }

        public virtual GrainInventory GrainInventory { get; set; }

        public virtual TransactionType TransactionType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GrainInventoryTransfer> GrainInventoryTransfer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GrainInvMinibookingTransaction> GrainInvMinibookingTransaction { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GrainInvTransactionGrainStorageLocation> GrainInvTransactionGrainStorageLocation { get; set; }
    }
}
