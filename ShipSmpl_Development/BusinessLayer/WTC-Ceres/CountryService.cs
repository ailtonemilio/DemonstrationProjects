using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.WTC_Ceres
{
    public class CountryService
    {
        private static ICountryRepository repository;

        static CountryService()
        {
            repository = new CountryRepository();
        }

        public static bool Delete(int Id)
        {
            return repository.Delete(Id);
        }

        public static List<Country> GetAll()
        {
            return repository.GetAll().OrderBy(p => p.CountryName).ToList();
        }

        public static List<Country> GetAll(WTCCeresEntities db)
        {
            return repository.GetAll(db);
        }

        public static List<Country> GetCountryDropBox()
        {
            var listCountry = new List<Country>();
            var L = repository.GetAll();

            listCountry.Clear();

            listCountry.Add(new Country { CountryId = 0, Code = "", CountryName = "", PhoneCode = 0 });

            foreach (var item in L)
            {
                listCountry.Add(new Country { CountryId = item.CountryId, Code = item.Code, CountryName = item.CountryName.ToUpper(), PhoneCode = item.PhoneCode });
            }

            return listCountry.ToList();
        }

        public static List<Country> GetById(int Id)
        {
            return repository.GetById(Id);
        }

        public static bool Insert(string Code, string CountryName, int PhoneCode)
        {
            return repository.Insert(Code, CountryName, PhoneCode);
        }

        public static bool Update(int CountryId, string Code, string CountryName, int PhoneCode)
        {
            return repository.Update(CountryId, Code, CountryName, PhoneCode);
        }
    }
}