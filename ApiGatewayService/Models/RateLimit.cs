using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiGatewayService.Models
{
    [Table("RateLimits")]
    public class RateLimit
    {
        [Key]
        public int Id { get; set; } // Benzersiz ID

        [Required]
        public string ServiceName { get; set; } // Hangi mikroservis için limit

        [Required]
        public int MaxRequests { get; set; } // Maksimum istek sayısı

        [Required]
        public TimeSpan TimeWindow { get; set; } // Zaman penceresi
    }
}
