using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataLayer
{
    public class BagInventoryRepository : IBagInventoryRepository

    {
        private Bag b = new Bag();
        private BagInventory bi = new BagInventory();
        private BagLogo bl = new BagLogo();
        private BagInventoryTransaction bt = new BagInventoryTransaction();
        private BagLocation blt = new BagLocation();
        private BookingBagAssignment bba = new BookingBagAssignment();
        private BookingBagUsage bbu = new BookingBagUsage();

        public bool DeleteBagLocation(int BagLocationId)
        {
            bool isSaved = true;

            try
            {
                using (WTCCeresEntities db = new WTCCeresEntities())
                {
                    blt = db.BagLocation.Find(BagLocationId);
                    db.BagLocation.Remove(blt);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                isSaved = false;
            }
            return isSaved;
        }

        public bool DeleteBookingBagAssignment(int BookignBagAssignmentId)
        {
            bool isSaved = true;

            try
            {
                using (WTCCeresEntities db = new WTCCeresEntities())
                {
                    var bb = db.BookingBagAssignment.Find(BookignBagAssignmentId);
                    db.BookingBagAssignment.Remove(bb);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                isSaved = false;
            }
            return isSaved;
        }

        public List<Bagger> GetAllBaggers()
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.Bagger.ToList();
            }
        }

        public List<BagLogo> GetAllBagLogos()
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.BagLogo.ToList();
            }
        }

        public List<VW_Bag> GetAllBags()
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_Bag.ToList();
            }
        }

        public List<VW_Bag> GetAllBagsByFilter(string BagName, string BagColor, string BagSize, string CustomerName)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var list = db.VW_Bag.Where(b => b.BagDescription.Contains(BagName)
                                                            && b.ColorName.Contains(BagColor)
                                                            && b.BagSizeName.Contains(BagSize)
                                                            && b.ColorName.Contains(CustomerName));

                return list.ToList();
            }
        }

        public List<BagSize> GetAllBagSize()
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var list = db.BagSize.ToList();
                BagSize b = new BagSize();
                b.BagSizeName = "";
                b.BagSizeId = 0;
                list.Insert(0, b);

                return list;
            }
        }

        public List<BagWeight> GetAllBagWeights()
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var list = db.BagWeight.ToList();

                return list;
            }
        }

        public List<ColorList> GetAllColors()
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var list = db.ColorList.ToList();
                ColorList c = new ColorList();
                c.ColorName = "";
                c.ColorId = 0;
                list.Insert(0, c);
                return list;
            }
        }

        public List<VW_BagInventory> GetAllInventory(bool ActiveBag)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var list = db.VW_BagInventory.AsNoTracking().Where(b => b.ActiveBag == ActiveBag).OrderBy(c => c.Remaining);
                return list.ToList();
            }
        }

        public List<VW_BagInventoryTransaction> GetAllInventoryTransaction(bool ActiveBag)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var list = db.VW_BagInventoryTransaction.ToList();
                return list.ToList();
            }
        }

        public List<TransactionType> GetAllTransactionsType()
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.TransactionType.ToList();
            }
        }

        public List<BagLocation> GetBagLocations()
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.BagLocation.ToList();
            }
        }

        public List<VW_InventoryBagLocation> GetBagLocationsByInvId(int InventoryId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_InventoryBagLocation.Where(b => b.BagInventoryId == InventoryId && b.BagQuantity > 0).ToList();
            }
        }

        public BagLogo GetBagLogoById(int BagLogoId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.BagLogo.Find(BagLogoId);
            }
        }

        public VW_Bag GetBagVWById(int BagId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_Bag.Where(b => b.BagId == BagId).ToList()[0];
            }
        }

        public List<VW_BookingBagInventoryAssignment> GetBookingBagInvAsnmByMbId(int MinibookingId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var list = db.VW_BookingBagInventoryAssignment.Where(b => b.MinibookingId == MinibookingId);

                return list.ToList();
            }
        }

        public List<VW_BookingBagInventoryAssignment> GetBookingBagInvAsnmtByBag(int BagInventoryId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var list = db.VW_BookingBagInventoryAssignment.Where(b => b.BagInventoryId == BagInventoryId);
                return list.ToList();
            }
        }

        public VW_BookingBagInventoryAssignment GetBookingBagInvAsnmtByMbBag(int MinibookingId, int BagInventoryId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var list = db.VW_BookingBagInventoryAssignment.Where(b => b.MinibookingId == MinibookingId && b.BagInventoryId == BagInventoryId);
                return list.ToList()[0];
            }
        }

        public List<VW_BagInventory> GetInventoryByCustomerId(int CustomerId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_BagInventory.Where(b => b.CustomerId == CustomerId).ToList();
            }
        }

        public List<VW_BagInventory> GetInventoryByFilters(string CustomerName, string BagDescription, string BagColor, string BagSize)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var list = db.VW_BagInventory.Where(b => b.CustomerName.Contains(CustomerName)
                                                               && b.BagDescription.Contains(BagDescription)
                                                               && b.BagColor.Contains(BagColor)
                                                               && b.BagSizeName.Contains(BagSize)).OrderBy(c => c.Remaining);

                return list.ToList();
            }
        }

        public VW_BagInventory GetInventoryById(int BagInventoryId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                return db.VW_BagInventory.Where(bi => bi.BagInventoryId == BagInventoryId).ToList()[0];
            }
        }

        public List<VW_BagInventoryTransaction> GetInventoryTransactionById(int BagInventoryId)
        {
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                var list = db.VW_BagInventoryTransaction.Where(b => b.BagInventoryId == BagInventoryId).ToList();
                return list;
            }
        }

        public int GetLastBagId()
        {
            return b.BagId;
        }

        public int GetLastBagInventoryId()
        {
            return bi.BagInventoryId;
        }

        public int GetLastBagInventoryTransactionId()
        {
            return bt.BagInventoryTransactionId;
        }

        public int GetLastBagLocationId()
        {
            return blt.BagLocationId;
        }

        public int GetLastBagLogoId()
        {
            return bl.BagLogoId;
        }

        public int GetLastBookingBagAssignmentId()
        {
            return bba.BookingBagAssignmentId;
        }

        public bool InsertBag(int BagSizeId, int BagWeightId, int ColorId, string ColorType, int BagLogoId, string BagDescription)
        {
            bool isSaved = true;
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    //        b = new Bag();
                    b.ColorId = ColorId;
                    b.BagSizeId = BagSizeId;
                    b.BagWeightId = BagWeightId;
                    b.ColorType = ColorType;
                    b.BagLogoId = BagLogoId;
                    b.BagDescription = BagDescription;
                    db.Bag.Add(b);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    isSaved = false;
                }
            }

            return isSaved;
        }

        public bool InsertBagInventory(int ShipperId, int BagId, int Quantity, DateTime StorageDate, bool ActiveBag)
        {
            bool isSaved = true;

            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    bi.ShipperId = ShipperId;
                    bi.BagId = BagId;
                    bi.InitialQuantity = Quantity;

                    bi.StorageDate = StorageDate;
                    bi.ActiveBag = ActiveBag;

                    db.BagInventory.Add(bi);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    isSaved = false;
                }
            }

            return isSaved;
        }

        public bool InsertBagInventoryTransaction(int TransactionTypeId, int Quantity, DateTime TransactionDate, int BagLocationId)
        {
            bool isSaved = true;

            try
            {
                using (WTCCeresEntities db = new WTCCeresEntities())
                {
                    bt.TransactionTypeId = TransactionTypeId;
                    bt.Quantity = Quantity;
                    bt.TransactionDate = TransactionDate;
                    bt.BagLocationId = BagLocationId;

                    db.BagInventoryTransaction.Add(bt);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                isSaved = false;
            }

            return isSaved;
        }

        public bool InsertBagLocation(int BagInventoryId, string LocationName, int StorageTypeId, int StorageId, int BagQuantity)
        {
            bool isSaved = true;
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    blt.BagInventoryId = BagInventoryId;
                    blt.StorageId = StorageId;
                    blt.LocationName = LocationName;
                    blt.StorageTypeId = StorageTypeId;
                    blt.BagQuantity = BagQuantity;

                    db.BagLocation.Add(blt);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    isSaved = false;
                }
            }

            return isSaved;
        }

        public bool InsertBagLogo(string BagYear, string LogoDescription, string ImagePath)
        {
            bool isSaved = true;
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    bl.BagYear = BagYear;
                    bl.LogoDescription = LogoDescription;
                    bl.ImagePath = ImagePath;

                    db.BagLogo.Add(bl);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    isSaved = false;
                }
            }

            return isSaved;
        }

        public bool InsertBagSize(string BagSize)
        {
            bool isSaved = true;
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    var bz = new BagSize();
                    bz.BagSizeName = BagSize;

                    db.BagSize.Add(bz);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    isSaved = false;
                }
            }

            return isSaved;
        }

        public bool InsertBookingBagAssignment(int BagInventoryId, int MinibookingId, DateTime CreatedAt)
        {
            bool isSaved = true;

            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    bba.BagInventoryId = BagInventoryId;
                    bba.MinibookingId = MinibookingId;
                    bba.CreatedAt = CreatedAt;

                    db.BookingBagAssignment.Add(bba);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    isSaved = false;
                }
            }

            return isSaved;
        }

        public bool InsertBookingBagUsage(int BookingBagAssignmentId, int BagInventoryTransactionId)
        {
            bool isSaved = true;
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    bbu.BookingBagAssignmentId = BookingBagAssignmentId;
                    bbu.BagInventoryTransactionId = BagInventoryTransactionId;
                    db.BookingBagUsage.Add(bbu);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    isSaved = false;
                }
                return isSaved;
            }
        }

        public bool UpdateBag(int BagId, int BagSizeId, int BagWeightId, int ColorId, string ColorType, int BagLogoId, string BagDescription)
        {
            bool isSaved = true;
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    var b = db.Bag.Find(BagId);
                    b.ColorId = ColorId;
                    b.BagSizeId = BagSizeId;
                    b.BagWeightId = BagWeightId;
                    b.ColorType = ColorType;
                    b.BagLogoId = BagLogoId;
                    b.BagDescription = BagDescription;
                    db.Bag.AddOrUpdate(b);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    isSaved = false;
                }
                return isSaved;
            }
        }

        public bool UpdateBagInventory(int BagInventoryId, int ShipperId, int BagId, int Quantity, DateTime StorageDate, bool ActiveBag)
        {
            bool isSaved = true;
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    bi = db.BagInventory.Find(BagInventoryId);
                    bi.ShipperId = ShipperId;
                    bi.BagId = BagId;
                    bi.InitialQuantity = Quantity;

                    bi.StorageDate = StorageDate;
                    bi.ActiveBag = ActiveBag;

                    db.BagInventory.AddOrUpdate(bi);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    isSaved = false;
                }
            }

            return isSaved;
        }

        public bool UpdateBagInventoryTransaction(int BagInventoryTransactionId, int TransactionTypeId, int Quantity, DateTime TransactionDate, int BagLocationId)
        {
            bool isSaved = true;
            using (WTCCeresEntities db = new WTCCeresEntities())
            {
                try
                {
                    bt = db.BagInventoryTransaction.Find(BagInventoryTransactionId);

                    bt.TransactionTypeId = TransactionTypeId;
                    bt.Quantity = Quantity;
                    bt.TransactionDate = TransactionDate;
                    bt.BagLocationId = BagLocationId;
                    db.BagInventoryTransaction.AddOrUpdate(bt);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    isSaved = false;
                }
            }
            return isSaved;
        }

        public bool UpdateBagLocation(int BagLocationId, int BagInventoryId, string LocationName, int StorageTypeId, int StorageId, int BagQuantity)
        {
            bool isSaved = true;

            try
            {
                using (WTCCeresEntities dbContext = new WTCCeresEntities())
                {
                    blt = dbContext.BagLocation.Find(BagLocationId);
                    blt.BagInventoryId = BagInventoryId;

                    blt.StorageId = StorageId;
                    blt.LocationName = LocationName;
                    blt.StorageTypeId = StorageTypeId;
                    blt.BagQuantity = BagQuantity;

                    dbContext.BagLocation.AddOrUpdate(blt);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                isSaved = false;
            }

            return isSaved;
        }

        public bool UpdateBagLogo(int BagLogoId, string LogoDescription, string BagYear, string ImagePath)
        {
            bool isSaved = true;

            try
            {
                using (WTCCeresEntities db = new WTCCeresEntities())
                {
                    bl = db.BagLogo.Find(BagLogoId);
                    bl.BagYear = BagYear;
                    bl.LogoDescription = LogoDescription;
                    bl.ImagePath = ImagePath;

                    db.BagLogo.AddOrUpdate(bl);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                isSaved = false;
            }

            return isSaved;
        }

        public bool UpdateBookingBagAssignment(int BookingBagAssignmentId, int BagInventoryId, int MinibookingId, DateTime CreatedAt)
        {
            bool isSaved = true;

            try
            {
                using (WTCCeresEntities db = new WTCCeresEntities())
                {
                    bba = db.BookingBagAssignment.Find(BookingBagAssignmentId);
                    bba.BagInventoryId = BagInventoryId;
                    bba.MinibookingId = MinibookingId;
                    bba.CreatedAt = CreatedAt;

                    db.BookingBagAssignment.AddOrUpdate(bba);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                isSaved = false;
            }
            return isSaved;
        }

        public bool UpdateBookingBagUsage(int BookingBagUsageId, int BookingBagAssignmentId, int BagInventoryTransactionId)
        {
            bool isSaved = true;

            try
            {
                using (WTCCeresEntities db = new WTCCeresEntities())
                {
                    bbu = db.BookingBagUsage.Find(BookingBagUsageId);
                    bbu.BookingBagAssignmentId = BookingBagAssignmentId;
                    bbu.BagInventoryTransactionId = BagInventoryTransactionId;
                    db.BookingBagUsage.AddOrUpdate(bbu);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                isSaved = false;
            }
            return isSaved;
        }
    }

    public interface IBagInventoryRepository
    {
        bool InsertBagSize(string BagSize);

        bool InsertBag(int BagSizeId, int BagWeightId, int ColorId, string ColorType, int BagLogoId, string BagDescription);

        bool UpdateBag(int BagId, int BagSizeId, int BagWeightId, int ColorId, string ColorType, int BagLogoId, string BagDescription);

        int GetLastBagId();

        bool InsertBagInventory(int ShipperId, int BagId, int Quantity, DateTime StorageDate, bool ActiveBag);

        bool UpdateBagInventory(int BagInventoryId, int ShipperId, int BagId, int Quantity, DateTime StorageDate, bool ActiveBag);

        int GetLastBagInventoryId();

        int GetLastBagInventoryTransactionId();

        bool InsertBagLogo(string BagYear, string LogoDescription, string ImagePath);

        int GetLastBagLogoId();

        bool UpdateBagLogo(int BagLogoId, string LogoDescription, string BagYear, string ImagePath);

        bool InsertBagInventoryTransaction(int TransactionTypeId, int Quantity, DateTime TransactionDate, int BagLocationId);

        bool UpdateBagInventoryTransaction(int BagInventoryTransactionId, int TransactionTypeId, int Quantity, DateTime TransactionDate, int BagLocationId);

        bool InsertBagLocation(int BagInventoryId, string LocationName, int StorageTypeId, int StorageId, int BagQuantity);

        bool UpdateBagLocation(int BagLocationId, int BagInventoryId, string LocationName, int StorageTypeId, int StorageId, int BagQuantity);

        int GetLastBagLocationId();

        bool InsertBookingBagAssignment(int BagInventoryId, int MinibookingId, DateTime CreatedAt);

        bool UpdateBookingBagAssignment(int BookingBagAssignmentId, int BagInventoryId, int MinibookingId, DateTime CreatedAt);

        bool InsertBookingBagUsage(int BookingBagAssignmentId, int BagInventoryTransactionId);

        bool UpdateBookingBagUsage(int BookingBagUsageId, int BookingBagAssignmentId, int BagInventoryTransactionId);

        int GetLastBookingBagAssignmentId();

        bool DeleteBagLocation(int BagLocationId);

        bool DeleteBookingBagAssignment(int BookignBagAssignmentId);

        List<VW_BagInventory> GetAllInventory(bool ActiveBag);

        List<VW_BagInventory> GetInventoryByCustomerId(int CustomerId);

        List<VW_BagInventory> GetInventoryByFilters(string CustomerName, string BagDescription, string BagColor, string BagSize);

        List<Bagger> GetAllBaggers();

        VW_BagInventory GetInventoryById(int BagInventoryId);

        List<BagWeight> GetAllBagWeights();

        VW_BookingBagInventoryAssignment GetBookingBagInvAsnmtByMbBag(int MinibookingId, int BagInventoryId);

        List<VW_BookingBagInventoryAssignment> GetBookingBagInvAsnmtByBag(int BagInventoryId);

        List<VW_BookingBagInventoryAssignment> GetBookingBagInvAsnmByMbId(int MinibookingId);

        List<BagLogo> GetAllBagLogos();

        //   List<BagLogo> GetBagLogosByCustomerId(int CustomerId);

        BagLogo GetBagLogoById(int BagLogoId);

        List<ColorList> GetAllColors();

        List<BagLocation> GetBagLocations();

        List<VW_InventoryBagLocation> GetBagLocationsByInvId(int InventoryId);

        List<BagSize> GetAllBagSize();

        List<VW_Bag> GetAllBags();

        List<VW_Bag> GetAllBagsByFilter(string BagName, string BagColor, string BagSize, string CustomerName);

        VW_Bag GetBagVWById(int BagId);

        List<TransactionType> GetAllTransactionsType();

        List<VW_BagInventoryTransaction> GetAllInventoryTransaction(bool ActiveBag);

        List<VW_BagInventoryTransaction> GetInventoryTransactionById(int BagInventoryId);
    }
}