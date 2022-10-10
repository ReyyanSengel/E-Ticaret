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
    public class BrandTypeBuilder : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(x => x.BrandName)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(100);

            builder.HasMany(i => i.Products).WithOne(i => i.Brand).HasForeignKey(i => i.BrandId);

        }
    }
}
