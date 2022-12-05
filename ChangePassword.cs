using System;
using System.Collections.Generic;
using System.Text;

namespace Investment_ideas_platform
{
    class ChangePassword
    {
        public static bool changeExistingPassword(string email, string password1, string password2)
        {
            if (password1.Equals(password2))
            {
                //encrypt password
                DBConnection.getInstanceOfDBConnection().changePassword(Constants.CHANGE_PASSWORD, email, password1);
                return true;
            }

            return false;
        }

        public static bool resetStaffPassword(string email)
        {
            string password = "1234";

            //get staffID from email

            DBConnection.getInstanceOfDBConnection().changePassword(Constants.CHANGE_PASSWORD, email, password);

            int staffID = DBConnection.getInstanceOfDBConnection().getSingleIntUsingJustEmail(Constants.FETCH_STAFFID, email);

            //It says createNotification, but also works to delete it when you feed in the correct constant
            DBConnection.getInstanceOfDBConnection().createNotification(Constants.DELETE_RESET_NOTIFICATION, 1, staffID);

            return true;
        }
    }
}
