using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class VesselRepository : IVesselRepository
    {
        private Vessel v = new Vessel();
        private WTCCeresEntities db = new WTCCeresEntities();

        public bool Delete(int Id)
        {
            bool isSaved = true;
            try
            {
                using (WTCCeresEntities d = new WTCCeresEntities())
                {
                    v = d.Vessel.Find(Id);
                    d.Vessel.Remove(v);
                    d.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                string msg = ex.ToString();
                isSaved = false;
            }
            return isSaved;
        }

        public List<Vessel> GetAll()
        {
            using (WTCCeresEntities d = new WTCCeresEntities())
            {
                return d.Vessel.ToList();
            }
        }

        public List<Vessel> GetById(int Id)
        {
            var listById = db.Vessel.Where(p => p.VesselId == Id);
            return listById.ToList();
        }

        public int GetLastVesselId()
        {
            using (WTCCeresEntities d = new WTCCeresEntities())
            {
                var List = (from r in d.Vessel
                            orderby r.VesselId descending
                            select r).First();

                return List.VesselId;
            }
        }

        public bool Insert(string VesselName, string VesselOwner, string Manager, decimal Capacity, int VesselYear, string Flag, bool IsActiveVessel)
        {
            bool isSave = true;
            try
            {
                using (WTCCeresEntities d = new WTCCeresEntities())
                {
                    v.VesselName = VesselName;
                    v.VesselOwner = VesselOwner;
                    v.Manager = Manager;
                    v.Capacity = Capacity;
                    v.VesselYear = VesselYear;
                    v.Flag = Flag;
                    v.IsActiveVessel = IsActiveVessel;
                    d.Vessel.Add(v);
                    d.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                string msg = ex.ToString();
                isSave = false;
            }
            return isSave;
        }

        public bool Update(int VesselId, string VesselName, string VesselOwner, string Manager, decimal Capacity, int VesselYear, string Flag, bool IsActiveVessel)
        {
            bool isSave = true;
            try
            {
                using (WTCCeresEntities d = new WTCCeresEntities())
                {
                    v = db.Vessel.Find(VesselId);
                    v.VesselId = VesselId;
                    v.VesselName = VesselName;
                    v.VesselOwner = VesselOwner;
                    v.Manager = Manager;
                    v.Capacity = Capacity;

                    if (VesselYear == 0)
                        v.VesselYear = null;
                    else
                        v.VesselYear = VesselYear;

                    v.Flag = Flag;
                    v.IsActiveVessel = IsActiveVessel;
                    d.Vessel.AddOrUpdate(v);
                    d.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                string msg = ex.ToString();
                isSave = false;
            }
            return isSave;
        }

        public bool UpdateIsActive(int VesselId, bool isActive)
        {
            bool isSave = true;
            try
            {
                v = db.Vessel.Find(VesselId);
                v.IsActiveVessel = isActive;
                db.Vessel.Attach(v);
                db.Entry(v).Property(p => p.IsActiveVessel).IsModified = true;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                string msg = ex.ToString();
                isSave = false;
            }
            return isSave;
        }
    }

    public interface IVesselRepository
    {
        List<Vessel> GetAll();
        List<Vessel> GetById(int Id);
        //List<VesselList> GetVesselListAll();
        int GetLastVesselId();
        bool UpdateIsActive(int VesselId, bool isActive);
        bool Insert(string VesselName, string VesselOwner, string Manager, decimal Capacity, int VesselYear, string Flag, bool IsActiveVessel);
        bool Update(int VesselId, string VesselName, string VesselOwner, string Manager, decimal Capacity, int VesselYear, string Flag, bool IsActiveVessel);
        bool Delete(int Id);
    }
}
