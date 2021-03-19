namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BookingBagAssignment")]
    public partial class BookingBagAssignment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BookingBagAssignment()
        {
            BookingBagUsage = new HashSet<BookingBagUsage>();
        }

        public int BookingBagAssignmentId { get; set; }

        public int BagInventoryId { get; set; }

        public int MinibookingId { get; set; }

        public DateTime? CreatedAt { get; set; }

        public virtual BagInventory BagInventory { get; set; }

        public virtual Minibooking Minibooking { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingBagUsage> BookingBagUsage { get; set; }
    }
}
