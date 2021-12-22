using Microsoft.EntityFrameworkCore;
using System;
using PrintLayer.Models;

namespace PrintLayer.Data
{
    public class Context : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public Context(DbContextOptions<Context> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
