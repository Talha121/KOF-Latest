using KOF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KOF.EntityConfigurations
{
    internal class ProductImageConfiguration : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.ToTable("ProductImage");
            builder.Property(x => x.Id).HasColumnName("ProductImageId");
            builder.HasKey(x => x.Id);
            builder.HasOne<Product>(sc => sc.Product)
                .WithMany(s => s.ProductImages)
                .HasForeignKey(sc => sc.ProductId);
        }
    }
}
