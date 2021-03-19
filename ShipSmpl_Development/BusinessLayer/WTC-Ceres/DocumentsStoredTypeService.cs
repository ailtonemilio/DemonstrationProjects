using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.WTC_Ceres
{
    public class DocumentsStoredTypeService
    {
        static IDocumentsStoredTypeRepository repository;

        static DocumentsStoredTypeService()
        {
            repository = new DocumentsStoredTypeRepository();
        }

        public static bool Delete(int Id)
        {
            return repository.Delete(Id);
        }

        public static List<DocumentsStoredType> GetAll()
        {
            return repository.GetAll();
        }

        public static List<DocumentsStoredType> GetById(int Id)
        {
            return repository.GetById(Id);
        }

        public static List<DocumentsStoredType> GetByDeparmentId(int Id)
        {
            return repository.GetByDeparmentId(Id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id">Id Department</param>
        /// <param name="NotALL">If you want to add ID = 0 and Text = ALL, put it false</param>
        /// <returns>List Documents Sore Type By Department</returns>
        public static List<DocumentsStoredType> GetByDeparmentIdForDropBox(int Id, bool NotALL)
        {
            var listDoc = new List<DocumentsStoredType>();
            var listByDep = repository.GetByDeparmentId(Id);

            listDoc.Clear();

            if (NotALL == false)
            { listDoc.Add(new DocumentsStoredType { DocumentsStoredTypeId = 0, DescDocumentsStoredType = "ALL", DocumentsStoredDepartmentId = 0 }); }


            foreach (var item in listByDep)
            {
                listDoc.Add(new DocumentsStoredType { DocumentsStoredTypeId = item.DocumentsStoredTypeId, DescDocumentsStoredType = item.DescDocumentsStoredType, DocumentsStoredDepartmentId = item.DocumentsStoredDepartmentId });
            }

            return listDoc.OrderBy(x => x.DescDocumentsStoredType).ToList();
        }

        public static bool VerifyDocumentsStoredTypeEquals(int DepId, string DescDocType)
        {
            bool isEqual = false;

            var list = repository.GetAll().Where(p => p.DescDocumentsStoredType == DescDocType.TrimEnd() && p.DocumentsStoredDepartmentId == DepId).ToList();
            if (list.Count > 0)
                isEqual = true;

            return isEqual;
        }

        public static int GetLastId()
        {
            return repository.GetLastId();
        }

        public static bool Insert(string DescDocumentsStoredType, int DocumentsStoredDepartmentId)
        {
            return repository.Insert(DescDocumentsStoredType, DocumentsStoredDepartmentId);
        }

        public static bool Update(int Id, string DescDocumentsStoredType, int DocumentsStoredDepartmentId)
        {
            return repository.Update(Id, DescDocumentsStoredType, DocumentsStoredDepartmentId);
        }
    }
}
