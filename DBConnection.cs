using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
//May have to install this package (below), just search for System.Data.SqlClient in NuGet packet manager
using System.Data.SqlClient;

namespace Investment_ideas_platform
{
    class DBConnection
    {
        private static DBConnection _instance;

        private string dBConnectionString;

        private DBConnection()
        {
            //Gets the connection string that was set in settings instead of having to type the connection string out manually in the code
            dBConnectionString = Properties.Settings.Default.InvestmentIdeasDBConnectionString;
        }

        public static DBConnection getInstanceOfDBConnection()
        {
            if (_instance == null)
            {
                _instance = new DBConnection();
            }

            return _instance;
        }

        public string getUserFirstName(string sqlQuery, string email)
        {
            string value;

            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                connToDB.Open();
                SqlCommand command = new SqlCommand(sqlQuery, connToDB);
                command.CommandType = CommandType.Text;
                command.Parameters.Add(new SqlParameter("userEmail", email));

                value = (string)command.ExecuteScalar(); //since we only want one value/string

                connToDB.Close();
            }

            return value;
        }

        public void addNewAccountToDB(string sqlQuery, string email, string accountType, string firstName, string lastName, string password)
        {
            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                connToDB.Open();

                SqlCommand command = new SqlCommand(sqlQuery, connToDB);
                command.CommandType = CommandType.Text;
                command.Parameters.Add(new SqlParameter("email", email));
                command.Parameters.Add(new SqlParameter("accountType", accountType));
                command.Parameters.Add(new SqlParameter("firstName", firstName));
                command.Parameters.Add(new SqlParameter("lastName", lastName));
                command.Parameters.Add(new SqlParameter("password", password));

                command.ExecuteNonQuery();

                connToDB.Close();
            }
        }

    }
}
