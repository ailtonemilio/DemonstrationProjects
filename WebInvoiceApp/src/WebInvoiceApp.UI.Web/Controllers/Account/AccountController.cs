using WebInvoiceApp.Common.Identity.Configuration;
using WebInvoiceApp.Common.Identity.Users;
using WebInvoiceApp.Common.Identity.Context;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using WebInvoiceApp.UI.Web.Models;
using WebInvoiceApp.UI.Web.Models.ViewModels;
using Microsoft.AspNet.Identity.EntityFramework;
using System;

namespace WebInvoiceApp.UI.Web.Controllers.Account
{
    public class AccountController : Controller
    {
        #region "Usando ASPNET Identity"
        //Usando aspnet Identity
        ApplicationDbContext context;
        private ApplicationUserManager _userManager;
        private ApplicationSignInManager _signInManager;
        private ApplicationRoleManager _roleManager;

        private webinvoiceEntities db = new webinvoiceEntities();

        public AccountController()
        {
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
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(AspNetRegisterVM register)
        {
            if (ModelState.IsValid)
            {

                var user = new ApplicationUser
                {
                    UserName = register.Alias,
                    FullName = register.FullName,
                    Email = register.Email,
                    UserImage = register.UserImage
                };

                var result = UserManager.Create(user, register.Password);

                if (result.Succeeded)
                {
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult InsertUser(AspNetRegisterVM register)
        {
            if (ModelState.IsValid)
            {

                var user = new ApplicationUser
                {
                    UserName = register.Alias,
                    FullName = register.FullName,
                    Email = register.Email,
                    UserImage = register.UserImage
                };

                var result = UserManager.Create(user, register.Password);

                if (!result.Succeeded)
                {
                    foreach (var erro in result.Errors)
                    {
                        ModelState.AddModelError("", erro);
                    }

                    return View(register);
                }
            }

            return Json(new { success = true },
                JsonRequestBehavior.AllowGet);

        }

        #endregion

        #region: Login => Login na App

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel vModel, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(vModel);
            }

            var result = await SignInManager.PasswordSignInAsync(vModel.Alias, vModel.Password, vModel.RememberMe, shouldLockout: false);

            switch (result)
            {
                case SignInStatus.Success:
                    var identity = (ClaimsIdentity)User.Identity;
                    AuthenticationManager.SignIn(new AuthenticationProperties
                    {
                        IsPersistent = vModel.RememberMe
                    }, identity);

                    var dados = (from us in db.AspNetUsers
                                 where us.UserName == vModel.Alias
                                 select us).ToList<AspNetUsers>();

                    foreach (var temp in dados)
                    {
                        Session["Name"] = temp.UserName;
                        Session["UserImage"] = temp.UserImage;
                        Session["LastAccess"] = string.Format("{0:ddd, MMM d, yyyy}", temp.LastAccess);
                    }

                    //return RedirectToAction(returnUrl);
                    return RedirectToAction("Index", "Home");

                case SignInStatus.LockedOut:
                    return View("Lockout");
                case SignInStatus.RequiresVerification:
                    return RedirectToAction("SendCode", new { ReturnUrl = returnUrl });
                case SignInStatus.Failure:

                default:
                    ViewBag.Message = "Invalid Login attempt!";
                    return View(vModel);
            }


        }

        #endregion

        public ActionResult Logoff()
        {
            var authManager = HttpContext.GetOwinContext().Authentication;
            authManager.SignOut();
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("Login", "Account");
        }

        #region Helpers
        // Used for XSRF protection when adding external logins
        private const string XsrfKey = "XsrfId";

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }

        internal class ChallengeResult : HttpUnauthorizedResult
        {
            public ChallengeResult(string provider, string redirectUri)
                : this(provider, redirectUri, null)
            {
            }

            public ChallengeResult(string provider, string redirectUri, string userId)
            {
                LoginProvider = provider;
                RedirectUri = redirectUri;
                UserId = userId;
            }

            public string LoginProvider { get; set; }
            public string RedirectUri { get; set; }
            public string UserId { get; set; }

            public override void ExecuteResult(ControllerContext context)
            {
                var properties = new AuthenticationProperties { RedirectUri = RedirectUri };
                if (UserId != null)
                {
                    properties.Dictionary[XsrfKey] = UserId;
                }
                context.HttpContext.GetOwinContext().Authentication.Challenge(properties, LoginProvider);
            }
        }
        #endregion

        #endregion
    }
}