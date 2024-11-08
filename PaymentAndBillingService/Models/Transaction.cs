using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaymentManagementService.Models
{
    [Table("Transactions")]
    public class Transaction
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString(); // Benzersiz ID (GUID)

        [Required]
        public string PaymentId { get; set; } // İlgili ödeme ID
        public Payment Payment { get; set; } // Ödeme ile ilişki

        [Required]
        public string TransactionType { get; set; } // İşlem türü (örn. Debit, Credit)

        [Required]
        public decimal Amount { get; set; } // İşlem tutarı

        [Required]
        public DateTime TransactionDate { get; set; } // İşlem tarihi
    }
}
