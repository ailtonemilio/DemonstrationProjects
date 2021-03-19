using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class UnitSourceRepository : IUnitSourceRepository
    {
        private UnitSource us = new UnitSource();

        public bool Insert(string UnitNumber, int UnitStatusId, string UnitType, int CargoTypeId, string OriginLocation, string UnitLine, DateTime ETADate,
                   string ETALocation, DateTime LatTraced, string LastLocation, string Sequence, string Track, int DemurageDays, int InTransitDays, DateTime BillDate,
                   DateTime CallDate, DateTime ArrivalDate, DateTime AvailableDate, DateTime ReleaseDate, float TotalBilled, DateTime LastUpdated, bool ActiveUpdates,
                   bool isActive, int RailListId, string CargoDescription, int ShipperId)
        {
            bool isSaved = true;
            try
            {
                using (WTCCeresEntities db = new WTCCeresEntities())
                {
                    DateTime minDate = new DateTime(1753, 1, 1);

                    us.UnitNumber = UnitNumber;
                    us.UnitStatusId = UnitStatusId;
                    us.UnitType = UnitType;
                    us.CargoTypeId = CargoTypeId;
                    us.OriginLocation = OriginLocation;
                    us.UnitLine = UnitLine;
                    us.ETALocation = ETALocation;
                    us.Sequence = Sequence;
                    us.Track = Track;
                    us.DemurageDays = DemurageDays;
                    us.InTransitDays = InTransitDays;
                    us.TotalBilled = TotalBilled;
                    us.LastUpdate = LastUpdated;
                    us.ActiveUpdates = ActiveUpdates;
                    us.Active = isActive;
                    us.RecordKey = RailListId;
                    us.CargoDescription = CargoDescription;

                    us.ShipperId = ShipperId;

                    us.ETADate = (minDate.Date == ETADate.Date) ? (DateTime?)ETADate : null;
                    us.BillDate = (minDate.Date == BillDate.Date) ? (DateTime?)BillDate : null;
                    us.CallDate = (minDate.Date == CallDate.Date) ? (DateTime?)CallDate : null;
                    us.AvailableDate = (minDate.Date == AvailableDate.Date) ? (DateTime?)AvailableDate : null;
                    us.ArrivalDate = (minDate.Date == ArrivalDate.Date) ? (DateTime?)ArrivalDate : null;
                    us.ReleaseDate = (minDate.Date == ReleaseDate.Date) ? (DateTime?)ReleaseDate : null;

                    db.UnitSource.Add(us);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                isSaved = false;
            }
            return isSaved;
        }

        public bool Delete(int UnitSourceId)
        {
            bool isDeleted = true;
            try
            {
                using (WTCCeresEntities db = new WTCCeresEntities())
                {
                    us = db.UnitSource.Find(UnitSourceId);

                    db.UnitSource.Remove(us);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                isDeleted = false;
            }
            return isDeleted;
        }

        public List<UnitSource> GetAll()
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.UnitSource.ToList();
            }
        }

        public List<UnitSource> GetByActiveStatus(bool isActive)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                List<UnitSource> listuS;

                if (isActive)
                    listuS = db.UnitSource.Where(us => us.Active == isActive && us.UnitStatusId != 8).ToList();
                else
                    listuS = db.UnitSource.Where(us => us.Active == isActive && us.UnitStatusId == 8).ToList();

                return listuS;
            }
        }

        public UnitSource GetById(int UnitSourceId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.UnitSource.Find(UnitSourceId);
            }
        }

        public VW_UnitSource GetVWById(int UnitSourceId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var u = db.VW_UnitSource.Where(us => us.UnitSourceId == UnitSourceId).ToList();

                if (u.Count > 0)
                    return u[0];
                else

                    return null;
            }
        }

        public bool Update(int UnitSourceId, string UnitNumber, int UnitStatusId, string UnitType, int CargoTypeId, string OriginLocation, string UnitLine, DateTime ETADate,
                    string ETALocation, DateTime LatTraced, string LastLocation, string Sequence, string Track, int DemurageDays, int InTransitDays, DateTime BillDate,
                    DateTime CallDate, DateTime ArrivalDate, DateTime AvailableDate, DateTime ReleaseDate, float TotalBilled, DateTime LastUpdated, bool ActiveUpdates,
                    bool isActive, int RailListId, string CargoDescription, int ShipperId)
        {
            bool isSaved = true;
            try
            {
                using (WTCCeresEntities db = new WTCCeresEntities())
                {
                    DateTime minDate = new DateTime(0001, 1, 1);
                    if (UnitSourceId == 0)
                    {
                        us = new UnitSource();
                    }
                    else
                    {
                        us = db.UnitSource.Find(UnitSourceId);
                    }

                    us.UnitNumber = UnitNumber;
                    us.UnitStatusId = UnitStatusId;
                    us.UnitType = UnitType;
                    us.CargoTypeId = CargoTypeId;
                    us.OriginLocation = OriginLocation;
                    us.UnitLine = UnitLine;
                    us.ETALocation = ETALocation;
                    us.Sequence = Sequence;
                    us.Track = Track;
                    us.DemurageDays = DemurageDays;
                    us.InTransitDays = InTransitDays;
                    us.TotalBilled = TotalBilled;
                    us.LastUpdate = LastUpdated;
                    us.ActiveUpdates = ActiveUpdates;
                    us.Active = isActive;
                    us.RecordKey = RailListId;
                    us.CargoDescription = CargoDescription;
                    us.ShipperId = ShipperId;

                    us.ETADate = (minDate.Date == ETADate.Date) ? (DateTime?)null : ETADate;
                    us.BillDate = (minDate.Date == BillDate.Date) ? (DateTime?)null : BillDate;
                    us.CallDate = (minDate.Date == CallDate.Date) ? (DateTime?)null : CallDate;
                    us.AvailableDate = (minDate.Date == AvailableDate.Date) ? (DateTime?)null : AvailableDate;
                    us.ArrivalDate = (minDate.Date == ArrivalDate.Date) ? (DateTime?)null : ArrivalDate;
                    us.ReleaseDate = (minDate.Date == ReleaseDate.Date) ? (DateTime?)null : ReleaseDate;

                    db.UnitSource.AddOrUpdate(us);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                isSaved = false;
            }
            return isSaved;
        }

        public List<VW_UnitSource> GetByUnitSourceListById(List<int> UnitSourceIdList)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_UnitSource.Where(mu => UnitSourceIdList.Contains(mu.UnitSourceId)).ToList();
            }
        }

        public int GetLastUnitSourceId()
        {
            return us.UnitSourceId;
        }

        public List<UnitSource> GetAllExceptUnitStatus(int UnitStatusId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.UnitSource.Where(mu => mu.UnitStatusId != UnitStatusId).ToList();
            }
        }

        public bool AddOrUpdate(UnitSource unitSource)
        {
            bool isSaved = true;
            try
            {
                using (WTCCeresEntities db = new WTCCeresEntities())
                {
                    if (unitSource.UnitSourceId == 0)
                    {
                        db.UnitSource.Add(unitSource);
                    }
                    else
                    {
                        db.UnitSource.AddOrUpdate(unitSource);
                    }

                    db.SaveChanges();
                    us = unitSource;
                }
            }
            catch (Exception ex)
            {
                isSaved = false;
            }
            return isSaved;
        }
    }

    public interface IUnitSourceRepository
    {
        List<UnitSource> GetAll();

        List<UnitSource> GetByActiveStatus(bool isActive);

        List<UnitSource> GetAllExceptUnitStatus(int UnitStatusId);

        List<VW_UnitSource> GetByUnitSourceListById(List<int> UnitSourceIdList);

        UnitSource GetById(int UnitSourceId);

        VW_UnitSource GetVWById(int UnitSourceId);

        int GetLastUnitSourceId();

        bool Update(int UnitSourceId, string UnitNumber, int UnitStatusId, string UnitType, int CargoTypeId, string OriginLocation, string UnitLine, DateTime ETADate,
                    string ETALocation, DateTime LatTraced, string LastLocation, string Sequence, string Track, int DemurageDays, int InTransitDays, DateTime BillDate,
                    DateTime CallDate, DateTime ArrivalDate, DateTime AvailableDate, DateTime ReleaseDate, float TotalBilled, DateTime LastUpdated, bool ActiveUpdates,
                    bool isActive, int RailListId, string CargoDescription, int ShipperId);

        bool Insert(string UnitNumber, int UnitStatusId, string UnitType, int CargoTypeId, string OriginLocation, string UnitLine, DateTime ETADate,
                   string ETALocation, DateTime LatTraced, string LastLocation, string Sequence, string Track, int DemurageDays, int InTransitDays, DateTime BillDate,
                   DateTime CallDate, DateTime ArrivalDate, DateTime AvailableDate, DateTime ReleaseDate, float TotalBilled, DateTime LastUpdated, bool ActiveUpdates,
                   bool isActive, int RailListId, string CargoDescription, int ShipperId);

        bool AddOrUpdate(UnitSource unitSource);

        bool Delete(int UnitSourceId);
    }
}