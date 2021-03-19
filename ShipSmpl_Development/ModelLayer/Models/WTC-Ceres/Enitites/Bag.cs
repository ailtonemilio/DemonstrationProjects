namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bag")]
    public partial class Bag
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bag()
        {
            BagInventory = new HashSet<BagInventory>();
            GrainInventory = new HashSet<GrainInventory>();
        }

        public int BagId { get; set; }

        public int ColorId { get; set; }

        public int BagSizeId { get; set; }

        public int BagWeightId { get; set; }

        public int BagLogoId { get; set; }

        [Required]
        [StringLength(10)]
        public string ColorType { get; set; }

        [StringLength(300)]
        public string BagDescription { get; set; }

        public virtual BagLogo BagLogo { get; set; }

        public virtual BagSize BagSize { get; set; }

        public virtual BagWeight BagWeight { get; set; }

        public virtual ColorList ColorList { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BagInventory> BagInventory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GrainInventory> GrainInventory { get; set; }
    }
}
