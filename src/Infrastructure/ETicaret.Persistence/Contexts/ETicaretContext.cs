using ETicaret.Domain.Entities;
using ETicaret.Domain.EntityTypeBuilder;
using ETicaret.Domain.Seeds;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Persistence.Contexts
{
    public class ETicaretContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public ETicaretContext(DbContextOptions<ETicaretContext> options) : base(options)
        {
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Size> Sizes { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                 .ApplyConfiguration(new BrandTypeBuilder())
                 .ApplyConfiguration(new CategoryTypeBuilder())
                 .ApplyConfiguration(new ColorTypeBuilder())
                 .ApplyConfiguration(new CommentTypeBuilder())
                 .ApplyConfiguration(new ProductTypeBuilder())
                 .ApplyConfiguration(new SizeTypeBuilder());


            builder
                .ApplyConfiguration(new BrandSeed())
                .ApplyConfiguration(new ColorSeed())
                .ApplyConfiguration(new CategorySeed())
                .ApplyConfiguration(new CommentSeed())
                .ApplyConfiguration(new ProductSeed())
                .ApplyConfiguration(new SizeSeed());

            base.OnModelCreating(builder);
        }
    }
}
