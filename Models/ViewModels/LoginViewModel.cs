using System.ComponentModel.DataAnnotations;

namespace BookCave.Models.ViewModels
{
    public class LoginViewModel
    {
        [EmailAddress]
        [Required(ErrorMessage="Email is invalid")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage="Email is not valid")]
        public string Email { get; set; }
        [Required(ErrorMessage="Country is required")]
        [RegularExpression(@"(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,10})*", ErrorMessage="Password must contain 1 capital letter, one non alphanumerical character , 1 number and be atleast 8 characters long")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }

        	
    }
}