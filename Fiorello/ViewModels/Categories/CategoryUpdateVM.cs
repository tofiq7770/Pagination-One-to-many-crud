using System.ComponentModel.DataAnnotations;

namespace Fiorello.ViewModels.Categories
{
    public class CategoryUpdateVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This field can't be empty")]
        [StringLength(25, ErrorMessage = "Max length must be 20")]
        public string Name { get; set; }
    }
}
