using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentalManagementService.Models
{
    [Table("Rentals")]
    public class Rental
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString(); // Benzersiz ID (GUID)

        [Required]
        public string ProductId { get; set; } // Kiralanacak ürün ID
        public Product Product { get; set; } // Ürün ile ilişki

        [Required]
        public string UserId { get; set; } // Kiralayan kullanıcı ID
        public User User { get; set; } // Kullanıcı ile ilişki

        [Required]
        public DateTime StartDate { get; set; } // Kiralama başlangıç tarihi

        [Required]
        public DateTime EndDate { get; set; } // Kiralama bitiş tarihi

        [Required]
        public decimal TotalAmount { get; set; } // Toplam tutar
    }
}
