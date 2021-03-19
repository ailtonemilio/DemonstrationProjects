using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;


namespace DataLayer.WTC_Ceres
{
    public class DocumentsStoredDepartmentRepository : IDocumentsStoredDepartmentRepository
    {
        WTCCeresEntities db = new WTCCeresEntities();
        DocumentsStoredDepartment dd = new DocumentsStoredDepartment();
        public bool Delete(int Id)
        {
            bool isDelete = true;
            try
            {
                dd = db.DocumentsStoredDepartment.Find(Id);
                db.DocumentsStoredDepartment.Remove(dd);
                db.SaveChanges();
            }
            catch (Exception)
            {
                isDelete = false;
            }
            return isDelete;
        }

        public List<DocumentsStoredDepartment> GetAll()
        {
            var list = db.DocumentsStoredDepartment.OrderBy(p => p.DescDocumentsStoredDepartment);
            return list.ToList();
        }

        public List<DocumentsStoredDepartment> GetById(int Id)
        {
            var listById = db.DocumentsStoredDepartment.Where(p => p.DocumentsStoredDepartmentId == Id);
            return listById.ToList();
        }

        public int GetLastId()
        {
            int Id = int.Parse(db.DocumentsStoredDepartment
                                    .OrderByDescending(p => p.DocumentsStoredDepartmentId)
                                    .Select(p => p.DocumentsStoredDepartmentId)
                                    .First().ToString());
            return Id;
        }

        public bool Insert(string DescDocumentsStoredDepartment)
        {
            bool isSave = true;
            try
            {
                dd.DescDocumentsStoredDepartment = DescDocumentsStoredDepartment;
                db.DocumentsStoredDepartment.Add(dd);
                db.SaveChanges();
            }
            catch (Exception)
            {
                isSave = false;
            }
            return isSave;
        }

        public bool Update(int Id, string DescDocumentsStoredDepartment)
        {
            bool isSave = true;
            try
            {
                dd = db.DocumentsStoredDepartment.Find(Id);
                dd.DescDocumentsStoredDepartment = DescDocumentsStoredDepartment;
                db.DocumentsStoredDepartment.AddOrUpdate(dd);
                db.SaveChanges();
            }
            catch (Exception)
            {
                isSave = false;
            }
            return isSave;
        }
    }

    public interface IDocumentsStoredDepartmentRepository
    {
        List<DocumentsStoredDepartment> GetAll();
        List<DocumentsStoredDepartment> GetById(int Id);
        int GetLastId();
        bool Insert(string DescDocumentsStoredDepartment);
        bool Update(int Id, string DescDocumentsStoredDepartment);
        bool Delete(int Id);
    }
}
