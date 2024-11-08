using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndFilterManagementService.Models
{
    [Table("Filters")]
    public class Filter
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString(); // Benzersiz ID (GUID)

        [Required]
        [StringLength(100)]
        public string Name { get; set; } // Filtre adı (örn. "Fiyat", "Marka", "Kategori")

        public string Value { get; set; } // Filtre değeri (örn. "100-200" veya "Nike")
    }
}
