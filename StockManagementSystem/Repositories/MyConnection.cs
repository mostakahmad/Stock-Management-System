using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Repositories
{
    public class MyConnection
    {
        public string connectionString = @"Server=DESKTOP-QEF700F\SQLEXPRESS; Database=StockManagementSystemDotDB; Integrated Security=True";
    }
}
