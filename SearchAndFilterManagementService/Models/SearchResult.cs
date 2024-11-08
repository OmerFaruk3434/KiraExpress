using SearchAndFilterManagementService.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndFilterManagementService.Models
{
    [Table("SearchResults")]
    public class SearchResult
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString(); // Benzersiz ID (GUID)

        public string SearchQueryId { get; set; } // İlişkili arama sorgusu ID
        public SearchQuery SearchQuery { get; set; } // Arama sorgusu ile ilişki

        public string ProductId { get; set; } // İlişkili ürün ID
        // İlgili ürün bilgilerini almak için başka bir servis kullanılması gerekebilir
    }
}
