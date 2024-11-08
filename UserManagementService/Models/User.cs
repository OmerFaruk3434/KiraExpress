using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagementService.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString(); // Benzersiz ID (GUID)

        [StringLength(50)]
        public string Username { get; set; } // Kullanıcı adı

        [StringLength(100)]
        public string PasswordHash { get; set; } // Şifre hash değeri

        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; } // E-posta adresi

        [StringLength(15)]
        public string PhoneNumber { get; set; } // Telefon numarası (opsiyonel)

        public DateTime CreatedAt { get; set; } // Hesap oluşturulma tarihi
        public DateTime? LastLogin { get; set; } // Son giriş tarihi (opsiyonel)
        public bool IsActive { get; set; } // Hesabın aktiflik durumu (true: aktif, false: devre dışı)

        // Navigation Property
        public ICollection<UserRole> UserRole { get; set; } // Kullanıcının rollerini ilişkilendirme
    }
}
