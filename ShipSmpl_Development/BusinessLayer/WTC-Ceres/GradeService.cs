using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.WTC_Ceres
{
    public class GradeService
    {
        private static IGradeRepository repository;

        static GradeService()
        {
            repository = new GradeRepository();
        }

        public static List<Grade> GetAll()
        {
            return repository.GetAll();
        }

        public static List<Grade> GetAll(WTCCeresEntities db)
        {
            return repository.GetAll(db);
        }

        public static Grade GetById(int GradeId)
        {
            return repository.GetById(GradeId);
        }

        public static bool VerifyByGradeCode(string GradeCode)
        {
            bool isCode = false;

            var list = repository.GetAll().Where(c => c.GradeCode.Equals(GradeCode)).ToList();

            if (list.Count > 0)
                isCode = true;

            return isCode;
        }

        public static bool Update(int GradeId, string GradeCode, string GradeName)
        {
            return repository.Update(GradeId, GradeCode, GradeName);
        }

        public static bool Insert(string GradeCode, string GradeName)
        {
            return repository.Insert(GradeCode, GradeName);
        }

        public static bool Delete(int GradeId)
        {
            return repository.Delete(GradeId);
        }
    }
}