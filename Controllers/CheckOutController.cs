using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BookCave.Data.EntityModels;
using BookCave.Models.ViewModels;
using BookCave.Services;
using Microsoft.AspNetCore.Authorization;
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
        private static CheckoutViewModel _model;

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
            var order = _checkoutService.GetCartViewModel();
            return View(order);
        }

        public IActionResult EditCart(int qty, int id)
        {
          _cookieService.EditItemCartCookie(id, qty);
          return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin,Customer")]
        [HttpGet]
        public IActionResult Shipping()
        {
            var _claimsPrincipal = new ClaimsPrincipal(User);

            var id = _userManager.GetUserId(_claimsPrincipal);
            _model = new CheckoutViewModel();
            _model.ShippingAddresses = _shippingServicee.GetByUserId(id);
            return View(_model);
        }

        //if user selects a shipping address
        [Authorize(Roles = "Admin,Customer")]
        [HttpPost]
        public IActionResult Shipping(int addrId)
        {
            var _claimsPrincipal = new ClaimsPrincipal(User);
            var id = _userManager.GetUserId(_claimsPrincipal);

            _model.SelectedShipping = _shippingServicee.GetByAddressId(addrId);
            
            return View(_model);
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Customer")]
        public IActionResult Billing()
        {
            var _claimsPrincipal = new ClaimsPrincipal(User);
            var id = _userManager.GetUserId(_claimsPrincipal);

            _model.BillingAddresses = _billingService.GetByUserId(id);

          return View(_model);
        }

        [HttpPost]
        [Authorize(Roles = "Admin,Customer")]
        public IActionResult Billing(int addrId)
        {
            var _claimsPrincipal = new ClaimsPrincipal(User);
            var id = _userManager.GetUserId(_claimsPrincipal);

            _model.SelectedBilling = _billingService.GetByAddressId(addrId);
            
            return View(_model);
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Customer")]
        public IActionResult Card()
        {
            var _claimsPrincipal = new ClaimsPrincipal(User);
            var id = _userManager.GetUserId(_claimsPrincipal);

            _model.Cards = _cardService.GetByUserId(id);

            return View(_model);
        }

        [HttpPost]
        [Authorize(Roles = "Admin,Customer")]
        public IActionResult Card(int cardId)
        {
            var _claimsPrincipal = new ClaimsPrincipal(User);
            var id = _userManager.GetUserId(_claimsPrincipal);

            _model.SelectedCard = _cardService.GetByCardId(cardId);

            return View(_model);
        }

        [Authorize(Roles = "Admin,Customer")]
        public IActionResult Review()
        {
            _model.Order = _checkoutService.GetCartViewModel();
            

            return View(_model);
        }

        [Authorize(Roles = "Admin,Customer")]
        public IActionResult Confirm()
        {
          return View();
        }
    }
}