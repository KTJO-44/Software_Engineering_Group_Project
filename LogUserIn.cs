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
                return true;
            }
            return false;
        }

        public static bool logIn(string email, string password)
        {
            if (DBConnection.getInstanceOfDBConnection().authenticatePassword(Constants.FETCH_PASSWORD, email, password))
            {
                return true;
            }

            return false;
        }
    }
}
