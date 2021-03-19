using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class MinibookingCommodityRepository : IMinibookingCommodityRepository
    {
        private MiniBookingCommodity mbc = new MiniBookingCommodity();

        public bool Delete(int MinibookingCommodityId)
        {
            bool isDeleted = true;
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    mbc = db.MiniBookingCommodity.Find(MinibookingCommodityId);
                    db.MiniBookingCommodity.Remove(mbc);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    string message = e.Message;
                    isDeleted = false;
                }
            }
            return isDeleted;
        }

        public List<VW_MinibookingCommodity> GetMinibookingCommodityByMbId(int MinibookingId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_MinibookingCommodity.Where(mbc => mbc.MiniBookingId == MinibookingId).ToList();
            }
        }

        public bool AddOrUpdate(MiniBookingCommodity miniBookingCommodity)
        {
            bool isInserted = true;
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    mbc = miniBookingCommodity;
                    db.MiniBookingCommodity.Add(mbc);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    string message = e.Message;
                    isInserted = false;
                }
            }
            return isInserted;
        }

        public bool AddOrUpdate(MiniBookingCommodity miniBookingCommodity, WTCCeresEntities db)
        {
            bool isInserted = true;

            try
            {
                mbc = miniBookingCommodity;
                db.MiniBookingCommodity.Add(mbc);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                string message = e.Message;
                isInserted = false;
            }

            return isInserted;
        }

        public List<VW_MinibookingCommodity> GetMinibookingCommodityByBkId(int BookingId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_MinibookingCommodity.Where(mbc => mbc.BookingId == BookingId).ToList();
            }
        }

        public List<VW_MinibookingCommodity> GetMinibookingCommodityByBkId(int BookingId, WTCCeresEntities db)
        {
            return db.VW_MinibookingCommodity.Where(mbc => mbc.BookingId == BookingId).ToList();
        }
    }

    public interface IMinibookingCommodityRepository
    {
        List<VW_MinibookingCommodity> GetMinibookingCommodityByMbId(int MinibookingId);

        List<VW_MinibookingCommodity> GetMinibookingCommodityByBkId(int BookingId);

        List<VW_MinibookingCommodity> GetMinibookingCommodityByBkId(int BookingId, WTCCeresEntities db);

        bool AddOrUpdate(MiniBookingCommodity minibookingCommodity);

        bool AddOrUpdate(MiniBookingCommodity minibookingCommodity, WTCCeresEntities db);

        bool Delete(int MinibookingCommodityId);
    }
}