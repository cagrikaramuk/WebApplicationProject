using Microsoft.AspNetCore.Mvc;
using WebApplicationProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace WebApplicationProject.Controllers
{
    public class AdminController : Controller
    {
        private readonly AppDbContext appDbContext;
        public AdminController(AppDbContext context)
        {
            this.appDbContext = context;
        }
        public IActionResult Dashboard()
        {
            var item = appDbContext.Requests.ToList();
            return View(item);
        }

        public IActionResult Edit (Request request)
        {   
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            var entitytoupdate = appDbContext.Requests.Where(p => p.RequestId == request.RequestId).FirstOrDefault();

            if (entitytoupdate != null) 
            {
                entitytoupdate.Message = request.Message;
                appDbContext.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }

    }
}
