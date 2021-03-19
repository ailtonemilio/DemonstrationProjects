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
    public class SalesSourceController : Controller
    {
        private atripservicesEntities db = new atripservicesEntities();

        // GET: SalesSource
        public ActionResult Index()
        {
            var salesSource = db.SalesSource.Include(s => s.SalesContact);
            return View(salesSource.ToList());
        }

        // GET: SalesSource/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalesSource salesSource = db.SalesSource.Find(id);
            if (salesSource == null)
            {
                return HttpNotFound();
            }
            return View(salesSource);
        }

        // GET: SalesSource/Create
        public ActionResult Create()
        {
            ViewBag.IdSalesContact = new SelectList(db.SalesContact, "IdSalesContact", "Contact");
            return View();
        }

        // POST: SalesSource/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdSalesSource,Value,PercentPay,TypePay,Status,Note,IdSalesContact,NumInvoice")] SalesSource salesSource)
        {
            if (ModelState.IsValid)
            {
                db.SalesSource.Add(salesSource);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdSalesContact = new SelectList(db.SalesContact, "IdSalesContact", "Contact", salesSource.IdSalesContact);
            return View(salesSource);
        }

        // GET: SalesSource/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalesSource salesSource = db.SalesSource.Find(id);
            if (salesSource == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdSalesContact = new SelectList(db.SalesContact, "IdSalesContact", "Contact", salesSource.IdSalesContact);
            return View(salesSource);
        }

        // POST: SalesSource/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdSalesSource,Value,PercentPay,TypePay,Status,Note,IdSalesContact,NumInvoice")] SalesSource salesSource)
        {
            if (ModelState.IsValid)
            {
                db.Entry(salesSource).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdSalesContact = new SelectList(db.SalesContact, "IdSalesContact", "Contact", salesSource.IdSalesContact);
            return View(salesSource);
        }

        public ActionResult DeleteItem(int id)
        {
            var deleted = "";

            try
            {
                SalesSource salesSource = db.SalesSource.Find(id);
                db.SalesSource.Remove(salesSource);
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

        // GET: SalesSource/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalesSource salesSource = db.SalesSource.Find(id);
            if (salesSource == null)
            {
                return HttpNotFound();
            }
            return View(salesSource);
        }

        // POST: SalesSource/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SalesSource salesSource = db.SalesSource.Find(id);
            db.SalesSource.Remove(salesSource);
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
    }
}
