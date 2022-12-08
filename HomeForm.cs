using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            pnChangePI1.Visible = false;
            pnChangePL1.Visible = false;
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

        private void txtFilterboxClientProfiles_TextChanged(object sender, EventArgs e)
        {
            (DGVViewAllClients.DataSource as DataTable).DefaultView.RowFilter = string.Format("firstName = '{0}' OR lastName = '{0}' OR email = '{0}' OR preferenceItem1 = '{0}' OR preferenceItem2 = '{0}' OR preferenceItem3 = '{0}'OR preferenceLocation1 = '{0}' OR preferenceLocation2 = '{0}' OR preferenceLocation3= '{0}'", txtFilterboxClientProfiles.Text);
        }

        private void btnCreateClient_Click(object sender, EventArgs e)
        {
            //Get inputs from the text boxes and send them to the backend to create the account
            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
            string email = textBox3.Text;
            string phoneNumber = textBox4.Text;
            string riskRating = comboBox1.GetItemText(comboBox1.Text);
            string preferenceItem1 = comboBox2.GetItemText(comboBox2.Text);
            string preferenceItem2 = comboBox3.GetItemText(comboBox3.Text);
            string preferenceItem3 = comboBox4.GetItemText(comboBox4.Text);
            string preferenceLocation1 = comboBox5.GetItemText(comboBox5.Text);
            string preferenceLocation2 = comboBox6.GetItemText(comboBox6.Text);
            string preferenceLocation3 = comboBox7.GetItemText(comboBox7.Text);


            //string password = tbPassword.Text; //Don't need password when creating an account, only when changing/logging in

            //CreateAccount createAccount = new CreateAccount(accountEmail, selectedItem, accountFirstName, accountLastName);
            bool createClient = CreateClient.createNewClient(firstName, lastName, email, phoneNumber, riskRating, preferenceItem1, preferenceItem2, preferenceItem3, preferenceLocation1, preferenceLocation2, preferenceLocation3);

            if (createClient)
            {
                MessageBox.Show("Success!");
          
            }
            else
            {
                MessageBox.Show("Please fill in all fields and make sure you use a company email");
            }
        }

  


        private void btnChangePI1_Click(object sender, EventArgs e)
        {
            pnDashboard.Visible = false;
            pnChangePI1.Visible = true;
        }

        private void btnChangeItem1_Click(object sender, EventArgs e)
        {

            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jordan English\OneDrive - Anglia Ruskin University\seee\InvestmentIdeasDB.mdf;Integrated Security=True;Connect Timeout=30");
            con1.Open();
            SqlCommand cmd1 = new SqlCommand("update clientProfiles set preferenceItem1='" + cmbChangePI1.GetItemText(cmbChangePI1.Text) + "' where email='" + txtClientEmailItem1.Text +  "'", con1);
            cmd1.ExecuteNonQuery();
           

            SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jordan English\OneDrive - Anglia Ruskin University\seee\InvestmentIdeasDB.mdf;Integrated Security=True;Connect Timeout=30");
            con2.Open();
            SqlCommand cmd2 = new SqlCommand("update clientProfiles set preferenceItem2='" + cmbChangePI2.GetItemText(cmbChangePI2.Text) + "' where email='" + txtClientEmailItem1.Text + "'", con2);
            cmd2.ExecuteNonQuery();


            SqlConnection con3 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jordan English\OneDrive - Anglia Ruskin University\seee\InvestmentIdeasDB.mdf;Integrated Security=True;Connect Timeout=30");
            con3.Open();
            SqlCommand cmd3 = new SqlCommand("update clientProfiles set preferenceItem3='" + cmbChangePI3.GetItemText(cmbChangePI3.Text) + "' where email='" + txtClientEmailItem1.Text + "'", con2);
            cmd3.ExecuteNonQuery();



            MessageBox.Show("Please check database to see if your data is updated.");

            con1.Close();
            con2.Close();
            con3.Close();
        }

        private void btnChangePL_Click(object sender, EventArgs e)
        {
            pnDashboard.Visible = false;
            pnChangePL1.Visible = true; 
        }

        private void btnChangeLocations1_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jordan English\OneDrive - Anglia Ruskin University\seee\InvestmentIdeasDB.mdf;Integrated Security=True;Connect Timeout=30");
            con1.Open();
            SqlCommand cmd1 = new SqlCommand("update clientProfiles set preferenceLocation1='" + cmbChangePL1.GetItemText(cmbChangePL1.Text) + "' where email='" + txtClientEmailLocation1.Text + "'", con1);
            cmd1.ExecuteNonQuery();


            SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jordan English\OneDrive - Anglia Ruskin University\seee\InvestmentIdeasDB.mdf;Integrated Security=True;Connect Timeout=30");
            con2.Open();
            SqlCommand cmd2 = new SqlCommand("update clientProfiles set preferenceLocation2='" + cmbChangePL2.GetItemText(cmbChangePL2.Text) + "' where email='" + txtClientEmailLocation1.Text + "'", con2);
            cmd2.ExecuteNonQuery();


            SqlConnection con3 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jordan English\OneDrive - Anglia Ruskin University\seee\InvestmentIdeasDB.mdf;Integrated Security=True;Connect Timeout=30");
            con3.Open();
            SqlCommand cmd3 = new SqlCommand("update clientProfiles set preferenceLocation3='" + cmbChangePL3.GetItemText(cmbChangePL3.Text) + "' where email='" + txtClientEmailLocation1.Text + "'", con2);
            cmd3.ExecuteNonQuery();



            MessageBox.Show("Please check database to see if your data is updated.");

            con1.Close();
            con2.Close();
            con3.Close();
        }
    }
    }
    




       
    


