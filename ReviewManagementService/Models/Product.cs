using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReviewManagementService.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString(); // Benzersiz ID (GUID)

        [Required]
        [StringLength(100)]
        public string Name { get; set; } // Ürün adı

        [StringLength(500)]
        public string Description { get; set; } // Ürün açıklaması

        [Required]
        public decimal Price { get; set; } // Ürün fiyatı

        [Required]
        public int StockQuantity { get; set; } // Stok miktarı

        [Required]
        public DateTime CreatedAt { get; set; } // Oluşturulma tarihi

        public DateTime? UpdatedAt { get; set; } // Güncellenme tarihi (opsiyonel)

        public ICollection<Review> Reviews { get; set; } // Ürüne ait incelemeler
    }
}
