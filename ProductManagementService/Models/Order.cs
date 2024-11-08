using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductManagementService.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString(); // Benzersiz ID (GUID)

        [Required]
        public string ProductId { get; set; } // Ürün ID (GUID olarak değiştirildi)
        public Product Product { get; set; } // Ürün ile ilişki

        [Required]
        public DateTime OrderDate { get; set; } // Sipariş tarihi

        [Required]
        public decimal TotalAmount { get; set; } // Toplam tutar
    }
}
