using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PrintLayer.Models;

namespace PrintLayer.Data
{
    public class DataSeedingContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public DbSet<User> Users { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Review> Reviews { get; set; }

        public DataSeedingContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));

        //public void Seed(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<User>(entity => { entity.Property(e => e.Email).IsRequired(); });

        //    modelBuilder.Entity<User>().HasData(new User
        //    {
        //        Email = "admin",
        //        PasswordHash = "a322b9c0b8e19ef16d4d308cd4e1222106d0edf8fbb3c8f1649242dff54a740c",
        //        EmailConfirmed = true
        //    });
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>(entity => { entity.Property(e => e.Email).IsRequired(); });

            //modelBuilder.Entity<User>().HasData(new User 
            //    { 
            //        Email = "admin",
            //        PasswordHash = "a322b9c0b8e19ef16d4d308cd4e1222106d0edf8fbb3c8f1649242dff54a740c",
            //        EmailConfirmed = true
            //    });

            modelBuilder.Entity<News>(entity => { entity.Property(e => e.Name).IsRequired(); });

            modelBuilder.Entity<News>().HasData(new News
            {
                Name = "Test Name",
                Description = "This is a test news description"
            });

            //modelBuilder.Entity<Blog>(entity => { entity.Property(e => e.Url).IsRequired(); });

            //#region BlogSeed
            //modelBuilder.Entity<Blog>().HasData(new Blog { BlogId = 1, Url = "http://sample.com" });
            //#endregion

            //modelBuilder.Entity<Post>(
            //    entity =>
            //    {
            //        entity.HasOne(d => d.Blog)
            //            .WithMany(p => p.Posts)
            //            .HasForeignKey("BlogId");
            //    });

            //#region PostSeed
            //modelBuilder.Entity<Post>().HasData(
            //    new Post { BlogId = 1, PostId = 1, Title = "First post", Content = "Test 1" });
            //#endregion

            //#region AnonymousPostSeed
            //modelBuilder.Entity<Post>().HasData(
            //    new { BlogId = 1, PostId = 2, Title = "Second post", Content = "Test 2" });
            //#endregion

            //#region OwnedTypeSeed
            //modelBuilder.Entity<Post>().OwnsOne(p => p.AuthorName).HasData(
            //    new { PostId = 1, First = "Andriy", Last = "Svyryd" },
            //    new { PostId = 2, First = "Diego", Last = "Vega" });
            //#endregion
        }
    }
}
