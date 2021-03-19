namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_BookingContainerAssignments
    {
        public int? Delivered { get; set; }

        public int? Ready { get; set; }

        public int? Assigned { get; set; }

        [Key]
        [Column("Booking Type", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Booking_Type { get; set; }

        [Key]
        [Column("Booking Service", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Booking_Service { get; set; }

        public bool? ActiveBooking { get; set; }

        [Column("Split Booking")]
        public bool? Split_Booking { get; set; }

        [Column("Customer Name")]
        [StringLength(100)]
        public string Customer_Name { get; set; }

        [Column("Forwarder Name")]
        [StringLength(100)]
        public string Forwarder_Name { get; set; }

        [Column("SS Line Code")]
        [StringLength(10)]
        public string SS_Line_Code { get; set; }

        [Column("Terminal Name")]
        [StringLength(100)]
        public string Terminal_Name { get; set; }

        [Column("Vessel Name")]
        public string Vessel_Name { get; set; }

        [Column("Destination City Name")]
        [StringLength(188)]
        public string Destination_City_Name { get; set; }

        [StringLength(4000)]
        public string ERD { get; set; }

        [StringLength(4000)]
        public string LRD { get; set; }

        [Key]
        [Column("Number Of Cans", Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Number_Of_Cans { get; set; }

        [Key]
        [Column("Booking Number", Order = 3)]
        [StringLength(40)]
        public string Booking_Number { get; set; }
    }
}
