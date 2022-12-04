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
            //User user = new User();
            //user.UserEmail = user.UserEmail;
            /*
            string userFirstName = user.UserEmail;
            lblAdminWelcome.Text = userFirstName;
            */
            string userEmail = user.UserEmail;
            string userFirstName = DBConnection.getInstanceOfDBConnection().getUserFirstName(Constants.FETCH_USER_FIRSTNAME, userEmail);
            lblAdminWelcome.Text = "Welcome, " + userFirstName + "!"; //does not work for some reason

        }

        public void hideMainPanels()
        {
            //Will contain code to hide page panels
            pnAdminHomepage.Visible = false;
        }

        private void btnHomepage_Click(object sender, EventArgs e)
        {
            hideMainPanels();
            pnAdminHomepage.Visible = true;
        }
    }
}
