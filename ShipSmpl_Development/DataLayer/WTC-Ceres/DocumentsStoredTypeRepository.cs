using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class DocumentsStoredTypeRepository : IDocumentsStoredTypeRepository
    {
        WTCCeresEntities db = new WTCCeresEntities();
        DocumentsStoredType dt = new DocumentsStoredType();
        public bool Delete(int Id)
        {
            bool isDelete = true;
            try
            {
                dt = db.DocumentsStoredType.Find(Id);
                db.DocumentsStoredType.Remove(dt);
                db.SaveChanges();
            }
            catch (Exception)
            {
                isDelete = false;
            }
            return isDelete;
        }

        public List<DocumentsStoredType> GetAll()
        {
            var list = db.DocumentsStoredType.OrderBy(p => p.DescDocumentsStoredType);
            return list.ToList();
        }

        public List<DocumentsStoredType> GetById(int Id)
        {
            var listById = db.DocumentsStoredType.Where(p => p.DocumentsStoredTypeId == Id);
            return listById.ToList();
        }
        public List<DocumentsStoredType> GetByDeparmentId(int Id)
        {
            var listByDep = db.DocumentsStoredType.Where(p => p.DocumentsStoredDepartmentId == Id);
            return listByDep.OrderBy(x => x.DescDocumentsStoredType).ToList();
        }

        public int GetLastId()
        {
            int Id = int.Parse(db.DocumentsStoredType
                                    .OrderByDescending(p => p.DocumentsStoredTypeId)
                                    .Select(p => p.DocumentsStoredTypeId)
                                    .First().ToString());

            return Id;
        }

        public bool Insert(string DescDocumentsStoredType, int DocumentsStoredDepartmentId)
        {
            bool isSave = true;
            try
            {
                dt.DescDocumentsStoredType = DescDocumentsStoredType;
                dt.DocumentsStoredDepartmentId = DocumentsStoredDepartmentId;
                db.DocumentsStoredType.Add(dt);
                db.SaveChanges();
            }
            catch (Exception)
            {
                isSave = false;
            }
            return isSave;
        }

        public bool Update(int Id, string DescDocumentsStoredType, int DocumentsStoredDepartmentId)
        {
            bool isSave = true;
            try
            {
                dt = db.DocumentsStoredType.Find(Id);
                dt.DescDocumentsStoredType = DescDocumentsStoredType;
                dt.DocumentsStoredDepartmentId = DocumentsStoredDepartmentId;
                db.DocumentsStoredType.AddOrUpdate(dt);
                db.SaveChanges();
            }
            catch (Exception)
            {
                isSave = false;
            }
            return isSave;
        }


    }

    public interface IDocumentsStoredTypeRepository
    {
        List<DocumentsStoredType> GetAll();
        List<DocumentsStoredType> GetById(int Id);
        List<DocumentsStoredType> GetByDeparmentId(int Id);
        int GetLastId();
        bool Insert(string DocumentsStoredType, int DocumentsStoredDepartmentId);
        bool Update(int Id, string DocumentsStoredType, int DocumentsStoredDepartmentId);
        bool Delete(int Id);
    }
}
