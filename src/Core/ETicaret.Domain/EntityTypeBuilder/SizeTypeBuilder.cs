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
    public class SizeTypeBuilder : IEntityTypeConfiguration<Size>
    {
        public void Configure(EntityTypeBuilder<Size> builder)
        {
            builder.Property(x => x.SizeName)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(100);

            builder.HasMany(i => i.Products).WithOne(i => i.Size).HasForeignKey(i => i.SizeId);
           
        }
    }
}
