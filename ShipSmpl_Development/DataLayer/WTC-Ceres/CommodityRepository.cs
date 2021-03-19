using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class CommodityRepository : ICommodityRepository
    {
        private WTCCeresEntities db = new WTCCeresEntities();
        private Commodity c = new Commodity();

        public bool Insert(string CommodityCode, string CommodityName)
        {
            bool isSaved = true;
            try
            {
                var cm = new Commodity();
                cm.CommodityCode = CommodityCode;
                cm.CommodityName = CommodityName;

                db.Commodity.AddOrUpdate(cm);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                isSaved = false;
            }

            return isSaved;
        }

        public bool Delete(int CommodityId)
        {
            bool isSaved = true;
            try
            {
                c = db.Commodity.Find(CommodityId);
                db.Commodity.Remove(c);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                isSaved = false;
            }

            return isSaved;
        }

        public List<Commodity> GetAll()
        {
            return db.Commodity.OrderBy(c => c.CommodityName).ToList();
        }

        public List<Commodity> GetAll(WTCCeresEntities db)
        {
            return db.Commodity.OrderBy(c => c.CommodityName).ToList();
        }

        public Commodity GetById(int CommodityId)
        {
            return db.Commodity.Find(CommodityId);
        }

        public bool Update(int CommodityId, string CommodityCode, string CommodityName)
        {
            bool isSaved = true;
            try
            {
                c = db.Commodity.Find(CommodityId);
                c.CommodityCode = CommodityCode;
                c.CommodityName = CommodityName;

                db.Commodity.AddOrUpdate(c);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                isSaved = false;
            }

            return isSaved;
        }
    }

    public interface ICommodityRepository
    {
        List<Commodity> GetAll();

        List<Commodity> GetAll(WTCCeresEntities db);

        Commodity GetById(int CommodityId);

        bool Update(int CommodityId, string CommodityCode, string CommodityName);

        bool Insert(string CommodityCode, string CommodityName);

        bool Delete(int CommodityId);
    }
}