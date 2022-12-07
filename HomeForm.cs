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
            pnViewAllClients.Visible = false;
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

            LoadDGVViewAllProducts();
            DGVViewAllProducts.Columns[0].HeaderText = "Product name";



        }

        private void LoadDGVViewAllProducts()
        {
            DataSet ds = DBConnection.getInstanceOfDBConnection().getDataSet(Constants.SELECT_VIEW_ALL_PRODUCTS);


            DGVViewAllProducts.DataSource = ds.Tables[0];


        }

        private void btnASortProducts_Click(object sender, EventArgs e)
        {
            DGVViewAllProducts.Sort(DGVViewAllProducts.Columns[0], ListSortDirection.Ascending);
        }

        private void btnDSortProducts_Click(object sender, EventArgs e)
        {
            DGVViewAllProducts.Sort(DGVViewAllProducts.Columns[0], ListSortDirection.Descending);
        }

        private void txtFilterBoxProducts_TextChanged(object sender, EventArgs e)
        {
            (DGVViewAllProducts.DataSource as DataTable).DefaultView.RowFilter = string.Format("productName = '{0}' OR productType = '{0}' OR companyName = '{0}' OR productDescription = '{0}'", txtFilterBoxProducts.Text);
        }

        private void btnViewClients_Click(object sender, EventArgs e)
        {
            pnDashboard.Visible = false;
            pnViewAllClients.Visible = true;


            LoadDGVViewAllClients();
            DGVViewAllClients.Columns[0].HeaderText = "First name";

            DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
            btnCol.HeaderText = "Delete account";
            btnCol.Text = "Delete";
            btnCol.Name = "btnDeleteAccount";
            btnCol.UseColumnTextForButtonValue = true;
            DGVViewAllClients.Columns.Add(btnCol);


        }

        private void LoadDGVViewAllClients()
        {
            DataSet ds = DBConnection.getInstanceOfDBConnection().getDataSet(Constants.SELECT_VIEW_ALL_CLIENTS);


            DGVViewAllClients.DataSource = ds.Tables[0];


        }



        private void DGVViewAllClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //int index = dgvViewAllAccounts.SelectedRows[0].Index;
                    int selectedrowindex = DGVViewAllClients.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = DGVViewAllClients.Rows[selectedrowindex];
                    string cellValue = Convert.ToString(selectedRow.Cells["firstName"].Value);
                    bool deleteClientAccount = DeleteClient.deleteClientAccount(cellValue);

                    if (deleteClientAccount)
                    {
                        MessageBox.Show("Success!");
                        //refresh dgv
                        LoadDGVViewAllClients(); //This adds a couple columns/messes things up.
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete account");
                    }
                    //MessageBox.Show(cellValue);
                    //delete func here
                }
            }
        }

        private void btnASortclientProfile_Click(object sender, EventArgs e)
        {
            DGVViewAllClients.Sort(DGVViewAllClients.Columns[0], ListSortDirection.Ascending);
        }

        private void btnDSortclientProfile_Click(object sender, EventArgs e)
        {
            DGVViewAllClients.Sort(DGVViewAllClients.Columns[0], ListSortDirection.Descending);
        }
    }
}

       
    


