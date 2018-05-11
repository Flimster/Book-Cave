using System;
using System.Collections.Generic;
using System.Linq;
using BookCave.Models.ViewModels;
using BookCave.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookCave.Controllers
{
    public class CheckOutController : Controller
    {
        private readonly CheckoutService _checkoutService;
        private readonly CookieService _cookieService;
        private readonly IHttpContextAccessor _httpContextAccessor;  

        public CheckOutController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _checkoutService = new CheckoutService(httpContextAccessor);
            _cookieService = new CookieService(_httpContextAccessor);
        }

        [HttpPost]
        public void AddToCart([FromQuery]int qty, int id)
        {
            _cookieService.AddToCartCookie(qty, id);
        }

        [HttpPost]
        public IActionResult RemoveFromCart(int id)
        {
            _cookieService.RemoveFromCartCookie(id);
            return RedirectToAction("Index");
        }
        
        public IActionResult Index()
        {
            var cartArr = _cookieService.GetCart();
            var bookList = _checkoutService.GetItemsInCart(cartArr);
            var order = _checkoutService.GetCartViewModel(bookList, cartArr);
            return View(order);
        }

        public IActionResult EditCart(int qty, int id)
        {
          _cookieService.EditItemCartCookie(id, qty);
          return RedirectToAction("Index");
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