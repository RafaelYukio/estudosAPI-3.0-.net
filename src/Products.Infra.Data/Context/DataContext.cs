using Microsoft.EntityFrameworkCore;
using Products.Domain.Entities;
using System.Reflection;

namespace Products.Infra.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Description> Descriptions { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
