using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class ContainersInOutDrayageRepository : IContainersInOutDrayageRepository
    {
        private List<VW_ContainersInOutDrayage> listQuery = new List<VW_ContainersInOutDrayage>();
        private WTCCeresEntities db = new WTCCeresEntities();
        private VW_ContainersInOutDrayage cio = new VW_ContainersInOutDrayage();

        public List<VW_ContainersInOutDrayage> GetAll()
        {
            return db.VW_ContainersInOutDrayage.ToList();
        }

        public List<VW_ContainersInOutDrayage> GetById(int Id)
        {
            var listById = db.VW_ContainersInOutDrayage.Where(c => c.Unique_ID == Id);

            return listById.ToList();
        }

        public List<VW_ContainersInOutDrayage> GetByInOutGateByDateRange(DateTime startDate, DateTime endDate)
        {
            var listByDateRange = db.VW_ContainersInOutDrayage.Where(c => (c.GateDateTime >= startDate.Date && c.GateDateTime <= endDate.Date));

            return listByDateRange.ToList();
        }

        public bool isMultiDrayage(string truckDriverId, DateTime gateDateTime, string drayageType)
        {
            DateTime startRange = gateDateTime;
            startRange = startRange.AddMinutes(-15);
            DateTime endRange = gateDateTime;
            endRange = gateDateTime.AddMinutes(15);

            var multDrayageList = listQuery.Where(c => (c.GateDateTime >= startRange && c.GateDateTime <= endRange) &&
                                                    c.truckDriverId == truckDriverId
                                                    && c.drayageType == drayageType).ToList();

            return multDrayageList.Count > 1;
        }

        public List<VW_ContainersInOutDrayage> GetByDrayageRates(string bkRelNumber, string pickUp, string dropOff,
            string truckDriverId, DateTime startDate, DateTime endDate, List<string> carrierCode, bool streetTurn, bool useDateRange)
        {
            int stTurn = 0;

            if (bkRelNumber.Equals("ALL"))
            {
                bkRelNumber = "";
            }
            if (pickUp == null)
            {
                pickUp = "";
            }
            if (dropOff == null)
            {
                dropOff = "";
            }
            if (bkRelNumber.Equals(" ALL"))
            {
                bkRelNumber = "";
            }
            if (streetTurn == true)
                stTurn = 1;
            else
                stTurn = 0;

            if (useDateRange && carrierCode.Count > 0)
            {
                if (streetTurn == false)
                {
                    listQuery = db.VW_ContainersInOutDrayage.Where(c => c.bkrelNumber.Contains(bkRelNumber) &&
                                                         carrierCode.Contains(c.carrierCode) &&
                                                       c.pickUpCode.Contains(pickUp) && c.dropOffCode.Contains(dropOff) &&
                                                       c.truckDriverId.Contains(truckDriverId) &&
                                                        c.GateDateTime != null &&
                                                       (c.GateDateTime >= startDate && c.GateDateTime <= endDate)
                                                       && c.streetTurn == stTurn).OrderBy(c => c.truckDriverId).ToList();
                }
                else
                {
                    listQuery = db.VW_ContainersInOutDrayage.Where(c => c.bkrelNumber.Contains(bkRelNumber) &&
                                      carrierCode.Contains(c.carrierCode) &&
                                    c.pickUpCode.Contains(pickUp) && c.dropOffCode.Contains(dropOff) &&
                                    c.truckDriverId.Contains(truckDriverId) &&
                                     c.GateDateTime != null &&
                                    (c.GateDateTime >= startDate && c.GateDateTime <= endDate)).OrderBy(c => c.truckDriverId).ToList();
                }
            }
            else
            {
                if (streetTurn == false)
                {
                    listQuery = db.VW_ContainersInOutDrayage.Where(c => c.bkrelNumber.Contains(bkRelNumber) &&
                    carrierCode.Contains(c.carrierCode) &&
                                                       c.pickUpCode.Contains(pickUp) && c.dropOffCode.Contains(dropOff) &&
                                                       c.truckDriverId.Contains(truckDriverId)
                                                       && c.streetTurn == stTurn).OrderBy(c => (c.truckDriverId)).ToList();
                }
                else
                {
                    listQuery = db.VW_ContainersInOutDrayage.Where(c => c.bkrelNumber.Contains(bkRelNumber) &&
                    carrierCode.Contains(c.carrierCode) &&
                                    c.pickUpCode.Contains(pickUp) && c.dropOffCode.Contains(dropOff) &&
                                    c.truckDriverId.Contains(truckDriverId)).OrderBy(c => (c.truckDriverId)).ToList();
                }
            }

            return listQuery;
        }
    }

    public interface IContainersInOutDrayageRepository
    {
        List<VW_ContainersInOutDrayage> GetAll();

        List<VW_ContainersInOutDrayage> GetById(int Id);

        bool isMultiDrayage(string truckID, DateTime gateDateTime, string drayageType);

        List<VW_ContainersInOutDrayage> GetByDrayageRates(string bkRelNumber, string pickUp, string dropOff, string truckId,
            DateTime startDate, DateTime endDate, List<string> carrierCode, bool streetTurn, bool useDateRange);

        List<VW_ContainersInOutDrayage> GetByInOutGateByDateRange(DateTime startDate, DateTime endDate);
    }
}