using idea102Core.Data.Entities;
using idea102Core.Data.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace idea102Core.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.SortOrder).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.IsShowOnHome).HasDefaultValue(false);
            builder.Property(x => x.ParentId).HasDefaultValue(0);
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
        }
    }
}
