using Microsoft.EntityFrameworkCore;
using PaymentManagementService.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace PaymentManagementService.Data
{
    public class PaymentManagementContext : DbContext
    {
        public PaymentManagementContext(DbContextOptions<PaymentManagementContext> options) : base(options)
        {
        }

        public DbSet<Payment> Payments { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<PaymentUser> PaymentUsers { get; set; } // Eğer kullanıcı sınıfını kullanıyorsanız

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
