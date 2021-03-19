using ModelLayer;
using ModelLayer.CustomModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class CompanyRepository : ICompanyRepository
    {
        private Company cp = new Company();

        public bool Delete(int Id)
        {
            bool isDeleted = true;
            try
            {
                using (WTCCeresEntities db = new WTCCeresEntities())
                {
                    cp = db.Company.Find(Id);
                    db.Company.Remove(cp);
                    db.SaveChanges();
                }
            }
            catch
            {
                isDeleted = false;
            }
            return isDeleted;
        }

        public List<VW_CompanyCompanyType> GetAll()
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_CompanyCompanyType.ToList();
            }
        }

        public List<VW_CompanyCompanyType> GetAll(WTCCeresEntities db)
        {
            return db.VW_CompanyCompanyType.ToList();
        }

        public List<VW_CompanyCompanyType> GetAllCompany()
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_CompanyCompanyType.ToList();
            }
        }

        public Company GetById(int Id, WTCCeresEntities db)
        {
            var listById = db.Company.Find(Id);

            return listById;
        }

        public VW_CompanyCompanyType GetVWById(int Id)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var listById = db.VW_CompanyCompanyType.Where(c => c.CompanyId == Id).ToList();

                if (listById.Count > 0)
                    return listById[0];
                else
                    return null;
            }
        }

        public List<VW_CompanyCompanyType> GetAllByType(string type)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var listByType = db.VW_CompanyCompanyType.Where(c => c.DescCompanyType == type || c.CompanyTypeId == 0).OrderBy(c => c.CompanyName).ToList();

                return listByType;
            }
        }

        public List<VW_CompanyCompanyType> GetAllByCompanyTypeId(int CompanyTypeId, WTCCeresEntities db)
        {
            var listByType = db.VW_CompanyCompanyType.Where(c => c.CompanyTypeId == CompanyTypeId || c.CompanyTypeId == 0).OrderBy(c => c.CompanyName).ToList();

            return listByType;
        }

        public List<VW_CompanyCompanyType> GetAllByType(string type, WTCCeresEntities db)
        {
            var listByType = db.VW_CompanyCompanyType.Where(c => c.DescCompanyType == type || c.CompanyTypeId == 0).OrderBy(c => c.CompanyName).ToList();

            return listByType;
        }

        public bool AddOrUpdate(Company company, WTCCeresEntities db)
        {
            bool isSaved = true;
            try
            {
                if (company.CompanyId == 0)
                    db.Company.Add(company);
                else
                    db.Company.AddOrUpdate(company);
                db.SaveChanges();
                cp = company;
            }
            catch (Exception e)
            {
                string error = e.Message;
                isSaved = false;
            }

            return isSaved;
        }

        public List<VW_CompanyCompanyType> GetAllByName(string name, string type)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var listByType = db.VW_CompanyCompanyType.Where(c => c.CompanyName.Contains(name) && c.DescCompanyType.Contains(type));

                return listByType.ToList();
            }
        }

        public List<VW_CompanyCompanyType> GetAllExceptName(string name, string type)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var listByType = db.VW_CompanyCompanyType.Where(c => c.CompanyName != name && c.DescCompanyType == type);

                return listByType.ToList();
            }
        }

        public List<VW_CompanyCompanyType> GetAllByType(List<string> type)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var listByType = from c in db.VW_CompanyCompanyType
                                 where type.Contains(c.DescCompanyType)
                                 select c;

                return listByType.ToList();
            }
        }

        public List<CompanyType> GetAllCompanyType()
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.CompanyType.OrderBy(c => c.DescCompanyType).ToList();
            }
        }

        public CompanyType GetCompanyTypeIdByName(string CompanyType)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.CompanyType.Where(c => c.DescCompanyType == CompanyType).ToList()[0];
            }
        }

        public int GetLastCompanyIdInserted()
        {
            return cp.CompanyId;
        }

        public List<Company> GetCompanyById(int Id)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var listById = db.Company.Where(p => p.CompanyId == Id);
                return listById.ToList();
            }
        }

        public List<VW_Company> GetAllActiveVWCompany()
        {
            var cList = new List<VW_Company>();
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                foreach (Company c in db.Company.Where(c => c.IsActive == true).ToList())
                {
                    VW_Company cvw = new VW_Company();

                    cvw.CompanyId = c.CompanyId;
                    cvw.CompanyCode = c.CompanyCode;
                    cvw.CompanyName = c.CompanyName;
                    cvw.Email = c.Email;
                    cvw.Website = c.Website;
                    cvw.Notes = c.Notes;
                    cvw.Rating = c.Rating;
                    cvw.Attention = c.Attention;
                    cvw.CompanyCategoryId = c.CompanyCategoryId;
                    cvw.CategoryName = c.CompanyCategory.Category;

                    cList.Add(cvw);
                }
            }

            return cList.OrderBy(c => c.CompanyName).ToList();
        }

        public List<VW_CompanyCompanyType> GetByCompanyCategoryId(List<int> CompanyCategoryIds, WTCCeresEntities db)
        {
            return db.VW_CompanyCompanyType.Where(c =>
            CompanyCategoryIds.Contains(c.CompanyCategoryId)).OrderBy(c => c.CompanyName).ToList();
        }
    }

    public interface ICompanyRepository
    {
        List<VW_CompanyCompanyType> GetAll();

        List<VW_CompanyCompanyType> GetByCompanyCategoryId(List<int> CompanyCategoryIds, WTCCeresEntities db);

        List<VW_CompanyCompanyType> GetAll(WTCCeresEntities db);

        List<VW_Company> GetAllActiveVWCompany();

        List<VW_CompanyCompanyType> GetAllCompany();

        List<CompanyType> GetAllCompanyType();

        CompanyType GetCompanyTypeIdByName(string CompanyType);

        List<VW_CompanyCompanyType> GetAllByType(string type);

        List<VW_CompanyCompanyType> GetAllByCompanyTypeId(int CompanyTypeId, WTCCeresEntities db);

        List<VW_CompanyCompanyType> GetAllByType(string type, WTCCeresEntities db);

        List<VW_CompanyCompanyType> GetAllByType(List<string> type);

        List<VW_CompanyCompanyType> GetAllByName(string name, string type);

        List<VW_CompanyCompanyType> GetAllExceptName(string name, string type);

        VW_CompanyCompanyType GetVWById(int Id);

        Company GetById(int Id, WTCCeresEntities db);

        List<Company> GetCompanyById(int Id);

        int GetLastCompanyIdInserted();

        bool AddOrUpdate(Company company, WTCCeresEntities db);

        bool Delete(int Id);
    }
}