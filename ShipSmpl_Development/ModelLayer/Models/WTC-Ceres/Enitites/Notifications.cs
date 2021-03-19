namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Notifications
    {
        [Key]
        [Column("Notification ID")]
        public int Notification_ID { get; set; }

        [Column("Notification Type")]
        [StringLength(2)]
        public string Notification_Type { get; set; }

        [Column("Notification Date/Time")]
        public DateTime? Notification_Date_Time { get; set; }

        [Column("Notification Details")]
        [StringLength(255)]
        public string Notification_Details { get; set; }

        [Column("Notification Read")]
        public bool? Notification_Read { get; set; }
    }
}
