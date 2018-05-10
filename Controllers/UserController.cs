using System;
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
				Console.WriteLine("YTESS");
				return RedirectToAction ("MyProfile");
			}
			return View();
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
				FavoriteBook = test.FavoriteBook,
				FavoriteAuthor = test.FavoriteAuthor,
				WishList = _bookService.GetList(),
				BookShelf = _bookService.GetList()
			};
			return View("Index", profile);
		}
	}
}