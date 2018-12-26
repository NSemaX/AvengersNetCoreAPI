using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AvengersAPI.Business;
using AvengersAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AvengersAPI.Controllers
{
    [Route("v1/")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryRepository _repository;

        public InventoryController(IInventoryRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        [Route("AddInventoryItem")]
        public ActionResult<InventoryItem> AddInventoryItem(InventoryItem item)
        {
            var inventoryItems = _repository.AddInventoryItem(item);

            if (inventoryItems==null)
            {
                return NotFound();
            }

            return inventoryItems;
        }

        [HttpGet]
        [Route("GetInventoryItems")]
        public ActionResult<List<InventoryItem>> GetInventoryItems()
        {
            var inventoryItems = _repository.GetInventoryItems();

            if (inventoryItems.Count==0)
            {
                return NotFound();
            }

            return inventoryItems;
        }


        [HttpGet]
        [Route("GetInventoryItem/{Id}")]
        public ActionResult<InventoryItem> GetInventoryItem(int Id)
        {
            var inventoryItem = _repository.GetInventoryItem(Id);

            if (inventoryItem == null)
            {
                return NotFound();
            }

            return inventoryItem;
        }




    }
}