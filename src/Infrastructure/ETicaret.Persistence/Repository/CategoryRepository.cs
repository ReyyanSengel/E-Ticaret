using ETicaret.Application.Interfaces.IRepository;
using ETicaret.Domain.Entities;
using ETicaret.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Persistence.Repository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ETicaretContext context) : base(context)
        {
        }
    }
}
