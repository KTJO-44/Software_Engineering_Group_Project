using System;
using System.Collections.Generic;
using System.Text;

namespace Investment_ideas_platform
{
    class Constants
    {
        public static string FETCH_USER_FIRSTNAME = "SELECT firstName FROM staffAccounts WHERE email=@userEmail";
        public static string FETCH_USER_LASTNAME = "SELECT lastName FROM staffAccounts WHERE email=@userEmail";
        public static string CHECK_EXISTS_userEmail = "SELECT email FROM staffAccounts WHERE email=@userEmail";
        public static string ADD_NEW_ACCOUNT = "INSERT INTO staffAccounts (email, accountType, firstName, lastName, password) VALUES (@email, @accountType, @firstName, @lastName, @password)";
        public static string SELECT_VIEW_ALL_ACCOUNTS = "SELECT email, firstName, lastName, accountType FROM staffAccounts";
        public static string DELETE_STAFF_ACCOUNT = "DELETE FROM staffAccounts WHERE email=@staffEmail";
        public static string CHECK_ACCOUNT_TYPE = "SELECT accountType FROM staffAccounts WHERE email=@userEmail";
        public static string FETCH_PASSWORD = "SELECT password FROM staffAccounts WHERE email=@userEmail";
        public static string CHANGE_PASSWORD = "UPDATE staffAccounts SET password=@newPassword WHERE email=@userEmail";


    }
}
