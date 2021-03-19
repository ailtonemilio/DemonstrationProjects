using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class PalletService
    {
        private static IPalletRepository repository;

        static PalletService()
        {
            repository = new PalletRepository();
        }

        public bool Update(int PalletId, string PalletName, int YardLocationId)
        {
            return repository.Update(PalletId, PalletName, YardLocationId);
        }

        public bool Insert(string PalletName, int YardLocationId)
        {
            return repository.Insert(PalletName, YardLocationId);
        }

        public static List<Pallet> GetAll()
        {
            return repository.GetAll();
        }
    }
}