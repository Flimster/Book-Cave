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
		// public List<PaymentViewModel> PaymentMethods {get; set;}
		// public List<BillingViewModel> PaymentMethods {get; set;}
		// public List<ShippingViewModel> PaymentMethods {get; set;}
	}
}

        // public string Id { get; set; }
        // public string Image { get; set; }
        // public string Name { get; set; }
        // public BookViewModel FavoriteBook { get; set; }
        // public AuthorViewModel FavoriteAuthor { get; set; }
        // public DateTime RegistrationDate { get; set; }
        // public DateTime LastLoginDate {get; set;}
        // public bool BookSuggestionsEmail { get; set; }
        // public int TotalReports { get; set; }
        // public int TotalBans { get; set; }