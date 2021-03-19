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
    public class PassengerController : Controller
    {
        private atripservicesEntities db = new atripservicesEntities();

        // GET: Passenger
        public ActionResult Index()
        {
            var passeger = db.Passenger.Include(d => d.TypeVisa);
            return View(passeger.ToList());
        }

        // GET: Passenger/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Passenger passenger = db.Passenger.Find(id);
            if (passenger == null)
            {
                return HttpNotFound();
            }
            return View(passenger);
        }

        // GET: Passenger/Create
        public ActionResult Create()
        {
            ViewBag.IdTypeVisa = new SelectList(db.TypeVisa, "IdTypeVisa", "DescTypeVisa");
            return View();
        }

        // POST: Passenger/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdPassenger,Name,Phone,Phone2,Email,IdTypeVisa")] Passenger passenger)
        {
            if (ModelState.IsValid)
            {
                db.Passenger.Add(passenger);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdTypeVisa = new SelectList(db.TypeVisa, "IdTypeVisa", "DescTypeVisa", passenger.IdTypeVisa);
            return View(passenger);
        }

        // GET: Passenger/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Passenger passenger = db.Passenger.Find(id);
            if (passenger == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdTypeVisa = new SelectList(db.TypeVisa, "IdTypeVisa", "DescTypeVisa", passenger.IdTypeVisa);
            return View(passenger);
        }

        // POST: Passenger/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdPassenger,Name,Phone,Phone2,Email,IdTypeVisa")] Passenger passenger)
        {
            if (ModelState.IsValid)
            {
                db.Entry(passenger).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdTypeVisa = new SelectList(db.TypeVisa, "IdTypeVisa", "DescTypeVisa", passenger.IdTypeVisa);
            return View(passenger);
        }

        public ActionResult DeleteItem(int id)
        {
            var deleted = "";

            try
            {
                Passenger passenger = db.Passenger.Find(id);
                db.Passenger.Remove(passenger);
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

        // GET: Passenger/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Passenger passenger = db.Passenger.Find(id);
            if (passenger == null)
            {
                return HttpNotFound();
            }
            return View(passenger);
        }

        // POST: Passenger/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Passenger passenger = db.Passenger.Find(id);
            db.Passenger.Remove(passenger);
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

        //Auto Complete
        [HttpPost]
        public JsonResult AutoComplete(string prefix)
        {
            atripservicesEntities entities = new atripservicesEntities();
            var customers = (from p in entities.Passenger
                             join t in entities.TypeVisa on p.IdTypeVisa equals t.IdTypeVisa
                             where p.Name.StartsWith(prefix)
                             select new
                             {
                                 lName = p.Name,
                                 lId = p.IdPassenger.ToString(),
                                 lEmail = p.Email,
                                 lPhone = p.Phone,
                                 lPhone2 = p.Phone2,
                                 lTypeVisa = t.DescTypeVisa.ToString()
                             }).ToList();

            return Json(customers);
        }
    }
}
