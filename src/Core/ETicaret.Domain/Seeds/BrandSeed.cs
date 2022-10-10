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
    public class BrandSeed : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasData(
                new Brand { Id = 1, BrandName = "Mango" },
                new Brand { Id = 2, BrandName = "Zara" },
                new Brand { Id = 3, BrandName = "Yargıcı" },
                new Brand { Id = 4, BrandName = "İpekyol" },
                new Brand { Id = 5, BrandName = "AdilIşık" },
                new Brand { Id = 6, BrandName = "Twist" },
                new Brand { Id = 7, BrandName = "Network" },
                new Brand { Id = 8, BrandName = "Fabrika" },
                new Brand { Id = 9, BrandName = "Stradivarius" },
                new Brand { Id = 10, BrandName = "Bershka" }
                );

        }
    }
}
