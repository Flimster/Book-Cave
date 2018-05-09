using System.Collections.Generic;
using BookCave.Models.ViewModels;

namespace BookCave.Models.ViewModels
{
	public class UserPrivateViewModel
	{
		public int Id { get; set; }
		public string Image { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string FavoriteBook { get; set; }
		public string FavouriteAuthor { get; set; }
		public List<OrderViewModel> PastOrders { get; set; }
		public List<BookViewModel> WishList { get; set; }
		public List<BookViewModel> BookShelf { get; set; }
		public bool wantsEmail { get; set; }
		public bool wantsEmailWishList { get; set; }
		// public List<PaymentViewModel> PaymentMethods {get; set;}
		// public List<BillingViewModel> PaymentMethods {get; set;}
		// public List<ShippingViewModel> PaymentMethods {get; set;}
	}
}