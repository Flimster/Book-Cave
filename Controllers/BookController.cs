using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BookCave.Services;
using BookCave.Data;

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
        public BookController()
        {
            _bookService = new BookService();
            _feedbackService = new FeedbackService();
            _aspNetUsersService = new AspNetUsersService();
            _ordersService = new OrdersService();
            _billingAddressService = new BillingAddressService();
            _cardDetailsService = new CardDetailsService();
            _db = new DataContext();
        }

        public IActionResult Index(int? id)
        {

          //var book = _db.GetList()[0];
          return View();
        }

        public IActionResult Test()
        {
            //var feedback = _feedbackService.();
            //var book = _bookService.GetList();
            var aspNetUsers = _aspNetUsersService.GetById("25a13905-92e4-4a72-a707-5b761313650e");
            //var billing = _billingAddressService.GetList();
            //var card = _cardDetailsService.GetList();
            //var order = _ordersService.GetByUserId("f8277a4c-5152-4599-83cb-598ef8fa8056");
            return View(aspNetUsers);
        }
    }
}