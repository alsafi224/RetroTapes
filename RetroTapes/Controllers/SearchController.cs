using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RetroTapes.Data;

namespace RetroTapes.Controllers
{
    public class SearchController : Controller
    {
        private readonly AppDbContext _context;

        public SearchController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string? query)
        {
            var films = from f in _context.Films
                        select f;

            if (!string.IsNullOrWhiteSpace(query))
            {
                films = films.Where(f => f.Title.Contains(query));
            }

            return View(await films.ToListAsync());
        }
    }
}