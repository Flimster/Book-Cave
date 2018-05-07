using Microsoft.AspNetCore.Mvc;

namespace Book_Cave.Controllers
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