using System;
using System.ComponentModel.DataAnnotations;

namespace WebInvoiceApp.Common.Identity.Users
{
    public class AspNetRegisterVM
    {
        [Key]
        public string Id { get; set; }

        [Required(ErrorMessage = "Field User Name is Required!")]
        [MaxLength(60, ErrorMessage = "Maximum Character Allowed: 60")]
        [Display(Name = "User Name")]
        public string Alias { get; set; }

        [Required(ErrorMessage = "Full Name Field is Required!")]
        [MaxLength(120, ErrorMessage = "Maximum Character Allowed: 120")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [MaxLength(120, ErrorMessage = "Maximum Character Allowed: 120")]
        [Display(Name = "UserImage")]
        public string UserImage { get; set; }

        [Display(Name = "Last Access")]
        public DateTime LastAccess { get; set; }

        [Required(ErrorMessage = "Email field is required!")]
        [EmailAddress(ErrorMessage = "Invalid email!")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Field {0} must be at least {2} characters.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The Password and Confirm Password fields are different!")]
        public string ConfirmPassword { get; set; }
    }
}
