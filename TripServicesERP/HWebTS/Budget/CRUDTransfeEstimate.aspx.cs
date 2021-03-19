using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HWebTS.Models;
using System.Data;
using System.Data.Entity;
//Auto complete
using System.Web.Services;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Entity.Migrations;


namespace HWebTS.Budget
{
    public partial class CRUDTransfeEstimate : System.Web.UI.Page
    {
        #region Variables
            int identify = 0;
            string Id = "0";
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (isMobileBrowser())
                {
                    divGridModalDestination.Attributes.Add("class", "table-responsive");
                    divGridModalTypeDestination.Attributes.Add("class", "table-responsive");
                    divGridModalPassenger.Attributes.Add("class", "table-responsive");
                }

                if (!String.IsNullOrEmpty(Request.QueryString["IdTransEst"]))
                {
                    Id = Request.QueryString["IdTransEst"];
                }
                else
                {
                    Response.Redirect("~/Account/Login");
                }

                if (Id == "0")
                {
                    ClearTransferEstimate(Id);
                }
                else
                {
                    LoadTranferInfo(Id);
                }
                
                txtNamePassenger.Focus();
            }
            else
            {
                if (!String.IsNullOrEmpty(Request.QueryString["IdTransEst"]))
                {
                    Id = Request.QueryString["IdTransEst"];
                }
                else
                {
                    Response.Redirect("~/Account/Login");
                }
            }
        }

        #region Metodos
        public static bool isMobileBrowser()
        {
            //GETS THE CURRENT USER CONTEXT
            HttpContext context = HttpContext.Current;
            //FIRST TRY BUILT IN ASP.NT CHECK
            if (context.Request.Browser.IsMobileDevice)
            {
                return true;
            }
            //THEN TRY CHECKING FOR THE HTTP_X_WAP_PROFILE HEADER
            if (context.Request.ServerVariables["HTTP_X_WAP_PROFILE"] != null)
            {
                return true;
            }
            //THEN TRY CHECKING THAT HTTP_ACCEPT EXISTS AND CONTAINS WAP
            if (context.Request.ServerVariables["HTTP_ACCEPT"] != null &&
                context.Request.ServerVariables["HTTP_ACCEPT"].ToLower().Contains("wap"))
            {
                return true;
            }
            //AND FINALLY CHECK THE HTTP_USER_AGENT 
            //HEADER VARIABLE FOR ANY ONE OF THE FOLLOWING
            if (context.Request.ServerVariables["HTTP_USER_AGENT"] != null)
            {
                //Create a list of all mobile types
                string[] mobiles =
                    new[]
                        {
                    "midp", "j2me", "avant", "docomo",
                    "novarra", "palmos", "palmsource",
                    "240x320", "opwv", "chtml",
                    "pda", "windows ce", "mmp/",
                    "blackberry", "mib/", "symbian",
                    "wireless", "nokia", "hand", "mobi",
                    "phone", "cdm", "up.b", "audio",
                    "SIE-", "SEC-", "samsung", "HTC",
                    "mot-", "mitsu", "sagem", "sony"
                    , "alcatel", "lg", "eric", "vx",
                    "NEC", "philips", "mmm", "xx",
                    "panasonic", "sharp", "wap", "sch",
                    "rover", "pocket", "benq", "java",
                    "pt", "pg", "vox", "amoi",
                    "bird", "compal", "kg", "voda",
                    "sany", "kdd", "dbt", "sendo",
                    "sgh", "gradi", "jb", "dddi",
                    "moto", "iphone"
                        };

                //Loop through each item in the list created above 
                //and check if the header contains that text
                foreach (string s in mobiles)
                {
                    if (context.Request.ServerVariables["HTTP_USER_AGENT"].
                                                        ToLower().Contains(s.ToLower()))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        protected void LoadPriciesCity(DropDownList City, string IdCity)
        {
            City.Items.Clear();
            atripservicesEntities DBTrip = new atripservicesEntities();

            var dados = (from p in DBTrip.PriceCities
                         orderby p.City
                         select p).ToList<PriceCities>();

            if (DBTrip != null)
            {
                foreach (var item in dados)
                {
                    City.Items.Add(new ListItem(item.City, item.IdCity.ToString()));
                }
            }

            if (IdCity != "0")
            {
                City.SelectedValue = IdCity;
            }
            
        }

        protected void ClearTransferEstimate(string Id)
        { 
            LoadPriciesCity(ddlCityTo, Id);
            LoadPriciesCity(ddlCityFrom, Id);
            LoadTypetransfer(ddlTypeTransfer, Id);
            //No change this order ---------------
            LoadTypeDestination(ddlTypeDestination, Id);
            LoadDestination(ddlTypeDestination.SelectedValue.ToString(),"0");
            LoadSale(ddlSalesContact, ddlDestination.SelectedValue, "0");
            //No change this order ---------------
            LoadMetingPoint(ddlMetingPoint, Id);
            LoadStatusPayment(ddlStatusPayment, Id);
            LoadTypePayment(ddlTypePayment, Id);
            LoadPayApprove(ddlAprove, Id);
            LoadTypeVisa(ddlTypeVisa, Id);
            LoadGridPassenger("");
            LoadGridTypeDestination("");
            LoadGridDestination("", ddlTypeDestination.SelectedValue);

            //Clear Transfer Estimate
            hdfIdPassenger.Value = "0";
            txtNamePassenger.Text = "";
            txtfone.Text = "";
            txtPhone2.Text = "";
            txtEmail.Text = "";
            txtTypeVisa.Text = "";
            txtDateEstimate.Text = "";
            txtTime.Text = "";
            txtFlightNumber.Text = "";
            txtDateVoo.Text = "";
            txtTimeVoo.Text = "";
            txtDateAprove.Text = "";
            txtDiscount.Text = "";
            lblTransferAmount.Text = "";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="IdTypeDestination"></param>
        /// <param name="IdDestination"></param>
        protected void LoadDestination(string IdTypeDestination, string IdDestination)
        {
            ddlDestination.Items.Clear();
            var idty = Convert.ToInt32(IdTypeDestination);
            var idd = Convert.ToInt32(IdDestination);
            atripservicesEntities DBTrip = new atripservicesEntities();


            if (IdDestination != "1")
            {
                var dados = (from p in DBTrip.Destination
                             where p.IdTypeDestination == idty
                             orderby p.Name
                             select p).ToList<Destination>();

                if (DBTrip != null)
                {
                    if (dados.Count > 0)
                    {
                        foreach (var item in dados)
                        {
                            ddlDestination.Items.Add(new ListItem(item.Name, item.IdDestination.ToString()));
                        }
                    }
                    else
                    {
                        ddlDestination.Items.Add(new ListItem("No destination!", ""));
                    }

                }
            }
            else
            {
                var dados = (from p in DBTrip.Destination
                             where p.IdDestination == idd
                             orderby p.Name
                             select p).ToList<Destination>();

                if (DBTrip != null)
                {
                    if (dados.Count > 0)
                    {
                        foreach (var item in dados)
                        {
                            ddlDestination.Items.Add(new ListItem(item.Name, item.IdDestination.ToString()));
                        }
                    }
                    else
                    {
                        ddlDestination.Items.Add(new ListItem("No destination!", ""));
                    }

                }
            }

            if (IdDestination != "0" && !String.IsNullOrEmpty(IdDestination))
            {
                ddlDestination.SelectedValue = IdDestination;
            }

            //ddlDestination.DataBind();
            upMainDestination.Update();

            if (ddlDestination.SelectedItem.ToString() == "Request Reservation")
            {
                divDestination.Attributes["class"] = "form-group has-error";
            }
            else
            { divDestination.Attributes["class"] = ""; }
        }
        protected int IdCityByName(string NameCity)
        {
            int Idci = 0;

            atripservicesEntities DBTrip = new atripservicesEntities();

            var dados = (from p in DBTrip.PriceCities
                         where p.City.StartsWith(NameCity)
                         select p).ToList<PriceCities>();

            if (DBTrip != null)
            {
                foreach (var item in dados)
                {
                    Idci = item.IdCity;
                }
            }

            return Idci;
        }
        protected void LoadCity(DropDownList City, string IdCity)
        {
            City.Items.Clear();
            atripservicesEntities DBTrip = new atripservicesEntities();

            var dados = (from p in DBTrip.PriceCities
                         orderby p.City
                         select p).ToList<PriceCities>();

            if (DBTrip != null)
            {
                foreach (var item in dados)
                {
                    City.Items.Add(new ListItem(item.City, item.IdCity.ToString()));
                }
            }

            if (IdCity != "0")
                City.SelectedValue = IdCity;
        }
        protected bool SaveDestination(string DestinationName, string Address, string City, string SalesContact, string TypeDestination, 
            string Mobile, string Phone, string Postalcode)
        {
            bool ret = false;
            var ids = Convert.ToInt32(SalesContact);
            var idc = Convert.ToInt32(City);
            var idtd = Convert.ToInt32(TypeDestination);

            atripservicesEntities DBTrip = new atripservicesEntities();
            Destination dt = new Destination();

            var dest = (from p in DBTrip.Destination
                         where p.Name == DestinationName && p.Address == Address
                                && p.IdCity==idc && p.IdSalesContact ==ids && p.IdTypeDestination == idtd
                                && p.Mobile == Mobile && p.Phone == Phone && p.PostalCode == Postalcode 
                         select p).ToList<Destination>();

            if (dest.Count == 0)
            {
                dt.Address = txtAddressDestination.Text;
                dt.IdCity = Convert.ToInt32(ddlIdCityDestModal.SelectedValue);
                dt.IdSalesContact = Convert.ToInt32(ddlIdSalesDestModal.SelectedValue);
                dt.IdTypeDestination = Convert.ToInt32(ddlIdTypeDestModal.SelectedValue);
                dt.Mobile = txtMobileDestination.Text;
                dt.Phone = txtPhoneDestination.Text;
                dt.Name = txtNameDestination.Text;
                dt.PostalCode = txtPostalCodeDestination.Text;

                DBTrip.Destination.Add(dt);
                DBTrip.SaveChanges();
                ret = true;
            }
            else
            {
                ret = false;
            }
            return ret;
        }
        protected bool EditDestination(string DestinationName, string Address, string City, string SalesContact, string TypeDestination,
            string Mobile, string Phone, string Postalcode, string IdDestination)
        {
            bool ret = false;
            var ids = Convert.ToInt32(SalesContact);
            var idc = Convert.ToInt32(City);
            var idtd = Convert.ToInt32(TypeDestination);
            var idd = Convert.ToInt32(IdDestination);

            atripservicesEntities DBTrip = new atripservicesEntities();
            Destination dt = DBTrip.Destination.Find(idd);


            if (dt != null)
            {
                dt.Address = txtAddressDestination.Text;
                dt.IdCity = Convert.ToInt32(ddlIdCityDestModal.SelectedValue);
                dt.IdSalesContact = Convert.ToInt32(ddlIdSalesDestModal.SelectedValue);
                dt.IdTypeDestination = Convert.ToInt32(ddlIdTypeDestModal.SelectedValue);
                dt.Mobile = txtMobileDestination.Text;
                dt.Phone = txtPhoneDestination.Text;
                dt.Name = txtNameDestination.Text;
                dt.PostalCode = txtPostalCodeDestination.Text;

                DBTrip.Entry(dt).State = EntityState.Modified;
                DBTrip.SaveChanges();
                ret = true;
            }
            else
            { ret = false; }

            //var dest = (from p in DBTrip.Destination
            //            where p.IdDestination == idd
            //            select p).ToList<Destination>();

            //if (dest.Count > 0)
            //{
                
                
            //    DBTrip.SaveChanges();
            //    ret = true;
            //}
            //else
            //{
            //    ret = false;
            //}
            return ret;
        }
        protected bool SaveTypeDestination(string IdTypeDestination)
        {
            bool ret = false;
            atripservicesEntities DBTrip = new atripservicesEntities();
            TypeDestination dt = new TypeDestination();

            var typedest = DBTrip.TypeDestination.Where(p => p.DescTypeDestination.Equals(IdTypeDestination)).FirstOrDefault();

            if (typedest == null)
            {
                dt.DescTypeDestination = txtModalTypeDestination.Text;
                DBTrip.TypeDestination.Add(dt);
                DBTrip.SaveChanges();

                DBTrip.SaveChanges();

                ret = true;
            }
            else
            {
                ret = false;
            }

            return ret;
        }
        protected void ClearDestination()
        {
            txtNameDestination.Enabled = true;
            txtPhoneDestination.Enabled = true;
            txtMobileDestination.Enabled = true;
            txtPostalCodeDestination.Enabled = true;
            ddlIdCityDestModal.Enabled = true;
            ddlIdTypeDestModal.Enabled = true;
            txtAddressDestination.Text = "";
            txtNameDestination.Text = "";
            txtPostalCodeDestination.Text = "";
            txtPhoneDestination.Text = "";
            txtMobileDestination.Text = "";
            //LoadTypeDestination(ddlIdTypeDestModal, "0");
            //LoadCity(ddlIdCityDestModal, "0");
            //LoadAllSale(ddlIdSalesDestModal, ddlSalesContact.SelectedValue);
            //LoadSale(ddlIdSalesDestModal, ddlDestination.SelectedValue, "0");
            UpModalDestination.Update();
        }
        protected void ClearTypeDestination()
        {
            txtModalTypeDestination.Text = "";
        }
        
        protected void LoadModalTypeDestination(string IdTypeDestination)
        {
            var idty = Convert.ToInt32(IdTypeDestination);
            atripservicesEntities DBTrip = new atripservicesEntities();
            var dados = (from p in DBTrip.TypeDestination
                         where p.IdTypeDestination == idty
                         select p).ToList<TypeDestination>();

            if (DBTrip != null)
            {
                if (dados.Count > 0)
                {
                    foreach (var item in dados)
                    {
                        hdfIdModalTypeDestination.Value = item.IdTypeDestination.ToString();
                        txtModalTypeDestination.Text = item.DescTypeDestination;
                    }
                }
            }

        }
        protected void LoadModalDestination(string IdDestination)
        {
            var idty = Convert.ToInt32(IdDestination);
            atripservicesEntities DBTrip = new atripservicesEntities();
            var dados = (from p in DBTrip.Destination
                         where p.IdDestination == idty
                         select p).ToList<Destination>();

            if (DBTrip != null)
            {
                if (dados.Count > 0)
                {
                    foreach (var item in dados)
                    {
                        txtAddressDestination.Text = item.Address;
                        txtNameDestination.Text = item.Name;
                        txtPostalCodeDestination.Text = item.PostalCode;
                        txtPhoneDestination.Text = item.Phone;
                        txtMobileDestination.Text = item.Mobile;
                        LoadTypeDestination(ddlIdTypeDestModal, item.IdTypeDestination.ToString());
                        LoadCity(ddlIdCityDestModal, item.IdCity.ToString());
                        LoadSale(ddlIdSalesDestModal, item.IdDestination.ToString(), item.IdSalesContact.ToString());
                    }
                }
            }
        }

        //Load All DropDownList
        /// <summary>
        /// Load Sales Contact Table
        /// </summary>
        /// <param name="Sale">DropListBox</param>
        /// <param name="IdDestination"></param>
        /// <param name="IdSale"></param>
        protected void LoadSale(DropDownList Sale, string IdDestination, string IdSale)
        {
            bool confirm = false;
            Sale.Items.Clear();

            if (!String.IsNullOrEmpty(IdDestination))
            {
                var idsa = Convert.ToInt32(IdDestination);
                atripservicesEntities DBTrip = new atripservicesEntities();

                var dados = (from s in DBTrip.SalesContact
                             join d in DBTrip.Destination on s.IdSalesContact equals d.IdSalesContact
                             where d.IdDestination == idsa
                             orderby s.Contact
                             select new
                             {
                                 d.IdSalesContact,
                                 s.Contact

                             }).ToList();

                //load dropdownlist
                if (DBTrip != null)
                {
                    foreach (var item in dados)
                    {
                        Sale.Items.Add(new ListItem(item.Contact, item.IdSalesContact.ToString()));

                        if (item.IdSalesContact.ToString() == IdSale)
                        { confirm = true; }
                    }
                }
                else
                {
                    Sale.Items.Add(new ListItem("No Sale!", "0"));
                }

                if (confirm)
                {
                    Sale.SelectedValue = IdSale;
                }
            }
            else
            {
                Sale.Items.Add(new ListItem("No Sale!", "0"));
            }

            
        }
        protected void LoadAllSale(DropDownList Sale, string IdSale)
        {
            Sale.Items.Clear();

            atripservicesEntities DBTrip = new atripservicesEntities();

            var dados = (from d in DBTrip.SalesContact
                         orderby d.Contact
                         select new
                         {
                             d.IdSalesContact,
                             d.Contact

                         }).ToList();

            //load dropdownlist
            if (DBTrip != null)
            {
                foreach (var item in dados)
                {
                    Sale.Items.Add(new ListItem(item.Contact, item.IdSalesContact.ToString()));
                }
            }

            if (!String.IsNullOrEmpty(IdSale) && IdSale != "0")
            {
                Sale.SelectedValue = IdSale;
            }
        }
        /// <summary>
        /// Verifica se Des
        /// </summary>
        /// <param name="IdDestination"></param>
        /// <param name="IdSale"></param>
        /// <returns></returns>
        protected bool VerifyDestinationSales(string IdDestination, string IdSale)
        {
            bool verify = true;

            //Verify Sales Contact / Destination
            if (IdSale != "0")
            {
                var ids = Convert.ToInt32(IdSale);
                atripservicesEntities DBTrip = new atripservicesEntities();

                var dados = (from p in DBTrip.Destination
                              where p.IdSalesContact == ids
                              orderby p.Name
                              select p).ToList<Destination>();

                if (DBTrip == null)
                {
                    Library.DisplayAtertSweet(this, "Verify Sales Contact!", "Sale different contact to Destination, select correct Destination", Library.MessageType.Warning);
                }
            }

            return verify;
        }

        protected void LoadTypetransfer(DropDownList TypeTrans, string IdTypeTrans)
        {
            TypeTrans.Items.Clear();

            atripservicesEntities DBTrip = new atripservicesEntities();
            var dados = (from p in DBTrip.TypeTransfer
                         select p).ToList<TypeTransfer>();

            if (DBTrip != null)
            {
                foreach (var item in dados)
                {
                    TypeTrans.Items.Add(new ListItem(item.DescType, item.IdTypeTransfer.ToString()));
                }
            }

            if (IdTypeTrans != "0")
            {
                TypeTrans.SelectedValue = IdTypeTrans;
            }
        }
        protected void LoadgvTest(DropDownList typeDestination, string IdTypeDes)
        {
            typeDestination.Items.Clear();

            atripservicesEntities DBTrip = new atripservicesEntities();
            var dados = (from p in DBTrip.TypeDestination
                         orderby p.DescTypeDestination
                         select p).ToList<TypeDestination>();

            if (DBTrip != null)
            {
                foreach (var item in dados)
                {
                    typeDestination.Items.Add(new ListItem(item.DescTypeDestination, item.IdTypeDestination.ToString()));
                }
            }

            if (IdTypeDes != "0")
            {
                typeDestination.SelectedValue = IdTypeDes;
            }
        }
        protected void LoadTypeDestination(DropDownList typeDestination, string IdTypeDes)
        {
            typeDestination.Items.Clear();

            atripservicesEntities DBTrip = new atripservicesEntities();
            var dados = (from p in DBTrip.TypeDestination
                         orderby p.IdTypeDestination
                         select p).ToList<TypeDestination>();

            if (DBTrip != null)
            {
                foreach (var item in dados)
                {
                    typeDestination.Items.Add(new ListItem(item.DescTypeDestination, item.IdTypeDestination.ToString()));
                }
            }

            if (IdTypeDes != "0")
            {
                typeDestination.SelectedValue = IdTypeDes;
            }
        }

        protected void LoadMetingPoint(DropDownList metingPoint, string IdMetinPoint)
        {
            metingPoint.Items.Clear();

            atripservicesEntities DBTrip = new atripservicesEntities();
            var dados = (from p in DBTrip.MetingPoint
                         select p).ToList<MetingPoint>();

            if (DBTrip != null)
            {
                foreach (var item in dados)
                {
                    metingPoint.Items.Add(new ListItem(item.DescMetingPoint, item.IdMetingPoint.ToString()));
                }
            }

            if (IdMetinPoint != "0")
            {
                metingPoint.SelectedValue = IdMetinPoint;
            }
        }

        protected void LoadTypePayment(DropDownList TypePayment, string IdTypePay)
        {
            TypePayment.Items.Clear();

            atripservicesEntities DBTrip = new atripservicesEntities();
            var dados = (from p in DBTrip.TypePayment
                         select p).ToList<TypePayment>();

            if (DBTrip != null)
            {
                foreach (var item in dados)
                {
                    TypePayment.Items.Add(new ListItem(item.DescTypePayment, item.IdTypePayment.ToString()));
                }
            }

            if (IdTypePay != "0")
            {
                TypePayment.SelectedValue = IdTypePay;
            }
        }

        protected void LoadStatusPayment(DropDownList StatusPay, string IdStatus)
        {
            StatusPay.Items.Clear();

            atripservicesEntities DBTrip = new atripservicesEntities();
            var dados = (from p in DBTrip.StatusPayment
                         select p).ToList<StatusPayment>();

            if (DBTrip != null)
            {
                foreach (var item in dados)
                {
                    StatusPay.Items.Add(new ListItem(item.DescStatusPayment, item.IdStatusPayment.ToString()));
                }
            }

            if (IdStatus != "0")
            {
                StatusPay.SelectedValue = IdStatus;
            }
        }

        protected void LoadPayApprove(DropDownList PayApprove, string IdPayApprove)
        {
            PayApprove.Items.Clear();

            atripservicesEntities DBTrip = new atripservicesEntities();
            var dados = (from p in DBTrip.TransferAprove
                         select p).ToList<TransferAprove>();

            if (DBTrip != null)
            {
                foreach (var item in dados)
                {
                    PayApprove.Items.Add(new ListItem(item.DescAprove, item.IdAprove.ToString()));
                }
            }

            if (IdPayApprove != "0")
            {
                PayApprove.SelectedValue = IdPayApprove;
            }

           switch (PayApprove.SelectedValue)
            {
                case "0":
                    cbIncludeCalendar.Enabled = true;
                    cbIncludeCalendar.Checked = true;
                    UpSalesChannel.Update();
                    break;
                case "2":
                    txtDateAprove.Text = DateTime.Now.ToString("yyyy-MM-dd");
                    cbIncludeCalendar.Enabled = true;
                    cbIncludeCalendar.Checked = true;
                    UpSalesChannel.Update();
                    break;
                case "1":
                    cbIncludeCalendar.Enabled = false;
                    cbIncludeCalendar.Checked = false;
                    UpSalesChannel.Update();
                    break;
            }
        }

        protected void LoadTypeVisa(DropDownList TypeVisa, string IdPayApprove)
        {
            TypeVisa.Items.Clear();

            atripservicesEntities DBTrip = new atripservicesEntities();
            var dados = (from p in DBTrip.TypeVisa
                         select p).ToList<TypeVisa>();

            if (DBTrip != null)
            {
                foreach (var item in dados)
                {
                    TypeVisa.Items.Add(new ListItem(item.DescTypeVisa, item.IdTypeVisa.ToString()));
                }
            }

            if (IdPayApprove != "0")
            {
                TypeVisa.SelectedValue = IdPayApprove;
            }
        }

        protected void LoadGridPassenger(string Name)
        {
            atripservicesEntities entities = new atripservicesEntities();

            if (!String.IsNullOrEmpty(Name))
            {
                var customers = (from p in entities.Passenger
                                 join t in entities.TypeVisa on p.IdTypeVisa equals t.IdTypeVisa
                                 where p.Name.StartsWith(Name)
                                 orderby p.Name
                                 select new
                                 {
                                     p.Name,
                                     p.IdPassenger,
                                     p.Email,
                                     p.Phone,
                                     p.Phone2,
                                     p.IdTypeVisa,
                                     t.DescTypeVisa
                                 }).ToList();


                gvPassenger.DataSource = customers;
                gvPassenger.DataBind();
            }
            else
            {
                var customers = (from p in entities.Passenger
                                 join t in entities.TypeVisa on p.IdTypeVisa equals t.IdTypeVisa
                                 select new
                                 {
                                     p.Name,
                                     p.IdPassenger,
                                     p.Email,
                                     p.Phone,
                                     p.Phone2,
                                     p.IdTypeVisa,
                                     t.DescTypeVisa
                                 }).ToList();


                gvPassenger.DataSource = customers;
                gvPassenger.DataBind();
            }

            
            
        }

        protected void LoadGridDestination(string Contact, string IdTypeDestination)
        {
            atripservicesEntities entities = new atripservicesEntities();

            int IdSCont = Convert.ToInt32(IdTypeDestination);

            if (!String.IsNullOrEmpty(Contact))
            {
                var destination = (from d in entities.Destination
                                   join t in entities.TypeDestination on d.IdTypeDestination equals t.IdTypeDestination
                                   join s in entities.SalesContact on d.IdSalesContact equals s.IdSalesContact
                                   join c in entities.PriceCities on d.IdCity equals c.IdCity
                                   where d.Name.StartsWith(Contact) && d.IdTypeDestination == IdSCont
                                   orderby d.Name
                                       select new
                                       {
                                           d.IdDestination,
                                           d.Name,
                                           d.Address,
                                           c.IdCity,
                                           c.City,
                                           d.PostalCode,
                                           d.Phone,
                                           d.Mobile,
                                           d.IdTypeDestination,
                                           t.DescTypeDestination,
                                           d.IdSalesContact,
                                           s.Contact

                                       }).ToList();


                gvDestination.DataSource = destination;
                gvDestination.DataBind();
            }
            else
            {
                var destination = (from d in entities.Destination
                                   join t in entities.TypeDestination on d.IdTypeDestination equals t.IdTypeDestination
                                   join s in entities.SalesContact on d.IdSalesContact equals s.IdSalesContact
                                   join c in entities.PriceCities on d.IdCity equals c.IdCity
                                   where d.IdTypeDestination == IdSCont
                                   orderby d.Name
                                   select new
                                   {
                                       d.IdDestination,
                                       d.Name,
                                       d.Address,
                                       c.IdCity,
                                       c.City,
                                       d.PostalCode,
                                       d.Phone,
                                       d.Mobile,
                                       d.IdTypeDestination,
                                       t.DescTypeDestination,
                                       d.IdSalesContact,
                                       s.Contact

                                   }).ToList();


                gvDestination.DataSource = destination;
                gvDestination.DataBind();
            }



        }
        protected void LoadGridDestinationReqReservation(string IdTrasferEst)
        {
            atripservicesEntities entities = new atripservicesEntities();

            int IdT = Convert.ToInt32(IdTrasferEst);

            if (IdTrasferEst == "0")
            {
                divGridRequestReservation.Visible = false;
            }
            else
            {
                var destinationreq = (from r in entities.ReservationRequest
                                      join t in entities.TypeDestination on r.IdTypeDestinationPD equals t.IdTypeDestination
                                      join c in entities.PriceCities on r.IdCityPD equals c.IdCity
                                      where r.IdTransferEst == IdT
                                      select new
                                      {
                                          r.IdReservationRequest,
                                          r.NamePD,
                                          r.AddressPD,
                                          r.PostalCodePD,
                                          r.PhonePD,
                                          r.MobilePD,
                                          c.City,
                                          t.DescTypeDestination

                                      }).ToList();

                gvDestinationReqReservation.DataSource = destinationreq;
                gvDestinationReqReservation.DataBind();

                if (destinationreq.Count == 0)
                {
                    divGridRequestReservation.Visible = false;
                }
            }
        }
        protected void LoadGridTypeDestination(string TypeDestination)
        {
            atripservicesEntities entities = new atripservicesEntities();

            if (!String.IsNullOrEmpty(TypeDestination))
            {
                var typedestination = (from p in entities.TypeDestination
                                       where p.DescTypeDestination.StartsWith(TypeDestination)
                                       orderby p.DescTypeDestination
                                       select new
                                       {
                                           p.IdTypeDestination,
                                           p.DescTypeDestination
                                       }).ToList();


                gvTypeDestination1.DataSource = typedestination;
                gvTypeDestination1.DataBind();
            }
            else
            {
                var typedestination = (from p in entities.TypeDestination
                                       orderby p.DescTypeDestination
                                       select new
                                       {
                                           p.IdTypeDestination,
                                           p.DescTypeDestination
                                       }).ToList();


                gvTypeDestination1.DataSource = typedestination;
                gvTypeDestination1.DataBind();
            }
        }
        protected void LoadTranferInfo(string Id)
        {
            atripservicesEntities DBTrip = new atripservicesEntities();

            var idt = Convert.ToInt32(Id);

            var dados = (from p in DBTrip.TransferEstimate
                         join d in DBTrip.Destination on p.IdDestination equals d.IdDestination 
                         where p.IdTransEst == idt
                         select p).ToList<TransferEstimate>();

            if (DBTrip != null)
            {
                foreach (var item in dados)
                {
                    lblTitle.Text = "Transfer Estimate Id: " + item.IdTransEst.ToString();

                    //Passenger
                    hdfIdPassenger.Value = item.IdPassenger.ToString();
                    txtNamePassenger.Text = item.NamePassenger;
                    txtPhone2.Text = item.Phone2;
                    txtfone.Text = item.Phone;
                    txtEmail.Text = item.Email.ToString();
                    txtNote.Text = item.Note;
                    txtTypeVisa.Text = item.TypeVisa;

                    //Destination/Origin
                    LoadPriciesCity(ddlCityTo, item.CityToId.ToString());
                    LoadTypeDestination(ddlTypeDestination, item.IdTypeDestination.ToString());
                    LoadDestination(item.IdTypeDestination.ToString(), item.IdDestination.ToString());

                    //Sales Channel Este tem que carregar primeiro
                    string[] DA = item.DateAprove.ToString().Split(' ');

                    //txtDateAprove.Text = item.DateAprove.ToString().Substring(0, 10);
                    txtDateAprove.Text = DA[0];
                    LoadSale(ddlSalesContact, item.IdDestination.ToString(), item.IdSales.ToString());
                    LoadTypePayment(ddlTypePayment, item.IdTypePayment.ToString());
                    LoadStatusPayment(ddlStatusPayment, item.StatusPayment.ToString());
                    txtDiscount.Text = item.Discount.ToString();
                    lblTransferAmount.Text = item.TransferAmount.ToString(); 
                    txtFinalPrice.Text = item.FinalPrice.ToString();
                    LoadPayApprove(ddlAprove, item.IdAprove.ToString());

                    //Transfer Info
                    LoadTypetransfer(ddlTypeTransfer, item.TypeTransfer.ToString());
                    string[] DE = item.DateTransEst.ToString().Split(' ');
                    txtDateEstimate.Text = DE[0];
                    if (!String.IsNullOrEmpty(item.TimePiDo.ToString())) { txtTime.Text = item.TimePiDo.ToString(); } else { txtTime.Text = ""; }
                    LoadMetingPoint(ddlMetingPoint, item.MetingPoint.ToString());
                    ddlQtyPassenger.SelectedValue = item.QtyPassenger.ToString();
                    ddlQtyLuggage.SelectedValue = item.QtyMalaGr.ToString();
                    ddlQtyCarryon.SelectedValue = item.QtyMalaPq.ToString();
                    LoadPriciesCity(ddlCityFrom, item.CityFromId.ToString());
                    //txtTransferAmount.Text = item.TransferAmount.ToString();

                    //Flight Details
                    txtFlightNumber.Text = item.FlightNumber;
                    string[] DF = item.DateFligh.ToString().Split(' ');
                    txtDateVoo.Text = DF[0];
                    txtTimeVoo.Text = item.TimeFligh.ToString();
                }
            }
        }

        protected void CalculateFinalPrice(string IdCityFrom, string IdCityTo, string qtyPass, string qtyLugagge, string qtyCarryon, string Discount, string IdSale)
        {
            atripservicesEntities ctx = new atripservicesEntities();

            decimal POne = 0;
            decimal PTwo = 0;
            decimal qtypassenger = Convert.ToDecimal(qtyPass);
            decimal qtyMalaGr = Convert.ToDecimal(qtyLugagge);
            decimal qtyMalaPq = Convert.ToDecimal(qtyCarryon);
            decimal MaxMalaGr = 0;
            decimal MaxMalaPq = 0;
            decimal TotalMala = 0;
            decimal TotalPass = 0;
            decimal TotDiscount = 0;
            decimal DescSalesChannel = 0;
            decimal TranferAmount = 0;
            decimal FinalPrice = 0;
            string IdCity = "";
            int id = 0;
            //bool SalesChannel = false;

            if (String.IsNullOrEmpty(IdCityFrom) || String.IsNullOrEmpty(IdCityTo))
            {
                Library.DisplayAtertSweet(this, "City is Empty!", "There are no cities for this sales channel!", Library.MessageType.Info);
                return;
            }

            if (IdCityFrom == IdCityTo)
            {
                Library.DisplayAtertSweet(this, "Same destination!", "Select City From / To!", Library.MessageType.Info);
                return;
            }

            //Verifica qual cidade nao e Aeroporto
            id = Convert.ToInt32(IdCityFrom);

            var cf = id;

            var dadoscf = (from p in ctx.PriceCities
                           where p.IdCity == cf
                           select p).ToList<PriceCities>();

            foreach (var temp in dadoscf)
            {
                if (temp.City.ToUpper() != "AIRPORT")
                {
                    IdCity = temp.IdCity.ToString();
                }
            }

            id = Convert.ToInt32(IdCityTo);

            var ct = id;

            var dadosct = (from p in ctx.PriceCities
                           where p.IdCity == ct
                           select p).ToList<PriceCities>();

            foreach (var temp in dadosct)
            {
                if (temp.City.ToUpper() != "AIRPORT")
                {
                    IdCity = temp.IdCity.ToString();
                }
            }

            //Verifica o preco das cidades
            id = Convert.ToInt32(IdCity);

            var idp = id;

            var dadosp = (from p in ctx.PriceCities
                          where p.IdCity == idp
                          select p).ToList<PriceCities>();

            foreach (var temp in dadosp)
            {
                POne = Convert.ToDecimal(temp.PriceOne);
                PTwo = Convert.ToDecimal(temp.Pricetwo);
            }

            //Verifica o desconto para aplicar para o canal de vendas
            id = Convert.ToInt32(IdSale);

            var ids = id;

            var dadoss = (from p in ctx.SalesContact
                          where p.IdSalesContact == ids
                          select p).ToList<SalesContact>();

            foreach (var temp in dadoss)
            {
                DescSalesChannel = Convert.ToDecimal(temp.PercentPay);
            }


            //Calculo Passageiro
            for (int i = 1; i <= qtypassenger; i++)
            {
                if (i == 1)
                {
                    TotalPass = POne - DescSalesChannel;
                }
                else
                {
                    TotalPass = TotalPass + (PTwo - DescSalesChannel);
                }

                TotDiscount = TotDiscount + DescSalesChannel;
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

            TranferAmount = TotalPass + TotalMala;
            lblTransferAmount.Text = TranferAmount.ToString("#0.00");

            if (!String.IsNullOrEmpty(Discount))
            {
                FinalPrice = TranferAmount - Convert.ToDecimal(Discount);
                txtFinalPrice.Text = FinalPrice.ToString("#0.00");
            }
            else
            {
                txtFinalPrice.Text = TranferAmount.ToString("#0.00");
            }

            if (DescSalesChannel != 0)
            {
                Library.DisplayAtertBootstrap(this, "$" + DescSalesChannel.ToString() + " Discount per passenger per sales channel " + ddlSalesContact.SelectedItem, Library.MessageType.Info);
                Library.DisplayAtertBootstrap(this, " Discount per passenger $ " + DescSalesChannel.ToString() + ", Total discount for <b>" + ddlSalesContact.SelectedItem + "</b> is $ "+ TotDiscount.ToString("#0.00"), Library.MessageType.Info);
                lblDemonstrativePrice.Text = "$" + DescSalesChannel.ToString() + " Discount per passenger per sales channel " + ddlSalesContact.SelectedItem;
            }
            
        }
        protected void CalculateEstimate(string IdCityFrom, string IdCityTo, string qtyPass, string qtyLugagge, string qtyCarryon, string Discount)
        {
            atripservicesEntities ctx = new atripservicesEntities();

            decimal POne = 0;
            decimal PTwo = 0;
            decimal qtypassenger = Convert.ToDecimal(qtyPass);
            decimal qtyMalaGr = Convert.ToDecimal(qtyLugagge);
            decimal qtyMalaPq = Convert.ToDecimal(qtyCarryon);
            decimal MaxMalaGr = 0;
            decimal MaxMalaPq = 0;
            decimal TotalMala = 0;
            decimal TotalPass = 0;
            decimal TranferAmount = 0;
            string IdCity = "";
            int id = 0;

            if (IdCityFrom == IdCityTo)
            {
                //lblInfoEstimate.Text = "Same destination! Select City From / To!";
                //lblTransferAmount.Text = "";
                Library.DisplayAtertSweet(this, "Same Destination!", "Same Destination! Select City From / To!", Library.MessageType.Warning);
                return;
            }

            //Verifica qual cidade nao e Aeroporto
            id = Convert.ToInt32(IdCityFrom);

            var cf = id;

            var dadoscf = (from p in ctx.PriceCities
                         where p.IdCity == cf
                         select p).ToList<PriceCities>();

            foreach (var temp in dadoscf)
            {
                if (temp.City.ToUpper() != "AIRPORT")
                {
                    IdCity = temp.IdCity.ToString();
                }
            }

            id = Convert.ToInt32(IdCityTo);

            var ct = id;

            var dadosct = (from p in ctx.PriceCities
                         where p.IdCity == ct
                         select p).ToList<PriceCities>();

            foreach (var temp in dadosct)
            {
                if (temp.City.ToUpper() != "AIRPORT")
                {
                    IdCity = temp.IdCity.ToString();
                }
            }

            //Verifica o preco das cidades
            id = Convert.ToInt32(IdCity);

            var idp = id;

            var dadosp = (from p in ctx.PriceCities
                         where p.IdCity == idp
                         select p).ToList<PriceCities>();

            foreach (var temp in dadosp)
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

            TranferAmount = TotalPass + TotalMala;
            lblTransferAmount.Text = TranferAmount.ToString("#0.00");

        }

        protected string ColorSalesContact(int IdSalesContact)
        {
            string cor = "gray";

            atripservicesEntities DBTrip = new atripservicesEntities();

            var dados = (from tx in DBTrip.SalesContact
                         where tx.IdSalesContact == IdSalesContact
                         select new
                         {
                             tx.ThemeColor

                         }).ToList();

            if (DBTrip != null)
            {
                foreach (var item in dados)
                {
                    cor = item.ThemeColor;
                }
            }

            return cor;
        }

        protected void SaveTransferCalendar(int IdTranfer)
        {
            atripservicesEntities DBTrip = new atripservicesEntities();
            Event ev = new Event();
            int idEve = 0;
            string colordefault = "darkslateblue";

            //1 - Remove this item from calendar (Aprove Transfer No = 1), 2 - Update or include item in calendar (Aprove Transfer Yes = 2) , 0 - Transfer in stand By (Open = 0)
            switch (ddlAprove.SelectedValue)
            {
                case "0":
                    if (IdTranfer == 0 && cbIncludeCalendar.Checked)
                    {
                        ev.Subject = "Stand by " + ddlTypeTransfer.SelectedItem + " - " + txtNamePassenger.Text + " - #" + IdTranfer.ToString();
                        ev.Description = " <b>Type Transfer: </b>" + ddlTypeTransfer.SelectedItem + "</br><b>Client: </b> " + txtNamePassenger.Text + "</br><b>Flight Number: </b> " + txtFlightNumber.Text + "</br><b>Meeting Point: </b> " + ddlMetingPoint.SelectedItem;
                        ev.IdTransEst = IdTranfer;
                        ev.IsFullDay = false;
                        ev.ThemeColor = colordefault;
                        ev.Start = Convert.ToDateTime(txtDateVoo.Text + " " + txtTime.Text);

                        string[] b = txtTime.Text.Split(':');
                        int min = Convert.ToInt16(b[1]) + 5;
                        string tempo = b[0] + ":" + min;

                        ev.End = Convert.ToDateTime(txtDateVoo.Text + " " + tempo);

                        DBTrip.Events.AddOrUpdate(ev);
                        DBTrip.SaveChanges();
                    }
                    else
                    {
                        var IdTran = Convert.ToInt32(Id);

                        var dado = (from e in DBTrip.Events
                                    where e.IdTransEst == IdTran
                                    select new
                                    {
                                        e.EventID

                                    }).ToList();

                       
                            if (DBTrip != null)
                            {
                                foreach (var item in dado)
                                {
                                    idEve = item.EventID;
                                }
                            }

                            if (idEve != 0) { ev.EventID = idEve; }

                            ev.Subject = ddlTypeTransfer.SelectedItem + " - " + txtNamePassenger.Text + " - #" + Id;
                            ev.Description = " <b>Type Transfer: </b>" + ddlTypeTransfer.SelectedItem + "</br><b>Client: </b> " + txtNamePassenger.Text + "</br><b>Flight Number: </b> " + txtFlightNumber.Text + "</br><b>Meeting Point: </b> " + ddlMetingPoint.SelectedItem;
                            ev.IdTransEst = Convert.ToInt32(Id);
                            ev.IsFullDay = false;
                            ev.ThemeColor = colordefault;
                            ev.Start = Convert.ToDateTime(txtDateVoo.Text + " " + txtTime.Text);

                            string[] b = txtTime.Text.Split(':');
                            int min = Convert.ToInt16(b[1]) + 5;
                            string tempo = b[0] + ":" + min;

                            ev.End = Convert.ToDateTime(txtDateVoo.Text + " " + tempo);

                            //Library.DisplayAtertBootstrap(this, "Transfer Included in Calendar", Library.MessageType.Success);

                            DBTrip.Events.AddOrUpdate(ev);
                            DBTrip.SaveChanges();

                        
                    }
                break;
                case "1":
                    if (IdTranfer != 0)
                    {
                        idEve = 0;
                        var IdTrans = Convert.ToInt32(Id);

                        var dados = (from e in DBTrip.Events
                                     where e.IdTransEst == IdTrans
                                     select new
                                     {
                                         e.EventID

                                     }).ToList();

                        if (DBTrip != null && dados.Count > 0)
                        {
                            foreach (var item in dados)
                            {
                                ev.EventID = item.EventID;
                            }
                        }

                        DBTrip.Events.Remove(ev);
                        DBTrip.SaveChanges();
                    }
                    break;
                case "2":
                    if (IdTranfer == 0)
                    {
                        ev.Subject = ddlTypeTransfer.SelectedItem + " - " + txtNamePassenger.Text + " - #" + IdTranfer.ToString();
                        ev.Description = " <b>Type Transfer: </b>" + ddlTypeTransfer.SelectedItem + "</br><b>Client: </b> " + txtNamePassenger.Text + "</br><b>Flight Number: </b> " + txtFlightNumber.Text + "</br><b>Meeting Point: </b> " + ddlMetingPoint.SelectedItem;
                        ev.IdTransEst = IdTranfer;
                        ev.IsFullDay = false;
                        ev.ThemeColor = ColorSalesContact(Convert.ToInt32(ddlSalesContact.SelectedValue));
                        ev.Start = Convert.ToDateTime(txtDateVoo.Text + " " + txtTime.Text);

                        string[] b = txtTime.Text.Split(':');
                        int min = Convert.ToInt16(b[1]) + 5;
                        string tempo = b[0] + ":" + min;

                        ev.End = Convert.ToDateTime(txtDateVoo.Text + " " + tempo);

                        //Library.DisplayAtertBootstrap(this, "Transfer Incluido no Calendario", Library.MessageType.Success);

                        DBTrip.Events.AddOrUpdate(ev);
                        DBTrip.SaveChanges();
                    }
                    else
                    {
                        var IdTran = Convert.ToInt32(Id);

                        var dado = (from e in DBTrip.Events
                                    where e.IdTransEst == IdTran
                                    select new
                                    {
                                        e.EventID

                                    }).ToList();

                        
                            if (DBTrip != null)
                            {
                                foreach (var item in dado)
                                {
                                    idEve = item.EventID;
                                }
                            }

                            if (idEve != 0) { ev.EventID = idEve; }

                            ev.Subject = ddlTypeTransfer.SelectedItem + " - " + txtNamePassenger.Text + " - #" + Id;
                            ev.Description = " <b>Type Transfer: </b>" + ddlTypeTransfer.SelectedItem + "</br><b>Client: </b> " + txtNamePassenger.Text + "</br><b>Flight Number: </b> " + txtFlightNumber.Text + "</br><b>Meeting Point: </b> " + ddlMetingPoint.SelectedItem;
                            ev.IdTransEst = Convert.ToInt32(Id);
                            ev.IsFullDay = false;
                            ev.ThemeColor = ColorSalesContact(Convert.ToInt32(ddlSalesContact.SelectedValue));
                            ev.Start = Convert.ToDateTime(txtDateVoo.Text + " " + txtTime.Text);

                            string[] b = txtTime.Text.Split(':');
                            int min = Convert.ToInt16(b[1]) + 5;
                            string tempo = b[0] + ":" + min;

                            ev.End = Convert.ToDateTime(txtDateVoo.Text + " " + tempo);

                            //Library.DisplayAtertBootstrap(this, "Transfer Included in Calendar", Library.MessageType.Success);

                            DBTrip.Events.AddOrUpdate(ev);
                            DBTrip.SaveChanges();
                    }
                    break;
            }
        }

        protected void SaveTranferTestimate(string IdTransferEst)
        {
            atripservicesEntities DBTrip = new atripservicesEntities();
            TransferEstimate te = new TransferEstimate();
            Event ev = new Event();

            if (VerifyTypeDestination(ddlDestination.SelectedValue))
            {
                Library.DisplayAtertSweet(this, "Type Destination Not compatible.", "Type Destination Not compatible with destination, please check !.", Library.MessageType.Warning);
                return;
            }

            if (IdTransferEst == "0")
            {
                te.FlightNumber = txtFlightNumber.Text.ToUpper();
                
                if (!String.IsNullOrEmpty(txtDateVoo.Text)) { te.DateFligh = Convert.ToDateTime(txtDateVoo.Text); } else { te.DateFligh = null; }
                if (!String.IsNullOrEmpty(txtTimeVoo.Text)) { te.TimeFligh = txtTimeVoo.Text; } else { te.TimeFligh = ""; }
                if (!String.IsNullOrEmpty(txtTime.Text)) { te.TimePiDo = txtTime.Text; } else { te.TimePiDo = ""; }
                if (!String.IsNullOrEmpty(txtDiscount.Text)) { te.Discount = Convert.ToDecimal(txtDiscount.Text); } else { te.Discount = 0; };
                if (!String.IsNullOrEmpty(txtDateEstimate.Text)) { te.DateTransEst = Convert.ToDateTime(txtDateEstimate.Text); } else { te.DateTransEst = null; }

                te.IdMetingPoint = Convert.ToInt32(ddlMetingPoint.SelectedValue);
                te.QtyPassenger = Convert.ToInt32(ddlQtyPassenger.SelectedValue);
                te.QtyPassengerKids = Convert.ToInt32(ddlQtyKids.SelectedValue);
                te.QtyMalaGr = Convert.ToInt32(ddlQtyLuggage.SelectedValue);
                te.QtyMalaPq = Convert.ToInt32(ddlQtyCarryon.SelectedValue);
                te.CityFromId = Convert.ToInt32(ddlCityFrom.SelectedValue);
                te.CityToId = Convert.ToInt32(ddlCityTo.SelectedValue);
                te.TransferAmount = Convert.ToDecimal(lblTransferAmount.Text);
                te.FinalPrice = Convert.ToDecimal(txtFinalPrice.Text);
                te.DateTransEst = Convert.ToDateTime(txtDateEstimate.Text);

                //Codigo Data da Aprovação: 0 - Open // 1 - NO // 2 - YES
                if (ddlAprove.SelectedValue != "0") { DateTime.Now.ToString("yyyy/MM/dd"); } else { te.DateAprove = null; }

                te.IdPassenger = Convert.ToInt32(hdfIdPassenger.Value);
                te.NamePassenger = txtNamePassenger.Text;
                te.Phone = txtfone.Text;
                te.Phone2 = txtPhone2.Text;
                te.Email = txtEmail.Text;
                te.TypeVisa = txtTypeVisa.Text;
                te.Note = txtNote.Text;
                te.IdAprove = Convert.ToInt32(ddlAprove.SelectedValue);
                te.IdTypeDestination = Convert.ToInt32(ddlTypeDestination.SelectedValue);
                te.IdDestination = Convert.ToInt32(ddlDestination.SelectedValue);
                te.IdSales = Convert.ToInt32(ddlSalesContact.SelectedValue);
                te.IdTypeTransfer = Convert.ToInt32(ddlTypeTransfer.SelectedValue);
                te.IdTypePayment = Convert.ToInt32(ddlTypePayment.SelectedValue);
                te.IdStatusPayment = Convert.ToInt32(ddlStatusPayment.SelectedValue);

                DBTrip.TransferEstimate.AddOrUpdate(te);
                DBTrip.SaveChanges();

                var lastId = te.IdTransEst;
                SaveTransferCalendar(te.IdTransEst);

                lblTitleModalSucess.Text = "Transfer Estimate Inserted successfully.";
                UpModalInsertSuccess.Update();
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ModalInsertSuccess", "$('#ModalInsertSuccess').modal();", true);
            }
            else
            {
                te = DBTrip.TransferEstimate.Find(Convert.ToInt32(Id));

                if(te != null)
                {
                    te.IdTransEst = Convert.ToInt32(IdTransferEst);
                    te.FlightNumber = txtFlightNumber.Text;
                    te.DateFligh = Convert.ToDateTime(txtDateVoo.Text);
                    te.TimeFligh = txtTimeVoo.Text;
                    te.TimePiDo = txtTime.Text;
                    te.IdMetingPoint = Convert.ToInt32(ddlMetingPoint.SelectedValue);
                    te.QtyPassenger = Convert.ToInt32(ddlQtyPassenger.SelectedValue);
                    te.QtyMalaGr = Convert.ToInt32(ddlQtyLuggage.SelectedValue);
                    te.QtyMalaPq = Convert.ToInt32(ddlQtyCarryon.SelectedValue);
                    te.CityFromId = Convert.ToInt32(ddlCityFrom.SelectedValue);
                    te.CityToId = Convert.ToInt32(ddlCityTo.SelectedValue);
                    te.TransferAmount = Convert.ToDecimal(lblTransferAmount.Text);
                    if (!String.IsNullOrEmpty(txtDiscount.Text)) { te.Discount = Convert.ToDecimal(txtDiscount.Text); } else { te.Discount = 0; };
                    te.FinalPrice = Convert.ToDecimal(txtFinalPrice.Text);
                    te.DateTransEst = Convert.ToDateTime(txtDateEstimate.Text);

                    //Codigo Data da Aprovação: 0 - Open // 1 - NO // 2 - YES
                    if (ddlAprove.SelectedValue != "0") { DateTime.Now.ToString("yyyy/MM/dd"); } else { te.DateAprove = null; }

                    te.IdPassenger = Convert.ToInt32(hdfIdPassenger.Value);
                    te.NamePassenger = txtNamePassenger.Text;
                    te.Phone = txtfone.Text;
                    te.Phone2 = txtPhone2.Text;
                    te.Email = txtEmail.Text;
                    te.Note = txtNote.Text;
                    te.IdAprove = Convert.ToInt32(ddlAprove.SelectedValue);
                    te.IdTypeDestination = Convert.ToInt32(ddlTypeDestination.SelectedValue);
                    te.IdDestination = Convert.ToInt32(ddlDestination.SelectedValue);
                    te.IdSales = Convert.ToInt32(ddlSalesContact.SelectedValue);
                    te.IdTypeTransfer = Convert.ToInt32(ddlTypeTransfer.SelectedValue);
                    te.IdTypePayment = Convert.ToInt32(ddlTypePayment.SelectedValue);
                    te.IdStatusPayment = Convert.ToInt32(ddlStatusPayment.SelectedValue);

                    DBTrip.TransferEstimate.AddOrUpdate(te);
                    DBTrip.SaveChanges();

                    SaveTransferCalendar(te.IdTransEst);

                    //Library.DisplayAtertBootstrap(this, "Transfer Estimate Updated!", Library.MessageType.Success);
                    //if (ddlAprove.SelectedValue == "2")
                    //{
                    //    Response.Redirect("~/TransferEstimate/TransferApproved");
                    //}

                    lblTitleModalSucess.Text = "Transfer Estimate Updated successfully.";
                    UpModalInsertSuccess.Update();
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ModalInsertSuccess", "$('#ModalInsertSuccess').modal();", true);
                }
            }
        }
        protected bool VerifyTypeDestination(string IdDest)
        {
            bool isTrue = false;
            var idd = Convert.ToInt32(IdDest);

            atripservicesEntities db = new atripservicesEntities();

            var dados = db.Destination.Find(idd);

            if (Convert.ToInt32(ddlTypeDestination.SelectedValue) != dados.IdTypeDestination)
            {isTrue = true;}

            return isTrue;
        }
        protected void SavePassenger()
        {
            string namepassenger = "";
            string email = "";
            string phone = "";
            bool verifyPassenger = false;

            namepassenger = txtNamePassengerModal.Text;
            email = txtEmailPassengerModal.Text;
            phone = txtPhonePassengerModal.Text;

            atripservicesEntities DBTrip = new atripservicesEntities();

            var qry = DBTrip.Passenger.Count(x => x.Email == email && x.Name == namepassenger && x.Phone == phone);

            if (qry >= 1)
            {
                verifyPassenger = true;
            }

            if (verifyPassenger == true)
            {
                Library.DisplayAtertBootstrap(this, "There is already a passenger!", Library.MessageType.Warning);
            }
            else
            {
                Passenger pa = new Passenger();

                pa.Name = txtNamePassengerModal.Text;
                pa.Email = txtEmailPassengerModal.Text;
                pa.Phone = txtPhonePassengerModal.Text;
                pa.Phone2 = txtPhone2PassengerModal.Text;
                pa.IdTypeVisa = Convert.ToInt32(ddlTypeVisa.SelectedValue);

                DBTrip.Passenger.Add(pa);
                DBTrip.SaveChanges();

                Library.DisplayAtertBootstrap(this, "Passenger Inserted!", Library.MessageType.Success);
            }
        }
        protected void ClearPassengerModal()
        {
            txtNamePassengerModal.Text = "";
            txtPhone2PassengerModal.Text = "";
            txtPhonePassengerModal.Text = "";
            txtEmailPassengerModal.Text = "";
        }
       
        #endregion

        #region Actions Buttons

        protected void lbCancel_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ModalDelete", "$('#ModalDelete').modal('hide');", true);
        }
        //Insert Passenger Modal ------------------------------------
        protected void btnInsertPassenger_Click(object sender, EventArgs e)
        {
            ClearPassengerModal();
            UpModalPassenger.Update();
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ModalPassenger", "$('#ModalPassenger').modal();", true);
        }
        protected void btnTest_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ModalInsertSuccess", "$('#ModalInsertSuccess').modal();", true);
        }
        
        protected void btnSavePassenger_Click(object sender, EventArgs e)
        {
            SavePassenger();
            LoadGridPassenger(txtNamePassengerModal.Text);
            ClearPassengerModal();
            UpModalPassenger.Update();
            
            //ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ModalPassenger", "$('#ModalPassenger').modal('hide');", true);
            //Library.DisplayAtertBootstrap(this, "Passenger inserted successfully!", Library.MessageType.Success);
        }
        protected void btnSearchPassenger_Click(object sender, EventArgs e)
        {
            LoadGridPassenger(txtNamePassengerModal.Text);
            UpModalPassenger.Update();
        }
        
        protected void btnCancelPassenger_Click(object sender, EventArgs e)
        {
            ClearPassengerModal();
            UpModalPassenger.Update();
        }
        protected void btnClearPassenger_Click(object sender, EventArgs e)
        {
            txtNamePassenger.Text = "";
            txtPhone2.Text = "";
            txtfone.Text = "";
            txtEmail.Text = "";
            upMainPassenger.Update();
        }

        #region Modal Sucess Transfer Mode
        protected void btnInsertNewTransferEstimate_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Budget/CRUDTransfeEstimate.aspx?IdTransEst=0");
        }
        protected void btnGoTransfersApproved_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/TransferEstimate/TransferApproved");
        }
        protected void btnGoCalendar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Calendar/Index");
        }

        #endregion

        //Insert Passenger Modal ------------------------------------
        #region for Insert-Update Type Destination
        // Procedures for insert - update Type Destination ------------------------------
        protected void btnNewTypeDestination_Click(object sender, EventArgs e)
        {
            LoadGridTypeDestination("");
            upModalTypeDestination.Update();
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ModalTypeDestination", "$('#ModalTypeDestination').modal();", true);
        }
        protected void btnSaveModelTypeDestination_Click(object sender, EventArgs e)
        {
            if (SaveTypeDestination(txtModalTypeDestination.Text) == true)
            {
                ClearTypeDestination();
                LoadGridTypeDestination(txtModalTypeDestination.Text);
                LoadTypeDestination(ddlTypeDestination, Id);
                LoadDestination(ddlTypeDestination.SelectedValue,"0");
                upModalTypeDestination.Update();
                upMainDestination.Update();
                UpSalesChannel1.Update();
                UpSalesChannel2.Update();
                Library.DisplayAtertBootstrap(this, "New Type Destination Inserted!", Library.MessageType.Success);
            }
            else
            {
                ClearTypeDestination();
                upModalTypeDestination.Update();
                Library.DisplayAtertSweet(this, "Verify Type Destination!", "Type Destination Already Exists", Library.MessageType.Warning);
            }
        }
        protected void btnCancelTypeModalDestination_Click(object sender, EventArgs e)
        {
            ClearTypeDestination();
            upModalTypeDestination.Update();
        }
        // Procedures for insert - update Type Destination ------------------------------
        #endregion
        #region Procedures for Insert-Update Destination
        //Procedures for Insert-Update Destination ----------------------------------------------------
        protected void btnNewDestination_Click(object sender, EventArgs e)
        {
            lblModalDestination.Text = "Add New Destination";
            ClearDestination();
            LoadCity(ddlIdCityDestModal, "0");
            LoadAllSale(ddlIdSalesDestModal, ddlSalesContact.SelectedValue);
            LoadTypeDestination(ddlIdTypeDestModal, ddlTypeDestination.SelectedValue);
            LoadGridDestination("", ddlTypeDestination.SelectedValue);
            LoadGridDestinationReqReservation(Id);
            UpModalDestination.Update();
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ModalDestination", "$('#ModalDestination').modal();", true);
            //UpModalDestination.Update();
        }
        protected void btnSaveModalDestination_Click(object sender, EventArgs e)
        {
            if (SaveDestination(txtNameDestination.Text, txtAddressDestination.Text, ddlIdCityDestModal.SelectedValue, ddlIdSalesDestModal.SelectedValue,
                ddlIdTypeDestModal.SelectedValue, txtMobileDestination.Text, txtPhoneDestination.Text, txtPostalCodeDestination.Text))
            {
                LoadGridDestination(txtNameDestination.Text, ddlIdTypeDestModal.SelectedValue);
                ClearDestination();
                UpModalDestination.Update();
                Library.DisplayAtertBootstrap(this, "Inserted Destination!", Library.MessageType.Success);
            }
            else
            {
                Library.DisplayAtertBootstrap(this, "So save destination!", Library.MessageType.Error);
            }
            
        }
        protected void btnEditDestination_Click(object sender, EventArgs e)
        {
            if (EditDestination(txtNameDestination.Text, txtAddressDestination.Text, ddlIdCityDestModal.SelectedValue, ddlIdSalesDestModal.SelectedValue,
                ddlIdTypeDestModal.SelectedValue, txtMobileDestination.Text, txtPhoneDestination.Text, txtPostalCodeDestination.Text, hdfIdDestinationOn.Value))
            {
                LoadGridDestination(txtNameDestination.Text, ddlIdTypeDestModal.SelectedValue);
                ClearDestination();
                btnEditDestination.Visible = false;
                btnSaveModalDestination.Visible = true;
                UpModalDestination.Update();
                Library.DisplayAtertBootstrap(this, "Updated Destination!", Library.MessageType.Success);
            }
            else
            {
                Library.DisplayAtertBootstrap(this, "No update destination!", Library.MessageType.Error);
            }

        }
        protected void btnCancelModalDestination_Click(object sender, EventArgs e)
        {
            ClearDestination();

            //UpModalDestination.Update();
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ModalTest", "$('#ModalTest').modal('hide');", true);
        }
        //Procedures for Insert-Update Destination ----------------------------------------------------
        #endregion

        protected void btnSaveTrasferEstimate_Click(object sender, EventArgs e)
        {
            if (ddlDestination.SelectedItem.ToString() == "Request Reservation")
            {
                Library.DisplayAtertSweet(this, "Attention!", "Destination not selected, please check.", Library.MessageType.Warning);
            }
            else
            {
                SaveTranferTestimate(Id);
                //ClearTransferEstimate("0");
            }
        }

        protected void btnCancelTransferEstimate_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/TransferEstimate/Index");
        }

        

        protected void btnCalcEstimate_Click(object sender, EventArgs e)
        {
            CalculateEstimate(ddlCityFrom.SelectedValue.ToString(), ddlCityTo.SelectedValue.ToString(), ddlQtyPassenger.SelectedValue.ToString(), ddlQtyLuggage.SelectedValue.ToString(), ddlQtyCarryon.SelectedValue.ToString(), txtDiscount.Text);
            upMainDestination.Update();
        }

        protected void btnCalcFinalPrice_Click(object sender, EventArgs e)
        {
            CalculateFinalPrice(ddlCityFrom.SelectedValue.ToString(), ddlCityTo.SelectedValue.ToString(), ddlQtyPassenger.SelectedValue.ToString(),ddlQtyLuggage.SelectedValue.ToString(), ddlQtyCarryon.SelectedValue.ToString(), txtDiscount.Text, ddlSalesContact.SelectedValue);
            btnCalcEstimate_Click(sender, e);
            UpSalesChannel2.Update();
            upMainDestination.Update();
        }

        protected void btnSearchModalDestination_Click(object sender, EventArgs e)
        {
            LoadGridDestination(txtNameDestination.Text, ddlIdTypeDestModal.SelectedValue);
            UpModalDestination.Update();
        }

        //protected void btnEditDestination_Click(object sender, EventArgs e)
        //{
        //    LoadGridDestination(txtNameDestination.Text, ddlIdTypeDestModal.SelectedValue);
        //    UpModalDestination.Update();
        //}

        #endregion

        #region Action
        protected void ddlTypeDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDestination(ddlTypeDestination.SelectedValue.ToString(), "0");
            LoadSale(ddlSalesContact, ddlDestination.SelectedValue, "0");
            upMainDestination.Update();
            UpSalesChannel1.Update();
        }
        protected void ddlSalesContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPriciesCity(ddlCityFrom, Id);
            LoadPriciesCity(ddlCityTo, Id);
        }
        protected void ddlDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSale(ddlSalesContact, ddlDestination.SelectedValue, "0");
            upMainDestination.Update();
            UpSalesChannel1.Update();
        }
        
        protected void btnSelectDestination_Click(object sender, EventArgs e)
        {
            identify = 2;
        }
        protected void ddlIdTypeDestModal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNameDestination.Text))
            {
                LoadGridDestination(txtNameDestination.Text, ddlIdTypeDestModal.SelectedValue);
            }
            else
            {
                LoadGridDestination("", ddlIdTypeDestModal.SelectedValue);
            }
            UpModalDestination.Update();
        }
        #endregion

        #region GridView Actions

        #region gvDestination
        protected void imbSelectDestination_Click(object sender, EventArgs e)
        {
            identify = 1;
        }
        protected void imbEditDestination_Click(object sender, EventArgs e)
        {
            identify = 2;
        }
        /// <summary>
        /// identify = 1 is Select; identify = 2 is select to Edit
        /// </summary>
        protected void gvDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            string IdType = ((HiddenField)gvDestination.Rows[gvDestination.SelectedRow.RowIndex].FindControl("hdfIdTypeDestination")).Value;
            string IdDestination = ((HiddenField)gvDestination.Rows[gvDestination.SelectedRow.RowIndex].FindControl("hdfIdDestination")).Value;
            string IdSalesContact = ((HiddenField)gvDestination.Rows[gvDestination.SelectedRow.RowIndex].FindControl("hdfIdSalesContact")).Value;
            string IdCity = ((HiddenField)gvDestination.Rows[gvDestination.SelectedRow.RowIndex].FindControl("hdfIdCity")).Value;

            switch (identify)
            {
                case 1:
                    ClearDestination();
                    txtNameDestination.Enabled = true;
                    txtPhoneDestination.Enabled = true;
                    txtMobileDestination.Enabled = true;
                    txtPostalCodeDestination.Enabled = true;
                    ddlIdCityDestModal.Enabled = true;
                    ddlIdTypeDestModal.Enabled = true;
                    btnEditDestination.Visible = false;
                    btnSaveModalDestination.Visible = true;
                    LoadTypeDestination(ddlTypeDestination, IdType);
                    LoadDestination(IdType, IdDestination);
                    LoadSale(ddlSalesContact, IdDestination, IdSalesContact);
                    LoadCity(ddlCityTo, IdCity);
                    upMainDestination.Update();
                    UpSalesChannel1.Update();
                    UpDepartures.Update();
                    btnCalcFinalPrice_Click(sender, e);
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ModalDestination", "$('#ModalDestination').modal('hide');", true);
                    break;
                case 2:
                    txtNameDestination.Text = ((Label)gvDestination.Rows[gvDestination.SelectedRow.RowIndex].FindControl("lblName")).Text;
                    txtPhoneDestination.Text = ((Label)gvDestination.Rows[gvDestination.SelectedRow.RowIndex].FindControl("lblPhone")).Text;
                    txtMobileDestination.Text = ((Label)gvDestination.Rows[gvDestination.SelectedRow.RowIndex].FindControl("lblMobile")).Text;
                    txtPostalCodeDestination.Text = ((Label)gvDestination.Rows[gvDestination.SelectedRow.RowIndex].FindControl("lblPostalCode")).Text;
                    txtAddressDestination.Text = ((Label)gvDestination.Rows[gvDestination.SelectedRow.RowIndex].FindControl("lblAddress")).Text;
                    ddlIdCityDestModal.SelectedValue = ((HiddenField)gvDestination.Rows[gvDestination.SelectedRow.RowIndex].FindControl("hdfIdCity")).Value;
                    ddlIdSalesDestModal.SelectedValue = IdSalesContact;
                    ddlIdTypeDestModal.SelectedValue = IdType;
                    hdfIdDestinationOn.Value = ((HiddenField)gvDestination.Rows[gvDestination.SelectedRow.RowIndex].FindControl("hdfIdDestination")).Value;

                    btnEditDestination.Visible = true;
                    btnSaveModalDestination.Visible = false;
                    //txtNameDestination.Enabled = false;
                    //txtPhoneDestination.Enabled = false;
                    //txtMobileDestination.Enabled = false;
                    //txtPostalCodeDestination.Enabled = false;
                    //ddlIdCityDestModal.Enabled = true;
                    //ddlIdTypeDestModal.Enabled = true;
                    //ddlIdTypeDestModal.AutoPostBack = true;
                    UpModalDestination.Update();
                    break;
            }

        }
        #endregion

        protected void gvPassenger_SelectedIndexChanged(object sender, EventArgs e)
        {
            string IdPassenger = ((HiddenField)gvPassenger.Rows[gvPassenger.SelectedRow.RowIndex].FindControl("hdfIdPassenger")).Value;
            string IdTypeVisa = ((HiddenField)gvPassenger.Rows[gvPassenger.SelectedRow.RowIndex].FindControl("hdfIdPassenger")).Value;
            hdfIdPassenger.Value = IdPassenger;
            LoadTypeVisa(ddlTypeVisa, IdTypeVisa);
            txtNamePassenger.Text = ((Label)gvPassenger.Rows[gvPassenger.SelectedRow.RowIndex].FindControl("lblName")).Text;
            txtEmail.Text = ((Label)gvPassenger.Rows[gvPassenger.SelectedRow.RowIndex].FindControl("lblEmail")).Text;
            txtPhone2.Text = ((Label)gvPassenger.Rows[gvPassenger.SelectedRow.RowIndex].FindControl("lblPhone2")).Text;
            txtfone.Text = ((Label)gvPassenger.Rows[gvPassenger.SelectedRow.RowIndex].FindControl("lblPhone")).Text;
            txtTypeVisa.Text = ((Label)gvPassenger.Rows[gvPassenger.SelectedRow.RowIndex].FindControl("lblTypeVisa")).Text;
            ClearPassengerModal();
            upMainPassenger.Update();
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ModalPassenger", "$('#ModalPassenger').modal('hide');", true);
        }
        protected void gvDestinationReqReservation_OnRowDeleted(object sender, EventArgs e)
        {
            string IdType = ((HiddenField)gvDestinationReqReservation.Rows[gvDestinationReqReservation.SelectedRow.RowIndex].FindControl("hdfIdReservationRequest")).Value;
        }
        protected void gvDestinationReqReservation_SelectedIndexChanged(object sender, EventArgs e)
        {
            string IdReservationRequest = ((HiddenField)gvDestinationReqReservation.Rows[gvDestinationReqReservation.SelectedRow.RowIndex].FindControl("hdfIdReservationRequest")).Value;
            //Library.DisplayAtertBootstrap(this, "Passou no teste", Library.MessageType.Info);

            var IdRR = Convert.ToInt32(IdReservationRequest);

            atripservicesEntities DBTrip = new atripservicesEntities();
            var dados = (from p in DBTrip.ReservationRequest
                         where p.IdReservationRequest == IdRR
                         select p).ToList<ReservationRequest>();

            if (DBTrip != null)
            {
                foreach (var item in dados)
                {
                    txtNameDestination.Text = item.NamePD;
                    txtPhoneDestination.Text = item.PhonePD;
                    txtMobileDestination.Text = item.MobilePD;
                    txtAddressDestination.Text = item.AddressPD;
                    txtPostalCodeDestination.Text = item.PostalCodePD;
                }
            }

            UpModalDestination.Update();
        }
        
        protected void gvTypeDestination1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            string IdType = ((HiddenField)gvTypeDestination1.Rows[gvTypeDestination1.SelectedRow.RowIndex].FindControl("hdfIdTypeDestination")).Value;
            LoadTypeDestination(ddlTypeDestination, IdType);
            LoadDestination(ddlTypeDestination.SelectedValue, "0");
            ClearTypeDestination();
            upModalTypeDestination.Update();
            upMainDestination.Update();
            UpSalesChannel1.Update();
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ModalTypeDestination", "$('#ModalTypeDestination').modal('hide');", true);
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ddlAprove_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ddlAprove.SelectedValue)
            {
                case "0":
                    cbIncludeCalendar.Enabled = true;
                    cbIncludeCalendar.Checked = true;
                    UpSalesChannel.Update();
                    break;
                case "2":
                    txtDateAprove.Text = DateTime.Now.ToString("yyyy-MM-dd");
                    cbIncludeCalendar.Enabled = true;
                    cbIncludeCalendar.Checked = true;
                    UpSalesChannel.Update();
                    break;
                case "1":
                    cbIncludeCalendar.Enabled = false;
                    cbIncludeCalendar.Checked = false;
                    UpSalesChannel.Update();
                    break;
            }
        }
    }
}