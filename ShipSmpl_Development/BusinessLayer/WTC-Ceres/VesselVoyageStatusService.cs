using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.WTC_Ceres
{
    public class VesselVoyageStatusService
    {
        static IVesselTripStatusRepository repository;

        static VesselVoyageStatusService()
        {
            repository = new VesselVoyageStatusRepository();
        }

        public static bool Delete(int Id)
        { return repository.Delete(Id); }

        public static int GetStatusIdByStatus(string StatusName)
        {
            int StaId = 0;

            var L = repository.GetAll().Where(p => p.StatusName == StatusName.ToUpper()).ToList();

            foreach (var item in L)
            {
                StaId = item.VesselVoyageStatusId;
            }

            return StaId;
        }

        public static List<VesselVoyageStatus> GetAll()
        { return repository.GetAll().OrderBy(p => p.VesselVoyageStatusId).ToList(); }

        public static List<VesselVoyageStatus> GetById(int Id)
        { return repository.GetById(Id); }

        public static bool Insert(string StatusName)
        { return repository.Insert(StatusName); }

        public static bool Update(int VesselStatusId, string StatusName)
        { return repository.Update(VesselStatusId, StatusName); }
    }
}
