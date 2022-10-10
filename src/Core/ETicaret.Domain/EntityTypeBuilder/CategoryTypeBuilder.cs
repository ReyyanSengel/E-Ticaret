using ETicaret.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Domain.EntityTypeBuilder
{
    public class CategoryTypeBuilder : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.CategoryName)
               .IsRequired()
               .HasColumnType("nvarchar")
               .HasMaxLength(100);

            builder.HasMany(i => i.Products).WithOne(i => i.Category).HasForeignKey(i => i.CategoryId);
        }
    }
}
