using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopApp.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll();
        TEntity GetById(object Id);
        Task DeleteById(object Id);
        Task Add(TEntity entity);
        Task Update(TEntity entity);
        //void SaveChanges();
    }
}
