using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class BaggerRepository : IBaggerRepository
    {
        private Bagger bgr = new Bagger();

        public List<Bagger> GetAll()
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.Bagger.ToList();
            }
        }

        public bool Insert(string BaggerName, int YardLocationId)
        {
            bool isSaved = true;

            try
            {
                using (WTCCeresEntities db = new WTCCeresEntities())
                {
                    bgr.BaggerName = BaggerName; ;
                    bgr.YardLocationId = YardLocationId;

                    db.Bagger.Add(bgr);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                isSaved = false;
            }
            return isSaved;
        }

        public bool Update(int BaggerId, string BaggerName, int YardLocationId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                bool isSaved = true;

                try
                {
                    bgr = db.Bagger.Find(BaggerId);
                    bgr.BaggerName = BaggerName; ;

                    bgr.YardLocationId = YardLocationId;

                    db.Bagger.AddOrUpdate(bgr);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    isSaved = false;
                }
                return isSaved;
            }
        }
    }

    public interface IBaggerRepository
    {
        bool Insert(string BaggerName, int YardLocationId);

        bool Update(int BaggerId, string BaggerName, int YardLocationId);

        List<Bagger> GetAll();
    }
}