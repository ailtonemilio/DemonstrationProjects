using System.ComponentModel.DataAnnotations;

namespace WebInvoiceApp.UI.Web.Models.ViewModels
{
    public class EditRoleViewModel
    {
        public string Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Role Name")]
        public string Name { get; set; }
    }
}
