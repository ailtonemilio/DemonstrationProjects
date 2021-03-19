namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_ActiveCarrierBookings
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BookingId { get; set; }

        [Key]
        [Column("Booking Number", Order = 1)]
        [StringLength(40)]
        public string Booking_Number { get; set; }

        [Key]
        [Column("Total Containers In Booking", Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Total_Containers_In_Booking { get; set; }

        [Column("Mini Booking Order")]
        public int? Mini_Booking_Order { get; set; }

        [Column("Number Of Containers")]
        public int? Number_Of_Containers { get; set; }

        [Column("Carrier ID")]
        [StringLength(10)]
        public string Carrier_ID { get; set; }

        [Column("Carrier Name")]
        [StringLength(100)]
        public string Carrier_Name { get; set; }

        [Column("Terminal Code")]
        [StringLength(10)]
        public string Terminal_Code { get; set; }

        public DateTime? LRD { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MiniBookingId { get; set; }
    }
}