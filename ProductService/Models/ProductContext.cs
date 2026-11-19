using Microsoft.EntityFrameworkCore;

namespace ProductService.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Product { get; set; }
    }

}
