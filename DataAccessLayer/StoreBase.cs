using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using IStore;
using Microsoft.EntityFrameworkCore;
using Store.DataBase;
namespace Store
{
    public class StoreBase<T> : IStoreBase<T> where T : class
    {
        private AppDbContext _db = AppFactoryContext.AppDbContext();

        public async Task<T> CreateAsync(T entity)
        {
            await _db.AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<T> DeleteAsync(T entity)
        {
            _db.Remove(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<T?> FindAsync(string id)
        {
            return await _db.FindAsync<T>(new Guid(id));

        }

        public IQueryable<T> Query(Expression<Func<T, bool>> predicate)
        {
            return _db.Set<T>().AsNoTracking().Where<T>(predicate);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _db.Update<T>(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
