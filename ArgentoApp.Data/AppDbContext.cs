using System;
using ArgentoApp.Entity.Concrete;
using ArgentoApp.Entity.Concrete.Abstact;
using Microsoft.EntityFrameworkCore;

namespace ArgentoApp.Data;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions options):base(options)
    {
        
    }
public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

}
