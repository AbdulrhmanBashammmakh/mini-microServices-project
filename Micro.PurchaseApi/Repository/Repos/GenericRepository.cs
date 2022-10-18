using Micro.PurchaseApi.Data;
using Micro.PurchaseApi.Repository.interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Micro.PurchaseApi.Repository.Repos
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected PurchaseDbContext context;
        internal DbSet<T> dbSet;
        public readonly ILogger _logger;
        public GenericRepository(
       PurchaseDbContext context,
       ILogger logger)
        {
            this.context = context;
            dbSet = context.Set<T>();
            _logger = logger;
        }

        public virtual async Task<IEnumerable<T>> All()
        {
            return await dbSet.ToListAsync();
        }

        public virtual async Task<T> GetById(int id)
        {

            return await dbSet.FindAsync(id);
        }

        public virtual async Task<bool> Add(T entity)
        {
            await dbSet.AddAsync(entity);
            return true;
        }

        public virtual async Task<bool> Delete(int id)
        {
            try
            {
                var x = await dbSet.FindAsync(id);
                if (x == null)
                {
                    return false;
                }
                dbSet.Remove(x);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public virtual Task<bool> Upsert(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate)
        {
            return await dbSet.Where(predicate).ToListAsync();
        }
    }
}
