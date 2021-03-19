using DataLayer.WTC_Ceres;
using ModelLayer;
using System;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class UnitSourceService
    {
        private static IUnitSourceRepository repository;

        static UnitSourceService()
        {
            repository = new UnitSourceRepository();
        }

        public static List<UnitSource> GetAll()
        {
            return repository.GetAll();
        }

        public static List<UnitSource> GetByActiveStatus(bool isActive)
        {
            return repository.GetByActiveStatus(isActive);
        }

        public static UnitSource GetById(int UnitSourceId)
        {
            return repository.GetById(UnitSourceId);
        }

        public static VW_UnitSource GetVWById(int UnitSourceId)
        {
            return repository.GetVWById(UnitSourceId);
        }

        public bool Update(int UnitSourceId, string UnitNumber, int UnitStatusId, string UnitType, int CargoTypeId, string OriginLocation, string CarrierId, DateTime ETADate,
                    string ETALocation, DateTime LatTraced, string LastLocation, string Sequence, string Track, int DemurageDays, int InTransitDays, DateTime BillDate,
                    DateTime CallDate, DateTime ArrivalDate, DateTime AvailableDate, DateTime ReleaseDate, float TotalBilled, DateTime LastUpdated, bool ActiveUpdates,
                    bool isActive, int RailListId, string CargoDescription, int ShipperId)
        {
            return repository.Update(UnitSourceId, UnitNumber, UnitStatusId, UnitType, CargoTypeId, OriginLocation, CarrierId, ETADate,
                     ETALocation, LatTraced, LastLocation, Sequence, Track, DemurageDays, InTransitDays, BillDate,
                     CallDate, ArrivalDate, AvailableDate, ReleaseDate, TotalBilled, LastUpdated, ActiveUpdates,
                     isActive, RailListId, CargoDescription, ShipperId);
        }

        public bool Insert(string UnitNumber, int UnitStatusId, string UnitType, int CargoTypeId, string OriginLocation, string CarrierId, DateTime ETADate,
                   string ETALocation, DateTime LatTraced, string LastLocation, string Sequence, string Track, int DemurageDays, int InTransitDays, DateTime BillDate,
                   DateTime CallDate, DateTime ArrivalDate, DateTime AvailableDate, DateTime ReleaseDate, float TotalBilled, DateTime LastUpdated, bool ActiveUpdates,
                   bool isActive, int RailListId, string CargoDescription, int ShipperId)
        {
            return repository.Insert(UnitNumber, UnitStatusId, UnitType, CargoTypeId, OriginLocation, CarrierId, ETADate,
                     ETALocation, LatTraced, LastLocation, Sequence, Track, DemurageDays, InTransitDays, BillDate,
                     CallDate, ArrivalDate, AvailableDate, ReleaseDate, TotalBilled, LastUpdated, ActiveUpdates,
                     isActive, RailListId, CargoDescription, ShipperId);
        }

        public bool AddOrUpdate(UnitSource unitSource)
        {
            return repository.AddOrUpdate(unitSource);
        }

        public bool Delete(int UnitSourceId)
        {
            return repository.Delete(UnitSourceId);
        }

        public static List<VW_UnitSource> GetByUnitSourceListById(List<int> UnitSourceIdList)
        {
            return repository.GetByUnitSourceListById(UnitSourceIdList);
        }

        public int GetLastUnitSourceId()
        {
            return repository.GetLastUnitSourceId();
        }

        public static List<UnitSource> GetAllExceptUnitStatusId(int UnitStatusId)
        {
            return repository.GetAllExceptUnitStatus(UnitStatusId);
        }
    }
}