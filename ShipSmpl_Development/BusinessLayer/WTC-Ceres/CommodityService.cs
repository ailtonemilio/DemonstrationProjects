using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.WTC_Ceres
{
    public class CommodityService
    {
        private static ICommodityRepository repository;

        static CommodityService()
        {
            repository = new CommodityRepository();
        }

        public static List<Commodity> GetAll()
        {
            return repository.GetAll();
        }

        public static List<Commodity> GetAll(WTCCeresEntities db)
        {
            return repository.GetAll(db);
        }

        public static bool VerifyByCommodityCode(string CommodityCode)
        {
            bool isCode = false;

            var list = repository.GetAll().Where(c => c.CommodityCode.Equals(CommodityCode)).ToList();

            if (list.Count > 0)
                isCode = true;

            return isCode;
        }

        public static Commodity GetById(int CommodityId)
        {
            return repository.GetById(CommodityId);
        }

        public static bool Update(int CommodityId, string CommodityCode, string CommodityName)
        {
            return repository.Update(CommodityId, CommodityCode, CommodityName);
        }

        public static bool Insert(string CommodityCode, string CommodityName)
        {
            return repository.Insert(CommodityCode, CommodityName);
        }

        public static bool Delete(int CommodityId)
        {
            return repository.Delete(CommodityId);
        }
    }
}