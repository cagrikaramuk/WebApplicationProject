using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using WebApplicationProject.Models;


namespace WebApplicationProject.Controllers
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

            return RedirectToAction(nameof(Privacy));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        [HttpPost]
        public IActionResult AddRequest(Request model)
        {
            _context.Requests.Add(model);
            _context.SaveChanges();
            return RedirectToAction(nameof(Tesekkur));
        }
        public IActionResult Tesekkur()
        {
            return View();
        }
    }

}
 