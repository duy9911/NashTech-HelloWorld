using Microsoft.EntityFrameworkCore;
using FE_Core_Assignment__day_2_.Models;
using System.Collections.Generic;

namespace FE_Core_Assignment__day_2_.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasMany(a => a.Products).WithOne(p => p.category);
            modelBuilder.Entity<Category>().Property(a => a.CategoryId).ValueGeneratedOnAdd();
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = 1,
                CategoryName = "Category1",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                ProductName = "Product1",   
                CategoryId = 1,
            });
        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}