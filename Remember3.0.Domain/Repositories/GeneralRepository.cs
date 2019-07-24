using Remember3._0.Domain.Interfaces;
using Remember3._0.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remember3._0.Domain.Repositories
{
    public class GeneralRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        ProductContext _context;
        DbSet<TEntity> _dbSet;

        public GeneralRepository(ProductContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public void Create(TEntity Entity)
        {
            if (Entity!=null)
            {
                _dbSet.Add(Entity);
            }
        }

        public void Delete(int id)
        {
           var delete_entity= _dbSet.Find(id);
            if (delete_entity!=null)
            {
                _dbSet.Remove(delete_entity);
            }
        }

        public void Edit(TEntity Entity)
        {
            if (Entity!=null)
            {
                _context.Entry(Entity).State = EntityState.Modified;
            }
        }

        public TEntity Get(int id)
        {
            return _dbSet.Find(id);

        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.AsNoTracking().ToList();
        }
    }
}
