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

		private static string _id;

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
				// string bytes = Base64Encode(profileInput.Image);
				_userService.ChangeName(_id, profileInput.Name);
				_userService.ChangeEmail(_id, profileInput.Email);
				_userService.ChangeImage(_id, profileInput.Image);
				return RedirectToAction("MyProfile");
			}
			return View();
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
				BookShelf = _bookService.GetList()

			};
			return View("Index", profile);
		}
	}
}
