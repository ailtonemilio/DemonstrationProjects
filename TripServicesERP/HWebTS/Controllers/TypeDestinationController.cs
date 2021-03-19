using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HWebTS.Models;

namespace HWebTS.Controllers
{
    [Authorize(Roles = "Admin")]
    public class TypeDestinationController : Controller
    {
        private atripservicesEntities db = new atripservicesEntities();

        TypeDestination td = new TypeDestination();

        // GET: TypeDestination
        public ActionResult Index()
        {
            return View(db.TypeDestination.ToList());
        }

        // GET: TypeDestination/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeDestination typeDestination = db.TypeDestination.Find(id);
            if (typeDestination == null)
            {
                return HttpNotFound();
            }
            return View(typeDestination);
        }

        // GET: TypeDestination/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TypeDestination/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdTypeDestination,DescTypeDestination")] TypeDestination typeDestination)
        {
            if (ModelState.IsValid)
            {
                db.TypeDestination.Add(typeDestination);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(typeDestination);
        }

        [HttpGet]
        public ActionResult AddNew(string TypeDest)
        {
            td.DescTypeDestination = TypeDest;

            db.TypeDestination.Add(td);
            db.SaveChanges();

            return Json(new { success = true, oldval = TypeDest },
                JsonRequestBehavior.AllowGet);
        }

            // GET: TypeDestination/Edit/5
            public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeDestination typeDestination = db.TypeDestination.Find(id);
            if (typeDestination == null)
            {
                return HttpNotFound();
            }
            return View(typeDestination);
        }

        // POST: TypeDestination/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdTypeDestination,DescTypeDestination")] TypeDestination typeDestination)
        {
            if (ModelState.IsValid)
            {
                db.Entry(typeDestination).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(typeDestination);
        }

        public ActionResult DeleteTypeDestination(int Id)
        {
            var deleted = "";

            var Inv = (from p in db.TypeDestination
                       where p.IdTypeDestination == Id
                       select p).ToList<TypeDestination>();


            if (Inv.Count() > 0)
            {
                TypeDestination TypeDestination = db.TypeDestination.Find(Id);
                db.TypeDestination.Remove(TypeDestination);
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
            TypeDestination typeDestination = db.TypeDestination.Find(id);
            db.TypeDestination.Remove(typeDestination);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: TypeDestination/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeDestination typeDestination = db.TypeDestination.Find(id);
            if (typeDestination == null)
            {
                return HttpNotFound();
            }
            return View(typeDestination);
        }

        // POST: TypeDestination/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TypeDestination typeDestination = db.TypeDestination.Find(id);
            db.TypeDestination.Remove(typeDestination);
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
