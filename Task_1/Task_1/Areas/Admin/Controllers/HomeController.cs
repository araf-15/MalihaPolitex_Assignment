using Microsoft.AspNetCore.Mvc;

namespace Task_1.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Enroll()
        {
            return View();
        }
    }
}
