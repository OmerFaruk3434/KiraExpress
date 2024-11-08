using Microsoft.EntityFrameworkCore;
using SearchAndFilterManagementService.Models;

namespace SearchAndFilterManagementService.Data
{
    public class SearchAndFilterManagementContext : DbContext
    {
        public SearchAndFilterManagementContext(DbContextOptions<SearchAndFilterManagementContext> options) : base(options)
        {
        }

        public DbSet<SearchQuery> SearchQueries { get; set; } // Arama sorguları tablosu
        public DbSet<Filter> Filters { get; set; } // Filtreler tablosu
        public DbSet<SearchResult> SearchResults { get; set; } // Arama sonuçları tablosu

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
