using ETicaret.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Domain.Entities
{
    public class Brand : BaseEntity
    {
        public string BrandName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}

