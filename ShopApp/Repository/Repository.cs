using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected DbContext db;
        public Repository(DbContext _db)
        {
            db = _db;
        }
        public async Task Add(TEntity entity)
        {
            db.Set<TEntity>().Add(entity);
            await db.SaveChangesAsync();
        }

        public async Task DeleteById(object Id)
        {
            TEntity entity = db.Set<TEntity>().Find(Id);
            if (entity != null)
            {
                db.Set<TEntity>().Remove(entity);
                await db.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await db.Set<TEntity>().ToListAsync();
        }

        public TEntity GetById(object Id)
        {
            return db.Set<TEntity>().Find(Id);
        }

        public async Task Update(TEntity entity)
        {
            db.Set<TEntity>().Update(entity);
            await db.SaveChangesAsync();
        }
    }
}
