using DataLayer.WTCOperations;
using ModelLayer;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.WTCOperations
{
    public class Safetyand_Risk_Management_ClearanceService
    {
        private static ISafetyand_Risk_Management_ClearanceRepository repository;

        static Safetyand_Risk_Management_ClearanceService()
        {
            repository = new Safetyand_Risk_Management_ClearanceRepository();
        }

        public static bool Delete(int Id)
        {
            return repository.Delete(Id);
        }

        public static List<Safety_and_Risk_Management_Clearance> GetAll()
        {
            return repository.GetAll();
        }

        public static List<Safety_and_Risk_Management_Clearance> GetByUserId(int UserId)
        {
            var listManagement = new List<Safety_and_Risk_Management_Clearance>();
            listManagement = repository.GetAll().Where(p => p.userID == UserId).ToList();

            return listManagement;
        }

        public static List<Safety_and_Risk_Management_Clearance> GetById(int Id)
        {
            return repository.GetById(Id);
        }

        public bool Insert(int UserID, bool Worked_Hours, bool Document_Storage)
        {
            return repository.Insert(UserID, Worked_Hours, Document_Storage);
        }

        public bool Update(int Id, int UserID, bool Worked_Hours, bool Document_Storage)
        {
            return repository.Update(Id, UserID, Worked_Hours, Document_Storage);
        }
    }
}