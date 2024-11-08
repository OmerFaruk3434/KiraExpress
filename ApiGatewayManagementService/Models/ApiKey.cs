using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiGatewayManagementService.Models
{
    [Table("ApiKeys")]
    public class ApiKey
    {
        [Key]
        public int Id { get; set; } // Benzersiz ID

        [Required]
        [StringLength(50)]
        public string Key { get; set; } // API Anahtarı

        [Required]
        public bool IsActive { get; set; } // Aktiflik durumu

        public DateTime CreatedAt { get; set; } // Oluşturulma tarihi
    }
}
