namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TimeSheet")]
    public partial class TimeSheet
    {
        public int TimeSheetId { get; set; }

        public DateTime? StartTimeDate { get; set; }

        public DateTime? EndTimeDate { get; set; }

        [StringLength(10)]
        public string PunchType { get; set; }

        [StringLength(20)]
        public string DeviceName { get; set; }

        [StringLength(15)]
        public string SiteLocation { get; set; }

        [StringLength(25)]
        public string DeviceIPAddress { get; set; }

        public int? EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
