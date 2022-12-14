using ETicaret.Application.ViewModels;
using ETicaret.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Application.Interfaces.IService
{
    public interface IProductService : IGenericService<Product>
    {
        Task<List<Product>> GetProductWithAll();
        Product GetProductId(int id);
    }
}


