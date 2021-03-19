using ModelLayer;
using ModelLayer.CustomModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private Employees em = new Employees();

        public bool Delete(int Id)
        {
            bool isDelete = true;
            try
            {
                using (WTCOperationsEntities db = new WTCOperationsEntities())
                {
                    em = db.Employees.Find(Id);
                    db.Employees.Remove(em);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                isDelete = false;
            }
            return isDelete;
        }

        public List<Employees> GetAll()
        {
            using (WTCOperationsEntities db = new WTCOperationsEntities())
            {
                return db.Employees.ToList();
            }
        }

        public Employees GetById(int Id)
        {
            using (WTCOperationsEntities db = new WTCOperationsEntities())
            {
                return db.Employees.Find(Id);
            }
        }

        /// <summary>
        /// The method that returns Employee's Last Name, First Name and Alias
        /// </summary>
        /// <returns>List LastName</returns>
        public List<EmployeeName> GetFirstNameLastName()
        {
            using (WTCOperationsEntities db = new WTCOperationsEntities())
            {
                var listEmployeeName = new List<EmployeeName>();

                var list = (from e in db.Employees
                            where e.Status == "Active"
                            select new
                            {
                                EmployeeId = e.ID,
                                FisrtNameLastName = " (" + e.Alias + ") " + e.First_Name + ", " + e.Last_Name
                            }).ToList();

                listEmployeeName.Clear();

                foreach (var item in list)
                {
                    listEmployeeName.Add(new EmployeeName { EmployeeId = item.EmployeeId, FisrtNameLastName = item.FisrtNameLastName });
                }

                return listEmployeeName.OrderBy(x => x.FisrtNameLastName).ToList();
            }
        }

        public List<EmployeeWorking> GetEmployeeWorking()
        {
            using (WTCOperationsEntities db = new WTCOperationsEntities())
            {
                var listEmployeeWorking = new List<EmployeeWorking>();

                var L = (from e in db.Employees
                         join ts in db.Time_Sheet on e.ID equals ts.UserID
                         where ts.End_Time_Date == null && ts.Start_Time_Date != null
                         select new
                         {
                             FirstName = e.First_Name,
                             LastName = e.Last_Name,
                             PhoneNumber = e.Phone_Number,
                             StartTimeDate = ts.Start_Time_Date,
                             SiteLocation = ts.Site_Location,
                             Supervisor = e.Supervisor
                         });

                foreach (var item in L)
                    listEmployeeWorking.Add(new EmployeeWorking()
                    {
                        FirstName = item.FirstName,
                        LastName = item.LastName,
                        PhoneNumber = item.PhoneNumber,
                        SiteLocation = item.SiteLocation,
                        StartTimeDate = item.StartTimeDate,
                        Supervisor = item.Supervisor
                    });

                return listEmployeeWorking.ToList();
            }
        }

        public bool Insert(string Card_ID
                           , string Phone_ID
                           , string First_Name
                           , string Last_Name
                           , string Alias
                           , string Address
                           , string TypeEmployee
                           , string Yard
                           , string Status
                           , string EmployeePicturePath
                           , string Phone_Number
                           , DateTime Start_Date
                           , DateTime End_Date
                           , string FirstName_Emerg_Contact
                           , string LastName_Emerg_Contact
                           , string PhoneNumber_Emerg_Contact
                           , string Relationship_Emerg_Contact
                           , DateTime Birth_Date
                           , string SIN_Number
                           , string Gender
                           , string Job_Description
                           , string Pay_Method
                           , string Supervisor
                           , string Email)
        {
            bool isSave = true;
            try
            {
                using (WTCOperationsEntities db = new WTCOperationsEntities())
                {
                }
            }
            catch (Exception)
            {
                isSave = false;
            }
            return isSave;
        }

        public bool Update(int Id
                           , string Card_ID
                           , string Phone_ID
                           , string First_Name
                           , string Last_Name
                           , string Alias
                           , string Address
                           , string TypeEmployee
                           , string Yard
                           , string Status
                           , string EmployeePicturePath
                           , string Phone_Number
                           , DateTime Start_Date
                           , DateTime End_Date
                           , string FirstName_Emerg_Contact
                           , string LastName_Emerg_Contact
                           , string PhoneNumber_Emerg_Contact
                           , string Relationship_Emerg_Contact
                           , DateTime Birth_Date
                           , string SIN_Number
                           , string Gender
                           , string Job_Description
                           , string Pay_Method
                           , string Supervisor
                           , string Email
            )
        {
            bool isSave = true;
            try
            {
                using (WTCOperationsEntities db = new WTCOperationsEntities())
                {
                    //  em.Employee = Id;
                    em = db.Employees.Find(Id);
                    em.Card_ID = Card_ID;
                    em.Phone_ID = Phone_ID;
                    em.First_Name = First_Name;
                    em.Last_Name = Last_Name;
                    em.Alias = Alias;
                    em.Address = Address;
                    em.Type = TypeEmployee;
                    em.Yard = Yard;
                    em.Status = Status;
                    em.EmployeePicturePath = EmployeePicturePath;
                    em.Phone_Number = Phone_Number;
                    em.Start_Date = Start_Date;
                    em.End_Date = End_Date;
                    em.FirstName_Emerg_Contact = FirstName_Emerg_Contact;
                    em.LastName_Emerg_Contact = LastName_Emerg_Contact;
                    em.PhoneNumber_Emerg_Contact = PhoneNumber_Emerg_Contact;
                    em.Relationship_Emerg_Contact = Relationship_Emerg_Contact;
                    em.Birth_Date = Birth_Date;
                    em.SIN_Number = SIN_Number;
                    em.Gender = Gender;
                    em.Job_Description = Job_Description;
                    em.Pay_Method = Pay_Method;
                    em.Supervisor = Supervisor;
                    em.Email = Email;
                    db.Employees.AddOrUpdate(em);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                isSave = false;
            }
            return isSave;
        }
    }

    public interface IEmployeeRepository
    {
        List<Employees> GetAll();

        List<EmployeeName> GetFirstNameLastName();

        Employees GetById(int Id);

        List<EmployeeWorking> GetEmployeeWorking();

        bool Insert(string Card_ID
                           , string Phone_ID
                           , string First_Name
                           , string Last_Name
                           , string Alias
                           , string Address
                           , string TypeEmployee
                           , string Yard
                           , string Status
                           , string EmployeePicturePath
                           , string Phone_Number
                           , DateTime Start_Date
                           , DateTime End_Date
                           , string FirstName_Emerg_Contact
                           , string LastName_Emerg_Contact
                           , string PhoneNumber_Emerg_Contact
                           , string Relationship_Emerg_Contact
                           , DateTime Birth_Date
                           , string SIN_Number
                           , string Gender
                           , string Job_Description
                           , string Pay_Method
                           , string Supervisor
                           , string Email);

        bool Update(int Id
                           , string Card_ID
                           , string Phone_ID
                           , string First_Name
                           , string Last_Name
                           , string Alias
                           , string Address
                           , string TypeEmployee
                           , string Yard
                           , string Status
                           , string EmployeePicturePath
                           , string Phone_Number
                           , DateTime Start_Date
                           , DateTime End_Date
                           , string FirstName_Emerg_Contact
                           , string LastName_Emerg_Contact
                           , string PhoneNumber_Emerg_Contact
                           , string Relationship_Emerg_Contact
                           , DateTime Birth_Date
                           , string SIN_Number
                           , string Gender
                           , string Job_Description
                           , string Pay_Method
                           , string Supervisor
                           , string Email);

        bool Delete(int Id);
    }
}