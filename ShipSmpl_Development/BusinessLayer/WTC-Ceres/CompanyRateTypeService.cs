using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class CompanyRateTypeService
    {
        private static ICompanyRateTypeRepository repository;

        static CompanyRateTypeService()
        {
            repository = new CompanyRateTypeRepository();
        }

        public static List<CustomerRateType> GetAllCustomerRateType()
        {
            return repository.GetAllCustomerRateType();
        }

        public static List<CustomerRateType> GetAllCustomerRateType(WTCCeresEntities db)
        {
            return repository.GetAllCustomerRateType(db);
        }

        public bool InsertCompanyCustomerRateType(int CompanyId, int CustomerRateTypeId)
        {
            return repository.InsertCompanyCustomerRateType(CompanyId, CustomerRateTypeId);
        }

        public bool UpdateCompanyCustomerRateType(int CompanyCustomerRateTypeId, int CompanyId, int CustomerRateTypeId)
        {
            return repository.UpdateCompanyCustomerRateType(CompanyCustomerRateTypeId, CompanyId, CustomerRateTypeId);
        }

        public static CustomerRateType GetCustomerRateTypeById(int CustomerRateTypeId)
        {
            return repository.GetCustomerRateTypeById(CustomerRateTypeId);
        }
    }
}