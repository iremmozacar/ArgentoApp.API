using System;
using ArgentoApp.Data.Concrete.Configs;
using ArgentoApp.Entity.Concrete;
using ArgentoApp.Entity.Concrete.Abstact;
using Microsoft.EntityFrameworkCore;

namespace ArgentoApp.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Cart> Carts { get; set ;}
    public DbSet<CartItem> CartItems { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       modelBuilder.ApplyConfigurationsFromAssembly(typeof(CategoryConfig).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
