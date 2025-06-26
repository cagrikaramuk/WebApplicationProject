using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace WebApplicationProject.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions <AppDbContext> options) : base(options)
        {

        }

        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Request> Requests { get; set; }

    }

}
