using DataLayer.WTC_Ceres;
using ModelLayer;

namespace BusinessLayer.WTC_Ceres
{
    public class CompanyCustomerRateTypeService
    {
        private static ICompanyCustomerRateTypeRepository repository;

        static CompanyCustomerRateTypeService()
        {
            repository = new CompanyCustomerRateTypeRepository();
        }

        public static CompanyCustomerRateType GetByCompanyId(int CompanyId, WTCCeresEntities db)
        {
            return repository.GetByCompanyId(CompanyId, db);
        }

        public bool AddOrUpdate(CompanyCustomerRateType companyCustomerRateType, WTCCeresEntities db)
        {
            return repository.AddOrUpdate(companyCustomerRateType, db);
        }
    }
}