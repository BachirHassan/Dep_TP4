using WebApplication2.Models;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Configurations;

namespace WebApplication2.Data.Context
{
    public class FruitContext : DbContext
    {
        public DbSet<Fruit> Fruit { get; set; }
        public FruitContext(DbContextOptions<FruitContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Fruit>(new FruitConfiguration());
        }

    }
}
