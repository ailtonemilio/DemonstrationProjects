using DataLayer.WTC_Ceres;
using ModelLayer;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Billing
{
    public class DrayageSchemeService
    {
        private static IDrayageSchemeRepository repository;

        static DrayageSchemeService()
        {
            repository = new DrayageSchemeRepository();
        }

        public static List<DrayageScheme> GetAll()
        {
            return repository.GetAll();
        }

        public static List<DrayageScheme> GetByTruckID(int Id)
        {
            return repository.GetByTruckId(Id);
        }

        public static List<Object> GetDrayageScheme(int truckingCompanyId, string rateType)
        {
            return repository.GetDrayageScheme(truckingCompanyId, rateType);
        }

        public static List<Object> GetAssignedRates(int truckingCompanyId, string rateType, string startDate)
        {
            return repository.GetAssignedRates(truckingCompanyId, rateType, startDate);
        }

        public static List<DrayageScheme> GetById(int Id)
        {
            return repository.GetById(Id);
        }

        public static int GetByFromToId(int truckingCompanyID, int fromDockId, int toDockId)
        {
            return repository.GetByFromToId(truckingCompanyID, fromDockId, toDockId);
        }

        public static int GetLastId()
        {
            return repository.GetLastId();
        }

        public static bool Insert(int TruckingCompanyID, int FromDockID, int ToDockID)
        {
            return repository.Insert(TruckingCompanyID, FromDockID, ToDockID);
        }

        public bool Update(int Id, int TruckingCompanyID, int FromDockID, int ToDockID)
        {
            return repository.Update(Id, TruckingCompanyID, FromDockID, ToDockID);
        }

        public bool Delete(int Id)
        {
            return repository.Delete(Id);
        }
    }
}