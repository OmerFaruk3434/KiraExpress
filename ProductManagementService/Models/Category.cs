using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductManagementService.Models
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString(); // Benzersiz ID (GUID)

        [Required]
        [StringLength(50)]
        public string Name { get; set; } // Kategori adı

        public ICollection<Product> Products { get; set; } // İlişkilendirilmiş ürünler
    }
}
