using System.Collections.Generic;

namespace BookCave.Models.ViewModels
{
    public class CartViewModel
    {
		public double Price { get; set; }
		public List<BookViewModel> BookList { get; set; }
    }
}