using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BookCave.Data.EntityModels;

namespace BookCave.Models.InputModel
{
    public class BookInputModel
    {
        [Required(ErrorMessage = "Title is empty")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Author list is empty")]
        public List<Authors> Authors { get; set; }
        [Required(ErrorMessage = "Genre is empty is empty")]
        public List<string> Genre { get; set; }
        [Required(ErrorMessage = "No image selected")]
        public string Image { get; set; }
        [Required(ErrorMessage = "Price is empty")]
        public double Price { get; set; }
        [Required(ErrorMessage = "ISBN10 is empty")]
        [RegularExpression(@"[0-9]{10}$", ErrorMessage = "ISBN10 number must be 10 character long")]
        public string ISBN10 { get; set; }
        [RegularExpression(@"(978|979)[0-9]{9}$", ErrorMessage = "Incorrect format")]
        [Required(ErrorMessage = "ISBN13 is empty")]
        public string ISBN13 { get; set; }
        [Required(ErrorMessage = "Description is empty")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Release year is empty")]
        public int ReleaseYear { get; set; }
        public bool Visibility { get; set; }
        [Required(ErrorMessage = "Publisher is empty")]
        public string Publisher { get; set; }
        [Required(ErrorMessage = "Format list is empty")]
        public Formats Formats { get; set; }
        [Required(ErrorMessage = "Stock count is empty")]
        public int StockCount { get; set; }
        [Required(ErrorMessage = "Discount field is empty")]
        public double Discount { get; set; }
    }
}