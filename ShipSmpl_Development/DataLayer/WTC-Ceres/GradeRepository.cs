using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class GradeRepository : IGradeRepository
    {
        private WTCCeresEntities db = new WTCCeresEntities();
        private Grade g = new Grade();

        public bool Insert(string GradeCode, string GradeName)
        {
            bool isSaved = true;
            try
            {
                var gr = new Grade();
                gr.GradeCode = GradeCode;
                gr.GradeName = GradeName;

                db.Grade.AddOrUpdate(gr);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                isSaved = false;
            }

            return isSaved;
        }

        public bool Delete(int GradeId)
        {
            bool isSaved = true;
            try
            {
                g = db.Grade.Find(GradeId);
                db.Grade.Remove(g);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                isSaved = false;
            }

            return isSaved;
        }

        public List<Grade> GetAll()
        {
            return db.Grade.OrderBy(g => g.GradeName).ToList();
        }

        public List<Grade> GetAll(WTCCeresEntities db)
        {
            return db.Grade.OrderBy(g => g.GradeName).ToList();
        }

        public Grade GetById(int Id)
        {
            return db.Grade.Find(Id);
        }

        public bool Update(int GradeId, string GradeCode, string GradeName)
        {
            bool isSaved = true;
            try
            {
                g = db.Grade.Find(GradeId);
                g.GradeCode = GradeCode;
                g.GradeName = GradeName;

                db.Grade.AddOrUpdate(g);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                isSaved = false;
            }

            return isSaved;
        }
    }

    public interface IGradeRepository
    {
        List<Grade> GetAll();

        List<Grade> GetAll(WTCCeresEntities db);

        Grade GetById(int GradeId);

        bool Update(int GradeId, string GradeCode, string GradeName);

        bool Insert(string GradeCode, string GradeName);

        bool Delete(int GradeId);
    }
}