using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class ContainerMinibookingRepository : IContainerMinibookingRepository
    {
        private WTCCeresEntities db = new WTCCeresEntities();
        private ContainerMinibooking cm = new ContainerMinibooking();

        public bool Delete(int Id)
        {
            bool isDeleted = true;
            try
            {
                cm = db.ContainerMinibooking.Find(Id);
                db.ContainerMinibooking.Remove(cm);
                db.SaveChanges();
            }
            catch
            {
                isDeleted = false;
            }
            return isDeleted;
        }

        public List<ContainerMinibooking> GetById(int Id)
        {
            var listById = db.ContainerMinibooking.Where(c => c.ContainerMinibookingId == Id);

            return listById.ToList();
        }

        public List<VW_ContainersByBooking> GetContainersAssignedByMbId(int Id)
        {
            try
            {
                var listById = db.VW_ContainersByBooking.Where(c => c.MiniBookingId == Id);

                return listById.ToList();
            }
            catch
            {
                return null;
            }
        }

        public bool Insert(int ContainerInOutId, int minibookingId)
        {
            bool isSaved = true;
            try
            {
                var can = new ContainerMinibooking();
                can.ContainerInOutId = ContainerInOutId;
                can.MinibookingId = minibookingId;
                can.AssignedAt = DateTime.Now;
                db.ContainerMinibooking.AddOrUpdate(can);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                isSaved = false;
            }

            return isSaved;
        }
    }
}

public interface IContainerMinibookingRepository
{
    bool Insert(int ContainerInOutId, int minibookingId);

    List<ContainerMinibooking> GetById(int Id);

    List<VW_ContainersByBooking> GetContainersAssignedByMbId(int Id);

    bool Delete(int Id);
}