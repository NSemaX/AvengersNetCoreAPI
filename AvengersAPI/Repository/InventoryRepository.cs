using AvengersAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvengersAPI.Business
{
    public class InventoryRepository:IInventoryRepository

    {
        private readonly List<InventoryItem> _inventoryItems;

        public InventoryRepository()
        {
            _inventoryItems = new List<InventoryItem>();
        }

        public InventoryItem AddInventoryItem(InventoryItem item)
        {
            _inventoryItems.Add(item);

            return item;
        }

        public List<InventoryItem> GetInventoryItems()
        {
            return _inventoryItems;
        }


        public InventoryItem GetInventoryItem(int Id)
        {
            return _inventoryItems.Where(x=>x.Id==Id).FirstOrDefault();
        }
    }
}
