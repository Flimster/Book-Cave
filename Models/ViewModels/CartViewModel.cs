using System.Collections.Generic;

namespace BookCave.Models.ViewModels
{
    public class CartViewModel
    {
		public double Price { get; set; }
		public List<OrderBookViewModel> BookList { get; set; }
    }
}