using Microsoft.EntityFrameworkCore;
using ProductManagementService.Models; // Model sınıflarının bulunduğu namespace

namespace ProductManagementService.Data
{
    public class ProductManagementContext : DbContext
    {
        public ProductManagementContext(DbContextOptions<ProductManagementContext> options) : base(options)
        {
        }

        // DbSet tanımlamaları
        public DbSet<Product> Products { get; set; } // Ürünler tablosu
        public DbSet<Category> Categories { get; set; } // Kategoriler tablosu
        public DbSet<Review> Reviews { get; set; } // İncelemeler tablosu
        public DbSet<Order> Orders { get; set; } // Siparişler tablosu

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Product ayarları
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Id); // Product anahtarı
            });

            // Category ayarları
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.Id); // Category anahtarı
            });

            // Review ayarları
            modelBuilder.Entity<Review>(entity =>
            {
                entity.HasKey(e => e.Id); // Review anahtarı
            });

            // Order ayarları
            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.Id); // Order anahtarı
            });
        }
    }
}
