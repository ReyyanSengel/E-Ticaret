using ETicaret.Application.Interfaces.IRepository;
using ETicaret.Domain.Entities;
using ETicaret.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Persistence.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        
        public ProductRepository(ETicaretContext context) : base(context)
        {
        }

        //public async Task<List<Product>> GetProductWithAll()
        //{
        //    return await _context.Products
        //      .Include(x => x.Brand)
        //       .Include(x => x.Category)
        //       .Include(x => x.Color)
        //       .Include(x => x.Comments)
        //       .Include(x => x.Size)
        //       .ToListAsync();
        //}

       

       

        

    }
}
