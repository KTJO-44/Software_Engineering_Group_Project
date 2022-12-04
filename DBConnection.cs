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

        public string getSingleValueUsingJustEmail(string sqlQuery, string email)
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

        public bool emailExists(string sqlQuery, string userEmail)
        {
            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                connToDB.Open();

                SqlCommand command = new SqlCommand(sqlQuery, connToDB);
                command.CommandType = CommandType.Text;
                command.Parameters.Add(new SqlParameter("userEmail", userEmail));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return true;
                    }
                }
            }
            return false;
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

        public DataSet getDataSet(string sqlQuery)
        {
            DataSet dataset = new DataSet();

            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                connToDB.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connToDB);
                adapter.Fill(dataset);
            }

            return dataset;
        }

        public void deleteAccountFromDB(string sqlQuery, string email)
        {
            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                connToDB.Open();
                SqlCommand command = new SqlCommand(sqlQuery, connToDB);
                command.CommandType = CommandType.Text;
                command.Parameters.Add(new SqlParameter("staffEmail", email));

                command.ExecuteNonQuery();

                connToDB.Close();
            }
        }

        public bool authenticatePassword(string sqlQuery, string email, string userPassword)
        {
            string dBPassword;

            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                connToDB.Open();
                SqlCommand command = new SqlCommand(sqlQuery, connToDB);
                command.CommandType = CommandType.Text;
                command.Parameters.Add(new SqlParameter("userEmail", email));

                dBPassword = (string)command.ExecuteScalar();

                connToDB.Close();

                if (dBPassword.Equals(userPassword)) { return true; }

            }

            return false;
        }

    }
}
