using System.ComponentModel.DataAnnotations;

namespace CodingEvents.ViewModels
{
    public class AddEventCategoryViewModel
    {
        [Required (ErrorMessage = "Please enter a category")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Name must contain between 3 and 20 characters")]
        public string? Name { get; set; }
    }
}
