namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BagWeight")]
    public partial class BagWeight
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BagWeight()
        {
            Bag = new HashSet<Bag>();
        }

        public int BagWeightId { get; set; }

        [StringLength(4)]
        public string BagWeightName { get; set; }

        [StringLength(2)]
        public string BagUnit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bag> Bag { get; set; }
    }
}
