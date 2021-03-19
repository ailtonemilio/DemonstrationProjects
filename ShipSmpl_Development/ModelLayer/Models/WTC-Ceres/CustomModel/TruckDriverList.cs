using System;
using System.Collections.Generic;

namespace ModelLayer.CustomModel
{
    public partial class TruckDriverList
    {
        public TruckDriverList()
        {
        }

        public TruckDriverList(int TruckDriverId, string PortPassId, string FirstName, string LastName, string FullName, string TruckNumber, bool SuspendTruckDriver, int CompanyId, string CompanyCode, string CompanyName, int TruckDriverCompanyId)
        {
            this.TruckDriverId = TruckDriverId;
            this.PortPassId = PortPassId;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.FullName = FullName;
            this.TruckNumber = TruckNumber;
            this.SuspendTruckDriver = SuspendTruckDriver;
            this.CompanyId = CompanyId;
            this.CompanyCode = CompanyCode;
            this.CompanyName = CompanyName;
            this.TruckDriverCompanyId = TruckDriverCompanyId;
        }

        //Truck Driver
        public int TruckDriverId { get; set; }

        public string PortPassId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string TruckNumber { get; set; }
        public Nullable<bool> SuspendTruckDriver { get; set; }

        //Company
        public int CompanyId { get; set; }

        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }

        //Truck Driver Company
        public int TruckDriverCompanyId { get; set; }
    }
}