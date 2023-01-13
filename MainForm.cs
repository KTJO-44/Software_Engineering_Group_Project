using System;
using System.Windows.Forms;

namespace Investment_ideas_platform
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            //Runs when MainForm is called
            InitializeComponent();
        }

        private void btnLoginCancel_Click(object sender, EventArgs e)
        {
            //Cancel button closes the login page
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Get user's login info from the login page
            string userEmail = txtbx_login_uname.Text;
            string userPassword = txb_login_pwd.Text;

            //If the userEmail is found in the database, the account exists and the user's password can now be verified
            if (LogUserIn.userExists(userEmail))
            {

                //If the account password and email match, the user can be logged in
                if (LogUserIn.logIn(userEmail, userPassword)) 
                {

                    User.userEmail = userEmail; //set the email so the program knows what email/user is logged in
                    string userAccountType = DBConnection.getInstanceOfDBConnection().getSingleValueUsingJustEmail(Constants.CHECK_ACCOUNT_TYPE, userEmail);
                    txtbx_login_uname.Clear();
                    txb_login_pwd.Clear();
                    
                    /*A switch case was used since there are only 3 options/account types. Depending on the account type
                    of the user logging in, the program will switch to that account type and show the homepage for that
                    user.*/
                    switch (userAccountType)
                    {
                        case "Admin":
                            this.Hide(); //Hide the login form
                            Program.userLoggedIn = true;
                            lab_login_error.Text = "";
                            txtbx_login_uname.Clear();
                            txb_login_pwd.Clear();
                            Admin fA = new Admin();
                            fA.Show(); //Create and show the Admin homepage
                            break;
                        case "Relationship manager":
                            this.Hide();
                            Program.userLoggedIn = true;
                            HomeForm f2 = new HomeForm();
                            lab_login_error.Text = "";
                            txtbx_login_uname.Text = "";
                            txb_login_pwd.Text = "";
                            Program.currForm = f2;
                            f2.Show();
                            break;
                        case "Idea creator":
                            this.Hide(); // Hide the form 
                            Program.userLoggedIn = true; // Only true if credentials are correct
                            lab_login_error.Text = "";
                            txtbx_login_uname.Clear();
                            txb_login_pwd.Clear();
                            idea_creator ic = new idea_creator();
                            ic.Show(); // Show the form when the case is called
                            break;
                    }
                }
                else
                {
                    //If the password did not match the password associated with the user's email, show
                    //an error message to the user letting them know that their password was incorrect.
                    MessageBox.Show("Incorrect password");
                    //Clear the password text box so the user can type their password in again
                    txb_login_pwd.Clear();
                }

            } 
            else
            {
                //If no email was found matching the inputted email, display an error message
                MessageBox.Show("Account does not exist, please use a valid email");
                //Clear the text boxes so the user can try again
                txtbx_login_uname.Clear();
                txb_login_pwd.Clear();
            }
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            //Get the email of the user who has forgotten their password
            string userEmail = txtbx_login_uname.Text;

            //If the email is in the database, the user can request a password change
            if (LogUserIn.userExists(userEmail))
            {
                //Double check that the user wants to reset password
                if (MessageBox.Show("Are you sure you want to request a password reset?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //If the user is sure they want to request a password reset, make sure that a reset notification
                    //doesn't already exist for this account, then make the notification.
                    if (!CreateResetNotification.findStaffID(userEmail))
                    {
                        //Make notification here
                        CreateResetNotification.makeResetNotification(userEmail);
                        MessageBox.Show("Reset request sent");
                    }
                    else
                    {
                        //If a notificaiton already exists for this account, don't make another one, and let the user
                        //know that a request has been sent
                        MessageBox.Show("Already sent a reset request");
                    }
                }
            }
            else
            {
                //Let the user know that the account does not exist
                MessageBox.Show("Account does not exist");
                //Clear the text boxes so the user can type in their login information again
                txtbx_login_uname.Clear();
                txb_login_pwd.Clear();
            }
        }
    }
}
