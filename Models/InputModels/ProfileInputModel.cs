using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BookCave.Data.EntityModels;

namespace BookCave.Models.InputModels
{
    public class ProfileInputModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")]
        public string Email { get; set; }
        [Required]
        public string BookTitle { get; set; }
        [Required]
        public string Author { get; set; }
    }
}