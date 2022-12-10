using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Investment_ideas_platform
{
    class CreateAccount
    {

        //This method has not been implemented yet.
        //It generates a random string with a length of 12 characters, and returns it.
        public static string generatePassword()
        {
            //A string containing all the possible characters that will be used to make the random password
            string possibleCharacters = "aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ0123456789!.,";
            //Start with an empty string for the password
            string password = "";
            //Create an object that will contain one random number at a time, and be used to select the next random character
            Random rng = new Random();

            for (int i = 0; i < 12; i++)
            {
                //Generate a random number using rng, store the number in index
                int index = rng.Next(possibleCharacters.Length);
                //use index variable to assign a character position to the randomChar variable
                char randomChar = possibleCharacters[index];
                //Concatenate the randomChar to the password string
                password += randomChar;
                //Repeat the loop, with index and randomChar changing each loop, but password is added to
            }
            
            //At the end of the loop, we will have a randomly-generated 12-character password. It can now be returned
            return password;
        }

        //Check if an email is in the valid format using regular expessions
        public static bool isEmailValid(string email)
        {
            //^ - begin the match at the start of the string
            //[^@\s]+ - match one or more occurences of any character other than @ or whitespace
            //@ - match the @ character
            //\. - will match a single full stop characer
            //(com) - the email must end with com. This can be changed to the company's specific email ending
            //$ - stop matching
            string regex = @"^[^@\s]+@[^@\s]+\.(com)$";

            //returns true if the email is valid, and false if the email does not match the format
            return Regex.IsMatch(email, regex, RegexOptions.IgnoreCase);
        }

        //method to create a new staff account. Checks that the email is in the valid format, and that the account does
        //not already exist in the database
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
                    return ""; //return an empty string which is basically returning false
                }

            }
            else
            {
                //return false
                return "";
            }
        }
    }
}
