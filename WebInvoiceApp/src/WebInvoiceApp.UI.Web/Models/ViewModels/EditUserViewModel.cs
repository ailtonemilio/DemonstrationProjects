using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace WebInvoiceApp.UI.Web.Models.ViewModels
{
    public class EditUserViewModel
    {
        public string Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "E-mail")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Full Name Field is Required!")]
        [MaxLength(120, ErrorMessage = "Maximum Character Allowed: 120")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [MaxLength(120, ErrorMessage = "Maximum Character Allowed: 120")]
        [Display(Name = "UserImage")]
        public string UserImage { get; set; }

        public IEnumerable<SelectListItem> RolesList { get; set; }
    }
}