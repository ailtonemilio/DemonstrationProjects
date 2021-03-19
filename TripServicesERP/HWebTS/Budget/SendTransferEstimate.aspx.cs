using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using HWebTS.Models;
using System.Data.Entity.Migrations;

//Create PDF
using iText = iTextSharp.text;
using iTextText = iTextSharp.text;
using itextTextPDF = iTextSharp.text.pdf;
using itextTextHTML = iTextSharp.text.html;
using iTextTextPDFEvents = iTextSharp.text.pdf.events;
using iTextTextPDFSimpleParser = iTextSharp.text.html.simpleparser;
using itextTextPDFElements = iTextSharp.text.Element;

//Send Email
using System.Net.Mail;
using System.Net.Mime;
using System.Net;
using System.Text.RegularExpressions;
using System.Net.Configuration;
using System.Text;

namespace HWebTS.Budget
{
    public partial class SendTransferEstimate : System.Web.UI.Page
    {
        #region Variables
        int identify = 0;
        string Id = "0";
        bool PDF_Created = false;
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!String.IsNullOrEmpty(Request.QueryString["IdTransEst"]))
                {
                    Id = Request.QueryString["IdTransEst"];
                }
                else
                {
                    Response.Redirect("~/Account/Login");
                }

                if (isMobileBrowser())
                {
                    divgvSend.Attributes.Add("class", "table-responsive");
                }

