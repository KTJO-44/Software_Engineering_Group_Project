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
    }
}
