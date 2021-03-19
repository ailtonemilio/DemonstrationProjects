using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HWebTS.Models;

namespace HWebTS.Controllers
{
    [Authorize(Roles = "Admin")]
    public class BankInfoController : Controller
    {
        private atripservicesEntities db = new atripservicesEntities();

        // GET: BankInfo
        public ActionResult Index()
        {
            var bankInfo = db.BankInfo.Include(b => b.Bank);

            //var entryPoint = (from ep in dbContext.tbl_EntryPoint
            //                  join e in dbContext.tbl_Entry on ep.EID equals e.EID
            //                  join t in dbContext.tbl_Title on e.TID equals t.TID
            //                  where e.OwnerID == user.UID
            //                  select new
            //                  {
            //                      UID = e.OwnerID,
            //                      TID = e.TID,
            //                      Title = t.Title,
            //                      EID = e.EID
            //                  }).Take(10);

            return View(bankInfo.ToList());
        }

        // GET: BankInfo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BankInfo bankInfo = db.BankInfo.Find(id);
            if (bankInfo == null)
            {
                return HttpNotFound();
            }
            return View(bankInfo);
        }

        // GET: BankInfo/Create
        public ActionResult Create()
        {
            ViewBag.IdBank = new SelectList(db.Bank, "IdBank", "Name");
            return View();
        }

        // POST: BankInfo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdBankInfo,BankAddress,BankPostalCode,BankCity,BankProvince,AccountNumber,SwiftCode,TransitNumber,Customer,IdBank")] BankInfo bankInfo)
        {
            if (ModelState.IsValid)
            {
                db.BankInfo.Add(bankInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdBank = new SelectList(db.Bank, "IdBank", "Name", bankInfo.IdBank);
            return View(bankInfo);
        }

        // GET: BankInfo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BankInfo bankInfo = db.BankInfo.Find(id);
            if (bankInfo == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdBank = new SelectList(db.Bank, "IdBank", "Name", bankInfo.IdBank);
            return View(bankInfo);
        }

        // POST: BankInfo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdBankInfo,BankAddress,BankPostalCode,BankCity,BankProvince,AccountNumber,SwiftCode,TransitNumber,Customer,IdBank")] BankInfo bankInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bankInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdBank = new SelectList(db.Bank, "IdBank", "Name", bankInfo.IdBank);
            return View(bankInfo);
        }

        public ActionResult DeleteItem(int id)
        {
            var deleted = "";

            try
            {
                BankInfo bankinfo = db.BankInfo.Find(id);
                db.BankInfo.Remove(bankinfo);
                db.SaveChanges();
                deleted = "true";
            }
            catch (Exception)
            {
                deleted = "false";
            }

            return Json(new { success = true, deleted },
             JsonRequestBehavior.AllowGet);
        }

        // GET: BankInfo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BankInfo bankInfo = db.BankInfo.Find(id);
            if (bankInfo == null)
            {
                return HttpNotFound();
            }
            return View(bankInfo);
        }

        // POST: BankInfo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BankInfo bankInfo = db.BankInfo.Find(id);
            db.BankInfo.Remove(bankInfo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public static List<SelectListItem> GetProvince()
        {
            List<SelectListItem> ls = new List<SelectListItem>();

            ls.Add(new SelectListItem() { Text = "Alberta", Value = "AB" });
            ls.Add(new SelectListItem() { Text = "British Columbia", Value = "BC" });
            ls.Add(new SelectListItem() { Text = "Manitoba", Value = "MB" });
            ls.Add(new SelectListItem() { Text = "New Brunswick", Value = "NB " });
            ls.Add(new SelectListItem() { Text = "Newfoundland and Labrador", Value = "NL" });
            ls.Add(new SelectListItem() { Text = "Nova Scotia ", Value = "NS " });
            ls.Add(new SelectListItem() { Text = "Ontario", Value = "ON" });
            ls.Add(new SelectListItem() { Text = "Prince Edward Island ", Value = "PE " });
            ls.Add(new SelectListItem() { Text = "Quebec", Value = "QC" });
            ls.Add(new SelectListItem() { Text = "Saskatchewan ", Value = "SK " });
            ls.Add(new SelectListItem() { Text = "Northwest Territories ", Value = "NT " });
            ls.Add(new SelectListItem() { Text = "Yukon ", Value = "YT " });
            ls.Add(new SelectListItem() { Text = "Nunavut ", Value = "NU " });

            return ls;
        }

        public static List<SelectListItem> GetCity()
        {
            List<SelectListItem> ls = new List<SelectListItem>();

            atripservicesEntities ctx = new atripservicesEntities();

            var dados = (from p in ctx.PriceCities
                         select p).ToList<PriceCities>();

            foreach (var temp in dados)
            {
                ls.Add(new SelectListItem() { Text = temp.City, Value = temp.IdCity.ToString() });
            }
            return ls;
        }
    }
}
