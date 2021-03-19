using DataLayer.WTC_Ceres;
using ModelLayer;
using System;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class GrainInventoryService
    {
        private static IGrainInventoryRepository repository;

        static GrainInventoryService()
        {
            repository = new GrainInventoryRepository();
        }

        public bool InsertGrainInventory(int CustomerId, int BagId, float InitialQuantity, int MiniUnitId)
        {
            return repository.InsertGrainInventory(CustomerId, BagId, InitialQuantity, MiniUnitId);
        }

        public int GetLastGrainInvetoryId()
        {
            return repository.GetLastGrainInvetoryId();
        }

        public bool UpdateGrainInventory(int GrainInventoryId, int CustomerId, int BagId, float InitialQuantity, int UnitSourceId)
        {
            return repository.UpdateGrainInventory(GrainInventoryId, CustomerId, BagId, InitialQuantity, UnitSourceId);
        }

        public bool DeleteGrainInventory(int GrainInventoryId)
        {
            return repository.DeleteGrainInventory(GrainInventoryId);
        }

        public bool InsertGrainInvStorageLocation(int GrainInventoryId, int StorageTypeId, int StorageId, float Quantity, DateTime StorageDate)
        {
            return repository.InsertGrainInvStorageLocation(GrainInventoryId, StorageTypeId, StorageId, Quantity, StorageDate);
        }

        public int GetLastGrainInvStorageLocationId()
        {
            return repository.GetLastGrainInvStorageLocationId();
        }

        public bool UpdateGrainInvStorageLocation(int GrainInvStorageLocationId, int GrainInventoryId, int StorageTypeId, int StorageId, float Quantity)
        {
            return repository.UpdateGrainInvStorageLocation(GrainInvStorageLocationId, GrainInventoryId, StorageTypeId, StorageId, Quantity);
        }

        public bool DeleteGrainInvStorageLocation(int GrainInvStorageLocationId)
        {
            return repository.DeleteGrainInvStorageLocation(GrainInvStorageLocationId);
        }

        public bool InsertGrainInvMinibookingAssignment(int MinibookingId, int GrainInvStorageLocationId, float QuantityAssigned, DateTime AssignedAt)
        {
            return repository.InsertGrainInvMinibookingAssignment(MinibookingId, GrainInvStorageLocationId, QuantityAssigned, AssignedAt);
        }

        public int GetLastGrainInvMinibookingAssignmenId()
        {
            return repository.GetLastGrainInvMinibookingAssignmenId();
        }

        public bool UpdateGrainInvMinibookingAssignment(int GrainInvMinibookingAssignmentId, int MinibookingId, int GrainInvStorageLocationId, float QuantityAssigned, DateTime AssignedAt)
        {
            return repository.UpdateGrainInvMinibookingAssignment(GrainInvMinibookingAssignmentId, MinibookingId, GrainInvStorageLocationId, QuantityAssigned, AssignedAt);
        }

        public bool DeleteGrainInvMinibookingAssignment(int GrainInvMinibookingAssignmenId)
        {
            return repository.DeleteGrainInvMinibookingAssignment(GrainInvMinibookingAssignmenId);
        }

        public bool InsertGrainInvMinibookingTransaction(int MinibookingId, int GrainInventoryTransactionId)
        {
            return repository.InsertGrainInvMinibookingTransaction(MinibookingId, GrainInventoryTransactionId);
        }

        public int GetLastGrainInvMinibookingTransactionId()
        {
            return repository.GetLastGrainInvMinibookingTransactionId();
        }

        public bool UpdateGrainInvMinibookingTransaction(int GrainInvMinibookingTransactionId, int MinibookingId, int GrainInventoryTransactionId)
        {
            return repository.UpdateGrainInvMinibookingTransaction(GrainInvMinibookingTransactionId, MinibookingId, GrainInventoryTransactionId);
        }

        public bool DeleteGrainInvMinibookingTransaction(int GrainInvMinibookingTransactionId)
        {
            return repository.DeleteGrainInvMinibookingTransaction(GrainInvMinibookingTransactionId);
        }

        public bool InsertGrainInventoryTransaction(int GrainInventoryId, int TransactionTypeId, float Quantity, DateTime CreatedAt)
        {
            return repository.InsertGrainInventoryTransaction(GrainInventoryId, TransactionTypeId, Quantity, CreatedAt);
        }

        public int GetLastGrainInventoryTransactionId()
        {
            return repository.GetLastGrainInventoryTransactionId();
        }

        public bool UpdateGrainInventoryTransaction(int GrainInventoryTransactionId, int GrainInventoryId, int TransactionTypeId, float Quantity, DateTime CreatedAt)
        {
            return repository.UpdateGrainInventoryTransaction(GrainInventoryTransactionId, GrainInventoryId, TransactionTypeId, Quantity, CreatedAt);
        }

        public bool DeleteGrainInventoryTransaction(int GrainInventoryTransactionId)
        {
            return repository.DeleteGrainInventoryTransaction(GrainInventoryTransactionId);
        }

        public bool InsertGrainInventoryTransfer(int GiverGrainInventoryId, int ReceiverGrainInventoryId, int GrainInventoryTransactionId)
        {
            return repository.InsertGrainInventoryTransfer(GiverGrainInventoryId, ReceiverGrainInventoryId, GrainInventoryTransactionId);
        }

        public int GetLastGrainInventoryTransferId()
        {
            return repository.GetLastGrainInventoryTransferId();
        }

        public bool UpdateGrainInventoryTransfer(int GrainInventoryTransferId, int GiverGrainInventoryId, int ReceiverGrainInventoryId, int GrainInventoryTransactionId)
        {
            return repository.UpdateGrainInventoryTransfer(GrainInventoryTransferId, GiverGrainInventoryId, ReceiverGrainInventoryId, GrainInventoryTransactionId);
        }

        public bool DeleteGrainInventoryTransfer(int GrainInventoryTransferId)
        {
            return repository.DeleteGrainInventoryTransfer(GrainInventoryTransferId);
        }

        public static List<VW_GrainInventory> GetAllGrainInventory()
        {
            return repository.GetAllGrainInventory();
        }

        public static List<VW_GrainInventory> GetGrainInventoryByFilets(string CustomerName, string CommodityCode, string GradeCode, string UnitNumber, string BagSizeName)
        {
            return repository.GetGrainInventoryByFilets(CustomerName, CommodityCode, GradeCode, UnitNumber, BagSizeName);
        }

        public static List<VW_GrainInventoryTransaction> GetGrainInventoryTransactionByGrainInvId(int GrainInventoryId)
        {
            return repository.GetGrainInventoryTransactionByGrainInvId(GrainInventoryId);
        }

        public static List<VW_GrainInventoryTransaction> GetGrainInventoryTransactionBMuId(int MiniUnitId)
        {
            return repository.GetGrainInventoryTransactionBMuId(MiniUnitId);
        }

        public static List<VW_GrainInvMinibookingTransaction> GetGrainInvMinibookingTransactionsByGrainInvId(int GrainInventoryId)
        {
            return repository.GetGrainInvMinibookingTransactionsByGrainInvId(GrainInventoryId);
        }

        public static List<VW_GrainInvMinibookingTransaction> GetGrainInvMinibookingTransactionsByMbId(int MinibookingId)
        {
            return repository.GetGrainInvMinibookingTransactionsByMbId(MinibookingId);
        }

        public static List<VW_GrainUnitStorage> GetAllGrainInventoryUnitsByFilter(string CustomerName, List<string> CargoType, string SearchField)
        {
            return repository.GetAllGrainInventoryUnitsByFilter(CustomerName, CargoType, SearchField);
        }

        public static List<VW_GrainInvMinibookingAssignment> GetGrainInvMBAsnUnitsByFilter(int MiniBookingId)
        {
            return repository.GetGrainInvMBAsnUnitsByFilter(MiniBookingId);
        }

        public bool InsertGrainInvTransactionGrainStorageLocation(int GrainInventoryTransactionId, int GrainInvStorageLocationId)
        {
            return repository.InsertGrainInvTransactionGrainStorageLocation(GrainInventoryTransactionId, GrainInvStorageLocationId);
        }
    }
}