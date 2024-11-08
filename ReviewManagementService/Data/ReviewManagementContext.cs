using Microsoft.EntityFrameworkCore;
using ReviewManagementService.Models; // Model sınıflarının bulunduğu namespace

namespace ReviewManagementService.Data
{
    public class ReviewManagementContext : DbContext
    {
        public ReviewManagementContext(DbContextOptions<ReviewManagementContext> options) : base(options)
        {
        }

        // DbSet tanımlamaları
        public DbSet<Product> Products { get; set; } // Ürünler tablosu
        public DbSet<User> Users { get; set; } // Kullanıcılar tablosu
        public DbSet<Review> Reviews { get; set; } // İncelemeler tablosu
        public DbSet<Comment> Comments { get; set; } // Yorumlar tablosu

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Yorumlar için anahtar tanımı
            modelBuilder.Entity<Comment>(entity =>
            {
                entity.HasKey(e => e.Id); // Id anahtar olarak tanımlanır

                // Dış anahtar ilişkileri
                entity.HasOne(c => c.Review)
                      .WithMany(r => r.Comments) // Burada r.Comments artık geçerli
                      .HasForeignKey(c => c.ReviewId)
                      .OnDelete(DeleteBehavior.Restrict); // Kaskad silmeyi engelle

                entity.HasOne(c => c.User)
                      .WithMany(u => u.Comments)
                      .HasForeignKey(c => c.UserId)
                      .OnDelete(DeleteBehavior.Restrict); // Kaskad silmeyi engelle
            });
        }
    }
}
