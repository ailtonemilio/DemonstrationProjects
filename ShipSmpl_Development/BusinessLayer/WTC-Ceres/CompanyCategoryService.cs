using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class CompanyCategoryService
    {
        private static ICompanyCategoryRepository repository;

        static CompanyCategoryService()
        {
            repository = new CompanyCategoryRepository();
        }

        public static List<CompanyCategory> GetAll(WTCCeresEntities db)
        {
            return repository.GetAll(db);
        }
    }
}