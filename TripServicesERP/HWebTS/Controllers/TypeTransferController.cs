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
    public class TypeTransferController : Controller
    {
        private atripservicesEntities db = new atripservicesEntities();

        // GET: TypeTransfer
        public ActionResult Index()
        {
            return View(db.TypeTransfer.ToList());
        }

        // GET: TypeTransfer/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeTransfer typeTransfer = db.TypeTransfer.Find(id);
            if (typeTransfer == null)
            {
                return HttpNotFound();
            }
            return View(typeTransfer);
        }

        // GET: TypeTransfer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TypeTransfer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdTypeTransfer,DescType")] TypeTransfer typeTransfer)
        {
            if (ModelState.IsValid)
            {
                db.TypeTransfer.Add(typeTransfer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(typeTransfer);
        }

        // GET: TypeTransfer/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeTransfer typeTransfer = db.TypeTransfer.Find(id);
            if (typeTransfer == null)
            {
                return HttpNotFound();
            }
            return View(typeTransfer);
        }

        // POST: TypeTransfer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdTypeTransfer,DescType")] TypeTransfer typeTransfer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(typeTransfer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(typeTransfer);
        }

        public ActionResult DeleteItem(int id)
        {
            var deleted = "";

            try
            {
                TypeTransfer tt = db.TypeTransfer.Find(id);
                db.TypeTransfer.Remove(tt);
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

        // GET: TypeTransfer/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeTransfer typeTransfer = db.TypeTransfer.Find(id);
            if (typeTransfer == null)
            {
                return HttpNotFound();
            }
            return View(typeTransfer);
        }

        // POST: TypeTransfer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TypeTransfer typeTransfer = db.TypeTransfer.Find(id);
            db.TypeTransfer.Remove(typeTransfer);
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
