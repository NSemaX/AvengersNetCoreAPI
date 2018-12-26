using AvengersAPI.Models;
using System.Collections.Generic;

namespace AvengersAPI.Business
{
    public interface IInventoryRepository
    {
        InventoryItem AddInventoryItem(InventoryItem item);
        List<InventoryItem> GetInventoryItems();
        InventoryItem GetInventoryItem(int Id);
    }
}