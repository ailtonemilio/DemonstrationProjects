namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DrayageScheme")]
    public partial class DrayageScheme
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DrayageScheme()
        {
            DrayageRate = new HashSet<DrayageRate>();
        }

        public int DrayageSchemeId { get; set; }

        public int TruckingCompanyId { get; set; }

        public int FromDockId { get; set; }

        public int ToDockId { get; set; }

        public virtual Company Company { get; set; }

        public virtual Company Company1 { get; set; }

        public virtual Company Company2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DrayageRate> DrayageRate { get; set; }
    }
}
