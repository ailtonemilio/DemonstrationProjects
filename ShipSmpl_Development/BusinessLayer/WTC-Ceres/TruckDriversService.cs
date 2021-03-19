using DataLayer.WTC_Ceres;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.WTC_Ceres
{
    public class TruckDriversService
    {
        private static ITruckDriversRepository repository;

        static TruckDriversService()
        {
            repository = new TruckDriversRepository();
        }

        public static List<Truck_Drivers> GetAll()
        {
            return repository.GetAll();
        }

        public static List<Truck_Drivers> GetByPortPass(string PortPassId)
        {
            return repository.GetByPortPass(PortPassId);
        }

        public static List<Truck_Drivers> GetByTruckId(string TruckId)
        {
            return GetByTruckId(TruckId);
        }
        public static List<Truck_Drivers> GetSearch(string PassId, string FirstName, string LastName, string TruckNum, string Company)
        {
            var listDoc = new List<Truck_Drivers>();

            if (Company != "ALL")
                listDoc = repository.GetAll().Where(p => p.Truck_Company_Name.TrimEnd().StartsWith(Company.TrimEnd())).ToList();
            else
                listDoc = repository.GetAll();

            if (!String.IsNullOrEmpty(PassId))
                listDoc = repository.GetAll().Where(p => p.Port_Pass_ID.Trim().StartsWith(PassId)).ToList();

            if (!String.IsNullOrEmpty(FirstName))
                listDoc = repository.GetAll().Where(p => p.First_Name.Trim().StartsWith(FirstName)).ToList();

            if (!String.IsNullOrEmpty(LastName))
                listDoc = repository.GetAll().Where(p => p.Last_Name.Trim().StartsWith(LastName)).ToList();

            if (!String.IsNullOrEmpty(TruckNum))
                listDoc = repository.GetAll().Where(p => p.Truck_Number.Trim().StartsWith(TruckNum)).ToList();

            return listDoc.ToList();
        }

        public static bool Insert(string PortPassId, string FirstName, string LastName, string TruckCompanyCode, string TruckCompanyName, string TruckNumber, bool SuspendyTruckDriver)

        {
            return repository.Insert(PortPassId, FirstName, LastName, TruckCompanyCode, TruckCompanyName, TruckNumber, SuspendyTruckDriver);
        }

        public static bool Update(
              string PortPassId
            , string FirstName
            , string LastName
            , string TruckCompanyCode
            , string TruckCompanyName
            , string TruckNumber
            , bool SuspendyTruckDriver)
        {
            return repository.Update(PortPassId, FirstName, LastName, TruckCompanyCode, TruckCompanyName, TruckNumber, SuspendyTruckDriver);
        }

        public static bool Delete(string PortPassID)
        {
            return repository.Delete(PortPassID);
        }
    }
}
