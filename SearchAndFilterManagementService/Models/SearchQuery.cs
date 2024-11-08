using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndFilterManagementService.Models
{
    [Table("SearchQueries")]
    public class SearchQuery
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString(); // Benzersiz ID (GUID)

        [Required]
        [StringLength(200)]
        public string Query { get; set; } // Arama sorgusu

        [Required]
        public DateTime SearchDate { get; set; } // Arama tarihi

        public string UserId { get; set; } // Sorguyu gerçekleştiren kullanıcı ID (isteğe bağlı)
    }
}
