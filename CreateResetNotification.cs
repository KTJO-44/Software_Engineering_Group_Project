using System;
using System.Collections.Generic;
using System.Text;

namespace Investment_ideas_platform
{
    class CreateResetNotification
    {
        //Use DBConnection to find StaffID, we know notID, then CREATE notification, 2 spearate funcs?
        public static bool findStaffID(string email)
        {
            int staffID = DBConnection.getInstanceOfDBConnection().getSingleIntUsingJustEmail(Constants.FETCH_STAFFID, email);
            if (DBConnection.getInstanceOfDBConnection().specificNotificationExists(Constants.CHECK_EXISTS_SPECIFIC_NOTIFICATION, staffID))
            {
                return true;
            }
            return false;
        }

        public static void makeResetNotification(string email)
        {
            //We have already clarified that the user account exists.
            int staffID = DBConnection.getInstanceOfDBConnection().getSingleIntUsingJustEmail(Constants.FETCH_STAFFID, email);
            //now we make the notification itself.
            DBConnection.getInstanceOfDBConnection().createNotification(Constants.CREATE_RESET_NOTIFICATION, 1, staffID);
        }

    }
}
