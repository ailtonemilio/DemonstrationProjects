using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class CompanyTypeService
    {
        private static ICompanyTypeRepository repository;

        static CompanyTypeService()
        {
            repository = new CompanyTypeRepository();
        }

        public bool AddOrUpdate(CompanyType companyType)
        {
            return repository.AddOrUpdate(companyType);
        }

        public bool Delete(int CompanyTypeId)
        {
            return repository.Delete(CompanyTypeId);
        }

        public static List<CompanyType> GetAll()
        {
            return repository.GetAll();
        }

        public static List<CompanyType> GetAll(WTCCeresEntities db)
        {
            return repository.GetAll(db);
        }
    }
}