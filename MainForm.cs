using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Investment_ideas_platform
{
    public partial class MainForm : Form
    {
        /*
        String u1 = "RM";
        String p1 = "rmpwd";
        String u2 = "CL";
        String p2 = "clpwd";
        
        //Credentials for admin login:
        String a1 = "jordan@company.com";
        String a2 = "password";
        */

        //User user;

        public MainForm()
        {
            InitializeComponent();

            //user = new User(); //instantiate the object
        }

        private void btnLoginCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*
            if (txtbx_login_uname.Text.Equals("RM") && txb_login_pwd.Text.Equals("rmpwd"))
            {
                this.Hide();
                Program.userLoggedIn = true;
                HomeForm f2 = new HomeForm();
                f2.setUser(txtbx_login_uname.Text, "RM");
                lab_login_error.Text = "";
                txtbx_login_uname.Text = "";
                txb_login_pwd.Text = "";
                Program.currForm = f2;
                f2.Show();
            }
            else if (txtbx_login_uname.Text.Equals(a1) && txb_login_pwd.Text.Equals(a2))
            {
                //Admin login
                this.Hide();
                Program.userLoggedIn = true;
                user.UserEmail = a1; //set email for the user object here
                lab_login_error.Text = "";
                txtbx_login_uname.Clear();
                txb_login_pwd.Clear();
                //new Admin().Show(); //takes user to the admin form
                Admin fA = new Admin(user);
                fA.Show();
            }
            else if (txtbx_login_uname.Text.Equals("CL") && txb_login_pwd.Text.Equals("clpwd"))
            {
                this.Hide();
                Program.userLoggedIn = true;
                HomeForm f2 = new HomeForm();
                f2.setUser(txtbx_login_uname.Text, "CL");
                lab_login_error.Text = "";
                txtbx_login_uname.Text = "";
                txb_login_pwd.Text = "";
                Program.currForm = f2;
                f2.Show();
            }
            else if (txtbx_login_uname.Text.Equals("IG") && txb_login_pwd.Text.Equals("igpwd"))
            {
                this.Hide();
                Program.userLoggedIn = true;
                HomeForm f2 = new HomeForm();
                f2.setUser(txtbx_login_uname.Text, "IG");
                lab_login_error.Text = "";
                txtbx_login_uname.Text = "";
                txb_login_pwd.Text = "";
                Program.currForm = f2;
                f2.Show();
            }
            else
            {
                lab_login_error.Text = "Incorrect credentials.";
            }
            */
            string userEmail = txtbx_login_uname.Text;
            string userPassword = txb_login_pwd.Text;

            if (LogUserIn.userExists(userEmail))
            {
                //Encryption to be added

                if (LogUserIn.logIn(userEmail, userPassword)) 
                {
                    User.userEmail = userEmail; //set the email so the program knows what email/user is logged in
                    string userAccountType = DBConnection.getInstanceOfDBConnection().getSingleValueUsingJustEmail(Constants.CHECK_ACCOUNT_TYPE, userEmail);
                    txtbx_login_uname.Clear();
                    txb_login_pwd.Clear();
                    
                    switch (userAccountType)
                    {
                        case "Admin":
                            //show admin homepage here
                            this.Hide();
                            Program.userLoggedIn = true;
                            lab_login_error.Text = "";
                            txtbx_login_uname.Clear();
                            txb_login_pwd.Clear();
                            Admin fA = new Admin();
                            fA.Show();
                            break;
                        case "Relationship manager":
                            this.Hide();
                            Program.userLoggedIn = true;
                            HomeForm f2 = new HomeForm();
                            f2.setUser(txtbx_login_uname.Text, "RM");
                            lab_login_error.Text = "";
                            txtbx_login_uname.Text = "";
                            txb_login_pwd.Text = "";
                            Program.currForm = f2;
                            f2.Show();
                            break;
                            
                            // (NATHAN) Added on to Biraj's original code logic.
                            // Create a case in which the idea creator is selected to login
                            // Using credientials with the account creation from admin, account type be an idea creator saved in database
                            // Hide until called upon when database is referenced with login details with the account type
                            // ic.Show to bring the form to the front

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

                // Nathan - create a condition in which the password or email does match the database records
                // If conditions are not mentioned within the cases then show else conditions

                else
                {
                    MessageBox.Show("Incorrect password"); // Display message when password is incorrect
                    txb_login_pwd.Clear(); // inbuilt function to clear text box
                }

            } 
            else

            // Conditions created so that if pwd and email dont work
            // Display the relevent message that meets this expectation of the case

            {
                MessageBox.Show("Account does not exist, please use a valid email"); // Use credentials that are matched to the database
                txtbx_login_uname.Clear(); // Based on email
                txb_login_pwd.Clear(); // Based on pwd
            }
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            string userEmail = txtbx_login_uname.Text;
            if (LogUserIn.userExists(userEmail))
            {
                //Double check that the user wants to reset password
                if (MessageBox.Show("Are you sure you want to request a password reset?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (!CreateResetNotification.findStaffID(userEmail))
                    {
                        //Make notification here
                        CreateResetNotification.makeResetNotification(userEmail);
                        MessageBox.Show("Reset request sent");
                    }
                    else
                    {
                        MessageBox.Show("Already sent a reset request");
                    }
                }
            }
            else
            {
                MessageBox.Show("Account does not exist");
            }
        }
    }
}
