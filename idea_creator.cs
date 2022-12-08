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
            hideMainPanel(); // Function created to hide panels
            pn_main_dashboard.Visible = true; // When form is called upon by login, set dashboard panel to true to be shown first
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

        // Create a function in which all panels are set to false for .Visible
        // This means that all the panels listed within the function will not be shown
        // We can use this function to be called on to switch to True in which the panel will be shown
        public void hideMainPanel()
        {
            pn_main_dashboard.Visible = false;
            pn_ideas.Visible = false;
            pn_ideas.Visible = false;
        }

        private void btn_home_Click(object sender, EventArgs e) // Create event on btn click
        {
            hideMainPanel(); // Function
            pn_main_dashboard.Visible = true; // When btn click show the main dashboard page
        }

        private void btn_ideas_Click(object sender, EventArgs e) // Create event on btn click
        {
            hideMainPanel(); // Function
            pn_ideas.Visible = true; // When btn click show the ideas page
            cb_risk_rating.DropDownStyle = ComboBoxStyle.DropDownList; // Stops user from inputting data into dropdown box
        }

        private void btn_products_Click(object sender, EventArgs e) // Create event on btn click
        {
            hideMainPanel(); // Function
            pnl_products.Visible = true;  // When btn is clicked show the products page
        }

        private void load_dgv_view_all_ideas()
        {
            DataSet ds = DBConnection.getInstanceOfDBConnection().getDataSet(Constants.SELECT_VIEW_ALL_IDEAS);
            dgv_view_all_ideas.DataSource = ds.Tables[0];
        }
        
    }
}
