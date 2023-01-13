using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Investment_ideas_platform
{
    class DBConnection
    {
        //Private object of the class
        private static DBConnection _instance;

        //The connection string that will be used for connecting to the database
        private string dBConnectionString;

        private DBConnection()
        {
            //Gets the connection string that was set in settings instead of having to type the connection string out manually in the code
            dBConnectionString = Properties.Settings.Default.InvestmentIdeasDBConnectionString;
        }

        //Static method that creates a unique object of the class so it can be called without having to make an object of the class
        public static DBConnection getInstanceOfDBConnection()
        {
            //Only create the object if it doesn't already exist
            if (_instance == null)
            {
                _instance = new DBConnection();
            }

            //If it exists, return the instance
            return _instance;
        }


        //This method can be used for mutlitple different queries, like fetching first name, password, or a staffID using the email
        public string getSingleValueUsingJustEmail(string sqlQuery, string email)
        {
            //Make a string value to return the string to
            string value;

            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                //Open the conneciton to the DB
                connToDB.Open();

                SqlCommand command = new SqlCommand(sqlQuery, connToDB);
                //Set the SqlCommand's properties
                command.CommandType = CommandType.Text;
                //Add the parameters to the SQL command. This ensures that the inputs are sanitised to avoid an SQL injection attack
                command.Parameters.Add(new SqlParameter("userEmail", email));

                //ExecuteScalar returns one value, cast it to string to make sure it matches the 'value' datatype
                value = (string)command.ExecuteScalar();

                //Close the connection
                connToDB.Close();
            }

            //Return the value that was fetched from the database
            return value;
        }

        //This method is the same as the one above, but returns an int instead of a string
        public int getSingleIntUsingJustEmail(string sqlQuery, string email)
        {
            //Make a variable to return the int from the database to
            int value;

            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                connToDB.Open();
                SqlCommand command = new SqlCommand(sqlQuery, connToDB);
                command.CommandType = CommandType.Text;
                command.Parameters.Add(new SqlParameter("userEmail", email));

                //Convert the returned value to an int to make sure it matches the 'value' datatype
                value = Convert.ToInt32(command.ExecuteScalar());

                connToDB.Close();
            }

            //Return the int that was fetched
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

                //If a value was returned/found, return true as it means the email exists in the database
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return true;
                    } //No need for an else statement, as if the IF statement doesn't run, false will be returned by default
                }
            }
            //Return false if no email was found in the database
            return false;
        }

        //Check if notificaitons exist in the database
        public bool notificationsExist(string sqlQuery)
        {
            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                connToDB.Open();

                SqlCommand command = new SqlCommand(sqlQuery, connToDB);
                command.CommandType = CommandType.Text;

                //If data is fetched, then there is at least one notification in the database
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return true;
                    }
                }
            }
            //If no notifications exist in the database, return false
            return false;
        }

        //Check if a specific notification exists - in order to prevent multiple of the same notification being inserted into the database
        public bool specificNotificationExists(string sqlQuery, int staffID)
        {
            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                connToDB.Open();

                SqlCommand command = new SqlCommand(sqlQuery, connToDB);
                command.CommandType = CommandType.Text;
                command.Parameters.Add(new SqlParameter("sID", staffID));

                //If the notification was found the reader will contain something so return true
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return true;
                    }
                }
            }
            //If nothing was found, it means the notification does not exist in the database, so return false
            return false;
        }

        //Insert a new account into the database
        public void addNewAccountToDB(string sqlQuery, string email, string accountType, string firstName, string lastName, string password)
        {
            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                connToDB.Open();

                SqlCommand command = new SqlCommand(sqlQuery, connToDB);
                command.CommandType = CommandType.Text;
                //Add all the new account information to the sqlQuery so it will be inserted into the database
                command.Parameters.Add(new SqlParameter("email", email));
                command.Parameters.Add(new SqlParameter("accountType", accountType));
                command.Parameters.Add(new SqlParameter("firstName", firstName));
                command.Parameters.Add(new SqlParameter("lastName", lastName));
                command.Parameters.Add(new SqlParameter("password", password));

                //ExecuteNonQuery is used here since we don't need to return anything. It will silently insert the data to the specified columns
                command.ExecuteNonQuery();

                connToDB.Close();
            }
        }

        //Returns a dataset based on the query sent to it
        public DataSet getDataSet(string sqlQuery)
        {
            DataSet dataset = new DataSet();

            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                connToDB.Open();

                //Create a data adapter object
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connToDB);
                //Fill the dataset using the data adapter
                adapter.Fill(dataset);
            }

            return dataset;
        }

        //Delete an account using the provided email address
        public void deleteAccountFromDB(string sqlQuery, string email)
        {
            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                connToDB.Open();
                SqlCommand command = new SqlCommand(sqlQuery, connToDB);
                command.CommandType = CommandType.Text;
                command.Parameters.Add(new SqlParameter("staffEmail", email));

                //ExecuteNonQuery is used as we do not need any data returned here
                command.ExecuteNonQuery();

                connToDB.Close();
            }
        }

        //Check the provided password against the password fetched from the database using the provided email
        public bool authenticatePassword(string sqlQuery, string email, string userPassword)
        {
            //Create a string to store the fetched password
            string dBPassword;

            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                connToDB.Open();
                SqlCommand command = new SqlCommand(sqlQuery, connToDB);
                command.CommandType = CommandType.Text;
                command.Parameters.Add(new SqlParameter("userEmail", email));

                //Fetch the password from the database
                dBPassword = (string)command.ExecuteScalar();

                connToDB.Close();

                //Compare the provided password with the password fetched from the database
                if (dBPassword.Equals(userPassword)) { return true; }

            }

            return false;
        }

        //Method to update the password of an account using the account's email and the new password
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

        //Method to create a notification. notificaitonID and staffID must be provided so that a composite key can be made/inserted
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
    }

    }

