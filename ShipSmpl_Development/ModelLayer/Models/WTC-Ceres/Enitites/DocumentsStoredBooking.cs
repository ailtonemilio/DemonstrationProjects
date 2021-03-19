namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentsStoredBooking")]
    public partial class DocumentsStoredBooking
    {
        public int DocumentsStoredBookingId { get; set; }

        [StringLength(50)]
        public string BookingNumber { get; set; }

        public int DocumentsStoredId { get; set; }

        public virtual DocumentsStored DocumentsStored { get; set; }
    }
}
