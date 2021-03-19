using System;

namespace ModelLayer.CustomModel
{
    public class EmployeeWorking
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string SiteLocation { get; set; }
        public Nullable<System.DateTime> StartTimeDate { get; set; }
        public string Supervisor { get; set; }
    }
}
