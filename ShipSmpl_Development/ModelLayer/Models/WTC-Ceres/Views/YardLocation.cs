namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("YardLocation")]
    public partial class YardLocation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public YardLocation()
        {
            Bagger = new HashSet<Bagger>();
            Container = new HashSet<Container>();
            Pallet = new HashSet<Pallet>();
            RelOrderPickUpDropOffLocation = new HashSet<RelOrderPickUpDropOffLocation>();
        }

        public int YardLocationId { get; set; }

        [StringLength(50)]
        public string YardName { get; set; }

        [StringLength(100)]
        public string YardAddress { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bagger> Bagger { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Container> Container { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pallet> Pallet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RelOrderPickUpDropOffLocation> RelOrderPickUpDropOffLocation { get; set; }
    }
}
