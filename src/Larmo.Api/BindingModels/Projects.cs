using System.ComponentModel.DataAnnotations;

namespace Larmo.Api.BindingModels
{
    public class AddNewProjectBindingModel
    {
        [Required, MinLength(2), MaxLength(50)]
        public string Name { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
    }
}