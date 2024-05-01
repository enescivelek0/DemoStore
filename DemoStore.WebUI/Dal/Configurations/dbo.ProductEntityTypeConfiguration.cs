using DemoStore.WebUI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace DemoStore.WebUI
{
    public class dbo_ProductEntityTypeConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .HasKey(x => x.ProductId);

            builder
                .Property(x => x.ProductId)
                .HasColumnName("ProductId")
                .HasPrecision(10, 0);

            builder
                .Property(x => x.ProductImageUrl)
                .HasColumnName("ProductImageUrl")
                .IsUnicode(true);

            builder
                .ToTable("Product", "dbo");
        }
    }
}
