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

            load_dgv_view_all_ideas();
            load_dgv_view_all_products();

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
            load_dgv_view_all_ideas();
            load_dgv_view_all_products();
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

        // Create instance from constant SQL statement
        // This will load the data gathered from inputs to the database connection into the data grid
        // Datagrid based on ideas
        private void load_dgv_view_all_ideas() // Function name 
        {
            DataSet ds = DBConnection.getInstanceOfDBConnection().getDataSet(Constants.SELECT_VIEW_ALL_IDEAS2); // Use constant SQL to source data
            dgv_ideas.DataSource = ds.Tables[0]; // Create the datagrid source and load data into the according table
        }

        // Create instance from constant SQL statement
        // This will load the data gathered from inputs to the database connection into the data grid
        // Datagrid based on products
        private void load_dgv_view_all_products() // Function name 
        {
            DataSet ds = DBConnection.getInstanceOfDBConnection().getDataSet(Constants.SELECT_VIEW_ALL_PRODUCTS);
            dgv_products.DataSource = ds.Tables[0];
        }

        private void btn_add_idea_Click(object sender, EventArgs e)
        {
            string newIdeaTitle = txtb_idea_title.Text;
            string newAbstract = txtb_abstract.Text;
            string newExpiryDate = dtp_expiry_date.Value.ToString("yyyy-mm-dd");
            string newContent = txtb_idea_description.Text;
            string newRiskRating = cb_risk_rating.GetItemText(cb_risk_rating.Text);

            if (Create_Idea.create_new_idea(newIdeaTitle, newAbstract, newExpiryDate, newContent, newRiskRating))
            {
                MessageBox.Show("Idea has been successfully added");
                txtb_idea_title.Clear();
                txtb_abstract.Clear();
                dtp_expiry_date.ResetText();
                txtb_idea_description.Clear();
                cb_risk_rating.ResetText();
                cb_risk_rating.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Failed to insert new data");
                txtb_idea_title.Clear();
                txtb_abstract.Clear();
                dtp_expiry_date.ResetText();
                txtb_idea_description.Clear();
                cb_risk_rating.ResetText();
                cb_risk_rating.SelectedIndex = -1;
            }


        }

        private void btn_add_product_Click(object sender, EventArgs e)
        {
            string newProductName = txtb_product_name.Text;
            string newProductType = txtb_product_type.Text;
            string newCompanyName = txtb_company_name.Text;
            string newProductDescription = txtb_product_description.Text;

            if (createNewProduct.create_new_product(newProductName, newProductType, newCompanyName, newProductDescription))
            {
                MessageBox.Show("Product has been successfully added");
                txtb_product_name.Clear();
                txtb_product_type.Clear();
                txtb_company_name.Clear();
                txtb_product_description.Clear();
            }
            else
            {
                MessageBox.Show("Product fields are invalid");
                txtb_product_name.Clear();
                txtb_product_type.Clear();
                txtb_company_name.Clear();
                txtb_product_description.Clear();
            }
        }
    }
}