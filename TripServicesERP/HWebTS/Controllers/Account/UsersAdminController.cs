using HWebTS.Common.Identity.Configuration;
using HWebTS.Common.Identity.Context;
using HWebTS.Common.Identity.Users;
using HWebTS.Models;
using Microsoft.AspNet.Identity.Owin;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Linq;
using System.Net;
using System;

namespace HWebTS.Controllers.Account
{
    [Authorize(Roles = "Admin")]
    public class UsersAdminController : Controller
    {
        private atripservicesEntities db = new atripservicesEntities();
        AspNetUsers User = new AspNetUsers();

        private ApplicationUserManager _userManager;
        private ApplicationSignInManager _signInManager;
        private ApplicationRoleManager _roleManager;
        ApplicationDbContext context;

        //User Admin

        public UsersAdminController()
        {
            context = new ApplicationDbContext();
        }

        public UsersAdminController(ApplicationUserManager userManager)
        {
            UserManager = userManager;
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }

            private set
            {
                _signInManager = value;
            }

        }

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

        #region User Admin
        // GET: UserAdmin
        public async Task<ActionResult> Index()
        {
            return View(await UserManager.Users.ToListAsync());
        }

        //Get: User Profile
        public ActionResult Profile(string UserName)
        {
            string IdUser = "";

            if (UserName == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var dados = (from tx in db.AspNetUsers
                         where tx.UserName == UserName
                         select new
                         {
                             tx.Id

                         }).ToList();

            if (db != null)
            {
                foreach (var item in dados)
                {
                    if (item.Id != "")
                    { IdUser += Convert.ToDecimal(item.Id); }
                }
            }

            var user = UserManager.FindByIdAsync(IdUser);

            return View(user);
        }

        // GET: /Users/Details/5
        public async Task<ActionResult> UserProfile(string id)
        {
            string IdUser = "";

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var dados = (from tx in db.AspNetUsers
                         where tx.UserName == id
                         select new
                         {
                             tx.Id

                         }).ToList();

            if (db != null)
            {
                foreach (var item in dados)
                {
                    if (item.Id != "")
                    { IdUser = item.Id; }
                }
            }

            //var user = UserManager.FindByIdAsync(IdUser);

            //return View(user);


            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            var user = await UserManager.FindByIdAsync(IdUser);

            ViewBag.RoleNames = await UserManager.GetRolesAsync(user.Id);

            return View(user);
        }


        // GET: /Users/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var user = await UserManager.FindByIdAsync(id);

            ViewBag.RoleNames = await UserManager.GetRolesAsync(user.Id);

            return View(user);
        }

        //
        // GET: /Users/Create
        public async Task<ActionResult> Create()
        {
            //Get the list of Roles
            ViewBag.RoleId = new SelectList(await RoleManager.Roles.ToListAsync(), "Name", "Name");
            return View();
        }

        //
        // POST: /Users/Create
        [HttpPost]
        public async Task<ActionResult> Create(AspNetRegisterVM register, params string[] selectedRoles)
        {
            if (ModelState.IsValid)
            {

                var user = new ApplicationUser
                {
                    UserName = register.Alias,
                    FullName = register.FullName,
                    Email = register.Email,
                    UserImage = register.UserImage,
                    LastAccess = DateTime.Now
                };

                var result = await UserManager.CreateAsync(user, register.Password);

                if (result.Succeeded)
                {
                    //-------------------atribuir role ao user------------------------------
                    if (selectedRoles != null)
                    {
                        var roleresult = await UserManager.AddToRolesAsync(user.Id, selectedRoles);
                        if (!roleresult.Succeeded)
                        {
                            ModelState.AddModelError("", result.Errors.First());
                            ViewBag.RoleId = new SelectList(await RoleManager.Roles.ToListAsync(), "Name", "Name");
                            return View();
                        }
                    }
                    //-------------------atribuir role ao user------------------------------

                    await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);

                    return RedirectToAction("Index", "UsersAdmin");
                    //return RedirectToAction("Index", "UsersAdmin", new { area = "" });
                }
                else
                {
                    foreach (var erro in result.Errors)
                    {
                        ModelState.AddModelError("", erro);
                        ViewBag.RoleId = new SelectList(await RoleManager.Roles.ToListAsync(), "Name", "Name");
                    }

                    return View();
                }
            }
            return View();
        }

        // GET: /Users/Edit/1
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var user = await UserManager.FindByIdAsync(id);
            if (user == null)
            {
                return HttpNotFound();
            }

            var userRoles = await UserManager.GetRolesAsync(user.Id);

            return View(new EditUserViewModel()
            {
                Id = user.Id,
                Email = user.Email,
                FullName = user.FullName,
                UserImage = user.UserImage,
                RolesList = RoleManager.Roles.ToList().Select(x => new SelectListItem()
                {
                    Selected = userRoles.Contains(x.Name),
                    Text = x.Name,
                    Value = x.Name
                })
            });
        }

        //
        // POST: /Users/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Email,Id,FullName,UserImage")] EditUserViewModel editUser, params string[] selectedRole)
        {
            if (ModelState.IsValid)
            {
                var user = await UserManager.FindByIdAsync(editUser.Id);
                if (user == null)
                {
                    return HttpNotFound();
                }

                user.Email = editUser.Email;
                user.UserImage = editUser.UserImage;
                user.FullName = editUser.FullName;

                var userRoles = await UserManager.GetRolesAsync(user.Id);

                selectedRole = selectedRole ?? new string[] { };

                var result = await UserManager.AddToRolesAsync(user.Id, selectedRole.Except(userRoles).ToArray<string>());

                if (!result.Succeeded)
                {
                    ModelState.AddModelError("", result.Errors.First());
                    return View();
                }
                result = await UserManager.RemoveFromRolesAsync(user.Id, userRoles.Except(selectedRole).ToArray<string>());

                if (!result.Succeeded)
                {
                    ModelState.AddModelError("", result.Errors.First());
                    return View();
                }
                return RedirectToAction("Index", "UsersAdmin", new { area = "" });
            }
            ModelState.AddModelError("", "Something failed.");
            return View();
        }

        // GET: /Users/Edit/1
        public async Task<ActionResult> EditProfile(string UserName)
        {
            if (UserName == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var user = await UserManager.FindByNameAsync(UserName);
            if (user == null)
            {
                return HttpNotFound();
            }

            return View(new EditUserViewModel()
            {
                Id = user.Id,
                Email = user.Email,
                FullName = user.FullName,
                UserImage = user.UserImage,
            });
        }

        //
        // POST: /Users/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditProfile([Bind(Include = "Email,Id,FullName,UserImage")] EditUserViewModel editUser, params string[] selectedRole)
        {
            if (ModelState.IsValid)
            {
                var user = await UserManager.FindByNameAsync(editUser.Id);
                if (user == null)
                {
                    return HttpNotFound();
                }

                user.Email = editUser.Email;
                user.UserImage = editUser.UserImage;
                user.FullName = editUser.FullName;
               
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("", "Something failed.");
            return View();
        }

        public async Task<ActionResult> DeleteUser(string id)
        {

            if (ModelState.IsValid)
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }

                var user = await UserManager.FindByIdAsync(id);
                if (user == null)
                {
                    return HttpNotFound();
                }
                var result = await UserManager.DeleteAsync(user);
                if (!result.Succeeded)
                {
                    ModelState.AddModelError("", result.Errors.First());
                    return View();
                }
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
        #endregion

    }
}