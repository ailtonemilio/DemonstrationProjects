using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using HWebTS.Common;

namespace HWebTS
{
    public partial class MainV3 : System.Web.UI.MasterPage
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            IdentityDbContext context = new IdentityDbContext();

            if (!context.Roles.Any(r => r.Name == "Admin"))
            {
                Session["RoleAdmin"] = "true";
            }
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
                //lblNameUser.Text = Session["Name"].ToString();
                ImageUser.Src = "images/users/" + Session["UserLog"].ToString();
            }
        }
    }
}