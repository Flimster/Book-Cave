using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BookCave.Data.EntityModels;

namespace BookCave.Models.InputModels
{
    public class ProfileInputModel
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required (ErrorMessage = "Email is required")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage="Email is not valid")]
        public string Email { get; set; }
        [Required (ErrorMessage="Title of the book is required")]
        public string BookTitle { get; set; }
        [Required (ErrorMessage = "An author is required")]
        public string Author { get; set; }
        [Required (ErrorMessage = "Image is required")]
        //[RegularExpression(@"\w(.png|.jpeg)\b", ErrorMessage="Image must end with  jpeg or png file")]
        public string Image { get; set; }
    }
}