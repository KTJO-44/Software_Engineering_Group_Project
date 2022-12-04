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
