using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Investment_ideas_platform
{
    public partial class idea_creator : Form
    {
        public idea_creator()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exit application
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close(); // this.Close is to close current form 
            Program.userLoggedIn = false; // current user from true to false to logout the idea creator
            Program.currForm = null; // current form is closed
            Program.f1.Show(); // show form 1 which is the main form for the login page
        }
    }
}
