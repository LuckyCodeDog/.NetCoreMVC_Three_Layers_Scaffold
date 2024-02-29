using IService;
using IStore;
using System.Linq.Expressions;

namespace BusinessLogicLayer
{
    public class ServiceBase<T> : IServiceBase<T> where T : class

    {
        protected IStoreBase<T> storeBase;

        public ServiceBase(IStoreBase<T> storeBase)
        {
            this.storeBase = storeBase;
        }

        public async Task<bool> CreateAsync(T entity) => await this.storeBase.CreateAsync(entity) !=null;

        public async Task<bool> DeleteAsync(T entity) => await this.storeBase.DeleteAsync(entity) !=null;


        public async Task<T?> FindAsync(string id) => await this.storeBase.FindAsync(id);
    

        public  IQueryable<T> Query(Expression<Func<T, bool>> lambda)=>  this.storeBase.Query(lambda);
       

        public async Task<bool> UpdateAsync(T entity) => await this.storeBase.UpdateAsync(entity)!=null;
    }
}
