using Exam2.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2.Repository
{
    public class MobileRepository
    {
        //Connection
        private string connectionString = @"Server=DESKTOP-PHFRTLE\SQLEXPRESS; Database=Mobile; Integrated Security=True";
        private SqlConnection sqlConnection;

        //Command
        private string commandString;
        private SqlCommand sqlCommand;

        public int Insert(Mobile mobile)
        {
            //
           sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            commandString = @"INSERT INTO MobileHandset (ModelName, Imei, Price) VALUES ('" + mobile.ModelName + "', '" + mobile.Imei + "', " + mobile.Price + ")";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            int isExecuted;
            isExecuted = sqlCommand.ExecuteNonQuery();
            //
            sqlConnection.Close();
            return isExecuted;
        }
        public DataTable SearchMobile(Mobile mobile)
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            commandString = @"SELECT * FROM MobileHandset WHERE Price BETWEEN '" + mobile.p1+"' AND '"+mobile.p2+"';";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();

            return dataTable;
        }
    }
}
