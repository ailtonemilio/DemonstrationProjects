using ModelLayer;
using ModelLayer.CustomModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class VesselVoyageRepository : IVesselTripRepository
    {
        private VesselVoyage vv = new VesselVoyage();
        private WTCCeresEntities db = new WTCCeresEntities();

        public bool Delete(int Id)
        {
            bool isSaved = true;
            try
            {
                using (WTCCeresEntities d = new WTCCeresEntities())
                {
                    vv = d.VesselVoyage.Find(Id);
                    d.VesselVoyage.Remove(vv);
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

        public List<VesselVoyage> GetAll()
        {
            using (WTCCeresEntities d = new WTCCeresEntities())
            {
                return d.VesselVoyage.ToList();
            }
        }

        public List<VesselVoyage> GetById(int Id)
        {
            using (WTCCeresEntities d = new WTCCeresEntities())
            {
                var listById = d.VesselVoyage.Where(p => p.VesselVoyageId == Id);
                return listById.ToList();
            }
        }

        public VesselVoyageList GetVesselVoyageVWById(int Id, WTCCeresEntities d)
        {
            var listVesselVoyage = new List<VesselVoyageList>();

            var List = (from vv in d.VesselVoyage
                        join v in d.Vessel on vv.VesselId equals v.VesselId
                        join vs in d.VesselVoyageStatus on vv.VesselVoyageStatusId equals vs.VesselVoyageStatusId
                        join c in d.Company on vv.PortId equals c.CompanyId
                        where vv.VesselVoyageId == Id
                        select vv).ToList();

            foreach (var item in List)
            {
                listVesselVoyage.Add(new VesselVoyageList
                (
                    item.VesselVoyageId,
                    item.VoyageNumber,
                    Convert.ToDateTime(item.ERD),
                    Convert.ToDateTime(item.LRD),
                    Convert.ToDateTime(item.ETA),
                    Convert.ToDateTime(item.ETD),
                    //string.Format("{0:dd-MM-yyyy}", item.ERD),
                    //string.Format("{0:dd-MM-yyyy}", item.LRD),
                    //string.Format("{0:dd-MM-yyyy}", item.ETA),
                    //string.Format("{0:dd-MM-yyyy}", item.ETD),
                    Convert.ToDateTime(item.LRD),
                    item.PortCity,
                    item.PortCountry,
                    Convert.ToBoolean(item.IsActiveTrip),
                    Convert.ToInt32(item.VesselId),
                    Convert.ToInt32(item.PortId),
                    Convert.ToInt32(item.VesselVoyageStatusId),
                    item.Vessel.VesselName,
                    item.VesselVoyageStatus.StatusName,
                    item.Company.CompanyCode + " - " + item.Company.CompanyName,
                    item.Company.CompanyCode,
                    item.Company.CompanyName
                ));
            }
            if (listVesselVoyage.Count > 0)
                return listVesselVoyage.ToList()[0];
            else
                return null;
        }

        public VesselVoyageList GetVesselVoyageVWById(int Id)
        {
            var listVesselVoyage = new List<VesselVoyageList>();

            using (WTCCeresEntities d = new WTCCeresEntities())
            {
                var List = (from vv in d.VesselVoyage
                            join v in d.Vessel on vv.VesselId equals v.VesselId
                            join vs in d.VesselVoyageStatus on vv.VesselVoyageStatusId equals vs.VesselVoyageStatusId
                            join c in d.Company on vv.PortId equals c.CompanyId
                            where vv.VesselVoyageId == Id
                            select vv).ToList();

                foreach (var item in List)
                {
                    listVesselVoyage.Add(new VesselVoyageList
                    (
                        item.VesselVoyageId,
                        item.VoyageNumber,
                        Convert.ToDateTime(item.ERD),
                        Convert.ToDateTime(item.LRD),
                        Convert.ToDateTime(item.ETA),
                        Convert.ToDateTime(item.ETD),
                        //string.Format("{0:dd-MM-yyyy}", item.ERD),
                        //string.Format("{0:dd-MM-yyyy}", item.LRD),
                        //string.Format("{0:dd-MM-yyyy}", item.ETA),
                        //string.Format("{0:dd-MM-yyyy}", item.ETD),
                        Convert.ToDateTime(item.LRD),
                        item.PortCity,
                        item.PortCountry,
                        Convert.ToBoolean(item.IsActiveTrip),
                        Convert.ToInt32(item.VesselId),
                        Convert.ToInt32(item.PortId),
                        Convert.ToInt32(item.VesselVoyageStatusId),
                        item.Vessel.VesselName,
                        item.VesselVoyageStatus.StatusName,
                        item.Company.CompanyCode + " - " + item.Company.CompanyName,
                        item.Company.CompanyCode,
                        item.Company.CompanyName
                    ));
                }
                if (listVesselVoyage.Count > 0)
                    return listVesselVoyage.ToList()[0];
                else
                    return null;
            }
        }

        public int GetLastVesselVoyageId()
        {
            using (WTCCeresEntities d = new WTCCeresEntities())
            {
                var List = (from r in d.VesselVoyage
                            orderby r.VesselVoyageId descending
                            select r).First();

                return List.VesselVoyageId;
            }
        }

        public List<VesselVoyageList> GetVesselVoyageAllList()
        {
            var listVesselVoyage = new List<VesselVoyageList>();

            using (WTCCeresEntities d = new WTCCeresEntities())
            {
                var List = (from vv in d.VesselVoyage
                            join v in d.Vessel on vv.VesselId equals v.VesselId
                            join vs in d.VesselVoyageStatus on vv.VesselVoyageStatusId equals vs.VesselVoyageStatusId
                            join c in d.Company on vv.PortId equals c.CompanyId
                            select vv).ToList();

                foreach (var item in List)
                {
                    listVesselVoyage.Add(new VesselVoyageList
                    {
                        VesselVoyageId = item.VesselVoyageId,
                        VoyageNumber = item.VoyageNumber,
                        ERD = item.ERD,
                        LRD = item.LRD,
                        ETA = item.ETA,
                        ETD = item.ETD,
                        //ERD = string.Format("{0:dd-MM-yyyy}", item.ERD),
                        //LRD = string.Format("{0:dd-MM-yyyy}", item.LRD),
                        //ETA = string.Format("{0:dd-MM-yyyy}", item.ETA),
                        //ETD = string.Format("{0:dd-MM-yyyy}", item.ETD),
                        LRDDateTime = item.LRD,
                        PortCity = item.PortCity,
                        PortCountry = item.PortCountry,
                        IsActiveTrip = item.IsActiveTrip,
                        VesselId = item.VesselId,
                        PortId = item.PortId,
                        VesselVoyageStatusId = item.VesselVoyageStatusId,
                        VesselName = item.Vessel.VesselName,
                        StatusName = item.VesselVoyageStatus.StatusName,
                        CompanyCodeName = item.Company.CompanyCode.TrimEnd() + " - " + item.Company.CompanyName.TrimEnd(),
                        CompanyCode = item.Company.CompanyCode.TrimEnd(),
                        CompanyName = item.Company.CompanyName.TrimEnd()
                    });
                }

                return listVesselVoyage.ToList();
            }
        }

        public List<VesselVoyageList> GetVesselVoyageListByFilters(string SearchWord)
        {
            var listVesselVoyage = new List<VesselVoyageList>();

            using (WTCCeresEntities d = new WTCCeresEntities())
            {
                DateTime yesteday = DateTime.Now.AddDays(-1);

                var List = (from vv in d.VesselVoyage
                            join v in d.Vessel on vv.VesselId equals v.VesselId
                            join vs in d.VesselVoyageStatus on vv.VesselVoyageStatusId equals vs.VesselVoyageStatusId
                            join c in d.Company on vv.PortId equals c.CompanyId
                            select vv).Where(v => (v.LRD.HasValue && v.LRD >= yesteday.Date) &&
                                                 (v.Vessel.VesselName.Contains(SearchWord) ||
                                                 v.VoyageNumber.Contains(SearchWord) ||
                                                 v.Company.CompanyName.Contains(SearchWord))).Take(100).ToList();

                foreach (var item in List)
                {
                    listVesselVoyage.Add(new VesselVoyageList
                    {
                        VesselVoyageId = item.VesselVoyageId,
                        VoyageNumber = item.VoyageNumber,
                        ERD = item.ERD,
                        LRD = item.LRD,
                        ETA = item.ETA,
                        ETD = item.ETD,
                        //ERD = string.Format("{0:dd-MM-yyyy}", item.ERD),
                        //LRD = string.Format("{0:dd-MM-yyyy}", item.LRD),
                        //ETA = string.Format("{0:dd-MM-yyyy}", item.ETA),
                        //ETD = string.Format("{0:dd-MM-yyyy}", item.ETD),
                        LRDDateTime = item.LRD,
                        PortCity = item.PortCity,
                        PortCountry = item.PortCountry,
                        IsActiveTrip = item.IsActiveTrip,
                        VesselId = item.VesselId,
                        PortId = item.PortId,
                        VesselVoyageStatusId = item.VesselVoyageStatusId,
                        VesselName = item.Vessel.VesselName,
                        StatusName = item.VesselVoyageStatus.StatusName,
                        CompanyCodeName = item.Company.CompanyCode.TrimEnd() + " - " + item.Company.CompanyName.TrimEnd(),
                        CompanyCode = item.Company.CompanyCode.TrimEnd(),
                        CompanyName = item.Company.CompanyName.TrimEnd()
                    });
                }

                return listVesselVoyage.ToList();
            }
        }

        public bool Insert(string VoyageNumber, string ERD, string LRD, string ETA, string ETD, string PortCity, string PortCountry, bool IsActiveTrip, int VesselVoyageStatusId, int VesselId, int PortId)
        {
            bool isSave = true;
            try
            {
                using (WTCCeresEntities d = new WTCCeresEntities())
                {
                    vv.VoyageNumber = VoyageNumber;

                    if (!String.IsNullOrEmpty(ERD))
                    { vv.ERD = Convert.ToDateTime(ERD); }
                    else
                    { vv.ERD = null; }

                    if (!String.IsNullOrEmpty(LRD))
                        vv.LRD = Convert.ToDateTime(LRD);
                    else
                        vv.LRD = null;

                    if (!String.IsNullOrEmpty(ETA))
                        vv.ETA = Convert.ToDateTime(ETA);
                    else
                        vv.ETA = null;

                    if (!String.IsNullOrEmpty(ETD))
                        vv.ETD = Convert.ToDateTime(ETD);
                    else
                        vv.ETD = null;

                    vv.PortCity = PortCity;
                    vv.PortCountry = PortCountry;
                    vv.IsActiveTrip = IsActiveTrip;
                    vv.VesselVoyageStatusId = VesselVoyageStatusId;
                    vv.VesselId = VesselId;
                    vv.PortId = PortId;
                    d.VesselVoyage.Add(vv);
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

        public bool Update(int VesselTripId, string VoyageNumber, string ERD, string LRD, string ETA, string ETD, string PortCity, string PortCountry, bool IsActiveTrip, int VesselVoyageStatusId, int VesselId, int PortId)
        {
            bool isSave = true;
            try
            {
                using (WTCCeresEntities db = new WTCCeresEntities())
                {
                    vv = db.VesselVoyage.Find(VesselTripId);
                    vv.VesselVoyageId = VesselTripId;
                    vv.VoyageNumber = VoyageNumber;

                    if (!String.IsNullOrEmpty(ERD))
                        vv.ERD = Convert.ToDateTime(ERD);
                    else
                        vv.ERD = null;

                    if (!String.IsNullOrEmpty(LRD))
                        vv.LRD = Convert.ToDateTime(LRD);
                    else
                        vv.LRD = null;

                    if (!String.IsNullOrEmpty(ETA))
                        vv.ETA = Convert.ToDateTime(ETA);
                    else
                        vv.ETA = null;

                    if (!String.IsNullOrEmpty(ETD))
                        vv.ETD = Convert.ToDateTime(ETD);
                    else
                        vv.ETD = null;
                    vv.PortCity = PortCity;
                    vv.PortCountry = PortCountry;
                    vv.IsActiveTrip = IsActiveTrip;
                    vv.VesselVoyageStatusId = VesselVoyageStatusId;
                    vv.VesselId = VesselId;
                    vv.PortId = PortId;
                    db.VesselVoyage.AddOrUpdate(vv);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                string msg = ex.ToString();
                isSave = false;
            }
            return isSave;
        }

        public bool UpdateIsActive(int VesselVoyageId, bool isActive)
        {
            bool isSave = true;
            try
            {
                vv = db.VesselVoyage.Find(VesselVoyageId);
                vv.IsActiveTrip = isActive;

                db.VesselVoyage.Attach(vv);
                db.Entry(vv).Property(p => p.IsActiveTrip).IsModified = true;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                string msg = ex.ToString();
                isSave = false;
            }
            return isSave;
        }

        /// <summary>
        /// Disables all Vessel Voyage with LRD dates less than yesterday.
        /// </summary>
        /// <returns>Returns true if you managed to update the data.</returns>
        public bool UpdateIsActiveDateLRDLessThanYesterday()
        {
            bool isUpdate = false;

            try
            {
                using (WTCCeresEntities d = new WTCCeresEntities())
                {
                    DateTime Yesterday = Convert.ToDateTime(DateTime.Now.AddDays(-1).ToShortDateString() + " 00:00:00");
                    var v1 = d.VesselVoyage.Where(v => v.LRD < Yesterday).ToList();
                    v1.ForEach(a => a.IsActiveTrip = false);
                    d.SaveChanges();
                    isUpdate = true;
                }
            }
            catch (Exception ex)
            {
                string msg = ex.ToString();
                isUpdate = false;
            }

            return isUpdate;
        }
    }

    public interface IVesselTripRepository
    {
        List<VesselVoyage> GetAll();

        List<VesselVoyage> GetById(int Id);

        VesselVoyageList GetVesselVoyageVWById(int Id);

        VesselVoyageList GetVesselVoyageVWById(int Id, WTCCeresEntities db);

        List<VesselVoyageList> GetVesselVoyageAllList();

        List<VesselVoyageList> GetVesselVoyageListByFilters(string SearchWord);

        int GetLastVesselVoyageId();

        bool UpdateIsActive(int VesselVoyageId, bool isActive);

        bool UpdateIsActiveDateLRDLessThanYesterday();

        bool Insert(string VoyageNumber, string ERD, string LRD, string ETA, string ETD, string PortCity, string PortCountry, bool IsActiveTrip, int VesselVoyageStatusId, int VesselId, int PortId);

        bool Update(int VesselTripId, string VoyageNumber, string ERD, string LRD, string ETA, string ETD, string PortCity, string PortCountry, bool IsActiveTrip, int VesselVoyageStatusId, int VesselId, int PortId);

        bool Delete(int Id);
    }
}