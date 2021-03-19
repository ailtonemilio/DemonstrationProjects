using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.WTC_Ceres
{
    public class DocumentsStoredDepartmentService
    {
        static IDocumentsStoredDepartmentRepository repository;

        static DocumentsStoredDepartmentService()
        {
            repository = new DocumentsStoredDepartmentRepository();
        }

        public static bool Delete(int Id)
        {
            return repository.Delete(Id);
        }

        public static List<DocumentsStoredDepartment> GetAll()
        {
            return repository.GetAll();
        }

        public static List<DocumentsStoredDepartment> GetById(int Id)
        {
            return repository.GetById(Id);
        }
        public static List<DocumentsStoredDepartment> GetAllForDropBox()
        {
            var listDoc = new List<DocumentsStoredDepartment>();
            var list = repository.GetAll();

            listDoc.Clear();
            listDoc.Add(new DocumentsStoredDepartment { DocumentsStoredDepartmentId = 0, DescDocumentsStoredDepartment = "ALL" });

            foreach (var item in list)
            {
                listDoc.Add(new DocumentsStoredDepartment { DocumentsStoredDepartmentId = item.DocumentsStoredDepartmentId, DescDocumentsStoredDepartment = item.DescDocumentsStoredDepartment });
            }

            return listDoc.OrderBy(x => x.DescDocumentsStoredDepartment).ToList();
        }

        public static bool VerifyDepartmentEquals(string Department)
        {
            bool isEqual = false;

            var list = repository.GetAll().Where(d => d.DescDocumentsStoredDepartment == Department).ToList();

            if (list.Count > 0)
                isEqual = true;

            return isEqual;
        }


        public static int GetLastId()
        {
            return repository.GetLastId();
        }

        public static bool Insert(string DescDocumentsStoredDepartment)
        {
            return repository.Insert(DescDocumentsStoredDepartment);
        }

        public static bool Update(int Id, string DescDocumentsStoredDepartment)
        {
            return repository.Update(Id, DescDocumentsStoredDepartment);
        }
    }
}
