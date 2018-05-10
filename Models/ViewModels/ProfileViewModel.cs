using System.Collections.Generic;
using BookCave.Models.ViewModels;

namespace BookCave.Models.ViewModels
{
	public class ProfileViewModel
	{
		public string Id { get; set; }
		public string Image { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public BookViewModel FavoriteBook { get; set; }
		public AuthorViewModel FavoriteAuthor { get; set; }
		public List<OrderViewModel> Orders { get; set; }
		public List<BookViewModel> WishList { get; set; }
		public List<BookViewModel> BookShelf { get; set; }
		public bool BookSuggestionsEmail { get; set; }
		public List<CardDetailsViewModel> PaymentMethods {get; set;}
		public List<BillingAddressViewModel> BillingAddresses {get; set;}
		public List<ShippingAddressViewModel> ShippingAddresses {get; set;}
	}
}