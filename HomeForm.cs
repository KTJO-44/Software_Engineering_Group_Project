using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Investment_ideas_platform
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();

            pnDashboard.Visible = true;
            pnViewIdeas.Visible = false;

        }

        private void btnViewIdeas_Click(object sender, EventArgs e)
        {
            pnDashboard.Visible = false;
            pnViewIdeas.Visible = true;
        }
    }
}
