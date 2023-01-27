using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
