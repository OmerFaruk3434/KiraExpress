using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiGatewayService.Models
{
    [Table("Routes")]
    public class Route
    {
        [Key]
        public int Id { get; set; } // Benzersiz ID

        [Required]
        [StringLength(200)]
        public string Path { get; set; } // Yönlendirilecek yol (örn. /api/products)

        [Required]
        [StringLength(100)]
        public string ServiceName { get; set; } // Yönlendirilecek mikroservis adı

        [Required]
        public string HttpMethod { get; set; } // HTTP Metodu (GET, POST, PUT, DELETE)

        public bool IsActive { get; set; } // Aktiflik durumu
    }
}
