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

        public int getSingleIntUsingJustEmail(string sqlQuery, string email)
        {
            int value;

            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                connToDB.Open();
                SqlCommand command = new SqlCommand(sqlQuery, connToDB);
                command.CommandType = CommandType.Text;
                command.Parameters.Add(new SqlParameter("userEmail", email));

                value = Convert.ToInt32(command.ExecuteScalar());

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

        public bool notificationsExist(string sqlQuery)
        {
            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                connToDB.Open();

                SqlCommand command = new SqlCommand(sqlQuery, connToDB);
                command.CommandType = CommandType.Text;

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

        public bool specificNotificationExists(string sqlQuery, int staffID)
        {
            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                connToDB.Open();

                SqlCommand command = new SqlCommand(sqlQuery, connToDB);
                command.CommandType = CommandType.Text;
                command.Parameters.Add(new SqlParameter("sID", staffID));

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

        public void changePassword(string sqlQuery, string email, string password)
        {
            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                connToDB.Open();
                SqlCommand command = new SqlCommand(sqlQuery, connToDB);
                command.CommandType = CommandType.Text;
                command.Parameters.Add(new SqlParameter("newPassword", password));
                command.Parameters.Add(new SqlParameter("userEmail", email));

                command.ExecuteNonQuery();

                connToDB.Close();
            }
        }

        public void createNotification(string sqlQuery, int notificationID, int staffID)
        {
            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                connToDB.Open();
                SqlCommand command = new SqlCommand(sqlQuery, connToDB);
                command.CommandType = CommandType.Text;
                command.Parameters.Add(new SqlParameter("nID", notificationID));
                command.Parameters.Add(new SqlParameter("sID", staffID));

                command.ExecuteNonQuery();

                connToDB.Close();
            }
        }

            public void deleteClientFromDB(string sqlQuery, string firstName)
            {
                using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
                {
                    connToDB.Open();
                    SqlCommand command = new SqlCommand(sqlQuery, connToDB);
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add(new SqlParameter("firstName", firstName));

                    command.ExecuteNonQuery();

                    connToDB.Close();
                }
            }

        public void  addNewClientToDB(string sqlQuery, string firstName, string lastName, string email, string phoneNumber, string riskRating, string preferenceItem1, string preferenceItem2, string preferenceItem3, string preferenceLocation1, string preferenceLocation2, string preferenceLocation3)
        {
            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                connToDB.Open();

                SqlCommand command = new SqlCommand(sqlQuery, connToDB);
                command.CommandType = CommandType.Text;
                command.Parameters.Add(new SqlParameter("firstName", firstName));
                command.Parameters.Add(new SqlParameter("lastName", lastName));
                command.Parameters.Add(new SqlParameter("email", email));
                command.Parameters.Add(new SqlParameter("phoneNumber", phoneNumber));
                command.Parameters.Add(new SqlParameter("riskRating", riskRating));
                command.Parameters.Add(new SqlParameter("preferenceItem1", preferenceItem1));
                command.Parameters.Add(new SqlParameter("preferenceItem2", preferenceItem2));
                command.Parameters.Add(new SqlParameter("preferenceItem3", preferenceItem3));
                command.Parameters.Add(new SqlParameter("preferenceLocation1", preferenceLocation1));
                command.Parameters.Add(new SqlParameter("preferenceLocation2", preferenceLocation2));
                command.Parameters.Add(new SqlParameter("preferenceLocation3", preferenceLocation3));

                command.ExecuteNonQuery();

                connToDB.Close();
            }

        }

        // This can be used as a function to be called upon when adding data to the data grid
        // You take the SQL queries and provide the data value types corrosponding to each attribute
        // If listed in order, this will be used to generate entries when adding to the data grid

        public void add_idea_to_DB(string sqlQuery, string idea_title, string abstract_description, string date_expire, string content, string risk_rating)
        {
            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                connToDB.Open();

                SqlCommand command = new SqlCommand(sqlQuery, connToDB);
                command.CommandType = CommandType.Text;
                command.Parameters.Add(new SqlParameter("idea_name", idea_title));
                command.Parameters.Add(new SqlParameter("abstract", abstract_description));
                command.Parameters.Add(new SqlParameter("date_expires", date_expire));
                command.Parameters.Add(new SqlParameter("idea_content", content));
                command.Parameters.Add(new SqlParameter("risk_rating", risk_rating));

                command.ExecuteNonQuery();

                connToDB.Close();
            }
        }
        public void add_product_to_DB(string sqlQuery, string product_name, string product_type,  string company_name, string product_description)
        {
            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                connToDB.Open();

                SqlCommand command = new SqlCommand(sqlQuery, connToDB);
                command.CommandType = CommandType.Text;
                command.Parameters.Add(new SqlParameter("product_name", product_name));
                command.Parameters.Add(new SqlParameter("product_type", product_type));
                command.Parameters.Add(new SqlParameter("company_name", company_name));
                command.Parameters.Add(new SqlParameter("product_description", product_description));

                command.ExecuteNonQuery();

                connToDB.Close();
            }
        }
    } 

    }

