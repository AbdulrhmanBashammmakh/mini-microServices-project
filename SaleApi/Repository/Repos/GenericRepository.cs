using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SaleApi.Data;
using SaleApi.Repository.interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SaleApi.Repository.Repos
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected SaleDbContext context;
        internal DbSet<T> dbSet;
        public readonly ILogger _logger;
        public GenericRepository(
       SaleDbContext context,
       ILogger logger)
        {
            this.context = context;
            dbSet = context.Set<T>();
            _logger = logger;
        }

        public Task<IEnumerable<T>> All()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Add(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
