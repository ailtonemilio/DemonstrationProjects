using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class StorageTypeRepository : IStorageTypeRepository
    {
        private WTCCeresEntities db = new WTCCeresEntities();
        private StorageType st = new StorageType();

        public List<StorageType> GetAll()
        {
            return db.StorageType.ToList();
        }

        public bool Insert(string StorageTypeName)
        {
            bool isSaved = true;

            try
            {
                st.StorageTypeName = StorageTypeName;

                db.StorageType.Add(st);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                isSaved = false;
            }
            return isSaved;
        }

        public bool Update(int StorageTypeId, string StorageTypeName)
        {
            bool isSaved = true;

            try
            {
                st = db.StorageType.Find(StorageTypeId);
                st.StorageTypeName = StorageTypeName;

                db.StorageType.AddOrUpdate(st);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                isSaved = false;
            }
            return isSaved;
        }
    }

    public interface IStorageTypeRepository
    {
        bool Insert(string StorageTypeName);

        bool Update(int StorageTypeId, string StorageTypeName);

        List<StorageType> GetAll();
    }
}