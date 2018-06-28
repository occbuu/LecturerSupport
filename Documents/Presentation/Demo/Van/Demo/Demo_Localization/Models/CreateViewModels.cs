using System.ComponentModel.DataAnnotations;

namespace Demo_Localization.Models
{
    using Resources;
    public class CreateViewModels
    {
        [Display(ResourceType = typeof(Resources.ViewString), Name = "FirstName")]
        [Required(ErrorMessageResourceType = typeof(ViewString), ErrorMessageResourceName = "Required")]
        public string FirstName { get; set; }

        [Display(ResourceType = typeof(Resources.ViewString), Name = "LastName")]
        [Required(ErrorMessageResourceType = typeof(ViewString), ErrorMessageResourceName = "Required")]
        [StringLength(20, ErrorMessageResourceType = typeof(ViewString), ErrorMessageResourceName = "StringLength")]
        public string LastName { get; set; }
    }
}