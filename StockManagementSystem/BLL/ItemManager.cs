using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Models;
using StockManagementSystem.Repositories;

namespace StockManagementSystem.BLL
{
    public class ItemManager
    {
        ItemRepository _itemRepository = new ItemRepository();
        public int InsertItem(Item item)
        {
            return _itemRepository.InsertItem(item);
        }

        public DataTable LoadCategories(int companyID)
        {
            return _itemRepository.LoadCategories(companyID);
        }

        public DataTable Loaditems(int companyID, int categoryID)
        {
            return _itemRepository.Loaditems(companyID, categoryID);
        }

        public DataTable Fetchitems(int itemID)
        {
            return _itemRepository.Fetchitems(itemID);
        }
        public int UpdateItem(StocksIn stocksIn, int availableItemCount)
        {
            return _itemRepository.UpdateItem(stocksIn, availableItemCount);
        }

        public int CheckItem(Item item)
        {
            return _itemRepository.CheckItem(item);
        }
    }
}
