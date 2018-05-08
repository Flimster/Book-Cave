using Microsoft.AspNetCore.Mvc;

namespace BookCave.Controllers
{
    public class FeedbackController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}