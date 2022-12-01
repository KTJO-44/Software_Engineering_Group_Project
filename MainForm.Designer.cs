
namespace Investment_ideas_platform
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtbx_login_uname = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txb_login_pwd = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLoginCancel = new System.Windows.Forms.Button();
            this.lab_login_error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 411);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(335, 30);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsername.Location = new System.Drawing.Point(258, 185);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(77, 18);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // txtbx_login_uname
            // 
            this.txtbx_login_uname.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtbx_login_uname.ForeColor = System.Drawing.Color.Navy;
            this.txtbx_login_uname.Location = new System.Drawing.Point(260, 204);
            this.txtbx_login_uname.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_login_uname.Name = "txtbx_login_uname";
            this.txtbx_login_uname.Size = new System.Drawing.Size(277, 32);
            this.txtbx_login_uname.TabIndex = 0;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPassword.Location = new System.Drawing.Point(258, 252);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(75, 18);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // txb_login_pwd
            // 
            this.txb_login_pwd.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txb_login_pwd.ForeColor = System.Drawing.Color.Navy;
            this.txb_login_pwd.Location = new System.Drawing.Point(259, 272);
            this.txb_login_pwd.Margin = new System.Windows.Forms.Padding(4);
            this.txb_login_pwd.Name = "txb_login_pwd";
            this.txb_login_pwd.PasswordChar = '#';
            this.txb_login_pwd.Size = new System.Drawing.Size(277, 32);
            this.txb_login_pwd.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(377, 315);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(108, 33);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLoginCancel
            // 
            this.btnLoginCancel.Location = new System.Drawing.Point(260, 313);
            this.btnLoginCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoginCancel.Name = "btnLoginCancel";
            this.btnLoginCancel.Size = new System.Drawing.Size(108, 33);
            this.btnLoginCancel.TabIndex = 3;
            this.btnLoginCancel.Text = "Cancel";
            this.btnLoginCancel.UseVisualStyleBackColor = true;
            this.btnLoginCancel.Click += new System.EventHandler(this.btnLoginCancel_Click);
            // 
            // lab_login_error
            // 
            this.lab_login_error.AutoSize = true;
            this.lab_login_error.BackColor = System.Drawing.Color.Transparent;
            this.lab_login_error.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_login_error.ForeColor = System.Drawing.Color.Red;
            this.lab_login_error.Location = new System.Drawing.Point(267, 357);
            this.lab_login_error.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_login_error.Name = "lab_login_error";
            this.lab_login_error.Size = new System.Drawing.Size(0, 18);
            this.lab_login_error.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(545, 411);
            this.Controls.Add(this.btnLoginCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txb_login_pwd);
            this.Controls.Add(this.txtbx_login_uname);
            this.Controls.Add(this.lab_login_error);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtbx_login_uname;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txb_login_pwd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLoginCancel;
        private System.Windows.Forms.Label lab_login_error;
    }
}

