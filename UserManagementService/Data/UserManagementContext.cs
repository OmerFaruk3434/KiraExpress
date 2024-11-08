using Microsoft.EntityFrameworkCore;
using UserManagementService.Models; // Model sınıflarının bulunduğu namespace

namespace UserManagementService.Data
{
    public class UserManagementContext : DbContext
    {
        public UserManagementContext(DbContextOptions<UserManagementContext> options) : base(options)
        {
        }

        // DbSet tanımlamaları
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserToken> UserTokens { get; set; }
        public DbSet<UserLog> UserLogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Kullanıcılar için anahtar tanımı
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id); // Id anahtar olarak tanımlanır
            });

            // Roller için anahtar tanımı
            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.RoleId); // RoleId anahtar olarak tanımlanır
            });

            // Kullanıcı rollerinin ilişkisi
            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasKey(e => e.UserRoleId); // UserRoleId anahtar olarak tanımlanır
            });

            // Tokenlar için anahtar tanımı
            modelBuilder.Entity<UserToken>(entity =>
            {
                entity.HasKey(e => e.TokenId); // TokenId anahtar olarak tanımlanır
            });

            // Loglar için anahtar tanımı
            modelBuilder.Entity<UserLog>(entity =>
            {
                entity.HasKey(e => e.LogId); // LogId anahtar olarak tanımlanır
            });
        }
    }
}
