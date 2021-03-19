namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Yard Locations")]
    public partial class Yard_Locations
    {
        [Key]
        [StringLength(20)]
        public string LOCATION { get; set; }

        [StringLength(40)]
        public string DESCRIPTION { get; set; }

        [StringLength(65)]
        public string ADDR { get; set; }

        [StringLength(20)]
        public string CITY { get; set; }

        [StringLength(10)]
        public string EDICODE { get; set; }
    }
}