                LoadTransfer(Id);
            }
        }

        #region Buttons Actions
        protected void btnPDFCreate_Click(object sender, EventArgs e)
        {
            if (ValidateEmail(txtEmail.Text))
            {
                Create_PDF(lblIdTransEst.Text);

                if (PDF_Created == true)
                {
                    SendEmailPassenger();
                    //After sending email and need to load JScript again on page
                    //Library.DisplayScript(this, "$('.btn-default').on('click', function () { var $this = $(this); $this.button('loading'); setTimeout(function() { $this.button('reset'); }, 28000); }); ");
                }
            }
            else
            {
                Library.DisplayAtertBootstrap(this, "This email is not valid! Please, insert one valid email.", Library.MessageType.Warning);
            }
        }
        protected void btnReturn_Click(object sender, EventArgs e)
        {
            atripservicesEntities DBTrip = new atripservicesEntities();
            TransferEstimate te = new TransferEstimate();
            Event ev = new Event();

            //Delete Event
            var idt = Convert.ToInt32(lblIdTransEst.Text);

            var dados = (from p in DBTrip.Events
                         where p.IdTransEst == idt
                         select p).ToList<Event>();

            if (DBTrip != null)
            {
                foreach (var item in dados)
                {
                    ev = DBTrip.Events.Find(item.EventID);
                    ev.ThemeColor = "darkslateblue";
                    DBTrip.Events.AddOrUpdate(ev);
                    DBTrip.SaveChanges();
                }
            }

            //Update Aprove for Open
            te = DBTrip.TransferEstimate.Find(Convert.ToInt32(lblIdTransEst.Text));

            if (te != null)
            {
                
                te.IdAprove = 0;

                DBTrip.SaveChanges();
                Response.Redirect("~/TransferEstimate/Index");
            }
        }
        
        #endregion

        #region Metodos
        protected void LoadTransfer(string IdTransfer)
        {
            atripservicesEntities DBTrip = new atripservicesEntities();

            var id = Convert.ToInt32(IdTransfer);

            var dados = (from p in DBTrip.TransferEstimate
                         join cf in DBTrip.PriceCities on p.CityFromId equals cf.IdCity
                         join ct in DBTrip.PriceCities on p.CityToId equals ct.IdCity
                         join mp in DBTrip.MetingPoint on p.IdMetingPoint equals mp.IdMetingPoint
                         join d in DBTrip.Destination on p.IdDestination equals d.IdDestination
                         join td in DBTrip.TypeDestination on p.IdTypeDestination equals td.IdTypeDestination
                         where p.IdTransEst == id
                         select p).ToList<TransferEstimate>();

            if (DBTrip != null)
            {
                foreach (var item in dados)
                {
                    lblIdTransEst.Text = item.IdTransEst.ToString();
                    lblFlightNum.Text = item.FlightNumber.ToString();
                    lblFlightDate.Text = item.DateFligh.ToString().Substring(0, 10);
                    lblFlighTime.Text = item.TimeFligh.ToString();
                    lblDateTransfer.Text = item.DateTransEst.ToString().Substring(0, 10);
                    lblHorarioTrans.Text = item.TimePiDo.ToString();

                    if (item.PriceCitiesTo.City.ToUpper() == "AIRPORT")
                    { lblLocalEncontro.Text = item.PriceCitiesTo.City + " - " + item.MetingPoint.DescMetingPoint; }
                    else
                    { lblLocalEncontro.Text = item.PriceCitiesTo.City ; }

                    
                    lblQtyPassenger.Text = item.QtyPassenger.ToString();
                    lblQtyKids.Text = item.QtyPassengerKids.ToString();
                    lblQtyLugagge.Text = item.QtyMalaGr.ToString();
                    lblQtySuitCase.Text = item.QtyMalaPq.ToString();
                    lblCityFrom.Text = item.PriceCitiesFrom.City;
                    lblCityTo.Text = item.PriceCitiesTo.City;
                    lblFinalPrice.Text = item.FinalPrice.ToString();
                    txtEmail.Text = item.Email;
                    lblNamePassenger.Text = item.NamePassenger.ToString();
                    lblPhone.Text = item.Phone.ToString();
                    lblEmailPassenger.Text = item.Email;

                    lblNameContact.Text = item.Destination.Name;
                    lblAddressContact.Text = item.Destination.Address;
                    lblPhoneContact.Text = item.Destination.Phone;
                    lblMobileContact.Text = item.Destination.Mobile;
                    lblTypeDestination.Text = item.TypeDestination.DescTypeDestination;
                }
            }
        }
        #endregion

        #region GridView Actions

        #endregion

        #region Create and Send PDF
        /// <summary>
        /// Confirm the validity of an email
        /// </summary>
        /// <param name="Email">Email to be validated</param>
        /// <returns>Returns True if the email is valid</returns>
        public static bool ValidateEmail(string Email)
        {
            try
            {
                //define the regular expression to validate the email
                string text_Validation = Email;
                Regex exRegex = new Regex(@"\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}");

                // test email with expression
                if (exRegex.IsMatch(text_Validation))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void InsertSendEmailTable()
        {

        }

        protected void SendEmail(string EmailTo, string EmailFrom, string Password, string SMTP, int Port)
        {
            string MessageEmail = "";
            string Image = "";
            string Html = "";

            if (!String.IsNullOrEmpty(txtMessage.Text))
                MessageEmail = txtMessage.Text;

            Image = " <div><img src='http://www.triptravel.ca/images/logoemail.png' width='160px' height='44px' /> </div>";

            ServicePointManager.ServerCertificateValidationCallback = (obj, certificate, chain, errors) => true;

            //MailMessage mail = new MailMessage();
            //mail.Subject = "Trip Services" + " Quotation Transfer Id #" + lblIdTransEst.Text;
            //mail.From = new MailAddress(EmailFrom);
            //mail.To.Add(EmailTo);

            //No delete this
            string link = "<a href='http://www.tripservices.ca' target='blank' >www.tripservices.ca</a>";
            string LinkFace = "<a href='http://www.Facebook.com/tripservices' target='blank' ><img src='http://www.triptravel.ca/images/logoface.jpeg' title=' FaceBook Trip Services, click here!' width='25px' height='25px' /></a>";
            string LinkIsta = "<a href='http://www.Instagram.com/tripservices' target='blank' ><img src ='http://www.triptravel.ca/images/logoinsta.jpg' title='Instagram Trip Services, click here!' width='25px' height='25px' /></a>";
            string Internet = "<img src='http://www.triptravel.ca/images/icon/internet.png'  />";
            string Whatsapp = "<img src='http://www.triptravel.ca/images/icon/whatsapp.png'  />";
            string EmailTrip = "<img src = 'http://www.triptravel.ca/images/icon/email.png' width='16px' height='16px' />";

            Html = "<html>" +
               "   <body>" +
               "      <div>" +
               "      <div>" +
               "        Quotation Transfer ID <b># " + lblIdTransEst.Text + "</b></div><br />" +
               "      <div>Dear " + lblNamePassenger.Text + ", " + "</div><br />";

            if (!String.IsNullOrEmpty(MessageEmail))
            {
                Html = Html + "<div>" + MessageEmail + "</div><br />";
            }

            Html = Html + "      <table>" +
            "           <tr>" +
            "               <td >Thank you </td>" +
            "           </tr>" +
            "           <tr>" +
            "               <td>" + "Trip Services" + "</td>" +
            "           </tr>" +
            "           <tr>" +
            "               <td>" + Image +
            "               </td>" +
            "           </tr>" +
            "       </table>" +

            "<br>" +


            "       <table>" +
            "           <tr>" +
            "               <td>" + Whatsapp + "</td>" +
            "               <td>&nbsp;" + "+1 778-883-4776" + "</td>" +
            "           </tr>" +
            "           <tr>" +
            "               <td>" + EmailTrip + "</td>" +
            "               <td>&nbsp;" + "info@tripservices.ca" + "</td>" +
            "           </tr>" +
            "           <tr>" +
            "               <td>" + Internet + "</td>" +
            "               <td>&nbsp;" + link +
            "              </td>" +
            "           </tr>" +
            "           <tr>" +
            "               <td>" + LinkFace + "</td>" +
            "               <td>" + LinkIsta +
            "              </td>" +
            "           </tr>" +
            "       </table>" +
            "      </td><td>" +

            "  </body>" +
            "</html>";

            #region New Code
            // Estancia da Classe de Mensagem
            MailMessage _mailMessage = new MailMessage();
            // Remetente
            _mailMessage.From = new MailAddress(EmailFrom);

            // Destinatario seta no metodo abaixo

            //Contrói o MailMessage
            _mailMessage.CC.Add(EmailTo);
            _mailMessage.Subject = "Trip Services" + " Quotation Transfer Id #" + lblIdTransEst.Text;

            Attachment at = new Attachment(Server.MapPath("~/temp/emailtransferid" + lblIdTransEst.Text + ".PDF"));
            _mailMessage.Attachments.Add(at);

            _mailMessage.IsBodyHtml = true;
            _mailMessage.Body = Html;

            //CONFIGURAÇÃO COM PORTA
            SmtpClient _smtpClient = new SmtpClient(SMTP, Port);

            //CONFIGURAÇÃO SEM PORTA
            // SmtpClient _smtpClient = new SmtpClient(UtilRsource.ConfigSmtp);

            // Credencial para envio por SMTP Seguro (Quando o servidor exige autenticação)
            _smtpClient.UseDefaultCredentials = false;
            _smtpClient.Credentials = new NetworkCredential(EmailFrom, Password);

            _smtpClient.EnableSsl = false;

            try
            {
                _smtpClient.Send(_mailMessage);
                _smtpClient.Dispose();
                at.Dispose();
                Library.DisplayAtertBootstrap(this, "Email sent to " + EmailTo + " with Quotation Transfer ID # " + lblIdTransEst.Text + " attached.", Library.MessageType.Success);
                System.IO.File.Delete(Server.MapPath("~/temp/emailtransferid" + lblIdTransEst.Text + ".PDF"));

                InsertTransferSend(lblIdTransEst.Text);
                gvSend.DataBind();
            }
            catch (Exception ex)
            {
                Library.DisplayAtertBootstrap(this, "No Send email: try again or contact admin", Library.MessageType.Error);
                _smtpClient.Dispose();
                at.Dispose();
                Delete_PDF(lblIdTransEst.Text);
            }
            #endregion


            #region Old Code
            //mail.Body = Html;

            //Attachment at1 = new Attachment(Server.MapPath("~/temp/emailtransferid" + lblIdTransEst.Text + ".PDF"));
            //mail.Attachments.Add(at1);

            //mail.IsBodyHtml = true;

            //SmtpClient smtp = new SmtpClient(SMTP, Port);
            //smtp.EnableSsl = true;
            //NetworkCredential netCre = new NetworkCredential(EmailFrom, Password);
            //smtp.Credentials = netCre;

            //try
            //{
            //    smtp.Send(mail);
            //    smtp.Dispose();
            //    at.Dispose();
            //    Library.DisplayAtertBootstrap(this, "Email sent to " + EmailTo + " with Quotation Transfer ID # " + lblIdTransEst.Text + " attached.", Library.MessageType.Success);
            //    System.IO.File.Delete(Server.MapPath("~/temp/emailtransferid" + lblIdTransEst.Text + ".PDF"));

            //    InsertTransferSend(lblIdTransEst.Text);
            //    gvSend.DataBind();
            //}
            //catch (Exception ex)
            //{
            //    Library.DisplayAtertBootstrap(this, "No Send email: try again or contact admin", Library.MessageType.Error);
            //    smtp.Dispose();
            //    at.Dispose();
            //    Delete_PDF(lblIdTransEst.Text);
            //}
            #endregion


        }
        
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
        protected void InsertTransferSend(string IdTransferEst)
        {
            bool ret = false;
            atripservicesEntities DBTrip = new atripservicesEntities();
            TransferSend dt = new TransferSend();


            dt.DateSend = DateTime.Now;
            dt.SmallMessage = txtMessage.Text;
            dt.IdAprove = 2;
            dt.IdTransEst = Convert.ToInt32(IdTransferEst);
            dt.Note = txtNote.Text;
            dt.NameUser = Session["Name"].ToString();

            DBTrip.TransferSend.Add(dt);
            DBTrip.SaveChanges();
            ret = true;
        }

        protected void SendEmailPassenger()
        {
            string EmailFrom = "";
            string SMTP = "";
            string Port = "";
            string Password = "";

            atripservicesEntities DBTrip = new atripservicesEntities();

            //var id = Convert.ToInt32(IdTransfer);

            var dados = (from p in DBTrip.ConfigApp
                         //join cf in DBTrip.PriceCities on p.CityFromId equals cf.IdCity
                         //join ct in DBTrip.PriceCities on p.CityToId equals ct.IdCity
                         //where p.IdTransEst == id
                         select p).ToList<ConfigApp>();

            if (DBTrip != null)
            {
                foreach (var item in dados)
                {
                    EmailFrom = item.account;
                    SMTP = item.AccountSMTP;
                    Port = item.PortSMTP;
                    Password = item.PasswordAccount;
                }
            }

            if (!String.IsNullOrEmpty(txtEmail.Text) && !String.IsNullOrEmpty(EmailFrom) && !String.IsNullOrEmpty(Password) && !String.IsNullOrEmpty(SMTP))
            {
                SendEmail(txtEmail.Text, EmailFrom, Password, SMTP, Convert.ToInt32(Port));
                txtMessage.Text = "";
                txtNote.Text = "";
            }
            else
            {
                Library.DisplayAtertBootstrap(this, "No email sent: verifi Config App", Library.MessageType.Error);
            }

                        
        }

        protected void Create_PDF(string TransferId)
        {
            try
            {
                //Start Create PDF Document
                // References http://www.4guysfromrolla.com/articles/030911-1.aspx
                // Reference http://www.macoratti.net/16/07/aspn_rlpdf1.htm 
                // Create a Document object
                var document = new iTextSharp.text.Document(iTextSharp.text.PageSize.LETTER, 25, 25, 15, 15);

                // define font
                System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();

                // Create a new PdfWrite object, writing the output to the file ~/temp/emailPO.pdf
                var output = new FileStream(Server.MapPath("~/temp/emailtransferid" + TransferId + ".pdf"), FileMode.OpenOrCreate);
                var writer = iTextSharp.text.pdf.PdfWriter.GetInstance(document, output);

                // Open the Document for writing
                document.Open();

                // First, create our fonts... (For more on working w/fonts in iTextSharp, see: http://www.mikesdotnetting.com/Article/81/iTextSharp-Working-with-Fonts
                var titleFont = iTextSharp.text.FontFactory.GetFont("Arial", 18, iTextSharp.text.Font.BOLD);
                var subTitleFont = iTextSharp.text.FontFactory.GetFont("Arial", 14, iTextSharp.text.Font.BOLD);
                var boldTableFont = iTextSharp.text.FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD);
                var endingMessageFont = iTextSharp.text.FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.ITALIC);
                var bodyFont = iTextSharp.text.FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.NORMAL);

                #region Header

                // Start Table Header ---------------------------------------------------------
                var tbHeader = new iTextSharp.text.pdf.PdfPTable(1);
                iTextSharp.text.Phrase frase = null;
                iTextSharp.text.pdf.PdfPCell cell = null;
                tbHeader.HorizontalAlignment = 0;
                tbHeader.WidthPercentage = 100.0F;
                tbHeader.SetWidths(new float[] { 0.100F });

                // Logo
                //cell = imageCell("~/images/TopoContato.jpg", 35.0F, iTextSharp.text.pdf.PdfPCell.ALIGN_TOP, iTextSharp.text.pdf.PdfPCell.ALIGN_LEFT, 0);
                cell = imageCell("~/images/TopoContrato.png", 35.0F, iTextSharp.text.pdf.PdfPCell.ALIGN_TOP, iTextSharp.text.pdf.PdfPCell.ALIGN_LEFT, 0);
                tbHeader.AddCell(cell);

                //tbHeader.AddCell(cell);
                document.Add(tbHeader);
                // End Table Header ----------------------------------------
                #endregion

                #region Title
                var tbTitle = new iTextSharp.text.pdf.PdfPTable(1);
                tbTitle.DefaultCell.Border = 0;
                tbTitle.HorizontalAlignment = iTextSharp.text.pdf.PdfPCell.ALIGN_CENTER;
                tbTitle.WidthPercentage = 100.0F;
                tbTitle.SetWidths(new float[] { 1.0F});
                tbTitle.SpacingBefore = 10.0F;

                cell = PhraseCell("SERVIÇO DE TRANSFER", iTextSharp.text.pdf.PdfPCell.ALIGN_CENTER, iTextSharp.text.pdf.PdfPCell.ALIGN_CENTER, 0, 2);
                tbTitle.AddCell(cell);
                cell = PhraseCell("(CHEGANDO EM VANCOUVER)", iTextSharp.text.pdf.PdfPCell.ALIGN_CENTER, iTextSharp.text.pdf.PdfPCell.ALIGN_CENTER, 0, 2);
                tbTitle.AddCell(cell);

                document.Add(tbTitle);
                #endregion

                #region Informações Passageiro
                var tbiPassenger = new iTextSharp.text.pdf.PdfPTable(3);
                tbiPassenger.DefaultCell.Border = 0;
                tbiPassenger.HorizontalAlignment = 0;
                tbiPassenger.WidthPercentage = 100.0F;
                tbiPassenger.SetWidths(new float[] { 0.3F, 0.4F, 0.3F });
                tbiPassenger.SpacingBefore = 10.0F;

                //tbiPassenger.DefaultCell.BackgroundColor = new iTextSharp.text.BaseColor(255, 249, 211);
                tbiPassenger.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("Informações do Passageiro:"), iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED))));
                tbiPassenger.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk((" "), iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED))));
                tbiPassenger.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk((" "), iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED))));
                tbiPassenger.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("Name: " + lblNamePassenger.Text), iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL))));
                tbiPassenger.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("Phone: " + lblPhone.Text), iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL))));
                tbiPassenger.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("Email: " + txtEmail.Text), iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL))));

                document.Add(tbiPassenger);
                //End Passenger Information ------------------------------------------------------------------
                #endregion

                #region Dados Voo
                //Start Voo Information ------------------------------------------------------------------
                var tbiVoo = new iTextSharp.text.pdf.PdfPTable(3);
                tbiVoo.DefaultCell.Border = 0;
                tbiVoo.HorizontalAlignment = 0;
                tbiVoo.WidthPercentage = 100.0F;
                tbiVoo.SetWidths(new float[] { 0.3F, 0.4F, 0.3F });
                tbiVoo.SpacingBefore = 10.0F;

                tbiVoo.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("Dados do Voo:"), iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED))));
                tbiVoo.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk((" "), iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED))));
                tbiVoo.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk((" "), iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED))));
                tbiVoo.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("Data: " + lblFlightDate.Text), iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL))));
                tbiVoo.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("Horário: " + lblFlighTime.Text), iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL))));
                tbiVoo.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("Num. Voo: " + lblFlightNum.Text), iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL))));

                document.Add(tbiVoo);
                //End Voo Information ------------------------------------------------------------------
                #endregion

                #region Informações do Transfer
                //Start Transfer Information ------------------------------------------------------------------
                var tbiTrans = new iTextSharp.text.pdf.PdfPTable(3);
                tbiTrans.DefaultCell.Border = 0;
                tbiTrans.HorizontalAlignment = 0;
                tbiTrans.WidthPercentage = 100.0F;
                tbiTrans.SetWidths(new float[] { 0.3F, 0.4F, 0.3F });
                tbiTrans.SpacingBefore = 10.0F;

                tbiTrans.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("Informações do Transfer:"), iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED))));
                tbiTrans.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk((" "), iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED))));
                tbiTrans.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk((" "), iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED))));
                tbiTrans.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("Data: " + lblDateTransfer.Text), iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL))));
                tbiTrans.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("Horário: " + lblHorarioTrans.Text), iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL))));
                tbiTrans.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("Local Encontro: " + lblLocalEncontro.Text), iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL))));
                tbiTrans.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk((" "), iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED))));
                tbiTrans.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("Nº de passageiros: " + lblQtyPassenger.Text), iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL))));
                tbiTrans.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("Nº de crianças: " + lblQtyKids.Text), iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL))));
                tbiTrans.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk((" "), iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED))));
                tbiTrans.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("Nº de Malas Grande: " + lblQtyLugagge.Text), iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL))));
                tbiTrans.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("Nº de Malas de mão: " + lblQtySuitCase.Text), iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL))));

                document.Add(tbiTrans);
                //End Transfer Information ------------------------------------------------------------------
                #endregion

                #region Destino Final
                var tbDFinal = new iTextSharp.text.pdf.PdfPTable(3);
                tbDFinal.DefaultCell.Border = 0;
                tbDFinal.HorizontalAlignment = 0;
                tbDFinal.WidthPercentage = 100.0F;
                tbDFinal.SetWidths(new float[] { 0.3F, 0.4F, 0.3F });
                tbDFinal.SpacingBefore = 10.0F;

                tbDFinal.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("Destino Final:"), iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED))));
                tbDFinal.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk((" "), iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED))));
                tbDFinal.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk((" "), iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED))));
                tbDFinal.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("Tipo: " + lblTypeDestination.Text), iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL))));
                tbDFinal.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("Nome/Contato: " + lblNameContact.Text), iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL))));
                tbDFinal.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("Celular: " + lblMobileContact.Text), iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL))));
                tbDFinal.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk((" "), iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED))));
                tbDFinal.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("Endereço: " + lblAddressContact.Text), iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL))));
                tbDFinal.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("Telefone: " + lblPhoneContact.Text), iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL))));
                //tbDFinal.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk((" "), iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED))));
                //tbDFinal.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk((" "), iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED))));
                //tbDFinal.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk((" "), iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED))));


                document.Add(tbDFinal);
                #endregion

                #region Serviços Contratados
                var tbServ = new iTextSharp.text.pdf.PdfPTable(1);
                tbServ.DefaultCell.Border = 0;
                tbServ.HorizontalAlignment = 0;
                tbServ.WidthPercentage = 100.0F;
                tbServ.SetWidths(new float[] { 1.0F });
                tbServ.SpacingBefore = 10.0F;

                tbServ.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("* Confira no anexo o nosso local de encontro."), iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL))));
                tbServ.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk((" "), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED))));
                tbServ.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk((" "), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED))));
                tbServ.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("I. SERVIÇOS CONTRATADOS:"), iTextSharp.text.FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD))));
                tbServ.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk((" "), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED))));
                tbServ.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("  • Recepção identificada (encontro em local previamente combinado);"), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL))));
                tbServ.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("  • Atendimento 100% em português;"), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL))));
                tbServ.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("  • Assistência na retirada e na movimentação das bagagens dentro e fora do aeroporto;"), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL))));
                tbServ.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("  • Ligação gratuita para o Brasil (Skype);"), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL))));
                tbServ.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("  • Água gratuita no interior do veículo, disponibilização de cabo para recarregar seu celular e internet gratuita;"), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL))));
                tbServ.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("  • Dicas e informações sobre a cidade com máximo conforto durante o traslado até o seu destino final;"), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL))));
                tbServ.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk((" "), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED))));

                document.Add(tbServ);
                #endregion

                #region Regras
                var tbRegras = new iTextSharp.text.pdf.PdfPTable(1);
                tbRegras.DefaultCell.Border = 0;
                tbRegras.HorizontalAlignment = 0;
                tbRegras.WidthPercentage = 100.0F;
                tbRegras.SetWidths(new float[] { 1.0F });
                tbRegras.SpacingBefore = 10.0F;

                tbRegras.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("II. REGRAS:"), iTextSharp.text.FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD))));
                tbRegras.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk((" "), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED))));
                tbRegras.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("    • É de total responsabilidade do passageiro informar qualquer Alteração do Horário e/ou número do voo."), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL))));
                tbRegras.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("        o   Alterações do horário e/ou número do voo quando INFORMADOS: A Trip Services fará o possível para atender o reagendamento de acordo com a disponibilidade da empresa."), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL))));
                tbRegras.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("        o   Alterações do horário e/ou número de voo quando NÃO INFORMADOS: A Trip Services irá aguardar não mais que uma hora após o horário previamente combinado. Após este período a Trip Services aplicará uma penalidade de CAD30.00 (por pessoa) para a prestação do serviço."), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL))));
                tbServ.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk((" "), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED))));
                tbRegras.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("    • Para os Cancelamentos solicitados pelos clientes, seguiremos as seguintes penalidades:"), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL))));
                tbRegras.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("        o   Mais de 72 horas antes do transfer, penalidade de 10% do total da tarifa;"), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL))));
                tbRegras.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("        o   De 24 horas até 72 horas antes do transfer, penalidade de 50% do total da tarifa;"), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL))));
                tbRegras.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("        o   Menos de 24 horas antes do transfer, penalidade de 100% do total da tarifa."), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL))));
                tbServ.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk((" "), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED))));
                tbRegras.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("    • Espera ou Parada extra solicitada: Caso o passageiro solicite uma parada ou mesmo uma mudança de rota, estendendo a viagem por mais de 5 minutos ou 2Km, serão acrescidos CAD10.00 por evento."), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL))));
                tbRegras.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("    • Estacionamento e Pedágios: Poderão ser cobrados a parte."), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL))));
                tbRegras.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("    • Bagagem: Será cobrado a taxa de CAD10.00 por cada mala caso o passageiro exceda o limite de duas malas grandes e uma mala de mão. *Informe previamente qualquer particularidade na sua bagagem."), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL))));
                tbRegras.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("    • Gorjetas: Estão a cargo dos nossos clientes."), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL))));

                document.Add(tbRegras);
                #endregion

                #region Depoimentos
                var tbDep = new iTextSharp.text.pdf.PdfPTable(1);
                tbDep.DefaultCell.Border = 0;
                tbDep.HorizontalAlignment = 0;
                tbDep.WidthPercentage = 100.0F;
                tbDep.SetWidths(new float[] { 1.0F });
                tbDep.SpacingBefore = 10.0F;

                tbDep.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("III.	DEPOIMENTO/FEEDBACK:"), iTextSharp.text.FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD))));
                tbDep.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk((" "), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED))));
                tbDep.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("Após a finalização do transfer, a Trip Services conta com sua colaboração para nos enviar um feedback sobre o nosso atendimento. Acesse o nosso site www.tripservices.ca clique na aba Clientes e no rodapé da página você encontrará o botão “Envie seu depoimento” clique e preencha o formulário, fique à vontade para nos enviar elogios e/ou críticas. Nós estamos em constante aperfeiçoamento."), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL))));

                document.Add(tbDep);
                #endregion

                #region Importante
                var tbImp = new iTextSharp.text.pdf.PdfPTable(1);
                tbImp.DefaultCell.Border = 0;
                tbImp.HorizontalAlignment = 0;
                tbImp.WidthPercentage = 100.0F;
                tbImp.SetWidths(new float[] { 1.0F });
                tbImp.SpacingBefore = 10.0F;

                string impo = "É de extrema importância tanto para você passageiro quanto para nós prestadores de serviço, saber de qualquer alteração que sua viagem venha sofrer, portanto nos comunique urgentemente. " +
                    "Dispomos de atendimento 24/7, por telefone e WhatsApp +1 (778)883-4776, por e-mail info@tripservices.ca, por mensagem no nosso site www.tripservices.ca  menu Contato ou pelo Facebook www.facebook.com/tripservices. " +
                    "Confira também em no site o nosso BLOG, nele você encontrar dicas para sua viagem e dicas de Vancouver.";

                tbImp.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("IV.	IMPORTANTE:"), iTextSharp.text.FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD))));
                tbImp.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk((" "), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED))));
                tbImp.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk((impo), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL))));
                tbImp.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk((" "), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED))));
                tbImp.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("Anexo você encontrará algumas informações que irão auxiliá-lo a conectar na internet do Aeroporto de Vancouver gratuitamente e também onde será o nosso ponto de encontro."), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL))));

                document.Add(tbImp);
                #endregion

                #region Assinatura
                var tbsig = new iTextSharp.text.pdf.PdfPTable(1);
                tbsig.DefaultCell.Border = 0;
                tbsig.HorizontalAlignment = 0;
                tbsig.WidthPercentage = 100.0F;
                tbsig.SetWidths(new float[] { 1.0F });
                tbsig.SpacingBefore = 10.0F;

                tbsig.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("Boa Viagem !"), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL))));
                tbsig.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("Ricardo Silva"), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.BOLDITALIC, iTextSharp.text.BaseColor.BLUE))));

                document.Add(tbsig);
                #endregion

                #region Anexo 1
                var tbane1 = new iTextSharp.text.pdf.PdfPTable(1);
                tbane1.DefaultCell.Border = 0;
                tbane1.HorizontalAlignment = 0;
                tbane1.WidthPercentage = 100.0F;
                tbane1.SetWidths(new float[] { 1.0F });
                tbane1.SpacingBefore = 10.0F;

                tbane1.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("1.	CONEXÃO DE INTERNET NO AEROPORTO DE VANCOUVER"), iTextSharp.text.FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD))));
                tbane1.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk((""), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL))));
                tbane1.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("É só seguir o passo a passo:"), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL))));
                tbane1.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk((""), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL))));

                //tbane1.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk((""), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL))));
                //tbane1.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk((""), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL))));
                

                document.Add(tbRegras);

                var tbane12 = new iTextSharp.text.pdf.PdfPTable(2);
                tbane12.DefaultCell.Border = 0;
                tbane12.HorizontalAlignment = 0;
                tbane12.WidthPercentage = 100.0F;
                tbane12.SetWidths(new float[] { 0.5F, 0.5F });
                tbane12.SpacingBefore = 10.0F;
                

                cell = imageCell("~/images/pdf/wifiairport1.png", 100.0F, iTextSharp.text.pdf.PdfPCell.ALIGN_TOP, iTextSharp.text.pdf.PdfPCell.ALIGN_RIGHT, 0);
                tbane12.AddCell(cell);
                tbane12.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("1º Passo - Selecione a rede @yvrairport:"), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL))));

                
                cell = imageCell("~/images/pdf/wifiairport2.png", 100.0F, iTextSharp.text.pdf.PdfPCell.ALIGN_TOP, iTextSharp.text.pdf.PdfPCell.ALIGN_LEFT, 0);
                tbane12.AddCell(cell);
                tbane12.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("2º Passo - Irá abrir uma nova página onde você verá um botão ''I Agree'' do lado esquerdo da tela, clique nele."), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL))));

                
                cell = imageCell("~/images/pdf/wifiairport3.png", 100.0F, iTextSharp.text.pdf.PdfPCell.ALIGN_TOP, iTextSharp.text.pdf.PdfPCell.ALIGN_LEFT, 0);
                tbane12.AddCell(cell);
                tbane12.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("3º Passo - Entrará em uma nova tela e quase no mesmo lugar do botão anterior aparecerá um novo botão ''Surf The Web'', clique nele. PRONTO simples assim. Enjoy!!!!"), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL))));


                document.Add(tbane12);
                #endregion

                #region Anexo 2 Ponto de Encontro
                var tbane2 = new iTextSharp.text.pdf.PdfPTable(1);
                tbane2.DefaultCell.Border = 0;
                tbane2.HorizontalAlignment = 0;
                tbane2.WidthPercentage = 100.0F;
                tbane2.SetWidths(new float[] { 1.0F });
                tbane2.SpacingBefore = 10.0F;

                string anemsg = "Após o desembarque, prepare toda sua documentação, você passará pela Imigração Canadense (CBSA), " +
                    "dependendo do motivo da sua viagem(estudo, trabalho ou lazer) o tempo de espera pode ser longo. Após a sua liberação " +
                    "você irá resgatar as suas malas no Baggage Claim, a esteira será previamente informada pela cia aérea e demonstradas " +
                    "nos televisores de informações espalhados por todo o trajeto. Após a retirada das malas, siga os sinais de EXIT ou " +
                    "Public Greeting Area, logo após a porta automática estaremos aguardando atrás dos dois “Índios” conforme a foto abaixo, " +
                    "estaremos identificados com uniforme (camisa polo preta com a Logo Marca da Trip Services) e com uma placa com seu nome ou o nome do grupo.";


                tbane2.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("2.	PONTO DE ENCONTRO."), iTextSharp.text.FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD))));
                tbane2.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk((""), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL))));
                tbane2.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("A Trip Services possui um ponto de encontro para facilitar a sua vida."), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL))));
                tbane2.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk((""), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL))));
                tbane2.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk((""), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL))));

                tbane2.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("2.1.	Voos Internacionais (Voos vindo dos EUA, México ou qualquer outro país)"), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.BOLD))));
                tbane2.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk((anemsg), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL))));

                document.Add(tbane2);

                var tbane21 = new iTextSharp.text.pdf.PdfPTable(2);
                tbane21.DefaultCell.Border = 0;
                tbane21.HorizontalAlignment = 0;
                tbane21.WidthPercentage = 100.0F;
                tbane21.SetWidths(new float[] { 0.5F, 0.5F });
                tbane21.SpacingBefore = 10.0F;


                cell = imageCell("~/images/pdf/pontoencontro1.png", 100.0F, iTextSharp.text.pdf.PdfPCell.ALIGN_TOP, iTextSharp.text.pdf.PdfPCell.ALIGN_RIGHT, 0);
                tbane21.AddCell(cell);
                cell = imageCell("~/images/pdf/pontoencontro2.png", 100.0F, iTextSharp.text.pdf.PdfPCell.ALIGN_TOP, iTextSharp.text.pdf.PdfPCell.ALIGN_RIGHT, 0);
                tbane21.AddCell(cell);
                cell = imageCell("~/images/pdf/pontoencontro3.png", 100.0F, iTextSharp.text.pdf.PdfPCell.ALIGN_TOP, iTextSharp.text.pdf.PdfPCell.ALIGN_RIGHT, 0);
                tbane21.AddCell(cell);
                tbane21.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk((""), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL))));

                document.Add(tbane21);

                var tbane22 = new iTextSharp.text.pdf.PdfPTable(1);
                iTextSharp.text.Paragraph paragraph = null;
                tbane22.DefaultCell.Border = 0;
                tbane22.HorizontalAlignment = 0;
                tbane22.WidthPercentage = 100.0F;
                tbane22.SetWidths(new float[] { 1.0F });
                tbane22.SpacingBefore = 10.0F;

                string anemsg2 = "Após o desembarque, siga as placas do Baggage Claim, a esteira será previamente" +
                    " informada pela cia aérea e demonstradas nos televisores de informações espalhados por todo o" +
                    " trajeto. Após encontrar a sua esteira, gentileza apresentar-se a equipe da Trip Services que estará" +
                    " te esperando no murinho que separa os passageiros do público, em frente a esteira designada para o seu voo." +
                    " Estaremos sempre identificados com uniforme (camisa polo preta com a Logo Marca da Trip Services) e " +
                    "com uma placa com seu nome ou o nome do grupo, após o encontro teremos o prazer em lhe ajudar com a retirada" +
                    " das suas bagagens.";
                    

                tbane22.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk(("2.2.	Voos Domésticos (Voos vindo de Toronto ou qualquer outra cidade do Canadá)"), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.BOLD))));
                tbane22.AddCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk((anemsg2), iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL))));

                document.Add(tbane22);

                var tbane22f = new iTextSharp.text.pdf.PdfPTable(1);
                tbane22f.DefaultCell.Border = 0;
                tbane22f.HorizontalAlignment = 0;
                tbane22f.WidthPercentage = 100.0F;
                tbane22f.SetWidths(new float[] { 1.0F });
                tbane22f.SpacingBefore = 10.0F;

                cell = imageCell("~/images/pdf/voosdomesticos.png", 100.0F, iTextSharp.text.pdf.PdfPCell.ALIGN_TOP, iTextSharp.text.pdf.PdfPCell.ALIGN_CENTER, 0);
                tbane22f.AddCell(cell);

                document.Add(tbane22f);
                #endregion

                #region Footer

                //Footer--------------------------------------------------------------------------------
                var tbFooter = new iTextSharp.text.pdf.PdfPTable(3);
                tbFooter.DefaultCell.Border = 0;
                tbFooter.HorizontalAlignment = 0;
                tbFooter.WidthPercentage = 100.0F;
                tbDFinal.SetWidths(new float[] { 0.4F, 0.2F, 0.4F });
                tbFooter.SpacingBefore = 10.0F;

                //Logo
                cell = imageCell("~/images/bar.png", 50F, iTextSharp.text.pdf.PdfPCell.ALIGN_BASELINE, iTextSharp.text.pdf.PdfPCell.ALIGN_CENTER, 0);
                tbFooter.AddCell(cell);
                cell = imageCell("~/images/RodaPeContrato2.png", 20F, iTextSharp.text.pdf.PdfPCell.ALIGN_BASELINE, iTextSharp.text.pdf.PdfPCell.ALIGN_CENTER, 0);
                tbFooter.AddCell(cell);
                cell = imageCell("~/images/bar.png", 50F, iTextSharp.text.pdf.PdfPCell.ALIGN_BASELINE, iTextSharp.text.pdf.PdfPCell.ALIGN_CENTER, 0);
                tbFooter.AddCell(cell);

                document.Add(tbFooter);
                #endregion


                //close document
                document.Close();
                byte[] bytes = memoryStream.ToArray();
                memoryStream.Close();

                PDF_Created = true;
                Library.DisplayAtertBootstrap(this, "Created PDF for Transfer Id: " + TransferId, Library.MessageType.Success);
            }
            catch (Exception ex)
            {
                PDF_Created = false;
                //divMessageError.Visible = true;
                Library.DisplayAtertBootstrap(this, "No Created PDF: contact admin", Library.MessageType.Error);
                //lblMSG.Text = ex.ToString();
                throw;
            }


        }
        protected void Delete_PDF(string TransferId)
        {
            System.IO.File.Delete(Server.MapPath("~/temp/emailtransferid" + TransferId + ".PDF"));
            Library.DisplayAtertBootstrap(this, "No send email and Deleted PDF: Transfer Estimate ID # " + TransferId, Library.MessageType.Info);
        }
        private static void DrawLine(iTextSharp.text.pdf.PdfWriter writer, float x1, float y1, float x2, float y2, iTextSharp.text.BaseColor color)
        {
            iTextSharp.text.pdf.PdfContentByte contentByte = writer.DirectContent;
            // contentByte.SetColorStroke(color.White)
            contentByte.MoveTo(x1, y1);
            contentByte.LineTo(x2, y2);
            contentByte.Stroke();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="phrase">Texto</param>
        /// <param name="alignV">Alinhamento Vertical</param>
        /// <param name="alignH">Alinhamento Horizontal</param>
        /// <param name="border">Border</param>
        /// <param name="color"> 1 - red or 2 - black</param>
        /// <returns></returns>
        private iTextSharp.text.pdf.PdfPCell PhraseCell(string Text, int alignV, int alignH, int border, int color)
        {
            if (color == 1)
            {
                iTextSharp.text.pdf.PdfPCell cell = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk((Text), iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED))));
                cell.VerticalAlignment = alignV;
                cell.HorizontalAlignment = alignH;
                cell.Border = border;

                return cell;
            }
            else
            {
                iTextSharp.text.pdf.PdfPCell cell = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(new iTextSharp.text.Chunk((Text), iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK))));
                cell.VerticalAlignment = alignV;
                cell.HorizontalAlignment = alignH;
                cell.Border = border;

                return cell;
            }
        }
        private iTextSharp.text.pdf.PdfPCell imageCell(string path, float scale, int alignV, int alignH, int border)
        {
            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(HttpContext.Current.Server.MapPath(path));
            image.ScalePercent(scale);
            iTextSharp.text.pdf.PdfPCell cell = new iTextSharp.text.pdf.PdfPCell(image);
            cell.VerticalAlignment = alignV;
            cell.HorizontalAlignment = alignH;
            cell.Border = border;
            return cell;
        }
        #endregion

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }
    }
}