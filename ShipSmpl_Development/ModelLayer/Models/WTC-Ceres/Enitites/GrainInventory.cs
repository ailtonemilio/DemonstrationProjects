namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GrainInventory")]
    public partial class GrainInventory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GrainInventory()
        {
            GrainInventoryTransaction = new HashSet<GrainInventoryTransaction>();
            GrainInventoryTransfer = new HashSet<GrainInventoryTransfer>();
            GrainInventoryTransfer1 = new HashSet<GrainInventoryTransfer>();
            GrainInvStorageLocation = new HashSet<GrainInvStorageLocation>();
        }

        public int GrainInventoryId { get; set; }

        public int CustomerId { get; set; }

        public int MiniUnitId { get; set; }

        public int BagId { get; set; }

        public double InitialQuantity { get; set; }

        public virtual Bag Bag { get; set; }

        public virtual Company Company { get; set; }

        public virtual MiniUnit MiniUnit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GrainInventoryTransaction> GrainInventoryTransaction { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GrainInventoryTransfer> GrainInventoryTransfer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GrainInventoryTransfer> GrainInventoryTransfer1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GrainInvStorageLocation> GrainInvStorageLocation { get; set; }
    }
}
