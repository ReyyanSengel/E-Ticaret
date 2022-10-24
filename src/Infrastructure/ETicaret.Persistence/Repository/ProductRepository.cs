using ETicaret.Application.Interfaces.IRepository;
using ETicaret.Domain.Entities;
using ETicaret.Persistence.Context;
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
    }
}









