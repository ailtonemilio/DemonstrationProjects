using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Globalization;
using System.Net;
using System.Net.Mail;
using System.IO;
using System.Text.RegularExpressions;

namespace HWebTS.Models
{
    public class Library
    {
        public Library()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public enum MessageType { Success, Error, Info, Warning };

        public static void CloseModalBootstrap(Page Pagina, string Modal)
        {
            ScriptManager.RegisterStartupScript(Pagina, Pagina.GetType(), System.Guid.NewGuid().ToString(), "Closepopup(" + Modal + ");", true);
        }
        public static void DisplayAtertSweet(Page Pagina, string Title, string Message, MessageType type)
        {
            string TypeMsg = "";

            switch (type)
            {
                case MessageType.Success:
                    TypeMsg = "success";
                    break;
                case MessageType.Error:
                    TypeMsg = "error";
                    break;
                case MessageType.Info:
                    TypeMsg = "info";
                    break;
                case MessageType.Warning:
                    TypeMsg = "warning";
                    break;
            }

            ScriptManager.RegisterStartupScript(Pagina, Pagina.GetType(), "Popup", "sweetalert('" + Title + "', '" + Message + "', '" + TypeMsg + "');", true);
        }
        public static void DisplayAtertBootstrap(Page Pagina, string Message, MessageType type)
        {
            ScriptManager.RegisterStartupScript(Pagina, Pagina.GetType(), System.Guid.NewGuid().ToString(), "ShowMessage('" + Message + "','" + type + "');", true);
        }

        //public static void DisplayAtertBootstrapMaster(MasterPage Pagina, string Message, MessageType type)
        //{
        //    ScriptManager.RegisterStartupScript(Pagina, Pagina.GetType(), System.Guid.NewGuid().ToString(), "ShowMessage('" + Message + "','" + type + "');", true);
        //}

        public static void DisplayAlert(Page Pagina, string MSG)
        {
            ScriptManager.RegisterStartupScript(Pagina, typeof(Page), Guid.NewGuid().ToString(), "alert('" + MSG.Replace("'", "\'") + "');", true);
        }

        public static void DisplayScript(Page Pagina, string script)
        {
            ScriptManager.RegisterStartupScript(Pagina, typeof(Page), Guid.NewGuid().ToString(), script.Replace("'", "\'"), true);
        }

        public static void DisplayScriptMaster(MasterPage Pagina, string script)
        {
            ScriptManager.RegisterStartupScript(Pagina, typeof(Page), Guid.NewGuid().ToString(), script.Replace("'", "\'"), true);
        }

        //public static void SummerNote(Page Pagina, string Obj)
        //{
        //    ScriptManager.RegisterStartupScript(Pagina, Pagina.GetType(), System.Guid.NewGuid().ToString(), "SummerNote(" + Obj + ");", true);
        //}

        //public static void funcMyHtml(Page Pagina, string Obj)
        //{
        //    ScriptManager.RegisterStartupScript(Pagina, Pagina.GetType(), System.Guid.NewGuid().ToString(), "funcMyHtml(" + Obj + ");", true);
        //}


        /// <summary>
        /// Abre Página em uma janela centralizada
        /// </summary>
        /// <param name="Pagina">This</param>
        /// <param name="URL">Endereço da página</param>
        /// <param name="Width">Comprimento do Browser do usuário está na Session["ScreenWidth"]</param>
        /// <param name="Heigth">Altura do Browser do usuário está na Session["ScreenHeight"]</param>
        /// <param name="PopUPWidth">Comprimento personalizável</param>
        /// <param name="PopUPHeigth">Altura Personalizavel</param>
        /// <param name="status">yes or no para habilitar no PopUp</param>
        /// <param name="scrollbars">yes or no para habilitar no PopUp</param>
        /// <param name="menubar">yes or no para habilitar no PopUp</param>
        /// 
        public static void PopUpCentral(Page Pagina, string URL, string Width, string Heigth, int PopUPWidth, int PopUPHeigth, string status, string scrollbars, string menubar)
        {
            int WidthLeft = (Convert.ToInt32(Width) - PopUPWidth) / 2;
            int HeigthTop = (Convert.ToInt32(Heigth) - PopUPHeigth) / 2;

            //string script = "window.open('" + URL + "','','status=yes, scrollbars=yes, menubar=yes, left=" + WidthLeft.ToString() + ",top=" + HeigthTop.ToString() + ",width=" + PopUPWidth.ToString() + ",height=" + PopUPHeigth.ToString() + "');";
            string script = "window.open('" + URL + "','','left=" + WidthLeft.ToString() + ",top=" + HeigthTop.ToString() + ",width=" + PopUPWidth.ToString() + ",height=" + PopUPHeigth.ToString() + ", status=" + status + ", scrollbars=" + scrollbars + ", menubar=" + menubar + "');";

            ScriptManager.RegisterStartupScript(Pagina, typeof(Page), Guid.NewGuid().ToString(), script.Replace("'", "\'"), true);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Pagina"></param>
        /// <param name="URL"></param>
        /// <param name="PopUPWidth"></param>
        /// <param name="PopUPHeigth"></param>
        public static void ModalPopUp(Page Pagina, string URL, int PopUPWidth, int PopUPHeigth)
        {
            string script = "window.showModalDialog(URL,'','DialogWidth='" + PopUPWidth.ToString() + "'px;DialogHeight='" + PopUPHeigth.ToString() + "'px;status=no;scrollbars=no;menubar=no');";
            ScriptManager.RegisterStartupScript(Pagina, typeof(Page), Guid.NewGuid().ToString(), script.Replace("'", "\'"), true);
        }

        public static void Atualizar(Page Pagina, string Funcao, string Tipo)
        {
            string jscript = "";
            jscript += "<script language='JavaScript'>";
            jscript += "window.opener." + Funcao + "('" + Tipo + "');window.close();";
            jscript += "</script>";

            Pagina.ClientScript.RegisterClientScriptBlock(Pagina.GetType(), "cliente", jscript);
        }

        /// <summary>
        /// Verifica se mobile pode acessar a página. Verifica também se o browser está atualizado para a versão 7 e qual a plataforma do browser
        /// </summary>
        /// <param name="Pagina">Informa a página a ser acessada</param>
        /// <param name="Coletor">Pode ser acessada pelo Coletor (Mobile)</param>
        /// <param name="URLErroMobile">Endereço de redirecionamento da página de erro mobile</param>
        /// <param name="URLAtualizaBrowser">Endereço da página de informação para atualizar o Browser</param>
        public static void Mobile(Page Pagina, bool Coletor, string URLErroMobile, string URLAtualizaBrowser)
        {
            bool Mobile = false;

            //Verifica se o browser é Mobile
            if (Pagina.Request.Browser.IsMobileDevice)
            {
                Mobile = true;
            }

            //Esta aplicação não pode ser usada no mobile ?
            if (Mobile != Coletor)
            {
                Pagina.Response.Redirect(URLErroMobile);
            }

            //Se não é para ser usado pelo coletor ele verifica se o browser está atualizado
            if (Coletor == false)
            {
                //Verifica o Browser e a versão
                if (Pagina.Request.Browser.Platform != "WinXP" & Pagina.Request.Browser.Platform != "WinNT")
                {
                    Pagina.Response.Redirect(URLAtualizaBrowser);
                }

                if (Convert.ToInt32(Pagina.Request.Browser.MajorVersion) < 7)
                {
                    Pagina.Response.Redirect(URLAtualizaBrowser);
                }
            }
        }
    }
}