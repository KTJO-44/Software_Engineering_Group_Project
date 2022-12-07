using System;
using System.Collections.Generic;
using System.Text;

namespace Investment_ideas_platform
{
    class DeleteClient
    {
        public static bool deleteClientAccount(string firstName)
        {
            DBConnection.getInstanceOfDBConnection().deleteClientFromDB(Constants.DELETE_CLIENT_ACCOUNT, firstName);
            return true;
        }
    }
}
