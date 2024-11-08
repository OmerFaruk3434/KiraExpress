using Microsoft.EntityFrameworkCore;
using RentalManagementService.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace RentalManagementService.Data
{
    public class RentalManagementContext : DbContext
    {
        public RentalManagementContext(DbContextOptions<RentalManagementContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
