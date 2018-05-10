using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BookCave.Services;
using BookCave.Data;
using BookCave.Data.EntityModels;

namespace BookCave.Controllers
{
    //[Authorize(Roles = "Admin, Customer")]
    public class BookController : Controller
    {
        private readonly DataContext _db;
        private readonly CardDetailsService _cardDetailsService;
        private readonly AspNetUsersService _aspNetUsersService;
        private readonly BookService _bookService;
        private readonly FeedbackService _feedbackService;
        private readonly OrdersService _ordersService;
        private readonly BillingAddressService _billingAddressService;
        private readonly ReviewsService _reviewsService;
        public BookController()
        {
            _bookService = new BookService();
            _feedbackService = new FeedbackService();
            _aspNetUsersService = new AspNetUsersService();
            _ordersService = new OrdersService();
            _billingAddressService = new BillingAddressService();
            _cardDetailsService = new CardDetailsService();
            _ordersService = new OrdersService();
            _reviewsService = new ReviewsService();
            _db = new DataContext();
        }

        public IActionResult Index(int id)
        {
          if(id == 0){
            return View("PageNotFound");
          }
          else
          {
            var book = _bookService.GetList()[id - 1];
            return View(book);
          }
        }

        public IActionResult Top10()
        {
            var books = _bookService.GetTop10();
            return View(books);
        }

        public IActionResult Discount()
        {
          var books = _bookService.GetDiscount();
          return View(books);
        }

        public IActionResult Test()
        {
            //var feedback = _feedbackService.();
            //var book = _bookService.GetList();
            //var aspNetUsers = _aspNetUsersService.GetById("25a13905-92e4-4a72-a707-5b761313650e");
            //var billing = _billingAddressService.GetList();
            //var card = _cardDetailsService.GetList();
            //var order = _ordersService.GetByUserId("25a13905-92e4-4a72-a707-5b761313650e");

            return View(_reviewsService.GetByUserId("8e252996-4d12-48fb-be5f-23fb7c2cc3e4"));
        }
    }
}