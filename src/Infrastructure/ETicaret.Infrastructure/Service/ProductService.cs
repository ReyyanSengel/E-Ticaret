using ETicaret.Application.Interfaces.IRepository;
using ETicaret.Application.Interfaces.IService;
using ETicaret.Application.Interfaces.IUnitOfWork;
using ETicaret.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Infrastructure.Service
{
    public class ProductService : GenericService<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IUnitOfWork unitOfWork, IGenericRepository<Product> repository, IProductRepository productRepository) : base(unitOfWork, repository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<Product>> GetProductWithAll()
        {
            return await _productRepository.GetAll()
              .Include(x => x.Brand)
               .Include(x => x.Category)
               .Include(x => x.Color)
               .Include(x => x.Comments)
               .Include(x => x.Size)
               .ToListAsync();
        }
        public Product GetProductId(int id)
        {
            var result = _productRepository.GetAll()
                .Where(x => x.Id == id)
                .Include(x => x.Category)
                .Include(x => x.Brand)
                .Include(x => x.Color)
                .Include(x => x.Size)
                .Include(x => x.Comments)
                .FirstOrDefault();
            return result;
        }









    }
}
