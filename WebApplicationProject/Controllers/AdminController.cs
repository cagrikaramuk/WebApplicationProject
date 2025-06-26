using Microsoft.AspNetCore.Mvc;
using WebApplicationProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace WebApplicationProject.Controllers
{
    public class AdminController : Controller
    {   
        public IActionResult Dashboard()
        {
            return View();
        }

    }
}
