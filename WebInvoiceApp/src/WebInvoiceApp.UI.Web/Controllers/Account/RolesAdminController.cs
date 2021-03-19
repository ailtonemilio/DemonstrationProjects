using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.EntityFramework;
using WebInvoiceApp.Common.Identity.Context;
using System.Threading.Tasks;
using System.Net;
using Microsoft.AspNet.Identity;
using WebInvoiceApp.Common.Identity.Configuration;
using Microsoft.AspNet.Identity.Owin;
using WebInvoiceApp.UI.Web.Models.ViewModels;
using WebInvoiceApp.Common.Identity.Users;
using System.Collections.Generic;

namespace WebInvoiceApp.UI.Web.Controllers.Account
{
    [Authorize(Roles = "Admin")]
    public class RolesAdminController : Controller
    {
        ApplicationDbContext context;

        public RolesAdminController()
        {
            context = new ApplicationDbContext();
        }

        public RolesAdminController(ApplicationUserManager userManager,
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

        // GET: RolesAdmin
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

        public ActionResult ListRole2()
        {
            var Roles = context.Roles.ToList();
            return View(Roles);

        }

        [HttpGet]
        public async Task<ActionResult> GetRole(string Id)
        {
            bool resp = false;
            string name = "", id = "";

            var role = await RoleManager.FindByIdAsync(Id);
            name = role.Name;
            id = role.Id;

            if(role.Name != null)
            { resp = true; }
            
            return Json(new { success = resp, name, id },
               JsonRequestBehavior.AllowGet);
        }

        //
        // GET: /Roles/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var role = await RoleManager.FindByIdAsync(id);
            // Get the list of Users in this Role
            var users = new List<ApplicationUser>();

            // Get the list of Users in this Role
            foreach (var user in UserManager.Users.ToList())
            {
                if (await UserManager.IsInRoleAsync(user.Id, role.Name))
                {
                    users.Add(user);
                }
            }

            ViewBag.Users = users;
            ViewBag.UserCount = users.Count();
            return View(role);
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
                    ModelState.AddModelError("", roleresult.Errors.First());
                    return View();
                }
                return Json(new { success = true, role }, JsonRequestBehavior.AllowGet);
            }
            return View();
        }

        public async Task<ActionResult> CreateRoleName(string Name)
        {
            var role = new IdentityRole(Name);
            var roleresult = await RoleManager.CreateAsync(role);
            if (!roleresult.Succeeded)
            {
                ModelState.AddModelError("", roleresult.Errors.First());
                return View();
            }

            return Json(new { success = true, role }, JsonRequestBehavior.AllowGet);
        }


        //
        // GET: /Roles/Edit/Admin
        public async Task<ActionResult> Edit(string id)
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
            EditRoleViewModel roleModel = new EditRoleViewModel { Id = role.Id, Name = role.Name };
            return View(roleModel);
        }

        //
        // POST: /Roles/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Name,Id")] EditRoleViewModel roleModel)
        {
            if (ModelState.IsValid)
            {
                var role = await RoleManager.FindByIdAsync(roleModel.Id);
                role.Name = roleModel.Name;
                await RoleManager.UpdateAsync(role);
                return RedirectToAction("Index");
            }
            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> EditRole(string Name, string Id)
        {
            string issuccess = "true";

            if (ModelState.IsValid)
            {
                var role = await RoleManager.FindByIdAsync(Id);
                role.Name = Name;
                var roleresult = await RoleManager.UpdateAsync(role);
                if (!roleresult.Succeeded)
                {
                    ModelState.AddModelError("", roleresult.Errors.First());
                    issuccess = "false";
                }
                
                return Json(new { success = true, issuccess }, JsonRequestBehavior.AllowGet);

            }
            return Json(new { success = false, issuccess }, JsonRequestBehavior.AllowGet);
        }

        public async Task<ActionResult> Delete(string id)
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
                return View();
            }
            return View();

        }

        public async Task<ActionResult> DeleteRole(string id)
        {
            bool deleteok = false;
            string deleted = "";

            if (ModelState.IsValid)
            {
                if (id != null)
                {
                    var role = await RoleManager.FindByIdAsync(id);
                    if (role == null)
                    {
                        deleteok = false;
                    }
                    else
                    {
                        IdentityResult result;
                        result = await RoleManager.DeleteAsync(role);
                        if (!result.Succeeded)
                        {
                            ModelState.AddModelError("", result.Errors.First());
                            deleteok = false;
                        }
                        else
                        {
                            deleteok = true;
                            deleted = "true";
                        }
                    }
                    
                }
                else
                {
                    deleteok = false;
                }
            }

            return Json(new { success = deleteok, deleted },
               JsonRequestBehavior.AllowGet);
        }
    }
}