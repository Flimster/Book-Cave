using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BookCave.Services;

namespace BookCave.Controllers
{
    //[Authorize(Roles = "Admin, Customer")]
    public class BookController : Controller
    {
      private readonly BookService _db;

      public BookController ()
      {
        _db = new BookService();
      }
        public IActionResult Index(int? id)
        {
          var books = _db.GetList();
          return View(books[0]);
        }
    }
}