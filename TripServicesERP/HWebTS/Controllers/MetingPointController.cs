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
    public class MetingPointController : Controller
    {
        private atripservicesEntities db = new atripservicesEntities();

        // GET: MetingPoint
        public ActionResult Index()
        {
            return View(db.MetingPoint.ToList());
        }

        // GET: MetingPoint/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MetingPoint metingPoint = db.MetingPoint.Find(id);
            if (metingPoint == null)
            {
                return HttpNotFound();
            }
            return View(metingPoint);
        }

        // GET: MetingPoint/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MetingPoint/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdMetingPoint,DescMetingPoint")] MetingPoint metingPoint)
        {
            if (ModelState.IsValid)
            {
                db.MetingPoint.Add(metingPoint);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(metingPoint);
        }

        // GET: MetingPoint/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MetingPoint metingPoint = db.MetingPoint.Find(id);
            if (metingPoint == null)
            {
                return HttpNotFound();
            }
            return View(metingPoint);
        }

        // POST: MetingPoint/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdMetingPoint,DescMetingPoint")] MetingPoint metingPoint)
        {
            if (ModelState.IsValid)
            {
                db.Entry(metingPoint).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(metingPoint);
        }

        public ActionResult DeleteMetingPoint(int Id)
        {
            var deleted = "";

            var Inv = (from p in db.MetingPoint
                       where p.IdMetingPoint == Id
                       select p).ToList<MetingPoint>();


            if (Inv.Count() > 0)
            {
                MetingPoint MetingPoint = db.MetingPoint.Find(Id);
                db.MetingPoint.Remove(MetingPoint);
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
            MetingPoint metingPoint = db.MetingPoint.Find(id);
            db.MetingPoint.Remove(metingPoint);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: MetingPoint/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MetingPoint metingPoint = db.MetingPoint.Find(id);
            if (metingPoint == null)
            {
                return HttpNotFound();
            }
            return View(metingPoint);
        }

        // POST: MetingPoint/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MetingPoint metingPoint = db.MetingPoint.Find(id);
            db.MetingPoint.Remove(metingPoint);
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
