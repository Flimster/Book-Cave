using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BookCave.Services;

namespace BookCave.Controllers
{
    //[Authorize(Roles = "Admin, Customer")]
    public class BookController : Controller
    {
        private readonly AspNetUsersService _aspNetUsersService;
        private readonly BookService _bookService;
        private readonly FeedbackService _feedbackService;
        private readonly OrdersService _ordersService;
        public BookController()
        {
            _bookService = new BookService();
            _feedbackService = new FeedbackService();
            _aspNetUsersService = new AspNetUsersService();
            _ordersService = new OrdersService();
        }

        public IActionResult Index(int? id)
        {
          if(id == null){
            return View("Not found");
          }
          var book = (from b in FakeDatabase.Books
                       where b.Id == id
                       select b).SingleOrDefault();
          if(book == null)
          {
            return View("Not found");
          }
          return View(/*book*/);
        }

        public IActionResult Test()
        {
<<<<<<< HEAD
            /*var feedback = _feedbackService.GetList();
            var book = _bookService.GetReviewList();
            var aspNetUsers = _aspNetUsersService.GetList();
            */
            var orders = _ordersService.GetList();
            return View(orders);
=======
            //var feedback = _feedbackService.GetList();
            var book = _bookService.GetList();
            //var aspNetUsers = _aspNetUsersService.GetList();
            return View(book);
>>>>>>> 61b25ceb41406450926b55ba3fce4d6a7ce4610a
        }
    }
}