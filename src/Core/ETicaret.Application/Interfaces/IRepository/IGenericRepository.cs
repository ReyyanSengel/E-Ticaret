using ETicaret.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Application.Interfaces.IRepository
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> GetByIdAsync(int id);
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression);
        TEntity Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);

    }
}

