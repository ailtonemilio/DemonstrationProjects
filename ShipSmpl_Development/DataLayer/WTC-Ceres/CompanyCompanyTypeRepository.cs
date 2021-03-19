using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class CompanyCompanyTypeRepository : ICompanyCompanyTypeRepository
    {
        public bool AddOrUpdate(CompanyCompanyType companyCompanyType, WTCCeresEntities db)
        {
            bool isSaved = true;

            try
            {
                db.CompanyCompanyType.AddOrUpdate(companyCompanyType);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                isSaved = false;
            }

            return isSaved;
        }

        public bool Delete(int CompanyCompanyTypeId)
        {
            bool isSaved = true;

            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    CompanyCompanyType cct = db.CompanyCompanyType.Find(CompanyCompanyTypeId);
                    db.CompanyCompanyType.Remove(cct);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    isSaved = false;
                }
            }

            return isSaved;
        }

        public List<CompanyCompanyType> GetByCompanyId(int CompanyId, WTCCeresEntities db)
        {
            return db.CompanyCompanyType.Where(c => c.CompanyId == CompanyId).ToList();
        }

        public List<CompanyCompanyType> GetByCompanyTypeId(int CompanyTypeId, WTCCeresEntities db)
        {
            return db.CompanyCompanyType.Where(c => c.CompanyTypeId == CompanyTypeId).ToList();
        }
    }

    public interface ICompanyCompanyTypeRepository
    {
        bool AddOrUpdate(CompanyCompanyType companyCompanyType, WTCCeresEntities db);

        bool Delete(int CompanyCompanyTypeId);

        List<CompanyCompanyType> GetByCompanyId(int CompanyId, WTCCeresEntities db);

        List<CompanyCompanyType> GetByCompanyTypeId(int CompanyTypeId, WTCCeresEntities db);
    }
}