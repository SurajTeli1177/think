using FizzWare.NBuilder;
using ShopApp.Models;
using ShopApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Unit.Test.Repository
{
    class ItemMockRepository : IItemRepository
    {

        public ItemMockRepository(List<Item> item)
        {

        }

        public async Task Add(Item entity)
        {
            var itemList = Builder<Item>.CreateListOfSize(10).Random(3).Build().ToList();
            itemList.Add(entity);
        }

        public Task DeleteById(object Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Item>> GetAll()
        {
            var itemList = Builder<Item>.CreateListOfSize(10).Random(3).Build().ToList();
            return itemList;
        }

        public Item GetById(object Id)
        {
            throw new NotImplementedException();
        }

        public async Task Update(Item entity)
        {
            var itemList = Builder<Item>.CreateListOfSize(10).Random(3).Build().ToList();
            itemList[0].Name = "Name";
        }
    }
}   
