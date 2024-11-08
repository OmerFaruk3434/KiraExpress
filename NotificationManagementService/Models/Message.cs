using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotificationManagementService.Models
{
    [Table("Messages")]
    public class Message
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString(); // Benzersiz ID (GUID)

        [Required]
        public string SenderId { get; set; } // Mesajı gönderen kullanıcı ID

        [Required]
        public string ReceiverId { get; set; } // Mesajı alan kullanıcı ID

        [Required]
        [StringLength(500)]
        public string Content { get; set; } // Mesaj içeriği

        [Required]
        public DateTime SentAt { get; set; } // Mesajın gönderildiği tarih
    }
}
