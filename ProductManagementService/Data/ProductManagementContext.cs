using Microsoft.EntityFrameworkCore;
using ProductManagementService.Models;

namespace ProductManagementService.Data
{
    public class ProductManagementContext : DbContext
    {
        public ProductManagementContext(DbContextOptions<ProductManagementContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
