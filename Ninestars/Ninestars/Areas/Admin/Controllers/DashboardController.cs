using Microsoft.AspNetCore.Mvc;

namespace Ninestars.Areas.Controllers
{
    public class DashboardController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
