using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using WebApplicationProject.Models;


namespace WebApplicationProject.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext appDbContext;
        public HomeController(AppDbContext _context)
        {
            this.appDbContext = _context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        [HttpPost]
        public IActionResult AddRequest(Request model)
        {
            return RedirectToAction(nameof(Tesekkur));
        }
        public IActionResult Tesekkur()
        {
            return View();
        }
    }

}
 