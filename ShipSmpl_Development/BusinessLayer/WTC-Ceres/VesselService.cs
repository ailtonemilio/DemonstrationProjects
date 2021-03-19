using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.WTC_Ceres
{
    public class VesselService
    {
        static IVesselRepository repository;

        static VesselService()
        {
            repository = new VesselRepository();
        }

        public static bool Delete(int Id)
        {
            return repository.Delete(Id);
        }

        public static List<Vessel> GetAll()
        {
            return repository.GetAll().OrderBy(p => p.VesselId).ToList();
        }

        public static int GetLastVesselId()
        {
            return repository.GetLastVesselId();
        }

        public static int GetVesselIdByVesselName(string NameVessel)
        {
            int isVesselId = 0;

            var L = repository.GetAll().Where(p => p.VesselName == NameVessel).ToList();

            foreach (var item in L)
            {
                isVesselId = item.VesselId;
            }

            return isVesselId;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Active">Bring all Vessels that are active to enter True</param>
        /// <param name="Unassigned">Enter true to include Vessel with Id 0 which is Vessel Unassigned.</param>
        /// <returns></returns>
        public static List<Vessel> GetVesselByActive(bool Active, bool Unassigned)
        {
            if (Unassigned)
                return GetAll().Where(p => p.IsActiveVessel == Active && p.VesselId != 0).ToList();
            else
                return GetAll().Where(p => p.IsActiveVessel == Active).ToList();
        }

        public static List<Vessel> GetById(int Id)
        {
            return repository.GetById(Id);
        }
        public static bool UpdateIsActive(int VesselId, bool isActive)
        {
            return repository.UpdateIsActive(VesselId, isActive);
        }
        public static bool Insert(string VesselName, string VesselOwner, string Manager, decimal Capacity, int VesselYear, string Flag, bool IsActiveVessel)
        {
            return repository.Insert(VesselName, VesselOwner, Manager, Capacity, VesselYear, Flag, IsActiveVessel);
        }
        public static bool Update(int VesselId, string VesselName, string VesselOwner, string Manager, decimal Capacity, int VesselYear, string Flag, bool IsActiveVessel)
        {
            return repository.Update(VesselId, VesselName, VesselOwner, Manager, Capacity, VesselYear, Flag, IsActiveVessel);
        }
    }
}
