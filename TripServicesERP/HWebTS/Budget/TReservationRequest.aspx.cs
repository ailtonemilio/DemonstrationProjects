using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HWebTS.Models;
using System.Data;
//Auto complete
using System.Web.Services;
using System.Configuration;
using System.Data.SqlClient;


namespace HWebTS.Budget
{
    public partial class TReservationRequest : System.Web.UI.Page
    {
        decimal FinalPrice = 0;
        bool SameCity = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadTypeVisa(ddlTypeVisa, "PT");
                LoadPriciesCity(ddlCityTo, "0");
                LoadPriciesCity(ddlCityFrom, "0");
                LoadTypetransfer(ddlTypeTransfer, "PT");
                LoadTypeDestination(ddlTypeDestination, "0");
                Translate("PT");
                //Session["IP"] = Request.UserHostAddress;
                //Library.DisplayAtertBootstrap(this, Session["IP"].ToString(), Library.MessageType.Info);
            }
        }

        #region Metodos
        protected void Translate(string Language)
        {
            switch (Language)
            {
                case "EN":
                    //Titulo pagina
                    lblReservationRequest.Text = "Reservation Request";

                    //Titulo das Etapas
                    lblPassengerInformation.Text = "Passenger Information";
                    lblTransferInformation.Text = "Transfer Information";
                    lblVooInformation.Text = "Voo Information";
                    lblDestinationInformation.Text = "Destination / Origin";

                    //Phases
                    //Passageiro
                    lblPasengerName.Text = "Passenger Name:";
                    lblTypeVisa.Text = "Type Visa:";
                    LoadTypeVisa(ddlTypeVisa, "EN");
                    lblPhonePassenger.Text = "Phone:";

                    //Transfer Information
                    LoadTypetransfer(ddlTypeTransfer, "EN");
                    lblTransferType.Text = "Transfer Type:";
                    lblDateTransfer.Text = "Date Transfer (MM/DD/YYYY):";
                    lblDateTime.Text = "Time:";
                    lblPassenger.Text = "Passenger:";
                    lblLuggage.Text = "Luggage:";
                    lblCarryon.Text = "Carry-on:";
                    lblOtherTypes.Text = "Other Types:";

                    //Voo Information
                    lblFlightNumber.Text = "Flight Number:";
                    lblDateVoo.Text = "Date Voo (MM/DD/YYYY):";
                    lblTimeVoo.Text = "Time Voo:";

                    //Destination
                    lblTypeDestination.Text = "Type Destination:";
                    lblNameDestination.Text = "Name/Destination:";
                    lblPhoneContact.Text = "Phone:";
                    lblAddress.Text = "Address:";
                    lblCityTo.Text = "City:";
                    lblProvince.Text = "Province";
                    lblCountry.Text = "Country";
                    lblPostalCode.Text = "Postal Code";

                    //Validators
                    rfvEmail.ErrorMessage = "Field is empty";
                    rfvNamePassenger.ErrorMessage = "Field is empty";
                    rfvPhonePassenger.ErrorMessage = "Field is empty";
                    revEmail.ErrorMessage = "Please enter corect email";
                    rfvDateEstimate.ErrorMessage = "Field is empty";
                    rfvFlightNumber.ErrorMessage = "Field is empty";
                    rfvDateVoo.ErrorMessage = "Field is empty";
                    rfvTimeVoo.ErrorMessage = "Field is empty";
                    rfvNameDestination.ErrorMessage = "Field is empty";
                    rfvPhoneContact.ErrorMessage = "Field is empty";
                    rfvAddress.ErrorMessage = "Field is empty";
                    rfvTimeEstimate.ErrorMessage = "Field is empty";

                    //Botões

                    lblSend.Text = "Send";
                    lblCancel.Text = "Cancel";

                    break;
                case "PT":
                    //Titulo pagina
                    lblReservationRequest.Text = "Solicitação de Reserva";

                    //Titulo das Etapas
                    lblPassengerInformation.Text = "Informações do Passageiro";
                    lblTransferInformation.Text = "Informações do Transfer";
                    lblVooInformation.Text = "Informações do Voo";
                    lblDestinationInformation.Text = "Destino / Origem";

                    //Phases
                    //Passageiro
                    lblPasengerName.Text = "Nome do Passageiro:";
                    lblTypeVisa.Text = "Tipo de Visto:";
                    LoadTypeVisa(ddlTypeVisa, "PT");
                    lblPhonePassenger.Text = "Telefone:";

                    //Transfer Information
                    LoadTypetransfer(ddlTypeTransfer, "PT");
                    lblTransferType.Text = "Tipo do Transfer:";
                    lblDateTransfer.Text = "Data Transfer (MM/DD/YYYY):";
                    lblDateTime.Text = "Hora:";
                    lblPassenger.Text = "Passageiros Acima de 12 anos:";
                    lblKids.Text = "Passageiros até 12 anos";
                    lblLuggage.Text = "Qt Bagagem:";
                    lblCarryon.Text = "Qt Bagagem de Mão:";
                    lblOtherTypes.Text = "Outros Tipos / Observação:";

                    //Voo Information
                    lblFlightNumber.Text = "Número do Voo:";
                    lblDateVoo.Text = "Data do Voo (MM/DD/YYYY):";
                    lblTimeVoo.Text = "Hora do Voo:";

                    //Destination
                    lblTypeDestination.Text = "Tipo de Destino:";
                    lblNameDestination.Text = "Nome/Contato:";
                    lblPhoneContact.Text = "Telefone:";
                    lblAddress.Text = "Endereço:";
                    lblCityFrom.Text = "Cidade";
                    lblCityTo.Text = "Cidade";
                    ddlCityTo.Text = "Cidade:";
                    lblProvince.Text = "Provincia:";
                    lblCountry.Text = "País";
                    lblPostalCode.Text = "Codigo Postal:";

                    //Validators
                    rfvEmail.ErrorMessage = "Campo está em vazio";
                    rfvNamePassenger.ErrorMessage = "Campo está em vazio";
                    rfvPhonePassenger.ErrorMessage = "Campo está em vazio";
                    revEmail.ErrorMessage = "Por favor, entre com o email correto";
                    rfvDateEstimate.ErrorMessage = "Campo está em vazio";
                    rfvFlightNumber.ErrorMessage = "Campo está em vazio";
                    rfvDateVoo.ErrorMessage = "Campo está em vazio";
                    rfvTimeVoo.ErrorMessage = "Campo está em vazio";
                    rfvNameDestination.ErrorMessage = "Campo está em vazio";
                    rfvPhoneContact.ErrorMessage = "Campo está em vazio";
                    rfvAddress.ErrorMessage = "Campo está em vazio";
                    rfvTimeEstimate.ErrorMessage = "Campo está em vazio";

                    //Botões
                    lblSend.Text= "Enviar";
                    lblCancel.Text = "Cancelar";
                    break;
                case "ES":
                    //Titulo pagina
                    lblReservationRequest.Text = "Solicitud de Reserva";

                    //Titulo das Etapas
                    lblPassengerInformation.Text = "Información del pasajero";
                    lblTransferInformation.Text = "Transferir informacion";
                    lblVooInformation.Text = "Información Voo";
                    lblDestinationInformation.Text = "Destino / Origen";

                    //Phases
                    //Passageiro
                    lblPasengerName.Text = "Nombre del pasajero:";
                    lblTypeVisa.Text = "Type Visa:";
                    LoadTypeVisa(ddlTypeVisa, "ES");
                    lblPhonePassenger.Text = "Teléfono:";

                    //Transfer Information
                    LoadTypetransfer(ddlTypeTransfer, "ES");
                    lblTransferType.Text = "Tipo de transferencia:";
                    lblDateTransfer.Text = "Fecha de transferencia (MM/DD/YYYY):";
                    lblDateTime.Text = "Hora:";
                    lblPassenger.Text = "Pasajero:";
                    lblLuggage.Text = "Equipaje:";
                    lblCarryon.Text = "El equipaje de mano:";
                    lblOtherTypes.Text = "Otros tipos:";

                    //Voo Information
                    lblFlightNumber.Text = "Número de vuelo:";
                    lblDateVoo.Text = "Fecha voo (MM/DD/YYYY):";
                    lblTimeVoo.Text = "Hora Voo:";

                    //Destination
                    lblTypeDestination.Text = "Tipo Destino:";
                    lblNameDestination.Text = "Nombre/Destino:";
                    lblPhoneContact.Text = "Teléfono:";
                    lblAddress.Text = "Dirección:";
                    ddlCityTo.Text = "Ciudad:";
                    lblProvince.Text = "Provincia:";
                    lblPostalCode.Text = "Código postal:";
                    lblCountry.Text = "País";

                    //Validators
                    rfvEmail.ErrorMessage = "Campo esta vacio";
                    rfvNamePassenger.ErrorMessage = "Campo esta vacio";
                    rfvPhonePassenger.ErrorMessage = "Campo esta vacio";
                    revEmail.ErrorMessage = "Por favor ingrese el correo electrónico correcto";
                    rfvDateEstimate.ErrorMessage = "Campo esta vacio";
                    rfvFlightNumber.ErrorMessage = "Campo esta vacio";
                    rfvDateVoo.ErrorMessage = "Campo esta vacio";
                    rfvTimeVoo.ErrorMessage = "Campo esta vacio";
                    rfvNameDestination.ErrorMessage = "Campo esta vacio";
                    rfvPhoneContact.ErrorMessage = "Campo esta vacio";
                    rfvAddress.ErrorMessage = "Campo esta vacio";
                    rfvTimeEstimate.ErrorMessage = "Campo esta vacio";

                    //Botões
                    lblSend.Text = "Enviar ";
                    lblCancel.Text = "Cancelar";
                    break;
            }
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
        protected void LoadTypeVisa(DropDownList TypeVisa, string Language)
        {
            TypeVisa.Items.Clear();

            atripservicesEntities DBTrip = new atripservicesEntities();
            var dados = (from p in DBTrip.TypeVisa
                         select p).ToList<TypeVisa>();

            if (DBTrip != null)
            {
                foreach (var item in dados)
                {
                    if (Language == "EN")
                    {
                        TypeVisa.Items.Add(new ListItem(item.DescTypeVisa, item.IdTypeVisa.ToString()));
                    }
                    else
                    {
                        TypeVisa.Items.Add(new ListItem(Visa(Language, item.IdTypeVisa), item.IdTypeVisa.ToString()));
                    }
                }
            }
        }
        protected void LoadTypetransfer(DropDownList TypeTrans, string Language)
        {
            TypeTrans.Items.Clear();

            atripservicesEntities DBTrip = new atripservicesEntities();
            var dados = (from p in DBTrip.TypeTransfer
                         select p).ToList<TypeTransfer>();

            if (DBTrip != null)
            {
                foreach (var item in dados)
                {
                    if(item.DescType != "Open")
                    {
                        if (Language == "EN")
                        {
                            TypeTrans.Items.Add(new ListItem(item.DescType, item.IdTypeTransfer.ToString()));
                        }
                        else
                        {
                            TypeTrans.Items.Add(new ListItem(TypeTransfer(Language, item.IdTypeTransfer), item.IdTypeTransfer.ToString()));
                        }
                    }
                }
            }
        }
        protected void LoadTypeDestination(DropDownList typeDestination, string IdTypeDes)
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
        protected string TypeTransfer(string Language, int IdTypeTransfer)
        {
            string TTransfer = "";

            if (Language == "PT")
            {
                switch (IdTypeTransfer)
                {
                    case 1:
                        TTransfer = "Transfer de Chegada";
                        break;
                    case 2:
                        TTransfer = "Transfer de Saída";
                        break;
                    case 3:
                        TTransfer = "Ponto a Ponto";
                        break;
                    case 4:
                        TTransfer = "Relocação";
                        break;
                }
            }
            else
            {
                switch (IdTypeTransfer)
                {
                    case 1:
                        TTransfer = "Recoger";
                        break;
                    case 2:
                        TTransfer = "Bajar";
                        break;
                    case 3:
                        TTransfer = "Punto a punto";
                        break;
                    case 4:
                        TTransfer = "Reubicación";
                        break;
                }
            }

            return TTransfer;
        }
        protected string Visa(string Language, int IdVisa)
        {
            string TypeVisa = "";

            if (Language == "PT")
            {
                switch (IdVisa)
                {
                    case 1:
                        TypeVisa = "ETA";
                        break;
                    case 2:
                        TypeVisa = "Turismo";
                        break;
                    case 3:
                        TypeVisa = "Permissão de Estudo";
                        break;
                    case 4:
                        TypeVisa = "Permissão de Trabalho";
                        break;
                    case 5:
                        TypeVisa = "PR";
                        break;
                    case 6:
                        TypeVisa = "Passaporte Europeu";
                        break;
                }
            }
            else
            {
                switch (IdVisa)
                {
                    case 1:
                        TypeVisa = "ETA";
                        break;
                    case 2:
                        TypeVisa = "Turismo";
                        break;
                    case 3:
                        TypeVisa = "Permiso para Estudiar";
                        break;
                    case 4:
                        TypeVisa = "Permiso de Trabajo";
                        break;
                    case 5:
                        TypeVisa = "PR";
                        break;
                    case 6:
                        TypeVisa = "Pasaporte Europeo";
                        break;
                }
            }

            return TypeVisa;
        }

        protected void CalculateFinalPrice(string IdCityFrom, string IdCityTo, string qtyPass, string qtyLugagge, string qtyCarryon)
        {
            atripservicesEntities ctx = new atripservicesEntities();

            FinalPrice = 0;

            decimal POne = 0;
            decimal PTwo = 0;
            decimal qtypassenger = Convert.ToDecimal(qtyPass);
            decimal qtyMalaGr = Convert.ToDecimal(qtyLugagge);
            decimal qtyMalaPq = Convert.ToDecimal(qtyCarryon);
            decimal MaxMalaGr = 0;
            decimal MaxMalaPq = 0;
            decimal TotalMala = 0;
            decimal TotalPass = 0;
            decimal DescSalesChannel = 0;
            decimal TranferAmount = 0;
            string IdCity = "";
            int id = 0;
            //bool SalesChannel = false;

            if (String.IsNullOrEmpty(IdCityFrom) || String.IsNullOrEmpty(IdCityTo))
            {
                Library.DisplayAtertSweet(this, "O campo Cidade está!", "Por favor verifique a cidade!", Library.MessageType.Info);
                //Library.DisplayAtertSweet(this, "City is Empty!", "There are no cities for this sales channel!", Library.MessageType.Info);
                return;
            }

            if (IdCityFrom == IdCityTo)
            {
                Library.DisplayAtertSweet(this, "Verificar Cidade de Destino!", "A cidade de destino não pede ser a mesma do Transfer!", Library.MessageType.Info);
                SameCity = true;
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
            
            FinalPrice = TranferAmount;
        }
        protected bool VerifyLastIP(string IP)
        {
            bool DubleIP = false;

            atripservicesEntities DB = new atripservicesEntities();

            var dados = DB.LastIPReservation
                        .Where(p => p.IP.Contains(IP)).ToList();

            if (dados.Count == 0)
            { DubleIP = true; }

            return DubleIP;
        }
        protected void DeleteLastIdYesterday()
        {
            atripservicesEntities DB = new atripservicesEntities();

            var dt = DateTime.Now.AddDays(-1);

            DB.LastIPReservation.RemoveRange(DB.LastIPReservation.Where(p => p.DateReservation < dt));
            DB.SaveChanges();
        }

        protected void SaveTranferTestimate()
        {
            atripservicesEntities DBTrip = new atripservicesEntities();
            TransferEstimate te = new TransferEstimate();
            Passenger pa = new Passenger();
            ReservationRequest rr = new ReservationRequest();
            LastIPReservation ip = new LastIPReservation();

            DeleteLastIdYesterday();

            if (VerifyLastIP(Request.UserHostAddress.ToString()) == false)
            {
                Library.DisplayAtertSweet(this, "Você já pediu uma reserva!", "Aguarde seu pedido ser processado, logo lhe enviaremos um email.", Library.MessageType.Info);
                return;
            }

            //Transfer Estimate
            te.FlightNumber = txtFlightNumber.Text.ToUpper();
            if (!String.IsNullOrEmpty(txtDateVoo.Text)) { te.DateFligh = Convert.ToDateTime(txtDateVoo.Text); } else { te.DateFligh = null; }
            if (!String.IsNullOrEmpty(txtTimeVoo.Text)) { te.TimeFligh = txtTimeVoo.Text; } else { te.TimeFligh = null; }
            if (!String.IsNullOrEmpty(txtTime.Text)) { te.TimePiDo = txtTime.Text; } else { te.TimePiDo = null; }
            if (!String.IsNullOrEmpty(txtDateEstimate.Text)) { te.DateTransEst = Convert.ToDateTime(txtDateEstimate.Text); } else { te.DateTransEst = null; }
            te.DateAprove = null;
            te.DateRequestEstimate = DateTime.Now;
            te.Discount = 0;
            te.IdMetingPoint = 1;
            te.QtyPassenger = Convert.ToInt32(ddlQtyPassenger.SelectedValue);
            te.QtyPassengerKids = Convert.ToInt32(ddlQtyKids.SelectedValue); 
            te.QtyMalaGr = Convert.ToInt32(ddlQtyLuggage.SelectedValue);

            te.QtyMalaPq = Convert.ToInt32(ddlQtyCarryon.SelectedValue);
            te.CityFromId = 1;
            te.CityToId = Convert.ToInt32(ddlCityTo.SelectedValue);
            te.TransferAmount = 0;
            te.Discount = null;

            te.FinalPrice = FinalPrice;

            te.NamePassenger = txtNamePassenger.Text;
            te.Phone = txtPhonePassenger.Text;
            te.Phone2 = "";
            te.Email = txtEmailPassenger.Text;
            te.TypeVisa = ddlTypeVisa.SelectedItem.ToString();

            te.Note = "Reservation Request";
            te.IdAprove = 0;
            te.IdTypeDestination = Convert.ToInt32(ddlTypeDestination.SelectedValue);
            te.IdDestination = 1;
            te.IdSales = 1;
            te.IdTypeTransfer = Convert.ToInt32(ddlTypeTransfer.SelectedValue);
            te.IdTypePayment = 0;
            te.IdStatusPayment = 0;

            DBTrip.TransferEstimate.Add(te);
            DBTrip.SaveChanges();

            var idte = te.IdTransEst;
            
            //Verify IP
            ip.IP = Request.UserHostAddress.ToString();
            ip.DateReservation = DateTime.Now;

            DBTrip.LastIPReservation.Add(ip);
            DBTrip.SaveChanges();

            //Passenger
            pa.Name = txtNamePassenger.Text;
            pa.Phone = txtPhonePassenger.Text;
            pa.Phone2 = "";
            pa.Email = txtEmailPassenger.Text;
            pa.IdTypeVisa = Convert.ToInt32(ddlTypeVisa.SelectedValue);

            DBTrip.Passenger.Add(pa);
            DBTrip.SaveChanges();

            var idpa = pa.IdPassenger;

            //Reservation Request (Destination)
            rr.NamePD = txtNameDestination.Text;
            rr.AddressPD = txtAddress.Text;
            rr.PostalCodePD = txtPostalCode.Text;
            rr.PhonePD = txtPhoneContact.Text;
            rr.MobilePD = "";
            rr.IdCityPD = Convert.ToInt32(ddlCityTo.SelectedValue);
            rr.IdTypeDestinationPD = Convert.ToInt32(ddlTypeDestination.SelectedValue);
            rr.IdPassenger = idpa;
            rr.IdTransferEst = idte;
            
            DBTrip.ReservationRequest.Add(rr);
            DBTrip.SaveChanges();

            ClearReservation();

            if (lblSend.Text == "Send")
            {
                Library.DisplayAtertSweet(this, "Success!", "Your reservation request was sent successfully! Wait for our contact.", Library.MessageType.Success);
            }

            if (lblSend.Text == "Enviar")
            {
                Library.DisplayAtertSweet(this, "Pedido Enviado!", "Seu pedido de reserva foi enviado com sucesso! Aguarde nosso contato.", Library.MessageType.Success);
            }

            if (lblSend.Text == "Enviar ")
            {
                Library.DisplayAtertSweet(this, "Éxito!", "Su solicitud de reserva fue enviada con éxito! Espera nuestro contacto.", Library.MessageType.Success);
            }
            ClearReservation();
        }
       
        protected void ClearReservation()
        {
            txtAddress.Text = "";
            txtDateEstimate.Text = "";
            txtDateVoo.Text = "";
            txtEmailPassenger.Text = "";
            txtFlightNumber.Text = "";
            txtNameDestination.Text = "";
            txtNamePassenger.Text = "";
            txtOtherTypes.Text = "";
            txtPhoneContact.Text = "";
            txtPhonePassenger.Text = "";
            txtPostalCode.Text = "";
            txtTime.Text = "";
            txtTimeVoo.Text = "";
        }
        #endregion

        #region Buttons
        protected void btnTranslateEspanish_Click(object sender, EventArgs e)
        {
            Translate("ES");
        }

        protected void btnTranslateEnglish_Click(object sender, EventArgs e)
        {
            Translate("EN");
        }
        protected void btnTranslateBrazil_Click(object sender, EventArgs e)
        {
            Translate("PT");
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            CalculateFinalPrice(ddlCityFrom.SelectedValue, ddlCityTo.SelectedValue, ddlQtyPassenger.SelectedValue, ddlQtyLuggage.SelectedValue, ddlQtyCarryon.SelectedValue);
            if(SameCity == false) { SaveTranferTestimate(); }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}