using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationProject.Models
{
    public class Request
    {
        public int RequestId { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }

        [ForeignKey(nameof(Kullanici.KullaniciId))]
        public string KId { get; set; }

    }
}
