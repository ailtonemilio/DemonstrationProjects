namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Rail List")]
    public partial class Rail_List
    {
        [Key]
        [Column("Record Key")]
        public int Record_Key { get; set; }

        [Column("Trip ID")]
        public int? Trip_ID { get; set; }

        [Column("Unit Number")]
        [StringLength(10)]
        public string Unit_Number { get; set; }

        [Column("Sighting Location")]
        [StringLength(13)]
        public string Sighting_Location { get; set; }

        [Column("Sighting DateTime")]
        [StringLength(7)]
        public string Sighting_DateTime { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Sighting_Date_Time { get; set; }

        [Column("Carrier ID")]
        [StringLength(6)]
        public string Carrier_ID { get; set; }

        [Column("Destination Location")]
        [StringLength(13)]
        public string Destination_Location { get; set; }

        [StringLength(4)]
        public string SASC { get; set; }

        [Column("ETA Location")]
        [StringLength(13)]
        public string ETA_Location { get; set; }

        [Column("ETA DateTime")]
        [Required]
        [StringLength(7)]
        public string ETA_DateTime { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ETA_Date_Time { get; set; }

        [Column("Consignee Name")]
        [StringLength(35)]
        public string Consignee_Name { get; set; }

        [Column("Shipper Name")]
        [StringLength(35)]
        public string Shipper_Name { get; set; }

        [Column("Way Bill Date", TypeName = "date")]
        public DateTime? Way_Bill_Date { get; set; }

        [Column("Way Bill Carrier")]
        [StringLength(6)]
        public string Way_Bill_Carrier { get; set; }

        [Column("Way Bill Net Wgt")]
        [StringLength(4)]
        public string Way_Bill_Net_Wgt { get; set; }

        [Column("Way_Bill_Net_Wgt")]
        public double? Way_Bill_Net_Wgt1 { get; set; }

        [Column("Way Bill Number")]
        [StringLength(6)]
        public string Way_Bill_Number { get; set; }

        [Column("Origin Location")]
        [StringLength(35)]
        public string Origin_Location { get; set; }

        [Column("EQ Type Code")]
        [StringLength(4)]
        public string EQ_Type_Code { get; set; }

        [Column("Cargo Description")]
        [StringLength(15)]
        public string Cargo_Description { get; set; }

        [Column("Unit Status")]
        [StringLength(2)]
        public string Unit_Status { get; set; }

        [Column("Rail Car Available")]
        public bool? Rail_Car_Available { get; set; }

        [Column("Rail Car Available Date", TypeName = "date")]
        public DateTime? Rail_Car_Available_Date { get; set; }

        [Column("Rail Car Called")]
        public bool? Rail_Car_Called { get; set; }

        [Column("Rail Car Called Date", TypeName = "date")]
        public DateTime? Rail_Car_Called_Date { get; set; }

        [Column("Rail Car Arrived")]
        public bool? Rail_Car_Arrived { get; set; }

        [Column("Rail Car Arrived Date", TypeName = "date")]
        public DateTime? Rail_Car_Arrived_Date { get; set; }

        [Column("Rail Car Released")]
        public bool? Rail_Car_Released { get; set; }

        [Column("Rail Car Released Date", TypeName = "date")]
        public DateTime? Rail_Car_Released_Date { get; set; }

        [Column("Rail Car Released Notes")]
        [StringLength(255)]
        public string Rail_Car_Released_Notes { get; set; }

        [Column("Booking Numbers", TypeName = "ntext")]
        public string Booking_Numbers { get; set; }

        [Column("Last Updated", TypeName = "date")]
        public DateTime? Last_Updated { get; set; }

        [Column("CLM FIle")]
        [StringLength(50)]
        public string CLM_FIle { get; set; }
    }
}
