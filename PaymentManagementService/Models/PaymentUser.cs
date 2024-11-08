using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaymentManagementService.Models
{
    [Table("PaymentUsers")]
    public class PaymentUser
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
        public string PasswordHash { get; set; } // Şifre hash değeri

        [Required]
        public DateTime CreatedAt { get; set; } // Hesap oluşturulma tarihi

        public DateTime? LastLogin { get; set; } // Son giriş tarihi (opsiyonel)

        public bool IsActive { get; set; } // Hesabın aktiflik durumu (true: aktif, false: devre dışı)
    }
}
