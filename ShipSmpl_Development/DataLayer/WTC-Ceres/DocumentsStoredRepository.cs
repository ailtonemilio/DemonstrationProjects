using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class DocumentsStoredRepository : IDocumentsStoredRepository
    {
        private WTCCeresEntities db = new WTCCeresEntities();
        private DocumentsStored ds = new DocumentsStored();

        public bool Delete(int Id)
        {
            bool isDelete = true;
            try
            {
                ds = db.DocumentsStored.Find(Id);
                db.DocumentsStored.Remove(ds);
                db.SaveChanges();
            }
            catch (Exception)
            {
                isDelete = false;
            }
            return isDelete;
        }

        public List<DocumentsStored> GetAll()
        {
            return db.DocumentsStored.ToList();
        }

        public List<DocumentsStored> GetById(int Id)
        {
            var listById = db.DocumentsStored.Where(p => p.DocumentsStoredId == Id);
            return listById.ToList();
        }

        public bool Insert(string FileTitle, string FileDescription, string ServerPath, string IssueDate, string ExpireDate, string FileName, int EmployeeId, int DocumentsStoredTypeId, int DocumentsStoredDepartmentId)
        {
            bool isSave = true;
            try
            {
                var d = new DocumentsStored();
                if (!String.IsNullOrEmpty(IssueDate))
                { d.IssueDate = Convert.ToDateTime(IssueDate); }
                else
                { d.IssueDate = null; }

                if (!String.IsNullOrEmpty(ExpireDate))
                { d.ExpireDate = Convert.ToDateTime(ExpireDate); }
                else
                { d.ExpireDate = null; }

                d.FileTitle = FileTitle;
                d.FileDescription = FileDescription;
                d.ServerPath = ServerPath;
                d.FileName = FileName;
                d.EmployeeId = EmployeeId;
                d.DocumentsStoredDepartmentId = DocumentsStoredDepartmentId;
                d.DocumentsStoredTypeId = DocumentsStoredTypeId;
                d.FileName = FileName;
                db.DocumentsStored.Add(d);
                db.SaveChanges();
            }
            catch (Exception)
            {
                isSave = false;
            }
            return isSave;
        }

        public bool Update(int Id, string FileTitle, string FileDescription, string ServerPath, string IssueDate, string ExpireDate, string FileName, int EmployeeId, int DocumentsStoredTypeId, int DocumentsStoredDepartmentId)
        {
            bool isSave = true;
            try
            {
                ds = db.DocumentsStored.Find(Id);
                if (!String.IsNullOrEmpty(IssueDate))
                { ds.IssueDate = Convert.ToDateTime(IssueDate); }
                else
                { ds.IssueDate = null; }

                if (!String.IsNullOrEmpty(ExpireDate))
                { ds.ExpireDate = Convert.ToDateTime(ExpireDate); }
                else
                { ds.ExpireDate = null; }
                ds.DocumentsStoredId = Id;
                ds.FileTitle = FileTitle;
                ds.FileDescription = FileDescription;
                ds.ServerPath = ServerPath;
                ds.FileName = FileName;
                ds.EmployeeId = EmployeeId;
                ds.DocumentsStoredDepartmentId = DocumentsStoredDepartmentId;
                ds.DocumentsStoredTypeId = DocumentsStoredTypeId;
                ds.FileName = FileName;
                db.DocumentsStored.AddOrUpdate(ds);
                db.SaveChanges();
            }
            catch (Exception)
            {
                isSave = false;
            }
            return isSave;
        }
    }

    public interface IDocumentsStoredRepository
    {
        List<DocumentsStored> GetAll();

        List<DocumentsStored> GetById(int Id);

        bool Insert(string FileTitle, string FileDescription, string ServerPath, string IssueDate, string ExpireDate, string FileName, int EmployeeId, int DocumentsStoredTypeId, int DocumentsStoredDepartmentId);

        bool Update(int Id, string FileTitle, string FileDescription, string ServerPath, string IssueDate, string ExpireDate, string FileName, int EmployeeId, int DocumentsStoredTypeId, int DocumentsStoredDepartmentId);

        bool Delete(int Id);
    }
}