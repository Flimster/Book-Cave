using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using BookCave.Models.ViewModels;
using BookCave.Data;
using BookCave.Services;
using Microsoft.AspNetCore.Identity;
using BookCave.Data.EntityModels;
using System.Threading.Tasks;

namespace BookCave.Controllers
{
	public class UserController : Controller
	{
		private readonly BookService _bookService;
		private readonly UserManager<AspNetUsers> _userManager;
		private readonly AspNetUsersService _userService;
		private readonly OrdersService _orderService;

		// private readonly string userEmail;

		public UserController(UserManager<AspNetUsers> userManager)
		{
			_userManager = userManager;
			_userService = new AspNetUsersService();
			_bookService = new BookService();
			_orderService = new OrdersService();
		}

		[HttpGet]
		//[Authorize(Roles = "Customer")]
		public IActionResult Index(int id)
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
				FavoriteBook = "Some favourite book",
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
							Date = new DateTime(),
							Status = false,
							Price = 50,
							BookList = _bookService.GetList()
					},
					new OrderViewModel()
					{
							Id = 1,
							Date = new DateTime(),
							Status = false,
							Price = 50,
							BookList = _bookService.GetList()
					}
				};
			return Json(orders);
		}

		[HttpGet]
		public JsonResult GetWishList()
		{
			var books = _bookService.GetList();
			return Json(books);
		}

		[HttpGet]
		public JsonResult GetBookShelf()
		{
			var books = _bookService.GetList();
			return Json(books);
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

		public async Task<IActionResult> MyProfile()
		{
			var user = await _userManager.GetUserAsync(User);
			var test = _userService.GetById(user.Id);

			var profile = new ProfileViewModel
			{
				Id = user.Id,
				Image = user.Image,
				Name = user.Name,
				Email = user.Email,
				//FavoriteBook = test.FavoriteBook,
				//FavoriteAuthor = test.FavoriteAuthor
			};
			return View("Index", profile);
		}
	}
}