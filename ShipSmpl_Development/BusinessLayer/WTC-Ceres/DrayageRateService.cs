using DataLayer.WTC_Ceres;
using ModelLayer;
using System;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class DrayageRateService
    {
        private static IDrayageRateRepository repository;

        static DrayageRateService()
        {
            repository = new DrayageRateRepository();
        }

        public static List<DrayageRate> GetAll()
        {
            return repository.GetAll();
        }

        public static List<DrayageRate> GetById(int Id)
        {
            return repository.GetById(Id);
        }

        public static bool Insert(int drayageSchemaID, DateTime fromDate, DateTime toDate, decimal rate, string rateType)
        {
            return repository.Insert(drayageSchemaID, fromDate, toDate, rate, rateType);
        }

        public bool Update(int Id, int drayageSchemaID, DateTime fromDate, DateTime toDate, decimal rate, string rateType)
        {
            return repository.Update(Id, drayageSchemaID, fromDate, toDate, rate, rateType);
        }

        public bool Delete(int Id)
        {
            return repository.Delete(Id);
        }
    }
}