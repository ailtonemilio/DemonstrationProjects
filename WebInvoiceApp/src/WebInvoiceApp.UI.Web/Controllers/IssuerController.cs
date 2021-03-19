using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebInvoiceApp.UI.Web.Models;

namespace WebInvoice.Controllers
{
    [Authorize(Roles = "Admin")]
    public class IssuerController : Controller
    {
        private webinvoiceEntities db = new webinvoiceEntities();

        // GET: Issuer
        public ActionResult Index()
        {
            var issuer = db.Issuer;
            return View(issuer.ToList());
        }

        // GET: Issuer/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Issuer issuer = db.Issuer.Find(id);
            if (issuer == null)
            {
                return HttpNotFound();
            }
            return View(issuer);
        }

        // GET: Issuer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Issuer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdIssuer,NameIssuer,Contact,Address,City,Province,PostalCode,Fone,Email")] Issuer issuer)
        {
            if (ModelState.IsValid)
            {
                db.Issuer.Add(issuer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(issuer);
        }

        // GET: Issuer/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Issuer issuer = db.Issuer.Find(id);
            if (issuer == null)
            {
                return HttpNotFound();
            }
            return View(issuer);
        }

        // POST: Issuer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdIssuer,NameIssuer,Contact,Address,City,Province,PostalCode,Fone,Email")] Issuer issuer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(issuer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(issuer);
        }

        //public ActionResult DeleteIssuer(int id)
        //{
        //    var Inv = (from p in db.Invoice
        //                where p.IdIssuer == id
        //               select p).ToList<Invoice>();

        //    if (Inv.Count() > 0)
        //    {
        //        ViewBag.Message = "Existe Invoice com este Issue!!!";
        //        return View();
        //    }
        //    else
        //    {
        //        //Issuer Issuer = db.Issuer.Find(id);
        //        //db.Issuer.Remove(Issuer);
        //        //db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

            
        //}

        public ActionResult DeleteIssuer(int Id)
        {
            var deleted = "";

            var Inv = (from p in db.Invoice
                       where p.IdIssuer == Id
                       select p).ToList<Invoice>();


            if (Inv.Count() > 0)
            {
                deleted = "false";
            }
            else
            {
                Issuer Issuer = db.Issuer.Find(Id);
                db.Issuer.Remove(Issuer);
                db.SaveChanges();
                deleted = "true";
                @ViewBag.Message = "Sucess";
            }


            return Json(new { success = true, deleted },
               JsonRequestBehavior.AllowGet);
        }


        // GET: Issuer/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Issuer issuer = db.Issuer.Find(id);
            if (issuer == null)
            {
                return HttpNotFound();
            }
            return View(issuer);
        }

        // POST: Issuer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Issuer issuer = db.Issuer.Find(id);
            db.Issuer.Remove(issuer);
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
