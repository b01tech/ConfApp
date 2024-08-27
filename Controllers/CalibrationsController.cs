using ConfApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace ConfApp.Controllers
{
    public class CalibrationsController : Controller
    {
        private readonly AppDbContext _context;

        public CalibrationsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
