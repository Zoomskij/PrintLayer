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
        public DbSet<Order> Orders { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<News> News { get; set; }
        public Context(DbContextOptions<Context> options, IConfiguration configuration) : base(options)
        {
           //Database.EnsureCreated();
            #region CustomSeeding
            using (var context = new DataSeedingContext(configuration))
            {
                context.Database.EnsureCreated();
                context.News.Add(new News {Name = "Test Name", Description = "This is a test news description"});
                //var testBlog = context.Blogs.FirstOrDefault(b => b.Url == "http://test.com");
                //if (testBlog == null)
                //{
                //    context.Blogs.Add(new Blog { Url = "http://test.com" });
                //}

                context.SaveChanges();
            }
            #endregion
        }
    }
}
