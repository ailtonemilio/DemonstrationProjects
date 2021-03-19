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
    public class ACCESSController : Controller
    {
        private atripservicesEntities db = new atripservicesEntities();

        // GET: ACCESS
        public ActionResult Index()
        {
            return View(db.ACCESS.ToList());
        }

        // GET: ACCESS/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ACCESS aCCESS = db.ACCESS.Find(id);
            if (aCCESS == null)
            {
                return HttpNotFound();
            }
            return View(aCCESS);
        }

        // GET: ACCESS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ACCESS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdLogin,Email,UserLog,Password,Active,Profile,Name,LastName,UserLogin")] ACCESS aCCESS)
        {
            if (ModelState.IsValid)
            {
                using (atripservicesEntities db = new atripservicesEntities())
                {
                    var vLogin = db.ACCESS.Where(p => p.Email.Equals(aCCESS.Email)).FirstOrDefault();

                    if (vLogin != null)
                    {
                        ModelState.AddModelError("", "Already registered user!!! Please, use other email.");
                        return View(new ACCESS());
                    }
                    else
                    {
                        db.ACCESS.Add(aCCESS);
                        db.SaveChanges();
                        return RedirectToAction("Index");
                    }
                }
            }

            return View(aCCESS);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "IdLogin,Email,UserLog,Password,Active,Profile,Name,LastName")] ACCESS aCCESS)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.ACCESS.Add(aCCESS);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(aCCESS);
        //}

        // GET: ACCESS/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ACCESS aCCESS = db.ACCESS.Find(id);
            if (aCCESS == null)
            {
                return HttpNotFound();
            }
            return View(aCCESS);
        }

        // POST: ACCESS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdLogin,Email,UserLog,Password,Active,Profile,Name,LastName,UserLogin")] ACCESS aCCESS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aCCESS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aCCESS);
        }

        public ActionResult DeleteItem(int id)
        {
            ACCESS ACCESS = db.ACCESS.Find(id);
            db.ACCESS.Remove(ACCESS);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: ACCESS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ACCESS aCCESS = db.ACCESS.Find(id);
            if (aCCESS == null)
            {
                return HttpNotFound();
            }
            return View(aCCESS);
        }

        // POST: ACCESS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ACCESS aCCESS = db.ACCESS.Find(id);
            db.ACCESS.Remove(aCCESS);
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
