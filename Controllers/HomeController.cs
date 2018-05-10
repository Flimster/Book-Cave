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
using Microsoft.AspNetCore.Http;

namespace BookCave.Controllers
{
    public class HomeController : Controller
    {
        private readonly BookService _bookService;
        private readonly CookieService _cookieService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public HomeController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _bookService = new BookService();
            _cookieService  = new CookieService(_httpContextAccessor);
        }

        public IActionResult Index()
        {
            var books = _bookService.GetList();
            //_cookieService.AddToCartCookie(2, "2323");
            _cookieService.RemoveFromCartCookie(2323);

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
