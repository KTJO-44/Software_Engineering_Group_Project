using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

// Form created to make idea creator page
// This will house idea creator capabilities
// Partial class will enable public merge between forms allowing to switch from form to form in future

namespace Investment_ideas_platform
{
    public partial class idea_creator : Form // Form created
    {
        public idea_creator() 
        {
            InitializeComponent();
        }
        
        // Adding a button to the form 
        // Named as btn_exit with behaviour activated on click
        // Used to exit out of the application
        private void btn_exit_Click(object sender, EventArgs e) // button event based on user click
        {
            Application.Exit(); // Exit application 
        }

        // Adding a button to the form 
        // Named as btn_logout with the behaviour activated on click
        // Used to logout of the form back to login screen
        // Should hide the current form of the idea creator and then bring up the login form 
        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close(); // this.Close is to close current form 
            Program.userLoggedIn = false; // current user from true to false to logout the idea creator
            Program.currForm = null; // current form is closed
            Program.f1.Show(); // show form 1 which is the main form for the login page
        }
    }
}
