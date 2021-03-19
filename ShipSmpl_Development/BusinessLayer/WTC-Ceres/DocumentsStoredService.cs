using DataLayer.WTC_Ceres;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.WTC_Ceres
{
    public class DocumentsStoredService
    {
        static IDocumentsStoredRepository repository;

        static DocumentsStoredService()
        {
            repository = new DocumentsStoredRepository();
        }

        public static bool Delete(int Id)
        {
            return repository.Delete(Id);
        }

        public static List<DocumentsStored> GetAll()
        {
            return repository.GetAll();
        }

        public static List<DocumentsStored> GetById(int Id)
        {
            return repository.GetById(Id);
        }

        public static List<DocumentsStored> GetByFilters(string FileTitle, string DocDescription, string DocumentsStoredDepartment, string DocumentsStoredType, int EmployeeId, string StartDate, string EndDate, bool IssueDate)
        {
            var List = new List<DocumentsStored>();

            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                if (!String.IsNullOrEmpty(StartDate))
                {
                    if (IssueDate)
                    {
                        if (EmployeeId != 0)
                        {
                            List = repository.GetAll().Where(d => (d.IssueDate >= Convert.ToDateTime(StartDate) && d.IssueDate <= Convert.ToDateTime(EndDate))
                                    && d.DocumentsStoredDepartment.DescDocumentsStoredDepartment.StartsWith(DocumentsStoredDepartment)
                                    && d.DocumentsStoredType.DescDocumentsStoredType.StartsWith(DocumentsStoredType)
                                    && d.FileTitle.StartsWith(FileTitle)
                                    && d.FileDescription.StartsWith(DocDescription)
                                    && d.EmployeeId == EmployeeId
                            ).ToList();

                        }
                        else
                        {
                            List = repository.GetAll().Where(d => (d.IssueDate >= Convert.ToDateTime(StartDate) && d.IssueDate <= Convert.ToDateTime(EndDate))
                                    && d.DocumentsStoredDepartment.DescDocumentsStoredDepartment.StartsWith(DocumentsStoredDepartment)
                                    && d.DocumentsStoredType.DescDocumentsStoredType.StartsWith(DocumentsStoredType)
                                    && d.FileTitle.StartsWith(FileTitle)
                                    && d.FileDescription.StartsWith(DocDescription)
                           ).ToList();

                        }

                    }
                    else
                    {
                        if (EmployeeId != 0)
                        {
                            List = repository.GetAll().Where(d => (d.ExpireDate >= Convert.ToDateTime(StartDate) && d.ExpireDate <= Convert.ToDateTime(EndDate))
                                    && d.DocumentsStoredDepartment.DescDocumentsStoredDepartment.StartsWith(DocumentsStoredDepartment)
                                    && d.DocumentsStoredType.DescDocumentsStoredType.StartsWith(DocumentsStoredType)
                                    && d.FileTitle.StartsWith(FileTitle)
                                    && d.FileDescription.StartsWith(DocDescription)
                                    && d.EmployeeId == EmployeeId
                           ).ToList();

                        }
                        else
                        {
                            List = repository.GetAll().Where(d => (d.ExpireDate >= Convert.ToDateTime(StartDate) && d.ExpireDate <= Convert.ToDateTime(EndDate))
                                    && d.DocumentsStoredDepartment.DescDocumentsStoredDepartment.StartsWith(DocumentsStoredDepartment)
                                    && d.DocumentsStoredType.DescDocumentsStoredType.StartsWith(DocumentsStoredType)
                                    && d.FileTitle.StartsWith(FileTitle)
                                    && d.FileDescription.StartsWith(DocDescription)
                           ).ToList();

                        }
                    }
                }
                else
                {
                    if (EmployeeId != 0)
                    {
                        List = repository.GetAll().Where(d => d.DocumentsStoredDepartment.DescDocumentsStoredDepartment.StartsWith(DocumentsStoredDepartment)
                                && d.DocumentsStoredType.DescDocumentsStoredType.StartsWith(DocumentsStoredType)
                                && d.FileTitle.StartsWith(FileTitle)
                                && d.FileDescription.StartsWith(DocDescription)
                                && d.EmployeeId == EmployeeId
                           ).ToList();

                    }
                    else
                    {
                        List = repository.GetAll().Where(d => d.DocumentsStoredDepartment.DescDocumentsStoredDepartment.StartsWith(DocumentsStoredDepartment)
                                && d.DocumentsStoredType.DescDocumentsStoredType.StartsWith(DocumentsStoredType)
                                && d.FileTitle.StartsWith(FileTitle)
                                && d.FileDescription.StartsWith(DocDescription)
                           ).ToList();

                    }
                }

            }

            return List;
        }


        public static bool VerifiDocByDepartment(int DocId, int DepId)
        {
            bool isDep = false;

            var list = repository.GetById(DocId).Where(p => p.DocumentsStoredDepartmentId == DepId).ToList();

            if (list.Count > 0)
                isDep = true;

            return isDep;
        }

        public static bool Insert(string FileTitle, string FileDescription, string ServerPath, string IssueDate, string ExpireDate, string FileName, int EmployeeId, int DocumentsStoredTypeId, int DocumentsStoredDepartmentId)
        {
            return repository.Insert(FileTitle, FileDescription, ServerPath, IssueDate, ExpireDate, FileName, EmployeeId, DocumentsStoredTypeId, DocumentsStoredDepartmentId);
        }

        public static bool Update(int Id, string FileTitle, string FileDescription, string ServerPath, string IssueDate, string ExpireDate, string FileName, int EmployeeId, int DocumentsStoredTypeId, int DocumentsStoredDepartmentId)
        {
            return repository.Update(Id, FileTitle, FileDescription, ServerPath, IssueDate, ExpireDate, FileName, EmployeeId, DocumentsStoredTypeId, DocumentsStoredDepartmentId);
        }
    }
}
