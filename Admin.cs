using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Investment_ideas_platform
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            hideMainPanels();
            pnAdminHomepage.Visible = true;

            string userEmail = User.userEmail;
            string userFirstName = DBConnection.getInstanceOfDBConnection().getSingleValueUsingJustEmail(Constants.FETCH_USER_FIRSTNAME, userEmail);
            lblAdminWelcome.Text = "Welcome, " + userFirstName + "!";
            lblAdminMenuName.Text = userFirstName;

            loadDGVViewAllAccounts();
            dgvViewAllAccounts.Columns[0].HeaderText = "Email";
            DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
            btnCol.HeaderText = "Delete account";
            btnCol.Text = "Delete";
            btnCol.Name = "btnDeleteAccount";
            btnCol.UseColumnTextForButtonValue = true;
            dgvViewAllAccounts.Columns.Add(btnCol);
            
            if (DBConnection.getInstanceOfDBConnection().notificationsExist(Constants.CHECK_EXISTS_NOTIFICATIONS))
            {
                //If there are notifications, load them in
                loadDGVViewAdminNotifications();
            }
            
        }

        public void hideMainPanels()
        {
            //Will contain code to hide page panels
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
            hideMainPanels();
            pnAdminHomepage.Visible = true;
        }

        private void btnAdminNotifications_Click(object sender, EventArgs e)
        {
            hideMainPanels();
            pnAdminNotifications.Visible = true;
        }

        //#####################################################
        private void loadDGVViewAdminNotifications()
        {
            DataSet ds = DBConnection.getInstanceOfDBConnection().getDataSet(Constants.FETCH_RESET_NOTIFICATIONS);

            dgvViewAdminNotifications.DataSource = ds.Tables[0];
        }

        private void btnCreateAccounts_Click(object sender, EventArgs e)
        {
            hideMainPanels();
            pnCreateAccounts.Visible = true;
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

            lblAdminMPEmailFetched.Text = User.userEmail;
            lblAdminMPFirstNameFetched.Text = DBConnection.getInstanceOfDBConnection().getSingleValueUsingJustEmail(Constants.FETCH_USER_FIRSTNAME, User.userEmail);
            lblAdminMPLastNameFetched.Text = DBConnection.getInstanceOfDBConnection().getSingleValueUsingJustEmail(Constants.FETCH_USER_LASTNAME, User.userEmail);

        }

        private void btnAdminLogout_Click(object sender, EventArgs e)
        {

            this.Close();
            Program.userLoggedIn = false;
            Program.currForm = null;
            Program.f1.Show();
        }

        private void btnAdminExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearCreateAccountTBs()
        {
            tbCAEmail.Clear();
            tbCAFirstName.Clear();
            tbCALastName.Clear();
            cbCAAccountType.ResetText();
            cbCAAccountType.SelectedIndex = -1;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string newAccountEmail = tbCAEmail.Text;
            string newAccountType = cbCAAccountType.GetItemText(cbCAAccountType.Text);
            string newAccountFirstName = tbCAFirstName.Text;
            string newAccountLastName = tbCALastName.Text;

            string createAccount = CreateAccount.createNewAccount(newAccountEmail, newAccountType, newAccountFirstName, newAccountLastName);

            if (createAccount != "")
            {
                pnCAConfirmation.Visible = true;
                pnCAConfirmation.BringToFront();
                tbCAGeneratedPassword.Text = createAccount;
                clearCreateAccountTBs();
            }
            else
            {
                MessageBox.Show("Please fill in all fields and make sure you use a company email");
            }
        }

        private void btnCAContinue_Click(object sender, EventArgs e)
        {
            pnCAConfirmation.Visible = false;
        }

        private void loadDGVViewAllAccounts()
        {
            DataSet ds = DBConnection.getInstanceOfDBConnection().getDataSet(Constants.SELECT_VIEW_ALL_ACCOUNTS);

            dgvViewAllAccounts.DataSource = ds.Tables[0];
        }

        private void dgvViewAllAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvViewAllAccounts.Columns[e.ColumnIndex].Name == "btnDeleteAccount")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //int index = dgvViewAllAccounts.SelectedRows[0].Index;
                    int selectedrowindex = dgvViewAllAccounts.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvViewAllAccounts.Rows[selectedrowindex];
                    string cellValue = Convert.ToString(selectedRow.Cells["Email"].Value);
                    bool deleteStaffAccount = DeleteAccount.deleteStaffAccount(cellValue);

                    if (deleteStaffAccount)
                    {
                        //MessageBox.Show("Success!");
                        //refresh dgv
                        loadDGVViewAllAccounts(); //This adds a couple columns/messes things up.
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete account");
                    }
                    //MessageBox.Show(cellValue);
                    //delete func here
                }
            }
        }

        private void btnMPChangePassword_Click(object sender, EventArgs e)
        {
            pnChangePassword.Visible = true;
        }

        private void btnConfirmChangePassword_Click(object sender, EventArgs e)
        {
            string userEmail = User.userEmail;
            string oldPassword = tbOldPassword.Text;
            string newPassword = tbNewPassword.Text;
            string confirmNewPassword = tbConfirmNewPassword.Text;

            if (!oldPassword.Equals("") && !newPassword.Equals("") && !confirmNewPassword.Equals("")) { 
                //Authenticate current password
                if (DBConnection.getInstanceOfDBConnection().authenticatePassword(Constants.FETCH_PASSWORD, userEmail, oldPassword))
                {
                    //pass was correct
                    if (ChangePassword.changeExistingPassword(userEmail, newPassword, confirmNewPassword))
                    {
                        MessageBox.Show("Password updated successfully");
                        tbOldPassword.Clear();
                        tbNewPassword.Clear();
                        tbConfirmNewPassword.Clear();
                        pnChangePassword.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("New passwords didn't match");
                        tbNewPassword.Clear();
                        tbConfirmNewPassword.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Password was incorrect");
                    tbOldPassword.Clear();
                    tbNewPassword.Clear();
                    tbConfirmNewPassword.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please fill in all boxes");
                tbOldPassword.Clear();
                tbNewPassword.Clear();
                tbConfirmNewPassword.Clear();
            }

        }

        private void btnChangePasswordCancel_Click(object sender, EventArgs e)
        {
            pnChangePassword.Visible = false;
        }
    }
}
