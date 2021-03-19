namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FSC_Rate
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(5)]
        public string Rate_Name { get; set; }

        public double? Rate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? From_Date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? To_Date { get; set; }
    }
}
