using Microsoft.AspNetCore.Mvc;

namespace Ninestars.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
