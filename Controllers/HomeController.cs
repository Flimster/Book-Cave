using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using BookCave.Models;
using BookCave.Data.EntityModels;
using Microsoft.AspNetCore.Diagnostics;
using BookCave.Services;

namespace BookCave.Controllers
{
    public class HomeController : Controller
    {
        private readonly BookService _bookService;

        public HomeController()
        {
            _bookService = new BookService();
        }

        public IActionResult Index()
        {
            var books = _bookService.GetList();
            return View(books);
        }

        public IActionResult Error()
        {
            var exceptionFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            if(exceptionFeature != null)
            {
                string path = exceptionFeature.Path;
                Exception exception = exceptionFeature.Error;

                //TODO: Write to databse
            }

            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
