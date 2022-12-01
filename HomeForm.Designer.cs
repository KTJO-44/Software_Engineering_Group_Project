
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
            this.pnUserDetails = new System.Windows.Forms.Panel();
            this.lblUserAccTypeDescription = new System.Windows.Forms.Label();
            this.lblUserAccountType = new System.Windows.Forms.Label();
            this.pbProfilePicture = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnIdeas = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.pnNavMenu.SuspendLayout();
            this.pnUserDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).BeginInit();
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
            this.btnClients.Text = "Dashboard";
            this.btnClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClients.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1813, 898);
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
    }
}