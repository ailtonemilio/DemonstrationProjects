using ModelLayer;
using System;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class CompanyCustomerRateTypeRepository : ICompanyCustomerRateTypeRepository
    {
        public bool AddOrUpdate(CompanyCustomerRateType companyCustomerRateType, WTCCeresEntities db)
        {
            bool isSaved = true;

            try
            {
                db.CompanyCustomerRateType.AddOrUpdate(companyCustomerRateType);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                isSaved = false;
            }

            return isSaved;
        }

        public CompanyCustomerRateType GetByCompanyId(int CompanyId, WTCCeresEntities db)
        {
            var l = db.CompanyCustomerRateType.Where(c => c.CompanyId == CompanyId).ToList();

            if (l.Count > 0)
                return l[0];
            else
                return null;
        }
    }

    public interface ICompanyCustomerRateTypeRepository
    {
        CompanyCustomerRateType GetByCompanyId(int CompanyId, WTCCeresEntities db);

        bool AddOrUpdate(CompanyCustomerRateType companyCustomerRateType, WTCCeresEntities db);
    }
}