using System;
using System.Collections.Generic;
using System.Text;

namespace Investment_ideas_platform
{
    class CreateResetNotification
    {
        //Use DBConnection to find StaffID, we know notificationID, then CREATE notification
        public static bool findStaffID(string email)
        {
            //creating an int value then fetching the staffID into it, using the email of the account
            int staffID = DBConnection.getInstanceOfDBConnection().getSingleIntUsingJustEmail(Constants.FETCH_STAFFID, email);
            //If a reset password notificaiton already exists in the database, return true so the program knows not to create another one
            if (DBConnection.getInstanceOfDBConnection().specificNotificationExists(Constants.CHECK_EXISTS_SPECIFIC_NOTIFICATION, staffID))
            {
                return true;
            }
            //otherwise return false, and the program can go ahead and create a new reset notification associated with that staff accounts
            return false;
        }

        //Method to make the reset notificaiton
        public static void makeResetNotification(string email)
        {
            //We have already clarified that the user account exists
            //Fetch the staffID using the staff account's email
            int staffID = DBConnection.getInstanceOfDBConnection().getSingleIntUsingJustEmail(Constants.FETCH_STAFFID, email);
            //Making the notification. We know the notificaitonID of a reset notification is 1, and we have just fetched the staffID
            DBConnection.getInstanceOfDBConnection().createNotification(Constants.CREATE_RESET_NOTIFICATION, 1, staffID);
        }

    }
}
