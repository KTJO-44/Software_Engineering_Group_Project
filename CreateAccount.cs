using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Investment_ideas_platform
{
    class CreateAccount
    {
        public static string generatePassword()
        {
            string possibleCharacters = "aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ0123456789!.,";
            string password = "";
            Random rng = new Random();

            for (int i = 0; i < 12; i++)
            {
                int index = rng.Next(possibleCharacters.Length);
                char randomChar = possibleCharacters[index];
                password += randomChar;
            }

            return password;
        }

        public static bool isEmailValid(string email)
        {
            string regex = @"^[^@\s]+@[^@\s]+\.(com)$";

            return Regex.IsMatch(email, regex, RegexOptions.IgnoreCase);
        }


        public static string createNewAccount(string email, string accountType, string firstName, string lastName)
        {
            //If email is valid and all fields have an input, then create the account and save to the DB
            if (isEmailValid(email) && accountType != "" && firstName != "" && lastName != "")
            {
                if (!LogUserIn.userExists(email))
                {
                    //string uPass = generatePassword();
                    string uPass = "password";
                    //string encryptedPassword = Encrypt.encryptString(uPass);
                    DBConnection.getInstanceOfDBConnection().addNewAccountToDB(Constants.ADD_NEW_ACCOUNT, email, accountType, firstName, lastName, "password");
                    //MessageBox.Show(uPass);
                    return uPass;
                }
                else
                {
                    MessageBox.Show("An account with this email already exists. Please use a different email");
                    return ""; //basically returning false
                }

            }
            else
            {
                return "";
            }
        }
    }
}
