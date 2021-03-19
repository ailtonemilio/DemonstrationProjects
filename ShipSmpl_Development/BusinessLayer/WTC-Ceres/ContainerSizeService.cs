using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class ContainerSizeService
    {
        private static IContainerSizeRepository repository;

        static ContainerSizeService()
        {
            repository = new ContainerSizeRepository();
        }

        public static List<ContainerSize> GetAll()
        {
            return repository.GetAll();
        }

        public static List<ContainerSize> GetAll(WTCCeresEntities db)
        {
            return repository.GetAll(db);
        }
    }
}