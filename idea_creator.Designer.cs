﻿namespace Investment_ideas_platform
{
    partial class idea_creator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(idea_creator));
            this.pn_menu_sidebar = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pn_sidebar_top = new System.Windows.Forms.Panel();
            this.lb_idea_creator = new System.Windows.Forms.Label();
            this.pn_top_bar = new System.Windows.Forms.Panel();
            this.lb_idea_dashboard = new System.Windows.Forms.Label();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_ideas = new System.Windows.Forms.Button();
            this.btn_products = new System.Windows.Forms.Button();
            this.pn_menu_sidebar.SuspendLayout();
            this.pn_sidebar_top.SuspendLayout();
            this.pn_top_bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_menu_sidebar
            // 
            this.pn_menu_sidebar.BackColor = System.Drawing.Color.DarkGray;
            this.pn_menu_sidebar.Controls.Add(this.btn_products);
            this.pn_menu_sidebar.Controls.Add(this.btn_ideas);
            this.pn_menu_sidebar.Controls.Add(this.btn_home);
            this.pn_menu_sidebar.Controls.Add(this.btn_logout);
            this.pn_menu_sidebar.Controls.Add(this.btn_exit);
            this.pn_menu_sidebar.Controls.Add(this.pn_sidebar_top);
            this.pn_menu_sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_menu_sidebar.Location = new System.Drawing.Point(0, 0);
            this.pn_menu_sidebar.Name = "pn_menu_sidebar";
            this.pn_menu_sidebar.Size = new System.Drawing.Size(200, 555);
            this.pn_menu_sidebar.TabIndex = 0;
            // 
            // btn_logout
            // 
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_logout.Location = new System.Drawing.Point(94, 514);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(103, 40);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_exit.Location = new System.Drawing.Point(1, 515);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(91, 40);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pn_sidebar_top
            // 
            this.pn_sidebar_top.BackColor = System.Drawing.Color.DimGray;
            this.pn_sidebar_top.Controls.Add(this.lb_idea_creator);
            this.pn_sidebar_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_sidebar_top.Location = new System.Drawing.Point(0, 0);
            this.pn_sidebar_top.Name = "pn_sidebar_top";
            this.pn_sidebar_top.Size = new System.Drawing.Size(200, 63);
            this.pn_sidebar_top.TabIndex = 0;
            // 
            // lb_idea_creator
            // 
            this.lb_idea_creator.AutoSize = true;
            this.lb_idea_creator.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_idea_creator.Location = new System.Drawing.Point(37, 9);
            this.lb_idea_creator.Name = "lb_idea_creator";
            this.lb_idea_creator.Size = new System.Drawing.Size(128, 23);
            this.lb_idea_creator.TabIndex = 0;
            this.lb_idea_creator.Text = "Idea Creator";
            // 
            // pn_top_bar
            // 
            this.pn_top_bar.BackColor = System.Drawing.Color.DarkGray;
            this.pn_top_bar.Controls.Add(this.lb_idea_dashboard);
            this.pn_top_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_top_bar.Location = new System.Drawing.Point(200, 0);
            this.pn_top_bar.Name = "pn_top_bar";
            this.pn_top_bar.Size = new System.Drawing.Size(788, 63);
            this.pn_top_bar.TabIndex = 1;
            // 
            // lb_idea_dashboard
            // 
            this.lb_idea_dashboard.AutoSize = true;
            this.lb_idea_dashboard.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_idea_dashboard.ForeColor = System.Drawing.Color.Black;
            this.lb_idea_dashboard.Location = new System.Drawing.Point(279, 12);
            this.lb_idea_dashboard.Name = "lb_idea_dashboard";
            this.lb_idea_dashboard.Size = new System.Drawing.Size(231, 32);
            this.lb_idea_dashboard.TabIndex = 2;
            this.lb_idea_dashboard.Text = "Main Dashboard";
            // 
            // btn_home
            // 
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(7, 127);
            this.btn_home.Name = "btn_home";
            this.btn_home.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btn_home.Size = new System.Drawing.Size(185, 70);
            this.btn_home.TabIndex = 3;
            this.btn_home.Text = "Main Dashboard";
            this.btn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_home.UseVisualStyleBackColor = true;
            // 
            // btn_ideas
            // 
            this.btn_ideas.FlatAppearance.BorderSize = 0;
            this.btn_ideas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ideas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ideas.Image = ((System.Drawing.Image)(resources.GetObject("btn_ideas.Image")));
            this.btn_ideas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ideas.Location = new System.Drawing.Point(7, 215);
            this.btn_ideas.Name = "btn_ideas";
            this.btn_ideas.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btn_ideas.Size = new System.Drawing.Size(185, 70);
            this.btn_ideas.TabIndex = 4;
            this.btn_ideas.Text = "Ideas";
            this.btn_ideas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ideas.UseVisualStyleBackColor = true;
            // 
            // btn_products
            // 
            this.btn_products.FlatAppearance.BorderSize = 0;
            this.btn_products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_products.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_products.Image = ((System.Drawing.Image)(resources.GetObject("btn_products.Image")));
            this.btn_products.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_products.Location = new System.Drawing.Point(7, 300);
            this.btn_products.Name = "btn_products";
            this.btn_products.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btn_products.Size = new System.Drawing.Size(185, 70);
            this.btn_products.TabIndex = 5;
            this.btn_products.Text = "Products";
            this.btn_products.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_products.UseVisualStyleBackColor = true;
            // 
            // idea_creator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 555);
            this.Controls.Add(this.pn_top_bar);
            this.Controls.Add(this.pn_menu_sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "idea_creator";
            this.Text = "idea_creator";
            this.pn_menu_sidebar.ResumeLayout(false);
            this.pn_sidebar_top.ResumeLayout(false);
            this.pn_sidebar_top.PerformLayout();
            this.pn_top_bar.ResumeLayout(false);
            this.pn_top_bar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_menu_sidebar;
        private System.Windows.Forms.Panel pn_sidebar_top;
        private System.Windows.Forms.Label lb_idea_creator;
        private System.Windows.Forms.Panel pn_top_bar;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lb_idea_dashboard;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_ideas;
        private System.Windows.Forms.Button btn_products;
    }
}