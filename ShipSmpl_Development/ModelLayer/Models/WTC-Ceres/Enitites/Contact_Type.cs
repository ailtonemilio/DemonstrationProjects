namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contact Type")]
    public partial class Contact_Type
    {
        [Key]
        [StringLength(100)]
        public string department { get; set; }
    }
}
