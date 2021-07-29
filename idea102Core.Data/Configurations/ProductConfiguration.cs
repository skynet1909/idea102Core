using idea102Core.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace idea102Core.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Price).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.OriginalPrice).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.SortOrder).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.Stock).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.ViewCount).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.DateCreated).IsRequired().HasDefaultValue(DateTime.Now);
        }
    }
}
