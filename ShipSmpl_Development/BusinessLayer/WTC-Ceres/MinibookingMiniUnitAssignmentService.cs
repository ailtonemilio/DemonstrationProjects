using DataLayer.WTC_Ceres;
using ModelLayer;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class MinibookingMiniUnitAssignmentService
    {
        private static IMinibookingMiniUnitAssignmentRepository repository;

        static MinibookingMiniUnitAssignmentService()
        {
            repository = new MinibookingMiniUnitAssignmentRepository();
        }

        public static List<MinibookingMiniUnitAssignment> GetAll()
        {
            return repository.GetAll();
        }

        public static List<VW_MinibookingMiniUnitAssignment> GetByMiniBookingId(int MiniBookingId)
        {
            return repository.GetByMiniBookingId(MiniBookingId);
        }

        public static List<VW_MinibookingMiniUnitAssignment> GetByUnitSourceId(int UnitSourceId)
        {
            return repository.GetByUnitId(UnitSourceId);
        }

        public static List<VW_MinibookingMiniUnitAssignment> GetByBookingNumber(string BookingNumber)
        {
            return repository.GetByBookingNumber(BookingNumber);
        }

        public static List<VW_MinibookingMiniUnitAssignment> GetByMiniUnitId(int MiniUnitId)
        {
            return repository.GetByMiniUnitId(MiniUnitId);
        }

        public bool Update(int MinibookingMiniUnitAssignmentId, int MinibookingId, int MiniunitId)
        {
            return repository.Update(MinibookingMiniUnitAssignmentId, MinibookingId, MiniunitId);
        }

        public bool Delete(int MinibookingMiniUnitAssignmentId, bool IsStorageUnit)
        {
            return repository.Delete(MinibookingMiniUnitAssignmentId, IsStorageUnit);
        }

        public bool Insert(int MinibookingId, int MiniunitId)
        {
            return repository.Insert(MinibookingId, MiniunitId);
        }

        public bool MiniUnitAlreadyAssigned(int muORStorageId, int mbId, bool isStorageUnit)
        {
            return repository.MiniUnitAlreadyAssigned(muORStorageId, mbId, isStorageUnit);
        }

        public static List<VW_MinibookingMiniUnitAssignment> GetByOriginalBookingNumber(string OriginalBookingNumber)
        {
            return repository.GetByOriginalBookingNumber(OriginalBookingNumber);
        }
    }
}