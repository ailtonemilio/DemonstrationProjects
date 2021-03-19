using DataLayer;
using ModelLayer;
using System;
using System.Collections.Generic;

namespace BusinessLayer.WTC_Ceres
{
    public class BagInventoryService
    {
        private static IBagInventoryRepository repository;

        static BagInventoryService()
        {
            repository = new BagInventoryRepository();
        }

        public bool InsertBagSize(string BagSize)
        {
            return repository.InsertBagSize(BagSize);
        }

        public bool InsertBag(int BagSizeId, int BagWeightId, int ColorId, string ColorType, int BagLogoId, string BagDescription)
        {
            return repository.InsertBag(BagSizeId, BagWeightId, ColorId, ColorType, BagLogoId, BagDescription);
        }

        public bool UpdateBag(int BagId, int BagSizeId, int BagWeightId, int ColorId, string ColorType, int BagLogoId, string BagDescription)
        {
            return repository.UpdateBag(BagId, BagSizeId, BagWeightId, ColorId, ColorType, BagLogoId, BagDescription);
        }

        public int GetLastBagId()
        {
            return repository.GetLastBagId();
        }

        public static VW_Bag GetBagVWById(int BagId)
        {
            return repository.GetBagVWById(BagId);
        }

        public static List<VW_Bag> GetAllBagsByFilter(string BagName, string BagColor, string BagSize, string CustomerName)
        {
            return repository.GetAllBagsByFilter(BagName, BagColor, BagSize, CustomerName);
        }

        public bool InsertBagInventory(int ShipperId, int BagId, int Quantity, DateTime StorageDate, bool ActiveBag)
        {
            return repository.InsertBagInventory(ShipperId, BagId, Quantity, StorageDate, ActiveBag);
        }

        public bool UpdateBagInventory(int BagInventoryId, int ShipperId, int BagId, int Quantity, DateTime StorageDate, bool ActiveBag)
        {
            return repository.UpdateBagInventory(BagInventoryId, ShipperId, BagId, Quantity, StorageDate, ActiveBag);
        }

        public int GetLastBagInventoryId()
        {
            return repository.GetLastBagInventoryId();
        }

        public bool InsertBagLogo(string BagYear, string LogoDescription, string ImagePath)
        {
            return repository.InsertBagLogo(BagYear, LogoDescription, ImagePath);
        }

        public int GetLastBagLogoId()
        {
            return repository.GetLastBagLogoId();
        }

        public bool UpdateBagLogo(int BagLogoId, string LogoDescription, string BagYear, string ImagePath)
        {
            return repository.UpdateBagLogo(BagLogoId, LogoDescription, BagYear, ImagePath);
        }

        public bool InsertBagInventoryTransaction(int TransactionTypeId, int Quantity, DateTime TransactionDate, int BagLocationid)
        {
            return repository.InsertBagInventoryTransaction(TransactionTypeId, Quantity, TransactionDate, BagLocationid);
        }

        public bool UpdateBagInventoryTransaction(int BagInventoryTransactionId, int TransactionTypeId, int Quantity,
            DateTime TransactionDate, int BagLocationid)
        {
            return repository.UpdateBagInventoryTransaction(BagInventoryTransactionId, TransactionTypeId, Quantity, TransactionDate, BagLocationid);
        }

        public bool InsertBagLocation(int BagInventoryId, string LocationName, int StorageTypeId, int StorageId, int BagQuantity)
        {
            return repository.InsertBagLocation(BagInventoryId, LocationName, StorageTypeId, StorageId, BagQuantity);
        }

        public bool UpdateBagLocation(int BagLocationId, int BagInventoryId, string LocationName, int StorageTypeId, int StorageId, int BagQuantity)
        {
            return repository.UpdateBagLocation(BagLocationId, BagInventoryId, LocationName, StorageTypeId, StorageId, BagQuantity);
        }

        public static List<VW_BagInventory> GetAllInventory(bool ActiveBag)
        {
            return repository.GetAllInventory(ActiveBag);
        }

        public static VW_BagInventory GetInventoryById(int BagInventoryId)
        {
            return repository.GetInventoryById(BagInventoryId);
        }

        public static List<BagWeight> GetAllBagWeights()
        {
            return repository.GetAllBagWeights();
        }

        public static List<ColorList> GetAllColors()
        {
            return repository.GetAllColors();
        }

