using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotificationManagementService.Models
{
    [Table("Notifications")]
    public class Notification
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString(); // Benzersiz ID (GUID)

        [Required]
        public string UserId { get; set; } // Bildirimin ait olduğu kullanıcı ID
                                           // Eğer kullanıcı yönetimi başka bir mikroserviste ise, bu sınıfı burada kullanmayabilirsiniz.

        [Required]
        [StringLength(255)]
        public string Message { get; set; } // Bildirim mesajı

        [Required]
        public DateTime CreatedAt { get; set; } // Bildirim oluşturulma tarihi

        public bool IsRead { get; set; } // Bildirimin okunup okunmadığı durumu
    }
}
