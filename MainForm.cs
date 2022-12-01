using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Investment_ideas_platform
{
    public partial class MainForm : Form
    {
        String u1 = "RM";
        String p1 = "rmpwd";
        String u2 = "CL";
        String p2 = "clpwd";
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLoginCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtbx_login_uname.Text.Equals("RM") && txb_login_pwd.Text.Equals("rmpwd"))
            {
                this.Hide();
                Program.userLoggedIn = true;
                HomeForm f2 = new HomeForm();
                f2.setUser(txtbx_login_uname.Text, "RM");
                lab_login_error.Text = "";
                txtbx_login_uname.Text = "";
                txb_login_pwd.Text = "";
                Program.currForm = f2;
                f2.Show();
            }
            else if (txtbx_login_uname.Text.Equals("CL") && txb_login_pwd.Text.Equals("clpwd"))
            {
                this.Hide();
                Program.userLoggedIn = true;
                HomeForm f2 = new HomeForm();
                f2.setUser(txtbx_login_uname.Text, "CL");
                lab_login_error.Text = "";
                txtbx_login_uname.Text = "";
                txb_login_pwd.Text = "";
                Program.currForm = f2;
                f2.Show();
            }
            else if (txtbx_login_uname.Text.Equals("IG") && txb_login_pwd.Text.Equals("igpwd"))
            {
                this.Hide();
                Program.userLoggedIn = true;
                HomeForm f2 = new HomeForm();
                f2.setUser(txtbx_login_uname.Text, "IG");
                lab_login_error.Text = "";
                txtbx_login_uname.Text = "";
                txb_login_pwd.Text = "";
                Program.currForm = f2;
                f2.Show();
            }
            else
            {
                lab_login_error.Text = "Incorrect credentials.";
            }
        }
    }
}
