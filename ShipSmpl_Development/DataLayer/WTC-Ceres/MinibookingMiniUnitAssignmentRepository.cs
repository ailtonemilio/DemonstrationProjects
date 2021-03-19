using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class MinibookingMiniUnitAssignmentRepository : IMinibookingMiniUnitAssignmentRepository
    {
        private MinibookingMiniUnitAssignment bus = new MinibookingMiniUnitAssignment();
        private GrainInvMinibookingAssignment gima = new GrainInvMinibookingAssignment();

        public bool Delete(int MinibookingMiniUnitAssignmentId, bool IsStorageUnit)
        {
            bool isDeleted = true;
            try
            {
                using (WTCCeresEntities db = new WTCCeresEntities())
                {
                    if (IsStorageUnit == false)
                    {
                        bus = db.MinibookingMiniUnitAssignment.Find(MinibookingMiniUnitAssignmentId);
                        db.MinibookingMiniUnitAssignment.Remove(bus);
                    }
                    else
                    {
                        gima = db.GrainInvMinibookingAssignment.Find(MinibookingMiniUnitAssignmentId);
                        db.GrainInvMinibookingAssignment.Remove(gima);
                    }

                    db.SaveChanges();
                }
            }
            catch
            {
                isDeleted = false;
            }
            return isDeleted;
        }

        public List<MinibookingMiniUnitAssignment> GetAll()
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var list = db.MinibookingMiniUnitAssignment.ToList();

                return list;
            }
        }

        public List<VW_MinibookingMiniUnitAssignment> GetByBookingNumber(string BookingNumber)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var list = db.VW_MinibookingMiniUnitAssignment.Where(bu => bu.BookingNumber == BookingNumber);

                return list.ToList();
            }
        }

        public List<VW_MinibookingMiniUnitAssignment> GetByOriginalBookingNumber(string BookingNumber)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var list = db.VW_MinibookingMiniUnitAssignment.Where(bu => bu.BookingNumber == BookingNumber);

                return list.ToList();
            }
        }

        public List<VW_MinibookingMiniUnitAssignment> GetByMiniBookingId(int MiniBookingId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var list = db.VW_MinibookingMiniUnitAssignment.Where(bu => bu.MinibookingId == MiniBookingId);

                return list.ToList();
            }
        }

        public List<VW_MinibookingMiniUnitAssignment> GetByMiniUnitId(int MiniUnitId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var list = db.VW_MinibookingMiniUnitAssignment.Where(bu => bu.MiniUnitId == MiniUnitId).OrderBy(bu => bu.AssignedAt);

                return list.ToList();
            }
        }

        public List<VW_MinibookingMiniUnitAssignment> GetByUnitId(int UnitSourceId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var list = db.VW_MinibookingMiniUnitAssignment.Where(bu => bu.UnitSourceId == UnitSourceId);

                return list.ToList();
            }
        }

        public bool Insert(int MinibookingId, int MiniunitId)
        {
            bool isSaved = true;
            try
            {
                using (WTCCeresEntities db = new WTCCeresEntities())
                {
                    bus.MinibookingId = MinibookingId;
                    bus.MiniUnitId = MiniunitId;
                    bus.AssignedAt = DateTime.Now;
                    db.MinibookingMiniUnitAssignment.Add(bus);
                    db.SaveChanges();
                }
            }
            catch
            {
                isSaved = false;
            }
            return isSaved;
        }

        public bool MiniUnitAlreadyAssigned(int muORStorageId, int mbId, bool isStorageUnit)
        {
            bool muAlreadyAsn = false;
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                if (isStorageUnit == false)
                {
                    muAlreadyAsn = db.VW_MinibookingMiniUnitAssignment.Where(mbmu => mbmu.MiniUnitId == muORStorageId
                                                                            && mbmu.MinibookingId == mbId
                                                                            && mbmu.isStorageUnit == isStorageUnit).ToList().Count > 0;
                }
                else
                {
                    muAlreadyAsn = db.VW_MinibookingMiniUnitAssignment.Where(mbmu => mbmu.GrainInvStorageLocationId == muORStorageId
                                                                            && mbmu.MinibookingId == mbId
                                                                            && mbmu.isStorageUnit == isStorageUnit).ToList().Count > 0;
                }

                return muAlreadyAsn;
            }
        }

        public bool Update(int MinibookingMiniUnitAssignmentId, int MinibookingId, int MiniunitId)
        {
            bool isUpdated = true;
            try
            {
                using (WTCCeresEntities db = new WTCCeresEntities())
                {
                    bus = db.MinibookingMiniUnitAssignment.Find(MinibookingMiniUnitAssignmentId);
                    bus.MinibookingId = MinibookingId;
                    bus.MiniUnitId = MiniunitId;
                    db.MinibookingMiniUnitAssignment.AddOrUpdate(bus);
                    db.SaveChanges();
                }
            }
            catch
            {
                isUpdated = false;
            }
            return isUpdated;
        }
    }

    public interface IMinibookingMiniUnitAssignmentRepository
    {
        List<MinibookingMiniUnitAssignment> GetAll();

        List<VW_MinibookingMiniUnitAssignment> GetByMiniBookingId(int MiniBookingId);

        List<VW_MinibookingMiniUnitAssignment> GetByBookingNumber(string BookingNumber);

        List<VW_MinibookingMiniUnitAssignment> GetByOriginalBookingNumber(string BookingNumber);

        List<VW_MinibookingMiniUnitAssignment> GetByUnitId(int UnitId);

        List<VW_MinibookingMiniUnitAssignment> GetByMiniUnitId(int MiniUnitId);

        bool Update(int MinibookingMiniUnitAssignmentId, int MinibookingId, int MiniunitId);

        bool Delete(int MinibookingMiniUnitAssignmentId, bool IsStorageUnit);

        bool Insert(int MinibookingId, int MiniunitId);

        bool MiniUnitAlreadyAssigned(int muORStorageId, int mbId, bool isStorageUnit);
    }
}