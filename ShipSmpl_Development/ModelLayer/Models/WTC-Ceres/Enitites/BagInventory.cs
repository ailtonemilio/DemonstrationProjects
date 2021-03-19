namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BagInventory")]
    public partial class BagInventory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BagInventory()
        {
            BagLocation = new HashSet<BagLocation>();
            BookingBagAssignment = new HashSet<BookingBagAssignment>();
        }

        public int BagInventoryId { get; set; }

        public int ShipperId { get; set; }

        public int BagId { get; set; }

        public int InitialQuantity { get; set; }

        public DateTime? StorageDate { get; set; }

        public bool ActiveBag { get; set; }

        public virtual Bag Bag { get; set; }

        public virtual Company Company { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BagLocation> BagLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingBagAssignment> BookingBagAssignment { get; set; }
    }
}
