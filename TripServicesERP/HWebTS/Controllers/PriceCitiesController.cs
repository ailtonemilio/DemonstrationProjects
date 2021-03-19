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
    public class PriceCitiesController : Controller
    {
        private atripservicesEntities db = new atripservicesEntities();

        // GET: PriceCities
        public ActionResult Index()
        {
            //var priceCities = db.PriceCities.Include(p => p.SalesContact);
            return View(db.PriceCities.ToList());
        }

        // GET: PriceCities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PriceCities priceCities = db.PriceCities.Find(id);
            if (priceCities == null)
            {
                return HttpNotFound();
            }
            return View(priceCities);
        }

        // GET: PriceCities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PriceCities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdCity,City,PriceOne,Pricetwo")] PriceCities priceCities)
        {
            if (ModelState.IsValid)
            {
                db.PriceCities.Add(priceCities);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(priceCities);
        }

        // GET: PriceCities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PriceCities priceCities = db.PriceCities.Find(id);
            if (priceCities == null)
            {
                return HttpNotFound();
            }
            
            return View(priceCities);
        }

        // POST: PriceCities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdCity,City,PriceOne,Pricetwo")] PriceCities priceCities)
        {
            if (ModelState.IsValid)
            {
                db.Entry(priceCities).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            
            return View(priceCities);
        }

        public ActionResult DeletePriceCities(int Id)
        {
            var deleted = "";

            var Inv = (from p in db.PriceCities
                       where p.IdCity == Id
                       select p).ToList<PriceCities>();


            if (Inv.Count() > 0)
            {
                PriceCities PriceCities = db.PriceCities.Find(Id);
                db.PriceCities.Remove(PriceCities);
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
            PriceCities pricecities = db.PriceCities.Find(id);
            db.PriceCities.Remove(pricecities);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: PriceCities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PriceCities priceCities = db.PriceCities.Find(id);
            if (priceCities == null)
            {
                return HttpNotFound();
            }
            return View(priceCities);
        }

        // POST: PriceCities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PriceCities priceCities = db.PriceCities.Find(id);
            db.PriceCities.Remove(priceCities);
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
