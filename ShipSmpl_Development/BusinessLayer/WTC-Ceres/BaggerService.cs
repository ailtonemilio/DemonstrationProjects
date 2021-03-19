using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class BaggerService
    {
        private static IBaggerRepository repository;

        static BaggerService()
        {
            repository = new BaggerRepository();
        }

        public bool Insert(string BaggerName, int YardLocationId)
        {
            return repository.Insert(BaggerName, YardLocationId);
        }

        public bool Update(int BaggerId, string BaggerName, int YardLocationId)
        {
            return repository.Update(BaggerId, BaggerName, YardLocationId);
        }

        public static List<Bagger> GetAll()
        {
            return repository.GetAll();
        }
    }
}