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
    public class ProductTypeBuilder : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.ProductName)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(100);
            builder.Property(x => x.Price)
                .IsRequired()
                .HasColumnType("decimal(18,2)");
                
            builder.Property(x => x.Stock)
                .IsRequired()
                .HasColumnType("int")
                .HasMaxLength(50);

          
          
           

           
               

        }
    }
}
