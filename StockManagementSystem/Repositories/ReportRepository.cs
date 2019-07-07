using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Repositories
{
    public class ReportRepository
    {
        MyConnection myConnection = new MyConnection();
        private string commandString;
        private SqlCommand sqlCommand;
        private SqlConnection sqlConnection;

        public DataTable SummaryLoad(int companyID, int categoryID)
        {
            sqlConnection = new SqlConnection(myConnection.connectionString);
            commandString = @"SELECT i.ItemName AS Item, com.CompanyName AS Company, cat.CategoryName AS Category, i.AvailableItem AS Available, i.ReorderLevel AS ROL FROM Items AS i LEFT JOIN Companies AS com ON i.CompanyID = com.CompanyID LEFT JOIN Categories AS cat ON i.CategoryID = cat.CategoryID WHERE com.CompanyID = '"+companyID+"' AND cat.CategoryID = '"+categoryID+"' ";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;
        }

        public DataTable LoadReport(string fromDate, string toDate, int check)
        {
            sqlConnection = new SqlConnection(myConnection.connectionString);
            commandString = @"SELECT i.ItemName AS Item, C.CompanyName AS Company, SUM(s.StockOut) AS Quantity FROM StockOut s LEFT JOIN Items AS i ON s.ItemID = i.ItemID LEFT JOIN Companies AS c ON s.CompanyID = c.CompanyID WHERE StockCategory = '"+check+"' AND StockOutDate BETWEEN '"+fromDate+ "' AND '" + toDate + "' GROUP BY i.ItemName, C.CompanyName";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;
        }
    }
}
