using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Models;

namespace StockManagementSystem.Repositories
{
    public class ItemRepository
    {
        MyConnection myConnection = new MyConnection();
        private string commandString;
        private SqlCommand sqlCommand;
        private SqlConnection sqlConnection;

        public int InsertItem(Item item)
        {
            sqlConnection = new SqlConnection(myConnection.connectionString);
            commandString = @"INSERT INTO Items (ItemName, CompanyID, CategoryID, ReorderLevel) VALUES ('"+ item.ItemName+"', '"+item.CompanyID+"', '"+item.CategoryID+"', '"+item.ReorderLevel+"')";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            int isExecuted = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            return isExecuted;
        }

        public DataTable LoadCategories(int companyID)
        {
            sqlConnection = new SqlConnection(myConnection.connectionString);
            commandString = "SELECT DISTINCT i.CategoryID, c.CategoryName  FROM Items AS i LEFT OUTER JOIN Categories AS c ON i.CategoryID = c.CategoryID WHERE CompanyID = '" + companyID + "'";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;
        }

        public DataTable Loaditems(int companyID, int categoryID)
        {
            sqlConnection = new SqlConnection(myConnection.connectionString);
            commandString = "SELECT ItemID, ItemName FROM Items WHERE CategoryID = '" + categoryID + "' AND CompanyID = '"+ companyID + "'";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;
        }

        public DataTable Fetchitems(int itemID)
        {
            sqlConnection = new SqlConnection(myConnection.connectionString);
            commandString = "SELECT ReorderLevel, AvailableItem FROM Items WHERE itemID = '" + itemID + "'";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;
        }

        public int UpdateItem(StocksIn stocksIn, int availableItemCount)
        {
            sqlConnection = new SqlConnection(myConnection.connectionString);
            commandString = @"UPDATE Items SET AvailableItem = '"+ availableItemCount + "' WHERE  ItemID = '"+ stocksIn.ItemID+"' AND CompanyID = '"+stocksIn.CompanyID+"' AND CategoryID = '"+stocksIn.CategoryID+"' ";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            int isExecuted = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            return isExecuted;
        }

        public int CheckItem(Item item)
        {
            int isExists = 0;

            sqlConnection = new SqlConnection(myConnection.connectionString);
            commandString = @"SELECT * FROM Items WHERE ItemName = '"+ item.ItemName+ "' AND CompanyID = '"+ item.CompanyID+ "' AND CategoryID = '"+ item.CategoryID+ "'";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();

            if (dataTable.Rows.Count > 0)
            {
                isExists = 1;
            }

            return isExists;
        }
    }
}
