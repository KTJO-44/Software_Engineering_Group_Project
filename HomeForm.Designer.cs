
namespace Investment_ideas_platform
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.btnExit = new System.Windows.Forms.Button();
            this.pnDashboard = new System.Windows.Forms.Panel();
            this.btnViewProducts = new System.Windows.Forms.Button();
            this.btnViewIdeas = new System.Windows.Forms.Button();
            this.pnDashboardIdeas = new System.Windows.Forms.Panel();
            this.pbDMIdeas = new System.Windows.Forms.PictureBox();
            this.lblDMIdeasNumbers = new System.Windows.Forms.Label();
            this.lblDMIdeas = new System.Windows.Forms.Label();
            this.lblRMDashboard = new System.Windows.Forms.Label();
            this.pnIdeas = new System.Windows.Forms.Panel();
            this.lblIdeas = new System.Windows.Forms.Label();
            this.pnProducts = new System.Windows.Forms.Panel();
            this.lblProducts = new System.Windows.Forms.Label();
            this.pnClients = new System.Windows.Forms.Panel();
            this.lblClients = new System.Windows.Forms.Label();
            this.pnViewIdeas = new System.Windows.Forms.Panel();
            this.txtFilterboxIdea = new System.Windows.Forms.TextBox();
            this.DSortIdeas = new System.Windows.Forms.Button();
            this.ASortIdeas = new System.Windows.Forms.Button();
            this.DGVViewAllIdeas = new System.Windows.Forms.DataGridView();
            this.pnViewAllProducts = new System.Windows.Forms.Panel();
            this.btnDSortProducts = new System.Windows.Forms.Button();
            this.btnASortProducts = new System.Windows.Forms.Button();
            this.DGVViewAllProducts = new System.Windows.Forms.DataGridView();
            this.txtFilterBoxProducts = new System.Windows.Forms.TextBox();
            this.pnDashboard.SuspendLayout();
            this.pnDashboardIdeas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDMIdeas)).BeginInit();
            this.pnIdeas.SuspendLayout();
            this.pnProducts.SuspendLayout();
            this.pnClients.SuspendLayout();
            this.pnViewIdeas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVViewAllIdeas)).BeginInit();
            this.pnViewAllProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVViewAllProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(1764, 4);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 33);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // pnDashboard
            // 
            this.pnDashboard.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnDashboard.Controls.Add(this.btnViewProducts);
            this.pnDashboard.Controls.Add(this.btnViewIdeas);
            this.pnDashboard.Controls.Add(this.pnDashboardIdeas);
            this.pnDashboard.Controls.Add(this.lblRMDashboard);
            this.pnDashboard.Location = new System.Drawing.Point(36, 4);
            this.pnDashboard.Name = "pnDashboard";
            this.pnDashboard.Size = new System.Drawing.Size(1765, 882);
            this.pnDashboard.TabIndex = 2;
            // 
            // btnViewProducts
            // 
            this.btnViewProducts.Location = new System.Drawing.Point(564, 163);
            this.btnViewProducts.Name = "btnViewProducts";
            this.btnViewProducts.Size = new System.Drawing.Size(94, 29);
            this.btnViewProducts.TabIndex = 5;
            this.btnViewProducts.Text = "ViewProducts";
            this.btnViewProducts.UseVisualStyleBackColor = true;
            this.btnViewProducts.Click += new System.EventHandler(this.btnViewProducts_Click);
            // 
            // btnViewIdeas
            // 
            this.btnViewIdeas.Location = new System.Drawing.Point(401, 163);
            this.btnViewIdeas.Name = "btnViewIdeas";
            this.btnViewIdeas.Size = new System.Drawing.Size(94, 29);
            this.btnViewIdeas.TabIndex = 4;
            this.btnViewIdeas.Text = "button1";
            this.btnViewIdeas.UseVisualStyleBackColor = true;
            this.btnViewIdeas.Click += new System.EventHandler(this.btnViewIdeas_Click);
            // 
            // pnDashboardIdeas
            // 
            this.pnDashboardIdeas.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnDashboardIdeas.Controls.Add(this.pbDMIdeas);
            this.pnDashboardIdeas.Controls.Add(this.lblDMIdeasNumbers);
            this.pnDashboardIdeas.Controls.Add(this.lblDMIdeas);
            this.pnDashboardIdeas.Location = new System.Drawing.Point(30, 141);
            this.pnDashboardIdeas.Name = "pnDashboardIdeas";
            this.pnDashboardIdeas.Size = new System.Drawing.Size(343, 212);
            this.pnDashboardIdeas.TabIndex = 1;
            // 
            // pbDMIdeas
            // 
            this.pbDMIdeas.Image = ((System.Drawing.Image)(resources.GetObject("pbDMIdeas.Image")));
            this.pbDMIdeas.Location = new System.Drawing.Point(264, 14);
            this.pbDMIdeas.Name = "pbDMIdeas";
            this.pbDMIdeas.Size = new System.Drawing.Size(55, 56);
            this.pbDMIdeas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDMIdeas.TabIndex = 2;
            this.pbDMIdeas.TabStop = false;
            // 
            // lblDMIdeasNumbers
            // 
            this.lblDMIdeasNumbers.AutoSize = true;
            this.lblDMIdeasNumbers.Font = new System.Drawing.Font("Nirmala UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDMIdeasNumbers.ForeColor = System.Drawing.Color.White;
            this.lblDMIdeasNumbers.Location = new System.Drawing.Point(25, 76);
            this.lblDMIdeasNumbers.Name = "lblDMIdeasNumbers";
            this.lblDMIdeasNumbers.Size = new System.Drawing.Size(109, 50);
            this.lblDMIdeasNumbers.TabIndex = 0;
            this.lblDMIdeasNumbers.Text = "405K";
            // 
            // lblDMIdeas
            // 
            this.lblDMIdeas.AutoSize = true;
            this.lblDMIdeas.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDMIdeas.ForeColor = System.Drawing.Color.White;
            this.lblDMIdeas.Location = new System.Drawing.Point(25, 14);
            this.lblDMIdeas.Name = "lblDMIdeas";
            this.lblDMIdeas.Size = new System.Drawing.Size(85, 38);
            this.lblDMIdeas.TabIndex = 0;
            this.lblDMIdeas.Text = "Ideas";
            // 
            // lblRMDashboard
            // 
            this.lblRMDashboard.AutoSize = true;
            this.lblRMDashboard.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRMDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRMDashboard.Location = new System.Drawing.Point(54, 17);
            this.lblRMDashboard.Name = "lblRMDashboard";
            this.lblRMDashboard.Size = new System.Drawing.Size(1133, 81);
            this.lblRMDashboard.TabIndex = 0;
            this.lblRMDashboard.Text = "RELATIONSHIP MANAGER - DASHBOARD";
            // 
            // pnIdeas
            // 
            this.pnIdeas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnIdeas.Controls.Add(this.lblIdeas);
            this.pnIdeas.Location = new System.Drawing.Point(302, 48);
            this.pnIdeas.Name = "pnIdeas";
            this.pnIdeas.Size = new System.Drawing.Size(1500, 839);
            this.pnIdeas.TabIndex = 2;
            this.pnIdeas.Visible = false;
            // 
            // lblIdeas
            // 
            this.lblIdeas.AutoSize = true;
            this.lblIdeas.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdeas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIdeas.Location = new System.Drawing.Point(54, 17);
            this.lblIdeas.Name = "lblIdeas";
            this.lblIdeas.Size = new System.Drawing.Size(561, 81);
            this.lblIdeas.TabIndex = 0;
            this.lblIdeas.Text = "INVESTMENT IDEAS";
            // 
            // pnProducts
            // 
            this.pnProducts.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnProducts.Controls.Add(this.lblProducts);
            this.pnProducts.Location = new System.Drawing.Point(302, 48);
            this.pnProducts.Name = "pnProducts";
            this.pnProducts.Size = new System.Drawing.Size(1500, 839);
            this.pnProducts.TabIndex = 2;
            this.pnProducts.Visible = false;
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProducts.Location = new System.Drawing.Point(54, 17);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(332, 81);
            this.lblProducts.TabIndex = 0;
            this.lblProducts.Text = "PRODUCTS";
            // 
            // pnClients
            // 
            this.pnClients.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnClients.Controls.Add(this.lblClients);
            this.pnClients.Location = new System.Drawing.Point(302, 48);
            this.pnClients.Name = "pnClients";
            this.pnClients.Size = new System.Drawing.Size(1500, 839);
            this.pnClients.TabIndex = 2;
            this.pnClients.Visible = false;
            // 
            // lblClients
            // 
            this.lblClients.AutoSize = true;
            this.lblClients.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblClients.Location = new System.Drawing.Point(54, 17);
            this.lblClients.Name = "lblClients";
            this.lblClients.Size = new System.Drawing.Size(254, 81);
            this.lblClients.TabIndex = 0;
            this.lblClients.Text = "CLIENTS";
            // 
            // pnViewIdeas
            // 
            this.pnViewIdeas.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnViewIdeas.Controls.Add(this.txtFilterboxIdea);
            this.pnViewIdeas.Controls.Add(this.DSortIdeas);
            this.pnViewIdeas.Controls.Add(this.ASortIdeas);
            this.pnViewIdeas.Controls.Add(this.DGVViewAllIdeas);
            this.pnViewIdeas.Location = new System.Drawing.Point(39, 7);
            this.pnViewIdeas.Name = "pnViewIdeas";
            this.pnViewIdeas.Size = new System.Drawing.Size(1325, 772);
            this.pnViewIdeas.TabIndex = 5;
            // 
            // txtFilterboxIdea
            // 
            this.txtFilterboxIdea.Location = new System.Drawing.Point(127, 357);
            this.txtFilterboxIdea.Name = "txtFilterboxIdea";
            this.txtFilterboxIdea.Size = new System.Drawing.Size(125, 29);
            this.txtFilterboxIdea.TabIndex = 3;
            this.txtFilterboxIdea.TextChanged += new System.EventHandler(this.txtFilterboxIdea_TextChanged);
            // 
            // DSortIdeas
            // 
            this.DSortIdeas.Location = new System.Drawing.Point(107, 194);
            this.DSortIdeas.Name = "DSortIdeas";
            this.DSortIdeas.Size = new System.Drawing.Size(94, 29);
            this.DSortIdeas.TabIndex = 2;
            this.DSortIdeas.Text = "Decend";
            this.DSortIdeas.UseVisualStyleBackColor = true;
            this.DSortIdeas.Click += new System.EventHandler(this.DSortIdeas_Click);
            // 
            // ASortIdeas
            // 
            this.ASortIdeas.Location = new System.Drawing.Point(107, 110);
            this.ASortIdeas.Name = "ASortIdeas";
            this.ASortIdeas.Size = new System.Drawing.Size(94, 29);
            this.ASortIdeas.TabIndex = 1;
            this.ASortIdeas.Text = "Accend";
            this.ASortIdeas.UseVisualStyleBackColor = true;
            this.ASortIdeas.Click += new System.EventHandler(this.ASortIdeas_Click);
            // 
            // DGVViewAllIdeas
            // 
            this.DGVViewAllIdeas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVViewAllIdeas.Location = new System.Drawing.Point(651, 176);
            this.DGVViewAllIdeas.Name = "DGVViewAllIdeas";
            this.DGVViewAllIdeas.RowHeadersWidth = 51;
            this.DGVViewAllIdeas.RowTemplate.Height = 29;
            this.DGVViewAllIdeas.Size = new System.Drawing.Size(608, 482);
            this.DGVViewAllIdeas.TabIndex = 0;
            // 
            // pnViewAllProducts
            // 
            this.pnViewAllProducts.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnViewAllProducts.Controls.Add(this.txtFilterBoxProducts);
            this.pnViewAllProducts.Controls.Add(this.btnDSortProducts);
            this.pnViewAllProducts.Controls.Add(this.btnASortProducts);
            this.pnViewAllProducts.Controls.Add(this.DGVViewAllProducts);
            this.pnViewAllProducts.Location = new System.Drawing.Point(0, 0);
            this.pnViewAllProducts.Name = "pnViewAllProducts";
            this.pnViewAllProducts.Size = new System.Drawing.Size(1325, 772);
            this.pnViewAllProducts.TabIndex = 6;
            // 
            // btnDSortProducts
            // 
            this.btnDSortProducts.Location = new System.Drawing.Point(190, 314);
            this.btnDSortProducts.Name = "btnDSortProducts";
            this.btnDSortProducts.Size = new System.Drawing.Size(94, 29);
            this.btnDSortProducts.TabIndex = 2;
            this.btnDSortProducts.Text = "decend";
            this.btnDSortProducts.UseVisualStyleBackColor = true;
            this.btnDSortProducts.Click += new System.EventHandler(this.btnDSortProducts_Click);
            // 
            // btnASortProducts
            // 
            this.btnASortProducts.Location = new System.Drawing.Point(190, 200);
            this.btnASortProducts.Name = "btnASortProducts";
            this.btnASortProducts.Size = new System.Drawing.Size(94, 29);
            this.btnASortProducts.TabIndex = 1;
            this.btnASortProducts.Text = "Accend";
            this.btnASortProducts.UseVisualStyleBackColor = true;
            this.btnASortProducts.Click += new System.EventHandler(this.btnASortProducts_Click);
            // 
            // DGVViewAllProducts
            // 
            this.DGVViewAllProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVViewAllProducts.Location = new System.Drawing.Point(600, 298);
            this.DGVViewAllProducts.Name = "DGVViewAllProducts";
            this.DGVViewAllProducts.RowHeadersWidth = 51;
            this.DGVViewAllProducts.RowTemplate.Height = 29;
            this.DGVViewAllProducts.Size = new System.Drawing.Size(447, 319);
            this.DGVViewAllProducts.TabIndex = 0;
            // 
            // txtFilterBoxProducts
            // 
            this.txtFilterBoxProducts.Location = new System.Drawing.Point(190, 462);
            this.txtFilterBoxProducts.Name = "txtFilterBoxProducts";
            this.txtFilterBoxProducts.Size = new System.Drawing.Size(125, 29);
            this.txtFilterBoxProducts.TabIndex = 3;
            this.txtFilterBoxProducts.TextChanged += new System.EventHandler(this.txtFilterBoxProducts_TextChanged);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1813, 898);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnViewAllProducts);
            this.Controls.Add(this.pnViewIdeas);
            this.Controls.Add(this.pnDashboard);
            this.Controls.Add(this.pnClients);
            this.Controls.Add(this.pnProducts);
            this.Controls.Add(this.pnIdeas);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            this.pnDashboard.ResumeLayout(false);
            this.pnDashboard.PerformLayout();
            this.pnDashboardIdeas.ResumeLayout(false);
            this.pnDashboardIdeas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDMIdeas)).EndInit();
            this.pnIdeas.ResumeLayout(false);
            this.pnIdeas.PerformLayout();
            this.pnProducts.ResumeLayout(false);
            this.pnProducts.PerformLayout();
            this.pnClients.ResumeLayout(false);
            this.pnClients.PerformLayout();
            this.pnViewIdeas.ResumeLayout(false);
            this.pnViewIdeas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVViewAllIdeas)).EndInit();
            this.pnViewAllProducts.ResumeLayout(false);
            this.pnViewAllProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVViewAllProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnDashboard;
        private System.Windows.Forms.Label lblRMDashboard;
        private System.Windows.Forms.Panel pnIdeas;
        private System.Windows.Forms.Label lblIdeas;
        private System.Windows.Forms.Panel pnProducts;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Panel pnClients;
        private System.Windows.Forms.Label lblClients;
        private System.Windows.Forms.Panel pnDashboardIdeas;
        private System.Windows.Forms.PictureBox pbDMIdeas;
        private System.Windows.Forms.Label lblDMIdeasNumbers;
        private System.Windows.Forms.Label lblDMIdeas;
        private System.Windows.Forms.Button btnViewIdeas;
        private System.Windows.Forms.Panel pnViewIdeas;
        private System.Windows.Forms.DataGridView DGVViewAllIdeas;
        private System.Windows.Forms.Button ASortIdeas;
        private System.Windows.Forms.Button DSortIdeas;
        private System.Windows.Forms.TextBox txtFilterboxIdea;
        private System.Windows.Forms.Panel pnViewAllProducts;
        private System.Windows.Forms.DataGridView DGVViewAllProducts;
        private System.Windows.Forms.Button btnViewProducts;
        private System.Windows.Forms.Button btnDSortProducts;
        private System.Windows.Forms.Button btnASortProducts;
        private System.Windows.Forms.TextBox txtFilterBoxProducts;
    }
}