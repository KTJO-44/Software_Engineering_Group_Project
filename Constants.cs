﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Investment_ideas_platform
{
    class Constants
    {
        public static string FETCH_USER_FIRSTNAME = "SELECT firstName FROM staffAccounts WHERE email=@userEmail";
        public static string CHECK_EXISTS_userEmail = "SELECT email FROM staffAccounts WHERE email=@userEmail";
        public static string ADD_NEW_ACCOUNT = "INSERT INTO staffAccounts (email, accountType, firstName, lastName, password) VALUES (@email, @accountType, @firstName, @lastName, @password)";
    }
}
