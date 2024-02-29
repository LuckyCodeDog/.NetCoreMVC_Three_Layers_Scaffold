using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IService
{
    public interface IServiceBase<T> where T : class
    {
      
        Task<bool> CreateAsync(T entity);
   
        Task<bool> UpdateAsync(T entity);

        Task<bool> DeleteAsync(T entity);

        Task<T?> FindAsync(string id);
  
        IQueryable<T> Query(Expression<Func<T, bool>> lambda);
    }
}
