using System.Collections.Generic;
using System.Linq;
using BookCave.Models.ViewModels;
using BookCave.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookCave.Controllers
{
    public class CheckOutController : Controller
    {
        private readonly CheckoutService _checkoutService;

        public CheckOutController()
        {
            _checkoutService = new CheckoutService();
        }

        [HttpPost]
        public IActionResult Index([FromBody]List<int> idArr)
        {
            var bookList = _checkoutService.GetItemsInCart(idArr);
            var order = _checkoutService.GetCartViewModel(bookList);
            return View(order);
        }

        public IActionResult Shipping()
        {
          return View();
        }

        public IActionResult Billing()
        {
          return View();
        }

        public IActionResult Card()
        {
          return View();
        }

        public IActionResult Review()
        {
          return View();
        }

        public IActionResult Confirm()
        {
          return View();
        }
    }
}