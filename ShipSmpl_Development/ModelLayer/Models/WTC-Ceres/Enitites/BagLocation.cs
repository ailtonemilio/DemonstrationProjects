namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BagLocation")]
    public partial class BagLocation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BagLocation()
        {
            BagInventoryTransaction = new HashSet<BagInventoryTransaction>();
        }

        public int BagLocationId { get; set; }

        public int? BagInventoryId { get; set; }

        [StringLength(30)]
        public string LocationName { get; set; }

        public int? StorageId { get; set; }

        public int StorageTypeId { get; set; }

        public int BagQuantity { get; set; }

        public virtual BagInventory BagInventory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BagInventoryTransaction> BagInventoryTransaction { get; set; }

        public virtual StorageType StorageType { get; set; }
    }
}
