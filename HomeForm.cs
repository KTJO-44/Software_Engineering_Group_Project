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
    }
}
