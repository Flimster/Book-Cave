using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using BookCave.Data;
using BookCave.Services;
using BookCave.Data.EntityModels;
using BookCave.Models.ViewModels;
using BookCave.Models.InputModels;

namespace BookCave.Controllers
{
	public class UserController : Controller
	{
		private readonly BookService _bookService;
		private readonly UserManager<AspNetUsers> _userManager;
		private readonly AspNetUsersService _userService;
		private readonly OrdersService _orderService;
		private readonly BillingAddressService _billingService;
		private readonly ShippingAddressService _shippingService;
		private readonly CardDetailsService _cardService;

		private static string _id;

		public UserController(UserManager<AspNetUsers> userManager)
		{
			_userManager = userManager;
			_userService = new AspNetUsersService();
			_bookService = new BookService();
			_orderService = new OrdersService();
			_billingService = new BillingAddressService();
			_shippingService = new ShippingAddressService();
			_cardService = new CardDetailsService();
		}

		public async Task<IActionResult> MyProfile()
		{
			var user = await _userManager.GetUserAsync(User);
			_id = user.Id;
			var userInfo = _userService.GetById(user.Id);
			var profile = new ProfileViewModel
			{
				Id = user.Id,
				Image = user.Image,
				Name = user.Name,
				Email = user.Email,
				FavoriteBook = userInfo.FavoriteBook,
				FavoriteAuthor = userInfo.FavoriteAuthor,
				Orders = _orderService.GetByUserId(user.Id),
				WishList = _bookService.GetList(),
				BookShelf = _bookService.GetList(),
				PaymentMethods = _cardService.GetByUserId(user.Id),
				BillingAddresses = _billingService.GetByUserId(user.Id),
				ShippingAddresses = _shippingService.GetByUserId(user.Id)
			};
			return View("Index", profile);
		}

		[HttpGet]
		//[Authorize(Roles = "Customer")]
		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public IActionResult EditProfile()
		{
			return View();
		}

		[HttpPost]
		public IActionResult EditProfile(ProfileInputModel profileInput)
		{
			if (ModelState.IsValid)
			{
				_userService.ChangeName(_id, profileInput.Name);
				_userService.ChangeEmail(_id, profileInput.Email);
				_userService.ChangeImage(_id, profileInput.Image);
				_userService.ChangeImage(_id, profileInput.Image);
				return RedirectToAction("MyProfile");
			}
			return View();
		}

		[HttpGet]
		public IActionResult AddShipping()
		{
			return View();
		}

		[HttpPost]
		public IActionResult AddShipping(ShippingAddressViewModel shipping)
		{
			return RedirectToAction("MyProfile");
		}

		[HttpGet]
		public IActionResult AddBilling()
		{
			return View();
		}

		[HttpPost]
		public IActionResult AddBilling(BillingAddressViewModel billing)
		{
			return RedirectToAction("MyProfile");
		}

		[HttpGet]
		public IActionResult AddCard()
		{
			return View();
		}

		[HttpPost]
		public IActionResult AddCard(CardDetailsViewModel card)
		{
			return RedirectToAction("MyProfile");
		}

	}
}
