namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CargoType")]
    public partial class CargoType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CargoType()
        {
            UnitSource = new HashSet<UnitSource>();
        }

        public int CargoTypeId { get; set; }

        [StringLength(6)]
        public string CargoTypeCode { get; set; }

        [StringLength(10)]
        public string CargoTypeName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UnitSource> UnitSource { get; set; }
    }
}
