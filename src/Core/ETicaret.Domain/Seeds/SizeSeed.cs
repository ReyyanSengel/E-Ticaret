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
    public class SizeSeed : IEntityTypeConfiguration<Size>
    {
        public void Configure(EntityTypeBuilder<Size> builder)
        {
            builder.HasData(
                new Size { Id = 1, SizeName = "32" },
                new Size { Id = 2, SizeName = "34" },
                new Size { Id = 3, SizeName = "36" },
                new Size { Id = 4, SizeName = "38" },
                new Size { Id = 5, SizeName = "40" },
                new Size { Id = 6, SizeName = "42" },
                new Size { Id = 7, SizeName = "44" }
                );
                

        }
    }
}
