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
    public class ColorTypeBuilder : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.Property(x => x.ColorName)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(100);

            builder.HasMany(i => i.Products).WithOne(i => i.Color).HasForeignKey(i => i.ColorId);
        }
    }
}
