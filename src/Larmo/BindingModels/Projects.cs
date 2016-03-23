using System.ComponentModel.DataAnnotations;

namespace Larmo.Api.BindingModels
{
    public class AddNewProjectBindingModel
    {
        [Required]
        [Display(Name = "Name of project")]
        public string Name { get; set; }
    }
}
