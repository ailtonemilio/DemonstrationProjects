namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_InventoryBagLocation
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BagLocationId { get; set; }

        public int? BagInventoryId { get; set; }

        public int? StorageId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StorageTypeId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BagQuantity { get; set; }

        [StringLength(30)]
        public string StorageTypeName { get; set; }

        [StringLength(30)]
        public string LocationStorageName { get; set; }

        public int? YardLocationId { get; set; }

        [StringLength(50)]
        public string YardLocationName { get; set; }

        [StringLength(30)]
        public string LocationTag { get; set; }
    }
}
