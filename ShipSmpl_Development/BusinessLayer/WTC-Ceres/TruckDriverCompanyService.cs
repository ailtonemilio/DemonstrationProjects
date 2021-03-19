using System;
using System.Collections.Generic;
using System.Linq;
using ModelLayer;
using ModelLayer.CustomModel;
using DataLayer.WTC_Ceres;

namespace BusinessLayer.WTC_Ceres
{
    public class TruckDriverCompanyService
    {
        private static ITruckDriverCompanyRepository repository;

        static TruckDriverCompanyService()
        {
            repository = new TruckDriverCompanyRepository();
        }

        public static bool Insert(int TruckDriverId, int CompanyId)
        {
            return repository.Insert(TruckDriverId, CompanyId);
        }

        public static bool Update(int TruckDriverCompanyId, int TruckDriverId, int CompanyId)
        {
            return repository.Update(TruckDriverCompanyId, TruckDriverId, CompanyId);
        }

        public static bool Delete(int TruckDriverCompanyId)
        {
            return repository.Delete(TruckDriverCompanyId);
        }

        public static List<TruckDriverCompany> GetAll()
        {
            return repository.GetAll();
        }

        public static List<TruckDriverCompany> GetById(int TruckDriverCompanyId)
        {
            return repository.GetById(TruckDriverCompanyId);
        }

        public static int LastTruckDriverCompanyId()
        {
            return repository.LastTruckDriverCompanyId();
        }

        public static bool VerifyLastConection(int TruckDriverId, int CompanyId)
        {
            bool isConnection = false;

            var L = repository.GetAll().Where(p => p.TruckDriverId == TruckDriverId && p.CompanyId == CompanyId).ToList();

            if (L.Count == 1)
                isConnection = true;

            return isConnection;
        }
    }
}