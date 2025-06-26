using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationProject.Models
{
    public class Request
    {
        [Key]
        public int RequestId { get; set; }
        public string Message { get; set; }

        [ForeignKey(nameof(Kullanici.KullaniciId))]
        public string KId { get; set; }
        public DateTime Tarih { get; set; } = DateTime.Now;
    }
}
