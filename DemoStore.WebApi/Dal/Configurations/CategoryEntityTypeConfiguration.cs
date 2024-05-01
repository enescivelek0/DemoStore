using DemoStore.WebApi;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace DemoStore.WebApi
{
    public class CategoryEntityTypeConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
                .HasKey(x => x.CategoryId);

            builder
                .Property(x => x.CategoryId)
                .HasColumnName("CategoryId")
                .HasPrecision(10, 0);

            builder
                .Property(x => x.CategoryName)
                .HasColumnName("CategoryName")
                .IsUnicode(true);

            builder
                .Property(x => x.CastegoryStatus)
                .HasColumnName("CastegoryStatus");

            builder
                .ToTable("Category", "dbo");
        }
    }
}
