using Micro.ProductApi.Models;
using Microsoft.EntityFrameworkCore;

namespace Micro.ProdcutApi.Data
{
 
   public class ProductDbContext : DbContext
    {
        
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Stack> Stacks { get; set; }
    }
}
