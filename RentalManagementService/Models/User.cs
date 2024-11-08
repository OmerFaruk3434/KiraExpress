using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentalManagementService.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString(); // Benzersiz ID (GUID)

        [Required]
        [StringLength(100)]
        public string Username { get; set; } // Kullanıcı adı

        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; } // E-posta adresi

        [Required]
        [StringLength(15)]
        public string PhoneNumber { get; set; } // Telefon numarası (opsiyonel)

        public DateTime CreatedAt { get; set; } // Hesap oluşturulma tarihi
    }
}
