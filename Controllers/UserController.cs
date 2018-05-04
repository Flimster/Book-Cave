using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookCave.Models;
using BookCave.Models.ViewModels;

namespace BookCave.Controllers
{
	public class UserController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public JsonResult GetProfile()
		{
			var user = new UserPrivateViewModel
			{
				Image = "no-source",
				Name = "Harry potter",
				Email = "someemail@gmail.com",
                FavouriteBook = "Some favourite",
                FavouriteAuthor = "Some author"
			};
			return Json(user);
		}
	}
}