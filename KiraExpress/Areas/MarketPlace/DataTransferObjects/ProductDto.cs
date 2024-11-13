using System.ComponentModel.DataAnnotations;

namespace KiraExpress.Areas.MarketPlace.DataTransferObjects
{
    public class ProductDto
    {
        [Required]
        [StringLength(100, ErrorMessage = "Ürün adı 100 karakterden fazla olamaz.")]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Range(0.01, 10000, ErrorMessage = "Fiyat 0 ile 10.000 arasında olmalıdır.")]
        public decimal Price { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
