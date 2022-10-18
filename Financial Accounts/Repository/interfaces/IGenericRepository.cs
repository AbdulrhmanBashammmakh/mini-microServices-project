using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Financial_Accounts.Repository.interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> All();
        Task<T> GetById(int id);
        Task<bool> Add(T entity);
        Task<bool> Delete(int id);
        Task<bool> Update(T entity);
        Task<bool> Insert(T entity);
        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate);
    }

}
