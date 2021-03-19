namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RelOrderPickUpDropOffLocation")]
    public partial class RelOrderPickUpDropOffLocation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RelOrderPickUpDropOffLocation()
        {
            ReleaseDistributionRequest = new HashSet<ReleaseDistributionRequest>();
        }

        public int RelOrderPickUpDropOffLocationId { get; set; }

        public int ReleaseOrderId { get; set; }

        public int PickUpTerminalId { get; set; }

        public int DropOffYardLocationId { get; set; }

        public int QtyPickUpDropOff { get; set; }

        public virtual Company Company { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReleaseDistributionRequest> ReleaseDistributionRequest { get; set; }

        public virtual ReleaseOrder ReleaseOrder { get; set; }

        public virtual YardLocation YardLocation { get; set; }
    }
}
