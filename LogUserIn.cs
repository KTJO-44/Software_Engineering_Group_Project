using System;
using System.Collections.Generic;
using System.Text;

namespace Investment_ideas_platform
{
    class LogUserIn
    {
        //Check that the user's email is in the database. If they have an account, let them log in
        public static bool userExists(string email)
        {
            if (DBConnection.getInstanceOfDBConnection().emailExists(Constants.CHECK_EXISTS_userEmail, email))
            {
                //If the email exists, return true so that the program knows the account exists
                return true;
            }
            return false;
        }

        //Method to log the user in by checking if the password in the database matches the
        //password associated with the account the user entered.
        public static bool logIn(string email, string password)
        {
            if (DBConnection.getInstanceOfDBConnection().authenticatePassword(Constants.FETCH_PASSWORD, email, password))
            {
                //If the passwords match, return true so the user can be logged in
                return true;
            }
            return false;
        }
    }
}
