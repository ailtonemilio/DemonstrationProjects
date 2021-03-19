using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class StorageTypeService
    {
        private static IStorageTypeRepository repository;

        static StorageTypeService()
        {
            repository = new StorageTypeRepository();
        }

        public bool Insert(string StorageTypeName)
        {
            return repository.Insert(StorageTypeName);
        }

        public bool Update(int StorageTypeId, string StorageTypeName)
        {
            return repository.Update(StorageTypeId, StorageTypeName);
        }

        public static List<StorageType> GetAll()
        {
            return repository.GetAll();
        }
    }
}