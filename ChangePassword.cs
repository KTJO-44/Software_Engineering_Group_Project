using System;
using System.Collections.Generic;
using System.Text;

namespace Investment_ideas_platform
{
    class ChangePassword
    {

        //If a user is logged in, they can change their password. This method takes the new passwords, makes sure they
        //are the same, and then updates the database with the new password.
        public static bool changeExistingPassword(string email, string password1, string password2)
        {
            //If the new passwords are the same, the database can be updated with the new password
            if (password1.Equals(password2))
            {
                //find the user's account using their email, then update the database with the new password
                DBConnection.getInstanceOfDBConnection().changePassword(Constants.CHANGE_PASSWORD, email, password1);
                return true;
            }

            //If the passwords don't match, return false
            return false;
        }

        //Admin can reset staff passwords who request a password reset
        public static bool resetStaffPassword(string email)
        {
            //This string is what will replace the currently forgotten password
            string password = "1234";

            //Change the staff account's password
            DBConnection.getInstanceOfDBConnection().changePassword(Constants.CHANGE_PASSWORD, email, password);

            //get the staffID of the account using the email
            int staffID = DBConnection.getInstanceOfDBConnection().getSingleIntUsingJustEmail(Constants.FETCH_STAFFID, email);

            //Deleting the reset notification using staffID. We know the notificationID of reset requests is 1, so we use that
            DBConnection.getInstanceOfDBConnection().createNotification(Constants.DELETE_RESET_NOTIFICATION, 1, staffID);

            return true;
        }
    }
}
