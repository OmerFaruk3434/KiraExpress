using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReviewManagementService.Models
{
    [Table("Reviews")]
    public class Review
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString(); // Benzersiz ID (GUID)

        [Required]
        public string ProductId { get; set; } // İncelemenin ait olduğu ürün ID
        public Product Product { get; set; } // Ürün ile ilişki

        [Required]
        public string UserId { get; set; } // İncelemeyi yazan kullanıcı ID
        public User User { get; set; } // Kullanıcı ile ilişki

        [Required]
        [StringLength(500)]
        public string Content { get; set; } // İnceleme içeriği

        [Required]
        [Range(1, 5)] // Derecelendirme 1-5 arası olmalı
        public int Rating { get; set; } // Derecelendirme (1-5)

        [Required]
        public DateTime CreatedAt { get; set; } // İncelemenin oluşturulma tarihi

        public ICollection<Comment> Comments { get; set; } // İncelemeye ait yorumlar
    }
}
