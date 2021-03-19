using System;
using System.Collections.Generic;
using System.Linq;
using ModelLayer;
using ModelLayer.CustomModel;
using DataLayer.WTC_Ceres;

namespace BusinessLayer.WTC_Ceres
{
    public class TruckDriverService
    {
        private static ITruckDriverRepository repository;

        static TruckDriverService()
        {
            repository = new TruckDriverRepository();
        }

        public static List<TruckDriver> GetAll()
        {
            return repository.GetAll();
        }

        public static List<TruckDriver> GetByPortPass(string PortPassId, WTCCeresEntities d)
        {
            return repository.GetByPortPass(PortPassId, d);
        }

        public static List<TruckDriver> GetByTruckId(int TruckDriverId)
        {
            return repository.GetByTruckId(TruckDriverId);
        }

        public static List<TruckDriverList> GetTruckDriverAllList(WTCCeresEntities d)
        {
            return repository.GetTruckDriverAllList(d).ToList();
        }

        public static List<TruckDriverList> GetDriverTruckDropBox(WTCCeresEntities d)
        {
            var listTruck = new List<TruckDriverList>();
            var list = repository.GetTruckDriverAllList(d).OrderBy(p => p.FullName).ToList();

            listTruck.Add(new TruckDriverList
            {
                TruckDriverId = 0,
                PortPassId = "",
                FirstName = "",
                LastName = "",
                FullName = " ",
                TruckNumber = "",
                SuspendTruckDriver = false,
                CompanyId = 0,
                CompanyCode = "",
                CompanyName = "",
                TruckDriverCompanyId = 0
            });

            foreach (var item in list)
            {
                listTruck.Add(new TruckDriverList
                {
                    TruckDriverId = item.TruckDriverId,
                    PortPassId = item.PortPassId,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    FullName = item.FirstName + " " + item.LastName,
                    TruckNumber = item.TruckNumber,
                    SuspendTruckDriver = item.SuspendTruckDriver,
                    CompanyId = item.CompanyId,
                    CompanyCode = item.CompanyCode,
                    CompanyName = item.CompanyName,
                    TruckDriverCompanyId = item.TruckDriverCompanyId
                });
            }

            return listTruck.ToList();
        }

        public static int LastTruckDriverId()
        {
            return repository.LastTruckDriverId();
        }

        public static bool Insert(string PortPassId, string TruckNumber, string FirstName, string LastName, bool SuspendyTruckDriver, int CompanyId)
        {
            return repository.Insert(PortPassId, TruckNumber, FirstName, LastName, SuspendyTruckDriver, CompanyId);
        }

        public static bool Update(int TruckDriverId, string PortPassId, string TruckNumber, string FirstName, string LastName, bool SuspendyTruckDriver)
        {
            return repository.Update(TruckDriverId, PortPassId, TruckNumber, FirstName, LastName, SuspendyTruckDriver);
        }

        public static bool SuspendTruckDriver(int TruckDriverId, bool Suspendy)
        {
            return repository.SuspendTruckDriver(TruckDriverId, Suspendy);
        }
    }
}