using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebInvoiceApp.UI.Web.Models;
using WebInvoiceApp.UI.Web.Models.ViewModels;
using Newtonsoft.Json;
using System.Data.Entity.Migrations;



namespace WebInvoiceApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class InvoiceController : Controller
    {
        private webinvoiceEntities db = new webinvoiceEntities();
        Service se = new Service();
        Product po = new Product();
        Issuer iss = new Issuer();
        Invoice inv = new Invoice();
        TypeTaxServ tse = new TypeTaxServ();
        TypeTaxProd tpod = new TypeTaxProd();

        // GET: Invoice
        public ActionResult Index()
        {
            //var invoices = db.Invoice.Include(i => i.Client).Include(i => i.Issuer).Include(i => i.StatusInvoice);
            //return View(invoices.ToList());
            var results = db.Invoice.OrderBy(p => p.NumInvoice);
            return View(results.ToList());
        }

        // GET: Invoice
        public ActionResult RelInv(int? id)
        {
            Invoice invoice = db.Invoice.Find(id);
            return View(invoice);
        }

        // GET: Invoice
        public ActionResult DetailsInv(int? id)
        {
            Invoice invoice = db.Invoice.Find(id);
            return View(invoice);
        }

        // GET: Invoice
        public ActionResult DetailsInv2(int? id)
        {
            Invoice invoice = db.Invoice.Find(id);
            return View(invoice);
        }

        // GET: Invoice
        public ActionResult PrintInv(int? id)
        {
            Invoice invoice = db.Invoice.Find(id);
            return View(invoice);
        }

        // GET: Invoice
        public ActionResult PrintInvV2(int? id)
        {
            Invoice invoice = db.Invoice.Find(id);
            return View(invoice);
        }

        // GET: Invoice
        public ActionResult Print()
        {
            return View();
        }

        //public ActionResult TestImgInvoice(string id)
        //{
        //    var model = new TestViewModel { DocTitle = id, DocContent = "This is a test with a partial view" };
        //    return new PartialViewAsPdf("TestPartialViewWithModel", model);
        //}

        [HttpGet]
        public ActionResult GetProduct(string Id)
        {
            string typeproduct = "";
            string descproduct = "";
            string cost = "";
            string amount = "";
            string taxprod = "";
            string linetot = "";
            string numinv = "";
            string idproduct = "";


            webinvoiceEntities ctx = new webinvoiceEntities();

            int idt = Convert.ToInt32(Id);

            var ids = idt;

            var dados = (from p in ctx.Product
                         where p.IdProduct == ids
                         select p).ToList<Product>();

            foreach (var temp in dados)
            {
                typeproduct = temp.TypeProducts;
                descproduct = temp.DescriptionProd;
                cost = temp.UnitCost.ToString();
                amount = temp.Amount.ToString();
                taxprod = temp.TaxProd.ToString();
                linetot = temp.LineTotalProd.ToString();
                numinv = temp.NumInvoice.ToString();
                idproduct = temp.IdProduct.ToString();
            }

            return Json(new { success = true, typeproduct, descproduct, cost, amount, taxprod, linetot, idproduct },
                JsonRequestBehavior.AllowGet);

        }

        [HttpGet]
        public ActionResult GetTaxProd(string Id)
        {
            string desctax = "";
            string valuetax = "";
            string idtaxprod = "";

            webinvoiceEntities ctx = new webinvoiceEntities();

            int idt = Convert.ToInt32(Id);

            var ids = idt;

            var dados = (from p in ctx.TypeTaxProd
                         where p.IdTypeTaxProd == ids
                         select p).ToList<TypeTaxProd>();

            foreach (var temp in dados)
            {
                desctax = temp.DescTypeTaxProd;
                valuetax = temp.TaxProd.ToString();
                idtaxprod = temp.IdTypeTaxProd.ToString();
            }

            return Json(new { success = true, desctax, valuetax, idtaxprod },
               JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetService(string Id)
        {
            string typeservices = "";
            string descservices = "";
            string hourrate = "";
            string hours = "";
            string taxservice = "";
            string linetot = "";
            string numinv = "";
            string idservice = "";
            

            webinvoiceEntities ctx = new webinvoiceEntities();

            int idt = Convert.ToInt32(Id);

            var ids = idt;

            var dados = (from p in ctx.Service
                         where p.IdService == ids
                         select p).ToList<Service>();

            foreach (var temp in dados)
            {
                typeservices = temp.TypeServices;
                descservices = temp.DescriptionServ;
                hourrate = temp.HourRate.ToString();
                hours = temp.Hour.ToString();
                taxservice = temp.TaxServ.ToString();
                linetot = temp.LineTotalServ.ToString();
                numinv = temp.NumInvoice.ToString();
                idservice = temp.IdService.ToString();
            }

            return Json(new { success = true, typeservices, descservices, hourrate, hours, taxservice, linetot, idservice },
                JsonRequestBehavior.AllowGet);

        }

        [HttpGet]
        public ActionResult GetTaxServ(string Id)
        {
            string desctax = "";
            string valuetax = "";
            string idtaxserv = "";

            webinvoiceEntities ctx = new webinvoiceEntities();

            int idt = Convert.ToInt32(Id);

            var ids = idt;

            var dados = (from p in ctx.TypeTaxServ
                         where p.IdTypeTaxServ == ids
                         select p).ToList<TypeTaxServ>();

            foreach (var temp in dados)
            {
                desctax = temp.DescTypeTaxServ;
                valuetax = temp.TaxServ.ToString();
                idtaxserv = temp.IdTypeTaxServ.ToString();
            }

            return Json(new { success = true, desctax, valuetax, idtaxserv },
               JsonRequestBehavior.AllowGet);
        }

        

        [HttpGet]
        public ActionResult SaveInvoice(string SubTot, string Tot, string Taxx, string dtIssue, string dtDue, string IdIssuer, string IdCli, string IdSta, string Notes, string NumInv, string IdLogin)
        {
            try
            {
                inv.NumInvoice = Convert.ToInt32(NumInv);
                if (!String.IsNullOrEmpty(Tot)) { inv.Total = Convert.ToDecimal(Tot); } else { inv.Total = 0; }
                if (!String.IsNullOrEmpty(SubTot)) { inv.SubTotal = Convert.ToDecimal(SubTot); } else { inv.SubTotal = 0; }
                if (!String.IsNullOrEmpty(Taxx)) { inv.Tax = Convert.ToDecimal(Taxx); } else { inv.Tax = 0; }
                inv.IssueDate = Convert.ToDateTime(dtIssue);
                inv.DueDate = Convert.ToDateTime(dtDue);
                inv.IdIssuer = Convert.ToInt32(IdIssuer);
                inv.IdClient = Convert.ToInt32(IdCli);
                inv.IdStatusInv = Convert.ToInt32(IdSta);
                inv.Note = Notes;

                db.Invoice.AddOrUpdate(inv);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                ViewBag.Message = e;
                throw;
            }

            return Json(new { success = true, oldval = SubTot },
                JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult SaveService(string TypeService, string DescService, string  HourRate, string Hour, string NumInv, string IdIssuer, string IdService, string SubTot, string Tot, string Taxx)
        {
            decimal hor = Convert.ToDecimal(HourRate);
            decimal ho = Convert.ToDecimal(Hour);
            decimal tax = 0;
            decimal tot = 0;
            decimal tottax = 0;
            decimal totplustax = 0;

            var NumInvoice = Convert.ToInt32(NumInv);

            var dados = (from tx in db.TypeTaxServ
                         where tx.NumInvoice == NumInvoice
                         select new
                         {
                             tx.TaxServ

                         }).ToList();

            if (db != null)
            {
                foreach (var item in dados)
                {
                    if (item.TaxServ != 0)
                    { tax += Convert.ToDecimal(item.TaxServ); }
                }
            }

            if (tax != 0)
            {
                if (tax > 100) { tax = 100; }
                tottax = (hor * ho) * (tax / 100);
                tot = (hor * ho);
                totplustax = (hor * ho) * (1 + tax / 100); ;
            }
            else
            {
                tot = (hor * ho);
                totplustax = tot;
            }

            se.TypeServices = TypeService;
            se.DescriptionServ = DescService;
            se.HourRate = hor;
            se.Hour = ho;
            se.TaxServ = tottax;
            se.TotalServ = tot;
            se.LineTotalServ = totplustax;
            se.NumInvoice = Convert.ToInt16(NumInv);

            if (IdService == "0")
            {
                db.Service.Add(se);
            }
            else
            {
                se.IdService = Convert.ToInt16(IdService);
                db.Service.AddOrUpdate(se);
            }
            
            db.SaveChanges();

            #region Somando as linhas e trazendo o SubTotal, Tax e Total
            //Somando as linhas e trazendo o SubTotal, Tax e Total
            decimal LineTServ = 0;
            decimal TaxS = 0;
            decimal LineTProd = 0;
            decimal TaxP = 0;
            decimal SubTotal = 0;
            decimal Total = 0;
            decimal Tax = 0;

            var dser = (from s in db.Service
                        where s.NumInvoice == NumInvoice
                        select new
                        {
                            s.TaxServ,
                            s.LineTotalServ
                        }).ToList();

            if (db != null)
            {
                foreach (var item in dser)
                {
                    TaxS = TaxS + Convert.ToDecimal(item.TaxServ);
                    LineTServ = LineTServ + Convert.ToDecimal(item.LineTotalServ);
                }
            }

            var dpro = (from p in db.Product
                        where p.NumInvoice == NumInvoice
                        select new
                        {
                            p.TaxProd,
                            p.LineTotalProd
                        }).ToList();

            if (db != null)
            {
                foreach (var item in dpro)
                {
                    TaxP = TaxP + Convert.ToDecimal(item.TaxProd);
                    LineTProd = LineTProd + Convert.ToDecimal(item.LineTotalProd);
                }
            }

            //trazendo valor total e subtotal da invoice e seus dados
            DateTime dtIssue = Convert.ToDateTime(null);
            DateTime dtDue = Convert.ToDateTime(null);
            int IdCli = 0;
            int IdSta = 0;
            string Notes = "";


            var Inv = (from i in db.Invoice
                       where i.NumInvoice == NumInvoice
                       select new
                       {
                           i.SubTotal,
                           i.Total,
                           i.IssueDate,
                           i.DueDate,
                           i.IdClient,
                           i.IdStatusInv,
                           i.Note
                       }).ToList();

            if (db != null)
            {
                foreach (var item in Inv)
                {
                    //SubTot = Convert.ToDecimal(item.SubTotal);
                    //Tot = Convert.ToDecimal(item.Total);
                    dtIssue = Convert.ToDateTime(item.IssueDate);
                    dtDue = Convert.ToDateTime(item.DueDate);
                    IdCli = Convert.ToInt32(item.IdClient);
                    IdSta = Convert.ToInt32(item.IdStatusInv);
                    Notes = item.Note;
                }
            }

            Tax = (TaxS + TaxP);
            Total = (LineTProd + LineTServ);
            SubTotal = Total - Tax;


            inv.NumInvoice = Convert.ToInt32(NumInv);
            inv.Total = Total;
            inv.SubTotal = SubTotal;
            inv.Tax = Tax;
            inv.IssueDate = dtIssue;
            inv.DueDate = dtDue;
            inv.IdIssuer = Convert.ToInt32(IdIssuer);
            inv.IdClient = IdCli;
            inv.IdStatusInv = IdSta;
            inv.Note = Notes;

            db.Invoice.AddOrUpdate(inv);
            db.SaveChanges();
            #endregion


            return Json(new { success = true, oldval = SubTotal  },
                JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult SaveTax(string DescTypeTax, string TaxValue,string IdTax, string NumInv, string CalcServ, string CalcProd)
        {
            var IdTaxx = Convert.ToInt32(IdTax);
            var NumInvoice = Convert.ToInt32(NumInv);
            var TotalTax = 0.0;

            //Products
            if (CalcProd == "true")
            {
                #region Insere Tax para Produto
                tpod.DescTypeTaxProd = DescTypeTax;
                tpod.TaxProd = Convert.ToDecimal(TaxValue);
                tpod.NumInvoice = NumInvoice;

                if (IdTax == "0")
                {
                    db.TypeTaxProd.Add(tpod);
                }
                else
                {
                    tpod.IdTypeTaxProd = Convert.ToInt32(IdTaxx);
                    db.TypeTaxProd.AddOrUpdate(tpod);
                }

                db.SaveChanges();
                #endregion

                #region Verifica Total Taxa e atualiza o produto
                var dadoss = (from tx in db.TypeTaxProd
                              where tx.NumInvoice == NumInvoice
                              select new
                              {
                                  tx.TaxProd
                              }).ToList();

                if (db != null)
                {
                    foreach (var item in dadoss)
                    {
                        TotalTax += Convert.ToDouble(item.TaxProd);
                    }
                }

                var dados = (from tx in db.Product
                             where tx.NumInvoice == NumInvoice
                             select new
                             {
                                 tx.IdProduct,
                                 tx.TaxProd,
                                 tx.LineTotalProd,
                                 tx.Amount,
                                 tx.UnitCost,
                                 tx.TotalProd,
                                 tx.DescriptionProd,
                                 tx.TypeProducts

                             }).ToList();

                if (db != null)
                {
                    foreach (var item in dados)
                    {
                        var tottax = Convert.ToDouble((item.Amount * item.UnitCost)) * (TotalTax / 100.0);
                        var tot = Convert.ToDouble((item.Amount * item.UnitCost)) + tottax;

                        po.IdProduct = item.IdProduct;
                        po.TypeProducts = item.TypeProducts;
                        po.DescriptionProd = item.DescriptionProd;
                        po.Amount = item.Amount;
                        po.UnitCost = item.UnitCost;
                        po.TotalProd = item.Amount * item.UnitCost;
                        po.TaxProd = Convert.ToDecimal(tottax);
                        po.LineTotalProd = Convert.ToDecimal(tot);
                        po.NumInvoice = NumInvoice;

                        db.Product.AddOrUpdate(po);
                        db.SaveChanges();
                    }
                }
                #endregion
            }

            //Services
            if (CalcServ == "true")
            {
                #region Insere Tax para Servico
                tse.DescTypeTaxServ = DescTypeTax;
                tse.TaxServ = Convert.ToDecimal(TaxValue);
                tse.NumInvoice = NumInvoice;

                if (IdTax == "0")
                {
                    db.TypeTaxServ.Add(tse);
                }
                else
                {
                    tse.IdTypeTaxServ = Convert.ToInt32(IdTaxx);
                    db.TypeTaxServ.AddOrUpdate(tse);
                }

                db.SaveChanges();
                #endregion

                #region Verifica Total Taxa e atualiza o Servico
                var dadoss = (from tx in db.TypeTaxServ
                              where tx.NumInvoice == NumInvoice
                              select new
                              {
                                  tx.TaxServ
                              }).ToList();

                if (db != null)
                {
                    foreach (var item in dadoss)
                    {
                        TotalTax += Convert.ToDouble(item.TaxServ);
                    }
                }

                var dados = (from tx in db.Service
                             where tx.NumInvoice == NumInvoice
                             select new
                             {
                                 tx.IdService,
                                 tx.TaxServ,
                                 tx.LineTotalServ,
                                 tx.HourRate,
                                 tx.Hour,
                                 tx.TotalServ,
                                 tx.DescriptionServ,
                                 tx.TypeServices

                             }).ToList();

                if (db != null)
                {
                    foreach (var item in dados)
                    {
                        var tottax = Convert.ToDouble((item.HourRate * item.Hour)) * (TotalTax / 100.0);
                        var tot = Convert.ToDouble((item.HourRate * item.Hour)) + tottax;

                        se.IdService = item.IdService;
                        se.TypeServices = item.TypeServices;
                        se.DescriptionServ = item.DescriptionServ;
                        se.HourRate = item.HourRate;
                        se.Hour = item.Hour;
                        se.TotalServ = (item.HourRate * item.Hour);
                        se.TaxServ = Convert.ToDecimal(tottax);
                        se.LineTotalServ = Convert.ToDecimal(tot);
                        se.NumInvoice = NumInvoice;

                        db.Service.AddOrUpdate(se);
                        db.SaveChanges();
                    }
                }
                #endregion
            }

            //Atualiza Valores Invoice
            var Total = 0.0;
            var SubTot = 0.0;
            var TotTax = 0.0;

            var dadosse = (from t in db.Service
                            where t.NumInvoice == NumInvoice
                            select new
                            {
                               t.LineTotalServ,
                               t.TotalServ,
                               t.TaxServ
                            }).ToList();

            if (db != null)
            {
                foreach (var item in dadosse)
                {
                    Total += Convert.ToDouble(item.LineTotalServ);
                    SubTot += Convert.ToDouble(item.TotalServ);
                    TotTax += Convert.ToDouble(item.TaxServ);
                }
            }

            var dadospo = (from t in db.Product
                           where t.NumInvoice == NumInvoice
                           select new
                           {
                               t.LineTotalProd,
                               t.TotalProd,
                               t.TaxProd
                           }).ToList();

            if (db != null)
            {
                foreach (var item in dadospo)
                {
                    Total += Convert.ToDouble(item.LineTotalProd);
                    SubTot += Convert.ToDouble(item.TotalProd);
                    TotTax += Convert.ToDouble(item.TaxProd);
                }
            }


            var dadosinv = (from tx in db.Invoice
                         where tx.NumInvoice == NumInvoice
                         select new
                         {
                             tx.NumInvoice,
                             tx.SubTotal,
                             tx.Total,
                             tx.Tax,
                             tx.IssueDate,
                             tx.DueDate,
                             tx.IdIssuer,
                             tx.IdClient,
                             tx.IdStatusInv,
                             tx.Note
                         }).ToList();

            if (db != null)
            {
                foreach (var item in dadosinv)
                {
                    inv.NumInvoice = item.NumInvoice;
                    inv.SubTotal = Convert.ToDecimal(SubTot);
                    inv.Total = Convert.ToDecimal(Total);
                    inv.Tax = Convert.ToDecimal(TotTax);
                    inv.IssueDate = item.IssueDate;
                    inv.DueDate = item.DueDate;
                    inv.IdIssuer = item.IdIssuer;
                    inv.IdClient = item.IdClient;
                    inv.IdStatusInv = item.IdStatusInv;
                    inv.Note = item.Note;

                    db.Invoice.AddOrUpdate(inv);
                    db.SaveChanges();
                }
            }



            return Json(new { success = true, oldval = TaxValue },
                JsonRequestBehavior.AllowGet);
        }

        public string CalcSubTotal(string NumInv)
        {
            var NumInvoice = Convert.ToInt32(NumInv);

            //Somando as linhas e trazendo o SubTotal, Tax e Total
            decimal LineTServ = 0;
            decimal TaxS = 0;
            decimal LineTProd = 0;
            decimal TaxP = 0;
            decimal SubTotal = 0;
            decimal Total = 0;
            decimal Tax = 0;

            var dser = (from s in db.Service
                        where s.NumInvoice == NumInvoice
                        select new
                        {
                            s.TaxServ,
                            s.LineTotalServ
                        }).ToList();

            if (db != null)
            {
                foreach (var item in dser)
                {
                    TaxS = TaxS + Convert.ToDecimal(item.TaxServ);
                    LineTServ = LineTServ + Convert.ToDecimal(item.LineTotalServ);
                }
            }

            var dpro = (from p in db.Product
                        where p.NumInvoice == NumInvoice
                        select new
                        {
                            p.TaxProd,
                            p.LineTotalProd
                        }).ToList();

            if (db != null)
            {
                foreach (var item in dpro)
                {
                    TaxP = TaxP + Convert.ToDecimal(item.TaxProd);
                    LineTProd = LineTProd + Convert.ToDecimal(item.LineTotalProd);
                }
            }

            Tax = (TaxS + TaxP);
            Total = (LineTProd + LineTServ);
            SubTotal = Total - Tax;

            return SubTotal.ToString("#0.00");
        }
        public string CalcTax(string NumInv)
        {
            var NumInvoice = Convert.ToInt32(NumInv);

            //Somando as linhas e trazendo o SubTotal, Tax e Total
            decimal LineTServ = 0;
            decimal TaxS = 0;
            decimal LineTProd = 0;
            decimal TaxP = 0;
            decimal SubTotal = 0;
            decimal Total = 0;
            decimal Tax = 0;

            var dser = (from s in db.Service
                        where s.NumInvoice == NumInvoice
                        select new
                        {
                            s.TaxServ,
                            s.LineTotalServ
                        }).ToList();

            if (db != null)
            {
                foreach (var item in dser)
                {
                    TaxS = TaxS + Convert.ToDecimal(item.TaxServ);
                    LineTServ = LineTServ + Convert.ToDecimal(item.LineTotalServ);
                }
            }

            var dpro = (from p in db.Product
                        where p.NumInvoice == NumInvoice
                        select new
                        {
                            p.TaxProd,
                            p.LineTotalProd
                        }).ToList();

            if (db != null)
            {
                foreach (var item in dpro)
                {
                    TaxP = TaxP + Convert.ToDecimal(item.TaxProd);
                    LineTProd = LineTProd + Convert.ToDecimal(item.LineTotalProd);
                }
            }

            Tax = (TaxS + TaxP);
            Total = (LineTProd + LineTServ);
            SubTotal = Total - Tax;

            return Tax.ToString("#0.00");
        }
        public string CalcTotal(string NumInv)
        {
            var NumInvoice = Convert.ToInt32(NumInv);

            //Somando as linhas e trazendo o SubTotal, Tax e Total
            decimal LineTServ = 0;
            decimal TaxS = 0;
            decimal LineTProd = 0;
            decimal TaxP = 0;
            decimal SubTotal = 0;
            decimal Total = 0;
            decimal Tax = 0;

            var dser = (from s in db.Service
                        where s.NumInvoice == NumInvoice
                        select new
                        {
                            s.TaxServ,
                            s.LineTotalServ
                        }).ToList();

            if (db != null)
            {
                foreach (var item in dser)
                {
                    TaxS = TaxS + Convert.ToDecimal(item.TaxServ);
                    LineTServ = LineTServ + Convert.ToDecimal(item.LineTotalServ);
                }
            }

            var dpro = (from p in db.Product
                        where p.NumInvoice == NumInvoice
                        select new
                        {
                            p.TaxProd,
                            p.LineTotalProd
                        }).ToList();

            if (db != null)
            {
                foreach (var item in dpro)
                {
                    TaxP = TaxP + Convert.ToDecimal(item.TaxProd);
                    LineTProd = LineTProd + Convert.ToDecimal(item.LineTotalProd);
                }
            }

            Tax = (TaxS + TaxP);
            Total = (LineTProd + LineTServ);
            SubTotal = Total - Tax;

            return Total.ToString("#0.00");
        }

        [HttpGet]
        public ActionResult SaveProduct(string TypeProduct, string DescProduct, string UnitCoast, string Amount, string NumInv, string IdIssuer, string IdProduct, string SubTot, string Tot, string Taxx)
        {
            decimal uni = Convert.ToDecimal(UnitCoast);
            decimal amo = Convert.ToDecimal(Amount);
            decimal tax = 0;
            decimal tot = 0;
            decimal tottax = 0;
            decimal totplustax = 0;

            var NumInvoice = Convert.ToInt32(NumInv);

            var dados = (from tx in db.TypeTaxProd
                         where tx.NumInvoice == NumInvoice
                         select new
                         {
                             tx.TaxProd

                         }).ToList();

            if (db != null)
            {
                foreach (var item in dados)
                {
                    if (item.TaxProd != 0)
                    { tax += Convert.ToDecimal(item.TaxProd); }
                }
            }

            if (tax != 0)
            {
                if (tax > 100) { tax = 100; }
                tottax = (uni * amo) * (tax / 100);
                tot = (uni * amo);
                totplustax = (uni * amo) * (1 + tax / 100); ;
            }
            else
            {
                tot = (uni * amo);
                totplustax = tot;
            }

            po.TypeProducts = TypeProduct;
            po.DescriptionProd = DescProduct;
            po.Amount = amo;
            po.UnitCost = uni;
            po.TotalProd = tot;
            po.TaxProd = tottax;
            po.LineTotalProd = totplustax;
            po.NumInvoice = Convert.ToInt32(NumInv);

            if (IdProduct == "0")
            {
                db.Product.Add(po);
            }
            else
            {
                po.IdProduct = Convert.ToInt32(IdProduct);
                db.Product.AddOrUpdate(po);
            }

            
            db.SaveChanges();

            //Somando as linhas e trazendo o SubTotal, Tax e Total
            decimal LineTServ = 0;
            decimal TaxS = 0;
            decimal LineTProd = 0;
            decimal TaxP = 0;
            decimal SubTotal = 0;
            decimal Total = 0;
            decimal Tax = 0;

            var dser = (from s in db.Service

                        where s.NumInvoice == NumInvoice
                        select new
                        {
                            s.TaxServ,
                            s.LineTotalServ
                        }).ToList();

            if (db != null)
            {
                foreach (var item in dser)
                {
                    TaxS = TaxS + Convert.ToDecimal(item.TaxServ);
                    LineTServ = LineTServ + Convert.ToDecimal(item.LineTotalServ);
                }
            }

            var dpro = (from p in db.Product
                        where p.NumInvoice == NumInvoice
                        select new
                        {
                            p.TaxProd,
                            p.LineTotalProd
                        }).ToList();

            if (db != null)
            {
                foreach (var item in dpro)
                {
                    TaxP = TaxP + Convert.ToDecimal(item.TaxProd);
                    LineTProd = LineTProd + Convert.ToDecimal(item.LineTotalProd);
                }
            }

            //trazendo valor total e subtotal da invoice e seus dados
            DateTime dtIssue = Convert.ToDateTime(null);
            DateTime dtDue = Convert.ToDateTime(null);
            int IdCli = 0;
            int IdSta = 0;
            string Notes = "";


            var Inv = (from i in db.Invoice
                       where i.NumInvoice == NumInvoice
                       select new
                       {
                           i.SubTotal,
                           i.Total,
                           i.IssueDate,
                           i.DueDate,
                           i.IdClient,
                           i.IdStatusInv,
                           i.Note
                       }).ToList();

            if (db != null)
            {
                foreach (var item in Inv)
                {
                    //SubTot = Convert.ToDecimal(item.SubTotal);
                    //Tot = Convert.ToDecimal(item.Total);
                    dtIssue = Convert.ToDateTime(item.IssueDate);
                    dtDue = Convert.ToDateTime(item.DueDate);
                    IdCli = Convert.ToInt32(item.IdClient);
                    IdSta = Convert.ToInt32(item.IdStatusInv);
                    Notes = item.Note;
                }
            }

            Tax = (TaxS + TaxP);
            Total = (LineTProd + LineTServ);
            SubTotal = Total - Tax;


            inv.NumInvoice = Convert.ToInt32(NumInv);
            inv.Total = Total;
            inv.SubTotal = SubTotal;
            inv.Tax = Tax;
            inv.IssueDate = dtIssue;
            inv.DueDate = dtDue;
            inv.IdIssuer = Convert.ToInt32(IdIssuer);
            inv.IdClient = IdCli;
            inv.IdStatusInv = IdSta;
            inv.Note = Notes;

            

            db.Invoice.AddOrUpdate(inv);
            db.SaveChanges();


            return Json(new { success = true, oldval = SubTotal },
                JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult SaveTaxProd(string DescTypeTax, string TaxValue, string IdTax, string NumInv, string CalcServ, string CalcProd)
        {
            var IdTaxx = Convert.ToInt32(IdTax);
            var NumInvoice = Convert.ToInt32(NumInv);


            tpod.DescTypeTaxProd = DescTypeTax;
            tpod.TaxProd = Convert.ToDecimal(TaxValue);
            tpod.NumInvoice = NumInvoice;

            if (IdTax == "0")
            {
                db.TypeTaxProd.Add(tpod);
            }
            else
            {
                tpod.IdTypeTaxProd = Convert.ToInt32(IdTaxx);
                db.TypeTaxProd.AddOrUpdate(tpod);
            }

            db.SaveChanges();
            db.Dispose();

            if (CalcServ == "true")
            {
                var dados = (from tx in db.Service
                             where tx.NumInvoice == NumInvoice
                             select new
                             {
                                 tx.IdService,
                                 tx.TaxServ,
                                 tx.LineTotalServ,
                                 tx.HourRate,
                                 tx.Hour,
                                 tx.DescriptionServ,
                                 tx.TypeServices

                             }).ToList();

                if (db != null)
                {
                    foreach (var item in dados)
                    {
                        var tot = Convert.ToDouble(item.LineTotalServ) * ((Convert.ToDouble(TaxValue) / 100) * 1.1);

                        se.IdService = item.IdService;
                        se.TypeServices = item.TypeServices;
                        se.DescriptionServ = item.DescriptionServ;
                        se.HourRate = item.HourRate;
                        se.Hour = item.Hour;
                        se.TaxServ = Convert.ToDecimal(TaxValue);
                        se.LineTotalServ = Convert.ToDecimal(tot);
                        se.NumInvoice = NumInvoice;

                    }
                }
            }

            return Json(new { success = true, oldval = TaxValue },
                JsonRequestBehavior.AllowGet);
        }

        public ActionResult DeleteTaxProd(int id)
        {
            string NumInv = "";
            var NumInvoice = 0;
            var ValueTax = 0.0;

            //Verify Num Invoice
            var dados = (from i in db.TypeTaxProd
                         where i.IdTypeTaxProd == id
                         select new
                         {
                             i.NumInvoice

                         }).ToList();

            if (db != null)
            {
                foreach (var item in dados)
                {
                    NumInv = item.NumInvoice.ToString();
                    NumInvoice = Convert.ToInt32(item.NumInvoice);
                }
            }

            //Remove Tax
            TypeTaxProd TypeTax = db.TypeTaxProd.Find(id);
            db.TypeTaxProd.Remove(TypeTax);
            db.SaveChanges();

            //Verifi Tax Product
            var dadot = (from i in db.TypeTaxProd
                         where i.NumInvoice == NumInvoice
                         select new
                         {
                             i.NumInvoice,
                             i.TaxProd

                         }).ToList();

            if (db != null)
            {
                foreach (var item in dadot)
                {
                    ValueTax += Convert.ToDouble(item.TaxProd);
                }
            }


            //Atualiza Valores, primeiro atualizar os produtos e depois atualizar invloice
            
            var Total = 0.0;
            var SubTot = 0.0;
            var TotTax = 0.0;

            var TotalLine = 0.0;
            var TotProd = 0.0;
            var TotTaxP = 0.0;

            //recalcula e salva novas taxas na linha do produto
            var dadospo = (from t in db.Product
                           where t.NumInvoice == NumInvoice
                           select new
                           {
                               t.IdProduct,
                               t.TypeProducts,
                               t.DescriptionProd,
                               t.UnitCost,
                               t.Amount,
                               t.TotalProd,
                               t.TaxProd,
                               t.LineTotalProd
                               
                           }).ToList();

            if (db != null)
            {
                foreach (var item in dadospo)
                {
                    //Recalcula Linha do Produto
                    TotalLine = Convert.ToDouble(item.LineTotalProd);
                    TotProd = Convert.ToDouble(item.TotalProd);
                    TotTaxP = TotProd * (ValueTax / 100);

                    TotalLine = TotProd + TotTaxP;

                    po.IdProduct = item.IdProduct;
                    po.TypeProducts = item.TypeProducts;
                    po.DescriptionProd = item.DescriptionProd;
                    po.UnitCost = item.UnitCost;
                    po.Amount = item.Amount;
                    po.TotalProd = Convert.ToDecimal(TotProd);
                    po.TaxProd = Convert.ToDecimal(TotTaxP);
                    po.LineTotalProd = Convert.ToDecimal(TotalLine);
                    po.NumInvoice = Convert.ToInt32(NumInvoice);

                    db.Product.AddOrUpdate(po);
                    db.SaveChanges();
                }
            }

            //Pega os valores dos produtos e totaliza dados para a invoice
            var dadostp = (from t in db.Product
                           where t.NumInvoice == NumInvoice
                           select new
                           {
                               t.LineTotalProd,
                               t.TotalProd,
                               t.TaxProd

                           }).ToList();

            if (db != null)
            {
                foreach (var item in dadostp)
                {

                    //Recalcula Linha do Produto
                    Total += Convert.ToDouble(item.LineTotalProd);
                    SubTot += Convert.ToDouble(item.TotalProd);
                    TotTax += Convert.ToDouble(item.TaxProd);
                }
            }

            //Pega os valores dos serviços e totaliza dados para a invoice
            var dadosts = (from t in db.Service
                           where t.NumInvoice == NumInvoice
                           select new
                           {
                               t.LineTotalServ,
                               t.TotalServ,
                               t.TaxServ

                           }).ToList();

            if (db != null)
            {
                foreach (var item in dadosts)
                {

                    //Recalcula Linha do Produto
                    Total += Convert.ToDouble(item.LineTotalServ);
                    SubTot += Convert.ToDouble(item.TotalServ);
                    TotTax += Convert.ToDouble(item.TaxServ);
                }
            }


            //Retorna a invoice e insere os novos valores
            var dadosinv = (from tx in db.Invoice
                            where tx.NumInvoice == NumInvoice
                            select new
                            {
                                tx.NumInvoice,
                                tx.SubTotal,
                                tx.Total,
                                tx.Tax,
                                tx.IssueDate,
                                tx.DueDate,
                                tx.IdIssuer,
                                tx.IdClient,
                                tx.IdStatusInv,
                                tx.Note
                            }).ToList();

            if (db != null)
            {
                foreach (var item in dadosinv)
                {
                    inv.NumInvoice = item.NumInvoice;
                    inv.SubTotal = Convert.ToDecimal(SubTot);
                    inv.Total = Convert.ToDecimal(Total);
                    inv.Tax = Convert.ToDecimal(TotTax);
                    inv.IssueDate = item.IssueDate;
                    inv.DueDate = item.DueDate;
                    inv.IdIssuer = item.IdIssuer;
                    inv.IdClient = item.IdClient;
                    inv.IdStatusInv = item.IdStatusInv;
                    inv.Note = item.Note;

                    db.Invoice.AddOrUpdate(inv);
                    db.SaveChanges();
                }
            }

            return RedirectToAction("Edit/" + NumInv);
        }

        public ActionResult DeleteTaxServ(int id)
        {
            string NumInv = "";
            var NumInvoice = 0;
            var ValueTax = 0.0;

            var dados = (from i in db.TypeTaxServ
                         where i.IdTypeTaxServ == id
                         select new
                         {
                             i.NumInvoice

                         }).ToList();

            if (db != null)
            {
                foreach (var item in dados)
                {
                    NumInv = item.NumInvoice.ToString();
                    NumInvoice = Convert.ToInt32(item.NumInvoice);
                }
            }

            TypeTaxServ TypeTax = db.TypeTaxServ.Find(id);
            db.TypeTaxServ.Remove(TypeTax);
            db.SaveChanges();

            //Verifi Tax Serviço
            var dadot = (from i in db.TypeTaxServ
                         where i.NumInvoice == NumInvoice
                         select new
                         {
                             i.NumInvoice,
                             i.TaxServ

                         }).ToList();

            if (db != null)
            {
                foreach (var item in dadot)
                {
                    ValueTax += Convert.ToDouble(item.TaxServ);
                }
            }


            //Atualiza Valores, primeiro atualizar os serviços e depois atualizar invloice
           
            var Total = 0.0;
            var SubTot = 0.0;
            var TotTax = 0.0;

            var TotalLine = 0.0;
            var TotProd = 0.0;
            var TotTaxP = 0.0;

            //recalcula e salva novas taxas na linha do serviços
            var dadospo = (from t in db.Service
                           where t.NumInvoice == NumInvoice
                           select new
                           {
                               t.IdService,
                               t.TypeServices,
                               t.DescriptionServ,
                               t.HourRate,
                               t.Hour,
                               t.TotalServ,
                               t.TaxServ,
                               t.LineTotalServ

                           }).ToList();

            if (db != null)
            {
                foreach (var item in dadospo)
                {
                    //Recalcula Linha do serviços
                    TotalLine = Convert.ToDouble(item.LineTotalServ);
                    TotProd = Convert.ToDouble(item.TotalServ);
                    TotTaxP = TotProd * (ValueTax / 100);

                    TotalLine = TotProd + TotTaxP;

                    se.IdService = item.IdService;
                    se.TypeServices = item.TypeServices;
                    se.DescriptionServ = item.DescriptionServ;
                    se.HourRate = item.HourRate;
                    se.Hour = item.Hour;
                    se.TotalServ = Convert.ToDecimal(TotProd);
                    se.TaxServ = Convert.ToDecimal(TotTaxP);
                    se.LineTotalServ = Convert.ToDecimal(TotalLine);
                    se.NumInvoice = Convert.ToInt32(NumInvoice);

                    db.Service.AddOrUpdate(se);
                    db.SaveChanges();
                }
            }

            //Pega os valores dos serviços e totaliza dados para a invoice
            var dadosts = (from t in db.Service
                           where t.NumInvoice == NumInvoice
                           select new
                           {
                               t.LineTotalServ,
                               t.TotalServ,
                               t.TaxServ

                           }).ToList();

            if (db != null)
            {
                foreach (var item in dadosts)
                {

                    //Recalcula Linha do Produto
                    Total += Convert.ToDouble(item.LineTotalServ);
                    SubTot += Convert.ToDouble(item.TotalServ);
                    TotTax += Convert.ToDouble(item.TaxServ);
                }
            }

            //Pega os valores dos produtos e totaliza dados para a invoice
            var dadostp = (from t in db.Product
                           where t.NumInvoice == NumInvoice
                           select new
                           {
                               t.LineTotalProd,
                               t.TotalProd,
                               t.TaxProd

                           }).ToList();

            if (db != null)
            {
                foreach (var item in dadostp)
                {

                    //Recalcula Linha do Produto
                    Total += Convert.ToDouble(item.LineTotalProd);
                    SubTot += Convert.ToDouble(item.TotalProd);
                    TotTax += Convert.ToDouble(item.TaxProd);
                }
            }

            //Retorna a invoice e insere os novos valores
            var dadosinv = (from tx in db.Invoice
                            where tx.NumInvoice == NumInvoice
                            select new
                            {
                                tx.NumInvoice,
                                tx.SubTotal,
                                tx.Total,
                                tx.Tax,
                                tx.IssueDate,
                                tx.DueDate,
                                tx.IdIssuer,
                                tx.IdClient,
                                tx.IdStatusInv,
                                tx.Note
                            }).ToList();

            if (db != null)
            {
                foreach (var item in dadosinv)
                {
                    inv.NumInvoice = item.NumInvoice;
                    inv.SubTotal = Convert.ToDecimal(SubTot);
                    inv.Total = Convert.ToDecimal(Total);
                    inv.Tax = Convert.ToDecimal(TotTax);
                    inv.IssueDate = item.IssueDate;
                    inv.DueDate = item.DueDate;
                    inv.IdIssuer = item.IdIssuer;
                    inv.IdClient = item.IdClient;
                    inv.IdStatusInv = item.IdStatusInv;
                    inv.Note = item.Note;

                    db.Invoice.AddOrUpdate(inv);
                    db.SaveChanges();
                }
            }

            return RedirectToAction("Edit/" + NumInv);
        }

        public ActionResult DeleteService(int id)
        {
            string NumInv = "";

            var dados = (from i in db.Invoice
                         join s in db.Service on i.NumInvoice equals s.NumInvoice
                         where s.IdService == id
                         select new
                         {
                             i.NumInvoice

                         }).ToList();

            if (db != null)
            {
                foreach (var item in dados)
                {
                    NumInv = item.NumInvoice.ToString();
                }
            }


            Service Service = db.Service.Find(id);
            db.Service.Remove(Service);
            db.SaveChanges();

            #region Somando as linhas e trazendo o SubTotal, Tax e Total
            //Somando as linhas e trazendo o SubTotal, Tax e Total
            decimal LineTServ = 0;
            decimal TaxS = 0;
            decimal LineTProd = 0;
            decimal TaxP = 0;
            decimal SubTotal = 0;
            decimal Total = 0;
            decimal Tax = 0;
            var NumInvoice = Convert.ToInt32(NumInv);

            var dser = (from s in db.Service
                        where s.NumInvoice == NumInvoice
                        select new
                        {
                            s.TaxServ,
                            s.LineTotalServ
                        }).ToList();

            if (db != null)
            {
                foreach (var item in dser)
                {
                    TaxS = TaxS + Convert.ToDecimal(item.TaxServ);
                    LineTServ = LineTServ + Convert.ToDecimal(item.LineTotalServ);
                }
            }

            var dpro = (from p in db.Product
                        where p.NumInvoice == NumInvoice
                        select new
                        {
                            p.TaxProd,
                            p.LineTotalProd
                        }).ToList();

            if (db != null)
            {
                foreach (var item in dpro)
                {
                    TaxP = TaxP + Convert.ToDecimal(item.TaxProd);
                    LineTProd = LineTProd + Convert.ToDecimal(item.LineTotalProd);
                }
            }

            //trazendo valor total e subtotal da invoice e seus dados
            DateTime dtIssue = Convert.ToDateTime(null);
            DateTime dtDue = Convert.ToDateTime(null);
            int IdIssuer = 0;
            int IdCli = 0;
            int IdSta = 0;
            string Notes = "";


            var Inv = (from i in db.Invoice
                       where i.NumInvoice == NumInvoice
                       select new
                       {
                           i.SubTotal,
                           i.Total,
                           i.IssueDate,
                           i.DueDate,
                           i.IdIssuer,
                           i.IdClient,
                           i.IdStatusInv,
                           i.Note
                       }).ToList();

            if (db != null)
            {
                foreach (var item in Inv)
                {
                    //SubTot = Convert.ToDecimal(item.SubTotal);
                    //Tot = Convert.ToDecimal(item.Total);
                    dtIssue = Convert.ToDateTime(item.IssueDate);
                    dtDue = Convert.ToDateTime(item.DueDate);
                    IdCli = Convert.ToInt32(item.IdClient);
                    IdSta = Convert.ToInt32(item.IdStatusInv);
                    IdIssuer = Convert.ToInt32(item.IdIssuer);
                    Notes = item.Note;
                }
            }

            Tax = (TaxS + TaxP);
            Total = (LineTProd + LineTServ);
            SubTotal = Total - Tax;


            inv.NumInvoice = Convert.ToInt32(NumInv);
            inv.Total = Total;
            inv.SubTotal = SubTotal;
            inv.Tax = Tax;
            inv.IssueDate = dtIssue;
            inv.DueDate = dtDue;
            inv.IdIssuer = Convert.ToInt32(IdIssuer);
            inv.IdClient = IdCli;
            inv.IdStatusInv = IdSta;
            inv.Note = Notes;

            db.Invoice.AddOrUpdate(inv);
            db.SaveChanges();
            #endregion


            return RedirectToAction("Edit/" + NumInv);
        }

        public ActionResult DeleteProduct(int id)
        {
            string NumInv = "";

            var dados = (from i in db.Invoice
                         join s in db.Product on i.NumInvoice equals s.NumInvoice
                         where s.IdProduct == id
                         select new
                         {
                             i.NumInvoice

                         }).ToList();

            if (db != null)
            {
                foreach (var item in dados)
                {
                    NumInv = item.NumInvoice.ToString();
                }
            }

            Product Product = db.Product.Find(id);
            db.Product.Remove(Product);
            db.SaveChanges();

            #region Somando as linhas e trazendo o SubTotal, Tax e Total
            //Somando as linhas e trazendo o SubTotal, Tax e Total
            decimal LineTServ = 0;
            decimal TaxS = 0;
            decimal LineTProd = 0;
            decimal TaxP = 0;
            decimal SubTotal = 0;
            decimal Total = 0;
            decimal Tax = 0;
            var NumInvoice = Convert.ToInt32(NumInv);

            var dser = (from s in db.Service
                        where s.NumInvoice == NumInvoice
                        select new
                        {
                            s.TaxServ,
                            s.LineTotalServ
                        }).ToList();

            if (db != null)
            {
                foreach (var item in dser)
                {
                    TaxS = TaxS + Convert.ToDecimal(item.TaxServ);
                    LineTServ = LineTServ + Convert.ToDecimal(item.LineTotalServ);
                }
            }

            var dpro = (from p in db.Product
                        where p.NumInvoice == NumInvoice
                        select new
                        {
                            p.TaxProd,
                            p.LineTotalProd
                        }).ToList();

            if (db != null)
            {
                foreach (var item in dpro)
                {
                    TaxP = TaxP + Convert.ToDecimal(item.TaxProd);
                    LineTProd = LineTProd + Convert.ToDecimal(item.LineTotalProd);
                }
            }

            //trazendo valor total e subtotal da invoice e seus dados
            DateTime dtIssue = Convert.ToDateTime(null);
            DateTime dtDue = Convert.ToDateTime(null);
            int IdIssuer = 0;
            int IdCli = 0;
            int IdSta = 0;
            string Notes = "";


            var Inv = (from i in db.Invoice
                       where i.NumInvoice == NumInvoice
                       select new
                       {
                           i.SubTotal,
                           i.Total,
                           i.IssueDate,
                           i.DueDate,
                           i.IdIssuer,
                           i.IdClient,
                           i.IdStatusInv,
                           i.Note
                       }).ToList();

            if (db != null)
            {
                foreach (var item in Inv)
                {
                    //SubTot = Convert.ToDecimal(item.SubTotal);
                    //Tot = Convert.ToDecimal(item.Total);
                    dtIssue = Convert.ToDateTime(item.IssueDate);
                    dtDue = Convert.ToDateTime(item.DueDate);
                    IdCli = Convert.ToInt32(item.IdClient);
                    IdSta = Convert.ToInt32(item.IdStatusInv);
                    IdIssuer = Convert.ToInt32(item.IdIssuer);
                    Notes = item.Note;
                }
            }

            Tax = (TaxS + TaxP);
            Total = (LineTProd + LineTServ);
            SubTotal = Total - Tax;


            inv.NumInvoice = Convert.ToInt32(NumInv);
            inv.Total = Total;
            inv.SubTotal = SubTotal;
            inv.Tax = Tax;
            inv.IssueDate = dtIssue;
            inv.DueDate = dtDue;
            inv.IdIssuer = Convert.ToInt32(IdIssuer);
            inv.IdClient = IdCli;
            inv.IdStatusInv = IdSta;
            inv.Note = Notes;

            db.Invoice.AddOrUpdate(inv);
            db.SaveChanges();
            #endregion

            return RedirectToAction("Edit/" + NumInv);
        }



        // GET: Invoice/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Invoice invoice = db.Invoice.Find(id);
            if (invoice == null)
            {
                return HttpNotFound();
            }
            return View(invoice);
        }

        // GET: Invoice/Create
        public ActionResult Create()
        {
            ViewBag.IdClient = new SelectList(db.Client, "IdClient", "NameClient");
            ViewBag.IdIssuer = new SelectList(db.Issuer, "IdIssuer", "NameIssuer");
            ViewBag.IdStatusInv = new SelectList(db.StatusInvoice, "IdStatusInv", "DescStatusInv");
            return View();
        }

        // POST: Invoice/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NumInvoice,SubTotal,Total,Tax,IssueDate,DueDate,IdIssuer,IdClient,IdStatusInv,Note")] Invoice invoice)
        {
            if (ModelState.IsValid)
            {
                db.Invoice.Add(invoice);
                db.SaveChanges();
                var IdInv = invoice.NumInvoice;
                return RedirectToAction("Edit/" + IdInv.ToString());
            }

            ViewBag.IdClient = new SelectList(db.Client, "IdClient", "NameClient", invoice.IdClient);
            ViewBag.IdIssuer = new SelectList(db.Issuer, "IdIssuer", "NameIssuer", invoice.IdIssuer);
            ViewBag.IdStatusInv = new SelectList(db.StatusInvoice, "IdStatusInv", "DescStatusInv");
            return View(invoice);
        }

        // GET: Invoice/Edit/5
        
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Invoice invoice = db.Invoice.Find(id);
            if (invoice == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdClient = new SelectList(db.Client, "IdClient", "NameClient", invoice.IdClient);
            ViewBag.IdIssuer = new SelectList(db.Issuer, "IdIssuer", "NameIssuer", invoice.IdIssuer);
            ViewBag.IdStatusInv = new SelectList(db.StatusInvoice, "IdStatusInv", "DescStatusInv");
            return View(invoice);
        }

        // POST: Invoice/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NumInvoice,SubTotal,Total,Tax,IssueDate,DueDate,IdIssuer,IdClient,IdStatusInv,Note")] Invoice invoice)
        {
            if (ModelState.IsValid)
            {
                db.Entry(invoice).State = EntityState.Modified;
                db.SaveChanges();
                var IdInv = invoice.NumInvoice;
                return RedirectToAction("Edit/" + IdInv.ToString());
            }
            ViewBag.IdClient = new SelectList(db.Client, "IdClient", "NameClient", invoice.IdClient);
            ViewBag.IdIssuer = new SelectList(db.Issuer, "IdIssuer", "NameIssuer", invoice.IdIssuer);
            ViewBag.IdStatusInv = new SelectList(db.StatusInvoice, "IdStatusInv", "DescStatusInv");
            return View(invoice);
        }

        // GET: Invoice/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Invoice invoice = db.Invoice.Find(id);
            if (invoice == null)
            {
                return HttpNotFound();
            }
            return View(invoice);
        }

        

        // POST: Invoice/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Invoice invoice = db.Invoice.Find(id);
            db.Invoice.Remove(invoice);
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

