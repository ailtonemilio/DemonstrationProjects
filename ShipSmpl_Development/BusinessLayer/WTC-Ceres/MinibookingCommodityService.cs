using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class MinibookingCommodityService
    {
        private static IMinibookingCommodityRepository repository;

        static MinibookingCommodityService()
        {
            repository = new MinibookingCommodityRepository();
        }

        public static List<VW_MinibookingCommodity> GetMinibookingCommodityByMbId(int MinibookingId)
        {
            return repository.GetMinibookingCommodityByMbId(MinibookingId);
        }

        public static List<VW_MinibookingCommodity> GetMinibookingCommodityByBkId(int BookingId)
        {
            return repository.GetMinibookingCommodityByBkId(BookingId);
        }

        public static List<VW_MinibookingCommodity> GetMinibookingCommodityByBkId(int BookingId, WTCCeresEntities db)
        {
            return repository.GetMinibookingCommodityByBkId(BookingId, db);
        }

        public bool AddOrUpdate(MiniBookingCommodity minibookingCommodity)
        {
            return repository.AddOrUpdate(minibookingCommodity);
        }

        public bool AddOrUpdate(MiniBookingCommodity minibookingCommodity, WTCCeresEntities db)
        {
            return repository.AddOrUpdate(minibookingCommodity, db);
        }

        public bool Delete(int MinibookingCommodityId)
        {
            return repository.Delete(MinibookingCommodityId);
        }
    }
}