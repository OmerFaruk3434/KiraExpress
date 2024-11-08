using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagementService.Models
{
    [Table("Roles")]
    public class Role
    {
        [Key]
        public string RoleId { get; set; } = Guid.NewGuid().ToString(); // Benzersiz Rol ID (GUID)

        [StringLength(50)]
        public string RoleName { get; set; } // Rol adı (örn: "Admin", "Customer")

        [StringLength(200)]
        public string Description { get; set; } // Rol açıklaması (opsiyonel)
    }
}
