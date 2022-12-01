
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
            this.pnNavMenu = new System.Windows.Forms.Panel();
            this.pnNavBtnHighlighter = new System.Windows.Forms.Panel();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnIdeas = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnUserDetails = new System.Windows.Forms.Panel();
            this.lblUserAccTypeDescription = new System.Windows.Forms.Label();
            this.lblUserAccountType = new System.Windows.Forms.Label();
            this.pbProfilePicture = new System.Windows.Forms.PictureBox();
            this.pnDashboard = new System.Windows.Forms.Panel();
            this.lblRMDashboard = new System.Windows.Forms.Label();
            this.pnIdeas = new System.Windows.Forms.Panel();
            this.lblIdeas = new System.Windows.Forms.Label();
            this.pnProducts = new System.Windows.Forms.Panel();
            this.lblProducts = new System.Windows.Forms.Label();
            this.pnClients = new System.Windows.Forms.Panel();
            this.lblClients = new System.Windows.Forms.Label();
            this.pnNavMenu.SuspendLayout();
            this.pnUserDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).BeginInit();
            this.pnDashboard.SuspendLayout();
            this.pnIdeas.SuspendLayout();
            this.pnProducts.SuspendLayout();
            this.pnClients.SuspendLayout();
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
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // pnNavMenu
            // 
            this.pnNavMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnNavMenu.Controls.Add(this.pnNavBtnHighlighter);
            this.pnNavMenu.Controls.Add(this.btnClients);
            this.pnNavMenu.Controls.Add(this.btnProducts);
            this.pnNavMenu.Controls.Add(this.btnIdeas);
            this.pnNavMenu.Controls.Add(this.btnDashboard);
            this.pnNavMenu.Controls.Add(this.pnUserDetails);
            this.pnNavMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnNavMenu.Location = new System.Drawing.Point(0, 0);
            this.pnNavMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnNavMenu.Name = "pnNavMenu";
            this.pnNavMenu.Size = new System.Drawing.Size(281, 898);
            this.pnNavMenu.TabIndex = 1;
            // 
            // pnNavBtnHighlighter
            // 
            this.pnNavBtnHighlighter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnNavBtnHighlighter.Location = new System.Drawing.Point(0, 257);
            this.pnNavBtnHighlighter.Name = "pnNavBtnHighlighter";
            this.pnNavBtnHighlighter.Size = new System.Drawing.Size(3, 133);
            this.pnNavBtnHighlighter.TabIndex = 2;
            // 
            // btnClients
            // 
            this.btnClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClients.FlatAppearance.BorderSize = 0;
            this.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClients.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClients.Image = ((System.Drawing.Image)(resources.GetObject("btnClients.Image")));
            this.btnClients.Location = new System.Drawing.Point(0, 370);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(281, 56);
            this.btnClients.TabIndex = 1;
            this.btnClients.Text = "Clients";
            this.btnClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            this.btnClients.Leave += new System.EventHandler(this.btnClients_Leave);
            // 
            // btnProducts
            // 
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnProducts.Image")));
            this.btnProducts.Location = new System.Drawing.Point(0, 314);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(281, 56);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Products";
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            this.btnProducts.Leave += new System.EventHandler(this.btnProducts_Leave);
            // 
            // btnIdeas
            // 
            this.btnIdeas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIdeas.FlatAppearance.BorderSize = 0;
            this.btnIdeas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdeas.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIdeas.Image = ((System.Drawing.Image)(resources.GetObject("btnIdeas.Image")));
            this.btnIdeas.Location = new System.Drawing.Point(0, 258);
            this.btnIdeas.Name = "btnIdeas";
            this.btnIdeas.Size = new System.Drawing.Size(281, 56);
            this.btnIdeas.TabIndex = 1;
            this.btnIdeas.Text = "Ideas";
            this.btnIdeas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIdeas.UseVisualStyleBackColor = true;
            this.btnIdeas.Click += new System.EventHandler(this.btnIdeas_Click);
            this.btnIdeas.Leave += new System.EventHandler(this.btnIdeas_Leave);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.Location = new System.Drawing.Point(0, 202);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(281, 56);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnDashboard.Leave += new System.EventHandler(this.btnDashboard_Leave);
            // 
            // pnUserDetails
            // 
            this.pnUserDetails.Controls.Add(this.lblUserAccTypeDescription);
            this.pnUserDetails.Controls.Add(this.lblUserAccountType);
            this.pnUserDetails.Controls.Add(this.pbProfilePicture);
            this.pnUserDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnUserDetails.Location = new System.Drawing.Point(0, 0);
            this.pnUserDetails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnUserDetails.Name = "pnUserDetails";
            this.pnUserDetails.Size = new System.Drawing.Size(281, 202);
            this.pnUserDetails.TabIndex = 0;
            // 
            // lblUserAccTypeDescription
            // 
            this.lblUserAccTypeDescription.AutoSize = true;
            this.lblUserAccTypeDescription.Font = new System.Drawing.Font("Nirmala UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblUserAccTypeDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.lblUserAccTypeDescription.Location = new System.Drawing.Point(61, 155);
            this.lblUserAccTypeDescription.Name = "lblUserAccTypeDescription";
            this.lblUserAccTypeDescription.Size = new System.Drawing.Size(153, 17);
            this.lblUserAccTypeDescription.TabIndex = 2;
            this.lblUserAccTypeDescription.Text = "(Relationship Manager)";
            // 
            // lblUserAccountType
            // 
            this.lblUserAccountType.AutoSize = true;
            this.lblUserAccountType.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserAccountType.Image = ((System.Drawing.Image)(resources.GetObject("lblUserAccountType.Image")));
            this.lblUserAccountType.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUserAccountType.Location = new System.Drawing.Point(86, 122);
            this.lblUserAccountType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserAccountType.Name = "lblUserAccountType";
            this.lblUserAccountType.Size = new System.Drawing.Size(102, 23);
            this.lblUserAccountType.TabIndex = 1;
            this.lblUserAccountType.Text = "RM             ";
            this.lblUserAccountType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbProfilePicture
            // 
            this.pbProfilePicture.Image = ((System.Drawing.Image)(resources.GetObject("pbProfilePicture.Image")));
            this.pbProfilePicture.Location = new System.Drawing.Point(98, 31);
            this.pbProfilePicture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbProfilePicture.Name = "pbProfilePicture";
            this.pbProfilePicture.Size = new System.Drawing.Size(81, 88);
            this.pbProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProfilePicture.TabIndex = 0;
            this.pbProfilePicture.TabStop = false;
            // 
            // pnDashboard
            // 
            this.pnDashboard.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnDashboard.Controls.Add(this.lblRMDashboard);
            this.pnDashboard.Location = new System.Drawing.Point(301, 47);
            this.pnDashboard.Name = "pnDashboard";
            this.pnDashboard.Size = new System.Drawing.Size(1500, 839);
            this.pnDashboard.TabIndex = 2;
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
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1813, 898);
            this.Controls.Add(this.pnClients);
            this.Controls.Add(this.pnProducts);
            this.Controls.Add(this.pnIdeas);
            this.Controls.Add(this.pnDashboard);
            this.Controls.Add(this.pnNavMenu);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            this.pnNavMenu.ResumeLayout(false);
            this.pnUserDetails.ResumeLayout(false);
            this.pnUserDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).EndInit();
            this.pnDashboard.ResumeLayout(false);
            this.pnDashboard.PerformLayout();
            this.pnIdeas.ResumeLayout(false);
            this.pnIdeas.PerformLayout();
            this.pnProducts.ResumeLayout(false);
            this.pnProducts.PerformLayout();
            this.pnClients.ResumeLayout(false);
            this.pnClients.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnNavMenu;
        private System.Windows.Forms.Panel pnUserDetails;
        private System.Windows.Forms.Label lblUserAccountType;
        private System.Windows.Forms.PictureBox pbProfilePicture;
        private System.Windows.Forms.Label lblUserAccTypeDescription;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnIdeas;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnNavBtnHighlighter;
        private System.Windows.Forms.Panel pnDashboard;
        private System.Windows.Forms.Label lblRMDashboard;
        private System.Windows.Forms.Panel pnIdeas;
        private System.Windows.Forms.Label lblIdeas;
        private System.Windows.Forms.Panel pnProducts;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Panel pnClients;
        private System.Windows.Forms.Label lblClients;
    }
}