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
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = 1, CategoryName = "Outerwear" },
                new Category { Id = 2, CategoryName = "Underwear" },
                new Category { Id = 3, CategoryName = "Shoe" },
                new Category { Id = 4, CategoryName = "Kids clothing" },
                new Category { Id = 5, CategoryName = "Bag" }
                );

        }
    }
}
