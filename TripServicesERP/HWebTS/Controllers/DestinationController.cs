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
    public class DestinationController : Controller
    {
        private atripservicesEntities db = new atripservicesEntities();

        // GET: Destination
        public ActionResult Index()
        {
            var destination = db.Destination.Include(d => d.SalesContact).Include(d => d.TypeDestination).Include(d => d.PriceCities);
            return View(destination.ToList());
        }

        // GET: Destination/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Destination destination = db.Destination.Find(id);
            if (destination == null)
            {
                return HttpNotFound();
            }
            return View(destination);
        }

        // GET: Destination/Create
        public ActionResult Create()
        {
            ViewBag.IdSalesContact = new SelectList(db.SalesContact, "IdSalesContact", "Contact");
            ViewBag.IdTypeDestination = new SelectList(db.TypeDestination, "IdTypeDestination", "DescTypeDestination");
            ViewBag.IdCity = new SelectList(db.PriceCities, "IdCity", "City");
            return View();
        }

        // POST: Destination/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdDestination,Name,Address,PostalCode,Phone,Mobile,IdTypeDestination,IdSalesContact,IdCity")] Destination destination)
        {
            if (ModelState.IsValid)
            {
                db.Destination.Add(destination);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdSalesContact = new SelectList(db.SalesContact, "IdSalesContact", "Contact", destination.IdSalesContact);
            ViewBag.IdTypeDestination = new SelectList(db.TypeDestination, "IdTypeDestination", "DescTypeDestination", destination.IdTypeDestination);
            ViewBag.IdCity = new SelectList(db.PriceCities, "IdCity", "City", destination.IdCity);
            return View(destination);
        }

        // GET: Destination/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Destination destination = db.Destination.Find(id);
            if (destination == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdSalesContact = new SelectList(db.SalesContact, "IdSalesContact", "Contact", destination.IdSalesContact);
            ViewBag.IdTypeDestination = new SelectList(db.TypeDestination, "IdTypeDestination", "DescTypeDestination", destination.IdTypeDestination);
            ViewBag.IdCity = new SelectList(db.PriceCities, "IdCity", "City", destination.IdCity);
            return View(destination);
        }

        // POST: Destination/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdDestination,Name,Address,PostalCode,Phone,Mobile,IdTypeDestination,IdSalesContact,IdCity")] Destination destination)
        {
            if (ModelState.IsValid)
            {
                db.Entry(destination).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdSalesContact = new SelectList(db.SalesContact, "IdSalesContact", "Contact", destination.IdSalesContact);
            ViewBag.IdTypeDestination = new SelectList(db.TypeDestination, "IdTypeDestination", "DescTypeDestination", destination.IdTypeDestination);
            ViewBag.IdCity = new SelectList(db.PriceCities, "IdCity", "City", destination.IdCity);
            return View(destination);
        }

        public ActionResult DeleteDestination(int Id)
        {
            var deleted = "";

            var Inv = (from p in db.Destination
                       where p.IdDestination == Id
                       select p).ToList<Destination>();


            if (Inv.Count() > 0)
            {
                Destination Destination = db.Destination.Find(Id);
                db.Destination.Remove(Destination);
                db.SaveChanges();

                deleted = "true";
                @ViewBag.Message = "Sucess";
            }
            else
            {
                deleted = "false";
            }


            return Json(new { success = true, deleted },
               JsonRequestBehavior.AllowGet);
        }

        public ActionResult DeleteItem(int id)
        {
            Destination destination = db.Destination.Find(id);
            db.Destination.Remove(destination);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Destination/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Destination destination = db.Destination.Find(id);
            if (destination == null)
            {
                return HttpNotFound();
            }
            return View(destination);
        }

        // POST: Destination/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Destination destination = db.Destination.Find(id);
            db.Destination.Remove(destination);
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