        public static List<VW_BagInventoryTransaction> GetInventoryTransactionById(int BagInventoryId)
        {
            return repository.GetInventoryTransactionById(BagInventoryId);
        }

        public static List<BagLocation> GetBagLocations()
        {
            return repository.GetBagLocations();
        }

        public static List<BagSize> GetAllBagSize()
        {
            return repository.GetAllBagSize();
        }

        public static List<TransactionType> GetAllTransactionsType()
        {
            return repository.GetAllTransactionsType();
        }

        public static List<VW_BagInventoryTransaction> GetAllInventoryTransaction(bool ActiveBag)
        {
            return repository.GetAllInventoryTransaction(ActiveBag);
        }

        public static List<BagLogo> GetAllBagLogos()
        {
            return repository.GetAllBagLogos();
        }

        //public static List<BagLogo> GetBagLogosByCustomerId(int CustomerId)
        //{
        //    return repository.GetBagLogosByCustomerId(CustomerId);
        //}

        public static BagLogo GetBagLogoById(int BagLogoId)
        {
            return repository.GetBagLogoById(BagLogoId);
        }

        public static List<VW_Bag> GetAllBags()
        {
            return repository.GetAllBags();
        }

        public static List<Bagger> GetAllBaggers()
        {
            return repository.GetAllBaggers();
        }

        public static List<VW_BagInventory> GetInventoryByFilters(string CustomerName, string BagDescription, string BagColor, string BagSize)
        {
            return repository.GetInventoryByFilters(CustomerName, BagDescription, BagColor, BagSize);
        }

        public bool InsertBookingBagAssignment(int BagInventoryId, int MinibookingId, DateTime CreatedAt)
        {
            return repository.InsertBookingBagAssignment(BagInventoryId, MinibookingId, CreatedAt);
        }

        public bool UpdateBookingBagAssignment(int BookingBagAssignmentId, int BagInventoryId, int MinibookingId, DateTime CreatedAt)
        {
            return repository.UpdateBookingBagAssignment(BookingBagAssignmentId, BagInventoryId, MinibookingId, CreatedAt);
        }

        public bool InsertBookingBagUsage(int BookingBagAssignmentId, int BagInventoryTransactionId)
        {
            return repository.InsertBookingBagUsage(BookingBagAssignmentId, BagInventoryTransactionId);
        }

        public bool UpdateBookingBagUsage(int BookingBagUsageId, int BookingBagAssignmentId, int BagInventoryTransactionId)
        {
            return repository.UpdateBookingBagUsage(BookingBagUsageId, BookingBagAssignmentId, BagInventoryTransactionId);
        }

        public int GetLastBookingBagAssignmentId()
        {
            return repository.GetLastBookingBagAssignmentId();
        }

        public static VW_BookingBagInventoryAssignment GetBookingBagInvAsnmtByMbBag(int MinibookingId, int BagInventoryId)
        {
            return repository.GetBookingBagInvAsnmtByMbBag(MinibookingId, BagInventoryId);
        }

        public int GetLastBagInventoryTransactionId()
        {
            return repository.GetLastBagInventoryTransactionId();
        }

        public static List<VW_BookingBagInventoryAssignment> GetBookingBagInvAsnmtByBag(int BagInventoryId)
        {
            return repository.GetBookingBagInvAsnmtByBag(BagInventoryId);
        }

        public static List<VW_BagInventory> GetInventoryByCustomerId(int CustomerId)
        {
            return repository.GetInventoryByCustomerId(CustomerId);
        }

        public static List<VW_InventoryBagLocation> GetBagLocationsByInvId(int InventoryId)
        {
            return repository.GetBagLocationsByInvId(InventoryId);
        }

        public bool DeleteBagLocation(int BagLocationId)
        {
            return repository.DeleteBagLocation(BagLocationId);
        }

        public int GetLastBagLocationId()
        {
            return repository.GetLastBagLocationId();
        }

        public static List<VW_BookingBagInventoryAssignment> GetBookingBagInvAsnmByMbId(int MinibookingId)
        {
            return repository.GetBookingBagInvAsnmByMbId(MinibookingId);
        }

        public bool DeleteBookingBagAssignment(int BookignBagAssignmentId)
        {
            return repository.DeleteBookingBagAssignment(BookignBagAssignmentId);
        }
    }
}