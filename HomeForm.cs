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

            pnNavBtnHighlighter.Height = btnDashboard.Height;
            pnNavBtnHighlighter.Top = btnDashboard.Top;
            pnNavBtnHighlighter.Left = btnDashboard.Left;
        }
        private void Form2_Shown(object sender, EventArgs e)
        {
            //textBox1.Text = username;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //dashBoardRM1.BringToFront()
            // Controls.Clear();
            /*
            if (usertype.Equals("RM"))
            {
                DashBoardRM dashBoardRM = new DashBoardRM(username);
                Controls.Add(dashBoardRM);
            }
            if (usertype.Equals("CL"))
            {
                DashBoardCL dashBoardCL = new DashBoardCL(username);
                Controls.Add(dashBoardCL);
            }
            if (usertype.Equals("IG"))
            {
                DashBoardIG dashBoardIG = new DashBoardIG(username);
                Controls.Add(dashBoardIG);
            }
            */
            setPanelsInvisible();
            pnDashboard.Visible = true;
            //Controls.Clear();
        }

        public void setUser(String uname, String utype)
        {
            //username = uname;
            //usertype = utype;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Program.userLoggedIn = false;
            Program.currForm = null;
            Program.f1.Show();
        }

        private void setPanelsInvisible()
        {
            pnDashboard.Visible = false;
            pnIdeas.Visible = false;
            pnProducts.Visible = false;
            pnClients.Visible = false;
            
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            setPanelsInvisible();
            pnNavBtnHighlighter.Height = btnDashboard.Height;
            pnNavBtnHighlighter.Top = btnDashboard.Top;
            pnNavBtnHighlighter.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
            pnDashboard.Visible = true;
        }

        private void btnIdeas_Click(object sender, EventArgs e)
        {
            setPanelsInvisible();
            pnNavBtnHighlighter.Height = btnIdeas.Height;
            pnNavBtnHighlighter.Top = btnIdeas.Top;
            pnNavBtnHighlighter.Left = btnIdeas.Left;
            btnIdeas.BackColor = Color.FromArgb(46, 51, 73);
            pnIdeas.Visible = true;
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            setPanelsInvisible();
            pnNavBtnHighlighter.Height = btnProducts.Height;
            pnNavBtnHighlighter.Top = btnProducts.Top;
            pnNavBtnHighlighter.Left = btnProducts.Left;
            btnProducts.BackColor = Color.FromArgb(46, 51, 73);
            pnProducts.Visible = true;
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            setPanelsInvisible();
            pnNavBtnHighlighter.Height = btnClients.Height;
            pnNavBtnHighlighter.Top = btnClients.Top;
            pnNavBtnHighlighter.Left = btnClients.Left;
            btnClients.BackColor = Color.FromArgb(46, 51, 73);
            pnClients.Visible = true;
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnIdeas_Leave(object sender, EventArgs e)
        {
            btnIdeas.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnProducts_Leave(object sender, EventArgs e)
        {
            btnProducts.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnClients_Leave(object sender, EventArgs e)
        {
            btnClients.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
