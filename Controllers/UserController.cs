using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using BookCave.Models.ViewModels;
using BookCave.Data;
using BookCave.Services;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using BookCave.Data.EntityModels;
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
		public IActionResult Index(int id)
		{
			return View();
		}

		[HttpPost]
		public IActionResult EditProfile(ProfileInputModel profileInput)
		{
			return Redirect("Index");
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