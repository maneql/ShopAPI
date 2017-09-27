using ShopAPI.Models;
using Microsoft.EntityFrameworkCore;
namespace ShopAPI.Data
{
    public class ObjectContext : DbContext
    {
        public ObjectContext(DbContextOptions<ObjectContext> options) : base(options) { }
        public ObjectContext() { }
        public DbSet<Category> Categorys { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}
