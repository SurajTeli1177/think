
using FizzWare.NBuilder;
using ShopApp.Business;
using ShopApp.Models;
using ShopApp.Unit.Test.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace ShopApp.Unit.Test.Service
{
    public class ItemServiceTest
    {
        private ItemService itemService;

        [Fact]
        public async Task GetAll_Test()
        {
            //Arrange
            var itemList = Builder<Item>.CreateListOfSize(10).Random(3).Build().ToList();
            var itemMockRepository = new ItemMockRepository(itemList);
            //Act
            itemService = new ItemService(itemMockRepository);
            var response = await itemService.GetAll();
            //Assert
            Assert.IsType<List<Item>>(response);
        }

        [Fact]
        public async Task AddItem_Unit_Test()
        {
            //Arrange
            var itemList = Builder<Item>.CreateListOfSize(10).Random(3).Build().ToList();
            Item item = new Item()
            {
                Name = "Item1",
                Discription = "Discription",
                Price = 25
            };
            var itemMockRepository = new ItemMockRepository(itemList);
            //Act
            itemService = new ItemService(itemMockRepository);
            var count = ( await itemMockRepository.GetAll()).Count();
            await itemService.AddItem(item);
            var count1 = (await itemMockRepository.GetAll()).Count();
            //Assert
            Assert.Equal(count , count1);
        }

        [Fact]
        public async Task UpdateItem_Unit_Test()
        {
            //Arreange
            var itemList = Builder<Item>.CreateListOfSize(10).Random(3).Build().ToList();
            var itemMockRepository = new ItemMockRepository(itemList);
            //Act
            itemService = new ItemService(itemMockRepository);
            var result = itemList[0];
            result.Name = "Name";
            await itemService.UpdateItem(result);
            var updatedResult = result;
            //Assert
            Assert.Equal(result.Name, updatedResult.Name);
        }
    }
}
