using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReviewManagementService.Models
{
    [Table("Comments")]
    public class Comment
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString(); // Benzersiz ID (GUID)

        [Required]
        public string ReviewId { get; set; } // Yorumun ait olduğu inceleme ID
        public Review Review { get; set; } // İnceleme ile ilişki

        [Required]
        public string UserId { get; set; } // Yorumu yazan kullanıcı ID
        public User User { get; set; } // Kullanıcı ile ilişki

        [Required]
        [StringLength(250)]
        public string Content { get; set; } // Yorum içeriği

        [Required]
        public DateTime CreatedAt { get; set; } // Yorumun oluşturulma tarihi
    }
}
