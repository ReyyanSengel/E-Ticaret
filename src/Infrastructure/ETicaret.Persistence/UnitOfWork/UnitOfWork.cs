using ETicaret.Application.Interfaces.IUnitOfWork;
using ETicaret.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Persistence.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ETicaretContext _context;

        public UnitOfWork(ETicaretContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
