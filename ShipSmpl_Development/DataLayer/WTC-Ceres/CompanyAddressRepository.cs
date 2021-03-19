using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class CompanyAddressRepository : ICompanyAddressRepository
    {
        public bool AddOrUpdate(CompanyAddress companyAddress, WTCCeresEntities db)
        {
            bool isSaved = true;

            try
            {
                db.CompanyAddress.AddOrUpdate(companyAddress);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                isSaved = false;
            }

            return isSaved;
        }

        public bool Delete(int CompanyId)
        {
            bool isSaved = true;
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    CompanyAddress ca = db.CompanyAddress.Find(CompanyId);
                    db.CompanyAddress.Remove(ca);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    isSaved = false;
                }
            }
            return isSaved;
        }

        public List<CompanyAddress> GetAll()
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.CompanyAddress.ToList();
            }
        }

        public CompanyAddress GetById(int Id)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.CompanyAddress.Find(Id);
            }
        }

        public CompanyAddress GetById(int Id, WTCCeresEntities db)
        {
            return db.CompanyAddress.Find(Id);
        }

        public List<CompanyAddress> GetCompanyAddressByCompanyId(int Id)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var ListById = db.CompanyAddress.Where(p => p.CompanyId == Id).ToList();
                return ListById;
            }
        }

        public List<CompanyAddress> GetCompanyAddressByCompanyId(int Id, WTCCeresEntities db)
        {
            var ListById = db.CompanyAddress.Where(p => p.CompanyId == Id).ToList();
            return ListById;
        }
    }

    public interface ICompanyAddressRepository
    {
        List<CompanyAddress> GetAll();

        CompanyAddress GetById(int Id);

        CompanyAddress GetById(int Id, WTCCeresEntities db);

        List<CompanyAddress> GetCompanyAddressByCompanyId(int Id);

        List<CompanyAddress> GetCompanyAddressByCompanyId(int Id, WTCCeresEntities db);

        bool AddOrUpdate(CompanyAddress companyAddress, WTCCeresEntities db);

        bool Delete(int CompanyId);
    }
}