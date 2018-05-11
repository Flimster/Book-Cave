using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BookCave.Data.EntityModels;
using BookCave.Models.ViewModels;
using BookCave.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BookCave.Controllers
{
    public class CheckOutController : Controller
    {
        private readonly CheckoutService _checkoutService;
        private readonly CookieService _cookieService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ShippingAddressService _shippingServicee;
        private readonly BillingAddressService _billingService;
        private readonly CardDetailsService _cardService;
        private readonly UserManager<AspNetUsers> _userManager;

        public CheckOutController(IHttpContextAccessor httpContextAccessor, UserManager<AspNetUsers> userManager)
        {
            _httpContextAccessor = httpContextAccessor;
            _checkoutService = new CheckoutService(httpContextAccessor);
            _cookieService = new CookieService(_httpContextAccessor);
            _shippingServicee = new ShippingAddressService();
            _billingService = new BillingAddressService();
            _cardService = new CardDetailsService();
            _userManager = userManager;
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

        [HttpGet]
        public IActionResult Shipping()
        {
          var _claimsPrincipal = new ClaimsPrincipal(User);

          var id = _userManager.GetUserId(_claimsPrincipal);
          var shippingAddresses = _shippingServicee.GetByUserId(id);
          var billingAddresses = _billingService.GetList();
          var cards = _cardService.GetByUserId(id);
          var model = new CheckoutViewModel()
          {
              CurrentStatus = 0,
              ShippingAddresses = shippingAddresses,
              BillingAddresses = billingAddresses,
              Cards = cards,
          };
          return View(model);
        }

        //if user selects a shipping address
        [HttpPost]
        public IActionResult Shipping(int addrId)
        {
          var _claimsPrincipal = new ClaimsPrincipal(User);
          var id = _userManager.GetUserId(_claimsPrincipal);
          
          var shippingAddresses = _shippingServicee.GetByUserId(id);
          var selectedShipping = _shippingServicee.GetByAddressId(addrId);

          var model = new CheckoutViewModel()
          {
              CurrentStatus = 0,
              ShippingAddresses = shippingAddresses,
              SelectedShipping = selectedShipping,
          };
          return View(model);
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