using ExemploWebApiEfInMemory.Infrastruture.Models;
using Microsoft.EntityFrameworkCore;

namespace ExemploWebApiEfInMemory.Infrastruture.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }


    }
}
