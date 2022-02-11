using ShopApp.Models;
using ShopApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.Business
{
    public interface IItemService
    {
        Task<IEnumerable<Item>> GetAll();
        Task AddItem(Item item);
        Item GetById(int id);
        Task UpdateItem(Item item);
        Task DeleteById(int id);
    }
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;
        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }
        public async Task<IEnumerable<Item>> GetAll()
        {
            return await _itemRepository.GetAll();
        }

        public async Task AddItem(Item item)
        {
            await _itemRepository.Add(item);
        }

        public Item GetById(int id)
        {
            return _itemRepository.GetById(id);
        }

        public async Task UpdateItem(Item item)
        {
             await  _itemRepository.Update(item);
        }

        public async Task DeleteById(int id)
        {
            await _itemRepository.DeleteById(id);
        }

    }
}
