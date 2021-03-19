using DataLayer.WTC_Ceres;
using ModelLayer;
using ModelLayer.CustomModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.WTC_Ceres
{
    public class CompanyService
    {
        private static ICompanyRepository repository;

        static CompanyService()
        {
            repository = new CompanyRepository();
        }

        public static List<VW_CompanyCompanyType> GetAll()
        {
            return repository.GetAll();
        }

        public static List<VW_CompanyCompanyType> GetByCompanyCategoryId(List<int> CompanyCategoryIds, WTCCeresEntities db)
        {
            return repository.GetByCompanyCategoryId(CompanyCategoryIds, db);
        }

        public static List<VW_CompanyCompanyType> GetAll(WTCCeresEntities db)
        {
            return repository.GetAll(db);
        }

        public static List<VW_CompanyCompanyType> GetAllByName(string name, string type)
        {
            return repository.GetAllByName(name, type);
        }

        public static List<VW_CompanyCompanyType> GetAllExceptName(string name, string type)
        {
            return repository.GetAllExceptName(name, type);
        }

        public static List<VW_CompanyCompanyType> GetCompaniesByTypeId(int TypeId)
        {
            var L = repository.GetAllCompany().Where(p => p.CompanyTypeId == TypeId).ToList();
            return L.ToList();
        }

        public static List<CompaniesName> GetCompaniesDropBoxByTypeId(int TypeId, WTCCeresEntities d)
        {

            var listCia = new List<CompaniesName>();
            var list = repository.GetAll(d).Where(p => p.CompanyTypeId == TypeId).ToList();

            foreach (var item in list)
            {
                listCia.Add(new CompaniesName { CompanieId = item.CompanyId, CompanyName = item.CompanyName.TrimEnd() + "-" + item.CompanyCode.TrimEnd() });
            }

            return listCia.ToList();
        }

        public static List<CompaniesName> GetCompaniesCodeAndNameByTypeId(int TypeId)
        {
            var listCia = new List<CompaniesName>();
            var list = repository.GetAll().Where(p => p.CompanyTypeId == TypeId || p.CompanyId == 0).OrderBy(p => p.CompanyId).ToList();

            foreach (var item in list)
            {
                if (String.IsNullOrEmpty(item.CompanyCode) || String.IsNullOrWhiteSpace(item.CompanyCode))
                {
                    listCia.Add(new CompaniesName { CompanieId = 0, CompanyName = "" });
                }
                else
                {
                    listCia.Add(new CompaniesName { CompanieId = item.CompanyId, CompanyName = item.CompanyCode.TrimEnd() + " - " + item.CompanyName.TrimEnd() });
                }
            }

            return listCia.ToList();
        }

        public static List<Company> GetCompanyById(int Id)
        {
            return repository.GetCompanyById(Id);
        }

        /// <summary>
        /// Returns the name and id of the companies by their type
        /// </summary>
        /// <param name="type">Type Company - sample "Trucking Company"</param>
        /// <param name="NotALL">Insert one more item: the name = "ALL" and ID = 0 when inserted false, to facilitate the filter for all companies.</param>
        /// <returns></returns>
        public static List<CompaniesName> GetCompaniesDropBoxByType(string type, bool NotALL)
        {
            var listCia = new List<CompaniesName>();
            var list = repository.GetAllByType(type).OrderBy(p => p.CompanyName);

            listCia.Clear();

            listCia.Add(new CompaniesName { CompanieId = 00, CompanyName = "" });

            if (NotALL == false)
                listCia.Add(new CompaniesName { CompanieId = 0, CompanyName = "ALL" });

            foreach (var item in list)
            {
                listCia.Add(new CompaniesName { CompanieId = item.CompanyId, CompanyName = item.CompanyName.TrimEnd() });
            }

            return listCia.ToList();
        }

        public static string GetCodeByCompanyId(int Id)
        {
            string Code = "";

            var ListCode = repository.GetVWById(Id);

            Code = ListCode.CompanyCode;

            return Code;
        }

        public static int GetCompanyIdByCode(string Code, string Type)
        {
            int CiaId = 0;

            var ListCiaId = repository.GetAll().Where(p => p.DescCompanyType.TrimEnd() == Type && p.CompanyCode.TrimEnd() == Code).ToList();

            foreach (var item in ListCiaId)
            {
                CiaId = item.CompanyId;
            }

            return CiaId;
        }

        public static int GetCompanyIdByCompanyName(string CompanyName)
        {
            int CiaId = 0;

            var list = repository.GetAll().Where(p => p.CompanyName.TrimEnd().ToUpper() == CompanyName.ToUpper()).ToList();

            foreach (var item in list)
            {
                CiaId = item.CompanyId;
            }

            return CiaId;
        }

        public static VW_CompanyCompanyType GetVWById(int Id)
        {
            return repository.GetVWById(Id);
        }

        public static Company GetById(int Id, WTCCeresEntities db)
        {
            return repository.GetById(Id, db);
        }

        public bool Delete(int Id)
        {
            return repository.Delete(Id);
        }

        public static List<VW_CompanyCompanyType> GetAllByType(string type)
        {
            return repository.GetAllByType(type);
        }

        public static List<VW_CompanyCompanyType> GetAllByType(string type, WTCCeresEntities db)
        {
            return repository.GetAllByType(type, db);
        }

        public static List<VW_CompanyCompanyType> GetAllByCompanyTypeId(int CompanyTypeId, WTCCeresEntities db)
        {
            return repository.GetAllByCompanyTypeId(CompanyTypeId, db);
        }

        public static List<VW_CompanyCompanyType> GetAllByType(List<string> type)
        {
            return repository.GetAllByType(type);
        }

        public int GetLastCompanyIdInserted()
        {
            return repository.GetLastCompanyIdInserted();
        }

        public static List<CompanyType> GetAllCompanyType()
        {
            return repository.GetAllCompanyType();
        }

        public static CompanyType GetCompanyTypeIdByName(string CompanyType)
        {
            return repository.GetCompanyTypeIdByName(CompanyType);
        }

        public static List<VW_Company> GetAllActiveVWCompany()
        {
            return repository.GetAllActiveVWCompany();
        }

        public bool AddOrUpdate(Company company, WTCCeresEntities db)
        {
            return repository.AddOrUpdate(company, db);
        }
    }
}