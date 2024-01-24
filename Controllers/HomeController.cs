using Landab202.DAL;
using Landab202.Models;
using Microsoft.AspNetCore.Mvc;

namespace Landab202.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Services> s = _context.Servicess.ToList();
            return View(s);
        }

      
    }
}