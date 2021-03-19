namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BagLogo")]
    public partial class BagLogo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BagLogo()
        {
            Bag = new HashSet<Bag>();
        }

        public int BagLogoId { get; set; }

        [StringLength(4)]
        public string BagYear { get; set; }

        [StringLength(200)]
        public string LogoDescription { get; set; }

        [StringLength(200)]
        public string ImagePath { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bag> Bag { get; set; }
    }
}
