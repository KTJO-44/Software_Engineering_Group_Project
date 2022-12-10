using System;
using System.Collections.Generic;
using System.Text;

namespace Investment_ideas_platform
{
    class DeleteAccount
    {
        //Method to delete a staff account
        public static bool deleteStaffAccount(string staffEmail)
        {
            //Deletes a staff account using the staff's email
            DBConnection.getInstanceOfDBConnection().deleteAccountFromDB(Constants.DELETE_STAFF_ACCOUNT, staffEmail);
            //return true so that the program knows it was successful
            return true;
        }
    }
}
