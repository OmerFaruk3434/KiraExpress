using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagementService.Models
{
    [Table("UserRoles")]
    public class UserRole
    {
        [Key]
        public string UserRoleId { get; set; } = Guid.NewGuid().ToString(); // Benzersiz ID (GUID)

        public string UserId { get; set; } // KiraExpressUsers tablosuna Foreign Key
        public User User { get; set; } // Kullanıcı ile ilişkilendirme

        public string RoleId { get; set; } // KiraExpressRoles tablosuna Foreign Key
        public Role Role { get; set; } // Rol ile ilişkilendirme
    }
}
