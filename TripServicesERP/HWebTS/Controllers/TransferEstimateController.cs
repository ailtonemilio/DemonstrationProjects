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
    public class TransferEstimateController : Controller
    {
        private atripservicesEntities db = new atripservicesEntities();

        TypeDestination td = new TypeDestination();

        // GET: TransferEstimate
        //[Authorize(Roles = "Administrador")]
        public ActionResult Index()
        {
            var transferEstimate = (db.TransferEstimate).Include(t => t.Destination).Include(t => t.MetingPoint).Include(t => t.PriceCitiesFrom).Include(t => t.PriceCitiesTo).Include(t => t.SalesContact).Include(t => t.StatusPayment).Include(t => t.TransferAprove).Include(t => t.TypeDestination).Include(t => t.TypePayment).Include(t => t.TypeTransfer).Include(t => t.Passenger);

            var transferEstimate2 = (from p in transferEstimate
                                     where p.IdAprove == 0 || p.IdAprove == 1
                                     select p).ToList<TransferEstimate>();

            return View(transferEstimate2.ToList());
        }

        //GET: TransferEstimate with Approved
        public ActionResult TransferApproved()
        {
            var ida = 2;

            var transferEstimate = (from p in db.TransferEstimate
                                    where p.IdAprove == ida
                                    select p).ToList<TransferEstimate>();
            return View(transferEstimate.ToList());
        }

        // GET: TransferEstimate/Details/5
        //[Authorize(Roles = "Administrador")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TransferEstimate transferEstimate = db.TransferEstimate.Find(id);
            if (transferEstimate == null)
            {
                return HttpNotFound();
            }
            return View(transferEstimate);
        }

        [HttpGet]
        //[Authorize(Roles = "Administrador")]
        public ActionResult AddNew(string TypeDest)
        {
            td.DescTypeDestination = TypeDest;

            db.TypeDestination.Add(td);
            db.SaveChanges();

            return Json(new { success = true, oldval = TypeDest },
                JsonRequestBehavior.AllowGet);
        }

        // GET: TransferEstimate/Create
        //[Authorize(Roles = "Administrador")]
        public ActionResult Create()
        {
            ViewBag.IdDestination = new SelectList(db.Destination, "IdDestination", "Name");
            ViewBag.IdMetingPoint = new SelectList(db.MetingPoint, "IdMetingPoint", "DescMetingPoint");
            ViewBag.CityFromId = new SelectList(db.PriceCities, "IdCity", "City");
            ViewBag.CityToId = new SelectList(db.PriceCities, "IdCity", "City");
            ViewBag.IdSales = new SelectList(db.SalesContact, "IdSalesContact", "Contact");
            ViewBag.IdStatusPayment = new SelectList(db.StatusPayment, "IdStatusPayment", "DescStatusPayment");
            ViewBag.IdAprove = new SelectList(db.TransferAprove, "IdAprove", "DescAprove");
            ViewBag.IdTypeDestination = new SelectList(db.TypeDestination, "IdTypeDestination", "DescTypeDestination");
            ViewBag.IdTypePayment = new SelectList(db.TypePayment, "IdTypePayment", "DescTypePayment");
            ViewBag.IdTypeTransfer = new SelectList(db.TypeTransfer, "IdTypeTransfer", "DescType");
            return View();
        }

        // POST: TransferEstimate/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize(Roles = "Administrador")]
        public ActionResult Create([Bind(Include = "IdTransEst,FlightNumber,DateFligh,TimeFligh,TimePiDo,IdMetingPoint,QtyPassenger,QtyPassengerKids,QtyMalaGr,QtyMalaPq,CityFromId,CityToId,TransferAmount,Discount,FinalPrice,DateTransEst,DateAprove,DateRequestEstimate,NamePassenger,Phone,Phone2,Email,TypeVisa,Note,IdAprove,IdTypeDestination,IdDestination,IdSales,IdTypeTransfer,IdTypePayment,IdStatusPayment")] TransferEstimate transferEstimate)
        {
            if (ModelState.IsValid)
            {
                db.TransferEstimate.Add(transferEstimate);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdDestination = new SelectList(db.Destination, "IdDestination", "Name", transferEstimate.IdDestination);
            ViewBag.IdMetingPoint = new SelectList(db.MetingPoint, "IdMetingPoint", "DescMetingPoint", transferEstimate.IdMetingPoint);
            ViewBag.CityFromId = new SelectList(db.PriceCities, "IdCity", "City", transferEstimate.CityFromId);
            ViewBag.CityToId = new SelectList(db.PriceCities, "IdCity", "City", transferEstimate.CityToId);
            ViewBag.IdSales = new SelectList(db.SalesContact, "IdSalesContact", "Contact", transferEstimate.IdSales);
            ViewBag.IdStatusPayment = new SelectList(db.StatusPayment, "IdStatusPayment", "DescStatusPayment", transferEstimate.IdStatusPayment);
            ViewBag.IdAprove = new SelectList(db.TransferAprove, "IdAprove", "DescAprove", transferEstimate.IdAprove);
            ViewBag.IdTypeDestination = new SelectList(db.TypeDestination, "IdTypeDestination", "DescTypeDestination", transferEstimate.IdTypeDestination);
            ViewBag.IdTypePayment = new SelectList(db.TypePayment, "IdTypePayment", "DescTypePayment", transferEstimate.IdTypePayment);
            ViewBag.IdTypeTransfer = new SelectList(db.TypeTransfer, "IdTypeTransfer", "DescType", transferEstimate.IdTypeTransfer);
            return View(transferEstimate);
        }

        // GET: TransferEstimate/Edit/5
        //[Authorize(Roles = "Administrador")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TransferEstimate transferEstimate = db.TransferEstimate.Find(id);
            if (transferEstimate == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdDestination = new SelectList(db.Destination, "IdDestination", "Name", transferEstimate.IdDestination);
            ViewBag.IdMetingPoint = new SelectList(db.MetingPoint, "IdMetingPoint", "DescMetingPoint", transferEstimate.IdMetingPoint);
            ViewBag.CityFromId = new SelectList(db.PriceCities, "IdCity", "City", transferEstimate.CityFromId);
            ViewBag.CityToId = new SelectList(db.PriceCities, "IdCity", "City", transferEstimate.CityToId);
            ViewBag.IdSales = new SelectList(db.SalesContact, "IdSalesContact", "Contact", transferEstimate.IdSales);
            ViewBag.IdStatusPayment = new SelectList(db.StatusPayment, "IdStatusPayment", "DescStatusPayment", transferEstimate.IdStatusPayment);
            ViewBag.IdAprove = new SelectList(db.TransferAprove, "IdAprove", "DescAprove", transferEstimate.IdAprove);
            ViewBag.IdTypeDestination = new SelectList(db.TypeDestination, "IdTypeDestination", "DescTypeDestination", transferEstimate.IdTypeDestination);
            ViewBag.IdTypePayment = new SelectList(db.TypePayment, "IdTypePayment", "DescTypePayment", transferEstimate.IdTypePayment);
            ViewBag.IdTypeTransfer = new SelectList(db.TypeTransfer, "IdTypeTransfer", "DescType", transferEstimate.IdTypeTransfer);
            return View(transferEstimate);
        }

        // POST: TransferEstimate/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize(Roles = "Administrador")]
        public ActionResult Edit([Bind(Include = "IdTransEst,FlightNumber,DateFligh,TimeFligh,TimePiDo,IdMetingPoint,QtyPassenger,QtyPassengerKids,QtyMalaGr,QtyMalaPq,CityFromId,CityToId,TransferAmount,Discount,FinalPrice,DateTransEst,DateAprove,DateRequestEstimate,NamePassenger,Phone,Phone2,Email,TypeVisa,Note,IdAprove,IdTypeDestination,IdDestination,IdSales,IdTypeTransfer,IdTypePayment,IdStatusPayment")] TransferEstimate transferEstimate)
        {
            if (ModelState.IsValid)
            {
                db.Entry(transferEstimate).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdDestination = new SelectList(db.Destination, "IdDestination", "Name", transferEstimate.IdDestination);
            ViewBag.IdMetingPoint = new SelectList(db.MetingPoint, "IdMetingPoint", "DescMetingPoint", transferEstimate.IdMetingPoint);
            ViewBag.CityFromId = new SelectList(db.PriceCities, "IdCity", "City", transferEstimate.CityFromId);
            ViewBag.CityToId = new SelectList(db.PriceCities, "IdCity", "City", transferEstimate.CityToId);
            ViewBag.IdSales = new SelectList(db.SalesContact, "IdSalesContact", "Contact", transferEstimate.IdSales);
            ViewBag.IdStatusPayment = new SelectList(db.StatusPayment, "IdStatusPayment", "DescStatusPayment", transferEstimate.IdStatusPayment);
            ViewBag.IdAprove = new SelectList(db.TransferAprove, "IdAprove", "DescAprove", transferEstimate.IdAprove);
            ViewBag.IdTypeDestination = new SelectList(db.TypeDestination, "IdTypeDestination", "DescTypeDestination", transferEstimate.IdTypeDestination);
            ViewBag.IdTypePayment = new SelectList(db.TypePayment, "IdTypePayment", "DescTypePayment", transferEstimate.IdTypePayment);
            ViewBag.IdTypeTransfer = new SelectList(db.TypeTransfer, "IdTypeTransfer", "DescType", transferEstimate.IdTypeTransfer);
            return View(transferEstimate);
        }

        //[Authorize(Roles = "Administrador")]
        public ActionResult DeleteItem(int id)
        {
            var deleted = "";

            try
            {
                //Delete Transfer Estimate
                TransferEstimate transferEstimate = db.TransferEstimate.Find(id);
                db.TransferEstimate.Remove(transferEstimate);
                db.SaveChanges();

                //Delete All Send Transfer by Transfer Estimate
                db.TransferSend.Where(p => p.IdTransEst == id)
                                        .ToList().ForEach(p => db.TransferSend.Remove(p));
                db.SaveChanges();

                //Delete Events by Transfer Estimate
                db.Events.Where(p => p.IdTransEst == id).ToList().ForEach(p => db.Events.Remove(p));
                db.SaveChanges();

                deleted = "true";
            }
            catch (Exception)
            {
                deleted = "false";
                throw;
            }

            

            return Json(new { success = true, deleted },
              JsonRequestBehavior.AllowGet);
        }

        // GET: TransferEstimate/Delete/5
        //[Authorize(Roles = "Administrador")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TransferEstimate transferEstimate = db.TransferEstimate.Find(id);
            if (transferEstimate == null)
            {
                return HttpNotFound();
            }
            return View(transferEstimate);
        }

        // POST: TransferEstimate/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
 
        public ActionResult DeleteConfirmed(int id)
        {
            TransferEstimate transferEstimate = db.TransferEstimate.Find(id);
            db.TransferEstimate.Remove(transferEstimate);
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

        public ActionResult GetCity(string qtyPass, string QtyMlGr, string QtyMlPq, string IdCity)
        {
            decimal POne = 0;
            decimal PTwo = 0;
            decimal qtypassenger = Convert.ToDecimal(qtyPass);
            decimal qtyMalaGr = Convert.ToDecimal(QtyMlGr);
            decimal qtyMalaPq = Convert.ToDecimal(QtyMlPq);
            decimal MaxMalaGr = 0;
            decimal MaxMalaPq = 0;
            decimal TotalMala = 0;
            decimal TotalPass = 0;
            decimal Total = 0;


            atripservicesEntities ctx = new atripservicesEntities();

            int idt = Convert.ToInt32(IdCity);

            var ids = idt;

            var dados = (from p in ctx.PriceCities
                         where p.IdCity == ids
                         select p).ToList<PriceCities>();

            foreach (var temp in dados)
            {
                POne = Convert.ToDecimal(temp.PriceOne);
                PTwo = Convert.ToDecimal(temp.Pricetwo);
            }

            //Calculo Passageiro
            if (qtypassenger > 0)
            {
                if (qtypassenger == 1)
                {
                    TotalPass = qtypassenger * POne;
                }
                else
                {
                    TotalPass = POne + (PTwo * (qtypassenger - 1));
                }
            }

            //Calculo Malas
            MaxMalaGr = qtypassenger * 2;
            MaxMalaPq = qtypassenger * 1;

            TotalMala = ((qtyMalaGr - MaxMalaGr) + (qtyMalaPq - MaxMalaPq)) * 10;

            Total = TotalPass + TotalMala;

            //return this.Json(Total.ToString());
            return Json(new { TotalGeral = Total.ToString() });
        }

        [HttpGet]
        public ActionResult GetDestination(string Id)
        {
            string address = "";
            string contact = "";
            string phone = "";
            string mobile = "";

            atripservicesEntities ctx = new atripservicesEntities();

            int idt = Convert.ToInt32(Id);

            var ids = idt;

            var dados = (from p in ctx.Destination
                         where p.IdDestination == ids
                         select p).ToList<Destination>();

            foreach (var temp in dados)
            {
                contact = temp.Name;
                address = temp.Address;
                mobile = temp.Mobile;
                phone = temp.Phone;
            }

            return Json(new { success = true, contact, address, mobile, phone },
                JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetCalculateTranfer(string qtyPass, string QtyMlGr, string QtyMlPq, string IdCityFrom, string IdCityTo)
        {
            decimal POne = 0;
            decimal PTwo = 0;
            decimal qtypassenger = Convert.ToDecimal(qtyPass);
            decimal qtyMalaGr = Convert.ToDecimal(QtyMlGr);
            decimal qtyMalaPq = Convert.ToDecimal(QtyMlPq);
            decimal MaxMalaGr = 0;
            decimal MaxMalaPq = 0;
            decimal TotalMala = 0;
            decimal TotalPass = 0;
            decimal Total = 0;
            string IdCity = "";

            if (IdCityFrom != "1")
            {
                IdCity = IdCityFrom;
            }

            if (IdCityTo != "1")
            {
                IdCity = IdCityTo;
            }

            atripservicesEntities ctx = new atripservicesEntities();

            int idt = Convert.ToInt32(IdCity);

            var ids = idt;

            var dados = (from p in ctx.PriceCities
                         where p.IdCity == ids
                         select p).ToList<PriceCities>();

            foreach (var temp in dados)
            {
                POne = Convert.ToDecimal(temp.PriceOne);
                PTwo = Convert.ToDecimal(temp.Pricetwo);
            }

            //Calculo Passageiro
            if (qtypassenger > 0)
            {
                if (qtypassenger == 1)
                {
                    TotalPass = qtypassenger * POne;
                }
                else
                {
                    TotalPass = POne + (PTwo * (qtypassenger - 1));
                }
            }

            //Calculo Malas
            MaxMalaGr = qtypassenger * 2;
            MaxMalaPq = qtypassenger;

            if (qtyMalaGr > MaxMalaGr)
            {
                TotalMala = qtyMalaGr - MaxMalaGr;
            }

            if (qtyMalaPq > MaxMalaPq)
            {
                TotalMala = TotalMala + (qtyMalaPq - MaxMalaPq);
            }

            TotalMala = TotalMala * 10;

            Total = TotalPass + TotalMala;

            return Json(new { success = true, oldval = Total.ToString() },
                JsonRequestBehavior.AllowGet);

        }
    }
}
