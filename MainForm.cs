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
                        case "Idea creator":
                            //write code to show IC homepage here
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect password");
                    txb_login_pwd.Clear();
                }

            } 
            else
            {
                MessageBox.Show("Account does not exist, please use a valid email");
                txtbx_login_uname.Clear();
                txb_login_pwd.Clear();
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
                    //Make notification here
                    CreateResetNotification.findStaffID(userEmail);
                    MessageBox.Show("Reset request sent");
                }
            }
            else
            {
                MessageBox.Show("Account does not exist");
            }
        }
    }
}
