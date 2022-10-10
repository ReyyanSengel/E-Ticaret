using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Application.Interfaces.IUnitOfWork
{
    public interface IUnitOfWork
    {
        Task CommitAync();
        void Commit();
    }
}
