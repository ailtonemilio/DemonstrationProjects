using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class ContainerService
    {
        private static IContainerRepository repository;

        static ContainerService()
        {
            repository = new ContainerRepository();
        }

        public static List<Container> GetAll()
        {
            return repository.GetAll();
        }

        public bool Insert(string ContainerNumber, int OwnerId, int SSLineId, double TareWeight, double GrossMaxWeight, int ContainerSizeId, string StressLevel,
            int YardLocationId)
        {
            return repository.Insert(ContainerNumber, OwnerId, SSLineId, TareWeight, GrossMaxWeight, ContainerSizeId, StressLevel,
             YardLocationId);
        }

        public static List<VW_Container> GetByFilters(string ContainerNumber, string OwnerName, string SsLineName, string ContainerSize,
            string StressLevel, string YardLocation, List<string> DelegationsList, string YardLocationName)
        {
            return repository.GetByFilters(ContainerNumber, OwnerName, SsLineName, ContainerSize,
             StressLevel, YardLocation, DelegationsList, YardLocationName);
        }
    }
}