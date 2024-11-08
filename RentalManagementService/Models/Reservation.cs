using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentalManagementService.Models
{
    [Table("Reservations")]
    public class Reservation
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString(); // Benzersiz ID (GUID)

        [Required]
        public string ProductId { get; set; } // Rezervasyon yapılan ürün ID
        public Product Product { get; set; } // Ürün ile ilişki

        [Required]
        public string UserId { get; set; } // Rezervasyon yapan kullanıcı ID
        public User User { get; set; } // Kullanıcı ile ilişki

        [Required]
        public DateTime ReservationDate { get; set; } // Rezervasyon tarihi

        [Required]
        public DateTime StartDate { get; set; } // Rezervasyon başlangıç tarihi

        [Required]
        public DateTime EndDate { get; set; } // Rezervasyon bitiş tarihi
    }
}
