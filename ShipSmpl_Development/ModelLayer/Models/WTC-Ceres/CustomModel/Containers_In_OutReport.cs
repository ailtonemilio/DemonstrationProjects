using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ModelLayer.CustomModel
{
    public class Containers_In_OutReport
    {
        public string Booking_Number { get; set; }
        public string SS_Line_Code_In { get; set; }
        public string SS_Line_Name_In { get; set; }
        public string Container_Number { get; set; }
        public string Gate_Date_In { get; set; }
        public string Gate_EDI_Date { get; set; }
        public string Gate_Type { get; set; }
        public string RequestDate { get; set; }
        public string InputSource { get; set; }
        public string AVG_Delay { get; set; }
        public int EDIHour { get; set; }
        public int EDIMinute { get; set; }
        public int EDISecond { get; set; }
        public int EDITotSecond { get; set; }
    }
}
