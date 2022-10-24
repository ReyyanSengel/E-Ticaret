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
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, ProductName = "Coat", BrandId = 1, CategoryId = 1, ColorId = 4, SizeId = 4, Price = 800, Stock = 100 },
                new Product { Id = 2, ProductName = "Jacket", BrandId = 4, CategoryId = 1, ColorId = 2, SizeId = 5, Price = 500, Stock = 50 },
                new Product { Id = 3, ProductName = "Sandals", BrandId = 6, CategoryId = 3, ColorId = 5, SizeId = 3, Price = 400, Stock = 60 },
                new Product { Id = 4, ProductName = "Small Bag", BrandId = 7, CategoryId = 5, ColorId = 8, SizeId = 3, Price = 300, Stock = 10 },
                new Product { Id = 5, ProductName = "Skirt", BrandId = 1, CategoryId = 4, ColorId = 2, SizeId = 1, Price = 180, Stock = 50 },
                new Product { Id = 6, ProductName = "Backpack", BrandId = 10, CategoryId = 5, ColorId = 7, SizeId = 2, Price = 250, Stock = 30 },
                new Product { Id = 7, ProductName = "Boot", BrandId = 6, CategoryId = 3, ColorId = 7, SizeId = 3, Price = 500, Stock = 10 },
                new Product { Id = 8, ProductName = "Scarf", BrandId = 5, CategoryId = 1, ColorId = 4, SizeId = 2, Price = 50, Stock = 100 },
                new Product { Id = 9, ProductName = "Dress", BrandId = 9, CategoryId = 2, ColorId = 3, SizeId = 6, Price = 500, Stock = 100 },
                new Product { Id = 10, ProductName = "Rompers", BrandId = 2, CategoryId = 4, ColorId = 2, SizeId = 1, Price = 200, Stock = 10 }

                );
        }
    }
}
