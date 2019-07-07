using StockManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Repositories
{
    public class CategoryRepository
    {
        MyConnection myConnection = new MyConnection();
        private string commandString;
        private SqlCommand sqlCommand;
        private SqlConnection sqlConnection;

        public DataTable LoadCategories()
        {
            sqlConnection = new SqlConnection(myConnection.connectionString);
            commandString = @"SELECT * FROM Categories";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;
        }

        public int InsertCategory(Category category)
        {
            commandString = @"INSERT INTO Categories (CategoryName) VALUES ('" + category.CategoryName + "')";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            int isExecuted;

            sqlConnection.Open();
            isExecuted = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return isExecuted;
        }

        public int CheckCategory(Category category)
        {
            int isExists = 0;

            sqlConnection = new SqlConnection(myConnection.connectionString);
            commandString = @"SELECT * FROM Categories WHERE CategoryName = '"+ category .CategoryName+ "'";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();

            if(dataTable.Rows.Count > 0)
            {
                isExists = 1;
            }

            return isExists;
        }
    }
}
