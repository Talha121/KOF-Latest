using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KOF.Models;

namespace KOF.EntityConfigurations
{
    internal class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable("OrderItem");
            builder.Property(x => x.Id).HasColumnName("OrderItemId");
            builder.HasKey(x => x.Id);
            builder.HasOne<Order>(sc => sc.Order)
                .WithMany(s => s.OrderItems)
                .HasForeignKey(sc => sc.OrderId);
            builder.HasOne<Product>(sc => sc.Product)
               .WithMany(s => s.OrderItems)
               .HasForeignKey(sc => sc.ProductId);
        }
    }
}
