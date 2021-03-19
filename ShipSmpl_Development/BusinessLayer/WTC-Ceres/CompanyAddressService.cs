using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class CompanyAddressService
    {
        private static ICompanyAddressRepository repository;

        static CompanyAddressService()
        {
            repository = new CompanyAddressRepository();
        }

        public static List<CompanyAddress> GetAll()
        {
            return repository.GetAll();
        }

        public static CompanyAddress GetById(int Id)
        {
            return repository.GetById(Id);
        }

        public static CompanyAddress GetById(int Id, WTCCeresEntities db)
        {
            return repository.GetById(Id, db);
        }

        public static List<CompanyAddress> GetCompanyAddressByCompanyId(int Id)
        {
            return repository.GetCompanyAddressByCompanyId(Id);
        }

        public static List<CompanyAddress> GetCompanyAddressByCompanyId(int Id, WTCCeresEntities db)
        {
            return repository.GetCompanyAddressByCompanyId(Id, db);
        }

        public bool AddOrUpdate(CompanyAddress companyAddress, WTCCeresEntities db)
        {
            return repository.AddOrUpdate(companyAddress, db);
        }
    }
}