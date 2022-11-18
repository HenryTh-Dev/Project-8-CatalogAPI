using CatalogAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CatalogAPI.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) :base(options)
        {
        }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Product>? Products { get; set; }  
    }
}
