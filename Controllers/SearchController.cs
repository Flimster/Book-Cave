using Microsoft.AspNetCore.Mvc;

namespace BookCave.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
          return View();
        }
    }
}