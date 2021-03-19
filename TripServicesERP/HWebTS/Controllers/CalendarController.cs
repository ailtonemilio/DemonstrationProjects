using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HWebTS.Models;
using System.Data.Entity.Migrations;

namespace HWebTS.Controllers
{
    [Authorize(Roles = "Admin,Driver")]
    public class CalendarController : Controller
    {
        // GET: Calendar
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

        public JsonResult GetEvents()
        {
            using (atripservicesEntities dc = new atripservicesEntities())
            {
                var events = dc.Events.ToList();
                return new JsonResult { Data = events, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
        }

        [HttpGet]
        public JsonResult SaveEvent2(string EventID, string Subject, string Start, string End, string Description, string ThemeColor, string IsFullDay, string IdTransEst)
        {
            var status = false;
            using (atripservicesEntities dc = new atripservicesEntities())
            {
                if (Convert.ToInt32(EventID) > 0)
                {
                    //Update the event
                    var v = dc.Events.Where(a => a.EventID == Convert.ToInt32(EventID)).FirstOrDefault();
                    if (v != null)
                    {
                        v.Subject = Subject;
                        v.Start = Convert.ToDateTime(Start);
                        v.End = Convert.ToDateTime(End);
                        v.Description = Description;
                        v.IsFullDay = Convert.ToBoolean(IsFullDay);
                        v.ThemeColor = ThemeColor;
                        v.IdTransEst = Convert.ToInt32(IdTransEst);

                        dc.Events.AddOrUpdate(v);
                        status = true;
                    }
                }
                else
                {
                    //dc.Events.Add(e);
                }

                dc.SaveChanges();
                //status1 = true;

            }
            //return new JsonResult { Data = new { status = status1 } };
            return Json(new { success = true, status }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult SaveEvent(Event e)
        {
            var status1 = false;
            using (atripservicesEntities dc = new atripservicesEntities())
            {
                if (e.EventID > 0)
                {
                    //Update the event
                    var v = dc.Events.Where(a => a.EventID == e.EventID).FirstOrDefault();
                    if (v != null)
                    {
                        v.Subject = e.Subject;
                        v.Start = e.Start;
                        v.End = e.End;
                        v.Description = e.Description;
                        v.IsFullDay = e.IsFullDay;
                        v.ThemeColor = e.ThemeColor;
                        v.IdTransEst = e.IdTransEst;
                    }
                }
                else
                {
                    dc.Events.Add(e);
                }

                dc.SaveChanges();
                status1 = true;

            }
            return new JsonResult { Data = new { status = status1 } };
        }

        [HttpPost]
        public JsonResult DeleteEvent(int eventID)
        {
            var status = false;
            using (atripservicesEntities dc = new atripservicesEntities())
            {
                var v = dc.Events.Where(a => a.EventID == eventID).FirstOrDefault();
                if (v != null)
                {
                    dc.Events.Remove(v);
                    dc.SaveChanges();
                    status = true;
                }
            }
            return new JsonResult { Data = new { status = status } };
        }
    }
}