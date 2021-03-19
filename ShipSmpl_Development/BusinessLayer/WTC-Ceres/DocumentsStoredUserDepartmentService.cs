using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.WTC_Ceres
{
    public class DocumentsStoredUserDepartmentService
    {
        static IDocumentsStoredUserDepartmentRepository repository;

        static DocumentsStoredUserDepartmentService()
        {
            repository = new DocumentsStoredUserDepartmentRepository();
        }

        public static bool Delete(int Id)
        {
            return repository.Delete(Id);
        }

        public static List<DocumentsStoredUserDepartment> GetAll()
        {
            return repository.GetAll();
        }

        public static List<DocumentsStoredUserDepartment> GetById(int Id)
        {
            return repository.GetById(Id);
        }

        public static bool VerifySecurityDepartmentUser(int DepartmentId, int UserId)
        {
            bool isSecutity = false;

            var list = repository.GetAll().Where(p => p.DocumentsStoredDepartmentId == DepartmentId && p.UserId == UserId).ToList();

            if (list.Count > 0)
            { isSecutity = true; }

            return isSecutity;

        }

        public static bool Insert(int DocumentsStoredDepartmentId, int UserId)
        {
            return repository.Insert(DocumentsStoredDepartmentId, UserId);
        }

        public static bool Update(int Id, int DocumentsStoredDepartmentId, int UserId)
        {
            return repository.Update(Id, DocumentsStoredDepartmentId, UserId);
        }
    }
}
