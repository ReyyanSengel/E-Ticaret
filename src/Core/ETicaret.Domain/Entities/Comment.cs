using ETicaret.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Domain.Entities
{
    public class Comment : BaseEntity
    {
        public string Comments { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
