using System;
using System.ComponentModel.DataAnnotations;

namespace WebInvoiceApp.Common.Identity.Users
{
    public class LoginViewModel
    {
        /// <summary>
        /// 
        /// </summary>        
        [Required]
        [Display(Name = "User Name")]
        [MaxLength(60, ErrorMessage = "Maximum Character Allowed: 60")]
        public string Alias { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "Remember?")]
        public bool RememberMe { get; set; }
    }
}
