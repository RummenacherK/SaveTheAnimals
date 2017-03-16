using SaveTheAnimals.Models;
using Microsoft.EntityFrameworkCore;

namespace SaveTheAnimals.Data
{
    public class StaDbContext : DbContext
    {
        public StaDbContext() { }

        public StaDbContext(DbContextOptions<StaDbContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }

        public DbSet<Species> Species { get; set; } //set to public to access
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Donation> Donation { get; set; }
        public DbSet<StatusCode> StatusCode { get; set; }
        public DbSet<CountryCode> CountryCode { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Species>().ToTable("Species");
        //}
    }
}