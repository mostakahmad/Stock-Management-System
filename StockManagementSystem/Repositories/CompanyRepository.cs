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
    public class CompanyRepository
    {
        MyConnection myConnection = new MyConnection();
        private string commandString;
        private SqlCommand sqlCommand;
        private SqlConnection sqlConnection;

        public DataTable LoadCompanies()
        {
            sqlConnection = new SqlConnection(myConnection.connectionString);
            commandString = @"SELECT * FROM Companies";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;
        }

        public int InsertCompany(Company company)
        {
            commandString = @"INSERT INTO Companies(CompanyName) VALUES ('" + company.CompanyName + "')";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            int isExecuted;

            sqlConnection.Open();
            isExecuted = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return isExecuted;
        }

        public int CheckCompany(Company company)
        {
            int isExists = 0;

            sqlConnection = new SqlConnection(myConnection.connectionString);
            commandString = @"SELECT * FROM Companies WHERE CompanyName = '" + company.CompanyName + "'";
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
