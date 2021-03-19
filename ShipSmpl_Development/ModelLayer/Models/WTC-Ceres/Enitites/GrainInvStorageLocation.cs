namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GrainInvStorageLocation")]
    public partial class GrainInvStorageLocation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GrainInvStorageLocation()
        {
            GrainInvMinibookingAssignment = new HashSet<GrainInvMinibookingAssignment>();
            GrainInvTransactionGrainStorageLocation = new HashSet<GrainInvTransactionGrainStorageLocation>();
        }

        public int GrainInvStorageLocationId { get; set; }

        public int GrainInventoryId { get; set; }

        public int StorageTypeId { get; set; }

        public int StorageId { get; set; }

        public double Quantity { get; set; }

        public DateTime? StorageDate { get; set; }

        public virtual GrainInventory GrainInventory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GrainInvMinibookingAssignment> GrainInvMinibookingAssignment { get; set; }

        public virtual StorageType StorageType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GrainInvTransactionGrainStorageLocation> GrainInvTransactionGrainStorageLocation { get; set; }
    }
}
