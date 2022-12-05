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
        // Named as btn_logout with behaviour activated on click
        // Used to log out of the application

        private void btn_logout_Click(object sender, EventArgs e) // button event based on user click
        {
            Application.Exit(); // Exit application 
        }
    }
}
