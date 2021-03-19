using ModelLayer;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class CompanyCategoryRepository : ICompanyCategoryRepository
    {
        public List<CompanyCategory> GetAll(WTCCeresEntities db)
        {
            return db.CompanyCategory.OrderBy(cc => cc.Category).ToList();
        }
    }

    public interface ICompanyCategoryRepository
    {
        List<CompanyCategory> GetAll(WTCCeresEntities db);
    }
}