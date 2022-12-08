namespace Investment_ideas_platform
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
            this.btn_products = new System.Windows.Forms.Button();
            this.btn_ideas = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pn_sidebar_top = new System.Windows.Forms.Panel();
            this.lb_idea_creator = new System.Windows.Forms.Label();
            this.pn_top_bar = new System.Windows.Forms.Panel();
            this.lb_idea_header = new System.Windows.Forms.Label();
            this.pn_main_dashboard = new System.Windows.Forms.Panel();
            this.pn_ideas = new System.Windows.Forms.Panel();
            this.btn_add_idea = new System.Windows.Forms.Button();
            this.txtb_idea_description = new System.Windows.Forms.TextBox();
            this.lb_description = new System.Windows.Forms.Label();
            this.lb_risk_rating = new System.Windows.Forms.Label();
            this.cb_risk_rating = new System.Windows.Forms.ComboBox();
            this.dtp_expiry_date = new System.Windows.Forms.DateTimePicker();
            this.lb_expiry_date = new System.Windows.Forms.Label();
            this.lb_abstract = new System.Windows.Forms.Label();
            this.txtb_abstract = new System.Windows.Forms.TextBox();
            this.lb_idea_title = new System.Windows.Forms.Label();
            this.txtb_idea_title = new System.Windows.Forms.TextBox();
            this.lb_ideas_header = new System.Windows.Forms.Label();
            this.pnl_products = new System.Windows.Forms.Panel();
            this.btn_add_product = new System.Windows.Forms.Button();
            this.lb_product_description = new System.Windows.Forms.Label();
            this.txtb_product_description = new System.Windows.Forms.TextBox();
            this.lb_company_name = new System.Windows.Forms.Label();
            this.txtb_company_name = new System.Windows.Forms.TextBox();
            this.lb_product_type = new System.Windows.Forms.Label();
            this.txtb_product_type = new System.Windows.Forms.TextBox();
            this.lb_product_name = new System.Windows.Forms.Label();
            this.txtb_ = new System.Windows.Forms.TextBox();
            this.lb_products = new System.Windows.Forms.Label();
            this.dgv_ideas = new System.Windows.Forms.DataGridView();
            this.dgv_products = new System.Windows.Forms.DataGridView();
            this.pn_menu_sidebar.SuspendLayout();
            this.pn_sidebar_top.SuspendLayout();
            this.pn_main_dashboard.SuspendLayout();
            this.pn_ideas.SuspendLayout();
            this.pnl_products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ideas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).BeginInit();
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
            this.btn_products.Click += new System.EventHandler(this.btn_products_Click);
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
            this.btn_ideas.Click += new System.EventHandler(this.btn_ideas_Click);
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
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
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
            this.pn_top_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_top_bar.Location = new System.Drawing.Point(200, 0);
            this.pn_top_bar.Name = "pn_top_bar";
            this.pn_top_bar.Size = new System.Drawing.Size(788, 63);
            this.pn_top_bar.TabIndex = 1;
            // 
            // lb_idea_header
            // 
            this.lb_idea_header.AutoSize = true;
            this.lb_idea_header.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_idea_header.ForeColor = System.Drawing.Color.Black;
            this.lb_idea_header.Location = new System.Drawing.Point(279, 14);
            this.lb_idea_header.Name = "lb_idea_header";
            this.lb_idea_header.Size = new System.Drawing.Size(231, 32);
            this.lb_idea_header.TabIndex = 2;
            this.lb_idea_header.Text = "Main Dashboard";
            // 
            // pn_main_dashboard
            // 
            this.pn_main_dashboard.BackColor = System.Drawing.Color.DimGray;
            this.pn_main_dashboard.Controls.Add(this.dgv_products);
            this.pn_main_dashboard.Controls.Add(this.dgv_ideas);
            this.pn_main_dashboard.Controls.Add(this.lb_idea_header);
            this.pn_main_dashboard.Location = new System.Drawing.Point(200, 62);
            this.pn_main_dashboard.Name = "pn_main_dashboard";
            this.pn_main_dashboard.Size = new System.Drawing.Size(788, 493);
            this.pn_main_dashboard.TabIndex = 2;
            // 
            // pn_ideas
            // 
            this.pn_ideas.BackColor = System.Drawing.Color.DimGray;
            this.pn_ideas.Controls.Add(this.btn_add_idea);
            this.pn_ideas.Controls.Add(this.txtb_idea_description);
            this.pn_ideas.Controls.Add(this.lb_description);
            this.pn_ideas.Controls.Add(this.lb_risk_rating);
            this.pn_ideas.Controls.Add(this.cb_risk_rating);
            this.pn_ideas.Controls.Add(this.dtp_expiry_date);
            this.pn_ideas.Controls.Add(this.lb_expiry_date);
            this.pn_ideas.Controls.Add(this.lb_abstract);
            this.pn_ideas.Controls.Add(this.txtb_abstract);
            this.pn_ideas.Controls.Add(this.lb_idea_title);
            this.pn_ideas.Controls.Add(this.txtb_idea_title);
            this.pn_ideas.Controls.Add(this.lb_ideas_header);
            this.pn_ideas.Location = new System.Drawing.Point(201, 62);
            this.pn_ideas.Name = "pn_ideas";
            this.pn_ideas.Size = new System.Drawing.Size(785, 492);
            this.pn_ideas.TabIndex = 3;
            // 
            // btn_add_idea
            // 
            this.btn_add_idea.BackColor = System.Drawing.Color.Transparent;
            this.btn_add_idea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_add_idea.FlatAppearance.BorderSize = 0;
            this.btn_add_idea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_idea.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_add_idea.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_idea.Image")));
            this.btn_add_idea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_idea.Location = new System.Drawing.Point(629, 365);
            this.btn_add_idea.Name = "btn_add_idea";
            this.btn_add_idea.Size = new System.Drawing.Size(123, 71);
            this.btn_add_idea.TabIndex = 15;
            this.btn_add_idea.Text = "Add Idea";
            this.btn_add_idea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_add_idea.UseVisualStyleBackColor = true;
            // 
            // txtb_idea_description
            // 
            this.txtb_idea_description.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_idea_description.Location = new System.Drawing.Point(55, 320);
            this.txtb_idea_description.MaxLength = 40000;
            this.txtb_idea_description.Multiline = true;
            this.txtb_idea_description.Name = "txtb_idea_description";
            this.txtb_idea_description.PlaceholderText = "Description of the Idea";
            this.txtb_idea_description.ReadOnly = true;
            this.txtb_idea_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtb_idea_description.Size = new System.Drawing.Size(332, 116);
            this.txtb_idea_description.TabIndex = 14;
            // 
            // lb_description
            // 
            this.lb_description.AutoSize = true;
            this.lb_description.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_description.Location = new System.Drawing.Point(55, 296);
            this.lb_description.Name = "lb_description";
            this.lb_description.Size = new System.Drawing.Size(137, 21);
            this.lb_description.TabIndex = 13;
            this.lb_description.Text = "Idea description";
            // 
            // lb_risk_rating
            // 
            this.lb_risk_rating.AutoSize = true;
            this.lb_risk_rating.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_risk_rating.Location = new System.Drawing.Point(55, 228);
            this.lb_risk_rating.Name = "lb_risk_rating";
            this.lb_risk_rating.Size = new System.Drawing.Size(93, 21);
            this.lb_risk_rating.TabIndex = 11;
            this.lb_risk_rating.Text = "Risk Rating";
            // 
            // cb_risk_rating
            // 
            this.cb_risk_rating.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_risk_rating.FormattingEnabled = true;
            this.cb_risk_rating.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cb_risk_rating.Location = new System.Drawing.Point(55, 252);
            this.cb_risk_rating.Name = "cb_risk_rating";
            this.cb_risk_rating.Size = new System.Drawing.Size(121, 29);
            this.cb_risk_rating.TabIndex = 10;
            // 
            // dtp_expiry_date
            // 
            this.dtp_expiry_date.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_expiry_date.Location = new System.Drawing.Point(55, 185);
            this.dtp_expiry_date.Name = "dtp_expiry_date";
            this.dtp_expiry_date.Size = new System.Drawing.Size(204, 27);
            this.dtp_expiry_date.TabIndex = 9;
            // 
            // lb_expiry_date
            // 
            this.lb_expiry_date.AutoSize = true;
            this.lb_expiry_date.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_expiry_date.Location = new System.Drawing.Point(55, 161);
            this.lb_expiry_date.Name = "lb_expiry_date";
            this.lb_expiry_date.Size = new System.Drawing.Size(98, 21);
            this.lb_expiry_date.TabIndex = 8;
            this.lb_expiry_date.Text = "Expiry Date";
            // 
            // lb_abstract
            // 
            this.lb_abstract.AutoSize = true;
            this.lb_abstract.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_abstract.Location = new System.Drawing.Point(55, 101);
            this.lb_abstract.Name = "lb_abstract";
            this.lb_abstract.Size = new System.Drawing.Size(80, 21);
            this.lb_abstract.TabIndex = 6;
            this.lb_abstract.Text = "Abstract";
            // 
            // txtb_abstract
            // 
            this.txtb_abstract.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_abstract.Location = new System.Drawing.Point(55, 125);
            this.txtb_abstract.Name = "txtb_abstract";
            this.txtb_abstract.Size = new System.Drawing.Size(204, 27);
            this.txtb_abstract.TabIndex = 5;
            // 
            // lb_idea_title
            // 
            this.lb_idea_title.AutoSize = true;
            this.lb_idea_title.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_idea_title.Location = new System.Drawing.Point(55, 43);
            this.lb_idea_title.Name = "lb_idea_title";
            this.lb_idea_title.Size = new System.Drawing.Size(99, 21);
            this.lb_idea_title.TabIndex = 4;
            this.lb_idea_title.Text = "Name Idea";
            // 
            // txtb_idea_title
            // 
            this.txtb_idea_title.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_idea_title.Location = new System.Drawing.Point(55, 67);
            this.txtb_idea_title.Name = "txtb_idea_title";
            this.txtb_idea_title.Size = new System.Drawing.Size(204, 27);
            this.txtb_idea_title.TabIndex = 3;
            // 
            // lb_ideas_header
            // 
            this.lb_ideas_header.AutoSize = true;
            this.lb_ideas_header.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_ideas_header.ForeColor = System.Drawing.Color.Black;
            this.lb_ideas_header.Location = new System.Drawing.Point(355, 7);
            this.lb_ideas_header.Name = "lb_ideas_header";
            this.lb_ideas_header.Size = new System.Drawing.Size(95, 32);
            this.lb_ideas_header.TabIndex = 2;
            this.lb_ideas_header.Text = "Ideas ";
            // 
            // pnl_products
            // 
            this.pnl_products.BackColor = System.Drawing.Color.DimGray;
            this.pnl_products.Controls.Add(this.btn_add_product);
            this.pnl_products.Controls.Add(this.lb_product_description);
            this.pnl_products.Controls.Add(this.txtb_product_description);
            this.pnl_products.Controls.Add(this.lb_company_name);
            this.pnl_products.Controls.Add(this.txtb_company_name);
            this.pnl_products.Controls.Add(this.lb_product_type);
            this.pnl_products.Controls.Add(this.txtb_product_type);
            this.pnl_products.Controls.Add(this.lb_product_name);
            this.pnl_products.Controls.Add(this.txtb_);
            this.pnl_products.Controls.Add(this.lb_products);
            this.pnl_products.Location = new System.Drawing.Point(201, 62);
            this.pnl_products.Name = "pnl_products";
            this.pnl_products.Size = new System.Drawing.Size(785, 492);
            this.pnl_products.TabIndex = 4;
            // 
            // btn_add_product
            // 
            this.btn_add_product.BackColor = System.Drawing.Color.Transparent;
            this.btn_add_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_add_product.FlatAppearance.BorderSize = 0;
            this.btn_add_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_product.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_add_product.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_product.Image")));
            this.btn_add_product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_product.Location = new System.Drawing.Point(606, 383);
            this.btn_add_product.Name = "btn_add_product";
            this.btn_add_product.Size = new System.Drawing.Size(146, 71);
            this.btn_add_product.TabIndex = 16;
            this.btn_add_product.Text = "Add Product";
            this.btn_add_product.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_add_product.UseVisualStyleBackColor = true;
            // 
            // lb_product_description
            // 
            this.lb_product_description.AutoSize = true;
            this.lb_product_description.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_product_description.Location = new System.Drawing.Point(52, 320);
            this.lb_product_description.Name = "lb_product_description";
            this.lb_product_description.Size = new System.Drawing.Size(163, 21);
            this.lb_product_description.TabIndex = 10;
            this.lb_product_description.Text = "Product Description";
            // 
            // txtb_product_description
            // 
            this.txtb_product_description.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_product_description.Location = new System.Drawing.Point(53, 344);
            this.txtb_product_description.Multiline = true;
            this.txtb_product_description.Name = "txtb_product_description";
            this.txtb_product_description.PlaceholderText = "Desciption of the product";
            this.txtb_product_description.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtb_product_description.Size = new System.Drawing.Size(351, 110);
            this.txtb_product_description.TabIndex = 9;
            // 
            // lb_company_name
            // 
            this.lb_company_name.AutoSize = true;
            this.lb_company_name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_company_name.Location = new System.Drawing.Point(52, 235);
            this.lb_company_name.Name = "lb_company_name";
            this.lb_company_name.Size = new System.Drawing.Size(140, 21);
            this.lb_company_name.TabIndex = 8;
            this.lb_company_name.Text = "Company Name";
            // 
            // txtb_company_name
            // 
            this.txtb_company_name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_company_name.Location = new System.Drawing.Point(53, 259);
            this.txtb_company_name.Name = "txtb_company_name";
            this.txtb_company_name.Size = new System.Drawing.Size(195, 27);
            this.txtb_company_name.TabIndex = 7;
            // 
            // lb_product_type
            // 
            this.lb_product_type.AutoSize = true;
            this.lb_product_type.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_product_type.Location = new System.Drawing.Point(52, 150);
            this.lb_product_type.Name = "lb_product_type";
            this.lb_product_type.Size = new System.Drawing.Size(113, 21);
            this.lb_product_type.TabIndex = 6;
            this.lb_product_type.Text = "Product Type";
            // 
            // txtb_product_type
            // 
            this.txtb_product_type.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_product_type.Location = new System.Drawing.Point(53, 174);
            this.txtb_product_type.Name = "txtb_product_type";
            this.txtb_product_type.Size = new System.Drawing.Size(195, 27);
            this.txtb_product_type.TabIndex = 5;
            // 
            // lb_product_name
            // 
            this.lb_product_name.AutoSize = true;
            this.lb_product_name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_product_name.Location = new System.Drawing.Point(52, 64);
            this.lb_product_name.Name = "lb_product_name";
            this.lb_product_name.Size = new System.Drawing.Size(124, 21);
            this.lb_product_name.TabIndex = 4;
            this.lb_product_name.Text = "Product Name";
            // 
            // txtb_
            // 
            this.txtb_.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_.Location = new System.Drawing.Point(53, 92);
            this.txtb_.Name = "txtb_";
            this.txtb_.Size = new System.Drawing.Size(195, 27);
            this.txtb_.TabIndex = 3;
            // 
            // lb_products
            // 
            this.lb_products.AutoSize = true;
            this.lb_products.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_products.ForeColor = System.Drawing.Color.Black;
            this.lb_products.Location = new System.Drawing.Point(330, 14);
            this.lb_products.Name = "lb_products";
            this.lb_products.Size = new System.Drawing.Size(126, 32);
            this.lb_products.TabIndex = 2;
            this.lb_products.Text = "Products";
            // 
            // dgv_ideas
            // 
            this.dgv_ideas.AllowUserToAddRows = false;
            this.dgv_ideas.AllowUserToDeleteRows = false;
            this.dgv_ideas.AllowUserToOrderColumns = true;
            this.dgv_ideas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ideas.Location = new System.Drawing.Point(53, 83);
            this.dgv_ideas.Name = "dgv_ideas";
            this.dgv_ideas.ReadOnly = true;
            this.dgv_ideas.RowTemplate.Height = 25;
            this.dgv_ideas.Size = new System.Drawing.Size(381, 163);
            this.dgv_ideas.TabIndex = 3;
            // 
            // dgv_products
            // 
            this.dgv_products.AllowUserToAddRows = false;
            this.dgv_products.AllowUserToDeleteRows = false;
            this.dgv_products.AllowUserToOrderColumns = true;
            this.dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_products.Location = new System.Drawing.Point(53, 259);
            this.dgv_products.Name = "dgv_products";
            this.dgv_products.ReadOnly = true;
            this.dgv_products.RowTemplate.Height = 25;
            this.dgv_products.Size = new System.Drawing.Size(381, 177);
            this.dgv_products.TabIndex = 4;
            // 
            // idea_creator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(988, 555);
            this.Controls.Add(this.pn_main_dashboard);
            this.Controls.Add(this.pn_ideas);
            this.Controls.Add(this.pnl_products);
            this.Controls.Add(this.pn_top_bar);
            this.Controls.Add(this.pn_menu_sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "idea_creator";
            this.Text = "idea_creator";
            this.pn_menu_sidebar.ResumeLayout(false);
            this.pn_sidebar_top.ResumeLayout(false);
            this.pn_sidebar_top.PerformLayout();
            this.pn_main_dashboard.ResumeLayout(false);
            this.pn_main_dashboard.PerformLayout();
            this.pn_ideas.ResumeLayout(false);
            this.pn_ideas.PerformLayout();
            this.pnl_products.ResumeLayout(false);
            this.pnl_products.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ideas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_menu_sidebar;
        private System.Windows.Forms.Panel pn_sidebar_top;
        private System.Windows.Forms.Label lb_idea_creator;
        private System.Windows.Forms.Panel pn_top_bar;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lb_idea_header;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_ideas;
        private System.Windows.Forms.Button btn_products;
        private System.Windows.Forms.Panel pn_main_dashboard;
        private System.Windows.Forms.Panel pn_ideas;
        private System.Windows.Forms.Label lb_ideas_header;
        private System.Windows.Forms.Panel pnl_products;
        private System.Windows.Forms.Label lb_products;
        private System.Windows.Forms.TextBox txtb_idea_title;
        private System.Windows.Forms.Label lb_risk_rating;
        private System.Windows.Forms.ComboBox cb_risk_rating;
        private System.Windows.Forms.DateTimePicker dtp_expiry_date;
        private System.Windows.Forms.Label lb_expiry_date;
        private System.Windows.Forms.Label lb_abstract;
        private System.Windows.Forms.TextBox txtb_abstract;
        private System.Windows.Forms.Label lb_idea_title;
        private System.Windows.Forms.TextBox txtb_idea_description;
        private System.Windows.Forms.Label lb_description;
        private System.Windows.Forms.Button btn_add_idea;
        private System.Windows.Forms.TextBox txtb_;
        private System.Windows.Forms.Label lb_product_description;
        private System.Windows.Forms.TextBox txtb_product_description;
        private System.Windows.Forms.Label lb_company_name;
        private System.Windows.Forms.TextBox txtb_company_name;
        private System.Windows.Forms.Label lb_product_type;
        private System.Windows.Forms.TextBox txtb_product_type;
        private System.Windows.Forms.Label lb_product_name;
        private System.Windows.Forms.Button btn_add_product;
        private System.Windows.Forms.DataGridView dgv_products;
        private System.Windows.Forms.DataGridView dgv_ideas;
    }
}