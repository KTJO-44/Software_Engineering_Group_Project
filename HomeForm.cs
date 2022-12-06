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
            pnViewAllProducts.Visible = false;
        }

        private void btnViewIdeas_Click(object sender, EventArgs e)
        {
            pnDashboard.Visible = false;
            pnViewIdeas.Visible = true;


            LoadDGVViewAllIdeas();
            DGVViewAllIdeas.Columns[0].HeaderText = "Idea Title";

          

        }

        private void LoadDGVViewAllIdeas()
        {
            DataSet ds = DBConnection.getInstanceOfDBConnection().getDataSet(Constants.SELECT_VIEW_ALL_IDEAS);


            DGVViewAllIdeas.DataSource = ds.Tables[0];


        }

        private void ASortIdeas_Click(object sender, EventArgs e)
        {
            DGVViewAllIdeas.Sort(DGVViewAllIdeas.Columns[0], ListSortDirection.Ascending);
        }

        private void DSortIdeas_Click(object sender, EventArgs e)
        {
            DGVViewAllIdeas.Sort(DGVViewAllIdeas.Columns[0], ListSortDirection.Descending);
        }

        private void txtFilterboxIdea_TextChanged(object sender, EventArgs e)
        {
            (DGVViewAllIdeas.DataSource as DataTable).DefaultView.RowFilter = string.Format("ideaTitle = '{0}' OR abstract = '{0}'", txtFilterboxIdea.Text);
        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            pnDashboard.Visible = false;
            pnViewAllProducts.Visible = true;
        }
    }
}

