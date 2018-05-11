using System.ComponentModel.DataAnnotations;

namespace BookCave.Models.ViewModels
{
    public class LoginViewModel
    {
        [EmailAddress]
        [Required(ErrorMessage="Email is invalid")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage="Email is not valid")]
        public string Email { get; set; }
        [Required(ErrorMessage="Password is required")]
        public string Password { get; set; }

        	
    }
}