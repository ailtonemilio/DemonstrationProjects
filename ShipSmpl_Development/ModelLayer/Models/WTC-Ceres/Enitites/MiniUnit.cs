namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MiniUnit")]
    public partial class MiniUnit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MiniUnit()
        {
            GrainInventory = new HashSet<GrainInventory>();
            MinibookingMiniUnitAssignment = new HashSet<MinibookingMiniUnitAssignment>();
        }

        public int MiniUnitId { get; set; }

        public int? MiniUnitOrder { get; set; }

        public int? UnitSourceId { get; set; }

        public decimal? TotalBilled { get; set; }

        public decimal? UnBilled { get; set; }

        public decimal? BilledByUnit { get; set; }

        [StringLength(2)]
        public string BilledByUnitUnitType { get; set; }

        public decimal? UnBilledByUnit { get; set; }

        [StringLength(2)]
        public string UnBilledByUnitUnitType { get; set; }

        [StringLength(250)]
        public string MULocation { get; set; }

        [StringLength(500)]
        public string Comments { get; set; }

        public int CustomerId { get; set; }

        public int GradeId { get; set; }

        public int CommodityId { get; set; }

        public bool? BalanceToStorageAllowed { get; set; }

        public bool isMultiMU { get; set; }

        [StringLength(150)]
        public string LotNumber { get; set; }

        public virtual Commodity Commodity { get; set; }

        public virtual Company Company { get; set; }

        public virtual Grade Grade { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GrainInventory> GrainInventory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MinibookingMiniUnitAssignment> MinibookingMiniUnitAssignment { get; set; }

        public virtual UnitSource UnitSource { get; set; }
    }
}
