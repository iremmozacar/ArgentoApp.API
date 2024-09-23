using System;
using ArgentoApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArgentoApp.Data.Concrete.Configs;

public class CancelledOrderConfig : IEntityTypeConfiguration<CancelledOrder>
{
    public void Configure(EntityTypeBuilder<CancelledOrder> builder)
    {
        builder.HasKey(c => c.Id);
        builder.HasMany(c => c.OrderItems)
              .WithOne(oi => oi.CancelledOrder)
              .HasForeignKey(oi => oi.CancelledOrderId);
    }

}
