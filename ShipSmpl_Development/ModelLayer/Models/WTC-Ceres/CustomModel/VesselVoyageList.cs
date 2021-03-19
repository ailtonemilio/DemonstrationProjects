using System;
using System.Collections.Generic;

namespace ModelLayer.CustomModel
{
    public partial class VesselVoyageList
    {
        public VesselVoyageList() { }

        public VesselVoyageList(int VesselVoyageId, string VoyageNumber, DateTime ERD, DateTime LRD, DateTime ETA, DateTime ETD, DateTime LRDDateTime, string PortCity, string PortCountry,
            bool IsActiveTrip, int VesselId, int PortId, int VesselVoyageStatusId, string VesselName, string StatusName, string CompanyCodeName, string CompanyCode, string CompanyName)
        {
            this.VesselVoyageId = VesselVoyageId;
            this.VoyageNumber = VoyageNumber;
            this.ERD = ERD;
            this.LRD = LRD;
            this.ETA = ETA;
            this.ETD = ETD;
            this.LRDDateTime = LRDDateTime;
            this.PortCity = PortCity;
            this.PortCountry = PortCountry;
            this.IsActiveTrip = IsActiveTrip;
            this.VesselId = VesselId;
            this.PortId = PortId;
            this.VesselVoyageStatusId = VesselVoyageStatusId;
            this.VesselName = VesselName;
            this.StatusName = StatusName;
            this.CompanyCodeName = CompanyCodeName;
            this.CompanyCode = CompanyCode;
            this.CompanyName = CompanyName;
        }
        
        
        //Vessel Voyage
        public int VesselVoyageId { get; set; }

        public string VoyageNumber { get; set; }
        public Nullable<DateTime> ERD { get; set; }
        public Nullable<DateTime> LRD { get; set; }
        public Nullable<DateTime> LRDDateTime { get; set; }
        public Nullable<DateTime> ETA { get; set; }
        public Nullable<DateTime> ETD { get; set; }
        public string PortCity { get; set; }
        public string PortCountry { get; set; }
        public Nullable<bool> IsActiveTrip { get; set; }
        public Nullable<int> VesselId { get; set; }
        public Nullable<int> PortId { get; set; }
        public Nullable<int> VesselVoyageStatusId { get; set; }

        //Vessel
        public string VesselName { get; set; }

        //VesselVoyageStatus
        public string StatusName { get; set; }

        //Company
        public string CompanyCodeName { get; set; }

        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
    }
}