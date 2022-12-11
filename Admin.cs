using System;
using System.Data;
using System.Windows.Forms;

namespace Investment_ideas_platform
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();

            //Make sure all page panels are hidden (not the menu patterns), so the correct panel can be displayed when
            //the user logs in
            hideMainPanels();
            //Show the homepage panel
            pnAdminHomepage.Visible = true;

            //retrieve the email of the user that is logged in currently. This can be used to determine other information
            string userEmail = User.userEmail;
            //Use the user's email to get their first name from the database
            string userFirstName = DBConnection.getInstanceOfDBConnection().getSingleValueUsingJustEmail(Constants.FETCH_USER_FIRSTNAME, userEmail);
            //Display the user's first name on the homepage and the menu
            lblAdminWelcome.Text = "Welcome, " + userFirstName + "!";
            lblAdminMenuName.Text = userFirstName;

            //Load the data grid view once at the start of the program, and design the column names to look nice.
            //First, the dataset must be loaded so that the dgv knows which columns to use, then the dgv can be edited.
            //Once the dgv has been loaded in once, the loadDGViewAllAccounts() method can be run again and again to
            //refresh the data and load it in again to the already created dgv.
            loadDGVViewAllAccounts();
            //Rename the column names, otherwise, the dgv will use the database column names which do not look as professional
            dgvViewAllAccounts.Columns[0].HeaderText = "Email";
            dgvViewAllAccounts.Columns[1].HeaderText = "First name";
            dgvViewAllAccounts.Columns[2].HeaderText = "Last name";
            dgvViewAllAccounts.Columns[3].HeaderText = "Account type";
            //Change the width of the email column so there is enough space to show the data
            dgvViewAllAccounts.Columns[0].Width = 200;
            dgvViewAllAccounts.Columns[3].Width = 180;
            //Add a button column, so that each row can can be deleted with a single button press
            DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
            btnCol.HeaderText = "Delete account";
            btnCol.Text = "Delete";
            btnCol.Name = "btnDeleteAccount";
            btnCol.UseColumnTextForButtonValue = true;
            //Add the button column to the dgv
            dgvViewAllAccounts.Columns.Add(btnCol);
            
            //This is the same concept with loading admin notifications into a different dgv
            loadDGVViewAdminNotifications();
            dgvViewAdminNotifications.Columns[0].HeaderText = "Email";
            dgvViewAdminNotifications.Columns[1].HeaderText = "First name";
            dgvViewAdminNotifications.Columns[2].HeaderText = "Last name";
            dgvViewAdminNotifications.Columns[3].HeaderText = "Timestamp";
            dgvViewAdminNotifications.Columns[4].HeaderText = "Notification type";
            dgvViewAdminNotifications.Columns[0].Width = 200;
            dgvViewAdminNotifications.Columns[4].Width = 180;
            //Instead of a delete button for each row, this dgv will have a reset password button for each row,
            //which will reset the account password for the account on that row
            DataGridViewButtonColumn btnColResetPassword = new DataGridViewButtonColumn();
            btnColResetPassword.HeaderText = "Reset password";
            btnColResetPassword.Text = "Reset";
            btnColResetPassword.Name = "btnResetForgottenPassword";
            btnColResetPassword.UseColumnTextForButtonValue = true;
            dgvViewAdminNotifications.Columns.Add(btnColResetPassword);

        }

        public void hideMainPanels()
        {
            //Add all the main page panels that will be hidden when a user logs in or a menu button is pressed.
            //This is to ensure that the correct panel is displayed by preventing panels hiding behind each other.
            pnAdminHomepage.Visible = false;
            pnAdminNotifications.Visible = false;
            pnCreateAccounts.Visible = false;
            pnViewAccounts.Visible = false;
            pnAdminMyProfile.Visible = false;
            pnCAConfirmation.Visible = false;
            pnChangePassword.Visible = false;
        }

        private void btnHomepage_Click(object sender, EventArgs e)
        {
            //Hide, other panels, then show the homepage panel by making it visible
            hideMainPanels();
            pnAdminHomepage.Visible = true;
        }

        private void btnAdminNotifications_Click(object sender, EventArgs e)
        {
            hideMainPanels();
            pnAdminNotifications.Visible = true;
        }

        private void loadDGVViewAdminNotifications()
        {
            //Get the dataset that will be put into the corresponding data grid view using this method from DBConnection
            DataSet ds = DBConnection.getInstanceOfDBConnection().getDataSet(Constants.FETCH_RESET_NOTIFICATIONS);

            //Set the datasource for the dgv as the ds we just created by fetching data from the database.
            dgvViewAdminNotifications.DataSource = ds.Tables[0];

        }

        private void btnCreateAccounts_Click(object sender, EventArgs e)
        {
            hideMainPanels();
            pnCreateAccounts.Visible = true;
            //Set the combo box style to dropdownlist which will prevent the user from typing their own text into it.
            //They will only be able to select from a list of pre-designed options.
            cbCAAccountType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnViewAccounts_Click(object sender, EventArgs e)
        {
            hideMainPanels();
            loadDGVViewAllAccounts();
            pnViewAccounts.Visible = true;
        }

        private void btnMyProfileAdmin_Click(object sender, EventArgs e)
        {
            hideMainPanels();
            pnAdminMyProfile.Visible = true;

            //On the admin's profile page, their email, name and last name are displayed.
            //Get this information from the database using the User class (which contains the user's email),
            //then set the label on the panel to the corresponding information.
            lblAdminMPEmailFetched.Text = User.userEmail;
            //We only need to get a single, but different value, but we can use the same method with different input parameters - in this case, different
            //SQL queries were used with the same email.
            lblAdminMPFirstNameFetched.Text = DBConnection.getInstanceOfDBConnection().getSingleValueUsingJustEmail(Constants.FETCH_USER_FIRSTNAME, User.userEmail);
            lblAdminMPLastNameFetched.Text = DBConnection.getInstanceOfDBConnection().getSingleValueUsingJustEmail(Constants.FETCH_USER_LASTNAME, User.userEmail);

        }

        private void btnAdminLogout_Click(object sender, EventArgs e)
        {
            //When the user clicks the logout button, reset the information in the User class to empty, since the user
            //will no longer be logged in
            User.userEmail = "";
            //Close the current form, and display the login form
            this.Close();
            Program.userLoggedIn = false;
            Program.currForm = null;
            Program.f1.Show();
        }

        private void btnAdminExit_Click(object sender, EventArgs e)
        {
            //When the exit button is clicked, close the whole application
            Application.Exit();
        }

        private void clearCreateAccountTBs()
        {
            //Clear the text boxes on the create account panel.
            //This code will be called multiple times, to clear the text boxes in various situations.
            tbCAEmail.Clear();
            tbCAFirstName.Clear();
            tbCALastName.Clear();

            //Reset the combo box selection, and set it to -1, so nothing will be selected instead of one of the options
            cbCAAccountType.ResetText();
            cbCAAccountType.SelectedIndex = -1;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            //Get all the information required for making a new account.
            //Get strings from the text boxes.
            string newAccountEmail = tbCAEmail.Text;
            //Get the account type from the combo box.
            string newAccountType = cbCAAccountType.GetItemText(cbCAAccountType.Text);
            string newAccountFirstName = tbCAFirstName.Text;
            string newAccountLastName = tbCALastName.Text;

            //Pass the information to the class CreateAccount and the method, in order to create a new account.
            string createAccount = CreateAccount.createNewAccount(newAccountEmail, newAccountType, newAccountFirstName, newAccountLastName);

            //If the createAccount method returns a string (a generated password), it was successful.
            if (createAccount != "")
            {
                //Show a confirmation message, which includes the password for the new account
                pnCAConfirmation.Visible = true;
                //Bring this panel to the front in case it is hiding behind its parent panel
                pnCAConfirmation.BringToFront();
                //Show the generated password string to the user in a text box, so they can copy it and send it to the new account owner
                tbCAGeneratedPassword.Text = createAccount;
                //Clear the text boxes so that another account can immediately be created
                clearCreateAccountTBs();
            }
            else
            {
                //If a field didn't contain any values, show the user the error so they know what to do to create a new account
                MessageBox.Show("Please fill in all fields and make sure you use a company email");
            }
        }

        private void btnCAContinue_Click(object sender, EventArgs e)
        {
            //On the create account confirmation panel, this button can be pressed to dismiss the message and hide it
            pnCAConfirmation.Visible = false;
        }

        private void loadDGVViewAllAccounts()
        {
            //Get the dataset that will be put into the corresponding data grid view using this method from DBConnection
            DataSet ds = DBConnection.getInstanceOfDBConnection().getDataSet(Constants.SELECT_VIEW_ALL_ACCOUNTS);

            //Set the datasource for the dgv as the ds we just created by fetching data from the database.
            dgvViewAllAccounts.DataSource = ds.Tables[0];
        }

        private void dgvViewAllAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Make the event of 'the delete button is pressed' in the button column of dgvViewAllAccounts
            //If the button is pressed, delete the account on that row.
            if (dgvViewAllAccounts.Columns[e.ColumnIndex].Name == "btnDeleteAccount")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //If the user confirms they want to delete the account, get the index of the row
                    //Use the row index to find out the email of the account to be deleted
                    int selectedrowindex = dgvViewAllAccounts.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvViewAllAccounts.Rows[selectedrowindex];
                    string cellValue = Convert.ToString(selectedRow.Cells["Email"].Value);
                    //Use the DeleteAccount class to delete the account
                    bool deleteStaffAccount = DeleteAccount.deleteStaffAccount(cellValue);

                    if (deleteStaffAccount)
                    {
                        //If the account was deleted, refresh the dgv to reflect the change
                        loadDGVViewAllAccounts();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete account");
                    }
                }
            }
        }

        private void btnMPChangePassword_Click(object sender, EventArgs e)
        {
            //If the user presses the change password button on the profile panel, show the change password panel
            pnChangePassword.Visible = true;
        }

        private void btnConfirmChangePassword_Click(object sender, EventArgs e)
        {
            //When the use wants to change their password:
            //Get their email from the User class
            //Get their old password and new passwords from the text boxes
            string userEmail = User.userEmail;
            string oldPassword = tbOldPassword.Text;
            string newPassword = tbNewPassword.Text;
            string confirmNewPassword = tbConfirmNewPassword.Text;

            //Check that there is some text in each textbox. If there is, the passwords can be checked
            if (!oldPassword.Equals("") && !newPassword.Equals("") && !confirmNewPassword.Equals("")) { 
                //Authenticate the current password
                if (DBConnection.getInstanceOfDBConnection().authenticatePassword(Constants.FETCH_PASSWORD, userEmail, oldPassword))
                {
                    //If the password was correct, check that the new passwords match, then change the password with the corresponding email in the database
                    if (ChangePassword.changeExistingPassword(userEmail, newPassword, confirmNewPassword))
                    {
                        //If the password was changed successfully, tell the user, then clear the text boxes
                        MessageBox.Show("Password updated successfully");
                        tbOldPassword.Clear();
                        tbNewPassword.Clear();
                        tbConfirmNewPassword.Clear();
                        //Make the change password panel invisible, as the user has successfully changed their password
                        pnChangePassword.Visible = false;
                    }
                    else
                    {
                        //Tell the user why changing the password didn't work, and what they need to do to complete it
                        MessageBox.Show("New passwords didn't match");
                        //Clear the new password text boxes so they can type in their new password again
                        tbNewPassword.Clear();
                        tbConfirmNewPassword.Clear();
                    }
                }
                else
                {
                    //Tell them if their password was incorrect so they know they have to re-type it
                    MessageBox.Show("Password was incorrect");
                    //Clear all text boxes so the user can try again
                    tbOldPassword.Clear();
                    tbNewPassword.Clear();
                    tbConfirmNewPassword.Clear();
                }
            }
            else
            {
                //Show this message so the user knows they need to type something into every box
                MessageBox.Show("Please fill in all boxes");
                tbOldPassword.Clear();
                tbNewPassword.Clear();
                tbConfirmNewPassword.Clear();
            }

        }

        private void btnChangePasswordCancel_Click(object sender, EventArgs e)
        {
            //If the user decides to cancel changing their password, hide the change password panel
            pnChangePassword.Visible = false;
        }

        private void dgvViewAdminNotifications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Make the event of 'the reset password button is pressed' in the button column of dgvViewAdminNotifications
            //If the button is pressed, reset the password of the account on that row.
            if (dgvViewAdminNotifications.Columns[e.ColumnIndex].Name == "btnResetForgottenPassword")
            {
                if (MessageBox.Show("Are you sure you want to reset this account's password?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //If the user confirms they want to reset the password for the account, get the index of the row
                    //Use the row index to find out the email of the account to be password reset
                    int selectedrowindex = dgvViewAdminNotifications.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvViewAdminNotifications.Rows[selectedrowindex];
                    string cellValue = Convert.ToString(selectedRow.Cells["Email"].Value);
                    //Use the ChangePassword class to change the password of the staff's account
                    bool resetStaffAccountPassword = ChangePassword.resetStaffPassword(cellValue);
                    if (resetStaffAccountPassword)
                    {
                        //If the account's password was reset, refresh the dgv to reflect the change (the notification will disappear)
                        MessageBox.Show("Success!");
                        loadDGVViewAdminNotifications();
                    }
                    else
                    {
                        MessageBox.Show("Failed to reset password");
                    }
                }
            }
        }
    }
}
