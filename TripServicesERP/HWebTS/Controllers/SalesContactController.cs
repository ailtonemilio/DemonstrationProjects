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
    public class SalesContactController : Controller
    {
        private atripservicesEntities db = new atripservicesEntities();

        // GET: SalesContact
        public ActionResult Index()
        {
            return View(db.SalesContact.ToList());
        }

        // GET: SalesContact/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalesContact salesContact = db.SalesContact.Find(id);
            if (salesContact == null)
            {
                return HttpNotFound();
            }
            return View(salesContact);
        }

        // GET: SalesContact/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SalesContact/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdSalesContact,Contact,Address,City,Phone,ThemeColor,PercentPay")] SalesContact salesContact)
        {
            if (ModelState.IsValid)
            {
                db.SalesContact.Add(salesContact);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(salesContact);
        }

        // GET: SalesContact/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalesContact salesContact = db.SalesContact.Find(id);
            if (salesContact == null)
            {
                return HttpNotFound();
            }
            return View(salesContact);
        }

        // POST: SalesContact/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdSalesContact,Contact,Address,City,Phone,ThemeColor,PercentPay")] SalesContact salesContact)
        {
            if (ModelState.IsValid)
            {
                db.Entry(salesContact).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(salesContact);
        }

        public ActionResult DeleteItem(int id)
        {
            var deleted = "";

            try
            {
                SalesContact salesContact = db.SalesContact.Find(id);
                db.SalesContact.Remove(salesContact);
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

        // GET: SalesContact/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalesContact salesContact = db.SalesContact.Find(id);
            if (salesContact == null)
            {
                return HttpNotFound();
            }
            return View(salesContact);
        }

        // POST: SalesContact/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SalesContact salesContact = db.SalesContact.Find(id);
            db.SalesContact.Remove(salesContact);
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

        public static List<SelectListItem> GetColor()
        {
            List<SelectListItem> ls = new List<SelectListItem>();

            ls.Add(new SelectListItem() { Text = "Red", Value = "red" });
            ls.Add(new SelectListItem() { Text = "Green", Value = "green" });
            ls.Add(new SelectListItem() { Text = "Blue", Value = "blue" });
            ls.Add(new SelectListItem() { Text = "Dark Blue ", Value = "darkBlue " });
            ls.Add(new SelectListItem() { Text = "Yellow", Value = "yellow" });
            ls.Add(new SelectListItem() { Text = "Dark Red ", Value = "darkred " });

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
                ls.Add(new SelectListItem() { Text = temp.City, Value = temp.City });
            }
            return ls;
        }
    }
}
