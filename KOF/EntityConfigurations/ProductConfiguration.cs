using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KOF.Models;

namespace KOF.EntityConfigurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.Property(x => x.Id).HasColumnName("ProductId");
            builder.HasKey(x => x.Id);
            builder.HasOne<Category>(sc => sc.Category)
                .WithMany(s => s.Product)
                .HasForeignKey(sc => sc.CategoryId);
        }
    }
}
