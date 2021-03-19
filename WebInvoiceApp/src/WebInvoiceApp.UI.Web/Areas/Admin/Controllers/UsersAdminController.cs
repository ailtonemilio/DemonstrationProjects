using WebInvoiceApp.Common.Identity.Configuration;
using WebInvoiceApp.Common.Identity.Context;
using WebInvoiceApp.Common.Identity.Users;
using WebInvoiceApp.UI.Web.Models.ViewModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

using System.Web.Mvc;
using System.Web.Security;
using System.Linq;
using System.Net;
using System.Data.Entity;
using System;

namespace WebInvoiceApp.UI.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UsersAdminController : Controller
    {
        private ApplicationUserManager _userManager;
        private ApplicationSignInManager _signInManager;
        private ApplicationRoleManager _roleManager;
        ApplicationDbContext context;

        public UsersAdminController()
        {
            context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            var User = context.Users.ToList();
            return View(User);
        }

        // GET: UserAdmin
        public async Task<ActionResult> ListUser()
        {
            return View(await UserManager.Users.ToListAsync());
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

        #region: Register

        public ActionResult Register()
        {
            ViewBag.Name = new SelectList(context.Roles.ToList(), "Name", "Name");
            return View();
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


        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(AspNetRegisterVM register)
        {
            if (ModelState.IsValid)
            {

                var user = new ApplicationUser
                {
                    UserName = register.Alias,
                    FullName = register.FullName,
                    Email = register.Email,
                    LastAccess = DateTime.Now,
                    UserImage = register.UserImage
                };

                var result = await UserManager.CreateAsync(user, register.Password);

                if (result.Succeeded)
                {
                    //Atribui o Peril ao usuário
                    await this.UserManager.AddToRoleAsync(user.Id, register.Alias);
                    //termina aqui

                    //-------------------atribuir role ao user------------------------------
                    //var applicationRole = await _roleManager.FindByNameAsync(register.Role);
                    //if (applicationRole != null)
                    //{
                    //    IdentityResult roleResult = await _userManager.AddToRoleAsync(user.Id, applicationRole.Name);
                    //}
                    //-------------------atribuir role ao user------------------------------

                    await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var erro in result.Errors)
                    {
                        ModelState.AddModelError("", erro);
                    }

                    return View(register);
                }
            }
            return View(register);
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
                    LastAccess = DateTime.Now,
                    UserImage = register.UserImage
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

                    return RedirectToAction("Index", "UsersAdmin", "Admin");
                }
                else
                {
                    foreach (var erro in result.Errors)
                    {
                        ModelState.AddModelError("", erro);
                    }

                    return View(register);
                }
            }
            return View(register);
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
        public async Task<ActionResult> Edit([Bind(Include = "Email,Id,FullName,UserImage,DateBirth")] EditUserViewModel editUser, params string[] selectedRole)
        {
            if (ModelState.IsValid)
            {
                var user = await UserManager.FindByIdAsync(editUser.Id);
                if (user == null)
                {
                    return HttpNotFound();
                }

                //user.UserName = editUser.Email;
                user.Email = editUser.Email;
                user.FullName = editUser.FullName;
                user.UserImage = editUser.UserImage;

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
                return RedirectToAction("Index", "UsersAdmin", new { area = "Admin" });
            }
            ModelState.AddModelError("", "Something failed.");
            return View();
        }
        
        public async Task<ActionResult> DeleteUser(string Id)
        {
            if (ModelState.IsValid)
            {
                if (Id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }

                var user = await UserManager.FindByIdAsync(Id);
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
                
            }

            return RedirectToAction("Index", "UsersAdmin", new { area = "Admin" });
        }

        #endregion
    }
}