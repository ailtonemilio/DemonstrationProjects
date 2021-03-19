using HWebTS.Common.Identity.Configuration;
using HWebTS.Common.Identity.Users;
using HWebTS.Common.Identity.Context;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using HWebTS.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity.Migrations;

namespace HWebTS.Controllers
{
    public class AccountController : Controller
    {
        #region "Usando ASPNET Identity"
        //Usando aspnet Identity
        ApplicationDbContext context;
        private ApplicationUserManager _userManager;
        private ApplicationSignInManager _signInManager;
        private ApplicationRoleManager _roleManager;

        private atripservicesEntities db = new atripservicesEntities();
        private AspNetUsers use = new AspNetUsers();

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
                ViewBag.Message = "Invalid User or Password Attempt!";
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
                        Session["UserLog"] = temp.UserImage;
                        Session["LastAccess"] = string.Format("{0:ddd, MMM d, yyyy}", temp.LastAccess);

                        temp.LastAccess = DateTime.Now;

                        db.AspNetUsers.AddOrUpdate(temp);
                        db.SaveChanges();
                    }

                    //return RedirectToAction(returnUrl);
                    return RedirectToAction("Index", "Home");

                case SignInStatus.LockedOut:
                    return View("Lockout");
                case SignInStatus.RequiresVerification:
                    return RedirectToAction("SendCode", new { ReturnUrl = returnUrl });
                case SignInStatus.Failure:

                default:
                    ModelState.AddModelError("", "Invalid Login Attempt.");
                    ViewBag.Message = "Invalid Login Attempt!";
                    return View(vModel);
            }


        }

        //LockScreen
        public ActionResult LockScreenLogin()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> LockScreenLogin(LoginViewModel vModel, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Message = "Invalid User or Password Attempt!";
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
                        Session["UserLog"] = temp.UserImage;
                        Session["LastAccess"] = string.Format("{0:ddd, MMM d, yyyy}", temp.LastAccess);
                        ViewBag.UserName = temp.UserName;

                        temp.LastAccess = DateTime.Now;

                        db.AspNetUsers.AddOrUpdate(temp);
                        db.SaveChanges();
                    }

                    //return RedirectToAction(returnUrl);
                    return RedirectToAction("Index", "Home");

                case SignInStatus.LockedOut:
                    return View("Lockout");
                case SignInStatus.RequiresVerification:
                    return RedirectToAction("SendCode", new { ReturnUrl = returnUrl });
                case SignInStatus.Failure:

                default:
                    ModelState.AddModelError("", "Invalid Login Attempt.");
                    ViewBag.Message = "Invalid Login Attempt!";
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

        public ActionResult LockScreen()
        {
            var authManager = HttpContext.GetOwinContext().Authentication;
            authManager.SignOut();
            //Session.Clear();
            //Session.Abandon();
            ViewBag.UserName = Session["Name"];
            return RedirectToAction("LockScreenLogin", "Account");
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
       




    #region "Versao Antiga de LogOff"

    //[AllowAnonymous]
    //public ActionResult Login(string returnURL)
    //{
    //    ViewBag.ReturnUrl = returnURL;
    //    return View(new ACCESS());
    //}

    //[HttpPost]
    //[AllowAnonymous]
    //[ValidateAntiForgeryToken]
    //public ActionResult Login(ACCESS login, string returnUrl)
    //{
    //    if (ModelState.IsValid)
    //    {
    //        using (atripservicesEntities db = new atripservicesEntities())
    //        {
    //            var vLogin = db.ACCESS.Where(p => p.UserLogin.Equals(login.UserLogin)).FirstOrDefault();
    //            /*Verificar se a variavel vLogin está vazia. Isso pode ocorrer caso o usuário não existe. 
    //      Caso não exista ele vai cair na condição else.*/
    //            if (vLogin != null)
    //            {
    //                /*Código abaixo verifica se o usuário que retornou na variavel tem está 
    //                  ativo. Caso não esteja cai direto no else*/
    //                if (Equals(vLogin.Active, "Y"))
    //                {
    //                    /*Código abaixo verifica se a senha digitada no site é igual a senha que está sendo retornada 
    //                     do banco. Caso não cai direto no else*/
    //                    if (Equals(vLogin.Password, login.Password))
    //                    {
    //                        FormsAuthentication.SetAuthCookie(vLogin.Email, false);
    //                        if (Url.IsLocalUrl(returnUrl)
    //                        && returnUrl.Length > 1
    //                        && returnUrl.StartsWith("/")
    //                        && !returnUrl.StartsWith("//")
    //                        && returnUrl.StartsWith("/\\"))
    //                        {
    //                            return Redirect(returnUrl);
    //                        }
    //                        /*código abaixo cria uma session para armazenar o nome do usuário*/
    //                        Session["Name"] = vLogin.Name;
    //                        /*código abaixo cria uma session para armazenar o sobrenome do usuário*/
    //                        Session["LastName"] = vLogin.LastName;
    //                        /*retorna para a tela inicial do Home*/
    //                        Session["Profile"] = vLogin.Profile;
    //                        Session["UserLog"] = vLogin.UserLog;
    //                        return RedirectToAction("Index", "Home");
    //                    }
    //                    /*Else responsável da validação da senha*/
    //                    else
    //                    {
    //                        /*Escreve na tela a mensagem de erro informada*/
    //                        //ModelState.AddModelError("", "Senha informada Inválida!!!");
    //                        ModelState.AddModelError("", "Password Invalid!!!");
    //                        /*Retorna a tela de login*/
    //                        return View(new ACCESS());
    //                    }
    //                }
    //                /*Else responsável por verificar se o usuário está ativo*/
    //                else
    //                {
    //                    /*Escreve na tela a mensagem de erro informada*/
    //                    //ModelState.AddModelError("", "Usuário sem acesso para usar o sistema!!!");
    //                    ModelState.AddModelError("", "User without access to use the system!!!");
    //                    /*Retorna a tela de login*/
    //                    return View(new ACCESS());
    //                }
    //            }
    //            /*Else responsável por verificar se o usuário existe*/
    //            else
    //            {
    //                /*Escreve na tela a mensagem de erro informada*/
    //                //ModelState.AddModelError("", "Usuário informado inválido!!!");
    //                ModelState.AddModelError("", "Informed invalid user!!!");
    //                /*Retorna a tela de login*/
    //                return View(new ACCESS());
    //            }
    //        }
    //    }
    //    /*Caso os campos não esteja de acordo com a solicitação retorna a tela de login com as mensagem dos campos*/
    //    return View(login);
    //}

    //public ActionResult Logout()
    //{
    //    FormsAuthentication.SignOut();
    //    Session.Clear();
    //    Session.Abandon();
    //    return RedirectToAction("Login", "Account");
    //}
    #endregion
}
}