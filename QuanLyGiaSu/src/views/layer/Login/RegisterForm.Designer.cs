namespace QuanLyGiaSu.src.app.views.Login
{
    partial class RegisterForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbExceptionUserName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbConfirmPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbUserType = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.lbExceptionPassword = new System.Windows.Forms.Label();
            this.tmCheckInfoLogin = new System.Windows.Forms.Timer(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(618, 252);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(60, 21);
            this.comboBox1.TabIndex = 74;
            // 
            // lbExceptionUserName
            // 
            this.lbExceptionUserName.AutoSize = true;
            this.lbExceptionUserName.ForeColor = System.Drawing.Color.Red;
            this.lbExceptionUserName.Location = new System.Drawing.Point(371, 278);
            this.lbExceptionUserName.Name = "lbExceptionUserName";
            this.lbExceptionUserName.Size = new System.Drawing.Size(220, 13);
            this.lbExceptionUserName.TabIndex = 73;
            this.lbExceptionUserName.Text = "Tên đăng nhập hoặc email đã được sử dụng";
            this.lbExceptionUserName.Visible = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(324, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(350, 3);
            this.label8.TabIndex = 72;
            // 
            // tbConfirmPass
            // 
            this.tbConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfirmPass.ForeColor = System.Drawing.Color.Gray;
            this.tbConfirmPass.Location = new System.Drawing.Point(374, 366);
            this.tbConfirmPass.Margin = new System.Windows.Forms.Padding(2);
            this.tbConfirmPass.Name = "tbConfirmPass";
            this.tbConfirmPass.Size = new System.Drawing.Size(303, 16);
            this.tbConfirmPass.TabIndex = 65;
            this.tbConfirmPass.Text = "Password";
            this.tbConfirmPass.UseSystemPasswordChar = true;
            this.tbConfirmPass.Click += new System.EventHandler(this.tbConfirmPass_Click);
            this.tbConfirmPass.Leave += new System.EventHandler(this.tbConfirmPass_Leave);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(324, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(350, 3);
            this.label4.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(328, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 3);
            this.label3.TabIndex = 68;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Blue;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(374, 426);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(268, 34);
            this.btnRegister.TabIndex = 67;
            this.btnRegister.Text = "Tiếp tục";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.Gray;
            this.tbPassword.Location = new System.Drawing.Point(374, 314);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(303, 16);
            this.tbPassword.TabIndex = 64;
            this.tbPassword.Text = "Password";
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.Click += new System.EventHandler(this.tbPassword_Click);
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // lbUserType
            // 
            this.lbUserType.AutoSize = true;
            this.lbUserType.BackColor = System.Drawing.Color.White;
            this.lbUserType.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbUserType.Location = new System.Drawing.Point(430, 132);
            this.lbUserType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserType.Name = "lbUserType";
            this.lbUserType.Size = new System.Drawing.Size(160, 26);
            this.lbUserType.TabIndex = 63;
            this.lbUserType.Text = "ĐĂNG KÝ GIA SƯ";
            // 
            // tbEmail
            // 
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.Gray;
            this.tbEmail.Location = new System.Drawing.Point(374, 206);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(303, 16);
            this.tbEmail.TabIndex = 62;
            this.tbEmail.Text = "Email";
            this.tbEmail.Click += new System.EventHandler(this.tbEmail_Click);
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(324, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(350, 3);
            this.label5.TabIndex = 69;
            // 
            // tbUser
            // 
            this.tbUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUser.ForeColor = System.Drawing.Color.Gray;
            this.tbUser.Location = new System.Drawing.Point(374, 257);
            this.tbUser.Margin = new System.Windows.Forms.Padding(2);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(239, 16);
            this.tbUser.TabIndex = 63;
            this.tbUser.Tag = "";
            this.tbUser.Text = "Username";
            this.tbUser.Click += new System.EventHandler(this.tbUser_Click);
            this.tbUser.Leave += new System.EventHandler(this.tbUser_Leave);
            // 
            // lbExceptionPassword
            // 
            this.lbExceptionPassword.AutoSize = true;
            this.lbExceptionPassword.ForeColor = System.Drawing.Color.Red;
            this.lbExceptionPassword.Location = new System.Drawing.Point(371, 388);
            this.lbExceptionPassword.Name = "lbExceptionPassword";
            this.lbExceptionPassword.Size = new System.Drawing.Size(195, 13);
            this.lbExceptionPassword.TabIndex = 73;
            this.lbExceptionPassword.Text = "Nhập khẩu bạn nhập không trùng khớp";
            this.lbExceptionPassword.Visible = false;
            // 
            // tmCheckInfoLogin
            // 
            this.tmCheckInfoLogin.Interval = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(283, 29);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 75;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Image = global::QuanLyGiaSu.Properties.Resources.password_24px3;
            this.pictureBox7.Location = new System.Drawing.Point(327, 355);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(33, 33);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 71;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::QuanLyGiaSu.Properties.Resources.email_open_50px;
            this.pictureBox1.Location = new System.Drawing.Point(327, 195);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::QuanLyGiaSu.Properties.Resources.password_24px2;
            this.pictureBox3.Location = new System.Drawing.Point(327, 303);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 66;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Image = global::QuanLyGiaSu.Properties.Resources.user_male_30px2;
            this.pictureBox2.Location = new System.Drawing.Point(327, 245);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 65;
            this.pictureBox2.TabStop = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 508);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbExceptionPassword);
            this.Controls.Add(this.lbExceptionUserName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.tbConfirmPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.lbUserType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterGiaSu";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbExceptionUserName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.TextBox tbConfirmPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbUserType;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label lbExceptionPassword;
        private System.Windows.Forms.Timer tmCheckInfoLogin;
    }
}