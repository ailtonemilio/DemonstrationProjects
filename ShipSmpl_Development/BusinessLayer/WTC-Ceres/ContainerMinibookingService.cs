using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class ContainerMinibookingService
    {
        private static IContainerMinibookingRepository repository;

        static ContainerMinibookingService()
        {
            repository = new ContainerMinibookingRepository();
        }

        public static List<ContainerMinibooking> GetById(int Id)
        {
            return repository.GetById(Id);
        }

        public bool Insert(int ContainerInOutId, int minibookingId)
        {
            return repository.Insert(ContainerInOutId, minibookingId);
        }

        public bool Delete(int Id)
        {
            return repository.Delete(Id);
        }

        public static List<VW_ContainersByBooking> GetContainersAssignedByMbId(int Id)
        {
            return repository.GetContainersAssignedByMbId(Id);
        }
    }
}