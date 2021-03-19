using DataLayer.WTC_Ceres;
using ModelLayer;
using ModelLayer.CustomModel;
using System;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class Containers_In_OutService
    {
        private static IContainers_In_OutRepository repository;

        static Containers_In_OutService()
        {
            repository = new Containers_In_OutRepository();
        }

        public static List<Containers_In_Out> GetAll()
        {
            return repository.GetAll();
        }

        public bool UnassignContainerFromMinibooking(int ContainerInOutId, int MinibookingId, bool isBookingChange)
        {
            return repository.UnassignContainerFromMinibooking(ContainerInOutId, MinibookingId, isBookingChange);
        }

        public static List<Containers_In_Out> GetById(int Id)
        {
            return repository.GetById(Id);
        }

        public static List<VW_ContainersByBooking> GetByIds(List<int> IdList)
        {
            return repository.GetByIds(IdList);
        }

        //public static List<VW_ContainersByBooking> GetByMBId(int Id)
        //{
        //    return repository.GetByMBIds(Id);
        //}

        public static List<VW_ContainersByBooking> GetContainersByBookingAndStatus(bool OutGateStatus, string BookingNumber)
        {
            return repository.GetContainersByBookingAndStatus(OutGateStatus, BookingNumber);
        }

        public static List<VW_ContainersByBooking> GetContainersByMiniBookingId(int MinibookingId)
        {
            return repository.GetContainersByMiniBookingId(MinibookingId);
        }

        public static List<Containers_In_Out> GetByInOutGateByDateRange(DateTime startDate, DateTime endDate, bool DateIn, bool DateOut)
        {
            return repository.GetByInOutGateByDateRange(startDate, endDate, DateIn, DateOut);
        }

        public static List<Containers_In_OutReport> GetByInOutGateByReportDateRange(DateTime startDate, DateTime endDate)
        {
            return repository.GetByInOutGateReportByDateRange(startDate, endDate);
        }

        public static Containers_In_Out GetByContainerNumber(string ContainerNumber)
        {
            return repository.GetByContainerNumber(ContainerNumber);
        }

        public static List<VW_ContainersByBooking> GetContainersByBookingNumber(string BookingNumber)
        {
            return repository.GetContainersByBookingNumber(BookingNumber);
        }

        public static List<VW_ContainersByBooking> GetContainersByBookingNumber(string BookingNumber, WTCCeresEntities db)
        {
            return repository.GetContainersByBookingNumber(BookingNumber, db);
        }
    }
}