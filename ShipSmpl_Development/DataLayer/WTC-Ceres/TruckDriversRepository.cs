using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class TruckDriversRepository : ITruckDriversRepository
    {
        private WTCCeresEntities db = new WTCCeresEntities();
        private Truck_Drivers td = new Truck_Drivers();

        public bool Delete(string PortPassID)
        {
            bool isDelete = true;
            try
            {
                td = db.Truck_Drivers.Find(PortPassID);
                db.Truck_Drivers.Remove(td);
                db.SaveChanges();
            }
            catch (Exception)
            {
                isDelete = false;
            }
            return isDelete;
        }

        public List<Truck_Drivers> GetAll()
        {
            var listByDriver = db.Truck_Drivers.OrderBy(t => t.Last_Name);
            return listByDriver.ToList();
        }

        public List<Truck_Drivers> GetByPortPass(string PortPassId)
        {
            var listById = db.Truck_Drivers.Where(t => t.Port_Pass_ID == PortPassId.ToString());
            return listById.ToList();
        }

        public List<Truck_Drivers> GetByTruckId(int TruckId)
        {
            var listById = db.Truck_Drivers.Where(t => t.Truck_Number == TruckId.ToString());

            return listById.ToList();
        }

        //Because of the table structure you cannot use this SqlQuery alternative
        //public List<Truck_Drivers> GetSearch(string PassId, string FirstName, string LastName, string TruckNum, string Company)
        //{
        //    string Query = "select [Port Pass ID] as Port_Pass_ID, [First Name] as First_Name ,[Last Name] as Last_Name, [Truck Company ID] as Truck_Company_ID" +
        //                    ",[Truck Company Name] as Truck_Company_Name, [Truck Number] as Truck_Number, [Suspend Truck Driver] as Suspend_Truck_Driver from [Truck Drivers] as Truck_Drivers ";

        //    if (!String.IsNullOrEmpty(PassId) || !String.IsNullOrEmpty(FirstName) || !String.IsNullOrEmpty(LastName) || !String.IsNullOrEmpty(TruckNum) || !String.IsNullOrEmpty(Company))
        //    {
        //        Query = Query + " where";

        //        if (!String.IsNullOrEmpty(PassId))
        //            Query = Query + " Port_Pass_ID Like '" + PassId + "%' and";

        //        if (!String.IsNullOrEmpty(FirstName))
        //            Query = Query + " [First Name] Like '" + FirstName + "%' and";

        //        if (!String.IsNullOrEmpty(LastName))
        //            Query = Query + " Last_Name Like '" + LastName + "%' and";

        //        if (!String.IsNullOrEmpty(TruckNum))
        //            Query = Query + " Truck_Number Like '" + TruckNum + "%' and";

        //        if (!String.IsNullOrEmpty(Company) && Company != "ALL")
        //            Query = Query + " [Truck_Company_Name] Like '" + Company.Trim() + "%' and";

        //        if (Query.Substring(Query.Length - 3) == "and")
        //            Query = Query.Substring(0, Query.Length - 3);
        //        else
        //            Query = Query.Substring(0, Query.Length - 5);

        //    }
        //    Query = Query + " order by First_Name";
        //    var list = db.Truck_Drivers.SqlQuery(Query);
        //    return list.ToList();
        //}

        public bool Insert(string PortPassId, string FirstName, string LastName, string TruckCompanyCode, string TruckCompanyName, string TruckNumber, bool SuspendyTruckDriver)
        {
            bool isSave = true;
            try
            {
                td.Port_Pass_ID = PortPassId;
                td.First_Name = FirstName;
                td.Last_Name = LastName;
                td.Truck_Company_ID = TruckCompanyCode;
                td.Truck_Company_Name = TruckCompanyName;
                td.Truck_Number = TruckNumber.ToString();
                td.Suspend_Truck_Driver = SuspendyTruckDriver;
                db.Truck_Drivers.Add(td);
                db.SaveChanges();
            }
            catch (Exception)
            {
                isSave = false;
            }
            return isSave;
        }

        public bool Update(string PortPassId, string FirstName, string LastName, string TruckCompanyCode, string TruckCompanyName, string TruckNumber, bool SuspendyTruckDriver)
        {
            bool isSave = true;
            try
            {
                td = db.Truck_Drivers.Find(PortPassId);
                td.Port_Pass_ID = PortPassId;
                td.First_Name = FirstName;
                td.Last_Name = LastName;
                td.Truck_Company_ID = TruckCompanyCode;
                td.Truck_Company_Name = TruckCompanyName;
                td.Truck_Number = TruckNumber.ToString();
                td.Suspend_Truck_Driver = SuspendyTruckDriver;
                db.Truck_Drivers.AddOrUpdate(td);
                db.SaveChanges();
            }
            catch (Exception)
            {
                isSave = false;
            }
            return isSave;
        }
    }

    public interface ITruckDriversRepository
    {
        List<Truck_Drivers> GetAll();

        List<Truck_Drivers> GetByPortPass(string PortPassId);

        List<Truck_Drivers> GetByTruckId(int TruckId);

        //List<Truck_Drivers> GetSearch(string PassId, string FirstName, string LastName, string TruckNum, string Company);

        bool Insert(
            string PortPassId
            , string FirstName
            , string LastName
            , string TruckCompanyCode
            , string TruckCompanyName
            , string TruckNumber
            , bool SuspendyTruckDriver);

        bool Update(
              string PortPassId
            , string FirstName
            , string LastName
            , string TruckCompanyCode
            , string TruckCompanyName
            , string TruckNumber
            , bool SuspendyTruckDriver);

        bool Delete(string PortPassID);
    }
}