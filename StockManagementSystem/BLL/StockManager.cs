using StockManagementSystem.Models;
using StockManagementSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.BLL
{
    public class StockManager
    {
        StockRepository _stockRepository = new StockRepository();
        public int InserStock(StocksIn stocksIn)
        {
            return _stockRepository.InserStock(stocksIn);
        }
        public DataTable LoadStockHistory(StocksIn stocksIn)
        {
            return _stockRepository.LoadStockHistory(stocksIn);
        }
        public void InserStockOut(int[,] stockOutLists, int row, int c)
        {
             _stockRepository.InserStockOut(stockOutLists, row, c);
        }
    }
}
