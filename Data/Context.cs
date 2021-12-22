using Microsoft.EntityFrameworkCore;
using System;

namespace PrintLayer.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
