using ETicaret.Application.Interfaces.IRepository;
using ETicaret.Domain.Common;
using ETicaret.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Persistence.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity:BaseEntity
    {
        protected readonly ETicaretContext _context;
        private readonly DbSet<TEntity> _dbset;

        public GenericRepository(ETicaretContext context)
        {
            _context = context;
            _dbset = _context.Set<TEntity>();
        }

        public TEntity Add(TEntity entity)
        {
             _dbset.Add(entity);
            return entity;
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await _dbset.AnyAsync(expression);
        }

        public IQueryable<TEntity> GetAll()
        {
           return _dbset.AsNoTracking().AsQueryable();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _dbset.FindAsync();
        }

        public void Remove(TEntity entity)
        {
             _dbset.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            _dbset.Update(entity);
        }

        public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression)
        {
            return _dbset.Where(expression);
        }

       
    }
}
