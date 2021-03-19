
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HWebTS.Common.Identity.Users
{
    public class ApplicationUser : IdentityUser
    {
        [Required(ErrorMessage = "Full Name Field is Required!")]
        [MaxLength(120, ErrorMessage = "Maximum Character Allowed: 120")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [MaxLength(120, ErrorMessage = "Maximum Character Allowed: 120")]
        [Display(Name = "UserImage")]
        public string UserImage { get; set; }

        [Display(Name = "Last Access")]
        public DateTime LastAccess { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
}
