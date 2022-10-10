using ETicaret.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Domain.Entities
{
     public class Size: BaseEntity
    {
        public string SizeName { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
