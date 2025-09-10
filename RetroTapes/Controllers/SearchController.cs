using Microsoft.AspNetCore.Mvc;

namespace RetroTapes.Controllers
{
    public class SearchController : Controller
    {
        // /Search
        public IActionResult Index()
        {
            return View();
        }

        // /Search/Advanced
        public IActionResult Advanced()
        {
            return View();
        }
    }
}
