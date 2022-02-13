using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KOF.Models;

namespace KOF.EntityConfigurations
{
    internal class InventoryConfiguration : IEntityTypeConfiguration<Inventory>
    {
        public void Configure(EntityTypeBuilder<Inventory> builder)
        {
            builder.ToTable("Inventory");
            builder.Property(x => x.Id).HasColumnName("InventoryId");
            builder.HasKey(x => x.Id);
            builder.HasOne<Product>(sc => sc.Product)
                .WithMany(s => s.Inventories)
                .HasForeignKey(sc => sc.ProductId);
            builder.HasOne<Supplier>(sc => sc.Supplier)
               .WithMany(s => s.Inventories)
               .HasForeignKey(sc => sc.SupplierId);
        }
    }
}
