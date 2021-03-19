using DataLayer.WTC_Ceres;
using ModelLayer;
using ModelLayer.CustomModel;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.WTC_Ceres
{
    public class VesselVoyageService
    {
        private static IVesselTripRepository repository;

        static VesselVoyageService()
        {
            repository = new VesselVoyageRepository();
        }

        public static bool Delete(int Id)
        {
            return repository.Delete(Id);
        }

        public static List<VesselVoyage> GetAll()
        {
            return repository.GetAll().OrderBy(p => p.VesselVoyageId).ToList();
        }

        public static List<VesselVoyage> GetById(int Id)
        {
            return repository.GetById(Id);
        }

        public static VesselVoyageList GetVesselVoyageVWById(int Id)
        {
            return repository.GetVesselVoyageVWById(Id);
        }

        public static VesselVoyageList GetVesselVoyageVWById(int Id, WTCCeresEntities db)
        {
            return repository.GetVesselVoyageVWById(Id, db);
        }

        public static int GetLastVesselVoyageId()
        {
            return repository.GetLastVesselVoyageId();
        }

        public static List<VesselVoyage> GetVesselByActive(bool Active, bool Unassigned)
        {
            if (Unassigned)
                return GetAll().Where(p => p.IsActiveTrip == Active).ToList();
            else
                return GetAll().Where(p => p.IsActiveTrip == Active && p.VesselVoyageId != 0).ToList();
        }

        public static List<VesselVoyageList> GetVesselVoyageAllList(bool Active)
        {
            return repository.GetVesselVoyageAllList().Where(p => p.IsActiveTrip == Active).ToList();
        }

        public static List<VesselVoyageList> GetVesselVoyageListAll()
        {
            return repository.GetVesselVoyageAllList().ToList();
        }

        public static List<VesselVoyageList> GetVesselVoyageListByFilters(string SearchWord)
        {
            return repository.GetVesselVoyageListByFilters(SearchWord);
        }

        public static int GetVesselVoyageIdByVoyageNumber(string VoyageNumber)
        {
            int VoyId = 0;

            var L = repository.GetAll().Where(p => p.VoyageNumber.TrimEnd().ToUpper() == VoyageNumber.TrimEnd().ToUpper()).ToList();

            foreach (var item in L)
            {
                VoyId = item.VesselVoyageId;
            }

            return VoyId;
        }

        public static bool GetVerificationVesselVoyageByVesselId(int VesselId)
        {
            bool isVerify = false;

            var L = repository.GetAll().Where(p => p.VesselId == VesselId).ToList();

            if (L.Count > 0)
                isVerify = true;

            return isVerify;
        }

        public static bool GetVerificationActiveVoyageByVoyageNumber(string VoyageNumber, int PortId)
        {
            bool isUnique = false;

            var L = repository.GetAll().Where(p => p.IsActiveTrip == true && p.PortId == PortId && p.VoyageNumber == VoyageNumber).ToList();

            if (L.Count > 0)
                isUnique = true;

            return isUnique;
        }

        public static bool GetVerifyActiveVoyageByVesselAndPort(int VesselId, int PortId)
        {
            bool isUnique = false;

            var L = repository.GetAll().Where(p => p.IsActiveTrip == true && p.PortId == PortId && p.VesselId == VesselId).ToList();

            if (L.Count > 0)
                isUnique = true;

            return isUnique;
        }

        public static bool GetUniqueActiveVoyageByVoyageNumber_Vessel_Port(string VoyageNumber, int VesselId, int PortId)
        {
            bool isUnique = false;

            var L = repository.GetAll().Where(p => p.IsActiveTrip == true && p.PortId == PortId && p.VesselId == VesselId && p.VoyageNumber == VoyageNumber).ToList();

            if (L.Count > 0)
                isUnique = true;

            return isUnique;
        }

        public static bool GetUniqueActiveVoyageByVoyageNumber_Vessel_Port_Update(string VoyageNumber, int VesselId, int PortId, int VesselVoyageId)
        {
            bool isUpdate = false;

            var L = repository.GetAll().Where(p => p.IsActiveTrip == true && p.PortId == PortId && p.VesselId == VesselId && p.VoyageNumber == VoyageNumber).ToList();

            switch (L.Count)
            {
                case 0:
                    isUpdate = true;
                    break;

                case 1:
                    foreach (var item in L)
                    {
                        if (item.VesselVoyageId == VesselVoyageId)
                            isUpdate = true;
                    }
                    break;

                default:
                    isUpdate = false;
                    break;
            }

            return isUpdate;
        }

        public static int GetVesselVoyageIdByVoyageNumber_Vessel_Port(string VoyageNumber, int VesselId, int PortId)
        {
            int isVesselVoyageId = 0;

            var L = repository.GetAll().Where(p => p.PortId == PortId && p.VesselId == VesselId && p.VoyageNumber == VoyageNumber).ToList();

            foreach (var item in L)
            {
                isVesselVoyageId = item.VesselVoyageId;
            }

            return isVesselVoyageId;
        }

        public static bool Insert(string VoyageNumber, string ERD, string LRD, string ETA, string ETD, string PortCity, string PortCountry, bool IsActiveTrip, int VesselVoyageStatusId, int VesselId, int PortId)
        {
            return repository.Insert(VoyageNumber, ERD, LRD, ETA, ETD, PortCity, PortCountry, IsActiveTrip, VesselVoyageStatusId, VesselId, PortId);
        }

        public static bool UpdateIsActive(int VesselVoyageId, bool isActive)
        {
            return repository.UpdateIsActive(VesselVoyageId, isActive);
        }

        public static bool UpdateIsActiveDateLRDLessThanYesterday()
        {
            return repository.UpdateIsActiveDateLRDLessThanYesterday();
        }

        public static bool Update(int VesselTripId, string VoyageNumber, string ERD, string LRD, string ETA, string ETD, string PortCity, string PortCountry, bool IsActiveTrip, int VesselVoyageStatusId, int VesselId, int PortId)
        {
            return repository.Update(VesselTripId, VoyageNumber, ERD, LRD, ETA, ETD, PortCity, PortCountry, IsActiveTrip, VesselVoyageStatusId, VesselId, PortId);
        }
    }
}