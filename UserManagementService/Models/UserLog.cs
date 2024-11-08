using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagementService.Models
{
    [Table("UserLogs")]
    public class UserLog
    {
        [Key]
        public string LogId { get; set; } = Guid.NewGuid().ToString(); // Benzersiz Log ID (GUID)

        public string UserId { get; set; } // KiraExpressUsers tablosuna Foreign Key
        public User User { get; set; } // Kullanıcı ile ilişkilendirme

        [StringLength(50)]
        public string Action { get; set; } // Yapılan işlem türü (örn: "Login", "Logout")
        public DateTime Timestamp { get; set; } // İşlemin yapıldığı tarih ve saat
        [StringLength(45)]
        public string IPAddress { get; set; } // İşlemin yapıldığı IP adresi (opsiyonel)
        public bool Success { get; set; } // İşlemin başarılı olup olmadığını gösterir
    }
}
