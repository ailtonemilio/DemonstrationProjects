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
    public class ConfigAppController : Controller
    {
        private atripservicesEntities db = new atripservicesEntities();

        // GET: ConfigApp
        public ActionResult Index()
        {
            return View(db.ConfigApp.ToList());
        }

        // GET: ConfigApp/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConfigApp configApp = db.ConfigApp.Find(id);
            if (configApp == null)
            {
                return HttpNotFound();
            }
            return View(configApp);
        }

        // GET: ConfigApp/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConfigApp/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdConfigApp,NameApp,AccountPOP3,PortPOP3,AccountSMTP,PortSMTP,account,PasswordAccount")] ConfigApp configApp)
        {
            if (ModelState.IsValid)
            {
                db.ConfigApp.Add(configApp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(configApp);
        }

        // GET: ConfigApp/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConfigApp configApp = db.ConfigApp.Find(id);
            if (configApp == null)
            {
                return HttpNotFound();
            }
            return View(configApp);
        }

        // POST: ConfigApp/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdConfigApp,NameApp,AccountPOP3,PortPOP3,AccountSMTP,PortSMTP,account,PasswordAccount")] ConfigApp configApp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(configApp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(configApp);
        }


        public ActionResult DeleteItem(int id)
        {
            var deleted = "";

            try
            {
                ConfigApp capp = db.ConfigApp.Find(id);
                db.ConfigApp.Remove(capp);
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

        // GET: ConfigApp/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConfigApp configApp = db.ConfigApp.Find(id);
            if (configApp == null)
            {
                return HttpNotFound();
            }
            return View(configApp);
        }

        // POST: ConfigApp/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ConfigApp configApp = db.ConfigApp.Find(id);
            db.ConfigApp.Remove(configApp);
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
