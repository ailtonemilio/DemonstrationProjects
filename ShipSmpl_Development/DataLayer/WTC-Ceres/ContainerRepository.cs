using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class ContainerRepository : IContainerRepository
    {
        private WTCCeresEntities db = new WTCCeresEntities();
        private Container c = new Container();

        public List<Container> GetAll()
        {
            return db.Container.ToList();
        }

        public List<VW_Container> GetByFilters(string ContainerNumber, string OwnerName, string SsLineName, string ContainerSize,
            string StressLevel, string YardName, List<string> DelegationsList, string YardLocationName)
        {
            var list = db.VW_Container.Where(c => c.ContainerNumber.Contains(ContainerNumber)
                                                  && c.ContainerOwner.Contains(OwnerName)
                                                  && c.SSLine.Contains(SsLineName)
                                                  && c.ContainerSizeName.Contains(ContainerSize)
                                                  && c.StressLevel.Contains(StressLevel)
                                                  && c.YardName.Contains(YardName)
                                                  && DelegationsList.Contains(c.ContainerStatus)
                                                  && YardLocationName.Contains(YardLocationName)
                                                  );
            return list.ToList();
        }

        public bool Insert(string ContainerNumber, int OwnerId, int SSLineId, double TareWeight, double GrossMaxWeight, int ContainerSizeId,
            string StressLevel, int YardLocationId)
        {
            bool isSaved = true;
            try
            {
                c.ContainerNumber = ContainerNumber;
                c.OwnerId = OwnerId;
                c.SSLineId = SSLineId;
                //c.TareWeight = TareWeight;
                //c.GrossMaxWeight = GrossMaxWeight;
                c.ContainerSizeId = ContainerSizeId;
                c.StressLevel = StressLevel;
                // c.YardLocationId = YardLocationId;

                db.Container.Add(c);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                isSaved = false;
            }

            return isSaved;
        }
    }

    public interface IContainerRepository
    {
        List<Container> GetAll();

        bool Insert(string ContainerNumber, int OwnerId, int SSLineId, double TareWeight, double GrossMaxWeight, int ContainerSizeId, string StressLevel,
            int YardLocationId);

        List<VW_Container> GetByFilters(string ContainerNumber, string OwnerName, string SsLineName, string ContainerSize, string StressLevel,
            string YardName, List<string> DelegationsList, string YardLocationName);
    }
}