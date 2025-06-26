using System.ComponentModel.DataAnnotations;

namespace WebApplicationProject.Models
{
    public class Kullanici
    {
        [Key]
        public int KullaniciId { get; set; }
        public string User { get; set; }
        public string Product { get; set; }
        public string Order { get; set; }
    }
}
