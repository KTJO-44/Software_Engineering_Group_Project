using System;
using System.Collections.Generic;
using System.Text;

namespace Investment_ideas_platform
{
    class DeleteAccount
    {
        public static bool deleteStaffAccount(string staffEmail)
        {
            DBConnection.getInstanceOfDBConnection().deleteAccountFromDB(Constants.DELETE_STAFF_ACCOUNT, staffEmail);
            return true;
        }
    }
}
