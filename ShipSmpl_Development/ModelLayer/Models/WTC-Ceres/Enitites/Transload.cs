namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Transload")]
    public partial class Transload
    {
        public int TransloadID { get; set; }

        public int? BookingID { get; set; }

        public int? MiniBookingID { get; set; }

        public int? BookServiceID { get; set; }

        public int? UnitSourceID { get; set; }

        public int? MiniUnitID { get; set; }

        public int? ContainerID { get; set; }

        public DateTime? PackedDate { get; set; }

        [StringLength(50)]
        public string Commodity { get; set; }

        [StringLength(50)]
        public string LotNumber { get; set; }

        public int? NumberOfBags { get; set; }

        public double? LoadedMT { get; set; }
    }
}
