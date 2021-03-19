namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TruckDriver")]
    public partial class TruckDriver
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TruckDriver()
        {
            TruckDriverCompany = new HashSet<TruckDriverCompany>();
        }

        public int TruckDriverId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<bool> SuspendTruckDriver { get; set; }
        public string PortPassId { get; set; }
        public string TruckNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TruckDriverCompany> TruckDriverCompany { get; set; }
    }
}