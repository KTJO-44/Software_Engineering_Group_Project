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
        public Admin(User user)
        {
            InitializeComponent();
            hideMainPanels();
            pnAdminHomepage.Visible = true;

            string userEmail = user.UserEmail;
            string userFirstName = DBConnection.getInstanceOfDBConnection().getUserFirstName(Constants.FETCH_USER_FIRSTNAME, userEmail);
            lblAdminWelcome.Text = "Welcome " + userFirstName; //does not work for some reason

            loadDGVViewAllAccounts();
            dgvViewAllAccounts.Columns[0].HeaderText = "Email";
            DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
            btnCol.HeaderText = "Delete account";
            btnCol.Text = "Delete";
            btnCol.Name = "btnDeleteAccount";
            btnCol.UseColumnTextForButtonValue = true;
            dgvViewAllAccounts.Columns.Add(btnCol);

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
    }
}
