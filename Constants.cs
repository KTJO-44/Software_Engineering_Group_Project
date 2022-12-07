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
        public static string FETCH_STAFFID = "SELECT staffID FROM staffAccounts WHERE email=@userEmail";
        public static string CREATE_RESET_NOTIFICATION = "INSERT INTO accountNotifications (notificationID, staffID) VALUES (@nID, @sID)";
        public static string FETCH_RESET_NOTIFICATIONS = "SELECT sA.email, sA.firstName, sA.lastName, aN.timeStamp, n.notificationType FROM ((staffAccounts AS sA INNER JOIN accountNotifications AS aN ON sA.staffID = aN.staffID) INNER JOIN notifications AS n ON aN.notificationID = n.notificationID)";
        public static string CHECK_EXISTS_NOTIFICATIONS = "SELECT * FROM accountNotifications";
        public static string CHECK_EXISTS_SPECIFIC_NOTIFICATION = "SELECT notificationID FROM accountNotifications WHERE staffID=@sID";
        public static string DELETE_RESET_NOTIFICATION = "DELETE FROM accountNotifications WHERE notificationID=@nID AND staffID=@sID";

        public static string SELECT_VIEW_ALL_IDEAS = "SELECT ideaTitle, dateCreated, abstract, dateExpires, ideaContent, riskRating, Views FROM InvestmentIdeas";
        public static string DELETE_STAFF_IDEAS = "DELETE FROM  InvestmentIdeas WHERE ideaTitle=@staffIdeas";

        public static string SELECT_VIEW_ALL_PRODUCTS = "SELECT productName, productType, companyName, productDescription FROM Products";
        public static string DELETE_STAFF_PRODUCTS = "DELETE FROM Products WHERE productName=@staffProducts";

        public static string SELECT_VIEW_ALL_CLIENTS= "SELECT firstName, lastName, email, phoneNumber, riskRating,preferenceItem1,preferenceItem2, preferenceItem3, preferenceLocation1, preferenceLocation2, preferenceLocation3  FROM clientProfiles";
        public static string ADD_NEW_CLIENT = "INSERT INTO clientProfiles (firstName, lastName, email, phoneNumber, riskRating, preferenceItem1, preferenceItem2, preferenceItem3, preferenceLocation1, preferenceLocation2, preferenceLocation3) VALUES (@firstName, @lastName, @email, @phoneNumber, @riskRating, @preferenceItem1, @preferenceItem2, @preferenceItem3, @preferenceLocation1, @preferenceLocation2, @preferenceLocation3)";
        public static string DELETE_CLIENT_ACCOUNT = "DELETE FROM clientProfiles WHERE firstName=@firstName";

        public static string CHANGE_ITEM1 = "UPDATE clientProfiles SET preferencesItem1=@Item1 WHERE email=@clientEmail";
    }
}
