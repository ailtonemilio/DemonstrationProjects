using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class DocumentsStoredUserDepartmentRepository : IDocumentsStoredUserDepartmentRepository
    {
        WTCCeresEntities db = new WTCCeresEntities();
        DocumentsStoredUserDepartment du = new DocumentsStoredUserDepartment();

        public bool Delete(int Id)
        {
            bool isDelete = true;
            try
            {
                du = db.DocumentsStoredUserDepartment.Find(Id);
                db.DocumentsStoredUserDepartment.Remove(du);
                db.SaveChanges();
            }
            catch (Exception)
            {
                isDelete = false;
            }
            return isDelete;
        }

        public List<DocumentsStoredUserDepartment> GetAll()
        {
            var list = db.DocumentsStoredUserDepartment.OrderBy(p => p.DocumentsStoredUserDepartmentId);
            return list.ToList();
        }

        public List<DocumentsStoredUserDepartment> GetById(int Id)
        {
            var list = db.DocumentsStoredUserDepartment.Where(p => p.DocumentsStoredUserDepartmentId == Id);
            return list.ToList();
        }

        public bool Insert(int DocumentsStoredDepartmentId, int UserId)
        {
            bool isSave = true;
            try
            {
                du.DocumentsStoredDepartmentId = DocumentsStoredDepartmentId;
                du.UserId = UserId;
                db.DocumentsStoredUserDepartment.Add(du);
                db.SaveChanges();
            }
            catch (Exception)
            {
                isSave = false;
            }
            return isSave;
        }

        public bool Update(int Id, int DocumentsStoredDepartmentId, int UserId)
        {
            bool isSave = true;
            try
            {
                du = db.DocumentsStoredUserDepartment.Find(Id);
                du.DocumentsStoredDepartmentId = DocumentsStoredDepartmentId;
                du.UserId = UserId;
                db.DocumentsStoredUserDepartment.AddOrUpdate(du);
                db.SaveChanges();
            }
            catch (Exception)
            {
                isSave = false;
            }
            return isSave;
        }
    }

    public interface IDocumentsStoredUserDepartmentRepository
    {
        List<DocumentsStoredUserDepartment> GetAll();
        List<DocumentsStoredUserDepartment> GetById(int Id);
        bool Insert(int DocumentsStoredDepartmentId, int UserId);
        bool Update(int Id, int DocumentsStoredDepartmentId, int UserId);
        bool Delete(int Id);
    }
}
