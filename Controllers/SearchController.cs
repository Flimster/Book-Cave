using BookCave.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookCave.Controllers
{
    public class SearchController : Controller
    {
        private readonly BookService _bookService;
        
        public SearchController()
        {
          _bookService = new BookService();
        }

        public IActionResult Index()
        {
          var books = _bookService.GetList();

          return View(books);
        }
    }
}