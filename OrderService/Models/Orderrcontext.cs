using Microsoft.EntityFrameworkCore;

namespace OrderService.Models
{
    public class Orderrcontext
    {
        public class OrderrContext : DbContext
        {
            public OrderrContext(DbContextOptions options) : base(options)
            {
            }
            public DbSet<Orderr> Orderr { get; set; }
        }

    }
}
