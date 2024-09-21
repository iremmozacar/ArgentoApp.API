using System;
using ArgentoApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArgentoApp.Data.Concrete.Configs;

public class CartConfig : IEntityTypeConfiguration<Cart>
{
    public void Configure(EntityTypeBuilder<Cart> builder)
    {
        builder.HasData(
         new Cart { Id = 1, CreatedDate = DateTime.Now, UserId = "1" }
        );
    }
}
