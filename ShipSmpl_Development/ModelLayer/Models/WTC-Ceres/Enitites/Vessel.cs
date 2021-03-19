namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vessel")]
    public partial class Vessel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vessel()
        {
            VesselVoyage = new HashSet<VesselVoyage>();
        }

        public Vessel(int VesselId, string VesselName, string VesselOwner, string Manager, decimal Capacity, int VesselYear, string Flag, bool IsActiveVessel)
        {
            this.VesselId = VesselId;
            this.VesselName = VesselName;
            this.VesselOwner = VesselOwner;
            this.Manager = Manager;
            this.Capacity = Capacity;
            this.VesselYear = VesselYear;
            this.Flag = Flag;
            this.IsActiveVessel = IsActiveVessel;
        }

        public int VesselId { get; set; }

        public string VesselName { get; set; }

        public string VesselOwner { get; set; }

        public string Manager { get; set; }

        public decimal? Capacity { get; set; }

        public int? VesselYear { get; set; }

        [StringLength(50)]
        public string Flag { get; set; }

        public bool? IsActiveVessel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VesselVoyage> VesselVoyage { get; set; }
    }
}