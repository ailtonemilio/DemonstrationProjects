using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer.WTC_Ceres
{
    public class GrainInventoryRepository : IGrainInventoryRepository
    {
        private GrainInventory gi = new GrainInventory();
        private GrainInvStorageLocation gisl = new GrainInvStorageLocation();
        private GrainInvMinibookingAssignment gima = new GrainInvMinibookingAssignment();
        private GrainInvMinibookingTransaction gimt = new GrainInvMinibookingTransaction();
        private GrainInventoryTransaction git = new GrainInventoryTransaction();
        private GrainInventoryTransfer gitr = new GrainInventoryTransfer();
        private GrainInvTransactionGrainStorageLocation gitgs = new GrainInvTransactionGrainStorageLocation();

        public bool DeleteGrainInventory(int GrainInventoryId)
        {
            bool isSaved = true;

            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    gi = db.GrainInventory.Find(GrainInventoryId);
                    db.GrainInventory.Remove(gi);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    var msg = e.Message;
                    isSaved = false;
                }
            }
            return isSaved;
        }

        public bool DeleteGrainInventoryTransaction(int GrainInventoryTransactionId)
        {
            bool isSaved = true;

            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    git = db.GrainInventoryTransaction.Find(GrainInventoryTransactionId);
                    db.GrainInventoryTransaction.Remove(git);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    var msg = e.Message;
                    isSaved = false;
                }
            }
            return isSaved;
        }

        public bool DeleteGrainInventoryTransfer(int GrainInventoryTransferId)
        {
            bool isSaved = true;

            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    gitr = db.GrainInventoryTransfer.Find(GrainInventoryTransferId);
                    db.GrainInventoryTransfer.Remove(gitr);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    var msg = e.Message;
                    isSaved = false;
                }
            }
            return isSaved;
        }

        public bool DeleteGrainInvMinibookingAssignment(int GrainInvMinibookingAssignmenId)
        {
            bool isSaved = true;

            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    gima = db.GrainInvMinibookingAssignment.Find(GrainInvMinibookingAssignmenId);
                    db.GrainInvMinibookingAssignment.Remove(gima);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    var msg = e.Message;
                    isSaved = false;
                }
            }
            return isSaved;
        }

        public bool DeleteGrainInvMinibookingTransaction(int GrainInvMinibookingTransactionId)
        {
            bool isSaved = true;

            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    gimt = db.GrainInvMinibookingTransaction.Find(GrainInvMinibookingTransactionId);
                    db.GrainInvMinibookingTransaction.Remove(gimt);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    var msg = e.Message;
                    isSaved = false;
                }
            }
            return isSaved;
        }

        public bool DeleteGrainInvStorageLocation(int GrainInvStorageLocationId)
        {
            bool isSaved = true;

            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    gisl = db.GrainInvStorageLocation.Find(GrainInvStorageLocationId);
                    db.GrainInvStorageLocation.Remove(gisl);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    var msg = e.Message;
                    isSaved = false;
                }
            }
            return isSaved;
        }

        public int GetLastGrainInventoryTransactionId()
        {
            return git.GrainInventoryTransactionId;
        }

        public int GetLastGrainInvetoryId()
        {
            return gi.GrainInventoryId;
        }

        public int GetLastGrainInvMinibookingTransactionId()
        {
            return gimt.GrainInvMinibookingTransactionId;
        }

        public int GetLastGrainInvStorageLocationId()
        {
            return gisl.GrainInvStorageLocationId;
        }

        public int GetLastGrainInvMinibookingAssignmenId()
        {
            return gima.GrainInvMinibookingAssignmentId;
        }

        public int GetLastGrainInventoryTransferId()
        {
            return gitr.GrainInventoryTransferId;
        }

        public bool InsertGrainInventory(int CustomerId, int BagId, double InitialQuantity, int MiniUnitId)
        {
            bool isSaved = true;

            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    gi.CustomerId = CustomerId;
                    gi.BagId = BagId;
                    gi.InitialQuantity = InitialQuantity;
                    gi.MiniUnitId = MiniUnitId;
                    db.GrainInventory.Add(gi);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    var msg = e.Message;
                    isSaved = false;
                }
            }
            return isSaved;
        }

        public bool InsertGrainInventoryTransaction(int GrainInventoryId, int TransactionTypeId, double Quantity, DateTime CreatedAt)
        {
            bool isSaved = true;

            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    git.GrainInventoryId = GrainInventoryId;
                    git.TransactionTypeId = TransactionTypeId;
                    git.Quantity = Quantity;
                    git.CreatedAt = CreatedAt;
                    db.GrainInventoryTransaction.Add(git);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    var msg = e.Message;
                    isSaved = false;
                }
            }
            return isSaved;
        }

        public bool InsertGrainInventoryTransfer(int GiverGrainInventoryId, int ReceiverGrainInventoryId, int GrainInventoryTransactionId)
        {
            bool isSaved = true;

            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    gitr.GiverGrainInventoryId = GiverGrainInventoryId;
                    gitr.ReceiverGrainInventoryId = ReceiverGrainInventoryId;
                    gitr.GrainInventoryTransactionId = GrainInventoryTransactionId;
                    db.GrainInventoryTransfer.Add(gitr);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    var msg = e.Message;
                    isSaved = false;
                }
            }
            return isSaved;
        }

        public bool InsertGrainInvMinibookingAssignment(int MinibookingId, int GrainInvStorageLocationId, double QuantityAssigned, DateTime AssignedAt)
        {
            bool isSaved = true;

            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    gima.MinibookingId = MinibookingId;
                    gima.GrainInvStorageLocationId = GrainInvStorageLocationId;
                    gima.QuantityAssigned = QuantityAssigned;
                    gima.AssignedAt = AssignedAt;

                    db.GrainInvMinibookingAssignment.Add(gima);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    var msg = e.Message;
                    isSaved = false;
                }
            }
            return isSaved;
        }

        public bool InsertGrainInvMinibookingTransaction(int MinibookingId, int GrainInventoryTransactionId)
        {
            bool isSaved = true;

            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    gimt.MinibookingId = MinibookingId;
                    gimt.GrainInventoryTransactionId = GrainInventoryTransactionId;
                    db.GrainInvMinibookingTransaction.Add(gimt);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    var msg = e.Message;
                    isSaved = false;
                }
            }
            return isSaved;
        }

        public bool InsertGrainInvStorageLocation(int GrainInventoryId, int StorageTypeId, int StorageId, double Quantity, DateTime StorageDate)
        {
            bool isSaved = true;

            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    gisl.GrainInventoryId = GrainInventoryId;
                    gisl.StorageTypeId = StorageTypeId;
                    gisl.StorageId = StorageId;
                    gisl.Quantity = Quantity;
                    gisl.StorageDate = StorageDate;
                    db.GrainInvStorageLocation.Add(gisl);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    var msg = e.Message;
                    isSaved = false;
                }
            }
            return isSaved;
        }

        public bool UpdateGrainInventory(int GrainInventoryId, int CustomerId, int BagId, double InitialQuantity, int MiniUnitid)
        {
            bool isSaved = true;

            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    gi = db.GrainInventory.Find(GrainInventoryId);
                    gi.CustomerId = CustomerId;
                    gi.BagId = BagId;
                    gi.InitialQuantity = InitialQuantity;
                    gi.MiniUnitId = MiniUnitid;
                    db.GrainInventory.AddOrUpdate(gi);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    var msg = e.Message;
                    isSaved = false;
                }
            }
            return isSaved;
        }

        public bool UpdateGrainInventoryTransaction(int GrainInventoryTransactionId, int GrainInventoryId, int TransactionTypeId, double Quantity, DateTime CreatedAt)
        {
            bool isSaved = true;

            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    git = db.GrainInventoryTransaction.Find(GrainInventoryTransactionId);
                    git.GrainInventoryId = GrainInventoryId;
                    git.TransactionTypeId = TransactionTypeId;
                    git.Quantity = Quantity;
                    git.CreatedAt = CreatedAt;
                    db.GrainInventoryTransaction.AddOrUpdate(git);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    var msg = e.Message;
                    isSaved = false;
                }
            }
            return isSaved;
        }

        public bool UpdateGrainInventoryTransfer(int GrainInventoryTransferId, int GiverGrainInventoryId, int ReceiverGrainInventoryId, int GrainInventoryTransactionId)
        {
            bool isSaved = true;

            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    gitr = db.GrainInventoryTransfer.Find(GrainInventoryTransferId);
                    gitr.GiverGrainInventoryId = GiverGrainInventoryId;
                    gitr.ReceiverGrainInventoryId = ReceiverGrainInventoryId;
                    gitr.GrainInventoryTransactionId = GrainInventoryTransactionId;
                    db.GrainInventoryTransfer.AddOrUpdate(gitr);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    var msg = e.Message;
                    isSaved = false;
                }
            }
            return isSaved;
        }

        public bool UpdateGrainInvMinibookingAssignment(int GrainInvMinibookingAssignmentId, int MinibookingId, int GrainInvStorageLocationId, double QuantityAssigned, DateTime AssignedAt)
        {
            bool isSaved = true;

            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    gima = db.GrainInvMinibookingAssignment.Find(GrainInvMinibookingAssignmentId);
                    gima.MinibookingId = MinibookingId;
                    gima.GrainInvStorageLocationId = GrainInvStorageLocationId;
                    gima.QuantityAssigned = QuantityAssigned;
                    gima.AssignedAt = AssignedAt;

                    db.GrainInvMinibookingAssignment.AddOrUpdate(gima);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    var msg = e.Message;
                    isSaved = false;
                }
            }
            return isSaved;
        }

        public bool UpdateGrainInvMinibookingTransaction(int GrainInvMinibookingTransactionId, int MinibookingId, int GrainInventoryTransactionId)
        {
            bool isSaved = true;

            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    gimt = db.GrainInvMinibookingTransaction.Find(GrainInvMinibookingTransactionId);
                    gimt.MinibookingId = MinibookingId;
                    gimt.GrainInventoryTransactionId = GrainInventoryTransactionId;
                    db.GrainInvMinibookingTransaction.AddOrUpdate(gimt);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    var msg = e.Message;
                    isSaved = false;
                }
            }
            return isSaved;
        }

        public bool UpdateGrainInvStorageLocation(int GrainInvStorageLocationId, int GrainInventoryId, int StorageTypeId, int StorageId, double Quantity)
        {
            bool isSaved = true;

            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    gisl = db.GrainInvStorageLocation.Find(GrainInvStorageLocationId);
                    gisl.GrainInventoryId = GrainInventoryId;
                    gisl.StorageTypeId = StorageTypeId;
                    gisl.StorageId = StorageId;
                    gisl.Quantity = Quantity;
                    db.GrainInvStorageLocation.AddOrUpdate(gisl);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    var msg = e.Message;
                    isSaved = false;
                }
            }
            return isSaved;
        }

        public List<VW_GrainInventory> GetAllGrainInventory()
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_GrainInventory.ToList();
            }
        }

        public List<VW_GrainInventory> GetGrainInventoryByFilets(string CustomerName, string CommodityCode, string GradeCode, string UnitNumber, string BagSizeName)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_GrainInventory.Where(c => c.CustomerNameGrainInv.Contains(CustomerName)
                                                   && c.CommodityCode.Contains(CommodityCode)
                                                   && c.GradeCode.Contains(GradeCode)
                                                   && c.UnitNumber.Contains(UnitNumber)
                                                   && c.BagSizeName.Contains(BagSizeName)).ToList();
            }
        }

        public List<VW_GrainInventoryTransaction> GetGrainInventoryTransactionByGrainInvId(int GrainInventoryId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_GrainInventoryTransaction.Where(g => g.GrainInventoryId == GrainInventoryId).ToList();
            }
        }

        public List<VW_GrainInventoryTransaction> GetGrainInventoryTransactionBMuId(int MiniUnitId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_GrainInventoryTransaction.Where(g => g.MiniUnitId == MiniUnitId).ToList();
            }
        }

        public List<VW_GrainInvMinibookingTransaction> GetGrainInvMinibookingTransactionsByGrainInvId(int GrainInventoryId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_GrainInvMinibookingTransaction.Where(g => g.GrainInventoryId == GrainInventoryId).ToList();
            }
        }

        public List<VW_GrainInvMinibookingTransaction> GetGrainInvMinibookingTransactionsByMbId(int MinibookingId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_GrainInvMinibookingTransaction.Where(g => g.MinibookingId == MinibookingId).ToList();
            }
        }

        public List<VW_GrainUnitStorage> GetAllGrainInventoryUnitsByFilter(string CustomerName, List<string> CargoType, string SearchField)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_GrainUnitStorage.Where(g => g.CustomerNameGrainInv.Contains(CustomerName)
                                                           && CargoType.Contains(g.CargoTypeCode)
                                                           && (g.MiniUnitNumber.Contains(SearchField)
                                                           || g.StorageLocation.Contains(SearchField)
                                                           || g.GradeCommodityCode.Contains(SearchField))
                                                           && g.QtyInStorage > 0).ToList();
            }
        }

        public List<VW_GrainInvMinibookingAssignment> GetGrainInvMBAsnUnitsByFilter(int MiniBookingId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_GrainInvMinibookingAssignment.Where(g => g.MinibookingId == MiniBookingId).ToList();
            }
        }

        public bool InsertGrainInvTransactionGrainStorageLocation(int GrainInventoryTransactionId, int GrainInvStorageLocationId)
        {
            bool isInserted = true;
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    gitgs.GrainInventoryTransactionId = GrainInventoryTransactionId;
                    gitgs.GrainInvStorageLocationId = GrainInvStorageLocationId;
                    db.GrainInvTransactionGrainStorageLocation.Add(gitgs);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    isInserted = false;
                    string message = e.Message;
                }
            }
            return isInserted;
        }
    }

    public interface IGrainInventoryRepository
    {
        bool InsertGrainInventory(int CustomerId, int BagId, double InitialQuantity, int MiniUnitid);

        int GetLastGrainInvetoryId();

        bool UpdateGrainInventory(int GrainInventoryId, int CustomerId, int BagId, double InitialQuantity, int MiniUnitid);

        bool DeleteGrainInventory(int GrainInventoryId);

        bool InsertGrainInvStorageLocation(int GrainInventoryId, int StorageTypeId, int StorageId, double Quantity, DateTime StorageDate);

        int GetLastGrainInvStorageLocationId();

        bool UpdateGrainInvStorageLocation(int GrainInvStorageLocationId, int GrainInventoryId, int StorageTypeId, int StorageId, double Quantity);

        bool DeleteGrainInvStorageLocation(int GrainInvStorageLocationId);

        bool InsertGrainInvMinibookingAssignment(int MinibookingId, int GrainInvStorageLocationId, double QuantityAssigned, DateTime AssignedAt);

        int GetLastGrainInvMinibookingAssignmenId();

        bool UpdateGrainInvMinibookingAssignment(int GrainInvMinibookingAssignmentId, int MinibookingId, int GrainInventoryId, double QuantityAssigned, DateTime AssignedAt);

        bool DeleteGrainInvMinibookingAssignment(int GrainInvMinibookingAssignmenId);

        bool InsertGrainInvMinibookingTransaction(int MinibookingId, int GrainInventoryTransactionId);

        int GetLastGrainInvMinibookingTransactionId();

        bool UpdateGrainInvMinibookingTransaction(int GrainInvMinibookingTransactionId, int MinibookingId, int GrainInventoryTransactionId);

        bool DeleteGrainInvMinibookingTransaction(int GrainInvMinibookingTransactionId);

        bool InsertGrainInventoryTransaction(int GrainInventoryId, int TransactionTypeId, double Quantity, DateTime CreatedAt);

        int GetLastGrainInventoryTransactionId();

        bool UpdateGrainInventoryTransaction(int GrainInventoryTransactionId, int GrainInventoryId, int TransactionTypeId, double Quantity, DateTime CreatedAt);

        bool DeleteGrainInventoryTransaction(int GrainInventoryTransactionId);

        bool InsertGrainInventoryTransfer(int GiverGrainInventoryId, int ReceiverGrainInventoryId, int GrainInventoryTransactionId);

        bool InsertGrainInvTransactionGrainStorageLocation(int GrainInventoryTransactionId, int GrainInvStorageLocationId);

        int GetLastGrainInventoryTransferId();

        bool UpdateGrainInventoryTransfer(int GrainInventoryTransferId, int GiverGrainInventoryId, int ReceiverGrainInventoryId, int GrainInventoryTransactionId);

        bool DeleteGrainInventoryTransfer(int GrainInventoryTransferId);

        List<VW_GrainInventory> GetAllGrainInventory();

        List<VW_GrainInventory> GetGrainInventoryByFilets(string CustomerName, string CommodityCode, string GradeCode, string UnitNumber, string BagSizeName);

        List<VW_GrainInventoryTransaction> GetGrainInventoryTransactionByGrainInvId(int GrainInventoryId);

        List<VW_GrainInventoryTransaction> GetGrainInventoryTransactionBMuId(int MiniUnitId);

        List<VW_GrainUnitStorage> GetAllGrainInventoryUnitsByFilter(string CustomerName, List<string> CargoType, string SearchField);

        List<VW_GrainInvMinibookingAssignment> GetGrainInvMBAsnUnitsByFilter(int MiniBookingId);

        List<VW_GrainInvMinibookingTransaction> GetGrainInvMinibookingTransactionsByGrainInvId(int GrainInventoryId);

        List<VW_GrainInvMinibookingTransaction> GetGrainInvMinibookingTransactionsByMbId(int MinibookingId);
    }
}