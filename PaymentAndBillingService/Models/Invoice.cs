using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaymentManagementService.Models
{
    [Table("Invoices")]
    public class Invoice
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString(); // Benzersiz ID (GUID)

        [Required]
        public string UserId { get; set; } // Faturanın ait olduğu kullanıcı ID

        // Kullanıcı ile ilişki
        public User User { get; set; } // User sınıfına referans

        [Required]
        public decimal TotalAmount { get; set; } // Toplam fatura tutarı

        [Required]
        public DateTime InvoiceDate { get; set; } // Fatura tarihi

        public string Status { get; set; } // Fatura durumu (örn. Ödenmiş, Ödenmemiş)
    }
}
