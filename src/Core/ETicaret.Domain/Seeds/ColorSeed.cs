using ETicaret.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Domain.Seeds
{
    public class ColorSeed : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.HasData(
                new Color { Id = 1, ColorName = "Yellow" },
                new Color { Id = 2, ColorName = "Red" },
                new Color { Id = 3, ColorName = "Green" },
                new Color { Id = 4, ColorName = "Pink" },
                new Color { Id = 5, ColorName = "Orange" },
                new Color { Id = 6, ColorName = "Blue" },
                new Color { Id = 7, ColorName = "Black" },
                new Color { Id = 8, ColorName = "White" }
                );
        }
    }
}
