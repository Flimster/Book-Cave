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
<<<<<<< HEAD
		public List<OrderViewModel> PastOrders { get; set; }
=======
		public List<OrderViewModel> Orders { get; set; }
>>>>>>> 6870fb2b916b8bdffa2f89dd350500f9eccd3733
		public List<BookViewModel> WishList { get; set; }
		public List<BookViewModel> BookShelf { get; set; }
		public bool wantsEmail { get; set; }
		public bool wantsEmailWishList { get; set; }
		// public List<PaymentViewModel> PaymentMethods {get; set;}
		// public List<BillingViewModel> PaymentMethods {get; set;}
		// public List<ShippingViewModel> PaymentMethods {get; set;}
	}
}