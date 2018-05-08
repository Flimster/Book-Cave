using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using BookCave.Models.ViewModels;
using BookCave.Data;

namespace BookCave.Controllers
{
	public class UserController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public JsonResult GetProfile()
		{
			var user = new UserPrivateViewModel
			{
				Image = "https://3.bp.blogspot.com/-j2CLGaKyPyg/TjMDiSi37DI/AAAAAAAAASA/RGQGSGtgstc/s1600/Chamber+of+Secrets+Poster.jpg",
				Name = "Harry potter",
				Email = "someemail@gmail.com",
				FavouriteBook = "Some favourite book",
				FavouriteAuthor = "Some testdsafdsaf"
			};
			return Json(user);
		}

		[HttpGet]
		public JsonResult GetOrders()
		{

			var orders = new List<OrderViewModel>
				{
					new OrderViewModel()
					{
							Id = 0,
							//User = 1,
							OrderDate = new DateTime(),
							OrderStatus = false,
							TotalPrice = 50,
							BookList = FakeDatabase.Books
					},
					new OrderViewModel()
					{
							Id = 1,
							//User = ,
							OrderDate = new DateTime(),
							OrderStatus = false,
							TotalPrice = 50,
							BookList = FakeDatabase.Books
					}
				};
			return Json(orders);
		}

		[HttpGet]
		public JsonResult GetWishList()
		{
			return Json(FakeDatabase.Books);
		}

		[HttpGet]
		public JsonResult GetBookShelf()
		{
			return Json(FakeDatabase.Books);
		}

		[HttpGet]
		public JsonResult GetSettings()
		{
			return Json("Settings");
		}

		[HttpGet]
		public JsonResult GetPaymentAndShipping()
		{
			return Json("Payment and Shipping");
		}
	}
}