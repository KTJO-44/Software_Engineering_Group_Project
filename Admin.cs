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

        }

        public void hideMainPanels()
        {
            //Will contain code to hide page panels
            pnAdminHomepage.Visible = false;
            pnAdminNotifications.Visible = false;
            pnCreateAccounts.Visible = false;
            pnViewAccounts.Visible = false;
            pnAdminMyProfile.Visible = false;
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
        }

        private void btnViewAccounts_Click(object sender, EventArgs e)
        {
            hideMainPanels();
            pnViewAccounts.Visible = true;
        }

        private void btnMyProfileAdmin_Click(object sender, EventArgs e)
        {
            hideMainPanels();
            pnAdminMyProfile.Visible = true;
        }
    }
}
