using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models
{
    public class StocksIn
    {
        public int StockID { get; set; }
        public int ItemID { get; set; }
        public int CategoryID { get; set; }
        public int CompanyID { get; set; }
        public int StockIn { get; set; }
        public string StockDate { get; set; }
        public string ItemName { get; set; }
    }
}
