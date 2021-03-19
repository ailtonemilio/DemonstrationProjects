using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class PalletRepository : IPalletRepository
    {
        private WTCCeresEntities db = new WTCCeresEntities();
        private Pallet pl = new Pallet();

        public List<Pallet> GetAll()
        {
            return db.Pallet.ToList();
        }

        public bool Insert(string PalletName, int YardLocationId)
        {
            bool isSaved = true;

            try
            {
                pl.PalletName = PalletName; ;
                pl.YardLocationId = YardLocationId;

                db.Pallet.Add(pl);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                isSaved = false;
            }
            return isSaved;
        }

        public bool Update(int PalletId, string PalletName, int YardLocationId)
        {
            bool isSaved = true;

            try
            {
                pl = db.Pallet.Find(PalletId);
                pl.PalletName = PalletName; ;
                pl.YardLocationId = YardLocationId;

                db.Pallet.AddOrUpdate(pl);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                isSaved = false;
            }
            return isSaved;
        }
    }

    public interface IPalletRepository
    {
        bool Update(int PalletId, string PalletName, int YardLocationId);

        bool Insert(string PalletName, int YardLocationId);

        List<Pallet> GetAll();
    }
}