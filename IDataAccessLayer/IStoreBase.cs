using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IStore
{
    public interface IStoreBase<T>
    {
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
        Task<T?> FindAsync(string id);
        IQueryable<T> Query(Expression<Func<T, bool>> predicate);
    }
}
