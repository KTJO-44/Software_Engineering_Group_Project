using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Investment_ideas_platform
{
    class CreateClient
    {

        public static bool createNewClient(string firstName, string lastName, string email, string phoneNumber, string riskRating, string preferenceItem1, string preferenceItem2, string preferenceItem3, string preferenceLocation1, string preferenceLocation2, string preferenceLocation3)
        {
            if (firstName != " " && lastName != "" && (isClientEmailValid(email) &&  phoneNumber != "" && riskRating != "" && preferenceItem1 != "" && preferenceItem2 != "" && preferenceItem3 != "" && preferenceLocation1 != "" && preferenceLocation3 != "" && preferenceLocation3 != ""))
            {
                DBConnection.getInstanceOfDBConnection().addNewClientToDB(Constants.ADD_NEW_CLIENT, firstName, lastName, email, phoneNumber, riskRating, preferenceItem1, preferenceItem2, preferenceItem3, preferenceLocation1, preferenceLocation2, preferenceLocation3);
                return true;

            }
            else
            {
                return false;

            }
        }

        public static bool isClientEmailValid(string email)
        {
            string regex = @"^[^@\s]+@[^@\s]+\.(com)$";

            return Regex.IsMatch(email, regex, RegexOptions.IgnoreCase);
        }
    }
}
