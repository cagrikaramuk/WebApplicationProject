using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using WebApplicationProject.Models;


namespace WebApplicationProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext appDbContext;
        public HomeController(AppDbContext context)
        {
            appDbContext = context;
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
            appDbContext.Requests.Add(model);
            appDbContext.SaveChanges();
            return RedirectToAction(nameof(Tesekkur));
        }
        public IActionResult Tesekkur()
        {
            return View();
        }
    }

}
 