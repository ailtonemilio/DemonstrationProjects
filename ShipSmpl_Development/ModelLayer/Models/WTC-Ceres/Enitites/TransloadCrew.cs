namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransloadCrew")]
    public partial class TransloadCrew
    {
        public int TransloadCrewID { get; set; }

        public int? TransloadID { get; set; }

        public int? CrewID { get; set; }

        [StringLength(50)]
        public string CrewName { get; set; }
    }
}
