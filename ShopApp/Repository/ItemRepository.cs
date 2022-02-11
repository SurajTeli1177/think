using ShopApp.Data;
using ShopApp.Models;

namespace ShopApp.Repository
{
    public class ItemRepository : Repository<Item>, IItemRepository
    {
        DataModelContext context
        {
            get
            {
                return db as DataModelContext;
            }
        }
        public ItemRepository(DataModelContext _db) : base(_db)
        {

        }
    }
}
