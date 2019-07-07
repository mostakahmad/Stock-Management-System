using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models
{
    public class StockOut
    {
        public int StockOutID { get; set; }

        public int CompanyID { get; set; }
        public int CategoryID { get; set; }
        public int ItemID { get; set; }
        public int StockOutAmount { get; set; }
        public int StockCategory { get; set; }
        public string StockOutDate { get; set; }

    }
}
