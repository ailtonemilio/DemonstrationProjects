using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class CompanyRateTypeRepository : ICompanyRateTypeRepository
    {
        private CompanyCustomerRateType ccrt = new CompanyCustomerRateType();

        public List<CustomerRateType> GetAllCustomerRateType()
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.CustomerRateType.OrderBy(c => c.RateCode).ToList();
            }
        }

        public List<CustomerRateType> GetAllCustomerRateType(WTCCeresEntities db)
        {
            return db.CustomerRateType.OrderBy(c => c.RateCode).ToList();
        }

        public CustomerRateType GetCustomerRateTypeById(int CustomerRateTypeId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.CustomerRateType.Find(CustomerRateTypeId);
            }
        }

        public bool InsertCompanyCustomerRateType(int CompanyId, int CustomerRateTypeId)
        {
            bool isSaved = true;
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    CompanyCustomerRateType ccrt = new CompanyCustomerRateType();
                    ccrt.CompanyId = CompanyId;
                    ccrt.CustomerRateTypeId = CustomerRateTypeId;

                    db.CompanyCustomerRateType.Add(ccrt);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    string message = e.Message;
                    isSaved = false;
                }
            }
            return isSaved;
        }

        public bool UpdateCompanyCustomerRateType(int CompanyCustomerRateTypeId, int CompanyId, int CustomerRateTypeId)
        {
            bool isSaved = true;
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    ccrt = db.CompanyCustomerRateType.Find(CompanyCustomerRateTypeId);
                    ccrt.CompanyId = CompanyId;
                    ccrt.CustomerRateTypeId = CustomerRateTypeId;

                    db.CompanyCustomerRateType.AddOrUpdate(ccrt);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    string message = e.Message;
                    isSaved = false;
                }
            }
            return isSaved;
        }
    }

    public interface ICompanyRateTypeRepository
    {
        List<CustomerRateType> GetAllCustomerRateType();

        List<CustomerRateType> GetAllCustomerRateType(WTCCeresEntities db);

        CustomerRateType GetCustomerRateTypeById(int CustomerRateTypeId);

        bool InsertCompanyCustomerRateType(int CompanyId, int CustomerRateTypeId);

        bool UpdateCompanyCustomerRateType(int CompanyCustomerRateTypeId, int CompanyId, int CustomerRateTypeId);
    }
}