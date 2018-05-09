using System.Collections.Generic;
using BookCave.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BookCave.Controllers
{
    public class CheckOutController : Controller
    {
        public IActionResult Index()
        {
          return View();
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