using ETicaret.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public int ColorId { get; set; }
        public Color Color { get; set; }

        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        public int SizeId { get; set; }
        public Size Size { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<Comment> Comments { get; set; }



    }
}
