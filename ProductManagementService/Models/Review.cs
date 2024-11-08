using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductManagementService.Models
{
    [Table("Reviews")]
    public class Review
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString(); // Benzersiz ID (GUID)

        [Required]
        public string ProductId { get; set; } // Ürün ID (GUID olarak değiştirildi)
        public Product Product { get; set; } // Ürün ile ilişki

        [Required]
        [StringLength(500)]
        public string Content { get; set; } // İnceleme içeriği

        [Required]
        public int Rating { get; set; } // Derecelendirme (1-5)

        [Required]
        public DateTime CreatedAt { get; set; } // Oluşturulma tarihi
    }
}
