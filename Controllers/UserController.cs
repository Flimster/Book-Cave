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
            var bookList = new List<BookViewModel>()
            {
                new BookViewModel()
                {
                    Id = 1,
                    Title = "Harry Potter and the Chamber of Secrets",
                    Author = "J.K Rowling",
                    Genre = "Adventure, Fantasy",
                    Image = "~/images/Feels_good_manDELETE.jpg",
                    Price = 33.49
                },
                                new BookViewModel()
                {
                    Id = 1,
                    Title = "Harry Potter and the Chamber of Secrets",
                    Author = "J.K Rowling",
                    Genre = "Adventure, Fantasy",
                    Image = "~/images/Feels_good_manDELETE.jpg",
                    Price = 33.49
                },
                 new BookViewModel()
                {
                    Id = 1,
                    Title = "Harry Potter and the Chamber of Secrets",
                    Author = "J.K Rowling",
                    Genre = "Adventure, Fantasy",
                    Image = "~/images/Feels_good_manDELETE.jpg",
                    Price = 33.49
                }
            };
            var pastOrders = new List<OrderViewModel>
            {
                new OrderViewModel()
                {
                    Id = 123,
                    UserId = 0,
                    OrderPlaced = new DateTime(),
                    OrderStatus = false,
                    TotalPrice = 99.99,
                    BookList = bookList
                },
                new OrderViewModel()
                {
                    Id = 124,
                    UserId = 1,
                    OrderPlaced = new DateTime(),
                    OrderStatus = true,
                    TotalPrice = 9913.99,
                    BookList = bookList
                }
            };
			var user = new UserPrivateViewModel
			{
                Id = 0,
                Image = "../wwwroot/images/Feels_good_manDELETE.jpg",
                Name = "Pepe",
                Email = "someemail@gmail.com",
                FavouriteBook = "Harry Potter and the chamber of Secrets",
                FavouriteAuthor = "J.K Rowling",
                PastOrders = pastOrders,
                WishList = bookList,
                BookShelf = bookList
			};
			return View(user);
		}
	}
}