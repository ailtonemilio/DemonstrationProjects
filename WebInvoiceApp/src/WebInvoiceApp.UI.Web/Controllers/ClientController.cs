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
    public class ClientController : Controller
    {
        private webinvoiceEntities db = new webinvoiceEntities();

        // GET: Client
        public ActionResult Index()
        {
            return View(db.Client.ToList());
        }

        // GET: Client/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Client client = db.Client.Find(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        // GET: Client/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Client/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdClient,NameClient,Contact,Address,City,Province,PostalCode,Fone")] Client client)
        {
            if (ModelState.IsValid)
            {
                db.Client.Add(client);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(client);
        }

        // GET: Client/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Client client = db.Client.Find(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        // POST: Client/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdClient,NameClient,Contact,Address,City,Province,PostalCode,Fone")] Client client)
        {
            if (ModelState.IsValid)
            {
                db.Entry(client).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(client);
        }

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

        public ActionResult DeleteClient(int Id)
        {
            var deleted = "";

            var Inv = (from p in db.Invoice
                       where p.IdClient == Id
                       select p).ToList<Invoice>();


            if (Inv.Count() > 0)
            {
                deleted = "false";
            }
            else
            {
                Client Client = db.Client.Find(Id);
                db.Client.Remove(Client);
                db.SaveChanges();

                deleted = "true";
                @ViewBag.Message = "Sucess";
            }


            return Json(new { success = true, deleted },
               JsonRequestBehavior.AllowGet);
        }

        // GET: Client/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Client client = db.Client.Find(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        // POST: Client/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Client client = db.Client.Find(id);
            db.Client.Remove(client);
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
