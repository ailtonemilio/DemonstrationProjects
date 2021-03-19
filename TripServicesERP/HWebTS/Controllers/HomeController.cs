using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HWebTS.Models;
using Microsoft.AspNet.Identity;

namespace HWebTS.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
                if (User.Identity.IsAuthenticated)
                {
                    return View();
                }
                else
                {
                    return RedirectToAction("Login", "Account");
                }
            //return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
    }
}