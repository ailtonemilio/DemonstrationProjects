using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using WebInvoiceApp.Common.Identity.Context;
using WebInvoiceApp.Common.Identity.Configuration;
using WebInvoiceApp.UI.Web.Models.ViewModels;
using WebInvoiceApp.Common.Identity.Users;
using System.Net;

namespace WebInvoiceApp.UI.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RoleController : Controller
    {
        ApplicationDbContext context;

        public RoleController()
        {
            context = new ApplicationDbContext();
        }

        public RoleController(ApplicationUserManager userManager,
            ApplicationRoleManager roleManager)
        {
            UserManager = userManager;
            RoleManager = roleManager;
        }

        private ApplicationUserManager _userManager;
        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            set
            {
                _userManager = value;
            }
        }

        private ApplicationRoleManager _roleManager;
        public ApplicationRoleManager RoleManager
        {
            get
            {
                return _roleManager ?? HttpContext.GetOwinContext().Get<ApplicationRoleManager>();
            }
            private set
            {
                _roleManager = value;
            }
        }

        public ActionResult Index()
        {
            var Roles = context.Roles.ToList();
            return View(Roles);
        }

        public ActionResult ListRole()
        {
            var Roles = context.Roles.ToList();
            return View(Roles);
        }

        public ActionResult Create()
        {
            var Role = new IdentityRole();
            return View(Role);
        }

        [HttpPost]
        public ActionResult Create(IdentityRole Role)
        {
                context.Roles.Add(Role);
                context.SaveChanges();
                return RedirectToAction("Index", "UsersAdmin", new { area = "" });
        }

        //
        // GET: /Roles/Create
        public ActionResult CreateRole()
        {
            return View();
        }

        //
        // POST: /Roles/Create
        [HttpPost]
        public async Task<ActionResult> CreateRole(EditRoleViewModel roleViewModel)
        {
            if (ModelState.IsValid)
            {
                var role = new IdentityRole(roleViewModel.Name);
                var roleresult = await RoleManager.CreateAsync(role);
                if (!roleresult.Succeeded)
                {
                    ViewBag.Message = "errorrole!";
                    //return RedirectToAction("Index", "UsersAdmin", new { area = "Admin" });
                    return RedirectToAction("Index", "UsersAdmin", new { area = "Admin" });
                }
                //return View();
                return RedirectToAction("Index", "UsersAdmin", new { area = "Admin" });
                //return RedirectToAction("Index", "UsersAdmin", "Admin");
            }
            return View();
        }

        //
        // POST: /Roles/Create
        [HttpPost]
        public async Task<ActionResult> CreateRoleSimple(EditRoleViewModel roleViewModel)
        {
            if (ModelState.IsValid)
            {
                var role = new IdentityRole(roleViewModel.Name);
                var roleresult = await RoleManager.CreateAsync(role);
                if (!roleresult.Succeeded)
                {
                    ModelState.AddModelError("", roleresult.Errors.First());
                    ViewBag.Message = "errorrole!";
                    //return RedirectToAction("Index", "UsersAdmin", new { area = "Admin" });
                    return View("Index", "UsersAdmin", new { area = "Admin" });
                }
                //return View();
                return RedirectToAction("Index", "UsersAdmin", new { area = "Admin" });
                //return RedirectToAction("Index", "UsersAdmin", "Admin");
            }
            return View();
        }

        public async Task<ActionResult> DeleteRole(string id)
        {
            if (ModelState.IsValid)
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                var role = await RoleManager.FindByIdAsync(id);
                if (role == null)
                {
                    return HttpNotFound();
                }
                IdentityResult result;
                result = await RoleManager.DeleteAsync(role);
                if (!result.Succeeded)
                {
                    ModelState.AddModelError("", result.Errors.First());
                    return View();
                }
                return RedirectToAction("Index", "UsersAdmin", new { area = "Admin" });
            }
            return RedirectToAction("Index", "UsersAdmin", new { area = "Admin" });
        }

        public JsonResult DelRole(string id)
        {

            return Json(new { success = true });
        }
    }
}