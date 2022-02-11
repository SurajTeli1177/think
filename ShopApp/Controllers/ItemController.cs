using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopApp.Business;
using ShopApp.Models;

namespace ShopApp.Controller
{
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;
        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpGet]
        public async Task<ActionResult> GetItems()
        {
            var result =  await _itemService.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddItem([FromBody]Item model)
        {
            try
            {
                await _itemService.AddItem(model);
                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPut("[action]/{id}")]
        public async Task<IActionResult> UpdateItem(int id,[FromBody]Item model)
        {
            try
            {
                if(id == model.Id)
                {
                    await _itemService.UpdateItem(model);
                    return StatusCode(StatusCodes.Status200OK);
                }
                return StatusCode(StatusCodes.Status204NoContent);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            try
            {
                await _itemService.DeleteById(id);
                return StatusCode(StatusCodes.Status200OK);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}