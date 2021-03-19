namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ContainerImages
    {
        [Key]
        public int ContainerImageID { get; set; }

        public int? ContainerID { get; set; }

        [StringLength(20)]
        public string ImageType { get; set; }

        [StringLength(50)]
        public string ImageFileName { get; set; }

        public DateTime? LastUpdate { get; set; }
    }
}
