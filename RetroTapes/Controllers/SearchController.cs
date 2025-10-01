using Microsoft.AspNetCore.Mvc;
using RetroTapes.Data;

namespace RetroTapes.Controllers
{
    public class SearchController : Controller
    {
        private readonly AppDbContext _context;

        // /Search
        

        public SearchController(AppDbContext context)
        {
            _context = context;
        }

        // /Search

        public IActionResult Index(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                return View();
            }

            var results = _context.Films
                .Where(m => m.Title.Contains(query))
                .Select(m => m.Title)
                .ToList();

            return View(results);
        }


        // /Search/Advanced
        public IActionResult Advanced()
        {
            return View();
        }


    }
}
