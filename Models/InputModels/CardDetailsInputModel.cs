using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BookCave.Data.EntityModels;

namespace BookCave.Models.InputModels
{
    public class CardDetailsInputModel
    {
        string Id;
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Card Number is required")]
        [RegularExpression("(^[0-9]{16}$)", ErrorMessage="Enter 16 valid digitss")]
        public string CardNumber { get; set; }
        [Required]
        [RegularExpression(@"\d\d\d", ErrorMessage="CVC is not valid")]
        public int Cvc { get; set; }
        [Required(ErrorMessage="Expiriation Date is required")]
        public DateTime ExpirationDate { get; set; }
    }
}