using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class CompanyTypeRepository : ICompanyTypeRepository
    {
        public bool AddOrUpdate(CompanyType companyType)
        {
            bool isSaved = true;

            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    db.CompanyType.AddOrUpdate(companyType);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    isSaved = false;
                }
            }

            return isSaved;
        }

        public bool Delete(int CompanyTypeId)
        {
            bool isSaved = true;

            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    CompanyType ct = db.CompanyType.Find(CompanyTypeId);
                    db.CompanyType.Remove(ct);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    isSaved = false;
                }
            }

            return isSaved;
        }

        public List<CompanyType> GetAll()
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.CompanyType.Where(c => c.DescCompanyType != "Customer" &
                                                 c.CompanyTypeId != 0).OrderBy(c => c.DescCompanyType).ToList();
            }
        }

        public List<CompanyType> GetAll(WTCCeresEntities db)
        {
            return db.CompanyType.Where(c => c.DescCompanyType != "Customer" &
                                             c.CompanyTypeId != 0).OrderBy(c => c.DescCompanyType).ToList();
        }
    }

    public interface ICompanyTypeRepository
    {
        bool AddOrUpdate(CompanyType companyType);

        bool Delete(int CompanyTypeId);

        List<CompanyType> GetAll();

        List<CompanyType> GetAll(WTCCeresEntities db);
    }
}