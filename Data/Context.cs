using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PrintLayer.Models;

namespace PrintLayer.Data
{
    public class Context : IdentityDbContext<User>
    {
        private readonly IConfiguration _configuration;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        public DbSet<Order> Orders { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<News> News { get; set; }
        public Context(DbContextOptions<Context> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
            Database.EnsureCreated();
            //using var context = new DataSeedingContext(options, configuration);
            //context.Database.EnsureCreated();
            //context.SaveChanges();

            #region CustomSeeding

            #endregion
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }

    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<News>(entity => { entity.Property(e => e.Id).IsRequired(); });

            modelBuilder.Entity<News>().HasData(new News
            {
                Name = "Test Name",
                Description = "This is a test news description"
            });
        }
    }
}
