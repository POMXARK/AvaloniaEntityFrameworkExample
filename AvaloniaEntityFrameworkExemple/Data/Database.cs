

using AvaloniaEntityFrameworkExemple.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

namespace AvaloniaEntityFrameworkExemple.Data
{
    public class Database : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public string DbPath { get; }

        public Database()
        {
            DbPath = Path.Join(AppDomain.CurrentDomain.BaseDirectory, "products.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite($"Data Source={DbPath}").UseLazyLoadingProxies();
        }
}

