using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagementService.Models
{
    [Table("UserTokens")]
    public class UserToken
    {
        [Key]
        public string TokenId { get; set; } = Guid.NewGuid().ToString(); // Benzersiz Token ID (GUID)

        public string UserId { get; set; } // KiraExpressUsers tablosuna Foreign Key
        public User User { get; set; } // Kullanıcı ile ilişkilendirme

        [StringLength(500)]
        public string Token { get; set; } // Erişim token değeri
        public DateTime ExpiryDate { get; set; } // Token’ın geçerlilik süresi
        public DateTime CreatedAt { get; set; } // Token’ın oluşturulma tarihi
        public bool IsRevoked { get; set; } // Token’ın geçersiz olup olmadığını belirtir
    }
}
