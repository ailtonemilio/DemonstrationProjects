using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class CompanyCompanyTypeService
    {
        private static ICompanyCompanyTypeRepository repository;

        static CompanyCompanyTypeService()
        {
            repository = new CompanyCompanyTypeRepository();
        }

        public bool AddOrUpdate(CompanyCompanyType companyCompanyType, WTCCeresEntities db)
        {
            return repository.AddOrUpdate(companyCompanyType, db);
        }

        public bool Delete(int CompanyCompanyTypeId)
        {
            return repository.Delete(CompanyCompanyTypeId);
        }

        public static List<CompanyCompanyType> GetByCompanyId(int CompanyId, WTCCeresEntities db)
        {
            return repository.GetByCompanyId(CompanyId, db);
        }

        public static List<CompanyCompanyType> GetByCompanyTypeId(int CompanyTypeId, WTCCeresEntities db)
        {
            return repository.GetByCompanyTypeId(CompanyTypeId, db);
        }
    }
}