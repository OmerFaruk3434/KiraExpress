using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaymentManagementService.Models
{
    [Table("Payments")]
    public class Payment
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString(); // Benzersiz ID (GUID)

        [Required]
        public string InvoiceId { get; set; } // İlgili fatura ID
        public Invoice Invoice { get; set; } // Fatura ile ilişki

        [Required]
        public decimal Amount { get; set; } // Ödeme tutarı

        [Required]
        public DateTime PaymentDate { get; set; } // Ödeme tarihi

        [Required]
        [StringLength(50)]
        public string PaymentMethod { get; set; } // Ödeme yöntemi (örn. Kredi Kartı, Nakit vb.)

        public string Status { get; set; } // Ödeme durumu (örn. Başarılı, Başarısız)
    }
}
