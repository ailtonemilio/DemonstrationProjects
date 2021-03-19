using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HWebTS.Common.Identity.Configuration;
using HWebTS.Common.Identity.Users;
using HWebTS.Common.Identity.Context;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace HWebTS
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            string userName = Session["Name"] != null ? Session["Name"].ToString() : null;

            if (!Request.IsAuthenticated)
            {
                Response.Redirect("~/Account/Login");
            }


            if (String.IsNullOrEmpty(userName))
            {
                //Response.Redirect("~/pageerror/ErrorSession.aspx");
                Response.Redirect("~/Account/Login");
                
            }
            else
            {
                lblNameUser.Text = Session["Name"].ToString();
                ImageUser.Src = "images/users/" + Session["UserLog"].ToString();
            }
        }
        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Clear();
            Response.Redirect("~/Account/Logoff");
        }

        
        public static void AbandonSession()
        {
            HttpContext.Current.Session.Abandon();
        }
    }
}