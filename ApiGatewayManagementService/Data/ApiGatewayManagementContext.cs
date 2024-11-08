using Microsoft.EntityFrameworkCore;
using ApiGatewayManagementService.Models; // Model sınıflarının bulunduğu namespace

namespace ApiGatewayManagementService.Data
{
    public class ApiGatewayManagementContext : DbContext
    {
        public ApiGatewayManagementContext(DbContextOptions<ApiGatewayManagementContext> options) : base(options)
        {
        }

        public DbSet<Models.Route> Routes { get; set; } // Route tablosu
        public DbSet<ApiKey> ApiKeys { get; set; } // API Anahtarları tablosu
        public DbSet<RateLimit> RateLimits { get; set; } // Rate Limiting tablosu

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
