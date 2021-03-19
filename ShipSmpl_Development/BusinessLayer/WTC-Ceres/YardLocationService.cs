using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class YardLocationService
    {
        private static IYardLocationRepository repository;

        static YardLocationService()
        {
            repository = new YardLocationRepository();
        }

        public static List<YardLocation> GetAll()
        {
            return repository.GetAll();
        }
    }
}