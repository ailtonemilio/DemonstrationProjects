using DataLayer.WTC_Ceres;
using ModelLayer;
using System;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class ContainersInOutDrayageService
    {
        private static IContainersInOutDrayageRepository repository;

        static ContainersInOutDrayageService()
        {
            repository = new ContainersInOutDrayageRepository();
        }

        public static List<VW_ContainersInOutDrayage> GetAll()
        {
            return repository.GetAll();
        }

        public static List<VW_ContainersInOutDrayage> GetById(int Id)
        {
            return repository.GetById(Id);
        }

        public static List<VW_ContainersInOutDrayage> GetByDrayageRates(string bkRelNumber, string pickUp, string dropOff, string truckId,
            DateTime startDate, DateTime endDate, List<String> carrierCode, bool streetTurn, bool useDateRange)
        {
            return repository.GetByDrayageRates(bkRelNumber, pickUp, dropOff, truckId, startDate, endDate, carrierCode, streetTurn, useDateRange);
        }

        public static bool isMultiDrayage(string truckID, DateTime gateDateTime, string drayageType)
        {
            return repository.isMultiDrayage(truckID, gateDateTime, drayageType);
        }

        public static List<VW_ContainersInOutDrayage> GetByInOutGateByDateRange(DateTime startDate, DateTime endDate)
        {
            return repository.GetByInOutGateByDateRange(startDate, endDate);
        }
    }
}