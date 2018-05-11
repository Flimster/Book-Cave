using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BookCave.Data.EntityModels;

namespace BookCave.Models.InputModels
{
    public class BillingAddressInputModel
    {
        public string Id { get; set; }
        [Required(ErrorMessage="Country is required")]
        public string Country { get; set; }
        [Required(ErrorMessage="State or Province are required")]
        public string StateOrProvince { get; set; }
        [Required(ErrorMessage="ZIP is required")]
        public string Zip {get; set;}
        [Required(ErrorMessage="Street address is required")]
        public string StreetAddress {get; set;}
        [Required(ErrorMessage="City is required")]
        public string City {get; set;}
    }
}