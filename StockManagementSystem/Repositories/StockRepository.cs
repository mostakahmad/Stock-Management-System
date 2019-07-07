using StockManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Repositories;
using System.Data.SqlClient;
using System.Data;

namespace StockManagementSystem.Repositories
{
    public class StockRepository
    {
        MyConnection myConnection = new MyConnection();
        private string commandString;
        private SqlCommand sqlCommand;
        private SqlConnection sqlConnection;
        public int InserStock(StocksIn stocksIn)
        {
            sqlConnection = new SqlConnection(myConnection.connectionString);
            commandString = @"INSERT INTO StocksIn (ItemID, CategoryID, CompanyID, StockIn, StockDate) VALUES ('" + stocksIn.ItemID + "', '" + stocksIn.CategoryID + "', '" + stocksIn.CompanyID + "', '" + stocksIn.StockIn + "', GETDATE())";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            int isExecuted = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();           

            return isExecuted;
        }

        public DataTable LoadStockHistory(StocksIn stocksIn)
        {
            sqlConnection = new SqlConnection(myConnection.connectionString);
            commandString = @"SELECT i.ItemName, s.StockDate, s.StockIn FROM StocksIn AS s LEFT JOIN Items AS i ON s.ItemID = i.ItemID WHERE s.CompanyID = '"+ stocksIn .CompanyID+ "' AND s.CategoryID = '"+ stocksIn .CategoryID+ "' AND s.ItemID = '"+ stocksIn .ItemID+ "'";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;
        }

        public void InserStockOut(int[,] stockOutLists, int row, int c)
        {
            
            sqlConnection = new SqlConnection(myConnection.connectionString);

            for(int i = 0; i < row; i++)
            {
                commandString = @"INSERT INTO StockOut (ItemID, CategoryID, CompanyID, StockOut, StockCategory, StockOutDate) VALUES ('" + stockOutLists[i, 0] + "', '" + stockOutLists[i, 1] + "', '" + stockOutLists[i, 2] + "', '" + stockOutLists[i, 3] + "', '"+c+"', GETDATE())";
                sqlCommand = new SqlCommand(commandString, sqlConnection);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }

            for (int i = 0; i < row; i++)
            {
                sqlConnection = new SqlConnection(myConnection.connectionString);
                commandString = @"UPDATE Items SET AvailableItem = '" + stockOutLists[i,4] + "' WHERE  ItemID = '" + stockOutLists[i,0] + "' AND CompanyID = '" + stockOutLists[i,2] + "' AND CategoryID = '" + stockOutLists[i,1] + "' ";
                sqlCommand = new SqlCommand(commandString, sqlConnection);
                sqlConnection.Open();
                int isExecuted = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }


        }
    }
}
