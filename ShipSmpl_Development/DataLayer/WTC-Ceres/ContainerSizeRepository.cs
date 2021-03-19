using ModelLayer;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class ContainerSizeRepository : IContainerSizeRepository
    {
        public List<ContainerSize> GetAll()
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.ContainerSize.OrderBy(c => c.ContainerSizeName).ToList();
            }
        }

        public List<ContainerSize> GetAll(WTCCeresEntities db)
        {
            return db.ContainerSize.OrderBy(c => c.ContainerSizeName).ToList();
        }
    }

    public interface IContainerSizeRepository
    {
        List<ContainerSize> GetAll();

        List<ContainerSize> GetAll(WTCCeresEntities db);
    }
}