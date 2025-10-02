using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RetroTapes.Data;
using RetroTapes.Models;
using System.Linq;

namespace RetroTapes.Controllers
{
    public class FilmController : Controller
    {
        private readonly AppDbContext _context;

        public FilmController(AppDbContext context)
        {
            _context = context;
        }
        public async Task <IActionResult> Details(int id)
        {
            var film = await _context.Films.FirstOrDefaultAsync(f => f.FilmId == id);
            if (film == null) return NotFound();

            return View(film);
        }
    }
}
