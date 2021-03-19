namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Time_Sheet
    {
        public int ID { get; set; }

        public int? UserID { get; set; }

        public DateTime? Start_Time_Date { get; set; }

        public DateTime? End_Time_Date { get; set; }

        [StringLength(10)]
        public string Punch_Type { get; set; }

        [StringLength(20)]
        public string Device_Name { get; set; }

        [StringLength(15)]
        public string Site_Location { get; set; }

        [StringLength(25)]
        public string Device_IP_Address { get; set; }
    }
}
