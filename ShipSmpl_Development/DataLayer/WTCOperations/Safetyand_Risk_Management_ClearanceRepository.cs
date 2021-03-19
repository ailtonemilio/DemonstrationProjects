using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTCOperations
{
    public class Safetyand_Risk_Management_ClearanceRepository : ISafetyand_Risk_Management_ClearanceRepository
    {
        private WTCOperationsEntities db = new WTCOperationsEntities();
        private Safety_and_Risk_Management_Clearance sr = new Safety_and_Risk_Management_Clearance();

        public bool Delete(int Id)
        {
            bool isDelete = true;
            try
            {
                sr = db.Safety_and_Risk_Management_Clearance.Find(Id);
                db.Safety_and_Risk_Management_Clearance.Remove(sr);
                db.SaveChanges();
            }
            catch (Exception)
            {
                isDelete = false;
            }
            return isDelete;
        }

        public List<Safety_and_Risk_Management_Clearance> GetAll()
        {
            return db.Safety_and_Risk_Management_Clearance.ToList();
        }

        public List<Safety_and_Risk_Management_Clearance> GetById(int Id)
        {
            var listById = db.Safety_and_Risk_Management_Clearance.Where(p => p.ID == Id);
            return listById.ToList();
        }

        public bool Insert(int UserID, bool Worked_Hours, bool Document_Storage)
        {
            bool isSave = true;
            try
            {
                sr.userID = UserID;
                sr.Worked_Hours = Worked_Hours;
                sr.Document_Storage = Document_Storage;
                db.Safety_and_Risk_Management_Clearance.Add(sr);
                db.SaveChanges();
            }
            catch (Exception)
            {
                isSave = false;
            }
            return isSave;
        }

        public bool Update(int Id, int UserID, bool Worked_Hours, bool Document_Storage)
        {
            bool isSave = true;
            try
            {
                sr.ID = Id;
                sr.userID = UserID;
                sr.Worked_Hours = Worked_Hours;
                sr.Document_Storage = Document_Storage;
                db.Safety_and_Risk_Management_Clearance.AddOrUpdate(sr);
                db.SaveChanges();
            }
            catch (Exception)
            {
                isSave = false;
            }
            return isSave;
        }
    }

    public interface ISafetyand_Risk_Management_ClearanceRepository
    {
        List<Safety_and_Risk_Management_Clearance> GetAll();

        List<Safety_and_Risk_Management_Clearance> GetById(int Id);

        bool Insert(int UserID, bool Worked_Hours, bool Document_Storage);

        bool Update(int Id, int UserID, bool Worked_Hours, bool Document_Storage);

        bool Delete(int Id);
    }
}