namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Safety_and_Risk_Management_Clearance
    {
        public int ID { get; set; }

        public int? userID { get; set; }

        public bool? Worked_Hours { get; set; }

        public bool? Document_Storage { get; set; }
    }
}
