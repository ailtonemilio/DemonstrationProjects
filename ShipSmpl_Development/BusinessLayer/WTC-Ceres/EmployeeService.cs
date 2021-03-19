using DataLayer.WTC_Ceres;
using ModelLayer;
using ModelLayer.CustomModel;
using System;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class EmployeeService
    {
        private static IEmployeeRepository repository;

        static EmployeeService()
        {
            repository = new EmployeeRepository();
        }

        public static bool Delete(int Id)
        {
            return repository.Delete(Id);
        }

        public static List<Employees> GetAll()
        {
            return repository.GetAll();
        }

        public static Employees GetById(int Id)
        {
            return repository.GetById(Id);
        }

        public static List<EmployeeName> GetFirstNameLastName()
        {
            return repository.GetFirstNameLastName();
        }
        public static List<EmployeeWorking> GetEmployeeWorking()
        {
            return repository.GetEmployeeWorking();
        }
        public static List<EmployeeName> GetFirstNameLastNameForDropBox()
        {
            var listDoc = new List<EmployeeName>();
            var list = repository.GetFirstNameLastName();

            listDoc.Clear();
            listDoc.Add(new EmployeeName { EmployeeId = 0, FisrtNameLastName = "ALL" });

            foreach (var item in list)
            {
                listDoc.Add(new EmployeeName { EmployeeId = item.EmployeeId, FisrtNameLastName = item.FisrtNameLastName });
            }

            return listDoc;
        }

        public static bool Insert(string Card_ID
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
            return repository.Insert(Card_ID
                           , Phone_ID
                           , First_Name
                           , Last_Name
                           , Alias
                           , Address
                           , TypeEmployee
                           , Yard
                           , Status
                           , EmployeePicturePath
                           , Phone_Number
                           , Start_Date
                           , End_Date
                           , FirstName_Emerg_Contact
                           , LastName_Emerg_Contact
                           , PhoneNumber_Emerg_Contact
                           , Relationship_Emerg_Contact
                           , Birth_Date
                           , SIN_Number
                           , Gender
                           , Job_Description
                           , Pay_Method
                           , Supervisor
                           , Email);
        }

        public static bool Update(int Id
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
            return repository.Update(Id
                           , Card_ID
                           , Phone_ID
                           , First_Name
                           , Last_Name
                           , Alias
                           , Address
                           , TypeEmployee
                           , Yard
                           , Status
                           , EmployeePicturePath
                           , Phone_Number
                           , Start_Date
                           , End_Date
                           , FirstName_Emerg_Contact
                           , LastName_Emerg_Contact
                           , PhoneNumber_Emerg_Contact
                           , Relationship_Emerg_Contact
                           , Birth_Date
                           , SIN_Number
                           , Gender
                           , Job_Description
                           , Pay_Method
                           , Supervisor
                           , Email);
        }
    }
}